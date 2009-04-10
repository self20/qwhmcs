Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Module Genel
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
            MsgBox(LErrorDatabase & vbCrLf & ex.Message, MsgBoxStyle.Critical, "QWHMCS")
            Curl = ""
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
            Return result
        Catch
            Return source
        End Try
    End Function
    Public Function XmlString2DataSet(ByVal xmlString As String) As DataSet
        Cursor.Current = Cursors.WaitCursor
        Dim quoteDataSet As DataSet = Nothing
        If [String].IsNullOrEmpty(xmlString) Then
            Return quoteDataSet
        End If
        Try
            Using stringReader As New StringReader(xmlString)
                quoteDataSet = New DataSet()
                quoteDataSet.ReadXml(stringReader)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
            quoteDataSet = Nothing
        End Try
        Return quoteDataSet
        Cursor.Current = Cursors.Default
    End Function
    Public Function XMLDownload(ByVal Action As String, Optional ByVal Id As Long = 0) As String
        Cursor.Current = Cursors.WaitCursor
        Dim ms As String = ""
        Dim a As New Random()
        Try
            Dim req As WebRequest = WebRequest.Create(APIAddress & "/qapi.php?action=" & Action & "&user=" & APIUsername & "&passwd=" & ConvertStringToMD5(APIPassword) & "&id=" & Id & "&rand=" & a.Next(10000, 30000))
            Dim result As WebResponse = req.GetResponse()
            Dim ReceiveStream As Stream = result.GetResponseStream()
            Dim enc As Encoding = System.Text.Encoding.Default
            Dim sr As StreamReader = New StreamReader(ReceiveStream, enc)
            ms = sr.ReadToEnd()
        Catch ex As Exception
            ms = "QWHMCSError:XML Download Problem"
        End Try
        Return ms
        Cursor.Current = Cursors.Default
    End Function
End Module
