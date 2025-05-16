Imports System.IO

Public Class frmChangeVolume

    Public s192FolderPath As String = ""

    Private Sub ChangeVolume_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFileList()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        If ListBox1.SelectedIndex = -1 Then
            MsgBox("Select a File")
            Exit Sub
        End If

        Dim sFileName As String = ListBox1.SelectedItem.ToString()
        Dim sFilePath As String = Path.Combine(s192FolderPath, sFileName)

        DecreaseMp3Volume(sFilePath, txtVolume.Text)
        SetFileList()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If ListBox1.SelectedIndex = -1 Then
            Exit Sub
        End If

        Dim sFileName As String = ListBox1.SelectedItem.ToString()
        Dim sFilePath As String = Path.Combine(s192FolderPath, sFileName)

        If File.Exists(sFilePath) Then
            File.Delete(sFilePath)
            SetFileList()
        End If

    End Sub

    Private Sub SetFileList()

        If System.IO.Directory.Exists(s192FolderPath) = False Then
            Exit Sub
        End If

        Dim sFileName As String = ""

        If ListBox1.SelectedIndex <> -1 Then
            sFileName = ListBox1.SelectedItem.ToString()
        End If

        ListBox1.Items.Clear()

        Dim oFiles As String() = System.IO.Directory.GetFiles(s192FolderPath)
        For Each sInputFilePath As String In oFiles
            Dim sName As String = Path.GetFileName(sInputFilePath)
            ListBox1.Items.Add(sName)
        Next

        Try
            ListBox1.SelectedItem = sFileName
        Catch ex As Exception
        End Try

    End Sub


    Sub DecreaseMp3Volume(ByVal sFilePath As String, Optional ByVal sVolume As String = "-2.5")

        Dim sFolderPath As String = Path.GetDirectoryName(sFilePath)
        Dim sFileName As String = Path.GetFileNameWithoutExtension(sFilePath)
        Dim sOutputFilePath As String = Path.Combine(sFolderPath, sFileName & sVolume & "_dB.mp3")

        If File.Exists(sOutputFilePath) Then
            Exit Sub
            'File.Delete(sOutputFilePath)
        End If

        Dim sFfmpegFolder As String = GetFolderPath("ffmpeg")
        Dim sFfmpegFile As String = sFfmpegFolder & "\bin\ffmpeg.exe"
        If IO.File.Exists(sFfmpegFile) = False Then
            MsgBox("ffmpeg.exe file is missing: " & sFfmpegFile)
            Exit Sub
        End If

        Dim oProcess As New System.Diagnostics.Process()
        Dim startInfo As New System.Diagnostics.ProcessStartInfo()
        startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
        startInfo.FileName = sFfmpegFile
        startInfo.Arguments = "-i """ & sFilePath & """ -af ""volume=" & sVolume & "dB"" -b:a ""192k"" """ & sOutputFilePath & """"
        oProcess.StartInfo = startInfo
        oProcess.Start()
        oProcess.WaitForExit()

    End Sub

    Private Function GetFolderPath(ByVal sFolderName As String) As String

        Dim sAssPath As String = System.Reflection.Assembly.GetExecutingAssembly().Location
        Dim sPath As String = System.IO.Path.GetDirectoryName(sAssPath)

        For i As Integer = 0 To 3
            Dim sRetPath As String = IO.Path.Combine(sPath, sFolderName)
            If IO.Directory.Exists(sRetPath) Then
                Return sRetPath
            End If

            sPath = IO.Directory.GetParent(sPath).FullName
        Next

        Return ""
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class