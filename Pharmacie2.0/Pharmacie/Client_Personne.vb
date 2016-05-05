Imports System.ComponentModel

<Serializable()>
Public Class Client_Personne
    Inherits Personne
   
    Private assurGouv As String
    Private assurPriv As String
    Private _allergies As Boolean
    Private commentaires As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal titre As String, ByVal nom As String, ByVal prenom As String, _
                  ByVal bDay As DateTime, ByVal tel As String, ByVal adresse As String, ByVal ville As String, _
                  ByVal codePostale As String, ByVal assurGouv As String, ByVal assurPriv As String, ByVal allergies As Boolean, _
                  ByVal commentaires As String)

        MyBase._titre = titre
        MyBase._nom = nom
        MyBase._prenom = prenom
        MyBase._bDay = bDay
        MyBase._tel = tel
        MyBase._adresse = adresse
        MyBase._ville = ville
        MyBase._codePostale = codePostale

        Me.assurGouv = assurGouv
        Me.assurPriv = assurPriv
        Me.Allergies = allergies
        Me.commentaires = commentaires

        MyBase.setID()

    End Sub

    Public Property Assurance_Gouv() As String
        Get
            Return assurGouv
        End Get
        Set(ByVal value As String)
            assurGouv = value
        End Set
    End Property

    Public Property Assurance() As String
        Get
            Return assurPriv
        End Get
        Set(ByVal value As String)
            assurPriv = value
        End Set
    End Property

    Public Property Allergies() As Boolean
        Get
            Return _allergies
        End Get
        Set(ByVal value As Boolean)
            _allergies = value
        End Set
    End Property

    Public Property Comentaires() As String
        Get
            Return commentaires
        End Get
        Set(ByVal value As String)
            commentaires = value
        End Set
    End Property

    Public Function isEquals(ByVal obj As Client_Personne) As Boolean
        If obj Is Nothing Then
            Return False
        End If
        Return (obj.ID = Me.ID And obj.Date_Naissance = Me.Date_Naissance)
    End Function

End Class
