<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class FormLogin
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents txtBxID As System.Windows.Forms.TextBox
    Friend WithEvents txtBxPass As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.txtBxID = New System.Windows.Forms.TextBox()
        Me.txtBxPass = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.Connexion = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Connexion.SuspendLayout()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImage = CType(resources.GetObject("LogoPictureBox.BackgroundImage"), System.Drawing.Image)
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.ImageLocation = ""
        Me.LogoPictureBox.Location = New System.Drawing.Point(0, 12)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(286, 282)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'txtBxID
        '
        Me.txtBxID.Location = New System.Drawing.Point(42, 83)
        Me.txtBxID.Name = "txtBxID"
        Me.txtBxID.Size = New System.Drawing.Size(162, 31)
        Me.txtBxID.TabIndex = 1
        '
        'txtBxPass
        '
        Me.txtBxPass.Location = New System.Drawing.Point(42, 171)
        Me.txtBxPass.Name = "txtBxPass"
        Me.txtBxPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtBxPass.Size = New System.Drawing.Size(162, 31)
        Me.txtBxPass.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(18, 221)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(108, 39)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "Entrer"
        '
        'Cancel
        '
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.Location = New System.Drawing.Point(132, 221)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(105, 39)
        Me.Cancel.TabIndex = 5
        Me.Cancel.Text = "&Annuler"
        '
        'Connexion
        '
        Me.Connexion.BackColor = System.Drawing.Color.Transparent
        Me.Connexion.Controls.Add(Me.Label2)
        Me.Connexion.Controls.Add(Me.Label1)
        Me.Connexion.Controls.Add(Me.Cancel)
        Me.Connexion.Controls.Add(Me.btnOK)
        Me.Connexion.Controls.Add(Me.txtBxPass)
        Me.Connexion.Controls.Add(Me.txtBxID)
        Me.Connexion.ForeColor = System.Drawing.Color.SaddleBrown
        Me.Connexion.Location = New System.Drawing.Point(292, 12)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(266, 282)
        Me.Connexion.TabIndex = 6
        Me.Connexion.TabStop = False
        Me.Connexion.Text = "Connexion"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "ID utilisateur:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Mot de passe:"
        '
        'FormLogin
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(571, 316)
        Me.Controls.Add(Me.Connexion)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(500, 500)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormLogin"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bienvenu"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Connexion.ResumeLayout(False)
        Me.Connexion.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Connexion As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
