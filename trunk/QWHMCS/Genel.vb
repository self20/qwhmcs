Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Module Genel
    Public Enum SorguSekli
        Tek = 0
        Tablo = 1
        Cevapsız = 2
    End Enum
    Public ConStrSirket As String
    Public BaglantiSirket As Odbc.OdbcConnection
    Public SetupDurumu As Boolean = False
    Public WHMCSAddress As String
    Public APIAddress As String
    Public APIUsername As String
    Public APIPassword As String
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
                    SorguMySQL = New DataTable
                    Exit Function
                End Try
            Case 2
                Try
                    Dim SSQL As New Odbc.OdbcCommand(SQL, Baglanti)
                    SSQL.ExecuteNonQuery()
                    SorguMySQL = True
                Catch ex As Exception
                    SorguMySQL = False
                    Exit Function
                End Try
            Case Else
                SorguMySQL = Nothing
        End Select
    End Function
    Function ConvertStringToMD5(ByVal ClearText As String) As String
        Dim ByteData As Byte() = Encoding.ASCII.GetBytes(ClearText)
        Dim oMd5 As MD5 = MD5.Create()
        Dim HashData As Byte() = oMd5.ComputeHash(ByteData)
        Dim oSb As StringBuilder = New StringBuilder()
        Dim x As Integer = 0
        Do While x < HashData.Length
            oSb.Append(HashData(x).ToString("x2"))
            x += 1
        Loop
        Return oSb.ToString()
    End Function
    Public Function Curl(ByVal URL As String, ByVal Post As String) As Boolean
        Try
            Dim Sonuc As String
            Dim data() As String
            Dim postBuffer As Byte() = System.Text.Encoding.Default.GetBytes(Post)
            Dim request As HttpWebRequest = DirectCast(WebRequest.Create(URL), HttpWebRequest)
            request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; en-EN; rv:1.9.0.5) Gecko/2008120122 Firefox/3.0.5"
            request.Method = "POST"
            request.ContentType = "application/x-www-form-urlencoded"
            request.ContentLength = postBuffer.Length
            Dim requestStream As Stream = request.GetRequestStream()
            requestStream.Write(postBuffer, 0, postBuffer.Length)
            requestStream.Close()
            Dim response As HttpWebResponse = DirectCast(request.GetResponse(), HttpWebResponse)
            Dim objStream As New StreamReader(response.GetResponseStream())
            Sonuc = objStream.ReadToEnd()
            data = Split(Sonuc, ";")
            Dim temp() As String
            Dim results As New Collection()
            For Each temp1 As String In data
                temp = Split(temp1, "=")
                results.Add(temp(1), temp(0))
            Next
            If results.Item("result") = "success" Then
                Curl = True
                Exit Function
            Else
                Curl = False
                MsgBox("Error :" & vbCrLf & results.Item("message"))
                Exit Function
            End If
            postBuffer = Nothing
        Catch ex As Exception
            MsgBox("API Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "QWHMCS")
            Curl = ""
        End Try
    End Function
    Public Function SorguGridMySQL(ByRef Tip As Integer, ByRef Baglanti As Odbc.OdbcConnection, ByRef SQL As String, ByRef Grid As DevExpress.XtraGrid.GridControl) As Boolean
        Dim nMysqlCommand As New Odbc.OdbcCommand
        nMysqlCommand.Connection = Baglanti
        Select Case Tip
            Case 1
                nMysqlCommand.CommandType = CommandType.Text
            Case 2
                nMysqlCommand.CommandType = CommandType.TableDirect
            Case 3
                nMysqlCommand.CommandType = CommandType.StoredProcedure
        End Select
        nMysqlCommand.CommandText = SQL
        Try
            Dim Dates As New Odbc.OdbcDataAdapter
            Dim Datass As New DataSet
            Dates = New Odbc.OdbcDataAdapter(nMysqlCommand)
            Dates.Fill(Datass)
            Grid.DataSource = Datass.Tables(0).DefaultView
        Catch ex As Exception
            SorguGridMySQL = False
        End Try
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
    Public Function StripHTML(ByVal source As String) As String
        Try
            Dim result As String
            result = System.Text.RegularExpressions.Regex.Replace(source, "<[^>]*>", String.Empty)
            'result = source.Replace(vbCr, " ")
            'result = result.Replace(vbLf, " ")
            'result = result.Replace(vbTab, String.Empty)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "( )+", " ")
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*head([^>])*>", "<head>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(<( )*(/)( )*head( )*>)", "</head>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(<head>).*(</head>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*script([^>])*>", "<script>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(<( )*(/)( )*script( )*>)", "</script>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(<script>).*(</script>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*style([^>])*>", "<style>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(<( )*(/)( )*style( )*>)", "</style>", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(<style>).*(</style>)", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*td([^>])*>", vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*br( )*>", vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*li( )*>", vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*div([^>])*>", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*tr([^>])*>", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<( )*p([^>])*>", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<[^>]*>", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, " ", " ", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "•", " * ", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "‹", "<", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "›", ">", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "™", "(tm)", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "⁄", "/", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "<", "<", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, ">", ">", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "©", "(c)", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "®", "(r)", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "&(.{2,6});", String.Empty, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = result.Replace(vbLf, vbCr)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")( )+(" & vbCr & ")", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbTab & ")( )+(" & vbTab & ")", vbTab & vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbTab & ")( )+(" & vbCr & ")", vbTab & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")( )+(" & vbTab & ")", vbCr & vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")(" & vbTab & ")+(" & vbCr & ")", vbCr & vbCr, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'result = System.Text.RegularExpressions.Regex.Replace(result, "(" & vbCr & ")(" & vbTab & ")+", vbCr & vbTab, System.Text.RegularExpressions.RegexOptions.IgnoreCase)
            'Dim breaks As String = vbCr & vbCr & vbCr
            'Dim tabs As String = vbTab & vbTab & vbTab & vbTab & vbTab
            'For index As Integer = 0 To result.Length - 1
            '    result = result.Replace(breaks, vbCr & vbCr)
            '    result = result.Replace(tabs, vbTab & vbTab & vbTab & vbTab)
            '    breaks = breaks & vbCr
            '    tabs = tabs & vbTab
            'Next
            Return result
        Catch
            Return source
        End Try
    End Function

End Module
