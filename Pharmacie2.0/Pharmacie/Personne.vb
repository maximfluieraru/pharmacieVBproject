
<Serializable()>
Public MustInherit Class Personne

    Protected _id As String
    Protected _titre As String
    Protected _nom As String
    Protected _prenom As String
    Protected _bDay As DateTime
    Protected _tel As String
    Protected _adresse As String
    Protected _ville As String
    Protected _codePostale As String

    Protected Sub setID()
        Me.ID = Me.Nom.Substring(0, 2) & Me.Prenom.Substring(0, 3)
    End Sub

    Public Property ID() As String
        Get
            Return Me._id
        End Get
        Set(ByVal value As String)
            _id = value
        End Set
    End Property

    Public Property Titre() As String
        Get
            Return Me._titre
        End Get
        Set(ByVal value As String)
            _titre = value
        End Set
    End Property

    Public Property Nom() As String
        Get
            Return Me._nom
        End Get
        Set(ByVal value As String)
            _nom = value
        End Set
    End Property

    Public Property Prenom() As String
        Get
            Return Me._prenom
        End Get
        Set(ByVal value As String)
            _prenom = value
        End Set
    End Property

    Public Property Date_Naissance() As DateTime
        Get
            Return _bDay
        End Get
        Set(ByVal value As DateTime)
            _bDay = value
        End Set
    End Property

    Public Property Telephone() As String
        Get
            Return Me._tel
        End Get
        Set(ByVal value As String)
            _tel = value
        End Set
    End Property

    Public Property Adresse() As String
        Get
            Return Me._adresse
        End Get
        Set(ByVal value As String)
            _adresse = value
        End Set
    End Property

    Public Property Ville() As String
        Get
            Return Me._ville
        End Get
        Set(ByVal value As String)
            _ville = value
        End Set
    End Property

    Public Property Code_Postale() As String
        Get
            Return Me._codePostale
        End Get
        Set(ByVal value As String)
            _codePostale = value
        End Set
    End Property

End Class
