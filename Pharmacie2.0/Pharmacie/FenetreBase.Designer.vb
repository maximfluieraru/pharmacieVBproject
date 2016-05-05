<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FenetreBase
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FenetreBase))
        Me.pnlResultRecherche = New System.Windows.Forms.Panel()
        Me.btnModiFClint = New System.Windows.Forms.CheckBox()
        Me.dgridVwClient = New System.Windows.Forms.DataGridView()
        Me.pnlRecherche = New System.Windows.Forms.Panel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.comBxBDay = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.comBxNom = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comBxPrenom = New System.Windows.Forms.ComboBox()
        Me.pnlOrdonnace = New System.Windows.Forms.Panel()
        Me.btnModifMedic = New System.Windows.Forms.CheckBox()
        Me.dGVwMedicam = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnModifieOrdon = New System.Windows.Forms.CheckBox()
        Me.dgVwOrdon = New System.Windows.Forms.DataGridView()
        Me.clm1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clm5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAnnulPrescr = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.menuMod_QUIT = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.menuQuiter = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAjouter = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAjoutClient = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAjoutOrdon = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAjouterEmpl = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFO = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblsetNomUtil = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.comMedicam = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlResultRecherche.SuspendLayout()
        CType(Me.dgridVwClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRecherche.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pnlOrdonnace.SuspendLayout()
        CType(Me.dGVwMedicam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgVwOrdon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlResultRecherche
        '
        Me.pnlResultRecherche.BackColor = System.Drawing.Color.Transparent
        Me.pnlResultRecherche.Controls.Add(Me.btnModiFClint)
        Me.pnlResultRecherche.Controls.Add(Me.dgridVwClient)
        Me.pnlResultRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlResultRecherche.Location = New System.Drawing.Point(0, 268)
        Me.pnlResultRecherche.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlResultRecherche.Name = "pnlResultRecherche"
        Me.pnlResultRecherche.Size = New System.Drawing.Size(564, 341)
        Me.pnlResultRecherche.TabIndex = 0
        '
        'btnModiFClint
        '
        Me.btnModiFClint.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnModiFClint.AutoSize = True
        Me.btnModiFClint.Location = New System.Drawing.Point(494, 313)
        Me.btnModiFClint.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModiFClint.Name = "btnModiFClint"
        Me.btnModiFClint.Size = New System.Drawing.Size(54, 23)
        Me.btnModiFClint.TabIndex = 12
        Me.btnModiFClint.Text = "Modifier"
        Me.btnModiFClint.UseVisualStyleBackColor = True
        '
        'dgridVwClient
        '
        Me.dgridVwClient.AllowUserToOrderColumns = True
        Me.dgridVwClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgridVwClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgridVwClient.BackgroundColor = System.Drawing.Color.White
        Me.dgridVwClient.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridVwClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridVwClient.GridColor = System.Drawing.Color.White
        Me.dgridVwClient.Location = New System.Drawing.Point(2, 2)
        Me.dgridVwClient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgridVwClient.Name = "dgridVwClient"
        Me.dgridVwClient.ReadOnly = True
        Me.dgridVwClient.RowHeadersVisible = False
        Me.dgridVwClient.RowTemplate.Height = 33
        Me.dgridVwClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridVwClient.Size = New System.Drawing.Size(558, 307)
        Me.dgridVwClient.TabIndex = 11
        '
        'pnlRecherche
        '
        Me.pnlRecherche.BackColor = System.Drawing.Color.GreenYellow
        Me.pnlRecherche.Controls.Add(Me.GroupBox3)
        Me.pnlRecherche.Controls.Add(Me.Label1)
        Me.pnlRecherche.Controls.Add(Me.GroupBox2)
        Me.pnlRecherche.Controls.Add(Me.GroupBox1)
        Me.pnlRecherche.Location = New System.Drawing.Point(34, 49)
        Me.pnlRecherche.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlRecherche.Name = "pnlRecherche"
        Me.pnlRecherche.Size = New System.Drawing.Size(190, 169)
        Me.pnlRecherche.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.comBxBDay)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 107)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(164, 37)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Date de Naissance"
        '
        'comBxBDay
        '
        Me.comBxBDay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comBxBDay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comBxBDay.FormattingEnabled = True
        Me.comBxBDay.Location = New System.Drawing.Point(5, 11)
        Me.comBxBDay.Name = "comBxBDay"
        Me.comBxBDay.Size = New System.Drawing.Size(154, 21)
        Me.comBxBDay.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Rechercher:"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.comBxNom)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 21)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(164, 37)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nom"
        '
        'comBxNom
        '
        Me.comBxNom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comBxNom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comBxNom.FormattingEnabled = True
        Me.comBxNom.Location = New System.Drawing.Point(5, 11)
        Me.comBxNom.Name = "comBxNom"
        Me.comBxNom.Size = New System.Drawing.Size(154, 21)
        Me.comBxNom.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.comBxPrenom)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 62)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(165, 40)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Prenom"
        '
        'comBxPrenom
        '
        Me.comBxPrenom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comBxPrenom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comBxPrenom.FormattingEnabled = True
        Me.comBxPrenom.Location = New System.Drawing.Point(5, 14)
        Me.comBxPrenom.Name = "comBxPrenom"
        Me.comBxPrenom.Size = New System.Drawing.Size(155, 21)
        Me.comBxPrenom.TabIndex = 0
        '
        'pnlOrdonnace
        '
        Me.pnlOrdonnace.BackColor = System.Drawing.Color.Transparent
        Me.pnlOrdonnace.Controls.Add(Me.btnModifMedic)
        Me.pnlOrdonnace.Controls.Add(Me.dGVwMedicam)
        Me.pnlOrdonnace.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlOrdonnace.Location = New System.Drawing.Point(595, 336)
        Me.pnlOrdonnace.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlOrdonnace.Name = "pnlOrdonnace"
        Me.pnlOrdonnace.Size = New System.Drawing.Size(477, 273)
        Me.pnlOrdonnace.TabIndex = 2
        '
        'btnModifMedic
        '
        Me.btnModifMedic.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnModifMedic.AutoSize = True
        Me.btnModifMedic.Location = New System.Drawing.Point(407, 245)
        Me.btnModifMedic.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModifMedic.Name = "btnModifMedic"
        Me.btnModifMedic.Size = New System.Drawing.Size(54, 23)
        Me.btnModifMedic.TabIndex = 12
        Me.btnModifMedic.Text = "Modifier"
        Me.btnModifMedic.UseVisualStyleBackColor = True
        '
        'dGVwMedicam
        '
        Me.dGVwMedicam.AllowUserToOrderColumns = True
        Me.dGVwMedicam.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dGVwMedicam.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dGVwMedicam.BackgroundColor = System.Drawing.Color.White
        Me.dGVwMedicam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dGVwMedicam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dGVwMedicam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column2, Me.Column5, Me.Column6, Me.Column1})
        Me.dGVwMedicam.GridColor = System.Drawing.Color.White
        Me.dGVwMedicam.Location = New System.Drawing.Point(2, 2)
        Me.dGVwMedicam.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dGVwMedicam.Name = "dGVwMedicam"
        Me.dGVwMedicam.ReadOnly = True
        Me.dGVwMedicam.RowHeadersVisible = False
        Me.dGVwMedicam.RowTemplate.Height = 33
        Me.dGVwMedicam.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dGVwMedicam.Size = New System.Drawing.Size(473, 239)
        Me.dGVwMedicam.TabIndex = 11
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Produit_ID"
        Me.Column3.HeaderText = "Prioduit ID"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 81
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "Nom_Produit"
        Me.Column4.HeaderText = "Nom Produit"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 90
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "Description"
        Me.Column2.HeaderText = "Description"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 85
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "Prix"
        Me.Column5.HeaderText = "Prix"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 49
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "Nb_Unites"
        Me.Column6.HeaderText = "Quantitée"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 78
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "DIN"
        Me.Column1.HeaderText = "DIN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 51
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.btnModifieOrdon)
        Me.Panel1.Controls.Add(Me.dgVwOrdon)
        Me.Panel1.Controls.Add(Me.btnAnnulPrescr)
        Me.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(455, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(617, 241)
        Me.Panel1.TabIndex = 7
        '
        'btnModifieOrdon
        '
        Me.btnModifieOrdon.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnModifieOrdon.AutoSize = True
        Me.btnModifieOrdon.Location = New System.Drawing.Point(557, 213)
        Me.btnModifieOrdon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModifieOrdon.Name = "btnModifieOrdon"
        Me.btnModifieOrdon.Size = New System.Drawing.Size(54, 23)
        Me.btnModifieOrdon.TabIndex = 6
        Me.btnModifieOrdon.Text = "Modifier"
        Me.btnModifieOrdon.UseVisualStyleBackColor = True
        '
        'dgVwOrdon
        '
        Me.dgVwOrdon.AllowUserToOrderColumns = True
        Me.dgVwOrdon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgVwOrdon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgVwOrdon.BackgroundColor = System.Drawing.Color.White
        Me.dgVwOrdon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgVwOrdon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVwOrdon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clm1, Me.clm2, Me.clm3, Me.clm4, Me.clm5})
        Me.dgVwOrdon.GridColor = System.Drawing.Color.White
        Me.dgVwOrdon.Location = New System.Drawing.Point(0, 0)
        Me.dgVwOrdon.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgVwOrdon.Name = "dgVwOrdon"
        Me.dgVwOrdon.ReadOnly = True
        Me.dgVwOrdon.RowHeadersVisible = False
        Me.dgVwOrdon.RowTemplate.Height = 33
        Me.dgVwOrdon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgVwOrdon.Size = New System.Drawing.Size(611, 209)
        Me.dgVwOrdon.TabIndex = 5
        '
        'clm1
        '
        Me.clm1.DataPropertyName = "ID_Client"
        Me.clm1.Frozen = True
        Me.clm1.HeaderText = "Client(ID)"
        Me.clm1.Name = "clm1"
        Me.clm1.ReadOnly = True
        Me.clm1.Width = 75
        '
        'clm2
        '
        Me.clm2.DataPropertyName = "ID"
        Me.clm2.HeaderText = "Ordonnace(ID)"
        Me.clm2.Name = "clm2"
        Me.clm2.ReadOnly = True
        Me.clm2.Width = 102
        '
        'clm3
        '
        Me.clm3.DataPropertyName = "Medecin"
        Me.clm3.HeaderText = "Medecin"
        Me.clm3.Name = "clm3"
        Me.clm3.ReadOnly = True
        Me.clm3.Width = 73
        '
        'clm4
        '
        Me.clm4.DataPropertyName = "Nb_Renouvlemnts"
        Me.clm4.HeaderText = "#Renouvlements"
        Me.clm4.Name = "clm4"
        Me.clm4.ReadOnly = True
        Me.clm4.Width = 113
        '
        'clm5
        '
        Me.clm5.DataPropertyName = "Date_Redaction"
        Me.clm5.HeaderText = "Date Redaction"
        Me.clm5.Name = "clm5"
        Me.clm5.ReadOnly = True
        Me.clm5.Width = 98
        '
        'btnAnnulPrescr
        '
        Me.btnAnnulPrescr.Location = New System.Drawing.Point(499, 213)
        Me.btnAnnulPrescr.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnnulPrescr.Name = "btnAnnulPrescr"
        Me.btnAnnulPrescr.Size = New System.Drawing.Size(54, 23)
        Me.btnAnnulPrescr.TabIndex = 3
        Me.btnAnnulPrescr.Text = "Annuler"
        Me.btnAnnulPrescr.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuMod_QUIT, Me.menuAjouter, Me.INFO})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(967, 21)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'menuMod_QUIT
        '
        Me.menuMod_QUIT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.menuQuiter})
        Me.menuMod_QUIT.Name = "menuMod_QUIT"
        Me.menuMod_QUIT.Size = New System.Drawing.Size(50, 19)
        Me.menuMod_QUIT.Text = "Menu"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(104, 6)
        '
        'menuQuiter
        '
        Me.menuQuiter.Name = "menuQuiter"
        Me.menuQuiter.Size = New System.Drawing.Size(107, 22)
        Me.menuQuiter.Text = "Quiter"
        '
        'menuAjouter
        '
        Me.menuAjouter.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menuAjoutClient, Me.menuAjoutOrdon, Me.menuAjouterEmpl})
        Me.menuAjouter.Name = "menuAjouter"
        Me.menuAjouter.Size = New System.Drawing.Size(58, 19)
        Me.menuAjouter.Text = "Ajouter"
        '
        'menuAjoutClient
        '
        Me.menuAjoutClient.Name = "menuAjoutClient"
        Me.menuAjoutClient.Size = New System.Drawing.Size(133, 22)
        Me.menuAjoutClient.Text = "Client"
        '
        'menuAjoutOrdon
        '
        Me.menuAjoutOrdon.Name = "menuAjoutOrdon"
        Me.menuAjoutOrdon.Size = New System.Drawing.Size(133, 22)
        Me.menuAjoutOrdon.Text = "Ordonance"
        '
        'menuAjouterEmpl
        '
        Me.menuAjouterEmpl.Enabled = False
        Me.menuAjouterEmpl.Name = "menuAjouterEmpl"
        Me.menuAjouterEmpl.Size = New System.Drawing.Size(133, 22)
        Me.menuAjouterEmpl.Text = "Employé"
        '
        'INFO
        '
        Me.INFO.Name = "INFO"
        Me.INFO.Size = New System.Drawing.Size(46, 19)
        Me.INFO.Text = "INFO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(670, 4)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Utilisateur : "
        '
        'lblsetNomUtil
        '
        Me.lblsetNomUtil.AutoSize = True
        Me.lblsetNomUtil.BackColor = System.Drawing.Color.Transparent
        Me.lblsetNomUtil.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsetNomUtil.Location = New System.Drawing.Point(744, 4)
        Me.lblsetNomUtil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblsetNomUtil.Name = "lblsetNomUtil"
        Me.lblsetNomUtil.Size = New System.Drawing.Size(41, 13)
        Me.lblsetNomUtil.TabIndex = 10
        Me.lblsetNomUtil.Text = "Admin"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.comMedicam)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 24)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(164, 37)
        Me.GroupBox4.TabIndex = 11
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Medicament"
        '
        'comMedicam
        '
        Me.comMedicam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comMedicam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comMedicam.FormattingEnabled = True
        Me.comMedicam.Location = New System.Drawing.Point(5, 11)
        Me.comMedicam.Name = "comMedicam"
        Me.comMedicam.Size = New System.Drawing.Size(154, 21)
        Me.comMedicam.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GreenYellow
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.GroupBox4)
        Me.Panel2.Location = New System.Drawing.Point(595, 268)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(181, 64)
        Me.Panel2.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Rechercher :"
        '
        'FenetreBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(967, 557)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblsetNomUtil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlOrdonnace)
        Me.Controls.Add(Me.pnlRecherche)
        Me.Controls.Add(Me.pnlResultRecherche)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.Name = "FenetreBase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ma Petite Pharmacie"
        Me.pnlResultRecherche.ResumeLayout(False)
        Me.pnlResultRecherche.PerformLayout()
        CType(Me.dgridVwClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRecherche.ResumeLayout(False)
        Me.pnlRecherche.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pnlOrdonnace.ResumeLayout(False)
        Me.pnlOrdonnace.PerformLayout()
        CType(Me.dGVwMedicam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgVwOrdon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlResultRecherche As System.Windows.Forms.Panel
    Friend WithEvents pnlRecherche As System.Windows.Forms.Panel
    Friend WithEvents pnlOrdonnace As System.Windows.Forms.Panel
    Friend WithEvents btnAnnulPrescr As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents menuMod_QUIT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuQuiter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents menuAjouter As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAjoutClient As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents menuAjoutOrdon As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblsetNomUtil As System.Windows.Forms.Label
    Friend WithEvents INFO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgridVwClient As System.Windows.Forms.DataGridView
    Friend WithEvents dGVwMedicam As System.Windows.Forms.DataGridView
    Friend WithEvents btnModiFClint As System.Windows.Forms.CheckBox
    Friend WithEvents btnModifMedic As System.Windows.Forms.CheckBox
    Friend WithEvents dgVwOrdon As System.Windows.Forms.DataGridView
    Friend WithEvents btnModifieOrdon As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents comBxNom As System.Windows.Forms.ComboBox
    Friend WithEvents comBxPrenom As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents comBxBDay As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents comMedicam As System.Windows.Forms.ComboBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clm5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents menuAjouterEmpl As System.Windows.Forms.ToolStripMenuItem
End Class
