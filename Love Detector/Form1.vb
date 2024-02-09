Imports System.Diagnostics.Eventing.Reader
Imports System.Security

Public Class Form1

    Private LoveLevls() As String = {"Dysfunctional", "Fake", "Friend zone", "Liking", "Crushing", "Uncondtional commitment", "Sacrifical love"}
    Private loveImages() As Image = {My.Resources.dysfunctional, My.Resources.fake, My.Resources._friend, My.Resources.liking, My.Resources.crushing, My.Resources.uncondtional, My.Resources.sacrificalLove}
    Private Sub btnDetermineStrength_Click(sender As Object, e As EventArgs) Handles btnDetermineStrength.Click

        Dim strp1 As String = txtPerson1.Text.Trim
        Dim strp2 As String = txtPerson2.Text.Trim

        If strp1 = "" OrElse strp2 = "" Then

            MessageBox.Show("Please enter both names for both inputs")
            Return

        End If

        lblPeopleMath.Text = strp1 & "+" & strp2
        lblPeopleMath.Visible = True

        Dim loveIndex As Integer = CalculateloveIndex(strp1, strp2)

        lblMatchStrength.Text = findMatchingText(loveIndex)
        lblMatchStrength.Visible = True

        picLove.Image = findMatchingImage(loveIndex)

    End Sub

    Private Function CalculateloveIndex(str1 As String, str2 As String) As Integer

        str1 = str1.ToLower.Trim
        str2 = str2.ToLower.Trim

        'get ascii value for each character and sum up those values 
        Dim total As Integer = GetStringAsciiSum(str1) + GetStringAsciiSum(str2)
        Return total

    End Function

    Private Function GetStringAsciiSum(str As String) As Integer

        Dim sum As Integer = 0

        'loop through the string and add each character ascii value to sum

        For Each c As Char In str
            sum += Asc(c) 'the ascii value of c 
        Next
        Return sum
    End Function

    Private Function findMatchingText(num As Integer) As String
        'we will return a value from the lovelevels array.
        'we need to put num within range of the values in the array (0 - length -1)

        Dim index As Integer = num Mod LoveLevls.Length
        Return LoveLevls(index)

    End Function

    Private Function findMatchingImage(num As Integer) As Image
        'we will return a value from the lovelevels array.
        'we need to put num within range of the values in the array (0 - length -1)

        Dim index As Integer = num Mod loveImages.Length

        Return loveImages(index)

    End Function

End Class
