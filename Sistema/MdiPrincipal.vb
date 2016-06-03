Public Class FrmMdiPrincipal


#Region "VARIABLES"

#End Region

#Region "LOAD CLOSE FORMULARIO"

    Private Sub FrmMdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

#End Region

#Region "SUB FUNCTION"

    Public Sub AjustaMenu()
        Dim distancia As Integer = ContainerPrincipal.SplitterDistance
        If distancia > 60 Then
            ContainerPrincipal.SplitterDistance = 60
            pnlAbrirCerrarMenu.BackgroundImage = My.Resources._next
        Else
            pnlAbrirCerrarMenu.BackgroundImage = My.Resources.preview
            ContainerPrincipal.SplitterDistance = 219
        End If
    End Sub

#End Region

#Region "EVENTOS CONTROLADORES"

    Private Sub Panel2_Enter(sender As Object, e As EventArgs) Handles pnlAbrirCerrarMenu.Click
        AjustaMenu()
    End Sub


#End Region


End Class
