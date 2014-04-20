Public Class AddItem

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If lstEntree.SelectedIndex() = -1 Then 
        Else
            intMenu(intCurrIndex) = (lstEntree.SelectedIndex())
            intCurrIndex = (intCurrIndex + 1)
            bolEntreeUpdate = True
        End If

        If lstApp.SelectedIndex() = -1 Then
        Else
            intMenu(intCurrIndex) = (lstApp.SelectedIndex() + intEntreeCount)
            intCurrIndex = (intCurrIndex + 1)
            bolAppUpdate = True
        End If

        If lstDessert.SelectedIndex() = -1 Then
        Else
            intMenu(intCurrIndex) = (lstDessert.SelectedIndex() + intEntreeCount + intAppitizerCount)
            intCurrIndex = (intCurrIndex + 1)
            bolDessertUpdate = True
        End If

        If (bolEntreeUpdate Or bolAppUpdate Or bolDessertUpdate) Then
            Me.Close()
        Else
            MessageBox.Show("Please select a menu item or close the form")
        End If
    End Sub

    Private Sub AddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intCount As Integer = 0
        While (intCount < intEntreeCount)
            lstEntree.Items.Add(getStrMenu(intCount))
            intCount = intCount + 1
        End While

        While (intCount < (intEntreeCount + intAppitizerCount))
            lstApp.Items.Add(getStrMenu(intCount))
            intCount = intCount + 1
        End While

        While (intCount < (intEntreeCount + intAppitizerCount + intDessertCount))
            lstDessert.Items.Add(getStrMenu(intCount))
            intCount = intCount + 1
        End While
    End Sub
End Class