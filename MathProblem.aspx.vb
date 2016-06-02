Imports Microsoft.VisualBasic
Partial Class _Default
    Inherits System.Web.UI.Page
    Private Sub Display_Random_Numbers()
        Dim objRandom As New random
        Dim intNumber1, intNumber2 As Integer

        'Generate two random numbers between 1 and 10
        intNumber1 = objRandom.Next(1, 11)       'will generate a random number betwee 1 and 10
        intNumber2 = objRandom.Next(1, 11)       'will generate a random number betwee 1 and 10

        'assign the correct label to intNumber1
        lblNumber1.Text = intNumber1.ToString
        'assign the correct label to intNumber2
        lblNumber2.Text = intNumber2.ToString



    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        UnobtrusiveValidationMode = UnobtrusiveValidationMode.None

        If Me.IsPostBack = False Then
            ddlOperation.Items.Add("+")
            ddlOperation.Items.Add("*")

            Display_Random_Numbers()
        End If


    End Sub


    Protected Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If Me.IsValid = True Then
            Dim intCorrectAnswer As Integer

            If (ddlOperation.SelectedIndex = 0) Then
                intCorrectAnswer = Integer.Parse(lblNumber1.Text) + Integer.Parse(lblNumber2.Text)

            Else
                intCorrectAnswer = Integer.Parse(lblNumber1.Text) * Integer.Parse(lblNumber2.Text)
            End If

            If (txtAnswer.Text = intCorrectAnswer) Then
                Session("Correct") += 1
                lblMessage.Text = "Your answer is correct"
            Else
                Session("Incorrect") += 1
                lblMessage.Text = "Your answer is incorrect, it should be " + intCorrectAnswer.ToString
            End If
        End If


    End Sub
    Protected Sub btnNextProblem_Click(sender As Object, e As EventArgs) Handles btnNextProblem.Click
        lblMessage.Text = String.Empty
        Display_Random_Numbers()
    End Sub
End Class
