Imports System.Data.OleDb



Public Class Form1

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\kelus\Documents\Database4.accdb"
    Dim con As New OleDbConnection

    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand
    Dim tables As DataTableCollection


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnDisplay_Click(sender, e)
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        con = New OleDbConnection
        con.ConnectionString = conString
        ds = New DataSet
        tables = ds.Tables
        ds.Clear()
        adp = New OleDbDataAdapter("select * from Student", con)
        adp.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        con.ConnectionString = conString
        con.Open()
        Dim cmd As New OleDbCommand
        If String.IsNullOrEmpty(txtName.Text) Then
            btnDisplay_Click(sender, e)
        Else
            cmd = New OleDbCommand("Insert into Student values( '" + txtId.Text + "','" + txtName.Text + "')", con)
            cmd.ExecuteNonQuery()
            MsgBox("Bhai Thai Gyu!!")
            btnDisplay_Click(sender, e)
        End If


    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        con.ConnectionString = conString
        con.Open()
        Dim cmd As New OleDbCommand
        Dim s As String
        s = InputBox("Enter Name want to delete:")
        If String.IsNullOrEmpty(s) Then
            btnDisplay_Click(sender, e)
        Else
            cmd = New OleDbCommand("delete * from Student where Name='" + s + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Query Deleted!")
            btnDisplay_Click(sender, e)
        End If




    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        con.ConnectionString = conString
        con.Open()
        Dim cmd As New OleDbCommand
        Dim s As String
        Dim s2 As String
        s = InputBox("Enter Name want to Update:")

        If String.IsNullOrEmpty(s) Then
            btnDisplay_Click(sender, e)
        Else
            s2 = InputBox("Enter New Name:")
            cmd = New OleDbCommand("update Student set Name = '" + s2 + "' where Name='" + s + "'", con)
            cmd.ExecuteNonQuery()
            MsgBox("Query Updated!")
            btnDisplay_Click(sender, e)

        End If



    End Sub
End Class
