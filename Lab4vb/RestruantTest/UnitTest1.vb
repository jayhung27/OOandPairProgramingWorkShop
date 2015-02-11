Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Lab4vb

<TestClass()> Public Class UnitTest1


    <TestInitialize>
    Public Sub Init()


    End Sub

    <TestMethod>
    Public Sub TrunOnTest()
        Dim venus As New Restruant
        Dim tempLst As New List(Of BulbSocket)
        For i As Integer = 0 To 149 Step 1
            Dim socket As New BulbSocketVenus
            If i = 3 Then
                socket.Bulb = New BulbMars
            Else
                socket.Bulb = New BulbVenus
            End If

            tempLst.Add(socket)
        Next

        venus.TurnOn()

        For Each socket As BulbSocket In venus.allSocket
            Assert.AreEqual(Color.clear, socket.SocketColor)
        Next

    End Sub


    '<TestMethod()> Public Sub LightTest()
    '    Dim lights As List(Of BulbSocket)
    '    For i = 1 To 150
    '        Dim venSocket As New BulbSocket
    '        venSocket.bulb.lightColor = "yellow"
    '        venus.allSocket.Add(venSocket)
    '    Next
    '    lights = venus.TurnOn()
    '    For Each light In lights
    '        Assert.AreEqual("yellow", light.bulb.lightColor)
    '    Next
    'End Sub

    '<TestMethod()> Public Sub WrongBulb()
    '    Dim lstSocket As List(Of BulbSocket)
    '    For i = 1 To 150
    '        Dim venSocket As New BulbSocket
    '        venSocket.bulb.lightColor = "red"
    '        venus.allSocket.Add(venSocket)
    '    Next
    '    lstSocket = venus.TurnOn
    '    For Each socketColor In lstSocket
    '        Assert.AreEqual(venus.allowColor, socketColor.socketColor)
    '    Next
    'End Sub
    '<TestMethod()> Public Sub RightBulb()
    '    venus.allowColor = "yellow"
    '    Dim lstSocket As List(Of BulbSocket)
    '    For i = 1 To 150
    '        Dim venSocket As New BulbSocket
    '        venSocket.bulb.lightColor = "yellow"
    '        venus.allSocket.Add(venSocket)
    '    Next
    '    lstSocket = venus.TurnOn
    '    For Each socketColor In lstSocket
    '        Assert.AreEqual("clear", socketColor.socketColor)
    '    Next
    'End Sub





End Class