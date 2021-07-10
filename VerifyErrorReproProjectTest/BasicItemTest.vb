Imports System.Xml.Linq
Imports VerifyErrorReproProject
Imports Xunit
Imports Xunit.Abstractions

Public Class BasicItemTest

    Private Property Output As ITestOutputHelper

    Public Sub New(ByVal outputHelper As ITestOutputHelper)

        Output = outputHelper

    End Sub

    <Fact>
    Public Sub BasicItemTest()

        Dim obj As New BasicItem()

        With obj
            .Name = "TestItem"
            .Type = 55
            .Setting.Add(New XElement("TestItem"))
        End With

        Output.WriteLine("obj: " & obj.ToString())

    End Sub

End Class
