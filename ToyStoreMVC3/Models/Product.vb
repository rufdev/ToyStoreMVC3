Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations

Public Class Product
    Public Property Id() As Integer

    <Required()>
    Public Property Name() As String
    <Required()>
    Public Property Description() As String
    Public Property Price() As Double
End Class

Public Class ProductDBContext
    Inherits DbContext
    Public Property Products() As DbSet(Of Product)
End Class
