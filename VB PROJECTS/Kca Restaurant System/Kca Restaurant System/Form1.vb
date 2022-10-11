Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceTextBox.TextChanged

    End Sub

    Private Sub GroupBox5_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentMethodListBox.SelectedIndexChanged

    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub BtnDisplayReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDisplayReceipt.Click

    End Sub

    Private Sub TxtShowReceipt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtShowReceipt.TextChanged
        TxtShowReceipt.Text = "Dish Served:" & ComboBox1.Text & ControlChars.NewLine & "Drinks:" & DrinksComboBox.Text & ControlChars.NewLine & "Price:" & PriceTextBox.Text & ControlChars.NewLine & "Staff:" & StaffComboBox.Text & ControlChars.NewLine & "Payment Method:" & PaymentMethodListBox.Text
    End Sub
End Class
