Public Class EregEmpl

    Private listEmpl As New LesEmployes

    Private Sub btnEnregClient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnregClient.Click

        Dim titre As String
        Dim le_poste As String
        Dim empl As Employe_Pharm
        Dim bDay As String = bxA.SelectedItem + "-" + bxM.SelectedItem + "-" + bxJ.SelectedItem

        If (rBtnM.Checked) Then
            titre = rBtnM.Tag
        Else
            titre = rBtnMme.Tag
        End If

        If radBtnAdmin.Checked Then
            le_poste = radBtnAdmin.Tag
        ElseIf radBtnCommis.Checked Then
            le_poste = radBtnCommis.Tag
        Else
            le_poste = radBtnPharm.Tag
        End If

        Try
            empl = New Employe_Pharm(titre, txtBxNom.Text, txtBxPrenom.Text, CDate(bDay), txtBxTel.Text, txtBxAdresse.Text, _
                                    txtBxVille.Text, txtBxCP.Text, le_poste, txtBxPass.Text, txtBxNAS.Text)

            listEmpl.list.Add(empl)
            MsgBox("L'employe est enregistre!")
            Me.Close()

        Catch ex As Exception
            MsgBox("Verifier les donnees du client")
        End Try

    End Sub

    Private Sub btnAnnuler_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnuler.Click
        Me.Close()
    End Sub

    Private Sub EregEmpl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dgridVwEmpl.DataSource = listEmpl.list
    End Sub

    Private Sub btnModiFClint_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifEmpl.CheckedChanged
        dgridVwEmpl.ReadOnly = Not btnModifEmpl.Checked
    End Sub
End Class