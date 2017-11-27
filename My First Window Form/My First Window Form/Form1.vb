Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Beep()
        MsgBox("Button Clicked should produce beep sound")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim testUser As New testClass
        testUser.userName = "Afzal,Ansari"
        testUser.Capitalize()
        MsgBox("The original username is= " & testUser.userName)
        testUser.userName = "Mohammad,Afzal"
        MsgBox("The new username is= " & testUser.userName)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim dtestuser As New derivedTestClass
        dtestuser.userName = " Karim, Walji"
        dtestuser.Capitalize()
        MsgBox("The original username is= " & dtestuser.userName)
        dtestuser.userName = "SuperSaiyan,Karim"
        MsgBox("The new username is= " & dtestuser.userName)
        dtestuser.userAge = 35
        MsgBox("The Age of new user is=" & dtestuser.userAge)





    End Sub
End Class
