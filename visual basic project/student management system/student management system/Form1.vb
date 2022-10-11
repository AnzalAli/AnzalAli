Public Class Form1

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeOfStudyListBox.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnDisplayMessage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplayMessage.Click

        TxtOutputMessage.Text = "Student Name:" & TxtStudentName.Text & ControlChars.NewLine & "Course:" & CourseComboBox.Text & ControlChars.NewLine & "Student Age:" & TxtStudentAge.Text & ControlChars.NewLine & "Mode of Study:" & ModeOfStudyListBox.Text

    End Sub

  
    Private Sub TxtOutputMessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtOutputMessage.TextChanged

    End Sub
End Class
