Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.IO

Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class ReceiptForm
    ' Properties to hold customer details
    Public Property CustomerName As String
    Public Property DrivingLicense As String
    Public Property IdNo As String
    Public Property Phone As String
    Public Property RentalId As String
    Public Property PlateNo As String
    Public Property Brand As String
    Public Property Model As String
    Public Property Color As String
    Public Property Price As String
    Public Property DateFrom As String
    Public Property DateTo As String
    Public Property Amount As String
    Public Property Method As String
    ' Public Property ReceiptImage As Image
    Public Property ReceiptImage As System.Drawing.Image




    ' Constructor with parameters to receive customer details
    Public Sub New(ByVal customerName As String, ByVal dLicenseNumber As String, ByVal nationalId As String, ByVal phoneNumber As String,
                   ByVal rentalId As String, ByVal plateNumber As String, ByVal brandName As String, ByVal modelName As String, ByVal color As String,
                   ByVal rentPricePerDay As String, ByVal dateFrom As String, ByVal dateTo As String, ByVal totalFee As String, ByVal method As String,
                   ByVal receiptImage As System.Drawing.Image)
        InitializeComponent()
        Me.CustomerName = customerName
        Me.DrivingLicense = dLicenseNumber
        Me.IdNo = nationalId
        Me.Phone = phoneNumber
        Me.RentalId = rentalId
        Me.PlateNo = plateNumber
        Me.Brand = brandName
        Me.Model = modelName
        Me.Color = color
        Me.Price = rentPricePerDay
        Me.DateFrom = dateFrom
        Me.DateTo = dateTo
        Me.Amount = totalFee
        Me.Method = method
        Me.ReceiptImage = receiptImage
        ' PictureBoxCarReceipt.Image = receiptImage

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
    End Sub

    Private Sub GroupBoxDates_Enter(sender As Object, e As EventArgs) Handles GroupBoxDates.Enter

    End Sub



    Private Sub ReceiptForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the current date and time to the label
        lblCurrentDateTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        ' Generate a random receipt number between 1000 and 9999
        Dim random As New Random()
        Dim receiptNumber As Integer = random.Next(1000, 100000)

        ' Display the random receipt number on the label
        lblReceiptNo.Text = receiptNumber.ToString()


        ' Use the customer details to populate the appropriate  labels on the ReceiptForm
        lblReceiptName.Text = CustomerName
        lblReceiptDlicense.Text = DrivingLicense
        lblReceiptPhone.Text = Phone
        lblReceiptCustomerId.Text = IdNo
        lblReceiptRentId.Text = RentalId

        lblPlateNo.Text = PlateNo
        lblBrand.Text = Brand
        lblModel.Text = Model
        lblColor.Text = Color
        lblPrice.Text = Price

        lblFrom.Text = DateFrom
        lblTo.Text = DateTo

        lblTotal.Text = Amount
        lblMethod.Text = Method
        ' Use the image to display it in the PictureBox control
        If ReceiptImage IsNot Nothing Then

            PictureBoxCarReceipt.Image = ReceiptImage
        End If


    End Sub

    Private Sub btnDownloadReceipt_Click(sender As Object, e As EventArgs) Handles btnDownloadReceipt.Click
        Try
            ' Create a SaveFileDialog to allow the user to choose the location and name of the receipt file
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf|All Files (*.*)|*.*"
            saveFileDialog.DefaultExt = "pdf"

            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Dim receiptFilePath As String = saveFileDialog.FileName

                ' Generate and save the receipt as a PDF
                Using document As New iTextSharp.text.Document()
                    Using writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(receiptFilePath, FileMode.Create))
                        document.Open()

                        ' Add content to the PDF document
                        Dim fontContent As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA, 12)
                        Dim fontContentHead As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)
                        Dim fontInfo As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.TIMES_BOLDITALIC, 12)
                        Dim fontTitle As iTextSharp.text.Font = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 18)


                        ' Add title
                        Dim titleParagraph As New iTextSharp.text.Paragraph("CAR RENTAL RECEIPT", fontTitle)
                        titleParagraph.Alignment = Element.ALIGN_CENTER
                        document.Add(titleParagraph)
                        document.Add(New iTextSharp.text.Paragraph(" "))
                        Dim companyName As New iTextSharp.text.Paragraph("Safari Drives car rental company", fontInfo)
                        companyName.Alignment = Element.ALIGN_LEFT
                        document.Add(companyName)
                        Dim Email As New iTextSharp.text.Paragraph("safaridrivecars@gmail.com", fontInfo)
                        Email.Alignment = Element.ALIGN_LEFT
                        document.Add(Email)
                        Dim address As New iTextSharp.text.Paragraph("P.O.Box 12111", fontInfo)
                        address.Alignment = Element.ALIGN_LEFT
                        document.Add(address)
                        Dim place As New iTextSharp.text.Paragraph("Kajiado.", fontInfo)
                        place.Alignment = Element.ALIGN_LEFT
                        document.Add(place)
                        document.Add(New iTextSharp.text.Paragraph(" "))

                        ' Create a table to organize the receipt details
                        Dim table As New PdfPTable(2)
                        table.WidthPercentage = 100
                        table.DefaultCell.Border = Rectangle.NO_BORDER

                        ' Add receipt details
                        AddRowToTable(table, "Receipt Number:", lblReceiptNo.Text, fontContentHead)
                        AddRowToTable(table, "", "                   ", fontContent)


                        ' Add customer information
                        AddRowToTable(table, "CUSTOMER DETAILS", "         ", fontContentHead)
                        AddRowToTable(table, "Customer Name:", lblReceiptName.Text, fontContent)
                        AddRowToTable(table, "Driving License:", lblReceiptDlicense.Text, fontContent)
                        AddRowToTable(table, "Phone:", lblReceiptPhone.Text, fontContent)
                        AddRowToTable(table, "Customer ID:", lblReceiptCustomerId.Text, fontContent)
                        AddRowToTable(table, "", "                   ", fontContent)

                        ' Add Car details

                        AddRowToTable(table, "CAR DETAILS", "         ", fontContentHead)
                        AddRowToTable(table, "Plate No:", lblPlateNo.Text, fontContent)
                        AddRowToTable(table, "Brand:", lblBrand.Text, fontContent)
                        AddRowToTable(table, "Model:", lblModel.Text, fontContent)
                        AddRowToTable(table, "Color:", lblColor.Text, fontContent)
                        AddRowToTable(table, "Price:", lblPrice.Text, fontContent)
                        AddRowToTable(table, "", "                   ", fontContent)

                        ' Add dates
                        AddRowToTable(table, "DURATION", "         ", fontContentHead)
                        AddRowToTable(table, "From: ", lblFrom.Text, fontContent)
                        AddRowToTable(table, "To:", lblTo.Text, fontContent)
                        AddRowToTable(table, "", "                   ", fontContent)

                        ' Add payment details
                        AddRowToTable(table, "PAYMENT", "         ", fontContentHead)
                        AddRowToTable(table, "Payment Method:", lblMethod.Text, fontContent)
                        AddRowToTable(table, "Total Amount:", lblTotal.Text, fontContent)
                        AddRowToTable(table, "Rental ID:", lblReceiptRentId.Text, fontContent)

                        AddRowToTable(table, "", "                   ", fontContent)

                        AddRowToTable(table, "Time of Service:", lblCurrentDateTime.Text, fontContent)

                        AddRowToTable(table, "", "                   ", fontContent)
                        AddRowToTable(table, "", "                   ", fontContent)
                        AddRowToTable(table, "Authorization Sign:", "____________________", fontContent)
                        AddRowToTable(table, "", "                   ", fontContent)
                        AddRowToTable(table, "", "                   ", fontContent)
                        AddRowToTable(table, "NB: Only valid with an official Car rental company Stamp ", "", fontContentHead)
                        AddRowToTable(table, "Keep this receipt safely as it will  be required when returning the Car", " ", fontInfo)


                        ' Add Table
                        document.Add(table)
                        'Close document
                        document.Close()
                        MessageBox.Show("Receipt  Saved Successfully")

                        Me.Close()
                    End Using
                End Using
            End If

        Catch ex As Exception
            MessageBox.Show("There was an error downloading Receipt")
        End Try


    End Sub

    ' Helper method to add a row to the table
    Private Sub AddRowToTable(ByRef table As PdfPTable, ByVal label As String, ByVal value As String, ByVal font As iTextSharp.text.Font)
        Dim cellLabel As New PdfPCell(New Phrase(label, font))
        cellLabel.Border = Rectangle.NO_BORDER
        cellLabel.HorizontalAlignment = Element.ALIGN_LEFT

        Dim cellValue As New PdfPCell(New Phrase(value, font))
        cellValue.Border = Rectangle.NO_BORDER
        cellValue.HorizontalAlignment = Element.ALIGN_JUSTIFIED

        table.AddCell(cellLabel)
        table.AddCell(cellValue)
    End Sub

    Private Sub lblColor_Click(sender As Object, e As EventArgs) Handles lblColor.Click

    End Sub
End Class
