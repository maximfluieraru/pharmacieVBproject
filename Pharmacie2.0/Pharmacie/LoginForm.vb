Imports System.Xml.Serialization
Imports System.IO

Public Class FormLogin
    Private listEmpl As New LesEmployes

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim fb As New FenetreBase
        If Not listEmpl.ouvrir(txtBxID.Text.Trim & txtBxPass.Text.Trim) Is Nothing Then
            Dim empl As Employe_Pharm = listEmpl.ouvrir(txtBxID.Text.Trim & txtBxPass.Text.Trim)
            If (empl.le_poste.Equals("Admin")) Then
                fb.menuAjouterEmpl.Enabled = True
            End If
            Me.Visible() = False
            fb.ShowDialog()
        Else
            MsgBox("Accès refusé!")

        End If

        txtBxID.Text = ""
        txtBxID.Focus()
        txtBxPass.Text = ""

        Me.Visible() = True

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click, MyBase.FormClosed

        If listEmpl.list.Count > 0 Then

            Try
                Dim xmlListFormatEmpl As New XmlSerializer(listEmpl.GetType)

                Dim fstrE As New FileStream("Employes.xml", FileMode.OpenOrCreate, FileAccess.Write)
                Dim fwrE As New StreamWriter(fstrE, System.Text.Encoding.UTF8)

                xmlListFormatEmpl.Serialize(fwrE, listEmpl)

                fwrE.Close()
                fstrE.Close()

                End
            Catch ex As Exception
                MsgBox("La liste des employes n'a pas ete enregistree")
            End Try
        End If

    End Sub

    Private Sub FormLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        listEmpl.list.Clear()

        Try
            Dim xmlForamtFichierC As New XmlSerializer(listEmpl.GetType)
            Dim fichier As New FileStream("Employes.xml", FileMode.Open, FileAccess.Read)
            listEmpl = xmlForamtFichierC.Deserialize(fichier)
            fichier.Close()
        Catch ex As Exception
            MsgBox("La liste des employes est introuvable ou le fichier est vide")
        End Try

    End Sub

   
End Class
