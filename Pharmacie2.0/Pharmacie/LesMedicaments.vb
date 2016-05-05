Imports System.ComponentModel

<Serializable()>
Public Class LesMedicaments

    Private Shared listMedicament As New BindingList(Of Medicament)

    Public Property list() As BindingList(Of Medicament)
        Get
            Return listMedicament
        End Get
        Set(ByVal value As BindingList(Of Medicament))
            listMedicament = value
        End Set
    End Property


End Class
