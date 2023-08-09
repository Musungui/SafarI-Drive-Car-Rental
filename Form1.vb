Imports Google.Cloud.Firestore
Imports Google.Apis.Auth.OAuth2
Imports Grpc.Core
Imports Google.Cloud.Firestore.V1
Imports Grpc.Auth
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports Google.Cloud.Storage.V1
Imports System.IO
Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button
Imports System.Windows.Forms.VisualStyles
Imports System.Runtime.Serialization
Imports Org.BouncyCastle.Tls

Public Class Form1

    Dim jsonPath As String = "D:\Visual Basic\Car Rental\DB Key\safari-drives-firebase-adminsdk-q8tjl-aa9702dbce.json"
    Dim firestoreCredentials As GoogleCredential = GoogleCredential.FromFile(jsonPath)

    Dim firestoreClient As FirestoreClient = New FirestoreClientBuilder() With {
    .ChannelCredentials = firestoreCredentials.ToChannelCredentials()
}.Build()

    Dim firestoreDb As FirestoreDb = FirestoreDb.Create("safari-drives", firestoreClient)


    Private Sub TabCar_Click(sender As Object, e As EventArgs) Handles TabCar.Click

    End Sub

    'a function created to validate customer details before moving to payment tab
    Private Function ValidateTabCustomer() As Boolean
        Dim rentId As String = txtRentalId.Text
        Dim customerName As String = lblRentIdCustomerName.Text

        ' Check if all fields in Tab Customers are filled
        If Not String.IsNullOrWhiteSpace(rentId) AndAlso Not String.IsNullOrWhiteSpace(customerName) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        If ValidateTabCustomer() Then
            TabControl1.SelectedIndex += 1
        Else
            MessageBox.Show("Please fill in all the rental details.")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtAddAdminPass.UseSystemPasswordChar = True

        Me.WindowState = FormWindowState.Maximized


    End Sub
    '

    '

    Private Sub TabCustomer_Click(sender As Object, e As EventArgs) Handles TabCustomer.Click

    End Sub






    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private imageURL As String = "" ' Global variable to store the image URL
    Private Async Sub BtnAddCar_Click(sender As Object, e As EventArgs) Handles btnAddCar.Click

        Try
            Dim CarsCollection As CollectionReference = firestoreDb.Collection("Cars")
            Dim plateNumber As String = txtCarRegNo.Text.Trim()

            Dim query As Query = CarsCollection.WhereEqualTo("plateNumber", plateNumber)
            Dim existingCars As QuerySnapshot = Await query.GetSnapshotAsync()
            If String.IsNullOrEmpty(imageURL) Then
                ' Check if the image URL is available. If not, show an error message.
                MessageBox.Show("Please upload a car image before adding the car.")
                Exit Sub ' Exit the event to prevent further processing

            ElseIf existingCars.Documents.Count > 0 Then
                MessageBox.Show("The number plate already exists")
            ElseIf txtCarRegNo.Text <> "" And CboBrand.Text <> "" And txtCarModel.Text <> "" _
                And txtRentPricePerDay.Text <> "" And txtColor.Text <> "" And CboCarAvailability.Text <> "" Then

                Dim carData As New Dictionary(Of String, Object)()
                carData("plateNumber") = plateNumber
                carData("brandName") = CboBrand.Text
                carData("modelName") = txtCarModel.Text
                carData("rentPricePerDay") = txtRentPricePerDay.Text
                carData("color") = txtColor.Text
                carData("available") = CboCarAvailability.Text

                'Save the image URL in the carData dictionary
                carData("imageURL") = imageURL

                Dim documentReference As DocumentReference = CarsCollection.Document(plateNumber)
                Await documentReference.SetAsync(carData) ' Use Await here to wait for the database operation to complete

                MessageBox.Show("Car details added successfully")
            Else
                MessageBox.Show("Enter all Fields to add Car")
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database. Check your internet Connection")
        End Try
    End Sub


    Private Sub LblBrand_Click(sender As Object, e As EventArgs) Handles lblBrandText.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboBrand.SelectedIndexChanged

    End Sub

    Private Async Sub btnSearchCar_Click(sender As Object, e As EventArgs) Handles btnSearchCar.Click
        Try
            Dim CarsCollection As CollectionReference = firestoreDb.Collection("Cars")
            Dim plateNumber As String = txtCarRegNo.Text.TrimStart

            Dim query As Query = CarsCollection.WhereEqualTo("plateNumber", plateNumber)
            Dim querySnapshot As QuerySnapshot = Await query.GetSnapshotAsync()
            Dim existingCars As QuerySnapshot = Await query.GetSnapshotAsync()

            If existingCars.Documents.Count > 0 Then
                ' Get the first document from the query result
                Dim carDocument As DocumentSnapshot = querySnapshot.Documents(0)
                Dim carBrand As String = carDocument.GetValue(Of String)("brandName")
                Dim carModel As String = carDocument.GetValue(Of String)("modelName")
                Dim carPrice As String = carDocument.GetValue(Of String)("rentPricePerDay")
                Dim carColor As String = carDocument.GetValue(Of String)("color")
                Dim carAvailability As String = carDocument.GetValue(Of String)("available")
                Dim carImage As String = carDocument.GetValue(Of String)("imageURL")

                ' Display the car details in labels
                CboBrand.Text = carBrand
                txtCarModel.Text = carModel
                txtRentPricePerDay.Text = carPrice
                txtColor.Text = carColor
                CboCarAvailability.Text = carAvailability
                PictureBoxCarImage.ImageLocation = carImage

            ElseIf plateNumber = "" Then
                MessageBox.Show("Enter car Plate number to search")
            Else
                ' Car not found, display an error message or take appropriate action
                MessageBox.Show("Car Details not found.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error in database query: " & ex.Message)
        End Try
    End Sub


    Private Async Sub btnSearchCustomer_Click(sender As Object, e As EventArgs) Handles btnSearchCustomer.Click

        Try

            ' Get references to the Firestore collections
            Dim customersCollection As CollectionReference = firestoreDb.Collection("Customers")
            Dim customerCarChoiceCollection As CollectionReference = firestoreDb.Collection("customerCarChoice")

            ' Retrieve the customer ID from a text box
            Dim rentalId As String = txtRentalId.Text.TrimStart

            Try
                ' Get the customer document reference
                Dim customerDocument As DocumentReference = customersCollection.Document(rentalId)
                Dim customerChoiceDocument As DocumentReference = customerCarChoiceCollection.Document(rentalId)

                ' Retrieve the customer document snapshot
                Dim customerSnapshot As DocumentSnapshot = Await customerDocument.GetSnapshotAsync()
                Dim customerChoiceSnapshot As DocumentSnapshot = Await customerChoiceDocument.GetSnapshotAsync()

                ' Check if the customer document exists
                If customerSnapshot.Exists And customerChoiceSnapshot.Exists Then
                    ' Access the customer details from the document data
                    Dim customerName As String = customerSnapshot.GetValue(Of String)("surname")
                    Dim dLicenseNumber As String = customerSnapshot.GetValue(Of String)("licenseNumber")
                    Dim nationalId As String = customerSnapshot.GetValue(Of String)("nationalId")
                    Dim phoneNumber As String = customerSnapshot.GetValue(Of String)("phoneNumber")

                    Dim plateNumber As String = customerChoiceSnapshot.GetValue(Of String)("plateNumber")
                    Dim modelName As String = customerChoiceSnapshot.GetValue(Of String)("modelName")
                    Dim brandName As String = customerChoiceSnapshot.GetValue(Of String)("brandName")
                    Dim color As String = customerChoiceSnapshot.GetValue(Of String)("color")
                    Dim rentPricePerDay As String = customerChoiceSnapshot.GetValue(Of String)("rentPricePerDay")
                    Dim dateFrom As String = customerChoiceSnapshot.GetValue(Of String)("dateFrom")
                    Dim dateTo As String = customerChoiceSnapshot.GetValue(Of String)("dateTo")

                    ' Display the customer details in labels
                    lblRentIdCustomerName.Text = customerName
                    lblRentCustomerDLicense.Text = dLicenseNumber
                    lblRentCustomerId.Text = nationalId
                    lblRentCustomerPhone.Text = phoneNumber

                    ' Display Chosen car details
                    lblRentCarReg.Text = plateNumber
                    lblRentCarBrand.Text = brandName
                    lblRentCarModel.Text = modelName
                    lblRentCarColor.Text = color
                    lblRentCarPriceADay.Text = rentPricePerDay

                    ' Retrieve the car image URL from the car data
                    Dim queryCar As Query = firestoreDb.Collection("Cars").WhereEqualTo("plateNumber", plateNumber)
                    Dim carSnapshot As QuerySnapshot = Await queryCar.GetSnapshotAsync()

                    If carSnapshot.Documents.Count > 0 Then
                        Dim imageURL As String = carSnapshot.Documents(0).GetValue(Of String)("imageURL")
                        If Not String.IsNullOrEmpty(imageURL) Then
                            PictureBox1.ImageLocation = imageURL
                        End If
                    End If

                    'Display rent dates
                    lblRentDateFrom.Text = dateFrom
                    lblRentDateTo.Text = dateTo
                Else
                    ' Customer not found, display an error message or take appropriate action
                    MessageBox.Show("Rental details not found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Enter Rental  Id to Continue")
            End Try
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database. Check your internet connection.")
        End Try
    End Sub

    Private Sub BtnClearCar_Click(sender As Object, e As EventArgs) Handles btnClearCar.Click

        CboBrand.Text = " "
        txtCarModel.Text = " "
        txtRentPricePerDay.Text = " "
        txtColor.Text = " "
        CboCarAvailability.Text = " "
        txtCarRegNo.Text = " "
        'Clear the PictureBox by setting the Image property to Nothing
        PictureBoxCarImage.Image = Nothing
        OpenFileDialog1.FileName = String.Empty
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtDeleteCar_TextChanged(sender As Object, e As EventArgs) Handles txtDeleteCar.TextChanged

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtRentalId.Clear()
        lblRentIdCustomerName.Text = " "
        lblRentCustomerId.Text = ""
        lblRentCustomerDLicense.Text = ""
        lblRentCustomerPhone.Text = ""
        lblRentCarReg.Text = " "
        lblRentCarBrand.Text = ""
        lblRentCarModel.Text = ""
        lblRentCarColor.Text = ""
        lblRentCarPriceADay.Text = ""
        lblRentDateFrom.Text = ""
        lblRentDateTo.Text = ""
        'Clear the PictureBox by setting the Image property to Nothing
        PictureBox1.Image = Nothing

    End Sub

    Private Sub LblTotalFees_Click(sender As Object, e As EventArgs) Handles lblTotalFees.Click
        Try
            Dim dateFrom As DateTime
            Dim dateTo As DateTime
            Dim pricePerDay As Decimal
            ' Parse the date values from the labels
            If DateTime.TryParseExact(lblRentDateFrom.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dateFrom) AndAlso
               DateTime.TryParseExact(lblRentDateTo.Text, "dd/MM/yyyy", Nothing, Globalization.DateTimeStyles.None, dateTo) AndAlso
                Decimal.TryParse(lblRentCarPriceADay.Text, pricePerDay) Then

                ' Calculate the duration in days
                Dim duration As Integer = CInt((dateTo - dateFrom).TotalDays)

                ' Calculate the total fee
                Dim totalFee As Decimal = duration * pricePerDay

                ' Display the total fee in lblTotal
                lblTotalFees.Text = totalFee.ToString("C") ' the currency format
            Else
                lblTotalFees.Text = "Invalid date or price"
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database. Check your internet Connection")
        End Try
    End Sub

    Private Sub TabPayment_Click(sender As Object, e As EventArgs) Handles TabPayment.Click

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        TabControl1.SelectedIndex -= 1
    End Sub

    Private Sub btnAddAdmin_Click(sender As Object, e As EventArgs) Handles btnAddAdmin.Click
        Try
            Dim adminCollection As CollectionReference = firestoreDb.Collection("Admins")
            Dim username As String = txtAddAdminUser.Text
            Dim password As String = txtAddAdminPass.Text
            Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password)
            If txtAddAdminUser.Text <> "" AndAlso txtAddAdminPass.Text <> "" Then
                Dim adminData As New Dictionary(Of String, Object)() From
            {
                {"Username", username},
                {"Password", hashedPassword}
             }
                If password.Length < 6 Then
                    ' Password does not meet the minimum length requirement
                    lblAdmPasswordError.Text = "Password must be at least 6 characters long."
                Else
                    ' Password meets the minimum length requirement
                    Dim documentReference As DocumentReference = adminCollection.Document(hashedPassword)
                    documentReference.SetAsync(adminData)
                    MessageBox.Show("Admin added successfully!")
                End If

            Else
                MessageBox.Show("Enter Username and Password")
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database. Check your internet Connection")
        End Try


    End Sub



    Private Sub TabAddAdmin_Click(sender As Object, e As EventArgs) Handles TabAddAdmin.Click

    End Sub

    Private Sub txtAddAdminPass_TextChanged(sender As Object, e As EventArgs) Handles txtAddAdminPass.TextChanged
        Dim password As String = txtAddAdminPass.Text

        If password.Length < 6 Then
            ' Password does not meet the minimum length requirement
            lblAdmPasswordError.Text = "Password must be at least 6 characters long."
        Else
            ' Password meets the minimum length requirement
            lblAdmPasswordError.Text = ""
        End If
    End Sub


    Private Sub GroupBoxAddCarDetails_Enter(sender As Object, e As EventArgs) Handles GroupBoxAddCarDetails.Enter

    End Sub

    Private Async Sub btnUploadImage_Click(sender As Object, e As EventArgs) Handles btnUploadImage.Click
        Try
            Dim plateNumber As String = txtCarRegNo.Text.Trim()
            OpenFileDialogImages.InitialDirectory = "C:\"
            OpenFileDialogImages.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif"
            OpenFileDialogImages.Title = "Select an Image"

            ' Display the OpenFileDialog and get the selected file path
            If OpenFileDialogImages.ShowDialog() = DialogResult.OK Then
                Dim imagePath As String = OpenFileDialogImages.FileName

                ' Perform the image upload to Firebase Storage
                Dim bucketName As String = "safari-drives.appspot.com"
                Dim storageClient As StorageClient = StorageClient.Create(firestoreCredentials)
                Using fs As New FileStream(imagePath, FileMode.Open, FileAccess.Read)
                    ' Adjust the path to where you want to store the image in Firebase Storage
                    Dim imageRef = storageClient.UploadObject(bucketName, "Cars/" & plateNumber & ".jpg", "image/jpeg", fs)
                End Using

                ' Generate the public URL for the uploaded image
                imageURL = $"https://firebasestorage.googleapis.com/v0/b/{bucketName}/o/Cars%2F{plateNumber}.jpg?alt=media"

                MessageBox.Show("Car image added successfully!")
            End If

        Catch ex As Exception
            MessageBox.Show("Error uploading image: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUpdateCar_Click(sender As Object, e As EventArgs) Handles btnUpdateCar.Click
        Try
            Dim CarsCollection As CollectionReference = firestoreDb.Collection("Cars")
            Dim plateNumber As String = txtCarRegNo.Text

            Dim carData As New Dictionary(Of String, Object)()

            ' Check if the fields have valid values and update the carData dictionary accordingly
            If Not String.IsNullOrEmpty(plateNumber) Then
                carData("carRegNo") = plateNumber
            Else
                MessageBox.Show("Please enter a car registration number.")
                Exit Sub ' Exit the event if the car registration number is empty
            End If

            If Not String.IsNullOrEmpty(CboBrand.Text) Then
                carData("brandName") = CboBrand.Text
            Else
                MessageBox.Show("Please select a car brand.")
                Exit Sub ' Exit the event if the car brand is not selected
            End If

            If Not String.IsNullOrEmpty(txtCarModel.Text) Then
                carData("modelName") = txtCarModel.Text
            Else
                MessageBox.Show("Please enter a car model.")
                Exit Sub ' Exit the event if the car model is empty
            End If

            If Not String.IsNullOrEmpty(txtRentPricePerDay.Text) Then
                carData("rentPricePerDay") = txtRentPricePerDay.Text
            Else
                MessageBox.Show("Please enter the rent price per day.")
                Exit Sub ' Exit the event if the rent price per day is empty
            End If

            If Not String.IsNullOrEmpty(txtColor.Text) Then
                carData("color") = txtColor.Text
            Else
                MessageBox.Show("Please enter the car color.")
                Exit Sub ' Exit the event if the car color is empty
            End If

            If Not String.IsNullOrEmpty(CboCarAvailability.Text) Then
                carData("available") = CboCarAvailability.Text
            Else
                MessageBox.Show("Please select the car availability.")
                Exit Sub ' Exit the event if the car availability is not selected
            End If

            ' Check if the image URL is available and update it if present
            If Not String.IsNullOrEmpty(PictureBoxCarImage.ImageLocation) Then
                carData("imageURL") = imageURL
            Else
                MessageBox.Show("Please select the car Image for upload.")
                Exit Sub ' Exit the event if the car image is not found
            End If

            ' Update the data in the Firestore database
            Dim documentReference As DocumentReference = CarsCollection.Document(plateNumber)
            documentReference.UpdateAsync(carData) ' update the document

            MessageBox.Show("Data Updated successfully")
        Catch ex As Exception
            MessageBox.Show("Failed to connect to the database. Check your internet Connection")
        End Try
    End Sub


    Private Async Sub BtnDeleteCar_Click(sender As Object, e As EventArgs) Handles btnDeleteCar.Click


        Dim CarsCollection As CollectionReference = firestoreDb.Collection("Cars")
        Dim plateNumber As String = txtDeleteCar.Text

        ' Query to find the car document with the given plate number
        Dim query As Query = firestoreDb.Collection("Cars").WhereEqualTo("plateNumber", plateNumber)
        Dim existingCars As QuerySnapshot = Await query.GetSnapshotAsync()





        If txtDeleteCar.Text = "" Then
            MessageBox.Show("Cannot delete empty car Plate Number")
        ElseIf existingCars.Documents.Count > 0 Then 'And txtDeleteCar.Text <> "" 

            ' Retrieve the car image URL from the car data
            Dim queryCar As Query = firestoreDb.Collection("Cars").WhereEqualTo("plateNumber", plateNumber)
            Dim carSnapshot As QuerySnapshot = Await queryCar.GetSnapshotAsync()

            ' Delete the car document
            Dim carDoc As DocumentSnapshot = existingCars.Documents(0)
            Await carDoc.Reference.DeleteAsync()

            MessageBox.Show("Car data deleted successfully")
            txtDeleteCar.Text = " "
        Else
            MessageBox.Show("No car found with the given plate number")
            txtDeleteCar.Text = " "
        End If

    End Sub

    Private Sub GroupBoxCustomerDetails_Enter(sender As Object, e As EventArgs) Handles GroupBoxCustomerDetails.Enter


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click


        If Not ValidateTabCustomer() Then
            MessageBox.Show("Please fill in the rental details.")
            TabControl1.SelectedIndex -= 1
        ElseIf lblTotalFees.Text = "" Or lblTotalFees.Text = "Invalid date or price" Then
            MessageBox.Show("Total fees label not Clicked or is Invalid")
        ElseIf CboPaymentMethod.Text = "" Then
            MessageBox.Show("Select Payment Method")
        ElseIf CheckBoxConfirmPayment.Checked = False Then
            MessageBox.Show("Confirm Payment")
        Else

            ' Get the customer rental details
            Dim customerName As String = lblRentIdCustomerName.Text
            Dim dLicenseNumber As String = lblRentCustomerDLicense.Text
            Dim nationalId As String = lblRentCustomerId.Text
            Dim phoneNumber As String = lblRentCustomerPhone.Text
            Dim rentalId As String = txtRentalId.Text
            'Car details

            Dim plateNumber As String = lblRentCarReg.Text
            Dim brandName As String = lblRentCarBrand.Text
            Dim modelName As String = lblRentCarModel.Text
            Dim color As String = lblRentCarColor.Text
            Dim rentPricePerDay As String = lblRentCarPriceADay.Text


            'Display rent dates
            Dim dateFrom As String = lblRentDateFrom.Text
            Dim dateTo As String = lblRentDateTo.Text

            Dim totalFee As String = lblTotalFees.Text
            Dim method As String = CboPaymentMethod.Text
            ' Get the image from PictureBox1 
            Dim receiptImage As Image = PictureBox1.Image

            ' Open ReceiptForm and pass the data
            Dim receiptForm As New ReceiptForm(customerName, dLicenseNumber, nationalId, phoneNumber, rentalId, plateNumber, brandName,
              modelName, color, rentPricePerDay, dateFrom, dateTo, totalFee, method, receiptImage)
            receiptForm.Show()

        End If
    End Sub

    Private Sub ComboBoxPaymentMethod_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboPaymentMethod.SelectedIndexChanged

    End Sub

    Private Sub lblRentCustomerId_Click(sender As Object, e As EventArgs) Handles lblRentCustomerId.Click

    End Sub

    Private Sub txtRentalId_TextChanged(sender As Object, e As EventArgs) Handles txtRentalId.TextChanged

    End Sub

    Private Sub lblRentCarReg_Click(sender As Object, e As EventArgs) Handles lblRentCarReg.Click

    End Sub

    Private Sub lblRentCarModel_Click(sender As Object, e As EventArgs) Handles lblRentCarModel.Click

    End Sub

    Private Sub txtCarModel_TextChanged(sender As Object, e As EventArgs) Handles txtCarModel.TextChanged

    End Sub
End Class
