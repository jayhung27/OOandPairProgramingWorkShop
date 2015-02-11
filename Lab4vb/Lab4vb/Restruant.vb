Public Class Restruant
    Public restruantName As String
    Public allSocket As New List(Of BulbSocket)


    Public Sub TurnOn()

        For Each socket In allSocket
            socket.TurnOn()
        Next

    End Sub

End Class
