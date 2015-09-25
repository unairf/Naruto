
Imports System.IO

Public Class Capitulo
    Private _Nombre As String
    Private _Enlace As String
    Private _Numero As Integer
    Private _Descarga As String
    Private _Visto As Boolean

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Enlace As String
        Get
            Return _Enlace
        End Get
        Set(ByVal value As String)
            _Enlace = value
        End Set
    End Property

    Public Property Numero As Integer
        Get
            Return _Numero
        End Get
        Set(ByVal value As Integer)
            _Numero = value
        End Set
    End Property

    Public Property Descarga As String
        Get
            Return _Descarga
        End Get
        Set(ByVal value As String)
            _Descarga = value
        End Set
    End Property

    Public Property Visto As Boolean
        Get
            Return _Visto
        End Get
        Set(ByVal value As Boolean)
            _Visto = value
        End Set
    End Property
    Public Function CargarEpisodiosLista(ByVal nombreSerie As String) As String()
        If Not Directory.Exists(My.Application.Info.DirectoryPath & "\Capitulos\") Then Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Capitulos\")
        If Not File.Exists(My.Application.Info.DirectoryPath & "\Capitulos\" & nombreSerie & ".txt") Then File.Create(My.Application.Info.DirectoryPath & "\Capitulos\" & nombreSerie & ".txt")
        ficR = New StreamReader(My.Application.Info.DirectoryPath & "\Capitulos\" & nombreSerie & ".txt")
        Dim lineas(0) As String
        Dim cont As Integer = 0
        Do Until ficR.EndOfStream
            ReDim Preserve lineas(cont)
            lineas(cont) = ficR.ReadLine

            cont += 1
        Loop
        ficR.Close()
        Return lineas
    End Function

    Public Function CargarCapitulos(ByVal nombreserie As String) As List(Of Capitulo)
        Dim miLista As New List(Of Capitulo)
        Dim miCapitulo As New Capitulo
        If Not Directory.Exists(My.Application.Info.DirectoryPath & "\Capitulos\") Then Directory.CreateDirectory(My.Application.Info.DirectoryPath & "\Capitulos\")
        If Not File.Exists(My.Application.Info.DirectoryPath & "\Capitulos\" & nombreserie & ".txt") Then File.Create(My.Application.Info.DirectoryPath & "\Capitulos\" & nombreserie & ".txt")
        ficR = New StreamReader(My.Application.Info.DirectoryPath & "\Capitulos\" & nombreserie & ".txt")
        Dim linea As String
        Dim datos() As String
        Do Until ficR.EndOfStream
            linea = ficR.ReadLine
            datos = linea.Split("*")
            miCapitulo.Nombre = datos(0)
            miCapitulo.Numero = datos(1)
            If datos(2).ToLower = "true" Then miCapitulo.Visto = True Else miCapitulo.Visto = False
            miCapitulo._Enlace = datos(3)
            miCapitulo.Descarga = datos(4)

        Loop
        Return miLista
        ficR.Close()
    End Function
End Class
