<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelStudent = New System.Windows.Forms.Label()
        Me.LabelCourseName = New System.Windows.Forms.Label()
        Me.LabelGender = New System.Windows.Forms.Label()
        Me.TextBoxGender = New System.Windows.Forms.TextBox()
        Me.TextBoxCourseName = New System.Windows.Forms.TextBox()
        Me.TextBoxStudentNAME = New System.Windows.Forms.TextBox()
        Me.BtnFirstStudent = New System.Windows.Forms.Button()
        Me.BtnSecondStudent = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnThirdStudent = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelStudent
        '
        Me.LabelStudent.AutoSize = True
        Me.LabelStudent.Location = New System.Drawing.Point(44, 24)
        Me.LabelStudent.Name = "LabelStudent"
        Me.LabelStudent.Size = New System.Drawing.Size(66, 20)
        Me.LabelStudent.TabIndex = 0
        Me.LabelStudent.Text = "Student"
        '
        'LabelCourseName
        '
        Me.LabelCourseName.AutoSize = True
        Me.LabelCourseName.Location = New System.Drawing.Point(44, 98)
        Me.LabelCourseName.Name = "LabelCourseName"
        Me.LabelCourseName.Size = New System.Drawing.Size(106, 20)
        Me.LabelCourseName.TabIndex = 1
        Me.LabelCourseName.Text = "Course Name"
        '
        'LabelGender
        '
        Me.LabelGender.AutoSize = True
        Me.LabelGender.Location = New System.Drawing.Point(44, 182)
        Me.LabelGender.Name = "LabelGender"
        Me.LabelGender.Size = New System.Drawing.Size(63, 20)
        Me.LabelGender.TabIndex = 2
        Me.LabelGender.Text = "Gender"
        '
        'TextBoxGender
        '
        Me.TextBoxGender.Location = New System.Drawing.Point(177, 179)
        Me.TextBoxGender.Name = "TextBoxGender"
        Me.TextBoxGender.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxGender.TabIndex = 3
        '
        'TextBoxCourseName
        '
        Me.TextBoxCourseName.Location = New System.Drawing.Point(177, 92)
        Me.TextBoxCourseName.Name = "TextBoxCourseName"
        Me.TextBoxCourseName.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxCourseName.TabIndex = 4
        '
        'TextBoxStudentNAME
        '
        Me.TextBoxStudentNAME.Location = New System.Drawing.Point(177, 12)
        Me.TextBoxStudentNAME.Name = "TextBoxStudentNAME"
        Me.TextBoxStudentNAME.Size = New System.Drawing.Size(100, 26)
        Me.TextBoxStudentNAME.TabIndex = 5
        '
        'BtnFirstStudent
        '
        Me.BtnFirstStudent.Location = New System.Drawing.Point(26, 275)
        Me.BtnFirstStudent.Name = "BtnFirstStudent"
        Me.BtnFirstStudent.Size = New System.Drawing.Size(142, 47)
        Me.BtnFirstStudent.TabIndex = 6
        Me.BtnFirstStudent.Text = "First Student"
        Me.BtnFirstStudent.UseVisualStyleBackColor = True
        '
        'BtnSecondStudent
        '
        Me.BtnSecondStudent.Location = New System.Drawing.Point(202, 287)
        Me.BtnSecondStudent.Name = "BtnSecondStudent"
        Me.BtnSecondStudent.Size = New System.Drawing.Size(142, 35)
        Me.BtnSecondStudent.TabIndex = 7
        Me.BtnSecondStudent.Text = "Second Student"
        Me.BtnSecondStudent.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(26, 363)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 34)
        Me.BtnClear.TabIndex = 8
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnExit
        '
        Me.BtnExit.Location = New System.Drawing.Point(129, 363)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 34)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'BtnThirdStudent
        '
        Me.BtnThirdStudent.Location = New System.Drawing.Point(422, 281)
        Me.BtnThirdStudent.Name = "BtnThirdStudent"
        Me.BtnThirdStudent.Size = New System.Drawing.Size(147, 35)
        Me.BtnThirdStudent.TabIndex = 12
        Me.BtnThirdStudent.Text = "Third Student"
        Me.BtnThirdStudent.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 559)
        Me.Controls.Add(Me.BtnThirdStudent)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.BtnSecondStudent)
        Me.Controls.Add(Me.BtnFirstStudent)
        Me.Controls.Add(Me.TextBoxStudentNAME)
        Me.Controls.Add(Me.TextBoxCourseName)
        Me.Controls.Add(Me.TextBoxGender)
        Me.Controls.Add(Me.LabelGender)
        Me.Controls.Add(Me.LabelCourseName)
        Me.Controls.Add(Me.LabelStudent)
        Me.Name = "Form1"
        Me.Text = "Student Management System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelStudent As System.Windows.Forms.Label
    Friend WithEvents LabelCourseName As System.Windows.Forms.Label
    Friend WithEvents LabelGender As System.Windows.Forms.Label
    Friend WithEvents TextBoxGender As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCourseName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxStudentNAME As System.Windows.Forms.TextBox
    Friend WithEvents BtnFirstStudent As System.Windows.Forms.Button
    Friend WithEvents BtnSecondStudent As System.Windows.Forms.Button
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnExit As System.Windows.Forms.Button
    Friend WithEvents BtnThirdStudent As System.Windows.Forms.Button

End Class
