Imports Google.Cloud.Firestore
Imports Google.Apis.Auth.OAuth2
Imports Google.Cloud.Firestore.V1
Imports Grpc.Auth
Imports BCrypt.Net


Public Class LoginForm
    'Get firestore credentials from a  downloaded json key 
    Dim jsonPath As String = "D:\Visual Basic\Car Rental\DB Key\safari-drives-firebase-adminsdk-q8tjl-aa9702dbce.json"
    Dim firestoreCredentials As GoogleCredential = GoogleCredential.FromFile(jsonPath)


    Dim firestoreClient As FirestoreClient = New FirestoreClientBuilder() With {
    .ChannelCredentials = firestoreCredentials.ToChannelCredentials()
}.Build()

    'create a firestore database named safari-drives
    Dim firestoreDb As FirestoreDb = FirestoreDb.Create("safari-drives", firestoreClient)



    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' providing a masked password input.
        txtPassword.UseSystemPasswordChar = True

    End Sub

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            Dim adminCollection As CollectionReference = firestoreDb.Collection("Admins")

            Dim username As String = txtUsername.Text
            Dim password As String = txtPassword.Text

            'Query admin username  in firestoreDb
            Dim adminQuery As Query = firestoreDb.Collection("Admins").WhereEqualTo("Username", username)
            Dim adminSnapshot As QuerySnapshot = Await adminQuery.GetSnapshotAsync()
            If txtUsername.Text = "" Then
                MessageBox.Show("Enter Username")
            ElseIf txtpassword.Text = "" Then
                MessageBox.Show("Enter Password")

            ElseIf adminSnapshot.Count > 0 Then
                For Each adminDocument As DocumentSnapshot In adminSnapshot.Documents
                    Dim storedHashedPassword As String = adminDocument.GetValue(Of String)("Password")

                    If BCrypt.Net.BCrypt.Verify(password, storedHashedPassword) Then
                        ' Passwords match

                        Form1.Show()

                        Exit Sub

                    End If

                Next

                ' Incorrect password
                MessageBox.Show("Incorrect password!")
                txtPassword.Text = ""
            Else
                ' Admin does not exist
                MessageBox.Show("Admin does not exist!")
                txtPassword.Clear()
            End If

        Catch ex As Exception
            MessageBox.Show("Failed to connect to database. Check your Internet Connection")
        End Try

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        Dim password As String = txtPassword.Text

        If password.Length < 6 Then
            ' Password does not meet the minimum length requirement
            lblPasswordError.Text = "Password must be at least 6 characters long."
        Else
            ' Password meets the minimum length requirement
            lblPasswordError.Text = ""
        End If
    End Sub



End Class