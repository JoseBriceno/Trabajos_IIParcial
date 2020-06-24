Public Class BolsasSolidarias

    Dim arreglo(100, 6) As String
    Dim contadorArreglo As Integer = 0
    Dim indice As String
    Dim caracteres As String
    Dim bolsa As String
    Dim arregloMunicipios(,) As String = {{"0101", "La Ceiba, Atlantida"}, {"0102", "El Porvenir, Atlantida"},
        {"0201", "Trujillo, Colon"}, {"0202", "Balfate, Colon"}, {"0301", "Comayagua, Comayagua"},
        {"0302", "Ajuterique, Comayagua"}, {"0401", "Santa Rosa, Copan"}, {"0402", "Cabañas, Copan"}, {"0501", "SPS, Cortes"},
        {"0502", "Choloma, Cortes"}, {"0601", "Choluteca, Choluteca"}, {"0602", "Apacilagua, Choloma"}, {"0701", "Yuscaran, El Paraiso"},
        {"0702", "Alauca, El Paraiso"}, {"0801", "Tegucigalpa, Francisco Morazan"}, {"0802", "Alubaren, Francisco Morazan"}, {"0901", "Puerto Lempira, Gracias a Dios"},
        {"0902", "Brus Laguna, Gracias a Dios"}, {"1001", "La Esperanza, Intibuca"}, {"1002", "Camasca,Intibuca"}, {"1101", "Roatan, Islas Bahia"},
        {"1102", "Guanaja, Islas Bahia"}, {"1201", "La Paz, La Paz"}, {"1202", "Aguanqueterique, La Paz"}, {"1301", "Gracias, Lempira"},
        {"1302", "Bele, Lempira"}, {"1401", "Nueva Ocotepeque, Ocotepeque"}, {"1402", "Belen Gualcho, Ocotepeque"}, {"1501", "Juticalpa, Olancho"},
        {"1502", "Campamento, Olancho"}, {"1601", "Santa Barbara, Santa Barbara"}, {"1602", "Arada, Santa Barbara"},
        {"1701", "Alianza, Valle"}, {"1702", "Amapala, Valle"}, {"1801", "Yoro, Yoro"}, {"1802", "Arenal, Yoro"}}


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub BolsasSolidarias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 5
        DataGridView1.Columns(0).Name = "IDENTIDAD"
        DataGridView1.Columns(1).Name = "NOMBRE"
        DataGridView1.Columns(2).Name = "BOLSA"
        DataGridView1.Columns(3).Name = "MUNICIPIO,DEPARTAMENTO"
        DataGridView1.Columns(4).Name = "ESTADO"


    End Sub

    Private Sub BTNLimpiar_Click(sender As Object, e As EventArgs) Handles BTNLimpiar.Click
        limpiar()
    End Sub

    Private Sub BTNIngresar_Click(sender As Object, e As EventArgs) Handles BTNIngresar.Click
        Dim nombre As String
        Dim identidad As String
        Dim integrantes As Integer
        Dim direccion As String

        If TxtNOMBRE.Text = "" Then
            MessageBox.Show("CAMPO VACIO")
        Else
            nombre = TxtNOMBRE.Text
        End If

        If TxtIdentidad.Text = "" Then
            MessageBox.Show("CAMPO VACIO")
        Else
            identidad = TxtIdentidad.Text
            caracteres = identidad.Substring(0, 4)
        End If

        If TxtIntegrantes.Text = 0 Then
            MessageBox.Show("CAMPO VACIO")
        Else
            integrantes = Val(TxtIntegrantes.Text)

            If integrantes <= 3 And integrantes >= 1 Then
                bolsa = "Basica"
            ElseIf integrantes > 3 Then
                bolsa = "Regular"
            End If

            If TxtDireccion.Text = "" Then
                MessageBox.Show("CAMPO VACIO")

            Else
                direccion = TxtDireccion.Text
            End If
        End If

        Dim repetido = 0
        For x As Integer = 0 To contadorArreglo Step 1
            If identidad = arreglo(x, 0) Then
                repetido = 1
            End If
        Next
        If repetido = 1 Then
            MessageBox.Show("Identidad repetida")
            limpiar()
        Else

            For x As Integer = 0 To 35 Step 1

                If arregloMunicipios(x, 0) = caracteres Then
                    arreglo(contadorArreglo, 0) = identidad
                    arreglo(contadorArreglo, 1) = nombre
                    arreglo(contadorArreglo, 2) = bolsa
                    arreglo(contadorArreglo, 3) = arregloMunicipios(x, 1)
                    arreglo(contadorArreglo, 4) = ComboEstado.SelectedItem.ToString
                    contadorArreglo = contadorArreglo + 1
                    DataGridView1.Rows.Add(identidad, nombre, bolsa, arregloMunicipios(x, 1), ComboEstado.SelectedItem.ToString)
                    limpiar()

                End If



            Next
        End If


    End Sub

    Private Sub BTNSalir_Click(sender As Object, e As EventArgs) Handles BTNSalir.Click
        Dim opcion As DialogResult
        opcion = MessageBox.Show("¿Desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If opcion = DialogResult.Yes Then
            Me.Close()
            Application.Exit()
        End If
    End Sub

    Private Sub TxtIdentidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIdentidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
    Private Sub limpiar()
        TxtNOMBRE.Text = ""
        TxtIntegrantes.Text = ""
        TxtIdentidad.Text = ""
        TxtDireccion.Text = ""
    End Sub

    Private Sub TxtIntegrantes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtIntegrantes.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub
End Class