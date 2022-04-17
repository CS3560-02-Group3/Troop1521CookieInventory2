﻿Imports MySql.Data.MySqlClient

Public Class mainMenu
    Private Sub mainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conn As New myConnection()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter("SELECT `firstName`, `lastName`, `address`, `email`, `phone`, `grade`, `note` FROM `user`", conn.getConnection())

        adapter.Fill(table)

        DataGridView1.DataSource = table
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex = -1 Then
            Return
        End If
        mainMenu_Load(e, e)
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(e.RowIndex)
        Dim myForm As New userForm
        myForm.firstNameTB.Text = selectedRow.Cells(0).Value
        myForm.lastNameTB.Text = selectedRow.Cells(1).Value
        myForm.addressTB.Text = selectedRow.Cells(2).Value
        myForm.emailTB.Text = selectedRow.Cells(3).Value
        myForm.phoneTB.Text = selectedRow.Cells(4).Value
        myForm.gradeTB.Text = selectedRow.Cells(5).Value
        myForm.noteTE.Text = selectedRow.Cells(6).Value
        myForm.Show()

    End Sub
End Class