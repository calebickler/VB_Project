Public Class Receipt

    Private Sub Receipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intCounter As Integer = 0
        lstReceipt.Items.Add("----------------------------Spaghetti's Restaurant----------------------------")
        lstReceipt.Items.Add("")
        While intCounter < intCurrIndex
            lstReceipt.Items.Add(getStrMenu(intMenu(intCounter).ToString()))
            intCounter = intCounter + 1
        End While
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("--------------------------------------------------------------------------------------------")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("Sub Total:                                                          " + dblSubPrice.ToString("c"))
        lstReceipt.Items.Add("Tax:                                                                   " + dblTax.ToString("c"))
        lstReceipt.Items.Add("Total:                                                                 " + dblTotal.ToString("c"))
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add("--------------------------------------------------------------------------------------------")
        lstReceipt.Items.Add("")
        lstReceipt.Items.Add(strFirstName)
        lstReceipt.Items.Add(strLastName)
        lstReceipt.Items.Add(strAddress)
        lstReceipt.Items.Add(strCity)
        lstReceipt.Items.Add(strState)
        lstReceipt.Items.Add(strZip)
        lstReceipt.Items.Add(strPhone)
        Me.Focus()
    End Sub
End Class