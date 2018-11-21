<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_contrato2
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
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lb_ciclo = New System.Windows.Forms.TabPage()
        Me.BT_IMPRIMIR = New System.Windows.Forms.Button()
        Me.cb_gl = New System.Windows.Forms.ComboBox()
        Me.CONTCPFGLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescuentosDS = New Fira_Cartera_Pasiva.DescuentosDS()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CK_FONAGA = New System.Windows.Forms.CheckBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.TXT_EFEC = New System.Windows.Forms.TextBox()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.ch_pen = New System.Windows.Forms.CheckBox()
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.txt_tiie = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cksubsidio = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.PCXSG_TXT = New System.Windows.Forms.TextBox()
        Me.TXT_FN = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TXT_FB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_aportacion = New System.Windows.Forms.TextBox()
        Me.TxtIntermediario = New System.Windows.Forms.TextBox()
        Me.Lb_id_contrato = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cb_periodo_revision = New System.Windows.Forms.ComboBox()
        Me.CONTCPFperiodicidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_periodo_int = New System.Windows.Forms.ComboBox()
        Me.cb_periodo_capital = New System.Windows.Forms.ComboBox()
        Me.txt_acreditado = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.cb_prestamo = New System.Windows.Forms.ComboBox()
        Me.CONTCPFtipoprestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_operacion = New System.Windows.Forms.ComboBox()
        Me.CONTCPFoperacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label62 = New System.Windows.Forms.Label()
        Me.cb_estatus = New System.Windows.Forms.ComboBox()
        Me.CONTCPFESTATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cb_intermediario = New System.Windows.Forms.ComboBox()
        Me.CONTCPFintermediariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_BP = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.txt_nvsm = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cb_tasa = New System.Windows.Forms.ComboBox()
        Me.CONTCPFtipotasasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_esquema = New System.Windows.Forms.ComboBox()
        Me.CONTCPFesquemacobroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_seguro = New System.Windows.Forms.ComboBox()
        Me.CONTCPFsegurosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_socios = New System.Windows.Forms.TextBox()
        Me.cb_divisa = New System.Windows.Forms.ComboBox()
        Me.CONTCPFdivisasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.cb_sucursal = New System.Windows.Forms.ComboBox()
        Me.CONTCPFsucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_id_contrato_siiof = New System.Windows.Forms.TextBox()
        Me.txt_autorizacion = New System.Windows.Forms.TextBox()
        Me.txt_credito = New System.Windows.Forms.TextBox()
        Me.cb_producto = New System.Windows.Forms.ComboBox()
        Me.CONTCPFproductosfiraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ch_ifnd = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_clasificacion = New System.Windows.Forms.ComboBox()
        Me.CONTCPFclasificaciongarantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txt_egresos = New System.Windows.Forms.TextBox()
        Me.cb_concepto = New System.Windows.Forms.ComboBox()
        Me.CONTCPFconceptosinversionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_localidad = New System.Windows.Forms.TextBox()
        Me.cb_periodo = New System.Windows.Forms.ComboBox()
        Me.CONTCPFperiodicidadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txt_estrato = New System.Windows.Forms.TextBox()
        Me.dt_febalance = New System.Windows.Forms.DateTimePicker()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_fondo = New System.Windows.Forms.TextBox()
        Me.txt_sieban = New System.Windows.Forms.TextBox()
        Me.txt_programaespecial = New System.Windows.Forms.TextBox()
        Me.cb_programa = New System.Windows.Forms.ComboBox()
        Me.CONTCPFprogramasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cb_cadena = New System.Windows.Forms.ComboBox()
        Me.CONTCPFcadenasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_subrama = New System.Windows.Forms.ComboBox()
        Me.CONTCPFsubramasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_rama = New System.Windows.Forms.ComboBox()
        Me.CONTCPFramasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_actividad = New System.Windows.Forms.ComboBox()
        Me.CONTCPFactividadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.txt_utilidad = New System.Windows.Forms.TextBox()
        Me.txt_ingresos = New System.Windows.Forms.TextBox()
        Me.txt_activototal = New System.Windows.Forms.TextBox()
        Me.txt_activofijo = New System.Windows.Forms.TextBox()
        Me.txt_capital = New System.Windows.Forms.TextBox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_ingresoneto = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.cb_medida = New System.Windows.Forms.ComboBox()
        Me.CONTCPFunidadesmedidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_clave = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txt_capacidad = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_jornales = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.cb_clase = New System.Windows.Forms.ComboBox()
        Me.VwconceptosinversionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GENProductosFinagilBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbclientes = New System.Windows.Forms.ComboBox()
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ClientesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.ClientesTableAdapter()
        Me.CONT_CPF_intermediariosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_intermediariosTableAdapter()
        Me.CONT_CPF_operacionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_operacionTableAdapter()
        Me.CONT_CPF_productos_firaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter()
        Me.CONT_CPF_sucursalesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_sucursalesTableAdapter()
        Me.CONT_CPF_divisasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter()
        Me.CONT_CPF_segurosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_segurosTableAdapter()
        Me.CONT_CPF_esquema_cobroTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_esquema_cobroTableAdapter()
        Me.CONT_CPF_tipo_tasasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipo_tasasTableAdapter()
        Me.CONT_CPF_ESTATUSTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ESTATUSTableAdapter()
        Me.CONT_CPF_clasificacion_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_clasificacion_garantiasTableAdapter()
        Me.CONT_CPF_periodicidadTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_periodicidadTableAdapter()
        Me.CONT_CPF_unidades_medidaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_unidades_medidaTableAdapter()
        Me.CONT_CPF_actividadTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_actividadTableAdapter()
        Me.CONT_CPF_ramasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ramasTableAdapter()
        Me.CONT_CPF_subramasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_subramasTableAdapter()
        Me.CONT_CPF_cadenasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_cadenasTableAdapter()
        Me.CONT_CPF_programasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_programasTableAdapter()
        Me.Vw_conceptos_inversionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_conceptos_inversionTableAdapter()
        Me.ViewcadenassubramasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.View_cadenas_subramasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.View_cadenas_subramasTableAdapter()
        Me.CONT_CPF_tipoprestamosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipoprestamosTableAdapter()
        Me.CONTCPFconceptosinversionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_conceptos_inversionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_conceptos_inversionTableAdapter()
        Me.GEN_ProductosFinagilTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.GEN_ProductosFinagilTableAdapter()
        Me.CONTCPFconfiguracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_configuracionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter()
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.DS_contratos1 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.CONTCPFministracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_ministracionesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter()
        Me.CONTCPFvencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CONT_CPF_GLTableAdapter = New Fira_Cartera_Pasiva.DescuentosDSTableAdapters.CONT_CPF_GLTableAdapter()
        Me.TabControl1.SuspendLayout()
        Me.lb_ciclo.SuspendLayout()
        CType(Me.CONTCPFGLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFperiodicidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFtipoprestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFoperacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFESTATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFintermediariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFtipotasasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFesquemacobroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFsegurosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFdivisasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFsucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFproductosfiraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFclasificaciongarantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CONTCPFconceptosinversionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFperiodicidadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFprogramasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcadenasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFsubramasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFramasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFactividadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFunidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VwconceptosinversionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GENProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewcadenassubramasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFconceptosinversionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFministracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bt_guardar
        '
        Me.bt_guardar.Location = New System.Drawing.Point(788, 266)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(93, 23)
        Me.bt_guardar.TabIndex = 147
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.lb_ciclo)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(21, 126)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 500)
        Me.TabControl1.TabIndex = 171
        '
        'lb_ciclo
        '
        Me.lb_ciclo.BackColor = System.Drawing.Color.Gainsboro
        Me.lb_ciclo.Controls.Add(Me.BT_IMPRIMIR)
        Me.lb_ciclo.Controls.Add(Me.cb_gl)
        Me.lb_ciclo.Controls.Add(Me.Label16)
        Me.lb_ciclo.Controls.Add(Me.CK_FONAGA)
        Me.lb_ciclo.Controls.Add(Me.Label69)
        Me.lb_ciclo.Controls.Add(Me.Label68)
        Me.lb_ciclo.Controls.Add(Me.Label67)
        Me.lb_ciclo.Controls.Add(Me.Label66)
        Me.lb_ciclo.Controls.Add(Me.TXT_EFEC)
        Me.lb_ciclo.Controls.Add(Me.TXT_NOM)
        Me.lb_ciclo.Controls.Add(Me.ch_pen)
        Me.lb_ciclo.Controls.Add(Me.Label65)
        Me.lb_ciclo.Controls.Add(Me.txt_tiie)
        Me.lb_ciclo.Controls.Add(Me.Label14)
        Me.lb_ciclo.Controls.Add(Me.Cksubsidio)
        Me.lb_ciclo.Controls.Add(Me.Label25)
        Me.lb_ciclo.Controls.Add(Me.PCXSG_TXT)
        Me.lb_ciclo.Controls.Add(Me.TXT_FN)
        Me.lb_ciclo.Controls.Add(Me.Label20)
        Me.lb_ciclo.Controls.Add(Me.TXT_FB)
        Me.lb_ciclo.Controls.Add(Me.Label3)
        Me.lb_ciclo.Controls.Add(Me.CheckBox1)
        Me.lb_ciclo.Controls.Add(Me.Label28)
        Me.lb_ciclo.Controls.Add(Me.TextBox1)
        Me.lb_ciclo.Controls.Add(Me.Label64)
        Me.lb_ciclo.Controls.Add(Me.Label18)
        Me.lb_ciclo.Controls.Add(Me.txt_aportacion)
        Me.lb_ciclo.Controls.Add(Me.TxtIntermediario)
        Me.lb_ciclo.Controls.Add(Me.Lb_id_contrato)
        Me.lb_ciclo.Controls.Add(Me.Label63)
        Me.lb_ciclo.Controls.Add(Me.Label59)
        Me.lb_ciclo.Controls.Add(Me.Label54)
        Me.lb_ciclo.Controls.Add(Me.cb_periodo_revision)
        Me.lb_ciclo.Controls.Add(Me.cb_periodo_int)
        Me.lb_ciclo.Controls.Add(Me.cb_periodo_capital)
        Me.lb_ciclo.Controls.Add(Me.txt_acreditado)
        Me.lb_ciclo.Controls.Add(Me.Label46)
        Me.lb_ciclo.Controls.Add(Me.cb_prestamo)
        Me.lb_ciclo.Controls.Add(Me.cb_operacion)
        Me.lb_ciclo.Controls.Add(Me.Label62)
        Me.lb_ciclo.Controls.Add(Me.cb_estatus)
        Me.lb_ciclo.Controls.Add(Me.Label58)
        Me.lb_ciclo.Controls.Add(Me.cb_intermediario)
        Me.lb_ciclo.Controls.Add(Me.Label57)
        Me.lb_ciclo.Controls.Add(Me.txt_BP)
        Me.lb_ciclo.Controls.Add(Me.Label55)
        Me.lb_ciclo.Controls.Add(Me.txt_nvsm)
        Me.lb_ciclo.Controls.Add(Me.Label19)
        Me.lb_ciclo.Controls.Add(Me.cb_tasa)
        Me.lb_ciclo.Controls.Add(Me.cb_esquema)
        Me.lb_ciclo.Controls.Add(Me.cb_seguro)
        Me.lb_ciclo.Controls.Add(Me.txt_socios)
        Me.lb_ciclo.Controls.Add(Me.cb_divisa)
        Me.lb_ciclo.Controls.Add(Me.txt_monto)
        Me.lb_ciclo.Controls.Add(Me.cb_sucursal)
        Me.lb_ciclo.Controls.Add(Me.txt_id_contrato_siiof)
        Me.lb_ciclo.Controls.Add(Me.txt_autorizacion)
        Me.lb_ciclo.Controls.Add(Me.txt_credito)
        Me.lb_ciclo.Controls.Add(Me.cb_producto)
        Me.lb_ciclo.Controls.Add(Me.Label23)
        Me.lb_ciclo.Controls.Add(Me.Label22)
        Me.lb_ciclo.Controls.Add(Me.Label21)
        Me.lb_ciclo.Controls.Add(Me.Label15)
        Me.lb_ciclo.Controls.Add(Me.Label13)
        Me.lb_ciclo.Controls.Add(Me.Label12)
        Me.lb_ciclo.Controls.Add(Me.Label11)
        Me.lb_ciclo.Controls.Add(Me.Label10)
        Me.lb_ciclo.Controls.Add(Me.Label9)
        Me.lb_ciclo.Controls.Add(Me.Label8)
        Me.lb_ciclo.Controls.Add(Me.ch_ifnd)
        Me.lb_ciclo.Controls.Add(Me.Label7)
        Me.lb_ciclo.Controls.Add(Me.Label5)
        Me.lb_ciclo.Controls.Add(Me.Label4)
        Me.lb_ciclo.Controls.Add(Me.cb_clasificacion)
        Me.lb_ciclo.Location = New System.Drawing.Point(4, 22)
        Me.lb_ciclo.Name = "lb_ciclo"
        Me.lb_ciclo.Padding = New System.Windows.Forms.Padding(3)
        Me.lb_ciclo.Size = New System.Drawing.Size(753, 474)
        Me.lb_ciclo.TabIndex = 0
        Me.lb_ciclo.Text = "Datos Financieros"
        '
        'BT_IMPRIMIR
        '
        Me.BT_IMPRIMIR.Location = New System.Drawing.Point(643, 451)
        Me.BT_IMPRIMIR.Name = "BT_IMPRIMIR"
        Me.BT_IMPRIMIR.Size = New System.Drawing.Size(104, 23)
        Me.BT_IMPRIMIR.TabIndex = 175
        Me.BT_IMPRIMIR.Text = "Estado de Cuenta"
        Me.BT_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'cb_gl
        '
        Me.cb_gl.DataSource = Me.CONTCPFGLBindingSource
        Me.cb_gl.DisplayMember = "valor"
        Me.cb_gl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_gl.FormattingEnabled = True
        Me.cb_gl.Location = New System.Drawing.Point(548, 93)
        Me.cb_gl.Name = "cb_gl"
        Me.cb_gl.Size = New System.Drawing.Size(85, 21)
        Me.cb_gl.TabIndex = 221
        Me.cb_gl.ValueMember = "id_gl"
        '
        'CONTCPFGLBindingSource
        '
        Me.CONTCPFGLBindingSource.DataMember = "CONT_CPF_GL"
        Me.CONTCPFGLBindingSource.DataSource = Me.DescuentosDS
        '
        'DescuentosDS
        '
        Me.DescuentosDS.DataSetName = "DescuentosDS"
        Me.DescuentosDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(423, 93)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 13)
        Me.Label16.TabIndex = 220
        Me.Label16.Text = "Garantia Líquida"
        '
        'CK_FONAGA
        '
        Me.CK_FONAGA.AutoSize = True
        Me.CK_FONAGA.Location = New System.Drawing.Point(717, 100)
        Me.CK_FONAGA.Name = "CK_FONAGA"
        Me.CK_FONAGA.Size = New System.Drawing.Size(15, 14)
        Me.CK_FONAGA.TabIndex = 219
        Me.CK_FONAGA.UseVisualStyleBackColor = True
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(656, 101)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(51, 13)
        Me.Label69.TabIndex = 218
        Me.Label69.Text = "FONAGA"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(665, 146)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(39, 13)
        Me.Label68.TabIndex = 217
        Me.Label68.Text = "% CXS"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(571, 146)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(45, 13)
        Me.Label67.TabIndex = 216
        Me.Label67.Text = "% EFEC"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(471, 146)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(43, 13)
        Me.Label66.TabIndex = 215
        Me.Label66.Text = "% NOM"
        '
        'TXT_EFEC
        '
        Me.TXT_EFEC.Location = New System.Drawing.Point(622, 143)
        Me.TXT_EFEC.Name = "TXT_EFEC"
        Me.TXT_EFEC.Size = New System.Drawing.Size(27, 20)
        Me.TXT_EFEC.TabIndex = 213
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Location = New System.Drawing.Point(532, 142)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(27, 20)
        Me.TXT_NOM.TabIndex = 212
        '
        'ch_pen
        '
        Me.ch_pen.AutoSize = True
        Me.ch_pen.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CONTCPFcontratosBindingSource, "Penalizacion", True))
        Me.ch_pen.Location = New System.Drawing.Point(128, 211)
        Me.ch_pen.Name = "ch_pen"
        Me.ch_pen.Size = New System.Drawing.Size(15, 14)
        Me.ch_pen.TabIndex = 211
        Me.ch_pen.UseVisualStyleBackColor = True
        '
        'CONTCPFcontratosBindingSource
        '
        Me.CONTCPFcontratosBindingSource.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(53, 211)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(67, 13)
        Me.Label65.TabIndex = 210
        Me.Label65.Text = "Penalización"
        '
        'txt_tiie
        '
        Me.txt_tiie.Location = New System.Drawing.Point(552, 274)
        Me.txt_tiie.Name = "txt_tiie"
        Me.txt_tiie.Size = New System.Drawing.Size(100, 20)
        Me.txt_tiie.TabIndex = 209
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(503, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 208
        Me.Label14.Text = "Tasa Tiie"
        '
        'Cksubsidio
        '
        Me.Cksubsidio.AutoSize = True
        Me.Cksubsidio.Location = New System.Drawing.Point(128, 446)
        Me.Cksubsidio.Name = "Cksubsidio"
        Me.Cksubsidio.Size = New System.Drawing.Size(15, 14)
        Me.Cksubsidio.TabIndex = 207
        Me.Cksubsidio.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(69, 447)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(47, 13)
        Me.Label25.TabIndex = 206
        Me.Label25.Text = "Subsidio"
        '
        'PCXSG_TXT
        '
        Me.PCXSG_TXT.Location = New System.Drawing.Point(710, 143)
        Me.PCXSG_TXT.Name = "PCXSG_TXT"
        Me.PCXSG_TXT.Size = New System.Drawing.Size(36, 20)
        Me.PCXSG_TXT.TabIndex = 203
        '
        'TXT_FN
        '
        Me.TXT_FN.Location = New System.Drawing.Point(549, 240)
        Me.TXT_FN.Name = "TXT_FN"
        Me.TXT_FN.Size = New System.Drawing.Size(100, 20)
        Me.TXT_FN.TabIndex = 199
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(500, 243)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 13)
        Me.Label20.TabIndex = 198
        Me.Label20.Text = "Tasa FN"
        '
        'TXT_FB
        '
        Me.TXT_FB.Location = New System.Drawing.Point(549, 189)
        Me.TXT_FB.Name = "TXT_FB"
        Me.TXT_FB.Size = New System.Drawing.Size(100, 20)
        Me.TXT_FB.TabIndex = 197
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(500, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 196
        Me.Label3.Text = "Tasa FB"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(550, 364)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 195
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(454, 364)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 13)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "Corte Int. Fin Mes"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(551, 339)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 193
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(445, 342)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(99, 13)
        Me.Label64.TabIndex = 192
        Me.Label64.Text = "Valor Garantía H/P"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 357)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 191
        Me.Label18.Text = "Aportación Acreditado"
        '
        'txt_aportacion
        '
        Me.txt_aportacion.Enabled = False
        Me.txt_aportacion.Location = New System.Drawing.Point(125, 352)
        Me.txt_aportacion.Name = "txt_aportacion"
        Me.txt_aportacion.Size = New System.Drawing.Size(156, 20)
        Me.txt_aportacion.TabIndex = 190
        '
        'TxtIntermediario
        '
        Me.TxtIntermediario.Location = New System.Drawing.Point(334, 14)
        Me.TxtIntermediario.Name = "TxtIntermediario"
        Me.TxtIntermediario.ReadOnly = True
        Me.TxtIntermediario.Size = New System.Drawing.Size(30, 20)
        Me.TxtIntermediario.TabIndex = 189
        Me.TxtIntermediario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lb_id_contrato
        '
        Me.Lb_id_contrato.AutoSize = True
        Me.Lb_id_contrato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosBindingSource, "id_contrato", True))
        Me.Lb_id_contrato.Location = New System.Drawing.Point(5, 387)
        Me.Lb_id_contrato.Name = "Lb_id_contrato"
        Me.Lb_id_contrato.Size = New System.Drawing.Size(13, 13)
        Me.Lb_id_contrato.TabIndex = 188
        Me.Lb_id_contrato.Text = "0"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(398, 434)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(133, 13)
        Me.Label63.TabIndex = 186
        Me.Label63.Text = "Periodo Revision Intereses"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(438, 407)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(89, 13)
        Me.Label59.TabIndex = 185
        Me.Label59.Text = "Periodo Intereses"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(449, 380)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 13)
        Me.Label54.TabIndex = 184
        Me.Label54.Text = "Periodo Capital"
        '
        'cb_periodo_revision
        '
        Me.cb_periodo_revision.DataSource = Me.CONTCPFperiodicidadBindingSource
        Me.cb_periodo_revision.DisplayMember = "descripcion"
        Me.cb_periodo_revision.FormattingEnabled = True
        Me.cb_periodo_revision.Location = New System.Drawing.Point(545, 427)
        Me.cb_periodo_revision.Name = "cb_periodo_revision"
        Me.cb_periodo_revision.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_revision.TabIndex = 183
        Me.cb_periodo_revision.ValueMember = "id_periodo"
        '
        'CONTCPFperiodicidadBindingSource
        '
        Me.CONTCPFperiodicidadBindingSource.DataMember = "CONT_CPF_periodicidad"
        Me.CONTCPFperiodicidadBindingSource.DataSource = Me.DS_contratos
        '
        'cb_periodo_int
        '
        Me.cb_periodo_int.DataSource = Me.CONTCPFperiodicidadBindingSource
        Me.cb_periodo_int.DisplayMember = "descripcion"
        Me.cb_periodo_int.FormattingEnabled = True
        Me.cb_periodo_int.Location = New System.Drawing.Point(545, 404)
        Me.cb_periodo_int.Name = "cb_periodo_int"
        Me.cb_periodo_int.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_int.TabIndex = 182
        Me.cb_periodo_int.ValueMember = "id_periodo"
        '
        'cb_periodo_capital
        '
        Me.cb_periodo_capital.DataSource = Me.CONTCPFperiodicidadBindingSource
        Me.cb_periodo_capital.DisplayMember = "descripcion"
        Me.cb_periodo_capital.FormattingEnabled = True
        Me.cb_periodo_capital.Location = New System.Drawing.Point(544, 377)
        Me.cb_periodo_capital.Name = "cb_periodo_capital"
        Me.cb_periodo_capital.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_capital.TabIndex = 181
        Me.cb_periodo_capital.ValueMember = "id_periodo"
        '
        'txt_acreditado
        '
        Me.txt_acreditado.Location = New System.Drawing.Point(310, 178)
        Me.txt_acreditado.Name = "txt_acreditado"
        Me.txt_acreditado.Size = New System.Drawing.Size(100, 20)
        Me.txt_acreditado.TabIndex = 180
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(232, 186)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(70, 13)
        Me.Label46.TabIndex = 179
        Me.Label46.Text = "Id Acreditado"
        '
        'cb_prestamo
        '
        Me.cb_prestamo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONTCPFcontratosBindingSource, "id_tipo_prestamo", True))
        Me.cb_prestamo.DataSource = Me.CONTCPFtipoprestamosBindingSource
        Me.cb_prestamo.DisplayMember = "descripcion_prestamo"
        Me.cb_prestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_prestamo.FormattingEnabled = True
        Me.cb_prestamo.Location = New System.Drawing.Point(125, 119)
        Me.cb_prestamo.Name = "cb_prestamo"
        Me.cb_prestamo.Size = New System.Drawing.Size(242, 21)
        Me.cb_prestamo.TabIndex = 172
        Me.cb_prestamo.ValueMember = "id_tipo_prestamo"
        '
        'CONTCPFtipoprestamosBindingSource
        '
        Me.CONTCPFtipoprestamosBindingSource.DataMember = "CONT_CPF_tipoprestamos"
        Me.CONTCPFtipoprestamosBindingSource.DataSource = Me.DS_contratos
        '
        'cb_operacion
        '
        Me.cb_operacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONTCPFcontratosBindingSource, "id_operacion", True))
        Me.cb_operacion.DataSource = Me.CONTCPFoperacionBindingSource
        Me.cb_operacion.DisplayMember = "desc"
        Me.cb_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_operacion.FormattingEnabled = True
        Me.cb_operacion.Location = New System.Drawing.Point(125, 67)
        Me.cb_operacion.Name = "cb_operacion"
        Me.cb_operacion.Size = New System.Drawing.Size(241, 21)
        Me.cb_operacion.TabIndex = 171
        Me.cb_operacion.ValueMember = "id_operacion"
        '
        'CONTCPFoperacionBindingSource
        '
        Me.CONTCPFoperacionBindingSource.DataMember = "CONT_CPF_operacion"
        Me.CONTCPFoperacionBindingSource.DataSource = Me.DS_contratos
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(32, 76)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(86, 13)
        Me.Label62.TabIndex = 170
        Me.Label62.Text = "Modo Operación"
        '
        'cb_estatus
        '
        Me.cb_estatus.DataSource = Me.CONTCPFESTATUSBindingSource
        Me.cb_estatus.DisplayMember = "estatus"
        Me.cb_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estatus.FormattingEnabled = True
        Me.cb_estatus.Location = New System.Drawing.Point(546, 64)
        Me.cb_estatus.Name = "cb_estatus"
        Me.cb_estatus.Size = New System.Drawing.Size(157, 21)
        Me.cb_estatus.TabIndex = 169
        Me.cb_estatus.ValueMember = "id_estatus"
        '
        'CONTCPFESTATUSBindingSource
        '
        Me.CONTCPFESTATUSBindingSource.DataMember = "CONT_CPF_ESTATUS"
        Me.CONTCPFESTATUSBindingSource.DataSource = Me.DS_contratos
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(454, 67)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(79, 13)
        Me.Label58.TabIndex = 166
        Me.Label58.Text = "Estatus Pagaré"
        '
        'cb_intermediario
        '
        Me.cb_intermediario.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONTCPFcontratosBindingSource, "id_intermediario", True))
        Me.cb_intermediario.DataSource = Me.CONTCPFintermediariosBindingSource
        Me.cb_intermediario.DisplayMember = "nombre_intermediario"
        Me.cb_intermediario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_intermediario.FormattingEnabled = True
        Me.cb_intermediario.Location = New System.Drawing.Point(125, 14)
        Me.cb_intermediario.Name = "cb_intermediario"
        Me.cb_intermediario.Size = New System.Drawing.Size(203, 21)
        Me.cb_intermediario.TabIndex = 165
        Me.cb_intermediario.ValueMember = "id_intermediario"
        '
        'CONTCPFintermediariosBindingSource
        '
        Me.CONTCPFintermediariosBindingSource.DataMember = "CONT_CPF_intermediarios"
        Me.CONTCPFintermediariosBindingSource.DataSource = Me.DS_contratos
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(51, 20)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(67, 13)
        Me.Label57.TabIndex = 164
        Me.Label57.Text = "Intermediario"
        '
        'txt_BP
        '
        Me.txt_BP.Location = New System.Drawing.Point(549, 217)
        Me.txt_BP.Name = "txt_BP"
        Me.txt_BP.Size = New System.Drawing.Size(100, 20)
        Me.txt_BP.TabIndex = 163
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(500, 220)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(51, 13)
        Me.Label55.TabIndex = 162
        Me.Label55.Text = "Tasa  BP"
        '
        'txt_nvsm
        '
        Me.txt_nvsm.Location = New System.Drawing.Point(334, 318)
        Me.txt_nvsm.Name = "txt_nvsm"
        Me.txt_nvsm.Size = New System.Drawing.Size(30, 20)
        Me.txt_nvsm.TabIndex = 52
        Me.txt_nvsm.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(244, 321)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "NVSM por socio"
        '
        'cb_tasa
        '
        Me.cb_tasa.DataSource = Me.CONTCPFtipotasasBindingSource
        Me.cb_tasa.DisplayMember = "des_tipo_tasa"
        Me.cb_tasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tasa.FormattingEnabled = True
        Me.cb_tasa.Location = New System.Drawing.Point(548, 17)
        Me.cb_tasa.Name = "cb_tasa"
        Me.cb_tasa.Size = New System.Drawing.Size(157, 21)
        Me.cb_tasa.TabIndex = 46
        Me.cb_tasa.ValueMember = "id_tipo_tasa"
        '
        'CONTCPFtipotasasBindingSource
        '
        Me.CONTCPFtipotasasBindingSource.DataMember = "CONT_CPF_tipo_tasas"
        Me.CONTCPFtipotasasBindingSource.DataSource = Me.DS_contratos
        '
        'cb_esquema
        '
        Me.cb_esquema.DataSource = Me.CONTCPFesquemacobroBindingSource
        Me.cb_esquema.DisplayMember = "esquema_cobro"
        Me.cb_esquema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_esquema.FormattingEnabled = True
        Me.cb_esquema.Location = New System.Drawing.Point(125, 410)
        Me.cb_esquema.Name = "cb_esquema"
        Me.cb_esquema.Size = New System.Drawing.Size(243, 21)
        Me.cb_esquema.TabIndex = 44
        Me.cb_esquema.ValueMember = "id_esquema_cobro"
        '
        'CONTCPFesquemacobroBindingSource
        '
        Me.CONTCPFesquemacobroBindingSource.DataMember = "CONT_CPF_esquema_cobro"
        Me.CONTCPFesquemacobroBindingSource.DataSource = Me.DS_contratos
        '
        'cb_seguro
        '
        Me.cb_seguro.DataSource = Me.CONTCPFsegurosBindingSource
        Me.cb_seguro.DisplayMember = "tipo_seguro"
        Me.cb_seguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_seguro.FormattingEnabled = True
        Me.cb_seguro.Location = New System.Drawing.Point(125, 381)
        Me.cb_seguro.Name = "cb_seguro"
        Me.cb_seguro.Size = New System.Drawing.Size(243, 21)
        Me.cb_seguro.TabIndex = 43
        Me.cb_seguro.ValueMember = "id_seguro"
        '
        'CONTCPFsegurosBindingSource
        '
        Me.CONTCPFsegurosBindingSource.DataMember = "CONT_CPF_seguros"
        Me.CONTCPFsegurosBindingSource.DataSource = Me.DS_contratos
        '
        'txt_socios
        '
        Me.txt_socios.Location = New System.Drawing.Point(125, 323)
        Me.txt_socios.Name = "txt_socios"
        Me.txt_socios.Size = New System.Drawing.Size(100, 20)
        Me.txt_socios.TabIndex = 42
        '
        'cb_divisa
        '
        Me.cb_divisa.DataSource = Me.CONTCPFdivisasBindingSource
        Me.cb_divisa.DisplayMember = "modena"
        Me.cb_divisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_divisa.FormattingEnabled = True
        Me.cb_divisa.Location = New System.Drawing.Point(265, 284)
        Me.cb_divisa.Name = "cb_divisa"
        Me.cb_divisa.Size = New System.Drawing.Size(100, 21)
        Me.cb_divisa.TabIndex = 41
        Me.cb_divisa.ValueMember = "id_divisa"
        '
        'CONTCPFdivisasBindingSource
        '
        Me.CONTCPFdivisasBindingSource.DataMember = "CONT_CPF_divisas"
        Me.CONTCPFdivisasBindingSource.DataSource = Me.DS_contratos
        '
        'txt_monto
        '
        Me.txt_monto.Location = New System.Drawing.Point(125, 293)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_monto.TabIndex = 40
        '
        'cb_sucursal
        '
        Me.cb_sucursal.DataSource = Me.CONTCPFsucursalesBindingSource
        Me.cb_sucursal.DisplayMember = "nombre_sucursal"
        Me.cb_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sucursal.FormattingEnabled = True
        Me.cb_sucursal.Location = New System.Drawing.Point(125, 256)
        Me.cb_sucursal.Name = "cb_sucursal"
        Me.cb_sucursal.Size = New System.Drawing.Size(242, 21)
        Me.cb_sucursal.TabIndex = 39
        Me.cb_sucursal.ValueMember = "id_sucursal"
        '
        'CONTCPFsucursalesBindingSource
        '
        Me.CONTCPFsucursalesBindingSource.DataMember = "CONT_CPF_sucursales"
        Me.CONTCPFsucursalesBindingSource.DataSource = Me.DS_contratos
        '
        'txt_id_contrato_siiof
        '
        Me.txt_id_contrato_siiof.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosBindingSource, "id_contrato_siiof", True))
        Me.txt_id_contrato_siiof.Location = New System.Drawing.Point(125, 182)
        Me.txt_id_contrato_siiof.Name = "txt_id_contrato_siiof"
        Me.txt_id_contrato_siiof.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_contrato_siiof.TabIndex = 38
        '
        'txt_autorizacion
        '
        Me.txt_autorizacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosBindingSource, "id_autorizacion", True))
        Me.txt_autorizacion.Location = New System.Drawing.Point(309, 146)
        Me.txt_autorizacion.Name = "txt_autorizacion"
        Me.txt_autorizacion.Size = New System.Drawing.Size(100, 20)
        Me.txt_autorizacion.TabIndex = 37
        '
        'txt_credito
        '
        Me.txt_credito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONTCPFcontratosBindingSource, "id_credito", True))
        Me.txt_credito.Location = New System.Drawing.Point(125, 147)
        Me.txt_credito.Name = "txt_credito"
        Me.txt_credito.Size = New System.Drawing.Size(100, 20)
        Me.txt_credito.TabIndex = 36
        '
        'cb_producto
        '
        Me.cb_producto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONTCPFcontratosBindingSource, "id_tipo_prestamo", True))
        Me.cb_producto.DataSource = Me.CONTCPFproductosfiraBindingSource
        Me.cb_producto.DisplayMember = "descripcion_producto_fira"
        Me.cb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_producto.FormattingEnabled = True
        Me.cb_producto.Location = New System.Drawing.Point(125, 93)
        Me.cb_producto.Name = "cb_producto"
        Me.cb_producto.Size = New System.Drawing.Size(242, 21)
        Me.cb_producto.TabIndex = 34
        Me.cb_producto.ValueMember = "id_producto_fira"
        '
        'CONTCPFproductosfiraBindingSource
        '
        Me.CONTCPFproductosfiraBindingSource.DataMember = "CONT_CPF_productos_fira"
        Me.CONTCPFproductosfiraBindingSource.DataSource = Me.DS_contratos
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(41, 185)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Contrato SIIOF"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(230, 150)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Id Autorización"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(66, 154)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Id Crédito"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 408)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Esquema de Cobro"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(480, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(55, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Tipo Tasa"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(53, 381)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Tipo Seguro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 326)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Num. socios"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Sucursal Bancaria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Monto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Divisa"
        '
        'ch_ifnd
        '
        Me.ch_ifnd.AutoSize = True
        Me.ch_ifnd.Location = New System.Drawing.Point(550, 323)
        Me.ch_ifnd.Name = "ch_ifnd"
        Me.ch_ifnd.Size = New System.Drawing.Size(15, 14)
        Me.ch_ifnd.TabIndex = 5
        Me.ch_ifnd.UseVisualStyleBackColor = True
        Me.ch_ifnd.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(438, 321)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Participa como IFND"
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo Préstamo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Producto"
        '
        'cb_clasificacion
        '
        Me.cb_clasificacion.DataSource = Me.CONTCPFclasificaciongarantiasBindingSource
        Me.cb_clasificacion.DisplayMember = "categoria"
        Me.cb_clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_clasificacion.Enabled = False
        Me.cb_clasificacion.FormattingEnabled = True
        Me.cb_clasificacion.Location = New System.Drawing.Point(548, 93)
        Me.cb_clasificacion.Name = "cb_clasificacion"
        Me.cb_clasificacion.Size = New System.Drawing.Size(39, 21)
        Me.cb_clasificacion.TabIndex = 168
        Me.cb_clasificacion.ValueMember = "id_clasificacion_garantia"
        Me.cb_clasificacion.Visible = False
        '
        'CONTCPFclasificaciongarantiasBindingSource
        '
        Me.CONTCPFclasificaciongarantiasBindingSource.DataMember = "CONT_CPF_clasificacion_garantias"
        Me.CONTCPFclasificaciongarantiasBindingSource.DataSource = Me.DS_contratos
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Controls.Add(Me.txt_egresos)
        Me.TabPage2.Controls.Add(Me.cb_concepto)
        Me.TabPage2.Controls.Add(Me.txt_localidad)
        Me.TabPage2.Controls.Add(Me.cb_periodo)
        Me.TabPage2.Controls.Add(Me.Label60)
        Me.TabPage2.Controls.Add(Me.txt_estrato)
        Me.TabPage2.Controls.Add(Me.dt_febalance)
        Me.TabPage2.Controls.Add(Me.Label56)
        Me.TabPage2.Controls.Add(Me.txt_fondo)
        Me.TabPage2.Controls.Add(Me.txt_sieban)
        Me.TabPage2.Controls.Add(Me.txt_programaespecial)
        Me.TabPage2.Controls.Add(Me.cb_programa)
        Me.TabPage2.Controls.Add(Me.Label53)
        Me.TabPage2.Controls.Add(Me.cb_cadena)
        Me.TabPage2.Controls.Add(Me.cb_subrama)
        Me.TabPage2.Controls.Add(Me.cb_rama)
        Me.TabPage2.Controls.Add(Me.cb_actividad)
        Me.TabPage2.Controls.Add(Me.Label52)
        Me.TabPage2.Controls.Add(Me.Label51)
        Me.TabPage2.Controls.Add(Me.Label50)
        Me.TabPage2.Controls.Add(Me.Label49)
        Me.TabPage2.Controls.Add(Me.Label47)
        Me.TabPage2.Controls.Add(Me.Label45)
        Me.TabPage2.Controls.Add(Me.Label44)
        Me.TabPage2.Controls.Add(Me.txt_utilidad)
        Me.TabPage2.Controls.Add(Me.txt_ingresos)
        Me.TabPage2.Controls.Add(Me.txt_activototal)
        Me.TabPage2.Controls.Add(Me.txt_activofijo)
        Me.TabPage2.Controls.Add(Me.txt_capital)
        Me.TabPage2.Controls.Add(Me.Label43)
        Me.TabPage2.Controls.Add(Me.Label42)
        Me.TabPage2.Controls.Add(Me.Label41)
        Me.TabPage2.Controls.Add(Me.Label40)
        Me.TabPage2.Controls.Add(Me.Label39)
        Me.TabPage2.Controls.Add(Me.Label38)
        Me.TabPage2.Controls.Add(Me.Label36)
        Me.TabPage2.Controls.Add(Me.Label35)
        Me.TabPage2.Controls.Add(Me.txt_ingresoneto)
        Me.TabPage2.Controls.Add(Me.Label34)
        Me.TabPage2.Controls.Add(Me.cb_medida)
        Me.TabPage2.Controls.Add(Me.txt_clave)
        Me.TabPage2.Controls.Add(Me.Label33)
        Me.TabPage2.Controls.Add(Me.Label32)
        Me.TabPage2.Controls.Add(Me.Label31)
        Me.TabPage2.Controls.Add(Me.txt_capacidad)
        Me.TabPage2.Controls.Add(Me.Label30)
        Me.TabPage2.Controls.Add(Me.Label29)
        Me.TabPage2.Controls.Add(Me.txt_jornales)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label61)
        Me.TabPage2.Controls.Add(Me.cb_clase)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(753, 474)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Complementarios"
        '
        'txt_egresos
        '
        Me.txt_egresos.Enabled = False
        Me.txt_egresos.Location = New System.Drawing.Point(138, 276)
        Me.txt_egresos.Name = "txt_egresos"
        Me.txt_egresos.Size = New System.Drawing.Size(157, 20)
        Me.txt_egresos.TabIndex = 31
        Me.txt_egresos.Text = "0"
        '
        'cb_concepto
        '
        Me.cb_concepto.DataSource = Me.CONTCPFconceptosinversionBindingSource1
        Me.cb_concepto.DisplayMember = "descr"
        Me.cb_concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_concepto.FormattingEnabled = True
        Me.cb_concepto.Location = New System.Drawing.Point(340, 348)
        Me.cb_concepto.Name = "cb_concepto"
        Me.cb_concepto.Size = New System.Drawing.Size(373, 21)
        Me.cb_concepto.TabIndex = 73
        Me.cb_concepto.ValueMember = "concepto"
        '
        'CONTCPFconceptosinversionBindingSource1
        '
        Me.CONTCPFconceptosinversionBindingSource1.DataMember = "CONT_CPF_conceptos_inversion"
        Me.CONTCPFconceptosinversionBindingSource1.DataSource = Me.DS_contratos
        '
        'txt_localidad
        '
        Me.txt_localidad.Location = New System.Drawing.Point(459, 68)
        Me.txt_localidad.Multiline = True
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(197, 61)
        Me.txt_localidad.TabIndex = 72
        '
        'cb_periodo
        '
        Me.cb_periodo.DataSource = Me.CONTCPFperiodicidadBindingSource1
        Me.cb_periodo.DisplayMember = "descripcion"
        Me.cb_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_periodo.FormattingEnabled = True
        Me.cb_periodo.Location = New System.Drawing.Point(459, 270)
        Me.cb_periodo.Name = "cb_periodo"
        Me.cb_periodo.Size = New System.Drawing.Size(193, 21)
        Me.cb_periodo.TabIndex = 71
        Me.cb_periodo.ValueMember = "id_periodo"
        Me.cb_periodo.Visible = False
        '
        'CONTCPFperiodicidadBindingSource1
        '
        Me.CONTCPFperiodicidadBindingSource1.DataMember = "CONT_CPF_periodicidad"
        Me.CONTCPFperiodicidadBindingSource1.DataSource = Me.DS_contratos
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(404, 278)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(43, 13)
        Me.Label60.TabIndex = 69
        Me.Label60.Text = "Periodo"
        Me.Label60.Visible = False
        '
        'txt_estrato
        '
        Me.txt_estrato.Enabled = False
        Me.txt_estrato.Location = New System.Drawing.Point(141, 92)
        Me.txt_estrato.Name = "txt_estrato"
        Me.txt_estrato.Size = New System.Drawing.Size(157, 20)
        Me.txt_estrato.TabIndex = 67
        '
        'dt_febalance
        '
        Me.dt_febalance.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dt_febalance.Location = New System.Drawing.Point(139, 170)
        Me.dt_febalance.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dt_febalance.Name = "dt_febalance"
        Me.dt_febalance.Size = New System.Drawing.Size(156, 20)
        Me.dt_febalance.TabIndex = 66
        Me.dt_febalance.Value = New Date(1900, 1, 1, 12, 0, 0, 0)
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(363, 45)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(80, 13)
        Me.Label56.TabIndex = 65
        Me.Label56.Text = "Fondo Reserva"
        '
        'txt_fondo
        '
        Me.txt_fondo.Location = New System.Drawing.Point(459, 42)
        Me.txt_fondo.Name = "txt_fondo"
        Me.txt_fondo.Size = New System.Drawing.Size(100, 20)
        Me.txt_fondo.TabIndex = 64
        '
        'txt_sieban
        '
        Me.txt_sieban.Location = New System.Drawing.Point(458, 15)
        Me.txt_sieban.Name = "txt_sieban"
        Me.txt_sieban.Size = New System.Drawing.Size(100, 20)
        Me.txt_sieban.TabIndex = 57
        '
        'txt_programaespecial
        '
        Me.txt_programaespecial.Location = New System.Drawing.Point(137, 328)
        Me.txt_programaespecial.Name = "txt_programaespecial"
        Me.txt_programaespecial.Size = New System.Drawing.Size(157, 20)
        Me.txt_programaespecial.TabIndex = 55
        '
        'cb_programa
        '
        Me.cb_programa.DataSource = Me.CONTCPFprogramasBindingSource
        Me.cb_programa.DisplayMember = "programa"
        Me.cb_programa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_programa.FormattingEnabled = True
        Me.cb_programa.Location = New System.Drawing.Point(459, 244)
        Me.cb_programa.Name = "cb_programa"
        Me.cb_programa.Size = New System.Drawing.Size(193, 21)
        Me.cb_programa.TabIndex = 53
        Me.cb_programa.ValueMember = "id_programa"
        '
        'CONTCPFprogramasBindingSource
        '
        Me.CONTCPFprogramasBindingSource.DataMember = "CONT_CPF_programas"
        Me.CONTCPFprogramasBindingSource.DataSource = Me.DS_contratos
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(399, 251)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(52, 13)
        Me.Label53.TabIndex = 52
        Me.Label53.Text = "Programa"
        '
        'cb_cadena
        '
        Me.cb_cadena.DataSource = Me.CONTCPFcadenasBindingSource
        Me.cb_cadena.DisplayMember = "cadena"
        Me.cb_cadena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cadena.FormattingEnabled = True
        Me.cb_cadena.Location = New System.Drawing.Point(459, 217)
        Me.cb_cadena.Name = "cb_cadena"
        Me.cb_cadena.Size = New System.Drawing.Size(193, 21)
        Me.cb_cadena.TabIndex = 51
        Me.cb_cadena.ValueMember = "id_cadena"
        '
        'CONTCPFcadenasBindingSource
        '
        Me.CONTCPFcadenasBindingSource.DataMember = "CONT_CPF_cadenas"
        Me.CONTCPFcadenasBindingSource.DataSource = Me.DS_contratos
        '
        'cb_subrama
        '
        Me.cb_subrama.DataSource = Me.CONTCPFsubramasBindingSource
        Me.cb_subrama.DisplayMember = "subrama"
        Me.cb_subrama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subrama.FormattingEnabled = True
        Me.cb_subrama.Location = New System.Drawing.Point(459, 192)
        Me.cb_subrama.Name = "cb_subrama"
        Me.cb_subrama.Size = New System.Drawing.Size(193, 21)
        Me.cb_subrama.TabIndex = 50
        Me.cb_subrama.ValueMember = "id_subrama"
        '
        'CONTCPFsubramasBindingSource
        '
        Me.CONTCPFsubramasBindingSource.DataMember = "CONT_CPF_subramas"
        Me.CONTCPFsubramasBindingSource.DataSource = Me.DS_contratos
        '
        'cb_rama
        '
        Me.cb_rama.DataSource = Me.CONTCPFramasBindingSource
        Me.cb_rama.DisplayMember = "rama"
        Me.cb_rama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_rama.FormattingEnabled = True
        Me.cb_rama.Location = New System.Drawing.Point(459, 165)
        Me.cb_rama.Name = "cb_rama"
        Me.cb_rama.Size = New System.Drawing.Size(193, 21)
        Me.cb_rama.TabIndex = 49
        Me.cb_rama.ValueMember = "id_rama"
        '
        'CONTCPFramasBindingSource
        '
        Me.CONTCPFramasBindingSource.DataMember = "CONT_CPF_ramas"
        Me.CONTCPFramasBindingSource.DataSource = Me.DS_contratos
        '
        'cb_actividad
        '
        Me.cb_actividad.DataSource = Me.CONTCPFactividadBindingSource
        Me.cb_actividad.DisplayMember = "tipo_actividad"
        Me.cb_actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_actividad.FormattingEnabled = True
        Me.cb_actividad.Location = New System.Drawing.Point(459, 139)
        Me.cb_actividad.Name = "cb_actividad"
        Me.cb_actividad.Size = New System.Drawing.Size(193, 21)
        Me.cb_actividad.TabIndex = 48
        Me.cb_actividad.ValueMember = "id_actividad"
        '
        'CONTCPFactividadBindingSource
        '
        Me.CONTCPFactividadBindingSource.DataMember = "CONT_CPF_actividad"
        Me.CONTCPFactividadBindingSource.DataSource = Me.DS_contratos
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(347, 225)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(98, 13)
        Me.Label52.TabIndex = 47
        Me.Label52.Text = "Cadena Productiva"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(393, 195)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(57, 13)
        Me.Label51.TabIndex = 46
        Me.Label51.Text = "Sub-Rama"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(410, 167)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(35, 13)
        Me.Label50.TabIndex = 45
        Me.Label50.Text = "Rama"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(394, 143)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(51, 13)
        Me.Label49.TabIndex = 44
        Me.Label49.Text = "Actividad"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(337, 329)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(114, 13)
        Me.Label47.TabIndex = 36
        Me.Label47.Text = "Concepto de Inversion"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(567, 309)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(0, 13)
        Me.Label45.TabIndex = 34
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(394, 64)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(53, 13)
        Me.Label44.TabIndex = 33
        Me.Label44.Text = "Localidad"
        '
        'txt_utilidad
        '
        Me.txt_utilidad.Enabled = False
        Me.txt_utilidad.Location = New System.Drawing.Point(138, 302)
        Me.txt_utilidad.Name = "txt_utilidad"
        Me.txt_utilidad.Size = New System.Drawing.Size(157, 20)
        Me.txt_utilidad.TabIndex = 32
        '
        'txt_ingresos
        '
        Me.txt_ingresos.Enabled = False
        Me.txt_ingresos.Location = New System.Drawing.Point(139, 249)
        Me.txt_ingresos.Name = "txt_ingresos"
        Me.txt_ingresos.Size = New System.Drawing.Size(156, 20)
        Me.txt_ingresos.TabIndex = 30
        '
        'txt_activototal
        '
        Me.txt_activototal.Enabled = False
        Me.txt_activototal.Location = New System.Drawing.Point(140, 222)
        Me.txt_activototal.Name = "txt_activototal"
        Me.txt_activototal.Size = New System.Drawing.Size(155, 20)
        Me.txt_activototal.TabIndex = 29
        '
        'txt_activofijo
        '
        Me.txt_activofijo.Enabled = False
        Me.txt_activofijo.Location = New System.Drawing.Point(140, 196)
        Me.txt_activofijo.Name = "txt_activofijo"
        Me.txt_activofijo.Size = New System.Drawing.Size(155, 20)
        Me.txt_activofijo.TabIndex = 28
        '
        'txt_capital
        '
        Me.txt_capital.Location = New System.Drawing.Point(138, 144)
        Me.txt_capital.Name = "txt_capital"
        Me.txt_capital.Size = New System.Drawing.Size(157, 20)
        Me.txt_capital.TabIndex = 26
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(82, 305)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(42, 13)
        Me.Label43.TabIndex = 25
        Me.Label43.Text = "Utilidad"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(80, 279)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(45, 13)
        Me.Label42.TabIndex = 24
        Me.Label42.Text = "Egresos"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(84, 252)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(47, 13)
        Me.Label41.TabIndex = 23
        Me.Label41.Text = "Ingresos"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(72, 226)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(64, 13)
        Me.Label40.TabIndex = 22
        Me.Label40.Text = "Activo Total"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(80, 199)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(56, 13)
        Me.Label39.TabIndex = 21
        Me.Label39.Text = "Activo Fijo"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(57, 174)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(79, 13)
        Me.Label38.TabIndex = 20
        Me.Label38.Text = "Fecha Balance"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(32, 326)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(95, 13)
        Me.Label36.TabIndex = 18
        Me.Label36.Text = "Programa Especial"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(53, 144)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 13)
        Me.Label35.TabIndex = 17
        Me.Label35.Text = "Capital Contable"
        '
        'txt_ingresoneto
        '
        Me.txt_ingresoneto.Enabled = False
        Me.txt_ingresoneto.Location = New System.Drawing.Point(140, 118)
        Me.txt_ingresoneto.Name = "txt_ingresoneto"
        Me.txt_ingresoneto.Size = New System.Drawing.Size(155, 20)
        Me.txt_ingresoneto.TabIndex = 16
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(68, 125)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(68, 13)
        Me.Label34.TabIndex = 15
        Me.Label34.Text = "Ingreso Neto"
        '
        'cb_medida
        '
        Me.cb_medida.DataSource = Me.CONTCPFunidadesmedidaBindingSource
        Me.cb_medida.DisplayMember = "medida"
        Me.cb_medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_medida.FormattingEnabled = True
        Me.cb_medida.Location = New System.Drawing.Point(142, 40)
        Me.cb_medida.Name = "cb_medida"
        Me.cb_medida.Size = New System.Drawing.Size(156, 21)
        Me.cb_medida.TabIndex = 14
        Me.cb_medida.ValueMember = "id_umedida"
        '
        'CONTCPFunidadesmedidaBindingSource
        '
        Me.CONTCPFunidadesmedidaBindingSource.DataMember = "CONT_CPF_unidades_medida"
        Me.CONTCPFunidadesmedidaBindingSource.DataSource = Me.DS_contratos
        '
        'txt_clave
        '
        Me.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave.Location = New System.Drawing.Point(459, 296)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(157, 20)
        Me.txt_clave.TabIndex = 13
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(413, 303)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(34, 13)
        Me.Label33.TabIndex = 12
        Me.Label33.Text = "Clave"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(364, 18)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(79, 13)
        Me.Label32.TabIndex = 10
        Me.Label32.Text = "Apoyo SIEBAN"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(99, 93)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 13)
        Me.Label31.TabIndex = 8
        Me.Label31.Text = "Estrato"
        '
        'txt_capacidad
        '
        Me.txt_capacidad.Location = New System.Drawing.Point(142, 15)
        Me.txt_capacidad.Name = "txt_capacidad"
        Me.txt_capacidad.Size = New System.Drawing.Size(156, 20)
        Me.txt_capacidad.TabIndex = 7
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(35, 20)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(104, 13)
        Me.Label30.TabIndex = 6
        Me.Label30.Text = "Capacidad Instalada"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(68, 48)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 13)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "U. de Medida"
        '
        'txt_jornales
        '
        Me.txt_jornales.Enabled = False
        Me.txt_jornales.Location = New System.Drawing.Point(141, 66)
        Me.txt_jornales.Name = "txt_jornales"
        Me.txt_jornales.Size = New System.Drawing.Size(157, 20)
        Me.txt_jornales.TabIndex = 3
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(92, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Jornales"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(378, 303)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(69, 13)
        Me.Label61.TabIndex = 74
        Me.Label61.Text = "Clase Credito"
        Me.Label61.Visible = False
        '
        'cb_clase
        '
        Me.cb_clase.DataSource = Me.VwconceptosinversionBindingSource
        Me.cb_clase.DisplayMember = "clase"
        Me.cb_clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_clase.FormattingEnabled = True
        Me.cb_clase.Location = New System.Drawing.Point(458, 296)
        Me.cb_clase.Name = "cb_clase"
        Me.cb_clase.Size = New System.Drawing.Size(194, 21)
        Me.cb_clase.TabIndex = 75
        Me.cb_clase.ValueMember = "clase"
        Me.cb_clase.Visible = False
        '
        'VwconceptosinversionBindingSource
        '
        Me.VwconceptosinversionBindingSource.DataMember = "vw_conceptos_inversion"
        Me.VwconceptosinversionBindingSource.DataSource = Me.DS_contratos
        '
        'GENProductosFinagilBindingSource
        '
        Me.GENProductosFinagilBindingSource.DataMember = "GEN_ProductosFinagil"
        Me.GENProductosFinagilBindingSource.DataSource = Me.DS_contratos
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbclientes)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(15, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 105)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(317, 69)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 13)
        Me.Label24.TabIndex = 45
        Me.Label24.Text = "ID_CREDITO"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Descr", True))
        Me.ComboBox1.DataSource = Me.CONTCPFcontratosBindingSource
        Me.ComboBox1.DisplayMember = "id_credito"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(395, 66)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(115, 21)
        Me.ComboBox1.TabIndex = 44
        Me.ComboBox1.ValueMember = "id_contrato"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DS_contratos
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Acreditado"
        '
        'cbclientes
        '
        Me.cbclientes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "Descr", True))
        Me.cbclientes.DataSource = Me.ClientesBindingSource
        Me.cbclientes.DisplayMember = "Descr"
        Me.cbclientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbclientes.FormattingEnabled = True
        Me.cbclientes.Location = New System.Drawing.Point(313, 36)
        Me.cbclientes.Name = "cbclientes"
        Me.cbclientes.Size = New System.Drawing.Size(404, 21)
        Me.cbclientes.TabIndex = 43
        Me.cbclientes.ValueMember = "Cliente"
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(6, 36)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(272, 20)
        Me.txtcliente.TabIndex = 36
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(310, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Selecciona un cliente de la lista"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_intermediariosTableAdapter
        '
        Me.CONT_CPF_intermediariosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_operacionTableAdapter
        '
        Me.CONT_CPF_operacionTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_productos_firaTableAdapter
        '
        Me.CONT_CPF_productos_firaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_sucursalesTableAdapter
        '
        Me.CONT_CPF_sucursalesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_divisasTableAdapter
        '
        Me.CONT_CPF_divisasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_segurosTableAdapter
        '
        Me.CONT_CPF_segurosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_esquema_cobroTableAdapter
        '
        Me.CONT_CPF_esquema_cobroTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_tipo_tasasTableAdapter
        '
        Me.CONT_CPF_tipo_tasasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_ESTATUSTableAdapter
        '
        Me.CONT_CPF_ESTATUSTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_clasificacion_garantiasTableAdapter
        '
        Me.CONT_CPF_clasificacion_garantiasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_periodicidadTableAdapter
        '
        Me.CONT_CPF_periodicidadTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_unidades_medidaTableAdapter
        '
        Me.CONT_CPF_unidades_medidaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_actividadTableAdapter
        '
        Me.CONT_CPF_actividadTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_ramasTableAdapter
        '
        Me.CONT_CPF_ramasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_subramasTableAdapter
        '
        Me.CONT_CPF_subramasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_cadenasTableAdapter
        '
        Me.CONT_CPF_cadenasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_programasTableAdapter
        '
        Me.CONT_CPF_programasTableAdapter.ClearBeforeFill = True
        '
        'Vw_conceptos_inversionTableAdapter
        '
        Me.Vw_conceptos_inversionTableAdapter.ClearBeforeFill = True
        '
        'ViewcadenassubramasBindingSource
        '
        Me.ViewcadenassubramasBindingSource.DataMember = "View_cadenas_subramas"
        Me.ViewcadenassubramasBindingSource.DataSource = Me.DS_contratos
        '
        'View_cadenas_subramasTableAdapter
        '
        Me.View_cadenas_subramasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_tipoprestamosTableAdapter
        '
        Me.CONT_CPF_tipoprestamosTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFconceptosinversionBindingSource
        '
        Me.CONTCPFconceptosinversionBindingSource.DataMember = "CONT_CPF_conceptos_inversion"
        Me.CONTCPFconceptosinversionBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_conceptos_inversionTableAdapter
        '
        Me.CONT_CPF_conceptos_inversionTableAdapter.ClearBeforeFill = True
        '
        'GEN_ProductosFinagilTableAdapter
        '
        Me.GEN_ProductosFinagilTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFconfiguracionBindingSource
        '
        Me.CONTCPFconfiguracionBindingSource.DataMember = "CONT_CPF_configuracion"
        Me.CONTCPFconfiguracionBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_configuracionTableAdapter
        '
        Me.CONT_CPF_configuracionTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_contratosTableAdapter
        '
        Me.CONT_CPF_contratosTableAdapter.ClearBeforeFill = True
        '
        'DS_contratos1
        '
        Me.DS_contratos1.DataSetName = "DS_contratos"
        Me.DS_contratos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CONTCPFministracionesBindingSource
        '
        Me.CONTCPFministracionesBindingSource.DataMember = "CONT_CPF_ministraciones"
        Me.CONTCPFministracionesBindingSource.DataSource = Me.DS_contratos1
        '
        'CONT_CPF_ministracionesTableAdapter
        '
        Me.CONT_CPF_ministracionesTableAdapter.ClearBeforeFill = True
        '
        'CONTCPFvencimientosBindingSource
        '
        Me.CONTCPFvencimientosBindingSource.DataMember = "CONT_CPF_vencimientos"
        Me.CONTCPFvencimientosBindingSource.DataSource = Me.DS_contratos1
        '
        'CONT_CPF_vencimientosTableAdapter
        '
        Me.CONT_CPF_vencimientosTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(788, 302)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 172
        Me.Button1.Text = "Ministraciones"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(788, 334)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 173
        Me.Button2.Text = "Vencimientos"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(788, 363)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 23)
        Me.Button3.TabIndex = 174
        Me.Button3.Text = "CalendarioTasa"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CONT_CPF_GLTableAdapter
        '
        Me.CONT_CPF_GLTableAdapter.ClearBeforeFill = True
        '
        'frm_contrato2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 651)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bt_guardar)
        Me.Name = "frm_contrato2"
        Me.Text = "frm_contrato2"
        Me.TabControl1.ResumeLayout(False)
        Me.lb_ciclo.ResumeLayout(False)
        Me.lb_ciclo.PerformLayout()
        CType(Me.CONTCPFGLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescuentosDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFperiodicidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFtipoprestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFoperacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFESTATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFintermediariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFtipotasasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFesquemacobroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFsegurosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFdivisasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFsucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFproductosfiraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFclasificaciongarantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.CONTCPFconceptosinversionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFperiodicidadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFprogramasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcadenasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFsubramasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFramasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFactividadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFunidadesmedidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VwconceptosinversionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GENProductosFinagilBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewcadenassubramasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFconceptosinversionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFconfiguracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFministracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFvencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bt_guardar As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents lb_ciclo As TabPage
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_aportacion As TextBox
    Friend WithEvents TxtIntermediario As TextBox
    Friend WithEvents Lb_id_contrato As Label
    Friend WithEvents Label63 As Label
    Friend WithEvents Label59 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents cb_periodo_revision As ComboBox
    Friend WithEvents cb_periodo_int As ComboBox
    Friend WithEvents cb_periodo_capital As ComboBox
    Friend WithEvents txt_acreditado As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents cb_prestamo As ComboBox
    Friend WithEvents cb_operacion As ComboBox
    Friend WithEvents Label62 As Label
    Friend WithEvents cb_estatus As ComboBox
    Friend WithEvents cb_clasificacion As ComboBox
    Friend WithEvents Label58 As Label
    Friend WithEvents cb_intermediario As ComboBox
    Friend WithEvents Label57 As Label
    Friend WithEvents txt_BP As TextBox
    Friend WithEvents Label55 As Label
    Friend WithEvents txt_nvsm As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cb_tasa As ComboBox
    Friend WithEvents cb_esquema As ComboBox
    Friend WithEvents cb_seguro As ComboBox
    Friend WithEvents txt_socios As TextBox
    Friend WithEvents cb_divisa As ComboBox
    Friend WithEvents txt_monto As TextBox
    Friend WithEvents cb_sucursal As ComboBox
    Friend WithEvents txt_id_contrato_siiof As TextBox
    Friend WithEvents txt_autorizacion As TextBox
    Friend WithEvents txt_credito As TextBox
    Friend WithEvents cb_producto As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ch_ifnd As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents txt_egresos As TextBox
    Friend WithEvents cb_concepto As ComboBox
    Friend WithEvents txt_localidad As TextBox
    Friend WithEvents cb_periodo As ComboBox
    Friend WithEvents Label60 As Label
    Friend WithEvents txt_estrato As TextBox
    Friend WithEvents dt_febalance As DateTimePicker
    Friend WithEvents Label56 As Label
    Friend WithEvents txt_fondo As TextBox
    Friend WithEvents txt_sieban As TextBox
    Friend WithEvents txt_programaespecial As TextBox
    Friend WithEvents cb_programa As ComboBox
    Friend WithEvents Label53 As Label
    Friend WithEvents cb_cadena As ComboBox
    Friend WithEvents cb_subrama As ComboBox
    Friend WithEvents cb_rama As ComboBox
    Friend WithEvents cb_actividad As ComboBox
    Friend WithEvents Label52 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents Label49 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents txt_utilidad As TextBox
    Friend WithEvents txt_ingresos As TextBox
    Friend WithEvents txt_activototal As TextBox
    Friend WithEvents txt_activofijo As TextBox
    Friend WithEvents txt_capital As TextBox
    Friend WithEvents Label43 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_ingresoneto As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents cb_medida As ComboBox
    Friend WithEvents txt_clave As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_capacidad As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_jornales As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label61 As Label
    Friend WithEvents cb_clase As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbclientes As ComboBox
    Friend WithEvents txtcliente As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DS_contratos As DS_contratos
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As DS_contratosTableAdapters.ClientesTableAdapter
    Friend WithEvents CONTCPFintermediariosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_intermediariosTableAdapter As DS_contratosTableAdapters.CONT_CPF_intermediariosTableAdapter
    Friend WithEvents CONTCPFoperacionBindingSource As BindingSource
    Friend WithEvents CONT_CPF_operacionTableAdapter As DS_contratosTableAdapters.CONT_CPF_operacionTableAdapter
    Friend WithEvents CONTCPFproductosfiraBindingSource As BindingSource
    Friend WithEvents CONT_CPF_productos_firaTableAdapter As DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter
    Friend WithEvents CONTCPFsucursalesBindingSource As BindingSource
    Friend WithEvents CONT_CPF_sucursalesTableAdapter As DS_contratosTableAdapters.CONT_CPF_sucursalesTableAdapter
    Friend WithEvents CONTCPFdivisasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_divisasTableAdapter As DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter
    Friend WithEvents CONTCPFsegurosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_segurosTableAdapter As DS_contratosTableAdapters.CONT_CPF_segurosTableAdapter
    Friend WithEvents CONTCPFesquemacobroBindingSource As BindingSource
    Friend WithEvents CONT_CPF_esquema_cobroTableAdapter As DS_contratosTableAdapters.CONT_CPF_esquema_cobroTableAdapter
    Friend WithEvents CONTCPFtipotasasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_tipo_tasasTableAdapter As DS_contratosTableAdapters.CONT_CPF_tipo_tasasTableAdapter
    Friend WithEvents CONTCPFESTATUSBindingSource As BindingSource
    Friend WithEvents CONT_CPF_ESTATUSTableAdapter As DS_contratosTableAdapters.CONT_CPF_ESTATUSTableAdapter
    Friend WithEvents CONTCPFclasificaciongarantiasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_clasificacion_garantiasTableAdapter As DS_contratosTableAdapters.CONT_CPF_clasificacion_garantiasTableAdapter
    Friend WithEvents CONTCPFperiodicidadBindingSource As BindingSource
    Friend WithEvents CONT_CPF_periodicidadTableAdapter As DS_contratosTableAdapters.CONT_CPF_periodicidadTableAdapter
    Friend WithEvents TXT_FN As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TXT_FB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CONTCPFunidadesmedidaBindingSource As BindingSource
    Friend WithEvents CONT_CPF_unidades_medidaTableAdapter As DS_contratosTableAdapters.CONT_CPF_unidades_medidaTableAdapter
    Friend WithEvents CONTCPFactividadBindingSource As BindingSource
    Friend WithEvents CONT_CPF_actividadTableAdapter As DS_contratosTableAdapters.CONT_CPF_actividadTableAdapter
    Friend WithEvents CONTCPFramasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_ramasTableAdapter As DS_contratosTableAdapters.CONT_CPF_ramasTableAdapter
    Friend WithEvents CONTCPFsubramasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_subramasTableAdapter As DS_contratosTableAdapters.CONT_CPF_subramasTableAdapter
    Friend WithEvents CONTCPFcadenasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_cadenasTableAdapter As DS_contratosTableAdapters.CONT_CPF_cadenasTableAdapter
    Friend WithEvents CONTCPFprogramasBindingSource As BindingSource
    Friend WithEvents CONT_CPF_programasTableAdapter As DS_contratosTableAdapters.CONT_CPF_programasTableAdapter
    Friend WithEvents CONTCPFperiodicidadBindingSource1 As BindingSource
    Friend WithEvents VwconceptosinversionBindingSource As BindingSource
    Friend WithEvents Vw_conceptos_inversionTableAdapter As DS_contratosTableAdapters.vw_conceptos_inversionTableAdapter
    Friend WithEvents ViewcadenassubramasBindingSource As BindingSource
    Friend WithEvents View_cadenas_subramasTableAdapter As DS_contratosTableAdapters.View_cadenas_subramasTableAdapter
    Friend WithEvents CONTCPFtipoprestamosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_tipoprestamosTableAdapter As DS_contratosTableAdapters.CONT_CPF_tipoprestamosTableAdapter
    Friend WithEvents CONTCPFconceptosinversionBindingSource As BindingSource
    Friend WithEvents CONT_CPF_conceptos_inversionTableAdapter As DS_contratosTableAdapters.CONT_CPF_conceptos_inversionTableAdapter
    Friend WithEvents CONTCPFconceptosinversionBindingSource1 As BindingSource
    Friend WithEvents PCXSG_TXT As TextBox
    Friend WithEvents GENProductosFinagilBindingSource As BindingSource
    Friend WithEvents GEN_ProductosFinagilTableAdapter As DS_contratosTableAdapters.GEN_ProductosFinagilTableAdapter
    Friend WithEvents CONTCPFconfiguracionBindingSource As BindingSource
    Friend WithEvents CONT_CPF_configuracionTableAdapter As DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_contratosTableAdapter As DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents Cksubsidio As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents DS_contratos1 As DS_contratos
    Friend WithEvents CONTCPFministracionesBindingSource As BindingSource
    Friend WithEvents CONT_CPF_ministracionesTableAdapter As DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter
    Friend WithEvents CONTCPFvencimientosBindingSource As BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_tiie As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ch_pen As CheckBox
    Friend WithEvents Label65 As Label
    Friend WithEvents CK_FONAGA As CheckBox
    Friend WithEvents Label69 As Label
    Friend WithEvents Label68 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents TXT_EFEC As TextBox
    Friend WithEvents TXT_NOM As TextBox
    Friend WithEvents cb_gl As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents DescuentosDS As DescuentosDS
    Friend WithEvents CONTCPFGLBindingSource As BindingSource
    Friend WithEvents CONT_CPF_GLTableAdapter As DescuentosDSTableAdapters.CONT_CPF_GLTableAdapter
    Friend WithEvents BT_IMPRIMIR As Button
End Class
