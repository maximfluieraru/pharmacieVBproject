Imports System.Collections.Generic

<Serializable()>
Public Class Ordonnance

    Private client_id As String
    Private id_ordonn As String
    Private _docteur As String
    Private _medicam As String
    Private nb_renvl_admis As Integer
    Private date_redact_ord As DateTime
    Private confirmPharm As Boolean

    Public Sub New()

    End Sub

    Public Sub New(ByVal client_id As String)
        Me.client_id = client_id
        Me.confirmPharm = False
    End Sub

    Public Sub New(ByVal client_id As String, ByVal id_ordonn As String, ByVal docteur As String, ByVal nb_renvl_admis As Integer, _
                   ByVal date_redact_ord As String)
        Me.New(client_id)
        Me.id_ordonn = id_ordonn
        Me._docteur = docteur
        Me.nb_renvl_admis = nb_renvl_admis
        Me.date_redact_ord = date_redact_ord
    End Sub

    Public Property ID_Client() As String
        Get
            Return client_id
        End Get
        Set(ByVal value As String)
            client_id = value
        End Set
    End Property


    Public Property ID() As String
        Get
            Return id_ordonn
        End Get
        Set(ByVal value As String)
            id_ordonn = value
        End Set
    End Property

    Public Property Medecin() As String
        Get
            Return _docteur
        End Get
        Set(ByVal value As String)
            _docteur = value
        End Set
    End Property

    Public Property Nb_Renouvlemnts() As Integer
        Get
            Return nb_renvl_admis
        End Get
        Set(ByVal value As Integer)
            nb_renvl_admis = value
        End Set
    End Property

    Public Property Date_Redaction() As String
        Get
            Return date_redact_ord
        End Get
        Set(ByVal value As String)
            date_redact_ord = value
        End Set
    End Property

    Public Property Confirmees() As Boolean
        Get
            Return confirmPharm
        End Get
        Set(ByVal value As Boolean)
            confirmPharm = value
        End Set
    End Property


    Public Property Medicament() As String
        Get
            Return _medicam
        End Get
        Set(ByVal value As String)
            _medicam = value
        End Set
    End Property


End Class
