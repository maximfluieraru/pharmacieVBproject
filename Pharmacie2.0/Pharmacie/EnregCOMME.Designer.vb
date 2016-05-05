<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EnregCOMME
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
        Me.pagOrdonnance = New System.Windows.Forms.TabPage()
        Me.dateTimeOrdon = New System.Windows.Forms.DateTimePicker()
        Me.comBxNomClient = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBxMed = New System.Windows.Forms.TextBox()
        Me.combBxIdClient = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnAnnulOrd = New System.Windows.Forms.Button()
        Me.btnEnregOrd = New System.Windows.Forms.Button()
        Me.cmbBxRenvl = New System.Windows.Forms.ComboBox()
        Me.grpBxMedic = New System.Windows.Forms.GroupBox()
        Me.comBxOrdonMedicam = New System.Windows.Forms.ComboBox()
        Me.btnAjoutMed = New System.Windows.Forms.Button()
        Me.txtBxFrequance = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtBxQty = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBxOrd = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.pagClient = New System.Windows.Forms.TabPage()
        Me.bxA = New System.Windows.Forms.ComboBox()
        Me.bxM = New System.Windows.Forms.ComboBox()
        Me.bxJ = New System.Windows.Forms.ComboBox()
        Me.txtBxNom = New System.Windows.Forms.TextBox()
        Me.txtBxPrenom = New System.Windows.Forms.TextBox()
        Me.txtBxVille = New System.Windows.Forms.TextBox()
        Me.txtBxTel = New System.Windows.Forms.TextBox()
        Me.txtBxCP = New System.Windows.Forms.TextBox()
        Me.txtBxAdresse = New System.Windows.Forms.TextBox()
        Me.txtBxComment = New System.Windows.Forms.TextBox()
        Me.btnEnregClient = New System.Windows.Forms.Button()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.grpBxAllergies = New System.Windows.Forms.GroupBox()
        Me.rBtnOuiAllergies = New System.Windows.Forms.RadioButton()
        Me.rBtnNonAllergies = New System.Windows.Forms.RadioButton()
        Me.grpBxAssur = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtBxAssPriv = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBxAssGouv = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.tabEnreg = New System.Windows.Forms.TabControl()
        Me.pagOrdonnance.SuspendLayout()
        Me.grpBxMedic.SuspendLayout()
        Me.pagClient.SuspendLayout()
        Me.grpBxAllergies.SuspendLayout()
        Me.grpBxAssur.SuspendLayout()
        Me.grpBxTitre.SuspendLayout()
        Me.tabEnreg.SuspendLayout()
        Me.SuspendLayout()
        '
        'pagOrdonnance
        '
        Me.pagOrdonnance.Controls.Add(Me.dateTimeOrdon)
        Me.pagOrdonnance.Controls.Add(Me.comBxNomClient)
        Me.pagOrdonnance.Controls.Add(Me.Label18)
        Me.pagOrdonnance.Controls.Add(Me.txtBxMed)
        Me.pagOrdonnance.Controls.Add(Me.combBxIdClient)
        Me.pagOrdonnance.Controls.Add(Me.Label11)
        Me.pagOrdonnance.Controls.Add(Me.btnAnnulOrd)
        Me.pagOrdonnance.Controls.Add(Me.btnEnregOrd)
        Me.pagOrdonnance.Controls.Add(Me.cmbBxRenvl)
        Me.pagOrdonnance.Controls.Add(Me.grpBxMedic)
        Me.pagOrdonnance.Controls.Add(Me.txtBxOrd)
        Me.pagOrdonnance.Controls.Add(Me.Label17)
        Me.pagOrdonnance.Controls.Add(Me.Label16)
        Me.pagOrdonnance.Controls.Add(Me.Label12)
        Me.pagOrdonnance.Controls.Add(Me.lblID)
        Me.pagOrdonnance.Location = New System.Drawing.Point(4, 34)
        Me.pagOrdonnance.Margin = New System.Windows.Forms.Padding(4)
        Me.pagOrdonnance.Name = "pagOrdonnance"
        Me.pagOrdonnance.Padding = New System.Windows.Forms.Padding(4)
        Me.pagOrdonnance.Size = New System.Drawing.Size(994, 754)
        Me.pagOrdonnance.TabIndex = 1
        Me.pagOrdonnance.Text = "Ordonnance"
        Me.pagOrdonnance.UseVisualStyleBackColor = True
        '
        'dateTimeOrdon
        '
        Me.dateTimeOrdon.Location = New System.Drawing.Point(226, 587)
        Me.dateTimeOrdon.Name = "dateTimeOrdon"
        Me.dateTimeOrdon.Size = New System.Drawing.Size(260, 31)
        Me.dateTimeOrdon.TabIndex = 54
        '
        'comBxNomClient
        '
        Me.comBxNomClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.comBxNomClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comBxNomClient.FormattingEnabled = True
        Me.comBxNomClient.Location = New System.Drawing.Point(320, 96)
        Me.comBxNomClient.Margin = New System.Windows.Forms.Padding(4)
        Me.comBxNomClient.Name = "comBxNomClient"
        Me.comBxNomClient.Size = New System.Drawing.Size(258, 33)
        Me.comBxNomClient.TabIndex = 35
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 10.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(316, 35)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(152, 34)
        Me.Label18.TabIndex = 36
        Me.Label18.Text = "Nom Cient"
        '
        'txtBxMed
        '
        Me.txtBxMed.Location = New System.Drawing.Point(48, 365)
        Me.txtBxMed.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxMed.Name = "txtBxMed"
        Me.txtBxMed.Size = New System.Drawing.Size(254, 31)
        Me.txtBxMed.TabIndex = 2
        '
        'combBxIdClient
        '
        Me.combBxIdClient.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.combBxIdClient.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.combBxIdClient.FormattingEnabled = True
        Me.combBxIdClient.Location = New System.Drawing.Point(56, 96)
        Me.combBxIdClient.Margin = New System.Windows.Forms.Padding(4)
        Me.combBxIdClient.Name = "combBxIdClient"
        Me.combBxIdClient.Size = New System.Drawing.Size(214, 33)
        Me.combBxIdClient.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(52, 35)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 34)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "ID Client"
        '
        'btnAnnulOrd
        '
        Me.btnAnnulOrd.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnAnnulOrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulOrd.Location = New System.Drawing.Point(556, 667)
        Me.btnAnnulOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnnulOrd.Name = "btnAnnulOrd"
        Me.btnAnnulOrd.Size = New System.Drawing.Size(202, 62)
        Me.btnAnnulOrd.TabIndex = 11
        Me.btnAnnulOrd.Text = "Annuler"
        Me.btnAnnulOrd.UseVisualStyleBackColor = False
        '
        'btnEnregOrd
        '
        Me.btnEnregOrd.BackColor = System.Drawing.Color.Olive
        Me.btnEnregOrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregOrd.Location = New System.Drawing.Point(764, 667)
        Me.btnEnregOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnregOrd.Name = "btnEnregOrd"
        Me.btnEnregOrd.Size = New System.Drawing.Size(202, 62)
        Me.btnEnregOrd.TabIndex = 10
        Me.btnEnregOrd.Text = "Enregistrer"
        Me.btnEnregOrd.UseVisualStyleBackColor = False
        '
        'cmbBxRenvl
        '
        Me.cmbBxRenvl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbBxRenvl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbBxRenvl.FormattingEnabled = True
        Me.cmbBxRenvl.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbBxRenvl.Location = New System.Drawing.Point(226, 515)
        Me.cmbBxRenvl.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBxRenvl.Name = "cmbBxRenvl"
        Me.cmbBxRenvl.Size = New System.Drawing.Size(260, 33)
        Me.cmbBxRenvl.TabIndex = 8
        '
        'grpBxMedic
        '
        Me.grpBxMedic.BackColor = System.Drawing.Color.Transparent
        Me.grpBxMedic.Controls.Add(Me.comBxOrdonMedicam)
        Me.grpBxMedic.Controls.Add(Me.btnAjoutMed)
        Me.grpBxMedic.Controls.Add(Me.txtBxFrequance)
        Me.grpBxMedic.Controls.Add(Me.Label15)
        Me.grpBxMedic.Controls.Add(Me.txtBxQty)
        Me.grpBxMedic.Controls.Add(Me.Label14)
        Me.grpBxMedic.Controls.Add(Me.Label13)
        Me.grpBxMedic.Location = New System.Drawing.Point(390, 188)
        Me.grpBxMedic.Margin = New System.Windows.Forms.Padding(0)
        Me.grpBxMedic.Name = "grpBxMedic"
        Me.grpBxMedic.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxMedic.Size = New System.Drawing.Size(564, 313)
        Me.grpBxMedic.TabIndex = 3
        Me.grpBxMedic.TabStop = False
        Me.grpBxMedic.Text = "Medicaments"
        '
        'comBxOrdonMedicam
        '
        Me.comBxOrdonMedicam.FormattingEnabled = True
        Me.comBxOrdonMedicam.Location = New System.Drawing.Point(272, 69)
        Me.comBxOrdonMedicam.Margin = New System.Windows.Forms.Padding(6)
        Me.comBxOrdonMedicam.Name = "comBxOrdonMedicam"
        Me.comBxOrdonMedicam.Size = New System.Drawing.Size(240, 33)
        Me.comBxOrdonMedicam.TabIndex = 15
        '
        'btnAjoutMed
        '
        Me.btnAjoutMed.BackColor = System.Drawing.Color.White
        Me.btnAjoutMed.Location = New System.Drawing.Point(372, 246)
        Me.btnAjoutMed.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAjoutMed.Name = "btnAjoutMed"
        Me.btnAjoutMed.Size = New System.Drawing.Size(140, 44)
        Me.btnAjoutMed.TabIndex = 7
        Me.btnAjoutMed.Text = "Ajouter"
        Me.btnAjoutMed.UseVisualStyleBackColor = False
        '
        'txtBxFrequance
        '
        Me.txtBxFrequance.Location = New System.Drawing.Point(268, 192)
        Me.txtBxFrequance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxFrequance.Name = "txtBxFrequance"
        Me.txtBxFrequance.Size = New System.Drawing.Size(244, 31)
        Me.txtBxFrequance.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(30, 192)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(164, 35)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Frequance"
        '
        'txtBxQty
        '
        Me.txtBxQty.Location = New System.Drawing.Point(268, 129)
        Me.txtBxQty.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxQty.Name = "txtBxQty"
        Me.txtBxQty.Size = New System.Drawing.Size(244, 31)
        Me.txtBxQty.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(30, 129)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(142, 35)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Qtee/Vol"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(26, 65)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(189, 35)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Medicament"
        '
        'txtBxOrd
        '
        Me.txtBxOrd.Location = New System.Drawing.Point(46, 254)
        Me.txtBxOrd.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxOrd.Name = "txtBxOrd"
        Me.txtBxOrd.Size = New System.Drawing.Size(258, 31)
        Me.txtBxOrd.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Moccasin
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(14, 587)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(189, 29)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "Date Ordonnace"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Moccasin
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(14, 515)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(199, 29)
        Me.Label16.TabIndex = 26
        Me.Label16.Text = "NB renouvlement"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(40, 319)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 34)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Medecin"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.BackColor = System.Drawing.Color.Transparent
        Me.lblID.Font = New System.Drawing.Font("Arial", 10.875!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(40, 188)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(199, 34)
        Me.lblID.TabIndex = 23
        Me.lblID.Text = "Ordonnance #"
        '
        'pagClient
        '
        Me.pagClient.Controls.Add(Me.bxA)
        Me.pagClient.Controls.Add(Me.bxM)
        Me.pagClient.Controls.Add(Me.bxJ)
        Me.pagClient.Controls.Add(Me.txtBxNom)
        Me.pagClient.Controls.Add(Me.txtBxPrenom)
        Me.pagClient.Controls.Add(Me.txtBxVille)
        Me.pagClient.Controls.Add(Me.txtBxTel)
        Me.pagClient.Controls.Add(Me.txtBxCP)
        Me.pagClient.Controls.Add(Me.txtBxAdresse)
        Me.pagClient.Controls.Add(Me.txtBxComment)
        Me.pagClient.Controls.Add(Me.btnEnregClient)
        Me.pagClient.Controls.Add(Me.btnAnnuler)
        Me.pagClient.Controls.Add(Me.grpBxAllergies)
        Me.pagClient.Controls.Add(Me.grpBxAssur)
        Me.pagClient.Controls.Add(Me.Label10)
        Me.pagClient.Controls.Add(Me.Label1)
        Me.pagClient.Controls.Add(Me.Label7)
        Me.pagClient.Controls.Add(Me.Label2)
        Me.pagClient.Controls.Add(Me.Label6)
        Me.pagClient.Controls.Add(Me.Label3)
        Me.pagClient.Controls.Add(Me.Label5)
        Me.pagClient.Controls.Add(Me.Label4)
        Me.pagClient.Controls.Add(Me.grpBxTitre)
        Me.pagClient.Location = New System.Drawing.Point(4, 34)
        Me.pagClient.Margin = New System.Windows.Forms.Padding(4)
        Me.pagClient.Name = "pagClient"
        Me.pagClient.Padding = New System.Windows.Forms.Padding(4)
        Me.pagClient.Size = New System.Drawing.Size(994, 754)
        Me.pagClient.TabIndex = 0
        Me.pagClient.Text = "Client"
        Me.pagClient.UseVisualStyleBackColor = True
        '
        'bxA
        '
        Me.bxA.AutoCompleteCustomSource.AddRange(New String() {"1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015"})
        Me.bxA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bxA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.bxA.FormattingEnabled = True
        Me.bxA.Items.AddRange(New Object() {"1900", "1901", "1902", "1903", "1904", "1905", "1906", "1907", "1908", "1909", "1910", "1911", "1912", "1913", "1914", "1915", "1916", "1917", "1918", "1919", "1920", "1921", "1922", "1923", "1924", "1925", "1926", "1927", "1928", "1929", "1930", "1931", "1932", "1933", "1934", "1935", "1936", "1937", "1938", "1939", "1940", "1941", "1942", "1943", "1944", "1945", "1946", "1947", "1948", "1949", "1950", "1951", "1952", "1953", "1954", "1955", "1956", "1957", "1958", "1959", "1960", "1961", "1962", "1963", "1964", "1965", "1966", "1967", "1968", "1969", "1970", "1971", "1972", "1973", "1974", "1975", "1976", "1977", "1978", "1979", "1980", "1981", "1982", "1983", "1984", "1985", "1986", "1987", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015"})
        Me.bxA.Location = New System.Drawing.Point(276, 283)
        Me.bxA.Margin = New System.Windows.Forms.Padding(4)
        Me.bxA.MaxDropDownItems = 12
        Me.bxA.Name = "bxA"
        Me.bxA.Size = New System.Drawing.Size(112, 33)
        Me.bxA.TabIndex = 50
        '
        'bxM
        '
        Me.bxM.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.bxM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bxM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.bxM.FormattingEnabled = True
        Me.bxM.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.bxM.Location = New System.Drawing.Point(400, 283)
        Me.bxM.Margin = New System.Windows.Forms.Padding(4)
        Me.bxM.MaxDropDownItems = 12
        Me.bxM.Name = "bxM"
        Me.bxM.Size = New System.Drawing.Size(84, 33)
        Me.bxM.TabIndex = 49
        '
        'bxJ
        '
        Me.bxJ.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.bxJ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.bxJ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.bxJ.FormattingEnabled = True
        Me.bxJ.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.bxJ.Location = New System.Drawing.Point(496, 283)
        Me.bxJ.Margin = New System.Windows.Forms.Padding(4)
        Me.bxJ.MaxDropDownItems = 13
        Me.bxJ.Name = "bxJ"
        Me.bxJ.Size = New System.Drawing.Size(80, 33)
        Me.bxJ.TabIndex = 48
        '
        'txtBxNom
        '
        Me.txtBxNom.AllowDrop = True
        Me.txtBxNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxNom.Location = New System.Drawing.Point(276, 127)
        Me.txtBxNom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxNom.Name = "txtBxNom"
        Me.txtBxNom.Size = New System.Drawing.Size(246, 40)
        Me.txtBxNom.TabIndex = 2
        '
        'txtBxPrenom
        '
        Me.txtBxPrenom.AllowDrop = True
        Me.txtBxPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxPrenom.Location = New System.Drawing.Point(276, 204)
        Me.txtBxPrenom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxPrenom.Name = "txtBxPrenom"
        Me.txtBxPrenom.Size = New System.Drawing.Size(246, 40)
        Me.txtBxPrenom.TabIndex = 3
        '
        'txtBxVille
        '
        Me.txtBxVille.AllowDrop = True
        Me.txtBxVille.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxVille.Location = New System.Drawing.Point(276, 583)
        Me.txtBxVille.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxVille.Name = "txtBxVille"
        Me.txtBxVille.Size = New System.Drawing.Size(246, 40)
        Me.txtBxVille.TabIndex = 8
        '
        'txtBxTel
        '
        Me.txtBxTel.AllowDrop = True
        Me.txtBxTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxTel.Location = New System.Drawing.Point(276, 356)
        Me.txtBxTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxTel.Name = "txtBxTel"
        Me.txtBxTel.Size = New System.Drawing.Size(246, 40)
        Me.txtBxTel.TabIndex = 5
        '
        'txtBxCP
        '
        Me.txtBxCP.AllowDrop = True
        Me.txtBxCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxCP.Location = New System.Drawing.Point(276, 510)
        Me.txtBxCP.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxCP.Name = "txtBxCP"
        Me.txtBxCP.Size = New System.Drawing.Size(246, 40)
        Me.txtBxCP.TabIndex = 7
        '
        'txtBxAdresse
        '
        Me.txtBxAdresse.AllowDrop = True
        Me.txtBxAdresse.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBxAdresse.Location = New System.Drawing.Point(276, 431)
        Me.txtBxAdresse.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxAdresse.Name = "txtBxAdresse"
        Me.txtBxAdresse.Size = New System.Drawing.Size(246, 40)
        Me.txtBxAdresse.TabIndex = 6
        '
        'txtBxComment
        '
        Me.txtBxComment.AcceptsReturn = True
        Me.txtBxComment.AcceptsTab = True
        Me.txtBxComment.AllowDrop = True
        Me.txtBxComment.Location = New System.Drawing.Point(540, 388)
        Me.txtBxComment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxComment.Multiline = True
        Me.txtBxComment.Name = "txtBxComment"
        Me.txtBxComment.Size = New System.Drawing.Size(416, 239)
        Me.txtBxComment.TabIndex = 15
        Me.txtBxComment.TabStop = False
        '
        'btnEnregClient
        '
        Me.btnEnregClient.BackColor = System.Drawing.Color.Olive
        Me.btnEnregClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregClient.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnEnregClient.Location = New System.Drawing.Point(764, 665)
        Me.btnEnregClient.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEnregClient.Name = "btnEnregClient"
        Me.btnEnregClient.Size = New System.Drawing.Size(202, 62)
        Me.btnEnregClient.TabIndex = 17
        Me.btnEnregClient.Text = "Enregistrer"
        Me.btnEnregClient.UseVisualStyleBackColor = False
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.DarkSalmon
        Me.btnAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.SystemColors.Desktop
        Me.btnAnnuler.Location = New System.Drawing.Point(556, 665)
        Me.btnAnnuler.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(202, 62)
        Me.btnAnnuler.TabIndex = 16
        Me.btnAnnuler.Text = "Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'grpBxAllergies
        '
        Me.grpBxAllergies.BackColor = System.Drawing.Color.Coral
        Me.grpBxAllergies.Controls.Add(Me.rBtnOuiAllergies)
        Me.grpBxAllergies.Controls.Add(Me.rBtnNonAllergies)
        Me.grpBxAllergies.Location = New System.Drawing.Point(664, 263)
        Me.grpBxAllergies.Margin = New System.Windows.Forms.Padding(0)
        Me.grpBxAllergies.Name = "grpBxAllergies"
        Me.grpBxAllergies.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxAllergies.Size = New System.Drawing.Size(236, 79)
        Me.grpBxAllergies.TabIndex = 12
        Me.grpBxAllergies.TabStop = False
        Me.grpBxAllergies.Text = "Allergies"
        '
        'rBtnOuiAllergies
        '
        Me.rBtnOuiAllergies.AutoSize = True
        Me.rBtnOuiAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnOuiAllergies.Location = New System.Drawing.Point(126, 31)
        Me.rBtnOuiAllergies.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtnOuiAllergies.Name = "rBtnOuiAllergies"
        Me.rBtnOuiAllergies.Size = New System.Drawing.Size(101, 37)
        Me.rBtnOuiAllergies.TabIndex = 14
        Me.rBtnOuiAllergies.TabStop = True
        Me.rBtnOuiAllergies.Text = "OUI"
        Me.rBtnOuiAllergies.UseVisualStyleBackColor = True
        '
        'rBtnNonAllergies
        '
        Me.rBtnNonAllergies.AutoSize = True
        Me.rBtnNonAllergies.Checked = True
        Me.rBtnNonAllergies.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rBtnNonAllergies.Location = New System.Drawing.Point(6, 31)
        Me.rBtnNonAllergies.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtnNonAllergies.Name = "rBtnNonAllergies"
        Me.rBtnNonAllergies.Size = New System.Drawing.Size(114, 37)
        Me.rBtnNonAllergies.TabIndex = 13
        Me.rBtnNonAllergies.TabStop = True
        Me.rBtnNonAllergies.Text = "NON"
        Me.rBtnNonAllergies.UseVisualStyleBackColor = True
        '
        'grpBxAssur
        '
        Me.grpBxAssur.BackColor = System.Drawing.Color.Transparent
        Me.grpBxAssur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grpBxAssur.Controls.Add(Me.Label9)
        Me.grpBxAssur.Controls.Add(Me.txtBxAssPriv)
        Me.grpBxAssur.Controls.Add(Me.Label8)
        Me.grpBxAssur.Controls.Add(Me.txtBxAssGouv)
        Me.grpBxAssur.Font = New System.Drawing.Font("Trebuchet MS", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBxAssur.ForeColor = System.Drawing.Color.Purple
        Me.grpBxAssur.Location = New System.Drawing.Point(564, 38)
        Me.grpBxAssur.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBxAssur.Name = "grpBxAssur"
        Me.grpBxAssur.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxAssur.Size = New System.Drawing.Size(396, 202)
        Me.grpBxAssur.TabIndex = 9
        Me.grpBxAssur.TabStop = False
        Me.grpBxAssur.Text = "Assurances"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 129)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 35)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Autre"
        '
        'txtBxAssPriv
        '
        Me.txtBxAssPriv.AllowDrop = True
        Me.txtBxAssPriv.Location = New System.Drawing.Point(160, 129)
        Me.txtBxAssPriv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxAssPriv.Name = "txtBxAssPriv"
        Me.txtBxAssPriv.Size = New System.Drawing.Size(206, 39)
        Me.txtBxAssPriv.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 62)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 35)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "GOUV."
        '
        'txtBxAssGouv
        '
        Me.txtBxAssGouv.AllowDrop = True
        Me.txtBxAssGouv.Location = New System.Drawing.Point(160, 62)
        Me.txtBxAssGouv.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBxAssGouv.Name = "txtBxAssGouv"
        Me.txtBxAssGouv.Size = New System.Drawing.Size(206, 39)
        Me.txtBxAssGouv.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(536, 362)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 25)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Commentaires:"
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
        Me.Label1.Location = New System.Drawing.Point(16, 127)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 38)
        Me.Label1.TabIndex = 40
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
        Me.Label7.Location = New System.Drawing.Point(24, 583)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 38)
        Me.Label7.TabIndex = 46
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
        Me.Label2.Location = New System.Drawing.Point(16, 204)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 38)
        Me.Label2.TabIndex = 41
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
        Me.Label6.Location = New System.Drawing.Point(18, 510)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(183, 38)
        Me.Label6.TabIndex = 45
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
        Me.Label3.Location = New System.Drawing.Point(16, 281)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 38)
        Me.Label3.TabIndex = 42
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
        Me.Label5.Location = New System.Drawing.Point(18, 431)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 38)
        Me.Label5.TabIndex = 44
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
        Me.Label4.Location = New System.Drawing.Point(16, 356)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 38)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Telephone"
        '
        'grpBxTitre
        '
        Me.grpBxTitre.BackColor = System.Drawing.Color.Transparent
        Me.grpBxTitre.Controls.Add(Me.rBtnMme)
        Me.grpBxTitre.Controls.Add(Me.rBtnM)
        Me.grpBxTitre.Location = New System.Drawing.Point(14, 8)
        Me.grpBxTitre.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBxTitre.Name = "grpBxTitre"
        Me.grpBxTitre.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBxTitre.Size = New System.Drawing.Size(186, 75)
        Me.grpBxTitre.TabIndex = 0
        Me.grpBxTitre.TabStop = False
        Me.grpBxTitre.Text = "Titre"
        '
        'rBtnMme
        '
        Me.rBtnMme.AutoSize = True
        Me.rBtnMme.Location = New System.Drawing.Point(76, 31)
        Me.rBtnMme.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtnMme.Name = "rBtnMme"
        Me.rBtnMme.Size = New System.Drawing.Size(90, 29)
        Me.rBtnMme.TabIndex = 1
        Me.rBtnMme.Tag = "Madame"
        Me.rBtnMme.Text = "Mme"
        Me.rBtnMme.UseVisualStyleBackColor = True
        '
        'rBtnM
        '
        Me.rBtnM.AutoSize = True
        Me.rBtnM.Checked = True
        Me.rBtnM.Location = New System.Drawing.Point(10, 31)
        Me.rBtnM.Margin = New System.Windows.Forms.Padding(4)
        Me.rBtnM.Name = "rBtnM"
        Me.rBtnM.Size = New System.Drawing.Size(61, 29)
        Me.rBtnM.TabIndex = 0
        Me.rBtnM.TabStop = True
        Me.rBtnM.Tag = "Monsieur"
        Me.rBtnM.Text = "M"
        Me.rBtnM.UseVisualStyleBackColor = True
        '
        'tabEnreg
        '
        Me.tabEnreg.Controls.Add(Me.pagClient)
        Me.tabEnreg.Controls.Add(Me.pagOrdonnance)
        Me.tabEnreg.Location = New System.Drawing.Point(0, 2)
        Me.tabEnreg.Margin = New System.Windows.Forms.Padding(4)
        Me.tabEnreg.MaximumSize = New System.Drawing.Size(1002, 792)
        Me.tabEnreg.Name = "tabEnreg"
        Me.tabEnreg.Padding = New System.Drawing.Point(3, 3)
        Me.tabEnreg.SelectedIndex = 0
        Me.tabEnreg.Size = New System.Drawing.Size(1002, 792)
        Me.tabEnreg.TabIndex = 0
        '
        'EnregCOMME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1002, 792)
        Me.Controls.Add(Me.tabEnreg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "EnregCOMME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "La Petite Pharmacie"
        Me.pagOrdonnance.ResumeLayout(False)
        Me.pagOrdonnance.PerformLayout()
        Me.grpBxMedic.ResumeLayout(False)
        Me.grpBxMedic.PerformLayout()
        Me.pagClient.ResumeLayout(False)
        Me.pagClient.PerformLayout()
        Me.grpBxAllergies.ResumeLayout(False)
        Me.grpBxAllergies.PerformLayout()
        Me.grpBxAssur.ResumeLayout(False)
        Me.grpBxAssur.PerformLayout()
        Me.grpBxTitre.ResumeLayout(False)
        Me.grpBxTitre.PerformLayout()
        Me.tabEnreg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pagOrdonnance As System.Windows.Forms.TabPage
    Friend WithEvents combBxIdClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnAnnulOrd As System.Windows.Forms.Button
    Friend WithEvents btnEnregOrd As System.Windows.Forms.Button
    Friend WithEvents cmbBxRenvl As System.Windows.Forms.ComboBox
    Friend WithEvents grpBxMedic As System.Windows.Forms.GroupBox
    Friend WithEvents btnAjoutMed As System.Windows.Forms.Button
    Friend WithEvents txtBxFrequance As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBxQty As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBxOrd As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents pagClient As System.Windows.Forms.TabPage
    Friend WithEvents txtBxNom As System.Windows.Forms.TextBox
    Friend WithEvents txtBxPrenom As System.Windows.Forms.TextBox
    Friend WithEvents txtBxVille As System.Windows.Forms.TextBox
    Friend WithEvents txtBxTel As System.Windows.Forms.TextBox
    Friend WithEvents txtBxCP As System.Windows.Forms.TextBox
    Friend WithEvents txtBxAdresse As System.Windows.Forms.TextBox
    Friend WithEvents txtBxComment As System.Windows.Forms.TextBox
    Friend WithEvents btnEnregClient As System.Windows.Forms.Button
    Friend WithEvents btnAnnuler As System.Windows.Forms.Button
    Friend WithEvents grpBxAllergies As System.Windows.Forms.GroupBox
    Friend WithEvents rBtnOuiAllergies As System.Windows.Forms.RadioButton
    Friend WithEvents rBtnNonAllergies As System.Windows.Forms.RadioButton
    Friend WithEvents grpBxAssur As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBxAssPriv As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBxAssGouv As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents tabEnreg As System.Windows.Forms.TabControl
    Friend WithEvents txtBxMed As System.Windows.Forms.TextBox
    Friend WithEvents comBxOrdonMedicam As System.Windows.Forms.ComboBox
    Friend WithEvents comBxNomClient As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents bxA As System.Windows.Forms.ComboBox
    Friend WithEvents bxM As System.Windows.Forms.ComboBox
    Friend WithEvents bxJ As System.Windows.Forms.ComboBox
    Friend WithEvents dateTimeOrdon As System.Windows.Forms.DateTimePicker
End Class
