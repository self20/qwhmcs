Imports System.IO
Imports System.Security.Cryptography
Module DosyaIslemleri
    Public Function DosyaVarmıYokmu(ByVal sDosyaismi As String) As Boolean
        Try
            Dim dosya As String = CStr(sDosyaismi) 'Dosya ismi doğrulandı
            If File.Exists(dosya.Replace("""", "")) Then 'Doysanın verlığı kontrol ediliyor
                DosyaVarmıYokmu = True 'Doysa var olduğunda TRUE(Var) fonksiyona yükleniyor
            Else
                DosyaVarmıYokmu = False 'Dosya yokluğunda FALSE(Yok) fonksiyona yükleniyor
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata") 'Hata durumu
        End Try
    End Function
    'Örnek:::: DosyaVarmıYokmu("C: vlog.txt")
    Public Function DoysanınBoyutu(ByVal sDosyaİsmi As String) As Integer
        Try
            Dim dosya As String = CStr(sDosyaİsmi)
            Dim fileinfo As New FileInfo(dosya) 'Doysa özellik sınıfı oluşturuldu.
            If DosyaVarmıYokmu(dosya) Then 'Dosyanın varlığı kontrol edildi.
                DoysanınBoyutu = fileinfo.Length 'Var olduğu durumda doysa boyutu fonksiyona yüklendi
            Else
                MsgBox("Belirtilen dosya yolu bulunamadı", MsgBoxStyle.Critical, "Hata") 'Hata durumu
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    'Örnek:::: DoysanınBoyutu("C: vlog.txt")
    Public Function KlasörBoyutu(ByVal sKlasör As String) As Integer
        Try
            Dim total As Integer, dosyalar As String, klasörler As String 'Tanıtımlar

            For Each dosyalar In Directory.GetFiles(sKlasör) 'sKlasöründe bulunan dosyaların listesi
                total += FileLen(dosyalar) 'Klasör içindeki dosyaların toplam boyutu
            Next

            For Each klasörler In Directory.GetDirectories(sKlasör) 'sKlasöründe bulunan klasörlerin listesi
                total += KlasörBoyutu(klasörler) 'Toplam boyuta sonsuz klasör kadar döngü atılıyor.
            Next

            KlasörBoyutu = total 'Toplam boyut
            Return total
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata") 'Hata durumu
        End Try
    End Function
    'Örnek:::: KlasörBoyutu("C:Windows")
    Public Function KlasörVarmıYokmu(ByVal sklasör As String) As Boolean
        Try
            Dim klasör As String = CStr(sklasör) 'Klasör ismi doğrulanıyor.
            Dim klasörözellikleri As New DirectoryInfo(klasör) 'Klasör özellikleri tanımlanıyor
            KlasörVarmıYokmu = klasörözellikleri.Exists 'Klasör ün olup-olmadığı bulunuyor.
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata") 'Hata oluştu
        End Try
    End Function
    'Örnek:::: KlasörVamıYokmu("C:Windows")
    Public Function KlasörSil(ByVal sklasör As String, ByVal Tümü As Boolean) As Boolean
        Try
            If KlasörVarmıYokmu(sklasör) Then 'Klasör ün var olup olmadığı sorgulanıyor.
                Dim klasörözellikleri As New DirectoryInfo(CStr(sklasör)) 'Klasör özellikleri tanımlanıyor.
                klasörözellikleri.Delete(Tümü) 'Klasör siliniyor
            Else
                MsgBox("Belirtilen doysa yolu bulunamadı", MsgBoxStyle.Critical, "Hata") 'Hata mesajı
                Exit Function 'Fonksiyondan çık

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata") 'Hata oluştu
        End Try
    End Function
    'Örnek:::: KlasörSil("C:BEJO")
    Public Function DosyaKopyala(ByVal sdosya As String, ByVal skopyalanacakyer As String, ByVal üzerineyaz As Boolean) As Boolean
        Try
            If DosyaVarmıYokmu(CStr(sdosya)) Then 'Dosyanın olup olmadığı sorgulanıyor.
                File.Copy(CStr(sdosya), skopyalanacakyer, üzerineyaz) 'Dosya kopyalanıyor
            Else
                MsgBox("Belirtilen doysa yolu bulunamadı", MsgBoxStyle.Critical, "Hata") 'Hata mesajı
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata") 'Hata oluştu
        End Try
    End Function
    'Örnek:::: DosyaKopyala("C:ejo.txt","D:ejo.txt ",False)
    Public Function KlasörOluştur(ByVal sklasörismi As String, ByVal soluşturulacakkonum As String) As Boolean
        Try
            Dim klasör As String = CStr(sklasörismi) 'Klasör ismi tanımlanıyor.
            If KlasörVarmıYokmu(soluşturulacakkonum & klasör) Then 'Klasör varlığı kontrol ediliyor.
                'Belirtilen klasör ismi varsa eğer klasör oluşturulmayacak ve aşağıdaki mesaj gösterilecek.
                MsgBox("Belirtilen isimde klasör zaten mevcut", MsgBoxStyle.Critical, "Hata")
                Exit Function 'Fonksiyondan çık
            Else
                'Belirtilen klasör dizin içerisinde yoksa klasör'ü oluştur
                Directory.CreateDirectory(klasör) 'Klasör'ü oluştur.
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    'Örnek:::: KlasörOluştur("C:BEJO")
    Public Function DosyaSill(ByVal sDosyaismi As String) As Boolean
        Try
            Dim dosya As String = CStr(sDosyaismi)
            Dim dosyaözellikleri As New FileInfo(dosya)
            If dosyaözellikleri.Exists = True Then
                dosyaözellikleri.Delete()
            Else
                MsgBox("Belirtilen isimde doysa bulunamadı", MsgBoxStyle.Critical, "Hata")
                Exit Function
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function DoysaYenidenAdlandır(ByVal sodosyaismi As String, ByVal sndosyaismi As String) As Boolean
        Try
            Dim dosya As String = CStr(sodosyaismi)
            Dim yenidosyaismi As String = CStr(sndosyaismi)
            If DosyaVarmıYokmu(dosya) Then
                If DosyaVarmıYokmu(yenidosyaismi) Then
                    MsgBox("Belirtilen isimde zaten bir dosya bulunmakta", MsgBoxStyle.Critical, "Hata")
                    Exit Function
                Else
                    Rename(dosya, sndosyaismi)
                End If
            Else
                MsgBox("Belirtilen isimde dosya bulunamadı", MsgBoxStyle.Critical, "Hata")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function KlasörİçindekiDosyaSayısı(ByVal SKlasör As String) As Integer
        Try
            Dim dsayı As Integer, dosyalar As String, klasörler As String

            For Each dosyalar In Directory.GetFiles(SKlasör)
                dsayı += 1
            Next

            For Each klasörler In Directory.GetDirectories(SKlasör)
                dsayı += KlasörİçindekiDosyaSayısı(klasörler)
            Next
            KlasörİçindekiDosyaSayısı = dsayı
            Return dsayı
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function KlasörİçindekiKlasörSayısı(ByVal Sklasör As String) As Integer
        Try
            Dim ksayı As Integer, klasörler As String

            For Each klasörler In Directory.GetDirectories(Sklasör)
                ksayı += KlasörİçindekiKlasörSayısı(klasörler)
                ksayı += 1
            Next
            KlasörİçindekiKlasörSayısı = ksayı
            Return ksayı
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function KlasörüDosyayaAç(ByVal SKlasör As String, ByVal SAçılacakKlasör As String) As Boolean
        Try
            Dim klasör As String = SKlasör
            Dim AKlasör As String = SAçılacakKlasör
            Dim dosyalar, Klasörler As String

            For Each dosyalar In Directory.GetFiles(klasör)
                FileCopy(dosyalar, SAçılacakKlasör & "\" & Path.GetFileName(dosyalar))
            Next

            For Each Klasörler In Directory.GetDirectories(SKlasör)
                KlasörüDosyayaAç(Klasörler, AKlasör)
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function KlasörüKopyala(ByVal SKlasör As String, ByVal Skopyalanacakyer As String) As Boolean
        Try
            Dim klasörler, Dosyalar As String
            Dim klasörismi As String = New DirectoryInfo(SKlasör).Name
            Dim tamisim As String = Skopyalanacakyer & "" & klasörismi & ""
            MkDir(tamisim)

            For Each Dosyalar In Directory.GetFiles(SKlasör)
                FileCopy(Dosyalar, tamisim & "" & IO.Path.GetFileName(Dosyalar))
            Next

            For Each klasörler In Directory.GetDirectories(SKlasör)
                KlasörüKopyala(klasörler, tamisim)
            Next

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function KlasörüTaşı(ByVal Sklasörismi As String, ByVal STaşınacakKonum As String) As Boolean
        Try
            Dim klasör As New DirectoryInfo(Sklasörismi)
            Dim tklasör As New DirectoryInfo(STaşınacakKonum)

            If tklasör.Exists = False Then
                klasör.MoveTo(STaşınacakKonum)
            Else
                MsgBox("Belirtiğin konumda aynı isimde klasör bulunmaktadır.", MsgBoxStyle.Critical, "Hata")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function KlasörYenidenAdlandır(ByVal Sklasör As String, ByVal sYeniisim As String) As Boolean
        Try

            If KlasörVarmıYokmu(Sklasör) Then
                RmDir(Sklasör)
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Hata")
        End Try
    End Function
    Public Function DosyaIsimBul(ByVal filePath As String) As String
        Dim md5 As MD5CryptoServiceProvider = New MD5CryptoServiceProvider
        Dim f As FileStream = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        f = New FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read, 8192)
        md5.ComputeHash(f)
        Dim hash As Byte() = md5.Hash
        Dim buff As System.Text.StringBuilder = New System.Text.StringBuilder
        Dim hashByte As Byte
        For Each hashByte In hash
            buff.Append(String.Format("{0:X2}", hashByte))
        Next
        Dim a As String
        a = buff.ToString().ToUpper
        Return a.Substring(0, 4) & "-" & a.Substring(4, 4) & "-" & a.Substring(8, 4) & "-" & a.Substring(12, 4) & "-" & a.Substring(16, 4) & "-" & a.Substring(20, 4) & "-" & a.Substring(24, 4) & "-" & a.Substring(28, 4)
    End Function
End Module
