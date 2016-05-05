
<Serializable()>
Public Class Employe_Pharm
    Inherits Personne

    Private _le_poste As String
    Private _mot_d_passe As String
    Private _NAS As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal titre As String, ByVal nom As String, ByVal prenom As String, _
                 ByVal bDay As DateTime, ByVal tel As String, ByVal adresse As String, ByVal ville As String, _
                 ByVal codePostale As String, ByVal le_poste As String, ByVal mot_d_passe As String, _
                 ByVal NAS As String)

        MyBase._titre = titre
        MyBase._nom = nom
        MyBase._prenom = prenom
        MyBase._bDay = bDay
        MyBase._tel = tel
        MyBase._adresse = adresse
        MyBase._ville = ville
        MyBase._codePostale = codePostale

        Me._le_poste = le_poste
        Me._mot_d_passe = mot_d_passe
        Me._NAS = NAS

        MyBase.setID()

    End Sub

    Public Property le_poste() As String
        Get
            Return _le_poste
        End Get
        Set(ByVal value As String)
            _le_poste = value
        End Set
    End Property

    Public Property mot_de_passe() As String
        Get
            Return _mot_d_passe
        End Get
        Set(ByVal value As String)
            _mot_d_passe = value
        End Set
    End Property


    Public Property NAS() As String
        Get
            Return _NAS
        End Get
        Set(ByVal value As String)
            _NAS = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return MyBase.ID & Me._mot_d_passe
    End Function



End Class
