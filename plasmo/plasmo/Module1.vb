Imports System.Data
Imports System.Data.SqlClient
Module dbconnection
    Public conn As New SqlConnection
    Public cmd As New SqlCommand
    Public reader As SqlDataReader
    Public ds As New DataSet
    Public adapter As New SqlDataAdapter


    Public query, user As String
End Module
