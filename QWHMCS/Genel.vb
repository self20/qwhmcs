Module Genel
    Public Enum SorguSekli
        Tek = 0
        Tablo = 1
        Cevapsız = 2
    End Enum
    Public ConStrSirket As String
    Public BaglantiSirket As Odbc.OdbcConnection
    Public SetupDurumu As Boolean = False
    'Language
    Public LOpenTicket As String
    Public LClosedTicket As String
    Public LAnswered As String
    Public LCusAnswered As String
    Public LcmdOpen As String
    Public LcmdClose As String
    Public LcmdHide As String
    Public LcmdRefresh As String
    Public LcmdSettings As String
    Public LColDate As String
    Public LColDepartment As String
    Public LColName As String
    Public LColSubName As String
    Public LColTitle As String
    Public LColStatus As String
    Public LColUrgency As String
    Public LBaloonCaption As String
    Public LBaloonNewTicket As String
    Public LBaloonNewAnswer As String
    Public LErrorDatabase As String
    Public RefreshRate As Long
    Public Transparency As Long
    Public Function SorguMySQL(ByVal SorguSekli As SorguSekli, ByVal Baglanti As Odbc.OdbcConnection, ByRef SQL As String, Optional ByRef Alan As String = "0") As Object
        Select Case SorguSekli
            Case 0
                Dim MyAdp As New Odbc.OdbcDataAdapter
                Dim Kayitset As New DataSet
                Dim MyTable As New DataTable
                Dim MyRow As DataRow
                Try
                    Dim SSQL As New Odbc.OdbcCommand(SQL, Baglanti)
                    MyAdp = New Odbc.OdbcDataAdapter(SSQL)
                    MyAdp.Fill(Kayitset)
                    MyTable = Kayitset.Tables(0)
                    If MyTable.Rows.Count <> 0 Then
                        MyRow = MyTable.Rows(0)
                        If Alan = "0" Then
                            SorguMySQL = MyRow(0)
                        Else
                            SorguMySQL = MyRow(Alan)
                        End If
                    Else
                        SorguMySQL = "Veri Yok"
                    End If
                Catch ex As Exception
                    MsgBox(LErrorDatabase & vbCrLf & SQL & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                    SorguMySQL = ""
                    Exit Function
                End Try
                MyRow = Nothing
                MyTable = Nothing
                Kayitset = Nothing
                MyAdp = Nothing
            Case 1
                Dim MyAdp As New Odbc.OdbcDataAdapter
                Dim Kayitset As New DataSet
                Try
                    Dim SSQL As New Odbc.OdbcCommand(SQL, Baglanti)
                    MyAdp = New Odbc.OdbcDataAdapter(SSQL)
                    MyAdp.Fill(Kayitset)
                    SorguMySQL = Kayitset.Tables(0)
                Catch ex As Exception
                    MsgBox(LErrorDatabase & vbCrLf & SQL & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                    SorguMySQL = New DataTable
                    Exit Function
                End Try
            Case 2
                Try
                    Dim SSQL As New Odbc.OdbcCommand(SQL, Baglanti)
                    SSQL.ExecuteNonQuery()
                    SorguMySQL = True
                Catch ex As Exception
                    MsgBox(LErrorDatabase & vbCrLf & SQL & vbCrLf & ex.Message, MsgBoxStyle.Critical)
                    SorguMySQL = False
                    Exit Function
                End Try
            Case Else
                SorguMySQL = Nothing
        End Select
    End Function

    Public Declare Auto Function PlaySound Lib "winmm.dll" (ByVal lpszSoundName As String, ByVal hModule As Integer, ByVal dwFlags As Integer) As Integer
    Const SND_FILENAME As Integer = &H20000
    Const SND_ALIAS As Integer = &H10000
    Const SND_SYNC As Integer = &H0
    Declare Auto Function waveOutGetNumDevs Lib "winmm.dll" Alias "waveOutGetNumDevs" () As Int32
    Declare Auto Function sndPlaySound Lib "WINMM.DLL" (ByVal FileName As String, ByVal Options As Int32) As Int32
    Private Const SND_MEMORY As Integer = &H4
    Private Const SND_ASYNC As Integer = &H1
    Private Const PROCESS_DOMAIN As String = ""
    Const SND_SYNC1 = &H0
    Const SND_ASYNC1 = &H1
    Const SND_NODEFAULT = &H2
    Const SND_LOOP = &H8
    Const SND_NOSTOP = &H10
End Module
