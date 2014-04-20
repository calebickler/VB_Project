Public Class EditCustomer

    Private Sub EditCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MembersTableAdapter.Fill(Me.EditMembers.Members, "")


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.MembersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.EditMembers)
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        BindingNavigatorDeleteItem.PerformClick()
    End Sub
End Class