

update RunningFormat set LastNo=0;
delete from Address where AddressID<> 1;
delete from AttachFile where FileID > 2;
delete from History where HistoryID > 1 ;
delete from Currency where CurrencyID> 2 ;
delete from Privilege where PrivilegeID > 1 ;
delete from ApproveTX;
delete from ApproveUser;
delete from ApproveUserDtl ;
delete from CreditBalance ;
delete from CreditGroup ;

delete from OrdersDetail ;
delete from Pledge ;
delete from Orders ;
delete from ProductList ;

delete from BankAccount ;
delete from BankDocType ;
delete from Base_CustomerType ;
delete from BillMethod ;
delete from BusinessType ;
delete from Cheque ;
delete from CompanyType ;
delete from ContactRole ;
delete from CreditRole ;
delete from Customer ;
delete from Department ;
delete from EmpGroup ;
delete from Employee ;
delete from IndustryType ;
delete from InformPrice ;
delete from InformPriceBuy ;
delete from LeadType ;
delete from Note ;
delete from OppContactRole ;
delete from OppHistory ;
delete from Opportunity ;
delete from OpportunityStage ;
delete from OpportunityType ;
delete from Position ;
delete from Prefix ;
delete from Product ;
delete from Product_CostAVG ;
delete from Product_Location ;
delete from Product_LocationDTL ;
delete from Product_LocationS ;
delete from Product_ProductBrand ;
delete from Product_ProductCategory ;
delete from Product_ProductDimension ;
delete from Product_ProductGroup ;
delete from Product_ProductType ;
delete from Product_Stock ;
delete from Product_Unit ;
delete from Product_UOM ;

delete from ShipingBy ;
delete from ShipingMethod ;
delete from ShipingRule ;
delete from Source ;
delete from Territory ;
delete from TmpOrders ;
delete from TmpProductList ;
delete from VatType ;
 
delete from Bank ;
