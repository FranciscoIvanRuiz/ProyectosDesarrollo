Public Class Form_TiposDeLicencia
    Inherits DevComponents.DotNetBar.Office2007Form


   

    Private Sub Form_TiposDeLicencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        t_tipo.CharacterCasing = CharacterCasing.Upper
    End Sub

   
    Private Sub btn_guardar1_Click_1(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion As New Clase_TiposDeLicencia
        Dim datos As New Clase_Datos_TiposDeLicencia


        datos.tipo = t_tipo.Text

        If conexion.Insertar_TiposDeLicencia(datos) Then
            MessageBox.Show("los datos han sido guardados", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            t_tipo.Clear()
        Else
            MessageBox.Show("No se pudieron guardar los datos", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If (MsgBox("Desea salir?", MsgBoxStyle.YesNo, "Salir")) = MsgBoxResult.Yes Then
            t_tipo.Clear()
            Me.Close()
        End If

    End Sub
End Class