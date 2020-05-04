Public Class calculator
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub a_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(a.Text) Then
            Exit Sub
        End If
        If IsNumeric(a.Text) And IsNumeric(b.Text) Then
        Else
            Exit Sub
        End If

        If DropDownList1.SelectedValue = "1" Then
            result.Text = Integer.Parse(a.Text) + Integer.Parse(b.Text)
        ElseIf DropDownList1.SelectedValue = "2" Then
            result.Text = Integer.Parse(a.Text) - Integer.Parse(b.Text)
        ElseIf DropDownList1.SelectedValue = "3" Then
            result.Text = Integer.Parse(a.Text) * Integer.Parse(b.Text)
        ElseIf DropDownList1.SelectedValue = "4" Then
            result.Text = Integer.Parse(a.Text) / Integer.Parse(b.Text)
        End If

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged

    End Sub
End Class