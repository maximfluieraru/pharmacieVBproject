
<Serializable()>
Public Class Medicament
    Inherits Produit

    Private _DIN As String
    Private desc_medicam As String


    Public Sub New()

    End Sub

    Public Sub New(ByVal id_produit As String, ByVal nom_prod As String, ByVal prix_prod As Double, ByVal nb_unite As Double, _
                   ByVal DIN As String, ByVal desc_medicam As String)
        MyBase.id_produit = id_produit
        MyBase.nom_prod = nom_prod
        MyBase.prix_prod = prix_prod
        MyBase.nb_unite = nb_unite

        Me.DIN = DIN
        Me.desc_medicam = desc_medicam
    End Sub
    ''pour ajouter de nouveau medicament a partir d'un fichier
    'Public Sub New(ByVal nom_prod As String, ByVal prix_prod As Double, ByVal nb_unite As Double, _
    '               ByVal DIN As String, ByVal desc_medicam As String)

    '    MyBase.id_produit = nom_prod.Substring(0, 2) & DIN.Substring(0, 3)
    '    MyBase.nom_prod = nom_prod
    '    MyBase.prix_prod = prix_prod
    '    MyBase.nb_unite = nb_unite

    '    Me.DIN = DIN
    '    Me.desc_medicam = desc_medicam
    'End Sub

    Public Property DIN() As String
        Get
            Return _DIN
        End Get
        Set(ByVal value As String)
            _DIN = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return desc_medicam
        End Get
        Set(ByVal value As String)
            desc_medicam = value
        End Set
    End Property


End Class
