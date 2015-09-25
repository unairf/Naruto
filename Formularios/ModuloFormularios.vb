
Imports System.IO
Imports Clases
Imports System.Net

Module ModuloFormularios
    Public grpCap As New GroupBox
    Public pnl As New Panel
    Public serieElegida As String
    Public misControles As New List(Of Control)
    Public myWebClient As New WebClient()
    Public enlace As String
    Public ficR As StreamReader
    Public num As Integer = 0
    Public espera As Integer = 0
    'Public pnl As New Panel
    Public frmVer As New frmVerCapitulo
    Public reproductorVisible As Boolean
    Public numNoQuitar As Integer = 0
    Public lineaCompleta As String
    Public ficW As StreamWriter
    Public miCapitulo As New Capitulo
    Public focusCapituloY As Integer
    Public longitudBotones As Integer = 210
End Module
