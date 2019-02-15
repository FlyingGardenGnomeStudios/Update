Public Class Update
    Dim Client As New Net.WebClient

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim NewDLL As String = "https://github.com/FlyingGardenGnomeStudios/Inventor-Batch-Program/blob/master/Batch_Program/bin/Debug/BPAssembly.dll"
        Client.DownloadFile(NewDLL, My.Settings.DLLLocation)
        My.Settings.Version = lblCurrent.Text
        Me.Close()
    End Sub

    Private Sub btnSkip_Click(sender As Object, e As EventArgs) Handles btnSkip.Click
        My.Settings.Version = lblNewest.Text
        Me.Close()
    End Sub
End Class
