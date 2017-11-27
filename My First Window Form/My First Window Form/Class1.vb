Public Class testClass
    Private userNameValue As String
    Public Property userName() As String
        Get
            Return userNameValue ' Gets the property value.
        End Get
        Set(ByVal Value As String)
            userNameValue = Value ' Sets the property value.
        End Set
    End Property
    Public Sub Capitalize()
        userNameValue = UCase(userNameValue) ' Capitalize the value of the property.
    End Sub
End Class
Public Class derivedTestClass
    Inherits testClass
    Private userAgeValue As Integer
    Public Property userAge() As Integer
        Get
            Return userAgeValue ' Gets the property value.
        End Get
        Set(ByVal dValue As Integer)
            userAgeValue = dValue ' Sets the property value.
        End Set
    End Property
End Class