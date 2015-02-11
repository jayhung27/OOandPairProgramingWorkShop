Public Class BulbSocketMars
    Inherits BulbSocket

    Public Sub New()
        Me.AllowBulb = GetType(BulbMars)
        Me.AllowColor = Color.red
    End Sub

End Class
