<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_acreditados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.VwFIRAAcreditadosLayoutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AcreditadosDS = New Fira_Cartera_Pasiva.acreditadosDS()
        Me.Vw_FIRA_Acreditados_LayoutTableAdapter = New Fira_Cartera_Pasiva.acreditadosDSTableAdapters.Vw_FIRA_Acreditados_LayoutTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_Nacionalidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_amaterno = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_apaterno = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_rfc = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_curp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_tec = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_ventas = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txt_capital = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_empleados = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_scian = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_localidadinv = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_municipioinv = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_edoinv = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_ingreso = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_localidad = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_municipio = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txt_edo = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txt_cp = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_numint = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_numext = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_Calle = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.bt_Guardar = New System.Windows.Forms.Button()
        Me.CONTCPFacreditadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_acreditadoTableAdapter = New Fira_Cartera_Pasiva.acreditadosDSTableAdapters.CONT_CPF_acreditadoTableAdapter()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        CType(Me.VwFIRAAcreditadosLayoutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AcreditadosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.CONTCPFacreditadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.VwFIRAAcreditadosLayoutBindingSource
        Me.ComboBox1.DisplayMember = "nombre"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(351, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(312, 21)
        Me.ComboBox1.TabIndex = 0
        Me.ComboBox1.ValueMember = "Cliente"
        '
        'VwFIRAAcreditadosLayoutBindingSource
        '
        Me.VwFIRAAcreditadosLayoutBindingSource.DataMember = "Vw_FIRA_Acreditados_Layout"
        Me.VwFIRAAcreditadosLayoutBindingSource.DataSource = Me.AcreditadosDS
        '
        'AcreditadosDS
        '
        Me.AcreditadosDS.DataSetName = "acreditadosDS"
        Me.AcreditadosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Vw_FIRA_Acreditados_LayoutTableAdapter
        '
        Me.Vw_FIRA_Acreditados_LayoutTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Acreditado"
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(28, 45)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(272, 20)
        Me.txtcliente.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(348, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Selecciona un cliente de la lista"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_cliente)
        Me.GroupBox1.Controls.Add(Me.txt_Nacionalidad)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_amaterno)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_apaterno)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txt_rfc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txt_curp)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_tipo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 164)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Acreditado"
        '
        'txt_Nacionalidad
        '
        Me.txt_Nacionalidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Nacionalidad", True))
        Me.txt_Nacionalidad.Location = New System.Drawing.Point(459, 82)
        Me.txt_Nacionalidad.Name = "txt_Nacionalidad"
        Me.txt_Nacionalidad.Size = New System.Drawing.Size(99, 20)
        Me.txt_Nacionalidad.TabIndex = 13
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(369, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Nacionalidad"
        '
        'txt_amaterno
        '
        Me.txt_amaterno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "ApellidoMaterno", True))
        Me.txt_amaterno.Location = New System.Drawing.Point(579, 126)
        Me.txt_amaterno.Name = "txt_amaterno"
        Me.txt_amaterno.Size = New System.Drawing.Size(99, 20)
        Me.txt_amaterno.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(489, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Apellido Materno"
        '
        'txt_apaterno
        '
        Me.txt_apaterno.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "ApellidoPaterno", True))
        Me.txt_apaterno.Location = New System.Drawing.Point(362, 126)
        Me.txt_apaterno.Name = "txt_apaterno"
        Me.txt_apaterno.Size = New System.Drawing.Size(99, 20)
        Me.txt_apaterno.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Apellido Paterno"
        '
        'txt_nombre
        '
        Me.txt_nombre.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "NombreCliente", True))
        Me.txt_nombre.Location = New System.Drawing.Point(69, 126)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(192, 20)
        Me.txt_nombre.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 129)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre"
        '
        'txt_rfc
        '
        Me.txt_rfc.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "RFC", True))
        Me.txt_rfc.Location = New System.Drawing.Point(240, 78)
        Me.txt_rfc.Name = "txt_rfc"
        Me.txt_rfc.Size = New System.Drawing.Size(99, 20)
        Me.txt_rfc.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(197, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(28, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "RFC"
        '
        'txt_curp
        '
        Me.txt_curp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "CURP", True))
        Me.txt_curp.Location = New System.Drawing.Point(69, 78)
        Me.txt_curp.Name = "txt_curp"
        Me.txt_curp.Size = New System.Drawing.Size(99, 20)
        Me.txt_curp.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "CURP"
        '
        'txt_tipo
        '
        Me.txt_tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Tipo", True))
        Me.txt_tipo.Location = New System.Drawing.Point(69, 45)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.Size = New System.Drawing.Size(49, 20)
        Me.txt_tipo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo"
        '
        'txt_tec
        '
        Me.txt_tec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "TecProducion", True))
        Me.txt_tec.Location = New System.Drawing.Point(478, 62)
        Me.txt_tec.Name = "txt_tec"
        Me.txt_tec.Size = New System.Drawing.Size(99, 20)
        Me.txt_tec.TabIndex = 81
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(390, 62)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(83, 13)
        Me.Label29.TabIndex = 80
        Me.Label29.Text = "Tec Produccion"
        '
        'txt_ventas
        '
        Me.txt_ventas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "VentasNetas", True))
        Me.txt_ventas.Location = New System.Drawing.Point(103, 62)
        Me.txt_ventas.Name = "txt_ventas"
        Me.txt_ventas.Size = New System.Drawing.Size(99, 20)
        Me.txt_ventas.TabIndex = 79
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(13, 69)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(71, 13)
        Me.Label30.TabIndex = 78
        Me.Label30.Text = "Ventas Netas"
        '
        'txt_capital
        '
        Me.txt_capital.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "CapitalContable", True))
        Me.txt_capital.Location = New System.Drawing.Point(103, 91)
        Me.txt_capital.Name = "txt_capital"
        Me.txt_capital.Size = New System.Drawing.Size(99, 20)
        Me.txt_capital.TabIndex = 77
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(13, 98)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(84, 13)
        Me.Label31.TabIndex = 76
        Me.Label31.Text = "Capital Contable"
        '
        'txt_empleados
        '
        Me.txt_empleados.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "NumEmpleados", True))
        Me.txt_empleados.Location = New System.Drawing.Point(479, 34)
        Me.txt_empleados.Name = "txt_empleados"
        Me.txt_empleados.Size = New System.Drawing.Size(99, 20)
        Me.txt_empleados.TabIndex = 75
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(371, 36)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(102, 13)
        Me.Label32.TabIndex = 74
        Me.Label32.Text = "Núm. de Empleados"
        '
        'txt_clave
        '
        Me.txt_clave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "ClaveCadena", True))
        Me.txt_clave.Location = New System.Drawing.Point(103, 145)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(99, 20)
        Me.txt_clave.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 148)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 72
        Me.Label13.Text = "Clave Cadena"
        '
        'txt_scian
        '
        Me.txt_scian.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "SCIAN", True))
        Me.txt_scian.Location = New System.Drawing.Point(103, 121)
        Me.txt_scian.Name = "txt_scian"
        Me.txt_scian.Size = New System.Drawing.Size(99, 20)
        Me.txt_scian.TabIndex = 71
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(14, 124)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 13)
        Me.Label14.TabIndex = 70
        Me.Label14.Text = "SCIAN"
        '
        'txt_localidadinv
        '
        Me.txt_localidadinv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Localidad", True))
        Me.txt_localidadinv.Location = New System.Drawing.Point(480, 143)
        Me.txt_localidadinv.Name = "txt_localidadinv"
        Me.txt_localidadinv.Size = New System.Drawing.Size(99, 20)
        Me.txt_localidadinv.TabIndex = 69
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(390, 146)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 13)
        Me.Label15.TabIndex = 68
        Me.Label15.Text = "Localidad"
        '
        'txt_municipioinv
        '
        Me.txt_municipioinv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "MunicipioInversion", True))
        Me.txt_municipioinv.Location = New System.Drawing.Point(480, 114)
        Me.txt_municipioinv.Name = "txt_municipioinv"
        Me.txt_municipioinv.Size = New System.Drawing.Size(99, 20)
        Me.txt_municipioinv.TabIndex = 67
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(390, 117)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 66
        Me.Label16.Text = "Municipio"
        '
        'txt_edoinv
        '
        Me.txt_edoinv.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "EstadoInversion", True))
        Me.txt_edoinv.Location = New System.Drawing.Point(480, 88)
        Me.txt_edoinv.Name = "txt_edoinv"
        Me.txt_edoinv.Size = New System.Drawing.Size(99, 20)
        Me.txt_edoinv.TabIndex = 65
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(390, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(40, 13)
        Me.Label17.TabIndex = 64
        Me.Label17.Text = "Estado"
        '
        'txt_ingreso
        '
        Me.txt_ingreso.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "IngresoNeto", True))
        Me.txt_ingreso.Location = New System.Drawing.Point(103, 36)
        Me.txt_ingreso.Name = "txt_ingreso"
        Me.txt_ingreso.Size = New System.Drawing.Size(99, 20)
        Me.txt_ingreso.TabIndex = 63
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(68, 13)
        Me.Label18.TabIndex = 62
        Me.Label18.Text = "Ingreso Neto"
        '
        'txt_localidad
        '
        Me.txt_localidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Localidad", True))
        Me.txt_localidad.Location = New System.Drawing.Point(343, 63)
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(99, 20)
        Me.txt_localidad.TabIndex = 61
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(296, 66)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 13)
        Me.Label19.TabIndex = 60
        Me.Label19.Text = "Localidad"
        '
        'txt_municipio
        '
        Me.txt_municipio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Municipio", True))
        Me.txt_municipio.Location = New System.Drawing.Point(228, 102)
        Me.txt_municipio.Name = "txt_municipio"
        Me.txt_municipio.Size = New System.Drawing.Size(99, 20)
        Me.txt_municipio.TabIndex = 59
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(181, 105)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 13)
        Me.Label20.TabIndex = 58
        Me.Label20.Text = "Municipio"
        '
        'txt_edo
        '
        Me.txt_edo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Estado", True))
        Me.txt_edo.Location = New System.Drawing.Point(60, 99)
        Me.txt_edo.Name = "txt_edo"
        Me.txt_edo.Size = New System.Drawing.Size(99, 20)
        Me.txt_edo.TabIndex = 57
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 102)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 56
        Me.Label21.Text = "Estado"
        '
        'txt_cp
        '
        Me.txt_cp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "cp", True))
        Me.txt_cp.Location = New System.Drawing.Point(60, 66)
        Me.txt_cp.Name = "txt_cp"
        Me.txt_cp.Size = New System.Drawing.Size(99, 20)
        Me.txt_cp.TabIndex = 55
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 13)
        Me.Label22.TabIndex = 54
        Me.Label22.Text = "CP"
        '
        'txt_numint
        '
        Me.txt_numint.Location = New System.Drawing.Point(602, 30)
        Me.txt_numint.Name = "txt_numint"
        Me.txt_numint.Size = New System.Drawing.Size(43, 20)
        Me.txt_numint.TabIndex = 53
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(529, 37)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "Núm. Interiro"
        '
        'txt_numext
        '
        Me.txt_numext.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "PLD_Numext", True))
        Me.txt_numext.Location = New System.Drawing.Point(448, 34)
        Me.txt_numext.Name = "txt_numext"
        Me.txt_numext.Size = New System.Drawing.Size(59, 20)
        Me.txt_numext.TabIndex = 51
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(358, 37)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Núm. Exterior"
        '
        'txt_Calle
        '
        Me.txt_Calle.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Calle", True))
        Me.txt_Calle.Location = New System.Drawing.Point(53, 26)
        Me.txt_Calle.Name = "txt_Calle"
        Me.txt_Calle.Size = New System.Drawing.Size(285, 20)
        Me.txt_Calle.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(30, 13)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Calle"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_Calle)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txt_numext)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txt_numint)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txt_cp)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txt_edo)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txt_municipio)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_localidad)
        Me.GroupBox2.Location = New System.Drawing.Point(26, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(711, 133)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Dirección"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txt_ingreso)
        Me.GroupBox3.Controls.Add(Me.txt_tec)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label29)
        Me.GroupBox3.Controls.Add(Me.txt_edoinv)
        Me.GroupBox3.Controls.Add(Me.txt_ventas)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Controls.Add(Me.txt_municipioinv)
        Me.GroupBox3.Controls.Add(Me.txt_capital)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label31)
        Me.GroupBox3.Controls.Add(Me.txt_localidadinv)
        Me.GroupBox3.Controls.Add(Me.txt_empleados)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label32)
        Me.GroupBox3.Controls.Add(Me.txt_scian)
        Me.GroupBox3.Controls.Add(Me.txt_clave)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Location = New System.Drawing.Point(26, 408)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(711, 189)
        Me.GroupBox3.TabIndex = 83
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Inversión"
        '
        'bt_Guardar
        '
        Me.bt_Guardar.Location = New System.Drawing.Point(756, 576)
        Me.bt_Guardar.Name = "bt_Guardar"
        Me.bt_Guardar.Size = New System.Drawing.Size(84, 21)
        Me.bt_Guardar.TabIndex = 84
        Me.bt_Guardar.Text = "Guardar"
        Me.bt_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_Guardar.UseVisualStyleBackColor = True
        Me.bt_Guardar.UseWaitCursor = True
        '
        'CONTCPFacreditadoBindingSource
        '
        Me.CONTCPFacreditadoBindingSource.DataMember = "CONT_CPF_acreditado"
        Me.CONTCPFacreditadoBindingSource.DataSource = Me.AcreditadosDS
        '
        'CONT_CPF_acreditadoTableAdapter
        '
        Me.CONT_CPF_acreditadoTableAdapter.ClearBeforeFill = True
        '
        'txt_cliente
        '
        Me.txt_cliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwFIRAAcreditadosLayoutBindingSource, "Cliente", True))
        Me.txt_cliente.Location = New System.Drawing.Point(579, 19)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(99, 20)
        Me.txt_cliente.TabIndex = 14
        '
        'frm_acreditados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(873, 609)
        Me.Controls.Add(Me.bt_Guardar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcliente)
        Me.Controls.Add(Me.ComboBox1)
        Me.Name = "frm_acreditados"
        Me.Text = "frm_acreditados"
        CType(Me.VwFIRAAcreditadosLayoutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AcreditadosDS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.CONTCPFacreditadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AcreditadosDS As acreditadosDS
    Friend WithEvents VwFIRAAcreditadosLayoutBindingSource As BindingSource
    Friend WithEvents Vw_FIRA_Acreditados_LayoutTableAdapter As acreditadosDSTableAdapters.Vw_FIRA_Acreditados_LayoutTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_Nacionalidad As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_amaterno As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_apaterno As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_rfc As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_curp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_tipo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_tec As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_ventas As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents txt_capital As TextBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_empleados As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_scian As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_localidadinv As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txt_municipioinv As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txt_edoinv As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_ingreso As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_localidad As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txt_municipio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_edo As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txt_cp As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents txt_numint As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_numext As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_Calle As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents bt_Guardar As Button
    Friend WithEvents CONTCPFacreditadoBindingSource As BindingSource
    Friend WithEvents CONT_CPF_acreditadoTableAdapter As acreditadosDSTableAdapters.CONT_CPF_acreditadoTableAdapter
    Friend WithEvents txt_cliente As TextBox
End Class
