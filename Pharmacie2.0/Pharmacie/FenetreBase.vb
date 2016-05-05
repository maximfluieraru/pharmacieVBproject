Imports System.IO
Imports System.Windows.Forms
Imports System.Xml.Serialization

Public Class FenetreBase

    Private client As Client_Personne
    Private medicam As Medicament
    Private listClt As New LesClients
    Private listMedicam As New LesMedicaments
    Private listOrdon As New LesOrdonnances
    Private listEmpl As New LesEmployes

    Private Sub enregFichier()

        If listClt.list.Count > 0 Then

            Try
                Dim xmlListFormatClient As New XmlSerializer(listClt.GetType)

                Dim fstrC As New FileStream("Clients.xml", FileMode.OpenOrCreate, FileAccess.Write)
                Dim fwrC As New StreamWriter(fstrC, System.Text.Encoding.UTF8)

                xmlListFormatClient.Serialize(fwrC, listClt)

                fwrC.Close()
                fstrC.Close()

            Catch ex As Exception
                MsgBox("La liste des clients n'a pas ete enregistree")
            End Try
        End If

        If listMedicam.list.Count > 0 Then
            Try
                Dim xmlListFormatMedicam As New XmlSerializer(listMedicam.GetType)

                Dim fstrM As New FileStream("Medicaments.xml", FileMode.OpenOrCreate, FileAccess.Write)
                Dim fwrM As New StreamWriter(fstrM, System.Text.Encoding.UTF8)

                xmlListFormatMedicam.Serialize(fwrM, listMedicam)

                fwrM.Close()
                fstrM.Close()

            Catch ex As Exception
                MsgBox("La liste des medicaments n'a pas ete enregistree")
            End Try
        End If

        If listOrdon.list.Count > 0 Then

            Try
                Dim xmlListFormatOdron As New XmlSerializer(listOrdon.GetType)

                Dim fstrO As New FileStream("Ordonnances.xml", FileMode.OpenOrCreate, FileAccess.Write)
                Dim fwrO As New StreamWriter(fstrO, System.Text.Encoding.UTF8)

                xmlListFormatOdron.Serialize(fwrO, listOrdon)

                fwrO.Close()
                fstrO.Close()

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub menuQuiter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuQuiter.Click
        enregFichier()
        Me.Close()
    End Sub

    Private Sub menuAjoutOrdon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAjoutOrdon.Click, menuAjoutClient.Click
        Dim fntrEnreg As New EnregCOMME
        If sender.Equals(menuAjoutClient) Then
            fntrEnreg.tabEnreg.SelectedIndex = 0
        Else : fntrEnreg.tabEnreg.SelectedIndex = 1
        End If
        fntrEnreg.ShowDialog()

    End Sub

    Private Sub FenetreBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        listClt.list.Clear()
        listMedicam.list.Clear()
        listOrdon.list.Clear()

        Try
            Dim xmlForamtFichierC As New XmlSerializer(listClt.GetType)
            Dim fichier As New FileStream("Clients.xml", FileMode.Open, FileAccess.Read)
            listClt = xmlForamtFichierC.Deserialize(fichier)
            fichier.Close()
        Catch ex As Exception
            MsgBox("La liste des clients est introuvable ou le fichier est vide")
        End Try

        Try
            Dim xmlForamtFichierM As New XmlSerializer(listMedicam.GetType)
            Dim fichier As New FileStream("Medicaments.xml", FileMode.Open, FileAccess.Read)
            listMedicam = xmlForamtFichierM.Deserialize(fichier)
            fichier.Close()
        Catch ex As Exception
            MsgBox("La liste des medicaments est introuvable ou le fichier est vide")
        End Try



            Try
                Dim xmlForamtFichierO As New XmlSerializer(listOrdon.GetType)
                Dim fichier As New FileStream("Ordonnances.xml", FileMode.Open, FileAccess.Read)
                listOrdon = xmlForamtFichierO.Deserialize(fichier)
                fichier.Close()
            Catch ex As Exception
                MsgBox("La liste des ordonance est introuvable ou le fichier est vide")
            End Try



        comBxNom.DataSource = listClt.list
        comBxNom.ValueMember = "Nom"

        comBxPrenom.DataSource = listClt.list
        comBxPrenom.ValueMember = "Prenom"

        comBxBDay.DataSource = listClt.list
        comBxBDay.ValueMember = "Date_Naissance"

        comMedicam.DataSource = listMedicam.list
        comMedicam.ValueMember = "Nom_Produit"

        dgridVwClient.DataSource = listClt.list

        dGVwMedicam.DataSource = listMedicam.list

        dgVwOrdon.DataSource = listOrdon.list

    End Sub

    Private Sub btnModiFClint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModiFClint.CheckedChanged, btnModifMedic.CheckedChanged, btnModifieOrdon.CheckedChanged
        dgridVwClient.ReadOnly = Not btnModiFClint.Checked
        dGVwMedicam.ReadOnly = Not btnModifMedic.Checked
        dgVwOrdon.ReadOnly = Not btnModifieOrdon.Checked
    End Sub


    Private Sub btnAnnulPrescr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulPrescr.Click
        If dgVwOrdon.SelectedRows.Count > 0 Then
            dgVwOrdon.Rows.Remove(dgVwOrdon.SelectedRows(0))
        End If
    End Sub

    Private Sub FenetreBase_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        enregFichier()
    End Sub

    Private Sub INFOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INFO.Click

        MsgBox("Realiser par:" & vbNewLine & "Maxim Fluieraru" & vbNewLine & "1499295" & vbNewLine & "Groupe: 280" & vbNewLine & "2015")

    End Sub

    Private Sub EmployéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menuAjouterEmpl.Click
        Dim enregEmpl As New EregEmpl
        enregEmpl.ShowDialog()
    End Sub
End Class