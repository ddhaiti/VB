<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reservation
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
        Me.components = New System.ComponentModel.Container()
        Dim CustomerNameLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim NumberOfNightsLabel As System.Windows.Forms.Label
        Dim Phone_numberLabel As System.Windows.Forms.Label
        Dim CreditCardNumberLabel As System.Windows.Forms.Label
        Dim ReservationNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reservation))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataSet1 = New Claytor.DataSet1()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ReservationBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NumberOfNightsNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Phone_numberTextBox = New System.Windows.Forms.TextBox()
        Me.CreditCardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationNumberTextBox = New System.Windows.Forms.TextBox()
        CustomerNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        NumberOfNightsLabel = New System.Windows.Forms.Label()
        Phone_numberLabel = New System.Windows.Forms.Label()
        CreditCardNumberLabel = New System.Windows.Forms.Label()
        ReservationNumberLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ReservationBindingNavigator.SuspendLayout()
        CType(Me.NumberOfNightsNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(619, 110)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(125, 20)
        CustomerNameLabel.TabIndex = 31
        CustomerNameLabel.Text = "customer Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(637, 163)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(70, 20)
        AddressLabel.TabIndex = 33
        AddressLabel.Text = "address:"
        '
        'NumberOfNightsLabel
        '
        NumberOfNightsLabel.AutoSize = True
        NumberOfNightsLabel.Location = New System.Drawing.Point(607, 205)
        NumberOfNightsLabel.Name = "NumberOfNightsLabel"
        NumberOfNightsLabel.Size = New System.Drawing.Size(137, 20)
        NumberOfNightsLabel.TabIndex = 35
        NumberOfNightsLabel.Text = "number Of Nights:"
        '
        'Phone_numberLabel
        '
        Phone_numberLabel.AutoSize = True
        Phone_numberLabel.Location = New System.Drawing.Point(607, 253)
        Phone_numberLabel.Name = "Phone_numberLabel"
        Phone_numberLabel.Size = New System.Drawing.Size(116, 20)
        Phone_numberLabel.TabIndex = 37
        Phone_numberLabel.Text = "phone number:"
        '
        'CreditCardNumberLabel
        '
        CreditCardNumberLabel.AutoSize = True
        CreditCardNumberLabel.Location = New System.Drawing.Point(594, 304)
        CreditCardNumberLabel.Name = "CreditCardNumberLabel"
        CreditCardNumberLabel.Size = New System.Drawing.Size(150, 20)
        CreditCardNumberLabel.TabIndex = 39
        CreditCardNumberLabel.Text = "credit Card Number:"
        '
        'ReservationNumberLabel
        '
        ReservationNumberLabel.AutoSize = True
        ReservationNumberLabel.Location = New System.Drawing.Point(593, 342)
        ReservationNumberLabel.Name = "ReservationNumberLabel"
        ReservationNumberLabel.Size = New System.Drawing.Size(151, 20)
        ReservationNumberLabel.TabIndex = 41
        ReservationNumberLabel.Text = "reservation Number:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 450)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Room Type"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(24, 110)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(65, 24)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "King"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(24, 151)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(82, 24)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Queen"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(24, 201)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(85, 24)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "Double"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Sunday Through Thursday Rate"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(406, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Friday and Saturday Rate"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "95.00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 20)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "85.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(163, 201)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "69.95"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(451, 112)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "105.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(451, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "95.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(451, 205)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "79.95"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Visa", "Mastercard", "American Express"})
        Me.ComboBox1.Location = New System.Drawing.Point(431, 342)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 13
        Me.ComboBox1.Text = "Credit Card"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(147, 244)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(101, 24)
        Me.CheckBox1.TabIndex = 18
        Me.CheckBox1.Text = "Weekday"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(410, 257)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(103, 24)
        Me.CheckBox2.TabIndex = 19
        Me.CheckBox2.Text = "Weekend"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(220, 375)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(79, 24)
        Me.CheckBox3.TabIndex = 20
        Me.CheckBox3.Text = "AARP"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(220, 417)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(68, 24)
        Me.CheckBox4.TabIndex = 21
        Me.CheckBox4.Text = "AAA"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(768, 394)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 20)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Total"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(571, 390)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 51)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Calculate"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "reservation"
        Me.ReservationBindingSource.DataSource = Me.DataSet1
        '
        'ReservationBindingNavigator
        '
        Me.ReservationBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ReservationBindingNavigator.BindingSource = Me.ReservationBindingSource
        Me.ReservationBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ReservationBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ReservationBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ReservationBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ReservationBindingNavigatorSaveItem})
        Me.ReservationBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ReservationBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ReservationBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ReservationBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ReservationBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ReservationBindingNavigator.Name = "ReservationBindingNavigator"
        Me.ReservationBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ReservationBindingNavigator.Size = New System.Drawing.Size(968, 31)
        Me.ReservationBindingNavigator.TabIndex = 31
        Me.ReservationBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(54, 28)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ReservationBindingNavigatorSaveItem
        '
        Me.ReservationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ReservationBindingNavigatorSaveItem.Image = CType(resources.GetObject("ReservationBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ReservationBindingNavigatorSaveItem.Name = "ReservationBindingNavigatorSaveItem"
        Me.ReservationBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.ReservationBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(772, 114)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(120, 26)
        Me.CustomerNameTextBox.TabIndex = 32
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(772, 163)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(120, 26)
        Me.AddressTextBox.TabIndex = 34
        '
        'NumberOfNightsNumericUpDown
        '
        Me.NumberOfNightsNumericUpDown.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ReservationBindingSource, "numberOfNights", True))
        Me.NumberOfNightsNumericUpDown.Location = New System.Drawing.Point(772, 203)
        Me.NumberOfNightsNumericUpDown.Name = "NumberOfNightsNumericUpDown"
        Me.NumberOfNightsNumericUpDown.Size = New System.Drawing.Size(120, 26)
        Me.NumberOfNightsNumericUpDown.TabIndex = 36
        '
        'Phone_numberTextBox
        '
        Me.Phone_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "phone_number", True))
        Me.Phone_numberTextBox.Location = New System.Drawing.Point(772, 250)
        Me.Phone_numberTextBox.Name = "Phone_numberTextBox"
        Me.Phone_numberTextBox.Size = New System.Drawing.Size(120, 26)
        Me.Phone_numberTextBox.TabIndex = 38
        '
        'CreditCardNumberTextBox
        '
        Me.CreditCardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "creditCardNumber", True))
        Me.CreditCardNumberTextBox.Location = New System.Drawing.Point(772, 304)
        Me.CreditCardNumberTextBox.Name = "CreditCardNumberTextBox"
        Me.CreditCardNumberTextBox.Size = New System.Drawing.Size(120, 26)
        Me.CreditCardNumberTextBox.TabIndex = 40
        '
        'ReservationNumberTextBox
        '
        Me.ReservationNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ReservationBindingSource, "reservationNumber", True))
        Me.ReservationNumberTextBox.Location = New System.Drawing.Point(772, 342)
        Me.ReservationNumberTextBox.Name = "ReservationNumberTextBox"
        Me.ReservationNumberTextBox.Size = New System.Drawing.Size(120, 26)
        Me.ReservationNumberTextBox.TabIndex = 42
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 520)
        Me.Controls.Add(CustomerNameLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(NumberOfNightsLabel)
        Me.Controls.Add(Me.NumberOfNightsNumericUpDown)
        Me.Controls.Add(Phone_numberLabel)
        Me.Controls.Add(Me.Phone_numberTextBox)
        Me.Controls.Add(CreditCardNumberLabel)
        Me.Controls.Add(Me.CreditCardNumberTextBox)
        Me.Controls.Add(ReservationNumberLabel)
        Me.Controls.Add(Me.ReservationNumberTextBox)
        Me.Controls.Add(Me.ReservationBindingNavigator)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ReservationBindingNavigator.ResumeLayout(False)
        Me.ReservationBindingNavigator.PerformLayout()
        CType(Me.NumberOfNightsNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ReservationBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NumberOfNightsNumericUpDown As NumericUpDown
    Friend WithEvents Phone_numberTextBox As TextBox
    Friend WithEvents CreditCardNumberTextBox As TextBox
    Friend WithEvents ReservationNumberTextBox As TextBox
End Class
