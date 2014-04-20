Public Class SelectCustomer


    Private Sub SelectCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MembersTableAdapter1.Fill(Me.EditMembers.Members, "")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Test As DataGridViewRow = (MembersDataGridView.SelectedRows(0))
            strLastName = ""
            strFirstName = ""
            strAddress = ""
            strCity = ""
            strState = ""
            strZip = ""
            strCountry = ""
            strPhone = ""

        Try
            strLastName = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(0).Value)
        Catch ex As Exception
        End Try

        Try
            strFirstName = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(1).Value)
        Catch ex As Exception
        End Try

        Try
            strAddress = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(2).Value)
        Catch ex As Exception
        End Try

        Try
            strCity = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(3).Value)
        Catch ex As Exception
        End Try

        Try
            strState = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(4).Value)
        Catch ex As Exception
        End Try

        Try
            strZip = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(5).Value)
        Catch ex As Exception
        End Try

        Try
            strCountry = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(6).Value)
        Catch ex As Exception
        End Try

        Try
            strPhone = CStr(MembersDataGridView.Rows(MembersDataGridView.SelectedRows(0).Index).Cells(7).Value)
        Catch ex As Exception
        End Try
        Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please select a entire row, click to the left of the row to select all")
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.MembersTableAdapter1.Fill(Me.EditMembers.Members, txtLastName.Text)
    End Sub
End Class