<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EregEmpl
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
        Me.bxA = New System.Windows.Forms.ComboBox()
        Me.bxM = New System.Windows.Forms.ComboBox()
        Me.bxJ = New System.Windows.Forms.ComboBox()
        Me.txtBxNom = New System.Windows.Forms.TextBox()
        Me.txtBxPrenom = New System.Windows.Forms.TextBox()
        Me.txtBxVille = New System.Windows.Forms.TextBox()
        Me.txtBxTel = New System.Windows.Forms.TextBox()
        Me.txtBxCP = New System.Windows.Forms.TextBox()
        Me.txtBxAdresse = New System.Windows.Forms.TextBox()
        Me.btnEnregClient = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.grpBxTitre = New System.Windows.Forms.GroupBox()
        Me.rBtnMme = New System.Windows.Forms.RadioButton()
        Me.rBtnM = New System.Windows.Forms.RadioButton()
        Me.txtBxNAS = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBxPass = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radBtnPharm = New System.Windows.Forms.RadioButton()
        Me.radBtnCommis = New System.Windows.Forms.RadioButton()
        Me.radBtnAdmin = New System.Windows.Forms.RadioButton()
        Me.grpBxLePoste = New System.Windows.Forms.GroupBox()
        Me.pnlResultRecherche = New System.Windows.Forms.Panel()
        Me.btnModifEmpl = New System.Windows.Forms.CheckBox()
        Me.dgridVwEmpl = New System.Windows.Forms.DataGridView()
        Me.grpBxTitre.SuspendLayout()
        Me.grpBxLePoste.SuspendLayout()
        Me.pnlResultRecherche.SuspendLayout()
        CType(Me.dgridVwEmpl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bxA
        '
        Me.bxA.AutoCompleteCustomSource.AddRange(New String() {"1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015"})
        Me.bxA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bxA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.bxA.FormattingEnabled = True
        Me.bxA.Items.AddRange(New Object() {"1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015"})
        Me.bxA.Location = New System.Drawing.Point(138, 150)
        Me.bxA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bxA.MaxDropDownItems = 12
        Me.bxA.Name = "bxA"
        Me.bxA.Size = New System.Drawing.Size(58, 21)
        Me.bxA.TabIndex = 4
        '
        'bxM
        '
        Me.bxM.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.bxM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bxM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.bxM.FormattingEnabled = True
        Me.bxM.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.bxM.Location = New System.Drawing.Point(200, 150)
        Me.bxM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bxM.MaxDropDownItems = 12
        Me.bxM.Name = "bxM"
        Me.bxM.Size = New System.Drawing.Size(44, 21)
        Me.bxM.TabIndex = 5
        '
        'bxJ
        '
        Me.bxJ.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.bxJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bxJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.bxJ.FormattingEnabled = True
        Me.bxJ.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.bxJ.Location = New System.Drawing.Point(248, 150)
        Me.bxJ.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.bxJ.MaxDropDownItems = 13
        Me.bxJ.Name = "bxJ"
        Me.bxJ.Size = New System.Drawing.Size(42, 21)
        Me.bxJ.TabIndex = 6
        '
        'txtBxNom
        '
        Me.txtBxNom.AllowDrop = True
        Me.txtBxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNom.Location = New System.Drawing.Point(138, 69)
        Me.txtBxNom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxNom.Name = "txtBxNom"
        Me.txtBxNom.Size = New System.Drawing.Size(152, 24)
        Me.txtBxNom.TabIndex = 2
        '
        'txtBxPrenom
        '
        Me.txtBxPrenom.AllowDrop = True
        Me.txtBxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPrenom.Location = New System.Drawing.Point(138, 109)
        Me.txtBxPrenom.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxPrenom.Name = "txtBxPrenom"
        Me.txtBxPrenom.Size = New System.Drawing.Size(152, 24)
        Me.txtBxPrenom.TabIndex = 3
        '
        'txtBxVille
        '
        Me.txtBxVille.AllowDrop = True
        Me.txtBxVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxVille.Location = New System.Drawing.Point(138, 306)
        Me.txtBxVille.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxVille.Name = "txtBxVille"
        Me.txtBxVille.Size = New System.Drawing.Size(152, 24)
        Me.txtBxVille.TabIndex = 10
        '
        'txtBxTel
        '
        Me.txtBxTel.AllowDrop = True
        Me.txtBxTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxTel.Location = New System.Drawing.Point(138, 188)
        Me.txtBxTel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxTel.Name = "txtBxTel"
        Me.txtBxTel.Size = New System.Drawing.Size(152, 24)
        Me.txtBxTel.TabIndex = 7
        '
        'txtBxCP
        '
        Me.txtBxCP.AllowDrop = True
        Me.txtBxCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCP.Location = New System.Drawing.Point(138, 268)
        Me.txtBxCP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxCP.Name = "txtBxCP"
        Me.txtBxCP.Size = New System.Drawing.Size(152, 24)
        Me.txtBxCP.TabIndex = 9
        '
        'txtBxAdresse
        '
        Me.txtBxAdresse.AllowDrop = True
        Me.txtBxAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAdresse.Location = New System.Drawing.Point(138, 227)
        Me.txtBxAdresse.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxAdresse.Name = "txtBxAdresse"
        Me.txtBxAdresse.Size = New System.Drawing.Size(152, 24)
        Me.txtBxAdresse.TabIndex = 8
        '
        'btnEnregClient
        '
        Me.btnEnregClient.BackColor = System.Drawing.Color.Olive
        Me.btnEnregClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregClient.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEnregClient.Location = New System.Drawing.Point(410, 329)
        Me.btnEnregClient.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEnregClient.Name = "btnEnregClient"
        Me.btnEnregClient.Size = New System.Drawing.Size(101, 32)
        Me.btnEnregClient.TabIndex = 18
        Me.btnEnregClient.Text = "Enregistrer"
        Me.btnEnregClient.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAnnuler.Location = New System.Drawing.Point(306, 329)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(101, 32)
        Me.btnAnnuler.TabIndex = 17
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoEllipsis = True
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.CausesValidation = False
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(8, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Nom"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoEllipsis = True
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.CausesValidation = False
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Location = New System.Drawing.Point(12, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 20)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Ville"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoEllipsis = True
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.CausesValidation = False
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(8, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Prenom"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoEllipsis = True
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.CausesValidation = False
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label6.Location = New System.Drawing.Point(8, 268)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 20)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Code Postale"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoEllipsis = True
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.CausesValidation = False
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(8, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Date de naissance"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoEllipsis = True
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.CausesValidation = False
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(8, 227)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 20)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Adresse"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoEllipsis = True
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.CausesValidation = False
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(8, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Telephone"
        '
        'grpBxTitre
        '
        Me.grpBxTitre.BackColor = System.Drawing.Color.Transparent
        Me.grpBxTitre.Controls.Add(Me.rBtnMme)
        Me.grpBxTitre.Controls.Add(Me.rBtnM)
        Me.grpBxTitre.Location = New System.Drawing.Point(6, 7)
        Me.grpBxTitre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpBxTitre.Name = "grpBxTitre"
        Me.grpBxTitre.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpBxTitre.Size = New System.Drawing.Size(93, 39)
        Me.grpBxTitre.TabIndex = 51
        Me.grpBxTitre.TabStop = False
        Me.grpBxTitre.Text = "Titre"
        '
        'rBtnMme
        '
        Me.rBtnMme.AutoSize = True
        Me.rBtnMme.Location = New System.Drawing.Point(38, 16)
        Me.rBtnMme.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rBtnMme.Name = "rBtnMme"
        Me.rBtnMme.Size = New System.Drawing.Size(24, 9)
        Me.rBtnMme.TabIndex = 1
        Me.rBtnMme.TabStop = True
        Me.rBtnMme.Tag = "Madame"
        Me.rBtnMme.Text = "Mme"
        Me.rBtnMme.UseVisualStyleBackColor = True
        '
        'rBtnM
        '
        Me.rBtnM.AutoSize = True
        Me.rBtnM.Checked = True
        Me.rBtnM.Location = New System.Drawing.Point(5, 16)
        Me.rBtnM.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rBtnM.Name = "rBtnM"
        Me.rBtnM.Size = New System.Drawing.Size(17, 9)
        Me.rBtnM.TabIndex = 0
        Me.rBtnM.TabStop = True
        Me.rBtnM.Tag = "Monsieur"
        Me.rBtnM.Text = "M"
        Me.rBtnM.UseVisualStyleBackColor = True
        '
        'txtBxNAS
        '
        Me.txtBxNAS.AllowDrop = True
        Me.txtBxNAS.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNAS.Location = New System.Drawing.Point(334, 30)
        Me.txtBxNAS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxNAS.Name = "txtBxNAS"
        Me.txtBxNAS.Size = New System.Drawing.Size(152, 24)
        Me.txtBxNAS.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoEllipsis = True
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.CausesValidation = False
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label8.Location = New System.Drawing.Point(331, 7)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "NAS"
        '
        'txtBxPass
        '
        Me.txtBxPass.AllowDrop = True
        Me.txtBxPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPass.Location = New System.Drawing.Point(334, 95)
        Me.txtBxPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBxPass.Name = "txtBxPass"
        Me.txtBxPass.Size = New System.Drawing.Size(152, 24)
        Me.txtBxPass.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoEllipsis = True
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.CausesValidation = False
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label9.Location = New System.Drawing.Point(331, 70)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 20)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "Mot de passe"
        '
        'radBtnPharm
        '
        Me.radBtnPharm.AutoSize = True
        Me.radBtnPharm.Location = New System.Drawing.Point(6, 24)
        Me.radBtnPharm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radBtnPharm.Name = "radBtnPharm"
        Me.radBtnPharm.Size = New System.Drawing.Size(50, 9)
        Me.radBtnPharm.TabIndex = 14
        Me.radBtnPharm.TabStop = True
        Me.radBtnPharm.Tag = "Pharmacien"
        Me.radBtnPharm.Text = "Pharmacien(ne)"
        Me.radBtnPharm.UseVisualStyleBackColor = True
        '
        'radBtnCommis
        '
        Me.radBtnCommis.AutoSize = True
        Me.radBtnCommis.Location = New System.Drawing.Point(6, 63)
        Me.radBtnCommis.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radBtnCommis.Name = "radBtnCommis"
        Me.radBtnCommis.Size = New System.Drawing.Size(30, 9)
        Me.radBtnCommis.TabIndex = 15
        Me.radBtnCommis.TabStop = True
        Me.radBtnCommis.Tag = "Commis"
        Me.radBtnCommis.Text = "Commis"
        Me.radBtnCommis.UseVisualStyleBackColor = True
        '
        'radBtnAdmin
        '
        Me.radBtnAdmin.AutoSize = True
        Me.radBtnAdmin.Location = New System.Drawing.Point(6, 105)
        Me.radBtnAdmin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.radBtnAdmin.Name = "radBtnAdmin"
        Me.radBtnAdmin.Size = New System.Drawing.Size(46, 9)
        Me.radBtnAdmin.TabIndex = 16
        Me.radBtnAdmin.TabStop = True
        Me.radBtnAdmin.Tag = "Admin"
        Me.radBtnAdmin.Text = "Administrateur"
        Me.radBtnAdmin.UseVisualStyleBackColor = True
        '
        'grpBxLePoste
        '
        Me.grpBxLePoste.Controls.Add(Me.radBtnAdmin)
        Me.grpBxLePoste.Controls.Add(Me.radBtnCommis)
        Me.grpBxLePoste.Controls.Add(Me.radBtnPharm)
        Me.grpBxLePoste.Location = New System.Drawing.Point(334, 163)
        Me.grpBxLePoste.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpBxLePoste.Name = "grpBxLePoste"
        Me.grpBxLePoste.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpBxLePoste.Size = New System.Drawing.Size(121, 135)
        Me.grpBxLePoste.TabIndex = 13
        Me.grpBxLePoste.TabStop = False
        Me.grpBxLePoste.Text = "Le Poste"
        '
        'pnlResultRecherche
        '
        Me.pnlResultRecherche.BackColor = System.Drawing.Color.Transparent
        Me.pnlResultRecherche.Controls.Add(Me.btnModifEmpl)
        Me.pnlResultRecherche.Controls.Add(Me.dgridVwEmpl)
        Me.pnlResultRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlResultRecherche.Location = New System.Drawing.Point(6, 366)
        Me.pnlResultRecherche.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pnlResultRecherche.Name = "pnlResultRecherche"
        Me.pnlResultRecherche.Size = New System.Drawing.Size(504, 225)
        Me.pnlResultRecherche.TabIndex = 78
        '
        'btnModifEmpl
        '
        Me.btnModifEmpl.Appearance = System.Windows.Forms.Appearance.Button
        Me.btnModifEmpl.AutoSize = True
        Me.btnModifEmpl.Location = New System.Drawing.Point(452, 202)
        Me.btnModifEmpl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModifEmpl.Name = "btnModifEmpl"
        Me.btnModifEmpl.Size = New System.Drawing.Size(54, 23)
        Me.btnModifEmpl.TabIndex = 12
        Me.btnModifEmpl.Text = "Modifier"
        Me.btnModifEmpl.UseVisualStyleBackColor = True
        '
        'dgridVwEmpl
        '
        Me.dgridVwEmpl.AllowUserToOrderColumns = True
        Me.dgridVwEmpl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgridVwEmpl.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgridVwEmpl.BackgroundColor = System.Drawing.Color.White
        Me.dgridVwEmpl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgridVwEmpl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgridVwEmpl.GridColor = System.Drawing.Color.White
        Me.dgridVwEmpl.Location = New System.Drawing.Point(2, 2)
        Me.dgridVwEmpl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgridVwEmpl.Name = "dgridVwEmpl"
        Me.dgridVwEmpl.ReadOnly = True
        Me.dgridVwEmpl.RowHeadersVisible = False
        Me.dgridVwEmpl.RowTemplate.Height = 33
        Me.dgridVwEmpl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgridVwEmpl.Size = New System.Drawing.Size(500, 196)
        Me.dgridVwEmpl.TabIndex = 11
        '
        'EregEmpl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(534, 557)
        Me.Controls.Add(Me.pnlResultRecherche)
        Me.Controls.Add(Me.grpBxLePoste)
        Me.Controls.Add(Me.txtBxPass)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtBxNAS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.bxA)
        Me.Controls.Add(Me.bxM)
        Me.Controls.Add(Me.bxJ)
        Me.Controls.Add(Me.txtBxNom)
        Me.Controls.Add(Me.txtBxPrenom)
        Me.Controls.Add(Me.txtBxVille)
        Me.Controls.Add(Me.txtBxTel)
        Me.Controls.Add(Me.txtBxCP)
        Me.Controls.Add(Me.txtBxAdresse)
        Me.Controls.Add(Me.btnEnregClient)
        Me.Controls.Add(Me.btnAnnuler)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.grpBxTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(540, 655)
        Me.MinimumSize = New System.Drawing.Size(540, 553)
        Me.Name = "EregEmpl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employe"
        Me.grpBxTitre.ResumeLayout(False)
        Me.grpBxTitre.PerformLayout()
        Me.grpBxLePoste.ResumeLayout(False)
        Me.grpBxLePoste.PerformLayout()
        Me.pnlResultRecherche.ResumeLayout(False)
        Me.pnlResultRecherche.PerformLayout()
        CType(Me.dgridVwEmpl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bxA As System.Windows.Forms.ComboBox
    Friend WithEvents bxM As System.Windows.Forms.ComboBox
    Friend WithEvents bxJ As System.Windows.Forms.ComboBox
    Friend WithEvents txtBxNom As System.Windows.Forms.TextBox
    Friend WithEvents txtBxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtBxVille As System.Windows.Forms.TextBox
    Friend WithEvents txtBxTel As System.Windows.Forms.TextBox
    Friend WithEvents txtBxCP As System.Windows.Forms.TextBox
    Friend WithEvents txtBxAdresse As System.Windows.Forms.TextBox
    Friend WithEvents btnEnregClient As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents grpBxTitre As System.Windows.Forms.GroupBox
    Friend WithEvents rBtnMme As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnM As System.Windows.Forms.RadioButton
    Friend WithEvents txtBxNAS As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBxPass As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents radBtnPharm As System.Windows.Forms.RadioButton
    Friend WithEvents radBtnCommis As System.Windows.Forms.RadioButton
    Friend WithEvents radBtnAdmin As System.Windows.Forms.RadioButton
    Friend WithEvents grpBxLePoste As System.Windows.Forms.GroupBox
    Friend WithEvents pnlResultRecherche As System.Windows.Forms.Panel
    Friend WithEvents btnModifEmpl As System.Windows.Forms.CheckBox
    Friend WithEvents dgridVwEmpl As System.Windows.Forms.DataGridView
End Class
