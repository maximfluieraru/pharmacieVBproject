
<Serializable()>
Public MustInherit Class Produit

    Protected id_produit As String
    Protected nom_prod As String
    Protected prix_prod As Double
    Protected nb_unite As Double

    Public Property Produit_ID() As String
        Get
            Return id_produit
        End Get
        Set(ByVal value As String)
            id_produit = value
        End Set
    End Property

    Public Property Nom_Produit() As String
        Get
            Return nom_prod
        End Get
        Set(ByVal value As String)
            nom_prod = value
        End Set
    End Property

    Public Property Prix() As Double
        Get
            Return prix_prod
        End Get
        Set(ByVal value As Double)
            prix_prod = value
        End Set
    End Property

    Public Property Nb_Unites() As Double
        Get
            Return nb_unite
        End Get
        Set(ByVal value As Double)
            nb_unite = value
        End Set
    End Property

End Class
