Imports System.Xml.Linq

Public Class BasicItem

    Public Sub New()
        Name = String.Empty
        Type = 0
        Setting = <root/>
    End Sub

    Public Property Name As String
    Public Property Type As Integer
    Public Property Setting As XElement

    Public Overrides Function ToString() As String

        Return $"Name = ""{Name}"", Type = {Type}, Setting = {Setting}"

    End Function
End Class
