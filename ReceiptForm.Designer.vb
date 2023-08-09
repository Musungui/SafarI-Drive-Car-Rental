<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReceiptForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblCompany = New Label()
        lblPobox = New Label()
        lblEmail = New Label()
        lblReceipt = New Label()
        lblDate = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblNames = New Label()
        lblID = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label12 = New Label()
        Label14 = New Label()
        GroupBoxCustomerInfo = New GroupBox()
        lblReceiptRentId = New Label()
        Label16 = New Label()
        lblReceiptDlicense = New Label()
        lblReceiptPhone = New Label()
        lblReceiptCustomerId = New Label()
        lblReceiptName = New Label()
        GroupBoxCarInfo = New GroupBox()
        lblPrice = New Label()
        lblColor = New Label()
        lblModel = New Label()
        lblBrand = New Label()
        lblPlateNo = New Label()
        GroupBoxDates = New GroupBox()
        lblTo = New Label()
        lblFrom = New Label()
        GroupBoxPayment = New GroupBox()
        lblMethod = New Label()
        lblTotal = New Label()
        Label11 = New Label()
        Panel1 = New Panel()
        PictureBoxCarReceipt = New PictureBox()
        btnDownloadReceipt = New Button()
        lblReceiptNo = New Label()
        lblCurrentDateTime = New Label()
        GroupBoxCustomerInfo.SuspendLayout()
        GroupBoxCarInfo.SuspendLayout()
        GroupBoxDates.SuspendLayout()
        GroupBoxPayment.SuspendLayout()
        CType(PictureBoxCarReceipt, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(297, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 38)
        Label1.TabIndex = 0
        Label1.Text = "CAR RENTAL RECEIPT"
        ' 
        ' lblCompany
        ' 
        lblCompany.AutoSize = True
        lblCompany.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblCompany.Location = New Point(12, 94)
        lblCompany.Name = "lblCompany"
        lblCompany.Size = New Size(231, 20)
        lblCompany.TabIndex = 1
        lblCompany.Text = "Safari Drives car rental company"
        ' 
        ' lblPobox
        ' 
        lblPobox.AutoSize = True
        lblPobox.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblPobox.Location = New Point(12, 158)
        lblPobox.Name = "lblPobox"
        lblPobox.Size = New Size(96, 20)
        lblPobox.TabIndex = 2
        lblPobox.Text = "P.O.Box 12111"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblEmail.Location = New Point(12, 126)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(193, 20)
        lblEmail.TabIndex = 3
        lblEmail.Text = "safaridrivecars@gmail.com"
        ' 
        ' lblReceipt
        ' 
        lblReceipt.AutoSize = True
        lblReceipt.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblReceipt.Location = New Point(578, 94)
        lblReceipt.Name = "lblReceipt"
        lblReceipt.Size = New Size(88, 20)
        lblReceipt.TabIndex = 4
        lblReceipt.Text = "Receipt No:"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblDate.Location = New Point(577, 141)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(45, 20)
        lblDate.TabIndex = 5
        lblDate.Text = "Date:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(31, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 20)
        Label2.TabIndex = 6
        Label2.Text = "Phone:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(31, 213)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 7
        Label3.Text = "D. Licence No:"
        ' 
        ' lblNames
        ' 
        lblNames.AutoSize = True
        lblNames.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblNames.Location = New Point(34, 52)
        lblNames.Name = "lblNames"
        lblNames.Size = New Size(54, 20)
        lblNames.TabIndex = 8
        lblNames.Text = "Name:"
        ' 
        ' lblID
        ' 
        lblID.AutoSize = True
        lblID.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblID.Location = New Point(34, 102)
        lblID.Name = "lblID"
        lblID.Size = New Size(51, 20)
        lblID.TabIndex = 9
        lblID.Text = "Id No:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(58, 76)
        Label4.Name = "Label4"
        Label4.Size = New Size(54, 20)
        Label4.TabIndex = 13
        Label4.Text = "Brand:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(58, 36)
        Label5.Name = "Label5"
        Label5.Size = New Size(64, 20)
        Label5.TabIndex = 12
        Label5.Text = "Reg No:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(55, 176)
        Label6.Name = "Label6"
        Label6.Size = New Size(51, 20)
        Label6.TabIndex = 11
        Label6.Text = "Color:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(55, 123)
        Label7.Name = "Label7"
        Label7.Size = New Size(57, 20)
        Label7.TabIndex = 10
        Label7.Text = "Model:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(57, 223)
        Label8.Name = "Label8"
        Label8.Size = New Size(115, 20)
        Label8.TabIndex = 14
        Label8.Text = "Rent Price/Day:"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(23, 85)
        Label9.Name = "Label9"
        Label9.Size = New Size(29, 20)
        Label9.TabIndex = 17
        Label9.Text = "To:"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(23, 38)
        Label10.Name = "Label10"
        Label10.Size = New Size(49, 20)
        Label10.TabIndex = 16
        Label10.Text = "From:"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(12, 38)
        Label12.Name = "Label12"
        Label12.Size = New Size(68, 20)
        Label12.TabIndex = 18
        Label12.Text = "Amount:"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(155, 948)
        Label14.Name = "Label14"
        Label14.Size = New Size(177, 20)
        Label14.TabIndex = 20
        Label14.Text = "Authorization Signature:"
        ' 
        ' GroupBoxCustomerInfo
        ' 
        GroupBoxCustomerInfo.Controls.Add(lblReceiptRentId)
        GroupBoxCustomerInfo.Controls.Add(Label16)
        GroupBoxCustomerInfo.Controls.Add(lblReceiptDlicense)
        GroupBoxCustomerInfo.Controls.Add(lblReceiptPhone)
        GroupBoxCustomerInfo.Controls.Add(lblReceiptCustomerId)
        GroupBoxCustomerInfo.Controls.Add(lblReceiptName)
        GroupBoxCustomerInfo.Controls.Add(lblID)
        GroupBoxCustomerInfo.Controls.Add(lblNames)
        GroupBoxCustomerInfo.Controls.Add(Label3)
        GroupBoxCustomerInfo.Controls.Add(Label2)
        GroupBoxCustomerInfo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBoxCustomerInfo.Location = New Point(566, 185)
        GroupBoxCustomerInfo.Name = "GroupBoxCustomerInfo"
        GroupBoxCustomerInfo.Size = New Size(369, 307)
        GroupBoxCustomerInfo.TabIndex = 22
        GroupBoxCustomerInfo.TabStop = False
        GroupBoxCustomerInfo.Text = "Customer Details"
        ' 
        ' lblReceiptRentId
        ' 
        lblReceiptRentId.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblReceiptRentId.Location = New Point(106, 256)
        lblReceiptRentId.Name = "lblReceiptRentId"
        lblReceiptRentId.Size = New Size(189, 28)
        lblReceiptRentId.TabIndex = 43
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(31, 256)
        Label16.Name = "Label16"
        Label16.Size = New Size(73, 20)
        Label16.TabIndex = 42
        Label16.Text = "Rental Id:"
        ' 
        ' lblReceiptDlicense
        ' 
        lblReceiptDlicense.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblReceiptDlicense.Location = New Point(133, 213)
        lblReceiptDlicense.Name = "lblReceiptDlicense"
        lblReceiptDlicense.Size = New Size(189, 28)
        lblReceiptDlicense.TabIndex = 41
        ' 
        ' lblReceiptPhone
        ' 
        lblReceiptPhone.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblReceiptPhone.Location = New Point(86, 161)
        lblReceiptPhone.Name = "lblReceiptPhone"
        lblReceiptPhone.Size = New Size(189, 28)
        lblReceiptPhone.TabIndex = 40
        ' 
        ' lblReceiptCustomerId
        ' 
        lblReceiptCustomerId.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblReceiptCustomerId.Location = New Point(86, 102)
        lblReceiptCustomerId.Name = "lblReceiptCustomerId"
        lblReceiptCustomerId.Size = New Size(189, 31)
        lblReceiptCustomerId.TabIndex = 39
        ' 
        ' lblReceiptName
        ' 
        lblReceiptName.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblReceiptName.Location = New Point(94, 48)
        lblReceiptName.Name = "lblReceiptName"
        lblReceiptName.Size = New Size(189, 30)
        lblReceiptName.TabIndex = 38
        ' 
        ' GroupBoxCarInfo
        ' 
        GroupBoxCarInfo.Controls.Add(lblPrice)
        GroupBoxCarInfo.Controls.Add(lblColor)
        GroupBoxCarInfo.Controls.Add(lblModel)
        GroupBoxCarInfo.Controls.Add(lblBrand)
        GroupBoxCarInfo.Controls.Add(lblPlateNo)
        GroupBoxCarInfo.Controls.Add(Label8)
        GroupBoxCarInfo.Controls.Add(Label4)
        GroupBoxCarInfo.Controls.Add(Label5)
        GroupBoxCarInfo.Controls.Add(Label6)
        GroupBoxCarInfo.Controls.Add(Label7)
        GroupBoxCarInfo.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBoxCarInfo.Location = New Point(12, 209)
        GroupBoxCarInfo.Name = "GroupBoxCarInfo"
        GroupBoxCarInfo.Size = New Size(452, 262)
        GroupBoxCarInfo.TabIndex = 23
        GroupBoxCarInfo.TabStop = False
        GroupBoxCarInfo.Text = "Car Details"
        ' 
        ' lblPrice
        ' 
        lblPrice.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblPrice.Location = New Point(168, 223)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(189, 31)
        lblPrice.TabIndex = 48
        ' 
        ' lblColor
        ' 
        lblColor.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblColor.Location = New Point(112, 176)
        lblColor.Name = "lblColor"
        lblColor.Size = New Size(189, 31)
        lblColor.TabIndex = 47
        ' 
        ' lblModel
        ' 
        lblModel.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblModel.Location = New Point(118, 123)
        lblModel.Name = "lblModel"
        lblModel.Size = New Size(189, 31)
        lblModel.TabIndex = 46
        ' 
        ' lblBrand
        ' 
        lblBrand.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblBrand.Location = New Point(118, 76)
        lblBrand.Name = "lblBrand"
        lblBrand.Size = New Size(189, 31)
        lblBrand.TabIndex = 45
        ' 
        ' lblPlateNo
        ' 
        lblPlateNo.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblPlateNo.Location = New Point(119, 36)
        lblPlateNo.Name = "lblPlateNo"
        lblPlateNo.Size = New Size(189, 31)
        lblPlateNo.TabIndex = 44
        ' 
        ' GroupBoxDates
        ' 
        GroupBoxDates.Controls.Add(lblTo)
        GroupBoxDates.Controls.Add(lblFrom)
        GroupBoxDates.Controls.Add(Label9)
        GroupBoxDates.Controls.Add(Label10)
        GroupBoxDates.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBoxDates.Location = New Point(12, 494)
        GroupBoxDates.Name = "GroupBoxDates"
        GroupBoxDates.Size = New Size(280, 138)
        GroupBoxDates.TabIndex = 24
        GroupBoxDates.TabStop = False
        GroupBoxDates.Text = "Duration"
        ' 
        ' lblTo
        ' 
        lblTo.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblTo.Location = New Point(55, 88)
        lblTo.Name = "lblTo"
        lblTo.Size = New Size(189, 31)
        lblTo.TabIndex = 50
        ' 
        ' lblFrom
        ' 
        lblFrom.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblFrom.Location = New Point(78, 38)
        lblFrom.Name = "lblFrom"
        lblFrom.Size = New Size(189, 31)
        lblFrom.TabIndex = 49
        ' 
        ' GroupBoxPayment
        ' 
        GroupBoxPayment.Controls.Add(lblMethod)
        GroupBoxPayment.Controls.Add(lblTotal)
        GroupBoxPayment.Controls.Add(Label11)
        GroupBoxPayment.Controls.Add(Label12)
        GroupBoxPayment.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        GroupBoxPayment.Location = New Point(566, 508)
        GroupBoxPayment.Name = "GroupBoxPayment"
        GroupBoxPayment.Size = New Size(343, 139)
        GroupBoxPayment.TabIndex = 25
        GroupBoxPayment.TabStop = False
        GroupBoxPayment.Text = "Payment"
        ' 
        ' lblMethod
        ' 
        lblMethod.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblMethod.Location = New Point(86, 86)
        lblMethod.Name = "lblMethod"
        lblMethod.Size = New Size(189, 31)
        lblMethod.TabIndex = 50
        ' 
        ' lblTotal
        ' 
        lblTotal.Font = New Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblTotal.Location = New Point(86, 37)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(189, 31)
        lblTotal.TabIndex = 49
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(15, 86)
        Label11.Name = "Label11"
        Label11.Size = New Size(67, 20)
        Label11.TabIndex = 19
        Label11.Text = "Method:"
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Location = New Point(337, 929)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 69)
        Panel1.TabIndex = 33
        ' 
        ' PictureBoxCarReceipt
        ' 
        PictureBoxCarReceipt.Location = New Point(233, 653)
        PictureBoxCarReceipt.Name = "PictureBoxCarReceipt"
        PictureBoxCarReceipt.Size = New Size(362, 244)
        PictureBoxCarReceipt.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxCarReceipt.TabIndex = 34
        PictureBoxCarReceipt.TabStop = False
        ' 
        ' btnDownloadReceipt
        ' 
        btnDownloadReceipt.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnDownloadReceipt.Location = New Point(776, 929)
        btnDownloadReceipt.Name = "btnDownloadReceipt"
        btnDownloadReceipt.Size = New Size(159, 52)
        btnDownloadReceipt.TabIndex = 36
        btnDownloadReceipt.Text = "Download"
        btnDownloadReceipt.UseVisualStyleBackColor = True
        ' 
        ' lblReceiptNo
        ' 
        lblReceiptNo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblReceiptNo.Location = New Point(672, 87)
        lblReceiptNo.Name = "lblReceiptNo"
        lblReceiptNo.Size = New Size(189, 35)
        lblReceiptNo.TabIndex = 37
        ' 
        ' lblCurrentDateTime
        ' 
        lblCurrentDateTime.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lblCurrentDateTime.Location = New Point(628, 141)
        lblCurrentDateTime.Name = "lblCurrentDateTime"
        lblCurrentDateTime.Size = New Size(289, 30)
        lblCurrentDateTime.TabIndex = 44
        ' 
        ' ReceiptForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        ClientSize = New Size(952, 1055)
        Controls.Add(lblCurrentDateTime)
        Controls.Add(lblReceiptNo)
        Controls.Add(btnDownloadReceipt)
        Controls.Add(PictureBoxCarReceipt)
        Controls.Add(Panel1)
        Controls.Add(GroupBoxPayment)
        Controls.Add(GroupBoxDates)
        Controls.Add(GroupBoxCarInfo)
        Controls.Add(GroupBoxCustomerInfo)
        Controls.Add(Label14)
        Controls.Add(lblDate)
        Controls.Add(lblReceipt)
        Controls.Add(lblEmail)
        Controls.Add(lblPobox)
        Controls.Add(lblCompany)
        Controls.Add(Label1)
        Name = "ReceiptForm"
        Text = "ReceiptForm"
        GroupBoxCustomerInfo.ResumeLayout(False)
        GroupBoxCustomerInfo.PerformLayout()
        GroupBoxCarInfo.ResumeLayout(False)
        GroupBoxCarInfo.PerformLayout()
        GroupBoxDates.ResumeLayout(False)
        GroupBoxDates.PerformLayout()
        GroupBoxPayment.ResumeLayout(False)
        GroupBoxPayment.PerformLayout()
        CType(PictureBoxCarReceipt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCompany As Label
    Friend WithEvents lblPobox As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblReceipt As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblNames As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents GroupBoxCustomerInfo As GroupBox
    Friend WithEvents GroupBoxCarInfo As GroupBox
    Friend WithEvents GroupBoxDates As GroupBox
    Friend WithEvents GroupBoxPayment As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBoxCarReceipt As PictureBox
    Friend WithEvents btnDownloadReceipt As Button
    Friend WithEvents lblReceiptName As Label
    Friend WithEvents lblReceiptNo As Label
    Friend WithEvents lblReceiptPhone As Label
    Friend WithEvents lblReceiptCustomerId As Label
    Friend WithEvents lblReceiptDlicense As Label
    Friend WithEvents lblReceiptRentId As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblBrand As Label
    Friend WithEvents lblPlateNo As Label
    Friend WithEvents lblFrom As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents lblMethod As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblCurrentDateTime As Label
End Class
