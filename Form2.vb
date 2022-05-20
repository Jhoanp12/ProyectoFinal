Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub itmDeviceRegister_Click(sender As Object, e As EventArgs) Handles itmDeviceRegister.Click
        Dim fDeviceRegister As New DeviceRegister
        fDeviceRegister.MdiParent = Me
        fDeviceRegister.Show()
    End Sub

    Private Sub itmDeviceConsult_Click(sender As Object, e As EventArgs) Handles itmDeviceConsult.Click
        Dim fDeviceConsult As New DeviceConsult
        fDeviceConsult.MdiParent = Me
        fDeviceConsult.Show()
    End Sub
End Class