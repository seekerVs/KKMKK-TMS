


Imports System.ComponentModel

Public Class Login_form

    Private MainForm As Main_form

    Public Sub New(ByVal parent As Main_form)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.MainForm = parent
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        MainForm.Hello()
    End Sub
End Class