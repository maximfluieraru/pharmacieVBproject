Imports System.Windows.Forms

Public Class EnregCOMME

    Private client As Client_Personne
    Private ordon As Ordonnance
    Private listOrdon As New LesOrdonnances
    Private listClt As New LesClients
    Private listMedicam As New LesMedicaments

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click, btnAnnulOrd.Click

        Me.Close()

    End Sub

    Private Sub btnEnregClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregClient.Click
        Dim trouv As Boolean = True
        Dim titre As String
        Dim allerg As Boolean = rBtnOuiAllergies.Checked

        Dim bDay As String = bxA.SelectedItem + "-" + bxM.SelectedItem + "-" + bxJ.SelectedItem

        If (rBtnM.Checked) Then
            titre = rBtnM.Tag
        Else
            titre = rBtnMme.Tag
        End If

        Try
            client = New Client_Personne(titre, txtBxNom.Text, txtBxPrenom.Text, CDate(bDay), txtBxTel.Text, txtBxAdresse.Text, _
                                    txtBxVille.Text, txtBxCP.Text, txtBxAssGouv.Text, txtBxAssPriv.Text, allerg, txtBxComment.Text)

            For Each clnt In listClt.list
                If (clnt.isEquals(client)) Then
                    MsgBox("le client est deja enregistrer!")
                    trouv = False
                    Exit For
                End If
            Next

            If trouv Then
                listClt.list.Add(client)
                MsgBox("Le client est enregistrer!")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox("Verifier les donnees du client")
        End Try

    End Sub

    Private Sub EnregCOMME_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        combBxIdClient.DataSource = listClt.list
        combBxIdClient.ValueMember = "ID"
        comBxOrdonMedicam.DataSource = listMedicam.list
        comBxOrdonMedicam.ValueMember = "Nom_Produit"
        comBxNomClient.DataSource = listClt.list
        comBxNomClient.ValueMember = "Nom"

    End Sub

    Private Sub btnAjoutMed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAjoutMed.Click


        Dim qte As Integer = listMedicam.list.Item(comBxOrdonMedicam.SelectedIndex).Nb_Unites

        If IsNumeric(txtBxQty.Text) Then
            qte -= txtBxQty.Text
            MsgBox(listMedicam.list.Item(comBxOrdonMedicam.SelectedIndex).Nom_Produit & vbNewLine & " Qte:" & txtBxQty.Text & vbNewLine & "a ete ajouté.")
        Else : MsgBox("saisir un valeur numerique valide")
            Return
        End If

        If (qte < 0) Then
            MsgBox("Quantitee insuffisante")
        Else
            ordon = New Ordonnance(listClt.list.Item(combBxIdClient.SelectedIndex).ID)

            listMedicam.list.Item(comBxOrdonMedicam.SelectedIndex).Nb_Unites = qte
            ordon.Medicament = listMedicam.list.Item(comBxOrdonMedicam.SelectedIndex).Nom_Produit & " Qte:" & txtBxQty.Text
        End If
    End Sub

    Private Sub btnEnregOrd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregOrd.Click
        Try
            ordon.Nb_Renouvlemnts = cmbBxRenvl.SelectedItem
            ordon.Date_Redaction = dateTimeOrdon.Value.ToLongDateString
            ordon.ID = txtBxOrd.Text
            ordon.Medecin = txtBxMed.Text
            listOrdon.list.Add(ordon)
            MsgBox("L'ordonnace a ete enregistree")
            Me.Close()
        Catch ex As Exception
            MsgBox("verifier les donnees")
        End Try

    End Sub

End Class