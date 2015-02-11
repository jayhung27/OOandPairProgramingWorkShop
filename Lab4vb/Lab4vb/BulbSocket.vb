Public MustInherit Class BulbSocket
    Property SocketColor As Color
    Property AllowBulb As Type
    Property AllowColor As Color

    Property Functional As Boolean = True

    Property Bulb As Bulb
    Public Overridable Sub TurnOn()
        If IsBulbSocketBroken() Then
            Me.SocketColor = Color.gray
        End If

        If Not IsBulbInstalled() Then
            Me.SocketColor = Color.black
        End If

        If IsBulbBroken() Then
            Me.SocketColor = Color.green
        End If

        If IsBulbAllow() Then
            Me.SocketColor = Color.clear
        Else
            Me.SocketColor = Me.AllowColor
        End If
    End Sub


    Protected Overridable Function IsBulbAllow()
        If GetType(Bulb) = AllowBulb Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overridable Function IsBulbBroken()
        If Me.Bulb.Functional = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overridable Function IsBulbSocketBroken()
        If Me.Functional = False Then
            Return True
        Else
            Return False
        End If
    End Function

    Protected Overridable Function IsBulbInstalled()
        If Me.Bulb Is Nothing Then
            Return False
        Else
            Return True
        End If
    End Function



End Class
