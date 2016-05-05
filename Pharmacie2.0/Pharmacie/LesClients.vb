Imports System.ComponentModel

<Serializable()>
Public Class LesClients

    Private Shared listClient As New BindingList(Of Client_Personne)

    Public Property list() As BindingList(Of Client_Personne)
        Get
            Return listClient
        End Get
        Set(ByVal value As BindingList(Of Client_Personne))
            listClient = value
        End Set
    End Property


End Class
