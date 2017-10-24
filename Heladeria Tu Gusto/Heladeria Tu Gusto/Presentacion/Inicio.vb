﻿Public Class Inicio
    Dim contador As Integer = 0

    Sub PlayBackgroundSoundResource()
        My.Computer.Audio.Play(My.Resources.efecto, AudioPlayMode.Background)
    End Sub

    Private Sub timer_inicio_Tick(sender As Object, e As EventArgs) Handles timer_inicio.Tick
        If contador < 2 Then
            contador = contador + 1
        Else
            timer_inicio.Enabled = False
            EffectOut()
            Me.Hide()
            Principal.Show()
        End If
    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PlayBackgroundSoundResource()
        timer_inicio.Enabled = True
        timer_inicio.Interval = 1000
        EffectIn()

    End Sub

End Class