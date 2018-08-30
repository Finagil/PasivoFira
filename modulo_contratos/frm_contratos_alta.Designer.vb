<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_contratos_alta
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cbclientes = New System.Windows.Forms.ComboBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos = New Fira_Cartera_Pasiva.DS_contratos()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbanexos = New System.Windows.Forms.ComboBox()
        Me.Vw_AnexosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtcliente = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbanexos2 = New System.Windows.Forms.ComboBox()
        Me.VwdescuentoSABindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lb_ciclo = New System.Windows.Forms.TabPage()
        Me.CK_FEGA = New System.Windows.Forms.CheckBox()
        Me.CONT_CPF_contratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.TXT_CXS = New System.Windows.Forms.TextBox()
        Me.TXT_EFEC = New System.Windows.Forms.TextBox()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.ch_pen = New System.Windows.Forms.CheckBox()
        Me.CONTCPFcontratosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos7 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_aportacion = New System.Windows.Forms.TextBox()
        Me.TxtIntermediario = New System.Windows.Forms.TextBox()
        Me.CONT_CPF_intermediariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lb_id_contrato = New System.Windows.Forms.Label()
        Me.BT_IMPRIMIR = New System.Windows.Forms.Button()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.cb_periodo_revision = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_periodicidadBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos3 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.cb_periodo_int = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_periodicidadBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos2 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.cb_periodo_capital = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_periodicidadBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos1 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.txt_acreditado = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.txt_Suma_G = New System.Windows.Forms.TextBox()
        Me.txt_total_G = New System.Windows.Forms.TextBox()
        Me.Cksubsidio = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cb_prestamo = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_tipoprestamosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_operacion = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_operacionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label62 = New System.Windows.Forms.Label()
        Me.cb_estatus = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_ESTATUSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_clasificacion = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_clasificacion_garantiasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label58 = New System.Windows.Forms.Label()
        Me.cb_intermediario = New System.Windows.Forms.ComboBox()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.txt_tasafija = New System.Windows.Forms.TextBox()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.bt_garantias = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_suma_v = New System.Windows.Forms.TextBox()
        Me.txt_suma_m = New System.Windows.Forms.TextBox()
        Me.txt_total_v = New System.Windows.Forms.TextBox()
        Me.txt_total_m = New System.Windows.Forms.TextBox()
        Me.bt_vencimientos = New System.Windows.Forms.Button()
        Me.bt_ministraciones = New System.Windows.Forms.Button()
        Me.txt_nvsm = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cb_tasa = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_tipo_tasasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_tasa = New System.Windows.Forms.TextBox()
        Me.cb_esquema = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_esquema_cobroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_seguro = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_segurosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_socios = New System.Windows.Forms.TextBox()
        Me.cb_divisa = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_divisasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_monto = New System.Windows.Forms.TextBox()
        Me.cb_sucursal = New System.Windows.Forms.ComboBox()
        Me.CONTCPFcontratosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_sucursalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txt_id_contrato_siiof = New System.Windows.Forms.TextBox()
        Me.txt_autorizacion = New System.Windows.Forms.TextBox()
        Me.txt_credito = New System.Windows.Forms.TextBox()
        Me.cb_producto = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_productos_firaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TXT_SUBRAMA = New System.Windows.Forms.TextBox()
        Me.txt_egresos = New System.Windows.Forms.TextBox()
        Me.cb_concepto = New System.Windows.Forms.ComboBox()
        Me.CONTCPFconceptosinversionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos5 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.txt_localidad = New System.Windows.Forms.TextBox()
        Me.cb_periodo = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_periodicidadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label60 = New System.Windows.Forms.Label()
        Me.txt_estrato = New System.Windows.Forms.TextBox()
        Me.dt_febalance = New System.Windows.Forms.DateTimePicker()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.txt_fondo = New System.Windows.Forms.TextBox()
        Me.txt_sieban = New System.Windows.Forms.TextBox()
        Me.txt_programaespecial = New System.Windows.Forms.TextBox()
        Me.cb_programa = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_programasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label53 = New System.Windows.Forms.Label()
        Me.cb_cadena = New System.Windows.Forms.ComboBox()
        Me.ViewcadenassubramasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_subrama = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_subramasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_rama = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_ramasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cb_actividad = New System.Windows.Forms.ComboBox()
        Me.CONT_CPF_actividadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.CONT_CPF_unidades_medidaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.Vw_conceptos_inversionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_conceptos_inversion_fullBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_cadenasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bt_guardar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtCultivo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ET_CICLO = New System.Windows.Forms.TextBox()
        Me.LB_Z25 = New System.Windows.Forms.TextBox()
        Me.txt_hipo = New System.Windows.Forms.TextBox()
        Me.txt_prenda = New System.Windows.Forms.TextBox()
        Me.txt_tipo = New System.Windows.Forms.TextBox()
        Me.LB_LINEA = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TXTMONEDA = New System.Windows.Forms.TextBox()
        Me.VwAnexos1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos6 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.ClientesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.ClientesTableAdapter()
        Me.CONT_CPF_conceptos_inversionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_municipios_firaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_estados_firaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FIRA_EstadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_productos_firaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter()
        Me.CONT_CPF_tipoprestamosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipoprestamosTableAdapter()
        Me.CONT_CPF_divisasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter()
        Me.CONT_CPF_sucursalesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_sucursalesTableAdapter()
        Me.CONT_CPF_segurosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_segurosTableAdapter()
        Me.CONT_CPF_tipo_tasasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipo_tasasTableAdapter()
        Me.CONT_CPF_esquema_cobroTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_esquema_cobroTableAdapter()
        Me.CONT_CPF_unidades_medidaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_unidades_medidaTableAdapter()
        Me.CONT_CPF_periodicidadTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_periodicidadTableAdapter()
        Me.CONT_CPF_actividadTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_actividadTableAdapter()
        Me.CONT_CPF_ramasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ramasTableAdapter()
        Me.CONT_CPF_programasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_programasTableAdapter()
        Me.CONT_CPF_subramasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_subramasTableAdapter()
        Me.CONT_CPF_cadenasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_cadenasTableAdapter()
        Me.CONT_CPF_contratosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.CONT_CPF_intermediariosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_intermediariosTableAdapter()
        Me.FIRA_EstadosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.FIRA_EstadosTableAdapter()
        Me.Vw_estados_firaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_estados_firaTableAdapter()
        Me.Vw_municipios_firaTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_municipios_firaTableAdapter()
        Me.CONT_CPF_ministracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_ministracionesTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter()
        Me.CONT_CPF_vencimientosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_vencimientosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter()
        Me.CONT_CPF_clasificacion_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_clasificacion_garantiasTableAdapter()
        Me.CONT_CPF_conceptos_inversionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_conceptos_inversionTableAdapter()
        Me.Vw_conceptos_inversionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_conceptos_inversionTableAdapter()
        Me.CONT_CPF_configuracionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_configuracionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter()
        Me.Vw_conceptos_inversion_fullTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_conceptos_inversion_fullTableAdapter()
        Me.CONT_CPF_operacionTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_operacionTableAdapter()
        Me.CONT_CPF_ESTATUSTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ESTATUSTableAdapter()
        Me.ConT_CPF_contratosTableAdapter1 = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter()
        Me.ConT_CPF_contratos_garantiasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter()
        Me.Vw_AnexosTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.Vw_AnexosTableAdapter()
        Me.CONT_CPF_contratosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONT_CPF_contratosBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ViewcadenassubramasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contratos4 = New Fira_Cartera_Pasiva.DS_contratos()
        Me.View_cadenas_subramasTableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.View_cadenas_subramasTableAdapter()
        Me.Vw_descuentoSATableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_descuentoSATableAdapter()
        Me.Vw_Anexos1TableAdapter = New Fira_Cartera_Pasiva.DS_contratosTableAdapters.Vw_Anexos1TableAdapter()
        Me.DScontratos7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CONTCPFcontratosBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_AnexosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VwdescuentoSABindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.lb_ciclo.SuspendLayout()
        CType(Me.CONT_CPF_contratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_intermediariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_periodicidadBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_periodicidadBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_periodicidadBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_tipoprestamosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_operacionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_ESTATUSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_clasificacion_garantiasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_tipo_tasasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_esquema_cobroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_segurosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_divisasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_sucursalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_productos_firaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.CONTCPFconceptosinversionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_periodicidadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_programasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewcadenassubramasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_subramasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_ramasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_actividadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_unidades_medidaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_conceptos_inversionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_conceptos_inversion_fullBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_cadenasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VwAnexos1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_conceptos_inversionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_municipios_firaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_estados_firaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FIRA_EstadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_ministracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_vencimientosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_configuracionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_contratosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_contratosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONT_CPF_contratosBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ViewcadenassubramasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contratos4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DScontratos7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CONTCPFcontratosBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbclientes
        '
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
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DS_contratos
        '
        'DS_contratos
        '
        Me.DS_contratos.DataSetName = "DS_contratos"
        Me.DS_contratos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(310, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 13)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Selecciona un contrato  de la lista"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Acreditado"
        '
        'cbanexos
        '
        Me.cbanexos.DataSource = Me.Vw_AnexosBindingSource
        Me.cbanexos.DisplayMember = "Anexo"
        Me.cbanexos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbanexos.FormattingEnabled = True
        Me.cbanexos.Location = New System.Drawing.Point(313, 76)
        Me.cbanexos.Name = "cbanexos"
        Me.cbanexos.Size = New System.Drawing.Size(116, 21)
        Me.cbanexos.TabIndex = 37
        Me.cbanexos.ValueMember = "Anexo"
        '
        'Vw_AnexosBindingSource
        '
        Me.Vw_AnexosBindingSource.DataMember = "Vw_Anexos"
        Me.Vw_AnexosBindingSource.DataSource = Me.DS_contratos
        '
        'txtcliente
        '
        Me.txtcliente.Location = New System.Drawing.Point(6, 36)
        Me.txtcliente.Name = "txtcliente"
        Me.txtcliente.Size = New System.Drawing.Size(272, 20)
        Me.txtcliente.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbanexos2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbclientes)
        Me.GroupBox1.Controls.Add(Me.txtcliente)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbanexos)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(742, 105)
        Me.GroupBox1.TabIndex = 44
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'cbanexos2
        '
        Me.cbanexos2.DataSource = Me.VwdescuentoSABindingSource
        Me.cbanexos2.DisplayMember = "ANEXO"
        Me.cbanexos2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbanexos2.FormattingEnabled = True
        Me.cbanexos2.Location = New System.Drawing.Point(465, 76)
        Me.cbanexos2.Name = "cbanexos2"
        Me.cbanexos2.Size = New System.Drawing.Size(116, 21)
        Me.cbanexos2.TabIndex = 44
        Me.cbanexos2.ValueMember = "id_credito"
        '
        'VwdescuentoSABindingSource
        '
        Me.VwdescuentoSABindingSource.DataMember = "vw_descuentoSA"
        Me.VwdescuentoSABindingSource.DataSource = Me.DS_contratos
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.lb_ciclo)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Enabled = False
        Me.TabControl1.Location = New System.Drawing.Point(12, 190)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(780, 486)
        Me.TabControl1.TabIndex = 45
        '
        'lb_ciclo
        '
        Me.lb_ciclo.BackColor = System.Drawing.Color.Gainsboro
        Me.lb_ciclo.Controls.Add(Me.CK_FEGA)
        Me.lb_ciclo.Controls.Add(Me.Label69)
        Me.lb_ciclo.Controls.Add(Me.Label68)
        Me.lb_ciclo.Controls.Add(Me.Label67)
        Me.lb_ciclo.Controls.Add(Me.Label66)
        Me.lb_ciclo.Controls.Add(Me.TXT_CXS)
        Me.lb_ciclo.Controls.Add(Me.TXT_EFEC)
        Me.lb_ciclo.Controls.Add(Me.TXT_NOM)
        Me.lb_ciclo.Controls.Add(Me.ch_pen)
        Me.lb_ciclo.Controls.Add(Me.Label65)
        Me.lb_ciclo.Controls.Add(Me.CheckBox1)
        Me.lb_ciclo.Controls.Add(Me.Label28)
        Me.lb_ciclo.Controls.Add(Me.TextBox1)
        Me.lb_ciclo.Controls.Add(Me.Label64)
        Me.lb_ciclo.Controls.Add(Me.Label18)
        Me.lb_ciclo.Controls.Add(Me.txt_aportacion)
        Me.lb_ciclo.Controls.Add(Me.TxtIntermediario)
        Me.lb_ciclo.Controls.Add(Me.Lb_id_contrato)
        Me.lb_ciclo.Controls.Add(Me.BT_IMPRIMIR)
        Me.lb_ciclo.Controls.Add(Me.Label63)
        Me.lb_ciclo.Controls.Add(Me.Label59)
        Me.lb_ciclo.Controls.Add(Me.Label54)
        Me.lb_ciclo.Controls.Add(Me.cb_periodo_revision)
        Me.lb_ciclo.Controls.Add(Me.cb_periodo_int)
        Me.lb_ciclo.Controls.Add(Me.cb_periodo_capital)
        Me.lb_ciclo.Controls.Add(Me.txt_acreditado)
        Me.lb_ciclo.Controls.Add(Me.Label46)
        Me.lb_ciclo.Controls.Add(Me.txt_Suma_G)
        Me.lb_ciclo.Controls.Add(Me.txt_total_G)
        Me.lb_ciclo.Controls.Add(Me.Cksubsidio)
        Me.lb_ciclo.Controls.Add(Me.Label20)
        Me.lb_ciclo.Controls.Add(Me.cb_prestamo)
        Me.lb_ciclo.Controls.Add(Me.cb_operacion)
        Me.lb_ciclo.Controls.Add(Me.Label62)
        Me.lb_ciclo.Controls.Add(Me.cb_estatus)
        Me.lb_ciclo.Controls.Add(Me.cb_clasificacion)
        Me.lb_ciclo.Controls.Add(Me.Label58)
        Me.lb_ciclo.Controls.Add(Me.cb_intermediario)
        Me.lb_ciclo.Controls.Add(Me.Label57)
        Me.lb_ciclo.Controls.Add(Me.txt_tasafija)
        Me.lb_ciclo.Controls.Add(Me.Label55)
        Me.lb_ciclo.Controls.Add(Me.bt_garantias)
        Me.lb_ciclo.Controls.Add(Me.Label16)
        Me.lb_ciclo.Controls.Add(Me.txt_suma_v)
        Me.lb_ciclo.Controls.Add(Me.txt_suma_m)
        Me.lb_ciclo.Controls.Add(Me.txt_total_v)
        Me.lb_ciclo.Controls.Add(Me.txt_total_m)
        Me.lb_ciclo.Controls.Add(Me.bt_vencimientos)
        Me.lb_ciclo.Controls.Add(Me.bt_ministraciones)
        Me.lb_ciclo.Controls.Add(Me.txt_nvsm)
        Me.lb_ciclo.Controls.Add(Me.Label19)
        Me.lb_ciclo.Controls.Add(Me.cb_tasa)
        Me.lb_ciclo.Controls.Add(Me.txt_tasa)
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
        Me.lb_ciclo.Controls.Add(Me.Label14)
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
        Me.lb_ciclo.Location = New System.Drawing.Point(4, 22)
        Me.lb_ciclo.Name = "lb_ciclo"
        Me.lb_ciclo.Padding = New System.Windows.Forms.Padding(3)
        Me.lb_ciclo.Size = New System.Drawing.Size(772, 460)
        Me.lb_ciclo.TabIndex = 0
        Me.lb_ciclo.Text = "Datos Financieros"
        '
        'CK_FEGA
        '
        Me.CK_FEGA.AutoSize = True
        Me.CK_FEGA.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CONT_CPF_contratosBindingSource, "CorteFinMES", True))
        Me.CK_FEGA.Location = New System.Drawing.Point(553, 155)
        Me.CK_FEGA.Name = "CK_FEGA"
        Me.CK_FEGA.Size = New System.Drawing.Size(15, 14)
        Me.CK_FEGA.TabIndex = 205
        Me.CK_FEGA.UseVisualStyleBackColor = True
        '
        'CONT_CPF_contratosBindingSource
        '
        Me.CONT_CPF_contratosBindingSource.DataMember = "CONT_CPF_contratos"
        Me.CONT_CPF_contratosBindingSource.DataSource = Me.DS_contratos
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Location = New System.Drawing.Point(488, 159)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(35, 13)
        Me.Label69.TabIndex = 204
        Me.Label69.Text = "FEGA"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Location = New System.Drawing.Point(682, 131)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(39, 13)
        Me.Label68.TabIndex = 203
        Me.Label68.Text = "% CXS"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Location = New System.Drawing.Point(588, 131)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(45, 13)
        Me.Label67.TabIndex = 202
        Me.Label67.Text = "% EFEC"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Location = New System.Drawing.Point(488, 131)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(43, 13)
        Me.Label66.TabIndex = 201
        Me.Label66.Text = "% NOM"
        '
        'TXT_CXS
        '
        Me.TXT_CXS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "valor_garantia", True))
        Me.TXT_CXS.Location = New System.Drawing.Point(727, 128)
        Me.TXT_CXS.Name = "TXT_CXS"
        Me.TXT_CXS.Size = New System.Drawing.Size(27, 20)
        Me.TXT_CXS.TabIndex = 200
        '
        'TXT_EFEC
        '
        Me.TXT_EFEC.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "valor_garantia", True))
        Me.TXT_EFEC.Location = New System.Drawing.Point(639, 128)
        Me.TXT_EFEC.Name = "TXT_EFEC"
        Me.TXT_EFEC.Size = New System.Drawing.Size(27, 20)
        Me.TXT_EFEC.TabIndex = 199
        '
        'TXT_NOM
        '
        Me.TXT_NOM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "valor_garantia", True))
        Me.TXT_NOM.Location = New System.Drawing.Point(549, 127)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(27, 20)
        Me.TXT_NOM.TabIndex = 198
        '
        'ch_pen
        '
        Me.ch_pen.AutoSize = True
        Me.ch_pen.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CONTCPFcontratosBindingSource1, "Penalizacion", True))
        Me.ch_pen.Location = New System.Drawing.Point(133, 186)
        Me.ch_pen.Name = "ch_pen"
        Me.ch_pen.Size = New System.Drawing.Size(15, 14)
        Me.ch_pen.TabIndex = 197
        Me.ch_pen.UseVisualStyleBackColor = True
        '
        'CONTCPFcontratosBindingSource1
        '
        Me.CONTCPFcontratosBindingSource1.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource1.DataSource = Me.DS_contratos7
        '
        'DS_contratos7
        '
        Me.DS_contratos7.DataSetName = "DS_contratos"
        Me.DS_contratos7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Location = New System.Drawing.Point(51, 186)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(67, 13)
        Me.Label65.TabIndex = 196
        Me.Label65.Text = "Penalización"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CONT_CPF_contratosBindingSource, "CorteFinMES", True))
        Me.CheckBox1.Location = New System.Drawing.Point(554, 247)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 195
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(458, 247)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(90, 13)
        Me.Label28.TabIndex = 194
        Me.Label28.Text = "Corte Int. Fin Mes"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "valor_garantia", True))
        Me.TextBox1.Location = New System.Drawing.Point(555, 222)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 193
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Location = New System.Drawing.Point(449, 225)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(99, 13)
        Me.Label64.TabIndex = 192
        Me.Label64.Text = "Valor Garantía H/P"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(7, 308)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(112, 13)
        Me.Label18.TabIndex = 191
        Me.Label18.Text = "Aportación Acreditado"
        '
        'txt_aportacion
        '
        Me.txt_aportacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "aportacion_acreditado", True))
        Me.txt_aportacion.Enabled = False
        Me.txt_aportacion.Location = New System.Drawing.Point(125, 303)
        Me.txt_aportacion.Name = "txt_aportacion"
        Me.txt_aportacion.Size = New System.Drawing.Size(156, 20)
        Me.txt_aportacion.TabIndex = 190
        '
        'TxtIntermediario
        '
        Me.TxtIntermediario.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_intermediariosBindingSource, "clave", True))
        Me.TxtIntermediario.Location = New System.Drawing.Point(334, 14)
        Me.TxtIntermediario.Name = "TxtIntermediario"
        Me.TxtIntermediario.ReadOnly = True
        Me.TxtIntermediario.Size = New System.Drawing.Size(30, 20)
        Me.TxtIntermediario.TabIndex = 189
        Me.TxtIntermediario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CONT_CPF_intermediariosBindingSource
        '
        Me.CONT_CPF_intermediariosBindingSource.DataMember = "CONT_CPF_intermediarios"
        Me.CONT_CPF_intermediariosBindingSource.DataSource = Me.DS_contratos
        '
        'Lb_id_contrato
        '
        Me.Lb_id_contrato.AutoSize = True
        Me.Lb_id_contrato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "id_contrato", True))
        Me.Lb_id_contrato.Location = New System.Drawing.Point(7, 435)
        Me.Lb_id_contrato.Name = "Lb_id_contrato"
        Me.Lb_id_contrato.Size = New System.Drawing.Size(13, 13)
        Me.Lb_id_contrato.TabIndex = 188
        Me.Lb_id_contrato.Text = "0"
        '
        'BT_IMPRIMIR
        '
        Me.BT_IMPRIMIR.Location = New System.Drawing.Point(609, 434)
        Me.BT_IMPRIMIR.Name = "BT_IMPRIMIR"
        Me.BT_IMPRIMIR.Size = New System.Drawing.Size(104, 23)
        Me.BT_IMPRIMIR.TabIndex = 44
        Me.BT_IMPRIMIR.Text = "Estado de Cuenta"
        Me.BT_IMPRIMIR.UseVisualStyleBackColor = True
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Location = New System.Drawing.Point(402, 317)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(133, 13)
        Me.Label63.TabIndex = 186
        Me.Label63.Text = "Periodo Revision Intereses"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Location = New System.Drawing.Point(442, 290)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(89, 13)
        Me.Label59.TabIndex = 185
        Me.Label59.Text = "Periodo Intereses"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(453, 263)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(78, 13)
        Me.Label54.TabIndex = 184
        Me.Label54.Text = "Periodo Capital"
        '
        'cb_periodo_revision
        '
        Me.cb_periodo_revision.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_periodo_revision", True))
        Me.cb_periodo_revision.DataSource = Me.CONT_CPF_periodicidadBindingSource3
        Me.cb_periodo_revision.DisplayMember = "descripcion"
        Me.cb_periodo_revision.FormattingEnabled = True
        Me.cb_periodo_revision.Location = New System.Drawing.Point(549, 310)
        Me.cb_periodo_revision.Name = "cb_periodo_revision"
        Me.cb_periodo_revision.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_revision.TabIndex = 183
        Me.cb_periodo_revision.ValueMember = "id_periodo"
        '
        'CONT_CPF_periodicidadBindingSource3
        '
        Me.CONT_CPF_periodicidadBindingSource3.DataMember = "CONT_CPF_periodicidad"
        Me.CONT_CPF_periodicidadBindingSource3.DataSource = Me.DS_contratos3
        '
        'DS_contratos3
        '
        Me.DS_contratos3.DataSetName = "DS_contratos"
        Me.DS_contratos3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_periodo_int
        '
        Me.cb_periodo_int.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_periodo_interes", True))
        Me.cb_periodo_int.DataSource = Me.CONT_CPF_periodicidadBindingSource2
        Me.cb_periodo_int.DisplayMember = "descripcion"
        Me.cb_periodo_int.FormattingEnabled = True
        Me.cb_periodo_int.Location = New System.Drawing.Point(549, 287)
        Me.cb_periodo_int.Name = "cb_periodo_int"
        Me.cb_periodo_int.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_int.TabIndex = 182
        Me.cb_periodo_int.ValueMember = "id_periodo"
        '
        'CONT_CPF_periodicidadBindingSource2
        '
        Me.CONT_CPF_periodicidadBindingSource2.DataMember = "CONT_CPF_periodicidad"
        Me.CONT_CPF_periodicidadBindingSource2.DataSource = Me.DS_contratos2
        '
        'DS_contratos2
        '
        Me.DS_contratos2.DataSetName = "DS_contratos"
        Me.DS_contratos2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cb_periodo_capital
        '
        Me.cb_periodo_capital.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_periodo_capital", True))
        Me.cb_periodo_capital.DataSource = Me.CONT_CPF_periodicidadBindingSource1
        Me.cb_periodo_capital.DisplayMember = "descripcion"
        Me.cb_periodo_capital.FormattingEnabled = True
        Me.cb_periodo_capital.Location = New System.Drawing.Point(548, 260)
        Me.cb_periodo_capital.Name = "cb_periodo_capital"
        Me.cb_periodo_capital.Size = New System.Drawing.Size(121, 21)
        Me.cb_periodo_capital.TabIndex = 181
        Me.cb_periodo_capital.ValueMember = "id_periodo"
        '
        'CONT_CPF_periodicidadBindingSource1
        '
        Me.CONT_CPF_periodicidadBindingSource1.DataMember = "CONT_CPF_periodicidad"
        Me.CONT_CPF_periodicidadBindingSource1.DataSource = Me.DS_contratos1
        '
        'DS_contratos1
        '
        Me.DS_contratos1.DataSetName = "DS_contratos"
        Me.DS_contratos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_acreditado
        '
        Me.txt_acreditado.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "ID_acreditado", True))
        Me.txt_acreditado.Location = New System.Drawing.Point(310, 155)
        Me.txt_acreditado.Name = "txt_acreditado"
        Me.txt_acreditado.Size = New System.Drawing.Size(100, 20)
        Me.txt_acreditado.TabIndex = 180
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(232, 163)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(70, 13)
        Me.Label46.TabIndex = 179
        Me.Label46.Text = "Id Acreditado"
        '
        'txt_Suma_G
        '
        Me.txt_Suma_G.Location = New System.Drawing.Point(589, 407)
        Me.txt_Suma_G.Name = "txt_Suma_G"
        Me.txt_Suma_G.ReadOnly = True
        Me.txt_Suma_G.Size = New System.Drawing.Size(124, 20)
        Me.txt_Suma_G.TabIndex = 178
        '
        'txt_total_G
        '
        Me.txt_total_G.Location = New System.Drawing.Point(561, 407)
        Me.txt_total_G.Name = "txt_total_G"
        Me.txt_total_G.ReadOnly = True
        Me.txt_total_G.Size = New System.Drawing.Size(22, 20)
        Me.txt_total_G.TabIndex = 177
        '
        'Cksubsidio
        '
        Me.Cksubsidio.AutoSize = True
        Me.Cksubsidio.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CONT_CPF_contratosBindingSource, "CorteFinMES", True))
        Me.Cksubsidio.Location = New System.Drawing.Point(553, 181)
        Me.Cksubsidio.Name = "Cksubsidio"
        Me.Cksubsidio.Size = New System.Drawing.Size(15, 14)
        Me.Cksubsidio.TabIndex = 174
        Me.Cksubsidio.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(488, 182)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 13)
        Me.Label20.TabIndex = 173
        Me.Label20.Text = "Subsidio"
        '
        'cb_prestamo
        '
        Me.cb_prestamo.DataSource = Me.CONT_CPF_tipoprestamosBindingSource
        Me.cb_prestamo.DisplayMember = "descripcion_prestamo"
        Me.cb_prestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_prestamo.FormattingEnabled = True
        Me.cb_prestamo.Location = New System.Drawing.Point(125, 96)
        Me.cb_prestamo.Name = "cb_prestamo"
        Me.cb_prestamo.Size = New System.Drawing.Size(242, 21)
        Me.cb_prestamo.TabIndex = 172
        Me.cb_prestamo.ValueMember = "id_tipo_prestamo"
        '
        'CONT_CPF_tipoprestamosBindingSource
        '
        Me.CONT_CPF_tipoprestamosBindingSource.DataMember = "CONT_CPF_tipoprestamos"
        Me.CONT_CPF_tipoprestamosBindingSource.DataSource = Me.DS_contratos
        '
        'cb_operacion
        '
        Me.cb_operacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_operacion", True))
        Me.cb_operacion.DataSource = Me.CONT_CPF_operacionBindingSource
        Me.cb_operacion.DisplayMember = "desc"
        Me.cb_operacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_operacion.FormattingEnabled = True
        Me.cb_operacion.Location = New System.Drawing.Point(125, 44)
        Me.cb_operacion.Name = "cb_operacion"
        Me.cb_operacion.Size = New System.Drawing.Size(241, 21)
        Me.cb_operacion.TabIndex = 171
        Me.cb_operacion.ValueMember = "id_operacion"
        '
        'CONT_CPF_operacionBindingSource
        '
        Me.CONT_CPF_operacionBindingSource.DataMember = "CONT_CPF_operacion"
        Me.CONT_CPF_operacionBindingSource.DataSource = Me.DS_contratos
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(32, 53)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(86, 13)
        Me.Label62.TabIndex = 170
        Me.Label62.Text = "Modo Operación"
        '
        'cb_estatus
        '
        Me.cb_estatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_estatus", True))
        Me.cb_estatus.DataSource = Me.CONT_CPF_ESTATUSBindingSource
        Me.cb_estatus.DisplayMember = "estatus"
        Me.cb_estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_estatus.FormattingEnabled = True
        Me.cb_estatus.Location = New System.Drawing.Point(548, 70)
        Me.cb_estatus.Name = "cb_estatus"
        Me.cb_estatus.Size = New System.Drawing.Size(157, 21)
        Me.cb_estatus.TabIndex = 169
        Me.cb_estatus.ValueMember = "id_estatus"
        '
        'CONT_CPF_ESTATUSBindingSource
        '
        Me.CONT_CPF_ESTATUSBindingSource.DataMember = "CONT_CPF_ESTATUS"
        Me.CONT_CPF_ESTATUSBindingSource.DataSource = Me.DS_contratos
        '
        'cb_clasificacion
        '
        Me.cb_clasificacion.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "tipo_garantia", True))
        Me.cb_clasificacion.DataSource = Me.CONT_CPF_clasificacion_garantiasBindingSource
        Me.cb_clasificacion.DisplayMember = "categoria"
        Me.cb_clasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_clasificacion.FormattingEnabled = True
        Me.cb_clasificacion.Location = New System.Drawing.Point(548, 93)
        Me.cb_clasificacion.Name = "cb_clasificacion"
        Me.cb_clasificacion.Size = New System.Drawing.Size(157, 21)
        Me.cb_clasificacion.TabIndex = 168
        Me.cb_clasificacion.ValueMember = "id_clasificacion_garantia"
        '
        'CONT_CPF_clasificacion_garantiasBindingSource
        '
        Me.CONT_CPF_clasificacion_garantiasBindingSource.DataMember = "CONT_CPF_clasificacion_garantias"
        Me.CONT_CPF_clasificacion_garantiasBindingSource.DataSource = Me.DS_contratos
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(456, 73)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(79, 13)
        Me.Label58.TabIndex = 166
        Me.Label58.Text = "Estatus Pagaré"
        '
        'cb_intermediario
        '
        Me.cb_intermediario.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_intermediario", True))
        Me.cb_intermediario.DataSource = Me.CONT_CPF_intermediariosBindingSource
        Me.cb_intermediario.DisplayMember = "nombre_intermediario"
        Me.cb_intermediario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_intermediario.FormattingEnabled = True
        Me.cb_intermediario.Location = New System.Drawing.Point(125, 14)
        Me.cb_intermediario.Name = "cb_intermediario"
        Me.cb_intermediario.Size = New System.Drawing.Size(203, 21)
        Me.cb_intermediario.TabIndex = 165
        Me.cb_intermediario.ValueMember = "id_intermediario"
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
        'txt_tasafija
        '
        Me.txt_tasafija.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "valor_garantia", True))
        Me.txt_tasafija.Location = New System.Drawing.Point(613, 178)
        Me.txt_tasafija.Name = "txt_tasafija"
        Me.txt_tasafija.Size = New System.Drawing.Size(100, 20)
        Me.txt_tasafija.TabIndex = 163
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(574, 182)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(31, 13)
        Me.Label55.TabIndex = 162
        Me.Label55.Text = "Tasa"
        '
        'bt_garantias
        '
        Me.bt_garantias.Location = New System.Drawing.Point(456, 406)
        Me.bt_garantias.Name = "bt_garantias"
        Me.bt_garantias.Size = New System.Drawing.Size(99, 23)
        Me.bt_garantias.TabIndex = 161
        Me.bt_garantias.Text = "Garantías"
        Me.bt_garantias.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(423, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(112, 13)
        Me.Label16.TabIndex = 159
        Me.Label16.Text = "Clasificación  Garantia"
        '
        'txt_suma_v
        '
        Me.txt_suma_v.Location = New System.Drawing.Point(589, 377)
        Me.txt_suma_v.Name = "txt_suma_v"
        Me.txt_suma_v.ReadOnly = True
        Me.txt_suma_v.Size = New System.Drawing.Size(124, 20)
        Me.txt_suma_v.TabIndex = 153
        '
        'txt_suma_m
        '
        Me.txt_suma_m.Location = New System.Drawing.Point(589, 349)
        Me.txt_suma_m.Name = "txt_suma_m"
        Me.txt_suma_m.ReadOnly = True
        Me.txt_suma_m.Size = New System.Drawing.Size(124, 20)
        Me.txt_suma_m.TabIndex = 152
        '
        'txt_total_v
        '
        Me.txt_total_v.Location = New System.Drawing.Point(561, 377)
        Me.txt_total_v.Name = "txt_total_v"
        Me.txt_total_v.ReadOnly = True
        Me.txt_total_v.Size = New System.Drawing.Size(22, 20)
        Me.txt_total_v.TabIndex = 151
        '
        'txt_total_m
        '
        Me.txt_total_m.Location = New System.Drawing.Point(561, 349)
        Me.txt_total_m.Name = "txt_total_m"
        Me.txt_total_m.ReadOnly = True
        Me.txt_total_m.Size = New System.Drawing.Size(22, 20)
        Me.txt_total_m.TabIndex = 150
        '
        'bt_vencimientos
        '
        Me.bt_vencimientos.Location = New System.Drawing.Point(456, 377)
        Me.bt_vencimientos.Name = "bt_vencimientos"
        Me.bt_vencimientos.Size = New System.Drawing.Size(99, 23)
        Me.bt_vencimientos.TabIndex = 149
        Me.bt_vencimientos.Text = "Vencimientos"
        Me.bt_vencimientos.UseVisualStyleBackColor = True
        '
        'bt_ministraciones
        '
        Me.bt_ministraciones.Location = New System.Drawing.Point(456, 348)
        Me.bt_ministraciones.Name = "bt_ministraciones"
        Me.bt_ministraciones.Size = New System.Drawing.Size(99, 23)
        Me.bt_ministraciones.TabIndex = 148
        Me.bt_ministraciones.Text = "Ministraciones"
        Me.bt_ministraciones.UseVisualStyleBackColor = True
        '
        'txt_nvsm
        '
        Me.txt_nvsm.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "mvsm", True))
        Me.txt_nvsm.Location = New System.Drawing.Point(334, 277)
        Me.txt_nvsm.Name = "txt_nvsm"
        Me.txt_nvsm.Size = New System.Drawing.Size(30, 20)
        Me.txt_nvsm.TabIndex = 52
        Me.txt_nvsm.Text = "0"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(244, 280)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(84, 13)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "NVSM por socio"
        '
        'cb_tasa
        '
        Me.cb_tasa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_tipo_tasa", True))
        Me.cb_tasa.DataSource = Me.CONT_CPF_tipo_tasasBindingSource
        Me.cb_tasa.DisplayMember = "des_tipo_tasa"
        Me.cb_tasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_tasa.FormattingEnabled = True
        Me.cb_tasa.Location = New System.Drawing.Point(548, 17)
        Me.cb_tasa.Name = "cb_tasa"
        Me.cb_tasa.Size = New System.Drawing.Size(157, 21)
        Me.cb_tasa.TabIndex = 46
        Me.cb_tasa.ValueMember = "id_tipo_tasa"
        '
        'CONT_CPF_tipo_tasasBindingSource
        '
        Me.CONT_CPF_tipo_tasasBindingSource.DataMember = "CONT_CPF_tipo_tasas"
        Me.CONT_CPF_tipo_tasasBindingSource.DataSource = Me.DS_contratos
        '
        'txt_tasa
        '
        Me.txt_tasa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "Tasas", True))
        Me.txt_tasa.Location = New System.Drawing.Point(548, 46)
        Me.txt_tasa.Name = "txt_tasa"
        Me.txt_tasa.Size = New System.Drawing.Size(33, 20)
        Me.txt_tasa.TabIndex = 45
        Me.txt_tasa.Text = "0"
        '
        'cb_esquema
        '
        Me.cb_esquema.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_esquema_cobro1", True))
        Me.cb_esquema.DataSource = Me.CONT_CPF_esquema_cobroBindingSource
        Me.cb_esquema.DisplayMember = "esquema_cobro"
        Me.cb_esquema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_esquema.FormattingEnabled = True
        Me.cb_esquema.Location = New System.Drawing.Point(125, 361)
        Me.cb_esquema.Name = "cb_esquema"
        Me.cb_esquema.Size = New System.Drawing.Size(243, 21)
        Me.cb_esquema.TabIndex = 44
        Me.cb_esquema.ValueMember = "id_esquema_cobro"
        '
        'CONT_CPF_esquema_cobroBindingSource
        '
        Me.CONT_CPF_esquema_cobroBindingSource.DataMember = "CONT_CPF_esquema_cobro"
        Me.CONT_CPF_esquema_cobroBindingSource.DataSource = Me.DS_contratos
        '
        'cb_seguro
        '
        Me.cb_seguro.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_seguro", True))
        Me.cb_seguro.DataSource = Me.CONT_CPF_segurosBindingSource
        Me.cb_seguro.DisplayMember = "tipo_seguro"
        Me.cb_seguro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_seguro.FormattingEnabled = True
        Me.cb_seguro.Location = New System.Drawing.Point(125, 332)
        Me.cb_seguro.Name = "cb_seguro"
        Me.cb_seguro.Size = New System.Drawing.Size(243, 21)
        Me.cb_seguro.TabIndex = 43
        Me.cb_seguro.ValueMember = "id_seguro"
        '
        'CONT_CPF_segurosBindingSource
        '
        Me.CONT_CPF_segurosBindingSource.DataMember = "CONT_CPF_seguros"
        Me.CONT_CPF_segurosBindingSource.DataSource = Me.DS_contratos
        '
        'txt_socios
        '
        Me.txt_socios.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "num_socios", True))
        Me.txt_socios.Location = New System.Drawing.Point(125, 274)
        Me.txt_socios.Name = "txt_socios"
        Me.txt_socios.Size = New System.Drawing.Size(100, 20)
        Me.txt_socios.TabIndex = 42
        '
        'cb_divisa
        '
        Me.cb_divisa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_divisa", True))
        Me.cb_divisa.DataSource = Me.CONT_CPF_divisasBindingSource
        Me.cb_divisa.DisplayMember = "codigo"
        Me.cb_divisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_divisa.FormattingEnabled = True
        Me.cb_divisa.Location = New System.Drawing.Point(265, 243)
        Me.cb_divisa.Name = "cb_divisa"
        Me.cb_divisa.Size = New System.Drawing.Size(100, 21)
        Me.cb_divisa.TabIndex = 41
        Me.cb_divisa.ValueMember = "id_divisa"
        '
        'CONT_CPF_divisasBindingSource
        '
        Me.CONT_CPF_divisasBindingSource.DataMember = "CONT_CPF_divisas"
        Me.CONT_CPF_divisasBindingSource.DataSource = Me.DS_contratos
        '
        'txt_monto
        '
        Me.txt_monto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "monto", True))
        Me.txt_monto.Location = New System.Drawing.Point(125, 244)
        Me.txt_monto.Name = "txt_monto"
        Me.txt_monto.Size = New System.Drawing.Size(100, 20)
        Me.txt_monto.TabIndex = 40
        '
        'cb_sucursal
        '
        Me.cb_sucursal.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONTCPFcontratosBindingSource, "id_sucursal", True))
        Me.cb_sucursal.DataSource = Me.CONT_CPF_sucursalesBindingSource
        Me.cb_sucursal.DisplayMember = "nombre_sucursal"
        Me.cb_sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_sucursal.FormattingEnabled = True
        Me.cb_sucursal.Location = New System.Drawing.Point(125, 204)
        Me.cb_sucursal.Name = "cb_sucursal"
        Me.cb_sucursal.Size = New System.Drawing.Size(242, 21)
        Me.cb_sucursal.TabIndex = 39
        Me.cb_sucursal.ValueMember = "id_sucursal"
        '
        'CONTCPFcontratosBindingSource
        '
        Me.CONTCPFcontratosBindingSource.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource.DataSource = Me.DS_contratos7
        '
        'CONT_CPF_sucursalesBindingSource
        '
        Me.CONT_CPF_sucursalesBindingSource.DataMember = "CONT_CPF_sucursales"
        Me.CONT_CPF_sucursalesBindingSource.DataSource = Me.DS_contratos
        '
        'txt_id_contrato_siiof
        '
        Me.txt_id_contrato_siiof.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "id_contrato_siiof", True))
        Me.txt_id_contrato_siiof.Location = New System.Drawing.Point(125, 159)
        Me.txt_id_contrato_siiof.Name = "txt_id_contrato_siiof"
        Me.txt_id_contrato_siiof.Size = New System.Drawing.Size(100, 20)
        Me.txt_id_contrato_siiof.TabIndex = 38
        '
        'txt_autorizacion
        '
        Me.txt_autorizacion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "id_autorizacion", True))
        Me.txt_autorizacion.Location = New System.Drawing.Point(309, 123)
        Me.txt_autorizacion.Name = "txt_autorizacion"
        Me.txt_autorizacion.Size = New System.Drawing.Size(100, 20)
        Me.txt_autorizacion.TabIndex = 37
        '
        'txt_credito
        '
        Me.txt_credito.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "id_credito", True))
        Me.txt_credito.Location = New System.Drawing.Point(125, 124)
        Me.txt_credito.Name = "txt_credito"
        Me.txt_credito.Size = New System.Drawing.Size(100, 20)
        Me.txt_credito.TabIndex = 36
        '
        'cb_producto
        '
        Me.cb_producto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_producto", True))
        Me.cb_producto.DataSource = Me.CONT_CPF_productos_firaBindingSource
        Me.cb_producto.DisplayMember = "descripcion_producto_fira"
        Me.cb_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_producto.FormattingEnabled = True
        Me.cb_producto.Location = New System.Drawing.Point(125, 70)
        Me.cb_producto.Name = "cb_producto"
        Me.cb_producto.Size = New System.Drawing.Size(242, 21)
        Me.cb_producto.TabIndex = 34
        Me.cb_producto.ValueMember = "id_producto_fira"
        '
        'CONT_CPF_productos_firaBindingSource
        '
        Me.CONT_CPF_productos_firaBindingSource.DataMember = "CONT_CPF_productos_fira"
        Me.CONT_CPF_productos_firaBindingSource.DataSource = Me.DS_contratos
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(41, 162)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 13)
        Me.Label23.TabIndex = 33
        Me.Label23.Text = "Contrato SIIOF"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(230, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 32
        Me.Label22.Text = "Id Autorización"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(66, 131)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 13)
        Me.Label21.TabIndex = 31
        Me.Label21.Text = "Id Crédito"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(21, 359)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(97, 13)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "Esquema de Cobro"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(438, 49)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(97, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Text = "Tasa IF-Acreditado"
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
        Me.Label12.Location = New System.Drawing.Point(53, 332)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "Tipo Seguro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(65, 13)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "Num. socios"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Sucursal Bancaria"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(81, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Monto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Divisa"
        '
        'ch_ifnd
        '
        Me.ch_ifnd.AutoSize = True
        Me.ch_ifnd.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.CONT_CPF_contratosBindingSource, "participa_IFND", True))
        Me.ch_ifnd.Location = New System.Drawing.Point(554, 206)
        Me.ch_ifnd.Name = "ch_ifnd"
        Me.ch_ifnd.Size = New System.Drawing.Size(15, 14)
        Me.ch_ifnd.TabIndex = 5
        Me.ch_ifnd.UseVisualStyleBackColor = True
        Me.ch_ifnd.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(442, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Participa como IFND"
        Me.Label7.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tipo Préstamo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(68, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Producto"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gainsboro
        Me.TabPage2.Controls.Add(Me.TXT_SUBRAMA)
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
        Me.TabPage2.Size = New System.Drawing.Size(772, 460)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Datos Complementarios"
        '
        'TXT_SUBRAMA
        '
        Me.TXT_SUBRAMA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "id_credito", True))
        Me.TXT_SUBRAMA.Location = New System.Drawing.Point(458, 192)
        Me.TXT_SUBRAMA.Name = "TXT_SUBRAMA"
        Me.TXT_SUBRAMA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_SUBRAMA.TabIndex = 76
        '
        'txt_egresos
        '
        Me.txt_egresos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "egresos", True))
        Me.txt_egresos.Enabled = False
        Me.txt_egresos.Location = New System.Drawing.Point(138, 276)
        Me.txt_egresos.Name = "txt_egresos"
        Me.txt_egresos.Size = New System.Drawing.Size(157, 20)
        Me.txt_egresos.TabIndex = 31
        Me.txt_egresos.Text = "0"
        '
        'cb_concepto
        '
        Me.cb_concepto.DataSource = Me.CONTCPFconceptosinversionBindingSource
        Me.cb_concepto.DisplayMember = "descr"
        Me.cb_concepto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_concepto.FormattingEnabled = True
        Me.cb_concepto.Location = New System.Drawing.Point(359, 418)
        Me.cb_concepto.Name = "cb_concepto"
        Me.cb_concepto.Size = New System.Drawing.Size(373, 21)
        Me.cb_concepto.TabIndex = 73
        Me.cb_concepto.ValueMember = "concepto"
        '
        'CONTCPFconceptosinversionBindingSource
        '
        Me.CONTCPFconceptosinversionBindingSource.DataMember = "CONT_CPF_conceptos_inversion"
        Me.CONTCPFconceptosinversionBindingSource.DataSource = Me.DS_contratos5
        '
        'DS_contratos5
        '
        Me.DS_contratos5.DataSetName = "DS_contratos"
        Me.DS_contratos5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txt_localidad
        '
        Me.txt_localidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "id_localidad", True))
        Me.txt_localidad.Location = New System.Drawing.Point(459, 68)
        Me.txt_localidad.Multiline = True
        Me.txt_localidad.Name = "txt_localidad"
        Me.txt_localidad.Size = New System.Drawing.Size(197, 61)
        Me.txt_localidad.TabIndex = 72
        '
        'cb_periodo
        '
        Me.cb_periodo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_periodo", True))
        Me.cb_periodo.DataSource = Me.CONT_CPF_periodicidadBindingSource
        Me.cb_periodo.DisplayMember = "descripcion"
        Me.cb_periodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_periodo.FormattingEnabled = True
        Me.cb_periodo.Location = New System.Drawing.Point(463, 329)
        Me.cb_periodo.Name = "cb_periodo"
        Me.cb_periodo.Size = New System.Drawing.Size(193, 21)
        Me.cb_periodo.TabIndex = 71
        Me.cb_periodo.ValueMember = "id_periodo"
        Me.cb_periodo.Visible = False
        '
        'CONT_CPF_periodicidadBindingSource
        '
        Me.CONT_CPF_periodicidadBindingSource.DataMember = "CONT_CPF_periodicidad"
        Me.CONT_CPF_periodicidadBindingSource.DataSource = Me.DS_contratos
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(408, 337)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(43, 13)
        Me.Label60.TabIndex = 69
        Me.Label60.Text = "Periodo"
        Me.Label60.Visible = False
        '
        'txt_estrato
        '
        Me.txt_estrato.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "estrato", True))
        Me.txt_estrato.Enabled = False
        Me.txt_estrato.Location = New System.Drawing.Point(141, 92)
        Me.txt_estrato.Name = "txt_estrato"
        Me.txt_estrato.Size = New System.Drawing.Size(157, 20)
        Me.txt_estrato.TabIndex = 67
        '
        'dt_febalance
        '
        Me.dt_febalance.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "fe_balance", True))
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
        Me.txt_fondo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "fondo_reserva", True))
        Me.txt_fondo.Location = New System.Drawing.Point(459, 42)
        Me.txt_fondo.Name = "txt_fondo"
        Me.txt_fondo.Size = New System.Drawing.Size(100, 20)
        Me.txt_fondo.TabIndex = 64
        '
        'txt_sieban
        '
        Me.txt_sieban.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "apoyo_SIEBAN", True))
        Me.txt_sieban.Enabled = False
        Me.txt_sieban.Location = New System.Drawing.Point(458, 15)
        Me.txt_sieban.Name = "txt_sieban"
        Me.txt_sieban.Size = New System.Drawing.Size(100, 20)
        Me.txt_sieban.TabIndex = 57
        '
        'txt_programaespecial
        '
        Me.txt_programaespecial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "programa_especial", True))
        Me.txt_programaespecial.Location = New System.Drawing.Point(137, 328)
        Me.txt_programaespecial.Name = "txt_programaespecial"
        Me.txt_programaespecial.Size = New System.Drawing.Size(157, 20)
        Me.txt_programaespecial.TabIndex = 55
        '
        'cb_programa
        '
        Me.cb_programa.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_programa", True))
        Me.cb_programa.DataSource = Me.CONT_CPF_programasBindingSource
        Me.cb_programa.DisplayMember = "programa"
        Me.cb_programa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_programa.FormattingEnabled = True
        Me.cb_programa.Location = New System.Drawing.Point(463, 303)
        Me.cb_programa.Name = "cb_programa"
        Me.cb_programa.Size = New System.Drawing.Size(193, 21)
        Me.cb_programa.TabIndex = 53
        Me.cb_programa.ValueMember = "id_programa"
        '
        'CONT_CPF_programasBindingSource
        '
        Me.CONT_CPF_programasBindingSource.DataMember = "CONT_CPF_programas"
        Me.CONT_CPF_programasBindingSource.DataSource = Me.DS_contratos
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(403, 310)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(52, 13)
        Me.Label53.TabIndex = 52
        Me.Label53.Text = "Programa"
        '
        'cb_cadena
        '
        Me.cb_cadena.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "cadena", True))
        Me.cb_cadena.DataSource = Me.ViewcadenassubramasBindingSource1
        Me.cb_cadena.DisplayMember = "cadena"
        Me.cb_cadena.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_cadena.FormattingEnabled = True
        Me.cb_cadena.Location = New System.Drawing.Point(463, 276)
        Me.cb_cadena.Name = "cb_cadena"
        Me.cb_cadena.Size = New System.Drawing.Size(193, 21)
        Me.cb_cadena.TabIndex = 51
        Me.cb_cadena.ValueMember = "id_cadena"
        '
        'ViewcadenassubramasBindingSource1
        '
        Me.ViewcadenassubramasBindingSource1.DataMember = "View_cadenas_subramas"
        Me.ViewcadenassubramasBindingSource1.DataSource = Me.DS_contratos
        '
        'cb_subrama
        '
        Me.cb_subrama.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_subrama", True))
        Me.cb_subrama.DataSource = Me.CONT_CPF_subramasBindingSource
        Me.cb_subrama.DisplayMember = "subrama"
        Me.cb_subrama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_subrama.FormattingEnabled = True
        Me.cb_subrama.Location = New System.Drawing.Point(354, 226)
        Me.cb_subrama.Name = "cb_subrama"
        Me.cb_subrama.Size = New System.Drawing.Size(359, 21)
        Me.cb_subrama.TabIndex = 50
        Me.cb_subrama.ValueMember = "id_subrama"
        '
        'CONT_CPF_subramasBindingSource
        '
        Me.CONT_CPF_subramasBindingSource.DataMember = "CONT_CPF_subramas"
        Me.CONT_CPF_subramasBindingSource.DataSource = Me.DS_contratos
        '
        'cb_rama
        '
        Me.cb_rama.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_rama", True))
        Me.cb_rama.DataSource = Me.CONT_CPF_ramasBindingSource
        Me.cb_rama.DisplayMember = "rama"
        Me.cb_rama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_rama.FormattingEnabled = True
        Me.cb_rama.Location = New System.Drawing.Point(459, 165)
        Me.cb_rama.Name = "cb_rama"
        Me.cb_rama.Size = New System.Drawing.Size(193, 21)
        Me.cb_rama.TabIndex = 49
        Me.cb_rama.ValueMember = "id_rama"
        '
        'CONT_CPF_ramasBindingSource
        '
        Me.CONT_CPF_ramasBindingSource.DataMember = "CONT_CPF_ramas"
        Me.CONT_CPF_ramasBindingSource.DataSource = Me.DS_contratos
        '
        'cb_actividad
        '
        Me.cb_actividad.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_actividad", True))
        Me.cb_actividad.DataSource = Me.CONT_CPF_actividadBindingSource
        Me.cb_actividad.DisplayMember = "tipo_actividad"
        Me.cb_actividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_actividad.FormattingEnabled = True
        Me.cb_actividad.Location = New System.Drawing.Point(459, 139)
        Me.cb_actividad.Name = "cb_actividad"
        Me.cb_actividad.Size = New System.Drawing.Size(193, 21)
        Me.cb_actividad.TabIndex = 48
        Me.cb_actividad.ValueMember = "id_actividad"
        '
        'CONT_CPF_actividadBindingSource
        '
        Me.CONT_CPF_actividadBindingSource.DataMember = "CONT_CPF_actividad"
        Me.CONT_CPF_actividadBindingSource.DataSource = Me.DS_contratos
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(351, 284)
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
        Me.Label47.Location = New System.Drawing.Point(341, 388)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(114, 13)
        Me.Label47.TabIndex = 36
        Me.Label47.Text = "Concepto de Inversion"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(571, 368)
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
        Me.txt_utilidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "utilidad", True))
        Me.txt_utilidad.Enabled = False
        Me.txt_utilidad.Location = New System.Drawing.Point(138, 302)
        Me.txt_utilidad.Name = "txt_utilidad"
        Me.txt_utilidad.Size = New System.Drawing.Size(157, 20)
        Me.txt_utilidad.TabIndex = 32
        '
        'txt_ingresos
        '
        Me.txt_ingresos.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "ingresos", True))
        Me.txt_ingresos.Enabled = False
        Me.txt_ingresos.Location = New System.Drawing.Point(139, 249)
        Me.txt_ingresos.Name = "txt_ingresos"
        Me.txt_ingresos.Size = New System.Drawing.Size(156, 20)
        Me.txt_ingresos.TabIndex = 30
        '
        'txt_activototal
        '
        Me.txt_activototal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "activo_total", True))
        Me.txt_activototal.Enabled = False
        Me.txt_activototal.Location = New System.Drawing.Point(140, 222)
        Me.txt_activototal.Name = "txt_activototal"
        Me.txt_activototal.Size = New System.Drawing.Size(155, 20)
        Me.txt_activototal.TabIndex = 29
        '
        'txt_activofijo
        '
        Me.txt_activofijo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "activo_fijo", True))
        Me.txt_activofijo.Enabled = False
        Me.txt_activofijo.Location = New System.Drawing.Point(140, 196)
        Me.txt_activofijo.Name = "txt_activofijo"
        Me.txt_activofijo.Size = New System.Drawing.Size(155, 20)
        Me.txt_activofijo.TabIndex = 28
        '
        'txt_capital
        '
        Me.txt_capital.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "capital_contable", True))
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
        Me.txt_ingresoneto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "ingreso_neto", True))
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
        Me.cb_medida.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "id_umedida", True))
        Me.cb_medida.DataSource = Me.CONT_CPF_unidades_medidaBindingSource
        Me.cb_medida.DisplayMember = "medida"
        Me.cb_medida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_medida.FormattingEnabled = True
        Me.cb_medida.Location = New System.Drawing.Point(142, 40)
        Me.cb_medida.Name = "cb_medida"
        Me.cb_medida.Size = New System.Drawing.Size(156, 21)
        Me.cb_medida.TabIndex = 14
        Me.cb_medida.ValueMember = "id_umedida"
        '
        'CONT_CPF_unidades_medidaBindingSource
        '
        Me.CONT_CPF_unidades_medidaBindingSource.DataMember = "CONT_CPF_unidades_medida"
        Me.CONT_CPF_unidades_medidaBindingSource.DataSource = Me.DS_contratos
        '
        'txt_clave
        '
        Me.txt_clave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_clave.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "clave", True))
        Me.txt_clave.Location = New System.Drawing.Point(463, 355)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(157, 20)
        Me.txt_clave.TabIndex = 13
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(417, 362)
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
        Me.txt_capacidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "capacidad_instalada", True))
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
        Me.txt_jornales.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CONT_CPF_contratosBindingSource, "jornales", True))
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
        Me.Label61.Location = New System.Drawing.Point(382, 362)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(69, 13)
        Me.Label61.TabIndex = 74
        Me.Label61.Text = "Clase Credito"
        Me.Label61.Visible = False
        '
        'cb_clase
        '
        Me.cb_clase.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CONT_CPF_contratosBindingSource, "tipo_garantia", True))
        Me.cb_clase.DataSource = Me.Vw_conceptos_inversionBindingSource
        Me.cb_clase.DisplayMember = "clase"
        Me.cb_clase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_clase.FormattingEnabled = True
        Me.cb_clase.Location = New System.Drawing.Point(463, 354)
        Me.cb_clase.Name = "cb_clase"
        Me.cb_clase.Size = New System.Drawing.Size(194, 21)
        Me.cb_clase.TabIndex = 75
        Me.cb_clase.ValueMember = "clase"
        Me.cb_clase.Visible = False
        '
        'Vw_conceptos_inversionBindingSource
        '
        Me.Vw_conceptos_inversionBindingSource.DataMember = "vw_conceptos_inversion"
        Me.Vw_conceptos_inversionBindingSource.DataSource = Me.DS_contratos
        '
        'Vw_conceptos_inversion_fullBindingSource
        '
        Me.Vw_conceptos_inversion_fullBindingSource.DataMember = "vw_conceptos_inversion_full"
        Me.Vw_conceptos_inversion_fullBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_cadenasBindingSource
        '
        Me.CONT_CPF_cadenasBindingSource.DataMember = "CONT_CPF_cadenas"
        Me.CONT_CPF_cadenasBindingSource.DataSource = Me.DS_contratos
        '
        'bt_guardar
        '
        Me.bt_guardar.Enabled = False
        Me.bt_guardar.Location = New System.Drawing.Point(655, 27)
        Me.bt_guardar.Name = "bt_guardar"
        Me.bt_guardar.Size = New System.Drawing.Size(81, 23)
        Me.bt_guardar.TabIndex = 147
        Me.bt_guardar.Text = "Guardar"
        Me.bt_guardar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtCultivo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.ET_CICLO)
        Me.GroupBox2.Controls.Add(Me.LB_Z25)
        Me.GroupBox2.Controls.Add(Me.txt_hipo)
        Me.GroupBox2.Controls.Add(Me.txt_prenda)
        Me.GroupBox2.Controls.Add(Me.txt_tipo)
        Me.GroupBox2.Controls.Add(Me.LB_LINEA)
        Me.GroupBox2.Controls.Add(Me.bt_guardar)
        Me.GroupBox2.Controls.Add(Me.Label48)
        Me.GroupBox2.Controls.Add(Me.Label37)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.TXTMONEDA)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 123)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 61)
        Me.GroupBox2.TabIndex = 169
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Contrato"
        '
        'TxtCultivo
        '
        Me.TxtCultivo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "Cultivo", True))
        Me.TxtCultivo.Location = New System.Drawing.Point(545, 32)
        Me.TxtCultivo.Name = "TxtCultivo"
        Me.TxtCultivo.ReadOnly = True
        Me.TxtCultivo.Size = New System.Drawing.Size(58, 20)
        Me.TxtCultivo.TabIndex = 155
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(545, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Cultivo"
        '
        'ET_CICLO
        '
        Me.ET_CICLO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "Ciclo", True))
        Me.ET_CICLO.Location = New System.Drawing.Point(308, 33)
        Me.ET_CICLO.Name = "ET_CICLO"
        Me.ET_CICLO.ReadOnly = True
        Me.ET_CICLO.Size = New System.Drawing.Size(106, 20)
        Me.ET_CICLO.TabIndex = 153
        '
        'LB_Z25
        '
        Me.LB_Z25.Cursor = System.Windows.Forms.Cursors.Cross
        Me.LB_Z25.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "Z25", True))
        Me.LB_Z25.Location = New System.Drawing.Point(228, 33)
        Me.LB_Z25.Name = "LB_Z25"
        Me.LB_Z25.ReadOnly = True
        Me.LB_Z25.Size = New System.Drawing.Size(74, 20)
        Me.LB_Z25.TabIndex = 152
        '
        'txt_hipo
        '
        Me.txt_hipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "GHipotec", True))
        Me.txt_hipo.Location = New System.Drawing.Point(164, 33)
        Me.txt_hipo.Name = "txt_hipo"
        Me.txt_hipo.ReadOnly = True
        Me.txt_hipo.Size = New System.Drawing.Size(58, 20)
        Me.txt_hipo.TabIndex = 151
        '
        'txt_prenda
        '
        Me.txt_prenda.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "Prenda", True))
        Me.txt_prenda.Location = New System.Drawing.Point(107, 33)
        Me.txt_prenda.Name = "txt_prenda"
        Me.txt_prenda.ReadOnly = True
        Me.txt_prenda.Size = New System.Drawing.Size(51, 20)
        Me.txt_prenda.TabIndex = 150
        '
        'txt_tipo
        '
        Me.txt_tipo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "TipoCredito", True))
        Me.txt_tipo.Location = New System.Drawing.Point(420, 32)
        Me.txt_tipo.Name = "txt_tipo"
        Me.txt_tipo.ReadOnly = True
        Me.txt_tipo.Size = New System.Drawing.Size(119, 20)
        Me.txt_tipo.TabIndex = 149
        '
        'LB_LINEA
        '
        Me.LB_LINEA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Vw_AnexosBindingSource, "MontoFinanciado", True))
        Me.LB_LINEA.Location = New System.Drawing.Point(9, 33)
        Me.LB_LINEA.Name = "LB_LINEA"
        Me.LB_LINEA.ReadOnly = True
        Me.LB_LINEA.Size = New System.Drawing.Size(92, 20)
        Me.LB_LINEA.TabIndex = 148
        Me.LB_LINEA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(310, 16)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(30, 13)
        Me.Label48.TabIndex = 11
        Me.Label48.Text = "Ciclo"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(228, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(74, 13)
        Me.Label37.TabIndex = 6
        Me.Label37.Text = "Programa Z25"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(161, 16)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(61, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "Hipotecaria"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(103, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(52, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "Prendaria"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(417, 16)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(64, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Tipo Credito"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(9, 16)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Línea Autorizada"
        '
        'TXTMONEDA
        '
        Me.TXTMONEDA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VwAnexos1BindingSource, "Moneda", True))
        Me.TXTMONEDA.Location = New System.Drawing.Point(420, 32)
        Me.TXTMONEDA.Name = "TXTMONEDA"
        Me.TXTMONEDA.ReadOnly = True
        Me.TXTMONEDA.Size = New System.Drawing.Size(61, 20)
        Me.TXTMONEDA.TabIndex = 156
        Me.TXTMONEDA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'VwAnexos1BindingSource
        '
        Me.VwAnexos1BindingSource.DataMember = "Vw_Anexos1"
        Me.VwAnexos1BindingSource.DataSource = Me.DS_contratos6
        '
        'DS_contratos6
        '
        Me.DS_contratos6.DataSetName = "DS_contratos"
        Me.DS_contratos6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_conceptos_inversionBindingSource
        '
        Me.CONT_CPF_conceptos_inversionBindingSource.DataMember = "CONT_CPF_conceptos_inversion"
        Me.CONT_CPF_conceptos_inversionBindingSource.DataSource = Me.DS_contratos
        '
        'Vw_municipios_firaBindingSource
        '
        Me.Vw_municipios_firaBindingSource.DataMember = "vw_municipios_fira"
        Me.Vw_municipios_firaBindingSource.DataSource = Me.DS_contratos
        '
        'Vw_estados_firaBindingSource
        '
        Me.Vw_estados_firaBindingSource.DataMember = "vw_estados_fira"
        Me.Vw_estados_firaBindingSource.DataSource = Me.DS_contratos
        '
        'FIRA_EstadosBindingSource
        '
        Me.FIRA_EstadosBindingSource.DataMember = "FIRA_Estados"
        Me.FIRA_EstadosBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_productos_firaTableAdapter
        '
        Me.CONT_CPF_productos_firaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_tipoprestamosTableAdapter
        '
        Me.CONT_CPF_tipoprestamosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_divisasTableAdapter
        '
        Me.CONT_CPF_divisasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_sucursalesTableAdapter
        '
        Me.CONT_CPF_sucursalesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_segurosTableAdapter
        '
        Me.CONT_CPF_segurosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_tipo_tasasTableAdapter
        '
        Me.CONT_CPF_tipo_tasasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_esquema_cobroTableAdapter
        '
        Me.CONT_CPF_esquema_cobroTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_unidades_medidaTableAdapter
        '
        Me.CONT_CPF_unidades_medidaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_periodicidadTableAdapter
        '
        Me.CONT_CPF_periodicidadTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_actividadTableAdapter
        '
        Me.CONT_CPF_actividadTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_ramasTableAdapter
        '
        Me.CONT_CPF_ramasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_programasTableAdapter
        '
        Me.CONT_CPF_programasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_subramasTableAdapter
        '
        Me.CONT_CPF_subramasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_cadenasTableAdapter
        '
        Me.CONT_CPF_cadenasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_contratosTableAdapter
        '
        Me.CONT_CPF_contratosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_intermediariosTableAdapter
        '
        Me.CONT_CPF_intermediariosTableAdapter.ClearBeforeFill = True
        '
        'FIRA_EstadosTableAdapter
        '
        Me.FIRA_EstadosTableAdapter.ClearBeforeFill = True
        '
        'Vw_estados_firaTableAdapter
        '
        Me.Vw_estados_firaTableAdapter.ClearBeforeFill = True
        '
        'Vw_municipios_firaTableAdapter
        '
        Me.Vw_municipios_firaTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_ministracionesBindingSource
        '
        Me.CONT_CPF_ministracionesBindingSource.DataMember = "CONT_CPF_ministraciones"
        Me.CONT_CPF_ministracionesBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_ministracionesTableAdapter
        '
        Me.CONT_CPF_ministracionesTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_vencimientosBindingSource
        '
        Me.CONT_CPF_vencimientosBindingSource.DataMember = "CONT_CPF_vencimientos"
        Me.CONT_CPF_vencimientosBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_vencimientosTableAdapter
        '
        Me.CONT_CPF_vencimientosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_clasificacion_garantiasTableAdapter
        '
        Me.CONT_CPF_clasificacion_garantiasTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_conceptos_inversionTableAdapter
        '
        Me.CONT_CPF_conceptos_inversionTableAdapter.ClearBeforeFill = True
        '
        'Vw_conceptos_inversionTableAdapter
        '
        Me.Vw_conceptos_inversionTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_configuracionBindingSource
        '
        Me.CONT_CPF_configuracionBindingSource.DataMember = "CONT_CPF_configuracion"
        Me.CONT_CPF_configuracionBindingSource.DataSource = Me.DS_contratos
        '
        'CONT_CPF_configuracionTableAdapter
        '
        Me.CONT_CPF_configuracionTableAdapter.ClearBeforeFill = True
        '
        'Vw_conceptos_inversion_fullTableAdapter
        '
        Me.Vw_conceptos_inversion_fullTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_operacionTableAdapter
        '
        Me.CONT_CPF_operacionTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_ESTATUSTableAdapter
        '
        Me.CONT_CPF_ESTATUSTableAdapter.ClearBeforeFill = True
        '
        'ConT_CPF_contratosTableAdapter1
        '
        Me.ConT_CPF_contratosTableAdapter1.ClearBeforeFill = True
        '
        'ConT_CPF_contratos_garantiasTableAdapter
        '
        Me.ConT_CPF_contratos_garantiasTableAdapter.ClearBeforeFill = True
        '
        'Vw_AnexosTableAdapter
        '
        Me.Vw_AnexosTableAdapter.ClearBeforeFill = True
        '
        'CONT_CPF_contratosBindingSource1
        '
        Me.CONT_CPF_contratosBindingSource1.DataMember = "CONT_CPF_contratos"
        Me.CONT_CPF_contratosBindingSource1.DataSource = Me.DS_contratos1
        '
        'CONT_CPF_contratosBindingSource2
        '
        Me.CONT_CPF_contratosBindingSource2.DataMember = "CONT_CPF_contratos"
        Me.CONT_CPF_contratosBindingSource2.DataSource = Me.DS_contratos2
        '
        'CONT_CPF_contratosBindingSource3
        '
        Me.CONT_CPF_contratosBindingSource3.DataMember = "CONT_CPF_contratos"
        Me.CONT_CPF_contratosBindingSource3.DataSource = Me.DS_contratos3
        '
        'ViewcadenassubramasBindingSource
        '
        Me.ViewcadenassubramasBindingSource.DataMember = "View_cadenas_subramas"
        Me.ViewcadenassubramasBindingSource.DataSource = Me.DS_contratos4
        '
        'DS_contratos4
        '
        Me.DS_contratos4.DataSetName = "DS_contratos"
        Me.DS_contratos4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'View_cadenas_subramasTableAdapter
        '
        Me.View_cadenas_subramasTableAdapter.ClearBeforeFill = True
        '
        'Vw_descuentoSATableAdapter
        '
        Me.Vw_descuentoSATableAdapter.ClearBeforeFill = True
        '
        'Vw_Anexos1TableAdapter
        '
        Me.Vw_Anexos1TableAdapter.ClearBeforeFill = True
        '
        'DScontratos7BindingSource
        '
        Me.DScontratos7BindingSource.DataSource = Me.DS_contratos7
        Me.DScontratos7BindingSource.Position = 0
        '
        'CONTCPFcontratosBindingSource2
        '
        Me.CONTCPFcontratosBindingSource2.DataMember = "CONT_CPF_contratos"
        Me.CONTCPFcontratosBindingSource2.DataSource = Me.DS_contratos7
        '
        'frm_contratos_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(858, 717)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_contratos_alta"
        Me.Text = "Consultas"
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_AnexosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VwdescuentoSABindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.lb_ciclo.ResumeLayout(False)
        Me.lb_ciclo.PerformLayout()
        CType(Me.CONT_CPF_contratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_intermediariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_periodicidadBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_periodicidadBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_periodicidadBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_tipoprestamosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_operacionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_ESTATUSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_clasificacion_garantiasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_tipo_tasasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_esquema_cobroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_segurosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_divisasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_sucursalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_productos_firaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.CONTCPFconceptosinversionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_periodicidadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_programasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewcadenassubramasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_subramasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_ramasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_actividadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_unidades_medidaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_conceptos_inversionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_conceptos_inversion_fullBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_cadenasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VwAnexos1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_conceptos_inversionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_municipios_firaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_estados_firaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FIRA_EstadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_ministracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_vencimientosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_configuracionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_contratosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_contratosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONT_CPF_contratosBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ViewcadenassubramasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contratos4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DScontratos7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CONTCPFcontratosBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cbclientes As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbanexos As System.Windows.Forms.ComboBox
    Friend WithEvents txtcliente As System.Windows.Forms.TextBox
    Friend WithEvents DS_contratos As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.ClientesTableAdapter
    Friend WithEvents Vw_AnexosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_productos_firaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_productos_firaTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_productos_firaTableAdapter
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_tipoprestamosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_tipoprestamosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipoprestamosTableAdapter
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ch_ifnd As System.Windows.Forms.CheckBox
    Friend WithEvents CONT_CPF_divisasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_divisasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_divisasTableAdapter
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_sucursalesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_sucursalesTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_sucursalesTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_segurosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_segurosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_segurosTableAdapter
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_tipo_tasasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_tipo_tasasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_tipo_tasasTableAdapter
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_esquema_cobroBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_esquema_cobroTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_esquema_cobroTableAdapter
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents bt_guardar As System.Windows.Forms.Button
    Friend WithEvents bt_ministraciones As System.Windows.Forms.Button
    Friend WithEvents bt_vencimientos As System.Windows.Forms.Button
    Friend WithEvents txt_id_contrato_siiof As System.Windows.Forms.TextBox
    Friend WithEvents txt_autorizacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_credito As System.Windows.Forms.TextBox
    Friend WithEvents cb_producto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_tasa As System.Windows.Forms.ComboBox
    Friend WithEvents txt_tasa As System.Windows.Forms.TextBox
    Friend WithEvents cb_esquema As System.Windows.Forms.ComboBox
    Friend WithEvents cb_seguro As System.Windows.Forms.ComboBox
    Friend WithEvents txt_socios As System.Windows.Forms.TextBox
    Friend WithEvents cb_divisa As System.Windows.Forms.ComboBox
    Friend WithEvents txt_monto As System.Windows.Forms.TextBox
    Friend WithEvents cb_sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nvsm As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_total_m As System.Windows.Forms.TextBox
    Friend WithEvents txt_suma_v As System.Windows.Forms.TextBox
    Friend WithEvents txt_suma_m As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_v As System.Windows.Forms.TextBox
    Friend WithEvents txt_clave As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txt_capacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txt_jornales As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txt_ingresoneto As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cb_medida As System.Windows.Forms.ComboBox
    Friend WithEvents txt_utilidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_ingresos As System.Windows.Forms.TextBox
    Friend WithEvents txt_activototal As System.Windows.Forms.TextBox
    Friend WithEvents txt_activofijo As System.Windows.Forms.TextBox
    Friend WithEvents txt_capital As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_unidades_medidaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_unidades_medidaTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_unidades_medidaTableAdapter
    Friend WithEvents CONT_CPF_periodicidadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_periodicidadTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_periodicidadTableAdapter
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_actividadBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_actividadTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_actividadTableAdapter
    Friend WithEvents CONT_CPF_ramasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_ramasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ramasTableAdapter
    Friend WithEvents CONT_CPF_programasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_programasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_programasTableAdapter
    Friend WithEvents CONT_CPF_subramasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_subramasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_subramasTableAdapter
    Friend WithEvents cb_subrama As System.Windows.Forms.ComboBox
    Friend WithEvents cb_rama As System.Windows.Forms.ComboBox
    Friend WithEvents cb_actividad As System.Windows.Forms.ComboBox
    Friend WithEvents cb_cadena As System.Windows.Forms.ComboBox
    Friend WithEvents CONT_CPF_cadenasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_cadenasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_cadenasTableAdapter
    Friend WithEvents cb_programa As System.Windows.Forms.ComboBox
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents txt_sieban As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents bt_garantias As System.Windows.Forms.Button
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents txt_fondo As System.Windows.Forms.TextBox
    Friend WithEvents dt_febalance As System.Windows.Forms.DateTimePicker
    Friend WithEvents CONT_CPF_contratosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents cb_intermediario As System.Windows.Forms.ComboBox
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_intermediariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_intermediariosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_intermediariosTableAdapter
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txt_estrato As System.Windows.Forms.TextBox
    Friend WithEvents FIRA_EstadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FIRA_EstadosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.FIRA_EstadosTableAdapter
    Friend WithEvents txt_programaespecial As System.Windows.Forms.TextBox
    Friend WithEvents cb_periodo As System.Windows.Forms.ComboBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Vw_estados_firaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_estados_firaTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_estados_firaTableAdapter
    Friend WithEvents Vw_municipios_firaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_municipios_firaTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_municipios_firaTableAdapter
    Friend WithEvents CONT_CPF_ministracionesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_ministracionesTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ministracionesTableAdapter
    Friend WithEvents CONT_CPF_vencimientosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_vencimientosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_vencimientosTableAdapter
    Friend WithEvents txt_localidad As System.Windows.Forms.TextBox
    Friend WithEvents cb_concepto As System.Windows.Forms.ComboBox
    Friend WithEvents cb_clasificacion As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cb_estatus As System.Windows.Forms.ComboBox
    Friend WithEvents CONT_CPF_clasificacion_garantiasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_clasificacion_garantiasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_clasificacion_garantiasTableAdapter
    Friend WithEvents CONT_CPF_conceptos_inversionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_conceptos_inversionTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_conceptos_inversionTableAdapter
    Friend WithEvents cb_clase As System.Windows.Forms.ComboBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Vw_conceptos_inversionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_conceptos_inversionTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_conceptos_inversionTableAdapter
    Friend WithEvents CONT_CPF_configuracionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_configuracionTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_configuracionTableAdapter
    Friend WithEvents Vw_conceptos_inversion_fullBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Vw_conceptos_inversion_fullTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.vw_conceptos_inversion_fullTableAdapter
    Friend WithEvents cb_operacion As System.Windows.Forms.ComboBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents CONT_CPF_operacionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_operacionTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_operacionTableAdapter
    Friend WithEvents CONT_CPF_ESTATUSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_ESTATUSTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_ESTATUSTableAdapter
    Friend WithEvents cb_prestamo As System.Windows.Forms.ComboBox
    Friend WithEvents CONT_CPF_contratosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConT_CPF_contratosTableAdapter1 As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratosTableAdapter
    Friend WithEvents txt_egresos As System.Windows.Forms.TextBox
    Friend WithEvents txt_tipo As System.Windows.Forms.TextBox
    Friend WithEvents LB_LINEA As System.Windows.Forms.TextBox
    Friend WithEvents ET_CICLO As System.Windows.Forms.TextBox
    Friend WithEvents LB_Z25 As System.Windows.Forms.TextBox
    Friend WithEvents txt_hipo As System.Windows.Forms.TextBox
    Friend WithEvents txt_prenda As System.Windows.Forms.TextBox
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents TxtCultivo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ConT_CPF_contratos_garantiasTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.CONT_CPF_contratos_garantiasTableAdapter
    Friend WithEvents Vw_AnexosTableAdapter As Fira_Cartera_Pasiva.DS_contratosTableAdapters.Vw_AnexosTableAdapter
    Friend WithEvents txt_Suma_G As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_G As System.Windows.Forms.TextBox
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txt_acreditado As System.Windows.Forms.TextBox
    Friend WithEvents cb_periodo_revision As System.Windows.Forms.ComboBox
    Friend WithEvents cb_periodo_int As System.Windows.Forms.ComboBox
    Friend WithEvents cb_periodo_capital As System.Windows.Forms.ComboBox
    Friend WithEvents DS_contratos1 As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents DS_contratos2 As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents DS_contratos3 As Fira_Cartera_Pasiva.DS_contratos
    Friend WithEvents CONT_CPF_contratosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_contratosBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_contratosBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_periodicidadBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_periodicidadBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CONT_CPF_periodicidadBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents BT_IMPRIMIR As System.Windows.Forms.Button
    Friend WithEvents lb_ciclo As System.Windows.Forms.TabPage
    Friend WithEvents Lb_id_contrato As Label
    Friend WithEvents TxtIntermediario As TextBox
    Friend WithEvents ViewcadenassubramasBindingSource As BindingSource
    Friend WithEvents DS_contratos4 As DS_contratos
    Friend WithEvents View_cadenas_subramasTableAdapter As DS_contratosTableAdapters.View_cadenas_subramasTableAdapter
    Friend WithEvents ViewcadenassubramasBindingSource1 As BindingSource
    Friend WithEvents DS_contratos5 As DS_contratos
    Friend WithEvents CONTCPFconceptosinversionBindingSource As BindingSource
    Friend WithEvents Label18 As Label
    Friend WithEvents txt_aportacion As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label64 As Label
    Friend WithEvents cbanexos2 As ComboBox
    Friend WithEvents VwdescuentoSABindingSource As BindingSource
    Friend WithEvents Vw_descuentoSATableAdapter As DS_contratosTableAdapters.vw_descuentoSATableAdapter
    Friend WithEvents TXTMONEDA As TextBox
    Friend WithEvents DS_contratos6 As DS_contratos
    Friend WithEvents VwAnexos1BindingSource As BindingSource
    Friend WithEvents Vw_Anexos1TableAdapter As DS_contratosTableAdapters.Vw_Anexos1TableAdapter
    Friend WithEvents TXT_SUBRAMA As TextBox
    Friend WithEvents DScontratos7BindingSource As BindingSource
    Friend WithEvents DS_contratos7 As DS_contratos
    Friend WithEvents ch_pen As CheckBox
    Friend WithEvents Label65 As Label
    Friend WithEvents Cksubsidio As CheckBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txt_tasafija As TextBox
    Friend WithEvents CONTCPFcontratosBindingSource As BindingSource
    Friend WithEvents CONTCPFcontratosBindingSource1 As BindingSource
    Friend WithEvents CONTCPFcontratosBindingSource2 As BindingSource
    Friend WithEvents TXT_CXS As TextBox
    Friend WithEvents TXT_EFEC As TextBox
    Friend WithEvents TXT_NOM As TextBox
    Friend WithEvents Label68 As Label
    Friend WithEvents Label67 As Label
    Friend WithEvents Label66 As Label
    Friend WithEvents CK_FEGA As CheckBox
    Friend WithEvents Label69 As Label
End Class
