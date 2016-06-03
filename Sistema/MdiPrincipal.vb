Public Class FrmMdiPrincipal


#Region "VARIABLES"

#End Region

#Region "LOAD CLOSE FORMULARIO"

    Private Sub FrmMdiPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MuestraTabForm()
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

    Public Sub MuestraTabForm()
        Dim myTabPage As New TabPage()
        myTabPage.Text = "Prueba "
        TabPrincipal.TabPages.Add(myTabPage)
    End Sub

    Public Sub CerrarTab()
        TabPrincipal.SelectedTab.Name.ToString()
    End Sub

#End Region

#Region "EVENTOS CONTROLADORES"

    Private Sub Panel2_Enter(sender As Object, e As EventArgs) Handles pnlAbrirCerrarMenu.Click
        AjustaMenu()
    End Sub


#End Region

    Private Sub CerrarTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTabToolStripMenuItem.Click
        Dim valor As String = Nothing
        Dim valor1 As String = Nothing

        valor = sender.Name
        'CerrarTab()
    End Sub
End Class
