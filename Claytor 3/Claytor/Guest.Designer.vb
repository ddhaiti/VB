<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Guest
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
        Dim CreditCardNumberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Guest))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GuestBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.GuestBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New Claytor.DataSet1()
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
        Me.GuestBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.CreditCardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CustomerNameLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        CreditCardNumberLabel = New System.Windows.Forms.Label()
        CType(Me.GuestBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GuestBindingNavigator.SuspendLayout()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerNameLabel
        '
        CustomerNameLabel.AutoSize = True
        CustomerNameLabel.Location = New System.Drawing.Point(90, 119)
        CustomerNameLabel.Name = "CustomerNameLabel"
        CustomerNameLabel.Size = New System.Drawing.Size(125, 20)
        CustomerNameLabel.TabIndex = 2
        CustomerNameLabel.Text = "customer Name:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(90, 151)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(70, 20)
        AddressLabel.TabIndex = 4
        AddressLabel.Text = "address:"
        '
        'CreditCardNumberLabel
        '
        CreditCardNumberLabel.AutoSize = True
        CreditCardNumberLabel.Location = New System.Drawing.Point(90, 183)
        CreditCardNumberLabel.Name = "CreditCardNumberLabel"
        CreditCardNumberLabel.Size = New System.Drawing.Size(150, 20)
        CreditCardNumberLabel.TabIndex = 6
        CreditCardNumberLabel.Text = "credit Card Number:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(50, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GuestBindingNavigator
        '
        Me.GuestBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.GuestBindingNavigator.BindingSource = Me.GuestBindingSource
        Me.GuestBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.GuestBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.GuestBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.GuestBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.GuestBindingNavigatorSaveItem})
        Me.GuestBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.GuestBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.GuestBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.GuestBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.GuestBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.GuestBindingNavigator.Name = "GuestBindingNavigator"
        Me.GuestBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.GuestBindingNavigator.Size = New System.Drawing.Size(1079, 31)
        Me.GuestBindingNavigator.TabIndex = 1
        Me.GuestBindingNavigator.Text = "BindingNavigator1"
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
        'GuestBindingSource
        '
        Me.GuestBindingSource.DataMember = "guest"
        Me.GuestBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'GuestBindingNavigatorSaveItem
        '
        Me.GuestBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GuestBindingNavigatorSaveItem.Image = CType(resources.GetObject("GuestBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.GuestBindingNavigatorSaveItem.Name = "GuestBindingNavigatorSaveItem"
        Me.GuestBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.GuestBindingNavigatorSaveItem.Text = "Save Data"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "customerName", True))
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(246, 116)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CustomerNameTextBox.TabIndex = 3
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(246, 148)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(100, 26)
        Me.AddressTextBox.TabIndex = 5
        '
        'CreditCardNumberTextBox
        '
        Me.CreditCardNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GuestBindingSource, "creditCardNumber", True))
        Me.CreditCardNumberTextBox.Location = New System.Drawing.Point(246, 180)
        Me.CreditCardNumberTextBox.Name = "CreditCardNumberTextBox"
        Me.CreditCardNumberTextBox.Size = New System.Drawing.Size(100, 26)
        Me.CreditCardNumberTextBox.TabIndex = 7
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "reservation"
        Me.ReservationBindingSource.DataSource = Me.DataSet1
        '
        'ReservationDataGridView
        '
        Me.ReservationDataGridView.AutoGenerateColumns = False
        Me.ReservationDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ReservationDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ReservationDataGridView.DataSource = Me.ReservationBindingSource
        Me.ReservationDataGridView.Location = New System.Drawing.Point(370, 73)
        Me.ReservationDataGridView.Name = "ReservationDataGridView"
        Me.ReservationDataGridView.RowTemplate.Height = 28
        Me.ReservationDataGridView.Size = New System.Drawing.Size(697, 260)
        Me.ReservationDataGridView.TabIndex = 8
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "customerName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "customerName"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "numberOfNights"
        Me.DataGridViewTextBoxColumn4.HeaderText = "numberOfNights"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "phone_number"
        Me.DataGridViewTextBoxColumn5.HeaderText = "phone_number"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "creditCardNumber"
        Me.DataGridViewTextBoxColumn6.HeaderText = "creditCardNumber"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "reservationNumber"
        Me.DataGridViewTextBoxColumn7.HeaderText = "reservationNumber"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Guest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1079, 446)
        Me.Controls.Add(Me.ReservationDataGridView)
        Me.Controls.Add(CustomerNameLabel)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(CreditCardNumberLabel)
        Me.Controls.Add(Me.CreditCardNumberTextBox)
        Me.Controls.Add(Me.GuestBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Guest"
        Me.Text = "Guest"
        CType(Me.GuestBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GuestBindingNavigator.ResumeLayout(False)
        Me.GuestBindingNavigator.PerformLayout()
        CType(Me.GuestBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents GuestBindingSource As BindingSource
    Friend WithEvents GuestBindingNavigator As BindingNavigator
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
    Friend WithEvents GuestBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents CreditCardNumberTextBox As TextBox
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
