

with Orders as (
SELECT [Employee].TerritoryID,[Territory].NameThai as TerritoryName, [Orders].EmpID,[EmpCode],Title + Firstname + ' ' + LastName AS EmpName,[Territory].CommissionID
,OrderDate,case when Orders.TableID=55 then Total *-1 else Total end Total 
FROM [dbo].[Orders]
INNER JOIN [dbo].[Employee] on [Orders].EmpID = [Employee].EmpID and [Employee].IsDelete=0
INNER JOIN [dbo].[Territory] on [Territory].TerritoryID = [Employee].TerritoryID and [Territory].IsDelete=0
WHERE Orders.IsDelete =0 AND Orders.IsCancel = 0  and Orders.TableID in(39,41,54,55)
and OrderDate between '2021-01-01' and '2023-01-31'
)

,Comm as (
 
SELECT [Commission].CommissionID
,[Commission].CommissionType,[Commission].Subject,[Commission].StartDate,[Commission].ExpireDate
,[CommissionDtl].SEQ,[CommissionDtl].AmountFrom,[CommissionDtl].AmountEnd,[CommissionDtl].ComPercen,[CommissionDtl].ComAmount
,isnull(PreComm.AmountEnd,0) as PreAmountEnd
,isnull(NextComm.AmountEnd,0) as NextAmountEnd

FROM  [dbo].[Commission] 
INNER JOIN [dbo].[CommissionDtl] on [Commission].[CommissionID]=[CommissionDtl].[CommissionID]
LEFT OUTER JOIN (
			SELECT CommissionID,SEQ,AmountEnd as AmountEnd  FROM [dbo].[CommissionDtl]		
			) PreComm on PreComm.CommissionID=[Commission].CommissionID and [CommissionDtl].SEQ-1=PreComm.SEQ
LEFT OUTER JOIN (
			SELECT CommissionID,SEQ,AmountEnd as AmountEnd  FROM [dbo].[CommissionDtl]  			
			) NextComm on NextComm.CommissionID=[Commission].CommissionID and [CommissionDtl].SEQ+1=NextComm.SEQ
WHERE [Commission].IsDelete=0 
 
)

,CommByGroup as (
SELECT TerritoryID,TerritoryName 
,max(OrderTotal)GroupTotal
--,StartDate
--,ExpireDate
--,CommissionType
--,Subject,SEQ,AmountFrom,AmountEnd
--,ComPercen,ComAmount,AmountTocal
,sum(case when AmountTocal > 0 and CommissionType=1 then (AmountTocal * ComPercen)/100
when AmountTocal > 0 and CommissionType=2 then ComAmount
else 0 end )Commisstion
 FROM(
	SELECT Orders.TerritoryID,Orders.TerritoryName ,SUM([Orders].Total) OrderTotal
	,comm.StartDate,comm.ExpireDate,CommissionType
	,Comm.Subject,Comm.SEQ,Comm.AmountFrom,Comm.AmountEnd,Comm.PreAmountEnd,Comm.ComPercen,Comm.ComAmount
	,case when SUM([Orders].Total)> 0 and Comm.AmountFrom=0 and  SUM([Orders].Total) < Comm.AmountEnd then  SUM([Orders].Total)
	 when SUM([Orders].Total)> Comm.AmountEnd and Comm.NextAmountEnd >0  then  Comm.AmountEnd-Comm.PreAmountEnd  
	 when SUM([Orders].Total)> Comm.AmountEnd and Comm.NextAmountEnd =0  then  SUM([Orders].Total)-Comm.PreAmountEnd 
	 when SUM([Orders].Total)< Comm.AmountEnd and SUM([Orders].Total)> Comm.AmountFrom then  SUM([Orders].Total)-Comm.PreAmountEnd 
	 else 0 end AmountTocal
	FROM Orders 
	LEFT OUTER JOIN Comm on Orders.CommissionID=Comm.CommissionID  AND [Orders].OrderDate between Comm.StartDate and Comm.ExpireDate
	GROUP BY  Orders.TerritoryID,Orders.TerritoryName 
	,comm.StartDate,comm.ExpireDate,CommissionType
	,Comm.Subject,Comm.SEQ,Comm.AmountFrom,Comm.AmountEnd,Comm.PreAmountEnd,Comm.NextAmountEnd,Comm.ComPercen,Comm.ComAmount
) as tmp 
group by TerritoryID,TerritoryName 
--,OrderTotal
--,StartDate
--,ExpireDate
--,CommissionType
--,Subject,SEQ,AmountFrom,AmountEnd
--,ComPercen,ComAmount,AmountTocal
)

--select * from CommByGroup


 
SELECT Orders.TerritoryID,Orders.TerritoryName, Orders.EmpID,Orders.EmpCode,Orders.EmpName
,SUM([Orders].Total) EmpTotal,CommByGroup.GroupTotal
,(SUM([Orders].Total) /CommByGroup.GroupTotal) as TotalRatio 
,CommByGroup.Commisstion
,CommByGroup.Commisstion * (SUM([Orders].Total) /CommByGroup.GroupTotal) as EmpComm
FROM Orders 
LEFT OUTER JOIN CommByGroup on Orders.TerritoryID=CommByGroup.TerritoryID   
GROUP BY   Orders.TerritoryID,Orders.TerritoryName,Orders.EmpID,Orders.EmpCode,Orders.EmpName ,CommByGroup.GroupTotal,CommByGroup.Commisstion
ORDER BY   Orders.TerritoryID,Orders.TerritoryName,Orders.EmpID