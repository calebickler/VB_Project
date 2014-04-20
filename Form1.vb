Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If intCurrIndex > 40 Then
            MessageBox.Show("Your order is full please remove an item to add another")
        Else
            Dim frmAddItem As New AddItem
            frmAddItem.ShowDialog()

            If bolEntreeUpdate Then
                If bolDessertUpdate And bolAppUpdate Then
                    lstItems.Items.Add(getStrMenu(intMenu(intCurrIndex - 3).ToString()))
                    dblSubPrice = dblSubPrice + getPriceMenu(intMenu(intCurrIndex - 3))
                Else
                    lstItems.Items.Add(getStrMenu(intMenu(intCurrIndex - 1).ToString()))
                    dblSubPrice = dblSubPrice + getPriceMenu(intMenu(intCurrIndex - 1))
                End If
                If (bolDessertUpdate Xor bolAppUpdate) Then
                    lstItems.Items.Add(getStrMenu(intMenu(intCurrIndex - 2).ToString()))
                    dblSubPrice = dblSubPrice + getPriceMenu(intMenu(intCurrIndex - 2))
                End If
            End If

            If bolAppUpdate Then
                If bolDessertUpdate Then
                    lstItems.Items.Add(getStrMenu(intMenu(intCurrIndex - 2).ToString()))
                    dblSubPrice = dblSubPrice + getPriceMenu(intMenu(intCurrIndex - 2))
                Else
                    lstItems.Items.Add(getStrMenu(intMenu(intCurrIndex - 1).ToString()))
                    dblSubPrice = dblSubPrice + getPriceMenu(intMenu(intCurrIndex - 1))
                End If
            End If

            If bolDessertUpdate Then
                lstItems.Items.Add(getStrMenu(intMenu(intCurrIndex - 1).ToString()))
                dblSubPrice = dblSubPrice + getPriceMenu(intMenu(intCurrIndex - 1))
            End If

            bolDessertUpdate = False
            bolAppUpdate = False
            bolEntreeUpdate = False
            lblSubTotal.Text = dblSubPrice.ToString("c")
            dblTax = (dblSubPrice * dblTaxRate)
            lblTax.Text = dblTax.ToString("c")
            dblTotal = dblSubPrice + dblTax
            lblTotal.Text = dblTotal.ToString("c")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If lstItems.SelectedIndex = -1 Then
            MessageBox.Show("Please select a feild to remove")
        Else
            Remove(lstItems.SelectedIndex)
        End If
        lstItems.Items.Clear()
        Dim intCounter As Integer = 0
        dblSubPrice = 0
        While intCounter < intCurrIndex
            lstItems.Items.Add(getStrMenu(intMenu(intCounter).ToString()))
            dblSubPrice = dblSubPrice + getPriceMenu(intMenu(intCounter))
            intCounter = intCounter + 1
        End While
        lblSubTotal.Text = dblSubPrice.ToString("c")
        dblTax = (dblSubPrice * dblTaxRate)
        lblTax.Text = dblTax.ToString("c")
        dblTotal = dblSubPrice + dblTax
        lblTotal.Text = dblTotal.ToString("c")
    End Sub

    Private Sub EditCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCustomersToolStripMenuItem.Click
        Dim frmEditCustomer As New EditCustomer
        frmEditCustomer.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim frmSelectCustomer As New SelectCustomer
        frmSelectCustomer.ShowDialog()

        lblAddress.Text = strAddress
        lblCity.Text = strCity
        lblCountry.Text = strCountry
        lblFirstName.Text = strFirstName
        lblLastName.Text = strLastName
        lblPhone.Text = strPhone
        lblState.Text = strState
        lblZip.Text = strZip
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frmReceipt As New Receipt
        frmReceipt.ShowDialog()
    End Sub

End Class
