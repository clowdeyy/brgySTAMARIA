Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports System.IO

Public Class frmCapture
    Dim cam As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub frmCapture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim camera As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If camera.ShowDialog() = Windows.Forms.DialogResult.OK Then
            cam = camera.VideoDevice
            AddHandler cam.NewFrame, New NewFrameEventHandler(AddressOf captured)
            cam.Start()
        End If

    End Sub
    Private Sub captured(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        picImage.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)
    End Sub
    Function ImageToBase64(ByVal image As Image, ByVal format As System.Drawing.Imaging.ImageFormat) As String
        Dim ms As New MemoryStream
        image.Save(ms, format)
        Dim imageByte() As Byte = ms.ToArray()
        Dim base64string As String = Convert.ToBase64String(imageByte)
        Return base64string
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        DbConnect()
        Dim qry0 As String = "SET GLOBAL max_allowed_packet=32*1024*1024;"
        Dim qry As String = "UPDATE residence SET res_image ='" & ImageToBase64(picImage.Image, System.Drawing.Imaging.ImageFormat.Png) & "' WHERE res_id = '" & resID.Text & "'"
        ExecuteQuery(qry0 + qry)
        DbDisconnect()
        MetroFramework.MetroMessageBox.Show(Me, " 
Resident image saved.", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Question)
        cam.Stop()
        Me.Dispose()
        Dim res As New ucAddResidence
        toPanelMain(res.Width, res.Height, res)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        cam.Stop()
        Me.Close()
    End Sub

    Private Sub resID_Click(sender As Object, e As EventArgs) Handles resID.Click

    End Sub
End Class