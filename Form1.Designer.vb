<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        TabControl1 = New TabControl()
        TabCustomer = New TabPage()
        PictureBox1 = New PictureBox()
        btnClearAll = New Button()
        GroupBoxCustomerDetails = New GroupBox()
        lblRentCustomerPhone = New Label()
        lblRentCustomerDLicense = New Label()
        lblRentCustomerId = New Label()
        lblRentIdCustomerName = New Label()
        LblCustomerPhone = New Label()
        LblDLicense = New Label()
        LblCustomerId = New Label()
        LblCustomerName = New Label()
        GroupBoxCarDetails = New GroupBox()
        lblRentCarPriceADay = New Label()
        Label19 = New Label()
        lblRentCarColor = New Label()
        Label17 = New Label()
        lblRentCarModel = New Label()
        Label15 = New Label()
        lblRentCarBrand = New Label()
        Label13 = New Label()
        lblRentCarReg = New Label()
        Label11 = New Label()
        GroupBoxRentDates = New GroupBox()
        lblRentDateTo = New Label()
        lblRentDateFrom = New Label()
        Label22 = New Label()
        Label21 = New Label()
        btnSearchCustomer = New Button()
        txtRentalId = New TextBox()
        Label10 = New Label()
        BtnNext = New Button()
        TabPayment = New TabPage()
        btnBack = New Button()
        CboPaymentMethod = New ComboBox()
        CheckBoxConfirmPayment = New CheckBox()
        Label2 = New Label()
        btnComplete = New Button()
        lblTotalFees = New Label()
        Label9 = New Label()
        Label8 = New Label()
        TabCar = New TabPage()
        PictureBoxCarImage = New PictureBox()
        btnClearCar = New Button()
        btnUpdateCar = New Button()
        btnSearchCar = New Button()
        btnExit = New Button()
        GroupBoxDeleteCar = New GroupBox()
        txtDeleteCar = New TextBox()
        Label4 = New Label()
        GroupBoxAddCarDetails = New GroupBox()
        btnUploadImage = New Button()
        CboCarAvailability = New ComboBox()
        CboBrand = New ComboBox()
        Label1 = New Label()
        lblColorText = New Label()
        lblRentPerDayText = New Label()
        txtColor = New TextBox()
        txtRentPricePerDay = New TextBox()
        lblModelText = New Label()
        lblBrandText = New Label()
        txtCarModel = New TextBox()
        txtCarRegNo = New TextBox()
        lblRegNoText = New Label()
        Label3 = New Label()
        btnDeleteCar = New Button()
        btnAddCar = New Button()
        TabAddAdmin = New TabPage()
        lblAdminInfo = New Label()
        lblAdmPasswordError = New Label()
        txtAddAdminPass = New TextBox()
        txtAddAdminUser = New TextBox()
        lblAddAdminPas = New Label()
        lblAddAdminUser = New Label()
        btnAddAdmin = New Button()
        ImageList1 = New ImageList(components)
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialog2 = New OpenFileDialog()
        OpenFileDialogImages = New OpenFileDialog()
        TabControl1.SuspendLayout()
        TabCustomer.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxCustomerDetails.SuspendLayout()
        GroupBoxCarDetails.SuspendLayout()
        GroupBoxRentDates.SuspendLayout()
        TabPayment.SuspendLayout()
        TabCar.SuspendLayout()
        CType(PictureBoxCarImage, ComponentModel.ISupportInitialize).BeginInit()
        GroupBoxDeleteCar.SuspendLayout()
        GroupBoxAddCarDetails.SuspendLayout()
        TabAddAdmin.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabControl1
        ' 
        TabControl1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        TabControl1.Controls.Add(TabCustomer)
        TabControl1.Controls.Add(TabPayment)
        TabControl1.Controls.Add(TabCar)
        TabControl1.Controls.Add(TabAddAdmin)
        TabControl1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        TabControl1.ImageList = ImageList1
        TabControl1.Location = New Point(1, -3)
        TabControl1.Name = "TabControl1"
        TabControl1.Padding = New Point(93, 4)
        TabControl1.RightToLeft = RightToLeft.No
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(1711, 1057)
        TabControl1.TabIndex = 1
        ' 
        ' TabCustomer
        ' 
        TabCustomer.BackColor = Color.Teal
        TabCustomer.Controls.Add(PictureBox1)
        TabCustomer.Controls.Add(btnClearAll)
        TabCustomer.Controls.Add(GroupBoxCustomerDetails)
        TabCustomer.Controls.Add(GroupBoxCarDetails)
        TabCustomer.Controls.Add(GroupBoxRentDates)
        TabCustomer.Controls.Add(btnSearchCustomer)
        TabCustomer.Controls.Add(txtRentalId)
        TabCustomer.Controls.Add(Label10)
        TabCustomer.Controls.Add(BtnNext)
        TabCustomer.ImageIndex = 0
        TabCustomer.Location = New Point(4, 39)
        TabCustomer.Name = "TabCustomer"
        TabCustomer.Padding = New Padding(3)
        TabCustomer.Size = New Size(1703, 1014)
        TabCustomer.TabIndex = 0
        TabCustomer.Text = "Search Customer"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.InitialImage = Nothing
        PictureBox1.Location = New Point(761, 596)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(577, 411)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 35
        PictureBox1.TabStop = False
        PictureBox1.WaitOnLoad = True
        ' 
        ' btnClearAll
        ' 
        btnClearAll.BackColor = Color.LightSlateGray
        btnClearAll.ForeColor = Color.White
        btnClearAll.Location = New Point(784, 40)
        btnClearAll.Name = "btnClearAll"
        btnClearAll.Size = New Size(138, 41)
        btnClearAll.TabIndex = 34
        btnClearAll.Text = "Clear All"
        btnClearAll.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxCustomerDetails
        ' 
        GroupBoxCustomerDetails.BackColor = Color.Teal
        GroupBoxCustomerDetails.BackgroundImageLayout = ImageLayout.None
        GroupBoxCustomerDetails.Controls.Add(lblRentCustomerPhone)
        GroupBoxCustomerDetails.Controls.Add(lblRentCustomerDLicense)
        GroupBoxCustomerDetails.Controls.Add(lblRentCustomerId)
        GroupBoxCustomerDetails.Controls.Add(lblRentIdCustomerName)
        GroupBoxCustomerDetails.Controls.Add(LblCustomerPhone)
        GroupBoxCustomerDetails.Controls.Add(LblDLicense)
        GroupBoxCustomerDetails.Controls.Add(LblCustomerId)
        GroupBoxCustomerDetails.Controls.Add(LblCustomerName)
        GroupBoxCustomerDetails.Cursor = Cursors.No
        GroupBoxCustomerDetails.Location = New Point(11, 123)
        GroupBoxCustomerDetails.Name = "GroupBoxCustomerDetails"
        GroupBoxCustomerDetails.Size = New Size(1467, 179)
        GroupBoxCustomerDetails.TabIndex = 33
        GroupBoxCustomerDetails.TabStop = False
        GroupBoxCustomerDetails.Text = "Customer Details:"
        ' 
        ' lblRentCustomerPhone
        ' 
        lblRentCustomerPhone.BackColor = Color.Gainsboro
        lblRentCustomerPhone.BorderStyle = BorderStyle.Fixed3D
        lblRentCustomerPhone.Location = New Point(1171, 77)
        lblRentCustomerPhone.Name = "lblRentCustomerPhone"
        lblRentCustomerPhone.Size = New Size(183, 35)
        lblRentCustomerPhone.TabIndex = 15
        ' 
        ' lblRentCustomerDLicense
        ' 
        lblRentCustomerDLicense.BackColor = Color.Gainsboro
        lblRentCustomerDLicense.BorderStyle = BorderStyle.Fixed3D
        lblRentCustomerDLicense.Location = New Point(793, 77)
        lblRentCustomerDLicense.Name = "lblRentCustomerDLicense"
        lblRentCustomerDLicense.Size = New Size(204, 35)
        lblRentCustomerDLicense.TabIndex = 14
        ' 
        ' lblRentCustomerId
        ' 
        lblRentCustomerId.BackColor = Color.Gainsboro
        lblRentCustomerId.BorderStyle = BorderStyle.Fixed3D
        lblRentCustomerId.Location = New Point(438, 77)
        lblRentCustomerId.Name = "lblRentCustomerId"
        lblRentCustomerId.Size = New Size(183, 35)
        lblRentCustomerId.TabIndex = 13
        ' 
        ' lblRentIdCustomerName
        ' 
        lblRentIdCustomerName.BackColor = Color.Gainsboro
        lblRentIdCustomerName.BorderStyle = BorderStyle.Fixed3D
        lblRentIdCustomerName.Location = New Point(17, 77)
        lblRentIdCustomerName.Name = "lblRentIdCustomerName"
        lblRentIdCustomerName.Size = New Size(272, 35)
        lblRentIdCustomerName.TabIndex = 12
        ' 
        ' LblCustomerPhone
        ' 
        LblCustomerPhone.AutoSize = True
        LblCustomerPhone.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblCustomerPhone.Location = New Point(1194, 45)
        LblCustomerPhone.Name = "LblCustomerPhone"
        LblCustomerPhone.Size = New Size(109, 28)
        LblCustomerPhone.TabIndex = 7
        LblCustomerPhone.Text = "Phone No:"
        ' 
        ' LblDLicense
        ' 
        LblDLicense.AutoSize = True
        LblDLicense.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblDLicense.Location = New Point(780, 45)
        LblDLicense.Name = "LblDLicense"
        LblDLicense.Size = New Size(188, 28)
        LblDLicense.TabIndex = 5
        LblDLicense.Text = "Driving License No:"
        ' 
        ' LblCustomerId
        ' 
        LblCustomerId.AutoSize = True
        LblCustomerId.BackColor = Color.Transparent
        LblCustomerId.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblCustomerId.Location = New Point(438, 45)
        LblCustomerId.Name = "LblCustomerId"
        LblCustomerId.Size = New Size(117, 28)
        LblCustomerId.TabIndex = 2
        LblCustomerId.Text = "Id Number:"
        ' 
        ' LblCustomerName
        ' 
        LblCustomerName.AutoSize = True
        LblCustomerName.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        LblCustomerName.Location = New Point(17, 45)
        LblCustomerName.Name = "LblCustomerName"
        LblCustomerName.Size = New Size(71, 28)
        LblCustomerName.TabIndex = 0
        LblCustomerName.Text = "Name:"
        ' 
        ' GroupBoxCarDetails
        ' 
        GroupBoxCarDetails.BackColor = Color.Teal
        GroupBoxCarDetails.Controls.Add(lblRentCarPriceADay)
        GroupBoxCarDetails.Controls.Add(Label19)
        GroupBoxCarDetails.Controls.Add(lblRentCarColor)
        GroupBoxCarDetails.Controls.Add(Label17)
        GroupBoxCarDetails.Controls.Add(lblRentCarModel)
        GroupBoxCarDetails.Controls.Add(Label15)
        GroupBoxCarDetails.Controls.Add(lblRentCarBrand)
        GroupBoxCarDetails.Controls.Add(Label13)
        GroupBoxCarDetails.Controls.Add(lblRentCarReg)
        GroupBoxCarDetails.Controls.Add(Label11)
        GroupBoxCarDetails.Location = New Point(11, 347)
        GroupBoxCarDetails.Name = "GroupBoxCarDetails"
        GroupBoxCarDetails.Size = New Size(1460, 208)
        GroupBoxCarDetails.TabIndex = 32
        GroupBoxCarDetails.TabStop = False
        GroupBoxCarDetails.Text = "Car Details:"
        ' 
        ' lblRentCarPriceADay
        ' 
        lblRentCarPriceADay.BackColor = Color.Gainsboro
        lblRentCarPriceADay.BorderStyle = BorderStyle.Fixed3D
        lblRentCarPriceADay.Location = New Point(1197, 96)
        lblRentCarPriceADay.Name = "lblRentCarPriceADay"
        lblRentCarPriceADay.Size = New Size(158, 35)
        lblRentCarPriceADay.TabIndex = 25
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(1197, 65)
        Label19.Name = "Label19"
        Label19.Size = New Size(150, 28)
        Label19.TabIndex = 24
        Label19.Text = "Rent Price/Day:"
        ' 
        ' lblRentCarColor
        ' 
        lblRentCarColor.BackColor = Color.Gainsboro
        lblRentCarColor.BorderStyle = BorderStyle.Fixed3D
        lblRentCarColor.Location = New Point(888, 96)
        lblRentCarColor.Name = "lblRentCarColor"
        lblRentCarColor.Size = New Size(159, 35)
        lblRentCarColor.TabIndex = 23
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(888, 65)
        Label17.Name = "Label17"
        Label17.Size = New Size(66, 28)
        Label17.TabIndex = 22
        Label17.Text = "Color:"
        ' 
        ' lblRentCarModel
        ' 
        lblRentCarModel.BackColor = Color.Gainsboro
        lblRentCarModel.BorderStyle = BorderStyle.Fixed3D
        lblRentCarModel.Location = New Point(567, 96)
        lblRentCarModel.Name = "lblRentCarModel"
        lblRentCarModel.Size = New Size(160, 35)
        lblRentCarModel.TabIndex = 21
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(567, 65)
        Label15.Name = "Label15"
        Label15.Size = New Size(75, 28)
        Label15.TabIndex = 20
        Label15.Text = "Model:"
        ' 
        ' lblRentCarBrand
        ' 
        lblRentCarBrand.BackColor = Color.Gainsboro
        lblRentCarBrand.BorderStyle = BorderStyle.Fixed3D
        lblRentCarBrand.Location = New Point(297, 96)
        lblRentCarBrand.Name = "lblRentCarBrand"
        lblRentCarBrand.Size = New Size(144, 35)
        lblRentCarBrand.TabIndex = 19
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.BackColor = Color.Transparent
        Label13.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(297, 65)
        Label13.Name = "Label13"
        Label13.Size = New Size(70, 28)
        Label13.TabIndex = 18
        Label13.Text = "Brand:"
        ' 
        ' lblRentCarReg
        ' 
        lblRentCarReg.BackColor = Color.Gainsboro
        lblRentCarReg.BorderStyle = BorderStyle.Fixed3D
        lblRentCarReg.Location = New Point(27, 96)
        lblRentCarReg.Name = "lblRentCarReg"
        lblRentCarReg.Size = New Size(138, 35)
        lblRentCarReg.TabIndex = 17
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(29, 65)
        Label11.Name = "Label11"
        Label11.Size = New Size(84, 28)
        Label11.TabIndex = 16
        Label11.Text = "Reg No:"
        ' 
        ' GroupBoxRentDates
        ' 
        GroupBoxRentDates.Controls.Add(lblRentDateTo)
        GroupBoxRentDates.Controls.Add(lblRentDateFrom)
        GroupBoxRentDates.Controls.Add(Label22)
        GroupBoxRentDates.Controls.Add(Label21)
        GroupBoxRentDates.Location = New Point(18, 694)
        GroupBoxRentDates.Name = "GroupBoxRentDates"
        GroupBoxRentDates.Size = New Size(631, 147)
        GroupBoxRentDates.TabIndex = 31
        GroupBoxRentDates.TabStop = False
        GroupBoxRentDates.Text = "Rent Dates:"
        ' 
        ' lblRentDateTo
        ' 
        lblRentDateTo.BackColor = Color.Gainsboro
        lblRentDateTo.BorderStyle = BorderStyle.Fixed3D
        lblRentDateTo.Location = New Point(360, 71)
        lblRentDateTo.Name = "lblRentDateTo"
        lblRentDateTo.Size = New Size(166, 35)
        lblRentDateTo.TabIndex = 30
        ' 
        ' lblRentDateFrom
        ' 
        lblRentDateFrom.BackColor = Color.Gainsboro
        lblRentDateFrom.BorderStyle = BorderStyle.Fixed3D
        lblRentDateFrom.Location = New Point(6, 71)
        lblRentDateFrom.Name = "lblRentDateFrom"
        lblRentDateFrom.Size = New Size(166, 35)
        lblRentDateFrom.TabIndex = 28
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label22.Location = New Point(386, 43)
        Label22.Name = "Label22"
        Label22.Size = New Size(38, 28)
        Label22.TabIndex = 27
        Label22.Text = "To:"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label21.Location = New Point(34, 43)
        Label21.Name = "Label21"
        Label21.Size = New Size(64, 28)
        Label21.TabIndex = 26
        Label21.Text = "From:"
        ' 
        ' btnSearchCustomer
        ' 
        btnSearchCustomer.BackColor = SystemColors.ActiveCaptionText
        btnSearchCustomer.ForeColor = Color.Transparent
        btnSearchCustomer.Location = New Point(430, 35)
        btnSearchCustomer.Name = "btnSearchCustomer"
        btnSearchCustomer.Size = New Size(202, 46)
        btnSearchCustomer.TabIndex = 11
        btnSearchCustomer.Text = "Search Customer"
        btnSearchCustomer.UseVisualStyleBackColor = False
        ' 
        ' txtRentalId
        ' 
        txtRentalId.BorderStyle = BorderStyle.FixedSingle
        txtRentalId.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtRentalId.Location = New Point(167, 40)
        txtRentalId.Multiline = True
        txtRentalId.Name = "txtRentalId"
        txtRentalId.Size = New Size(192, 38)
        txtRentalId.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(11, 47)
        Label10.Name = "Label10"
        Label10.Size = New Size(150, 28)
        Label10.TabIndex = 9
        Label10.Text = "Enter Rental Id:"
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = Color.LightSlateGray
        BtnNext.ForeColor = Color.White
        BtnNext.Location = New Point(1517, 886)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(123, 45)
        BtnNext.TabIndex = 8
        BtnNext.Text = "Next >>"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' TabPayment
        ' 
        TabPayment.BackColor = Color.Teal
        TabPayment.Controls.Add(btnBack)
        TabPayment.Controls.Add(CboPaymentMethod)
        TabPayment.Controls.Add(CheckBoxConfirmPayment)
        TabPayment.Controls.Add(Label2)
        TabPayment.Controls.Add(btnComplete)
        TabPayment.Controls.Add(lblTotalFees)
        TabPayment.Controls.Add(Label9)
        TabPayment.Controls.Add(Label8)
        TabPayment.ImageIndex = 2
        TabPayment.Location = New Point(4, 39)
        TabPayment.Name = "TabPayment"
        TabPayment.Size = New Size(1703, 1014)
        TabPayment.TabIndex = 2
        TabPayment.Text = "Payment"
        ' 
        ' btnBack
        ' 
        btnBack.BackColor = Color.LightSlateGray
        btnBack.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnBack.Location = New Point(484, 505)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(131, 50)
        btnBack.TabIndex = 26
        btnBack.Text = "<< Back"
        btnBack.UseVisualStyleBackColor = False
        ' 
        ' CboPaymentMethod
        ' 
        CboPaymentMethod.FormattingEnabled = True
        CboPaymentMethod.Items.AddRange(New Object() {"Cash", "Mpesa"})
        CboPaymentMethod.Location = New Point(694, 209)
        CboPaymentMethod.Name = "CboPaymentMethod"
        CboPaymentMethod.Size = New Size(152, 36)
        CboPaymentMethod.TabIndex = 25
        ' 
        ' CheckBoxConfirmPayment
        ' 
        CheckBoxConfirmPayment.AutoSize = True
        CheckBoxConfirmPayment.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        CheckBoxConfirmPayment.Location = New Point(694, 297)
        CheckBoxConfirmPayment.Name = "CheckBoxConfirmPayment"
        CheckBoxConfirmPayment.Size = New Size(72, 32)
        CheckBoxConfirmPayment.TabIndex = 24
        CheckBoxConfirmPayment.Text = "Paid"
        CheckBoxConfirmPayment.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(496, 205)
        Label2.Name = "Label2"
        Label2.Size = New Size(174, 28)
        Label2.TabIndex = 23
        Label2.Text = "Payment Method:"
        ' 
        ' btnComplete
        ' 
        btnComplete.BackColor = Color.LightSlateGray
        btnComplete.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnComplete.ForeColor = Color.Black
        btnComplete.Location = New Point(996, 504)
        btnComplete.Name = "btnComplete"
        btnComplete.Size = New Size(136, 51)
        btnComplete.TabIndex = 22
        btnComplete.Text = "Complete"
        btnComplete.UseVisualStyleBackColor = False
        ' 
        ' lblTotalFees
        ' 
        lblTotalFees.BackColor = Color.Gainsboro
        lblTotalFees.BorderStyle = BorderStyle.Fixed3D
        lblTotalFees.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        lblTotalFees.Location = New Point(685, 101)
        lblTotalFees.Name = "lblTotalFees"
        lblTotalFees.Size = New Size(250, 45)
        lblTotalFees.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(495, 291)
        Label9.Name = "Label9"
        Label9.Size = New Size(175, 28)
        Label9.TabIndex = 16
        Label9.Text = "Confirm Payment:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label8.Location = New Point(496, 101)
        Label8.Name = "Label8"
        Label8.Size = New Size(183, 28)
        Label8.TabIndex = 14
        Label8.Text = "Total Renting Fees:"
        ' 
        ' TabCar
        ' 
        TabCar.BackColor = Color.Teal
        TabCar.Controls.Add(PictureBoxCarImage)
        TabCar.Controls.Add(btnClearCar)
        TabCar.Controls.Add(btnUpdateCar)
        TabCar.Controls.Add(btnSearchCar)
        TabCar.Controls.Add(btnExit)
        TabCar.Controls.Add(GroupBoxDeleteCar)
        TabCar.Controls.Add(GroupBoxAddCarDetails)
        TabCar.Controls.Add(Label3)
        TabCar.Controls.Add(btnDeleteCar)
        TabCar.Controls.Add(btnAddCar)
        TabCar.ImageIndex = 1
        TabCar.Location = New Point(4, 39)
        TabCar.Name = "TabCar"
        TabCar.Padding = New Padding(3)
        TabCar.Size = New Size(1703, 1014)
        TabCar.TabIndex = 1
        TabCar.Text = "Add Car"
        ' 
        ' PictureBoxCarImage
        ' 
        PictureBoxCarImage.BackColor = Color.Transparent
        PictureBoxCarImage.InitialImage = Nothing
        PictureBoxCarImage.Location = New Point(1153, 82)
        PictureBoxCarImage.Name = "PictureBoxCarImage"
        PictureBoxCarImage.Size = New Size(554, 486)
        PictureBoxCarImage.SizeMode = PictureBoxSizeMode.Zoom
        PictureBoxCarImage.TabIndex = 26
        PictureBoxCarImage.TabStop = False
        PictureBoxCarImage.WaitOnLoad = True
        ' 
        ' btnClearCar
        ' 
        btnClearCar.BackColor = Color.LightSlateGray
        btnClearCar.Location = New Point(1180, 653)
        btnClearCar.Name = "btnClearCar"
        btnClearCar.Size = New Size(105, 39)
        btnClearCar.TabIndex = 24
        btnClearCar.Text = "Clear All"
        btnClearCar.UseVisualStyleBackColor = False
        ' 
        ' btnUpdateCar
        ' 
        btnUpdateCar.BackColor = Color.LightSlateGray
        btnUpdateCar.Location = New Point(914, 653)
        btnUpdateCar.Name = "btnUpdateCar"
        btnUpdateCar.Size = New Size(100, 39)
        btnUpdateCar.TabIndex = 23
        btnUpdateCar.Text = "Update"
        btnUpdateCar.UseVisualStyleBackColor = False
        ' 
        ' btnSearchCar
        ' 
        btnSearchCar.BackColor = Color.LightSlateGray
        btnSearchCar.Location = New Point(371, 653)
        btnSearchCar.Name = "btnSearchCar"
        btnSearchCar.Size = New Size(103, 39)
        btnSearchCar.TabIndex = 22
        btnSearchCar.Text = "Search "
        btnSearchCar.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.LightSlateGray
        btnExit.Location = New Point(1587, 891)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(109, 47)
        btnExit.TabIndex = 21
        btnExit.Text = "Exit "
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' GroupBoxDeleteCar
        ' 
        GroupBoxDeleteCar.Controls.Add(txtDeleteCar)
        GroupBoxDeleteCar.Controls.Add(Label4)
        GroupBoxDeleteCar.Location = New Point(466, 757)
        GroupBoxDeleteCar.Name = "GroupBoxDeleteCar"
        GroupBoxDeleteCar.Size = New Size(589, 93)
        GroupBoxDeleteCar.TabIndex = 0
        GroupBoxDeleteCar.TabStop = False
        ' 
        ' txtDeleteCar
        ' 
        txtDeleteCar.BorderStyle = BorderStyle.FixedSingle
        txtDeleteCar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtDeleteCar.Location = New Point(283, 33)
        txtDeleteCar.Multiline = True
        txtDeleteCar.Name = "txtDeleteCar"
        txtDeleteCar.Size = New Size(213, 42)
        txtDeleteCar.TabIndex = 22
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(18, 35)
        Label4.Name = "Label4"
        Label4.Size = New Size(260, 28)
        Label4.TabIndex = 21
        Label4.Text = "Enter Car Reg No to delete:"
        ' 
        ' GroupBoxAddCarDetails
        ' 
        GroupBoxAddCarDetails.Controls.Add(btnUploadImage)
        GroupBoxAddCarDetails.Controls.Add(CboCarAvailability)
        GroupBoxAddCarDetails.Controls.Add(CboBrand)
        GroupBoxAddCarDetails.Controls.Add(Label1)
        GroupBoxAddCarDetails.Controls.Add(lblColorText)
        GroupBoxAddCarDetails.Controls.Add(lblRentPerDayText)
        GroupBoxAddCarDetails.Controls.Add(txtColor)
        GroupBoxAddCarDetails.Controls.Add(txtRentPricePerDay)
        GroupBoxAddCarDetails.Controls.Add(lblModelText)
        GroupBoxAddCarDetails.Controls.Add(lblBrandText)
        GroupBoxAddCarDetails.Controls.Add(txtCarModel)
        GroupBoxAddCarDetails.Controls.Add(txtCarRegNo)
        GroupBoxAddCarDetails.Controls.Add(lblRegNoText)
        GroupBoxAddCarDetails.Location = New Point(29, 82)
        GroupBoxAddCarDetails.Name = "GroupBoxAddCarDetails"
        GroupBoxAddCarDetails.Size = New Size(1118, 486)
        GroupBoxAddCarDetails.TabIndex = 20
        GroupBoxAddCarDetails.TabStop = False
        GroupBoxAddCarDetails.Text = "Add Car Details:"
        ' 
        ' btnUploadImage
        ' 
        btnUploadImage.BackColor = Color.MintCream
        btnUploadImage.Location = New Point(37, 359)
        btnUploadImage.Name = "btnUploadImage"
        btnUploadImage.Size = New Size(187, 40)
        btnUploadImage.TabIndex = 25
        btnUploadImage.Text = "Upload Car Image"
        btnUploadImage.UseVisualStyleBackColor = False
        ' 
        ' CboCarAvailability
        ' 
        CboCarAvailability.FormattingEnabled = True
        CboCarAvailability.Items.AddRange(New Object() {"Yes", "No"})
        CboCarAvailability.Location = New Point(816, 235)
        CboCarAvailability.Name = "CboCarAvailability"
        CboCarAvailability.Size = New Size(157, 36)
        CboCarAvailability.TabIndex = 19
        ' 
        ' CboBrand
        ' 
        CboBrand.FormattingEnabled = True
        CboBrand.Items.AddRange(New Object() {"Audi", "BMW", "Ford", "Honda", "Jeep", "Landrover", "Lexus", "Mazda", "Mercedes-Benz", "Nissan", "Toyota", "Subaru", "Volkswagen"})
        CboBrand.Location = New Point(422, 123)
        CboBrand.Name = "CboBrand"
        CboBrand.Size = New Size(157, 36)
        CboBrand.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(816, 192)
        Label1.Name = "Label1"
        Label1.Size = New Size(98, 28)
        Label1.TabIndex = 12
        Label1.Text = "Available:"
        ' 
        ' lblColorText
        ' 
        lblColorText.AutoSize = True
        lblColorText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblColorText.Location = New Point(425, 192)
        lblColorText.Name = "lblColorText"
        lblColorText.Size = New Size(66, 28)
        lblColorText.TabIndex = 11
        lblColorText.Text = "Color:"
        ' 
        ' lblRentPerDayText
        ' 
        lblRentPerDayText.AutoSize = True
        lblRentPerDayText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRentPerDayText.Location = New Point(37, 192)
        lblRentPerDayText.Name = "lblRentPerDayText"
        lblRentPerDayText.Size = New Size(150, 28)
        lblRentPerDayText.TabIndex = 10
        lblRentPerDayText.Text = "Rent Price/Day:"
        ' 
        ' txtColor
        ' 
        txtColor.BorderStyle = BorderStyle.FixedSingle
        txtColor.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtColor.Location = New Point(425, 235)
        txtColor.Multiline = True
        txtColor.Name = "txtColor"
        txtColor.Size = New Size(184, 36)
        txtColor.TabIndex = 8
        ' 
        ' txtRentPricePerDay
        ' 
        txtRentPricePerDay.BorderStyle = BorderStyle.FixedSingle
        txtRentPricePerDay.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtRentPricePerDay.Location = New Point(37, 235)
        txtRentPricePerDay.Multiline = True
        txtRentPricePerDay.Name = "txtRentPricePerDay"
        txtRentPricePerDay.Size = New Size(172, 36)
        txtRentPricePerDay.TabIndex = 7
        ' 
        ' lblModelText
        ' 
        lblModelText.AutoSize = True
        lblModelText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblModelText.Location = New Point(854, 80)
        lblModelText.Name = "lblModelText"
        lblModelText.Size = New Size(75, 28)
        lblModelText.TabIndex = 6
        lblModelText.Text = "Model:"
        ' 
        ' lblBrandText
        ' 
        lblBrandText.AutoSize = True
        lblBrandText.BackColor = Color.Transparent
        lblBrandText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblBrandText.Location = New Point(437, 80)
        lblBrandText.Name = "lblBrandText"
        lblBrandText.Size = New Size(70, 28)
        lblBrandText.TabIndex = 5
        lblBrandText.Text = "Brand:"
        ' 
        ' txtCarModel
        ' 
        txtCarModel.BorderStyle = BorderStyle.FixedSingle
        txtCarModel.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCarModel.Location = New Point(816, 123)
        txtCarModel.Multiline = True
        txtCarModel.Name = "txtCarModel"
        txtCarModel.Size = New Size(169, 36)
        txtCarModel.TabIndex = 3
        ' 
        ' txtCarRegNo
        ' 
        txtCarRegNo.BorderStyle = BorderStyle.FixedSingle
        txtCarRegNo.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtCarRegNo.Location = New Point(37, 123)
        txtCarRegNo.Multiline = True
        txtCarRegNo.Name = "txtCarRegNo"
        txtCarRegNo.Size = New Size(172, 36)
        txtCarRegNo.TabIndex = 2
        ' 
        ' lblRegNoText
        ' 
        lblRegNoText.AutoSize = True
        lblRegNoText.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRegNoText.Location = New Point(37, 80)
        lblRegNoText.Name = "lblRegNoText"
        lblRegNoText.Size = New Size(84, 28)
        lblRegNoText.TabIndex = 1
        lblRegNoText.Text = "Reg No:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(32, 29)
        Label3.Name = "Label3"
        Label3.Size = New Size(213, 26)
        Label3.TabIndex = 19
        Label3.Text = "Enter all fields below"
        ' 
        ' btnDeleteCar
        ' 
        btnDeleteCar.BackColor = Color.SlateGray
        btnDeleteCar.Location = New Point(737, 892)
        btnDeleteCar.Name = "btnDeleteCar"
        btnDeleteCar.Size = New Size(113, 39)
        btnDeleteCar.TabIndex = 15
        btnDeleteCar.Text = "Delete"
        btnDeleteCar.UseVisualStyleBackColor = False
        ' 
        ' btnAddCar
        ' 
        btnAddCar.BackColor = Color.LightSlateGray
        btnAddCar.Location = New Point(633, 653)
        btnAddCar.Name = "btnAddCar"
        btnAddCar.Size = New Size(111, 39)
        btnAddCar.TabIndex = 13
        btnAddCar.Text = "Add"
        btnAddCar.UseVisualStyleBackColor = False
        ' 
        ' TabAddAdmin
        ' 
        TabAddAdmin.BackColor = Color.Teal
        TabAddAdmin.Controls.Add(lblAdminInfo)
        TabAddAdmin.Controls.Add(lblAdmPasswordError)
        TabAddAdmin.Controls.Add(txtAddAdminPass)
        TabAddAdmin.Controls.Add(txtAddAdminUser)
        TabAddAdmin.Controls.Add(lblAddAdminPas)
        TabAddAdmin.Controls.Add(lblAddAdminUser)
        TabAddAdmin.Controls.Add(btnAddAdmin)
        TabAddAdmin.ImageIndex = 3
        TabAddAdmin.Location = New Point(4, 39)
        TabAddAdmin.Name = "TabAddAdmin"
        TabAddAdmin.Size = New Size(1703, 1014)
        TabAddAdmin.TabIndex = 3
        TabAddAdmin.Text = "Add Admin"
        ' 
        ' lblAdminInfo
        ' 
        lblAdminInfo.AutoSize = True
        lblAdminInfo.Font = New Font("Times New Roman", 13.8F, FontStyle.Italic, GraphicsUnit.Point)
        lblAdminInfo.Location = New Point(250, 61)
        lblAdminInfo.Name = "lblAdminInfo"
        lblAdminInfo.Size = New Size(340, 26)
        lblAdminInfo.TabIndex = 13
        lblAdminInfo.Text = "Enter details below to add admin :"
        ' 
        ' lblAdmPasswordError
        ' 
        lblAdmPasswordError.AutoSize = True
        lblAdmPasswordError.ForeColor = Color.Transparent
        lblAdmPasswordError.Location = New Point(718, 203)
        lblAdmPasswordError.Name = "lblAdmPasswordError"
        lblAdmPasswordError.Size = New Size(0, 28)
        lblAdmPasswordError.TabIndex = 12
        ' 
        ' txtAddAdminPass
        ' 
        txtAddAdminPass.Location = New Point(350, 196)
        txtAddAdminPass.Name = "txtAddAdminPass"
        txtAddAdminPass.Size = New Size(310, 34)
        txtAddAdminPass.TabIndex = 11
        ' 
        ' txtAddAdminUser
        ' 
        txtAddAdminUser.Location = New Point(350, 125)
        txtAddAdminUser.Name = "txtAddAdminUser"
        txtAddAdminUser.Size = New Size(310, 34)
        txtAddAdminUser.TabIndex = 10
        ' 
        ' lblAddAdminPas
        ' 
        lblAddAdminPas.AutoSize = True
        lblAddAdminPas.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAddAdminPas.ForeColor = Color.Transparent
        lblAddAdminPas.Location = New Point(245, 196)
        lblAddAdminPas.Name = "lblAddAdminPas"
        lblAddAdminPas.Size = New Size(102, 28)
        lblAddAdminPas.TabIndex = 9
        lblAddAdminPas.Text = "Password:"
        ' 
        ' lblAddAdminUser
        ' 
        lblAddAdminUser.AutoSize = True
        lblAddAdminUser.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblAddAdminUser.ForeColor = Color.Transparent
        lblAddAdminUser.Location = New Point(235, 125)
        lblAddAdminUser.Name = "lblAddAdminUser"
        lblAddAdminUser.Size = New Size(109, 28)
        lblAddAdminUser.TabIndex = 8
        lblAddAdminUser.Text = "Username:"
        ' 
        ' btnAddAdmin
        ' 
        btnAddAdmin.BackColor = Color.Black
        btnAddAdmin.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddAdmin.ForeColor = Color.Transparent
        btnAddAdmin.Location = New Point(401, 317)
        btnAddAdmin.Name = "btnAddAdmin"
        btnAddAdmin.Size = New Size(162, 47)
        btnAddAdmin.TabIndex = 7
        btnAddAdmin.Text = "Add Admin"
        btnAddAdmin.UseVisualStyleBackColor = False
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "Custom-Icon-Design-Pretty-Office-8-User-blue.256.png")
        ImageList1.Images.SetKeyName(1, "Fatcow-Farm-Fresh-Car.32.png")
        ImageList1.Images.SetKeyName(2, "Aha-Soft-Business-Toolbar-Payment.ico")
        ImageList1.Images.SetKeyName(3, "Aha-Soft-Desktop-Device-Admin.48.png")
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' OpenFileDialog2
        ' 
        OpenFileDialog2.FileName = "OpenFileDialog2"
        ' 
        ' OpenFileDialogImages
        ' 
        OpenFileDialogImages.FileName = "OpenFileDialog1"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Black
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1711, 1055)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Home Page"
        WindowState = FormWindowState.Maximized
        TabControl1.ResumeLayout(False)
        TabCustomer.ResumeLayout(False)
        TabCustomer.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxCustomerDetails.ResumeLayout(False)
        GroupBoxCustomerDetails.PerformLayout()
        GroupBoxCarDetails.ResumeLayout(False)
        GroupBoxCarDetails.PerformLayout()
        GroupBoxRentDates.ResumeLayout(False)
        GroupBoxRentDates.PerformLayout()
        TabPayment.ResumeLayout(False)
        TabPayment.PerformLayout()
        TabCar.ResumeLayout(False)
        TabCar.PerformLayout()
        CType(PictureBoxCarImage, ComponentModel.ISupportInitialize).EndInit()
        GroupBoxDeleteCar.ResumeLayout(False)
        GroupBoxDeleteCar.PerformLayout()
        GroupBoxAddCarDetails.ResumeLayout(False)
        GroupBoxAddCarDetails.PerformLayout()
        TabAddAdmin.ResumeLayout(False)
        TabAddAdmin.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabCustomer As TabPage
    Friend WithEvents TabPayment As TabPage
    Friend WithEvents LblCustomerName As Label
    Friend WithEvents LblDLicense As Label
    Friend WithEvents LblCustomerId As Label
    Friend WithEvents LblCustomerPhone As Label
    Friend WithEvents BtnNext As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblTotalFees As Label
    Friend WithEvents btnComplete As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btnSearchCustomer As Button
    Friend WithEvents txtRentalId As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblRentCustomerPhone As Label
    Friend WithEvents lblRentCustomerDLicense As Label
    Friend WithEvents lblRentCustomerId As Label
    Friend WithEvents lblRentIdCustomerName As Label
    Friend WithEvents lblRentCarBrand As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblRentCarReg As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblRentDateFrom As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents lblRentCarPriceADay As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblRentCarColor As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblRentCarModel As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBoxRentDates As GroupBox
    Friend WithEvents lblRentDateTo As Label
    Friend WithEvents GroupBoxCustomerDetails As GroupBox
    Friend WithEvents GroupBoxCarDetails As GroupBox
    Friend WithEvents CboPaymentMethod As ComboBox
    Friend WithEvents CheckBoxConfirmPayment As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClearAll As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents TabAddAdmin As TabPage
    Friend WithEvents btnAddAdmin As Button
    Friend WithEvents lblAddAdminUser As Label
    Friend WithEvents txtAddAdminUser As TextBox
    Friend WithEvents lblAddAdminPas As Label
    Friend WithEvents txtAddAdminPass As TextBox
    Friend WithEvents lblAdmPasswordError As Label
    Friend WithEvents lblAdminInfo As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabCar As TabPage
    Friend WithEvents btnClearCar As Button
    Friend WithEvents btnUpdateCar As Button
    Friend WithEvents btnSearchCar As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBoxDeleteCar As GroupBox
    Friend WithEvents txtDeleteCar As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBoxAddCarDetails As GroupBox
    Friend WithEvents CboCarAvailability As ComboBox
    Friend WithEvents CboBrand As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblColorText As Label
    Friend WithEvents lblRentPerDayText As Label
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtRentPricePerDay As TextBox
    Friend WithEvents lblModelText As Label
    Friend WithEvents lblBrandText As Label
    Friend WithEvents txtCarModel As TextBox
    Friend WithEvents txtCarRegNo As TextBox
    Friend WithEvents lblRegNoText As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDeleteCar As Button
    Friend WithEvents btnAddCar As Button
    Friend WithEvents OpenFileDialog2 As OpenFileDialog
    Friend WithEvents OpenFileDialogImages As OpenFileDialog
    Friend WithEvents btnUploadImage As Button
    Friend WithEvents PictureBoxCarImage As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
