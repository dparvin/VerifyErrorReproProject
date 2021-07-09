Imports System.Xml.Linq
Imports VerifyErrorReproProject
Imports VerifyTests
Imports VerifyXunit
Imports Xunit
Imports Xunit.Abstractions

Public Class BasicItemTest

    Inherits VerifyBase
    Private Property Output As ITestOutputHelper

    Private Property Settings As VerifySettings

    Public Sub New(ByVal outputHelper As ITestOutputHelper)

        MyBase.New()

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

        Verify(obj, Settings)

    End Sub

End Class
