Imports System.ComponentModel

<Serializable()>
Public Class LesEmployes

    Private Shared listEmploye As New BindingList(Of Employe_Pharm)

    Public Property list() As BindingList(Of Employe_Pharm)
        Get
            Return listEmploye
        End Get
        Set(ByVal value As BindingList(Of Employe_Pharm))
            listEmploye = value
        End Set
    End Property

    Public Function ouvrir(ByVal id_mdp As String) As Employe_Pharm

        For Each e As Employe_Pharm In listEmploye
            If e.ToString().Equals(id_mdp) Then
                Return e
            End If
        Next
        Return Nothing
    End Function


End Class


