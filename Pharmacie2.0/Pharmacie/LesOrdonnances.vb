Imports System.ComponentModel

<Serializable()>
Public Class LesOrdonnances

    Private Shared listOrdonance As New BindingList(Of Ordonnance)


    Public Property list() As BindingList(Of Ordonnance)
        Get
            Return listOrdonance
        End Get
        Set(ByVal value As BindingList(Of Ordonnance))
            listOrdonance = value
        End Set
    End Property


End Class
