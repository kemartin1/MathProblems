
Partial Class SummaryResults
    Inherits System.Web.UI.Page

    Private Sub SummaryResults_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblCorrect.Text = Session("Correct").ToString
        lblIncorrect.Text = Session("Incorrect").ToString
    End Sub
    Protected Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Response.Redirect("MathProblem.aspx")
    End Sub
End Class
