Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelStudent.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelGender.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirstStudent.Click
        TextBoxStudentNAME.Text = "Mwiti"
        TextBoxCourseName.Text = "BSC"
        TextBoxGender.Text = "Male"

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnThirdStudent.Click
        TextBoxStudentNAME.Text = "Jaff"
        TextBoxCourseName.Text = "BIT"
        TextBoxGender.Text = "Male"

    End Sub

    Private Sub BtnSecondStudent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSecondStudent.Click
        TextBoxStudentNAME.Text = "Anzal"
        TextBoxCourseName.Text = "BBIT"
        TextBoxGender.Text = "Female"


    End Sub

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        BtnExit_Click()


    End Sub
End Class
