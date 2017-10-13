Module Transicion
    Public Sub EffectIn()
        Dim Effect As Double
        For Effect = 0.0 To 1.1 Step 0.1
            Inicio.Opacity = Effect

            Inicio.Refresh()

            Threading.Thread.Sleep(50)
        Next
    End Sub
    Public Sub EffectOut()
        Dim Effect As Double
        For Effect = 1.1 To 0.0 Step -0.1
            Inicio.Opacity = Effect
            Inicio.Refresh()
            Threading.Thread.Sleep(50)
        Next
    End Sub
End Module
