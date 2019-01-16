Public Class Alojamiento
    Private firma As String
    Private nombre As String
    Private descripcionAbre As String
    Private descripcionNoAbre As String
    Private telefono As Integer
    Private direccion As String
    Private email As String
    Private municipio As String
    Private provincia As String
    Private codPostal As Integer
    Private coordenadas As String
    Private web As Boolean
    Private calidad As Boolean
    Private restaurante As Boolean
    Private tienda As Boolean
    Private gastronomico As Boolean
    Private surfing As Boolean
    Private club As Boolean
    Private autocaravana As Boolean

    Public Sub New(ByVal nom As String, ByVal dir As String, ByVal mun As String, ByVal prov As String, ByVal cod As Integer, ByVal tel As Integer, ByVal em As String, ByVal sitio As String, ByVal firm As String,
                   ByVal descAbre As String, ByVal descNoAbre As String, ByVal coord As String, ByVal cali As Boolean, ByVal restauran As Boolean, ByVal tien As Boolean, ByVal gastro As Boolean,
                   ByVal surf As Boolean, ByVal clb As Boolean, ByVal autocara As Boolean)
        firma = firm
        nombre = nom
        descripcionAbre = descAbre
        descripcionNoAbre = descNoAbre
        telefono = tel
        email = em
        direccion = dir
        municipio = mun
        provincia = prov
        codPostal = cod
        coordenadas = coord
        web = sitio
        calidad = cali
        restaurante = restauran
        tienda = tien
        gastronomico = gastro
        surfing = surf
        club = clb
        autocaravana = autocara
    End Sub

    Sub New()

    End Sub
    Public Function getFirma() As String
        Return firma
    End Function
    Public Function getNombre() As String
        Return nombre
    End Function
    Public Function getDescripcionAbre() As String
        Return descripcionAbre
    End Function
    Public Function getDescripcionNoAbre() As String
        Return descripcionNoAbre
    End Function
    Public Function getTelefono() As Integer
        Return telefono
    End Function
    Public Function getDireccion() As String
        Return direccion
    End Function
    Public Function getMunicipio() As String
        Return municipio
    End Function
    Public Function getProvincia() As String
        Return provincia
    End Function
    Public Function getCodPostal() As Integer
        Return codPostal
    End Function
    Public Function getCoordenadas() As Integer
        Return coordenadas
    End Function
    Public Function getEmail() As String
        Return email
    End Function
    Public Function getWeb() As Boolean
        Return web
    End Function
    Public Function getCalidad() As Boolean
        Return calidad
    End Function
    Public Function getRestaurante() As Boolean
        Return restaurante
    End Function
    Public Function getTienda() As Boolean
        Return tienda
    End Function
    Public Function getGatronomico() As Boolean
        Return gastronomico
    End Function
    Public Function getSurfing() As Boolean
        Return surfing
    End Function
    Public Function getClub() As Boolean
        Return club
    End Function
    Public Function getAutocaravana() As Boolean
        Return autocaravana
    End Function
    '----------------------------------------------------------------------------------------------------------------------
    '----------------------------------------------------------------------------------------------------------------------
    Public Sub setFrima(ByVal firm As String)
        firma = firm
    End Sub
    Public Sub setNombre(ByVal nom As String)
        nombre = nom
    End Sub
    Public Sub setDescripcionAbre(ByVal descAb As String)
        descripcionAbre = descAb
    End Sub
    Public Sub setDescripcionNoAbre(ByVal descNOAb As String)
        descripcionNoAbre = descNOAb
    End Sub
    Public Sub setDireccion(ByVal dir As String)
        direccion = dir
    End Sub

    Public Sub setMunicipio(ByVal mun As String)
        municipio = mun
    End Sub

    Public Sub setProvincia(ByVal prov As String)
        provincia = prov
    End Sub

    Public Sub setCodPostal(ByVal cod As Integer)
        codPostal = cod
    End Sub

    Public Sub setTelefono(ByVal tel As Integer)
        telefono = tel
    End Sub

    Public Sub setEmail(ByVal em As String)
        email = em
    End Sub

    Public Sub setWeb(ByVal sw As Boolean)
        web = sw
    End Sub
    Public Sub setCalidad(ByVal cal As Boolean)
        calidad = cal
    End Sub



End Class

