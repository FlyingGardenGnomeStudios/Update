Imports System.IO
Imports System.Net
Imports System.Windows.Forms

Public Class CheckForUpdate
    Public Sub Check(ByVal Newest As String, ByVal Current As String, ByVal DLLLocation As String)
        Newest = "https://raw.githubusercontent.com/FlyingGardenGnomeStudios/Inventor-Batch-Program/master/Batch_Program/Resources/Version"
        Dim wr As HttpWebRequest = CType(WebRequest.Create(Newest.ToString), HttpWebRequest)
        Dim ws As HttpWebResponse = CType(wr.GetResponse(), HttpWebResponse)
        Dim str As Stream = ws.GetResponseStream()
        Dim inBuf(100000) As Byte
        Dim bytesToRead As Integer = CInt(inBuf.Length)
        Dim bytesRead As Integer = 0
        While bytesToRead > 0
            Dim n As Integer = str.Read(inBuf, bytesRead, bytesToRead)
            If n = 0 Then
                Exit While
            End If
            bytesRead += n
            bytesToRead -= n
        End While
        Dim fstr As New FileStream("version.txt", FileMode.OpenOrCreate, FileAccess.Write)
        fstr.Write(inBuf, 0, bytesRead)
        str.Close()
        fstr.Close()
        Dim sr As StreamReader = New System.IO.StreamReader("version.txt")
        Dim version As Integer = CInt(sr.ReadToEnd.Replace(".", "").Substring(0, 4))
        sr.Close()
        Dim Update As New Update
        If version > Current AndAlso version > My.Settings.Version Then
            My.Settings.DLLLocation = DLLLocation.Replace("Batch Program.dll", "BPAssembly.dll")
            My.Settings.Save()
            Update.lblCurrent.Text = Current
            Update.lblNewest.Text = version
            Update.ShowDialog()
        End If
    End Sub
End Class
