  Select Case mOrderType
         
            Case MasterType.ReceiptBuy
                cList.Add(New OrderType("ใบกำกับภาษี (ซื้อ)", MasterType.InvoiceBuy))
                cList.Add(New OrderType("ส่งของ (ซื้อ)", MasterType.ShipingBuy))
                cList.Add(New OrderType("บันทึกลดหนี้", MasterType.ReduceCreditBuy))
                cList.Add(New OrderType("ตั้งลูกหนี้", MasterType.AddCreditBuy))
                cList.Add(New OrderType("บันทึกค่าใช้จ่ายอื่นๆ", MasterType.Asset))
                cboOrderType.EditValue = MasterType.InvoiceBuy
              
            Case MasterType.ReduceCreditBuy, MasterType.AddCreditBuy
                cList.Add(New OrderType("ใบกำกับภาษี (ซื้อ)", MasterType.InvoiceBuy))
                cList.Add(New OrderType("ใบส่งของ (ซื้อ", MasterType.ShipingBuy))
                cboOrderType.EditValue = MasterType.InvoiceBuy
            Case MasterType.Asset
                cList.Add(New OrderType("ใบเสนอราคา", MasterType.Quotation))
                cboOrderType.EditValue = MasterType.Quotation