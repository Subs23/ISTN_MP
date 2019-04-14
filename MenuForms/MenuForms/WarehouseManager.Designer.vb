﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WarehouseManager
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.RecSpecDatasetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecSpecDataset = New MenuForms.RecSpecDataset()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New MenuForms.RecSpecDatasetTableAdapters.ProductTableAdapter()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txbOrderID = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnSearchOrderID = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Tc_WarehouseManager = New System.Windows.Forms.TabControl()
        Me.InventoryTab = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btrnDisableProduct = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAddNewProduct = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.cbSearchParam = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductDescript = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SellingPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OnHand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vat = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Active = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.PONum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReturnId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastReturnDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbcSupplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox21 = New System.Windows.Forms.TextBox()
        Me.Button7 = New System.Windows.Forms.Button()
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.TabPage1.SuspendLayout
        Me.Tc_WarehouseManager.SuspendLayout
        Me.InventoryTab.SuspendLayout
        Me.Panel1.SuspendLayout
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'RecSpecDatasetBindingSource
        '
        Me.RecSpecDatasetBindingSource.DataSource = Me.RecSpecDataset
        Me.RecSpecDatasetBindingSource.Position = 0
        '
        'RecSpecDataset
        '
        Me.RecSpecDataset.DataSetName = "RecSpecDataset"
        Me.RecSpecDataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.RecSpecDataset
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = true
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.txbOrderID)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.btnSearchOrderID)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.Button3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 26)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TabPage1.Size = New System.Drawing.Size(1225, 708)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Orders"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(253, 370)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(146, 25)
        Me.TextBox1.TabIndex = 15
        '
        'txbOrderID
        '
        Me.txbOrderID.Location = New System.Drawing.Point(337, 92)
        Me.txbOrderID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txbOrderID.Name = "txbOrderID"
        Me.txbOrderID.Size = New System.Drawing.Size(159, 25)
        Me.txbOrderID.TabIndex = 14
        '
        'Label17
        '
        Me.Label17.AutoSize = true
        Me.Label17.Location = New System.Drawing.Point(232, 101)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 17)
        Me.Label17.TabIndex = 13
        Me.Label17.Text = "Order ID :"
        '
        'btnSearchOrderID
        '
        Me.btnSearchOrderID.Location = New System.Drawing.Point(30, 367)
        Me.btnSearchOrderID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchOrderID.Name = "btnSearchOrderID"
        Me.btnSearchOrderID.Size = New System.Drawing.Size(152, 30)
        Me.btnSearchOrderID.TabIndex = 12
        Me.btnSearchOrderID.Text = "Search by Order ID"
        Me.btnSearchOrderID.UseVisualStyleBackColor = true
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(30, 89)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 30)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "Remove Order"
        Me.Button4.UseVisualStyleBackColor = true
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(30, 37)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(114, 30)
        Me.Button3.TabIndex = 0
        Me.Button3.Text = "View Orders"
        Me.Button3.UseVisualStyleBackColor = true
        '
        'Tc_WarehouseManager
        '
        Me.Tc_WarehouseManager.AccessibleName = ""
        Me.Tc_WarehouseManager.Controls.Add(Me.TabPage1)
        Me.Tc_WarehouseManager.Controls.Add(Me.InventoryTab)
        Me.Tc_WarehouseManager.Location = New System.Drawing.Point(15, 17)
        Me.Tc_WarehouseManager.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Tc_WarehouseManager.Name = "Tc_WarehouseManager"
        Me.Tc_WarehouseManager.SelectedIndex = 0
        Me.Tc_WarehouseManager.Size = New System.Drawing.Size(1233, 738)
        Me.Tc_WarehouseManager.TabIndex = 0
        '
        'InventoryTab
        '
        Me.InventoryTab.Controls.Add(Me.Panel1)
        Me.InventoryTab.Controls.Add(Me.cbSearchParam)
        Me.InventoryTab.Controls.Add(Me.DataGridView1)
        Me.InventoryTab.Controls.Add(Me.TextBox21)
        Me.InventoryTab.Controls.Add(Me.Button7)
        Me.InventoryTab.Location = New System.Drawing.Point(4, 26)
        Me.InventoryTab.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryTab.Name = "InventoryTab"
        Me.InventoryTab.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.InventoryTab.Size = New System.Drawing.Size(1225, 708)
        Me.InventoryTab.TabIndex = 1
        Me.InventoryTab.Text = "Products"
        Me.InventoryTab.UseVisualStyleBackColor = true
        '
        'Panel1
        '
        Me.Panel1.AutoSize = true
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.Controls.Add(Me.btrnDisableProduct)
        Me.Panel1.Controls.Add(Me.btnRemove)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnAddNewProduct)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Location = New System.Drawing.Point(170, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(841, 126)
        Me.Panel1.TabIndex = 27
        '
        'btrnDisableProduct
        '
        Me.btrnDisableProduct.Image = Global.MenuForms.My.Resources.Resources.network_error_icon
        Me.btrnDisableProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btrnDisableProduct.Location = New System.Drawing.Point(717, 4)
        Me.btrnDisableProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btrnDisableProduct.Name = "btrnDisableProduct"
        Me.btrnDisableProduct.Size = New System.Drawing.Size(121, 118)
        Me.btrnDisableProduct.TabIndex = 31
        Me.btrnDisableProduct.Text = "Deactivate Product"
        Me.btrnDisableProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btrnDisableProduct.UseVisualStyleBackColor = true
        '
        'btnRemove
        '
        Me.btnRemove.Image = Global.MenuForms.My.Resources.Resources.bin_red_full_icon
        Me.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnRemove.Location = New System.Drawing.Point(536, 4)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(121, 118)
        Me.btnRemove.TabIndex = 30
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnRemove.UseVisualStyleBackColor = true
        '
        'btnSave
        '
        Me.btnSave.Image = Global.MenuForms.My.Resources.Resources.Save_icon
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSave.Location = New System.Drawing.Point(350, 4)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(121, 118)
        Me.btnSave.TabIndex = 29
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = true
        '
        'btnAddNewProduct
        '
        Me.btnAddNewProduct.Image = Global.MenuForms.My.Resources.Resources.add_icon
        Me.btnAddNewProduct.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnAddNewProduct.Location = New System.Drawing.Point(5, 4)
        Me.btnAddNewProduct.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAddNewProduct.Name = "btnAddNewProduct"
        Me.btnAddNewProduct.Size = New System.Drawing.Size(121, 118)
        Me.btnAddNewProduct.TabIndex = 27
        Me.btnAddNewProduct.Text = "Add New Product"
        Me.btnAddNewProduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAddNewProduct.UseVisualStyleBackColor = true
        '
        'btnUpdate
        '
        Me.btnUpdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.btnUpdate.Image = Global.MenuForms.My.Resources.Resources.Pencil_icon
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnUpdate.Location = New System.Drawing.Point(175, 4)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(121, 118)
        Me.btnUpdate.TabIndex = 28
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUpdate.UseCompatibleTextRendering = true
        Me.btnUpdate.UseVisualStyleBackColor = true
        '
        'cbSearchParam
        '
        Me.cbSearchParam.FormattingEnabled = true
        Me.cbSearchParam.Items.AddRange(New Object() {"By Product Code", "By Name"})
        Me.cbSearchParam.Location = New System.Drawing.Point(884, 170)
        Me.cbSearchParam.Name = "cbSearchParam"
        Me.cbSearchParam.Size = New System.Drawing.Size(151, 25)
        Me.cbSearchParam.TabIndex = 22
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = true
        Me.DataGridView1.AutoGenerateColumns = false
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductCode, Me.ProductDescript, Me.SellingPrice, Me.OnHand, Me.Vat, Me.Active, Me.PONum, Me.PoDate, Me.ReturnId, Me.LastReturnDate, Me.tbcSupplier})
        Me.DataGridView1.DataSource = Me.RecSpecDatasetBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 204)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1211, 483)
        Me.DataGridView1.TabIndex = 16
        '
        'ProductCode
        '
        Me.ProductCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductCode.DividerWidth = 1
        Me.ProductCode.FillWeight = 80!
        Me.ProductCode.HeaderText = "Product Code"
        Me.ProductCode.MinimumWidth = 40
        Me.ProductCode.Name = "ProductCode"
        Me.ProductCode.ReadOnly = true
        '
        'ProductDescript
        '
        Me.ProductDescript.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductDescript.FillWeight = 200!
        Me.ProductDescript.HeaderText = "Product Name"
        Me.ProductDescript.MinimumWidth = 80
        Me.ProductDescript.Name = "ProductDescript"
        '
        'SellingPrice
        '
        Me.SellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SellingPrice.FillWeight = 88.55048!
        Me.SellingPrice.HeaderText = "Selling Price"
        Me.SellingPrice.Name = "SellingPrice"
        '
        'OnHand
        '
        Me.OnHand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OnHand.FillWeight = 88.55048!
        Me.OnHand.HeaderText = "On Hand"
        Me.OnHand.Name = "OnHand"
        '
        'Vat
        '
        Me.Vat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Vat.FillWeight = 50!
        Me.Vat.HeaderText = "Vat"
        Me.Vat.MinimumWidth = 25
        Me.Vat.Name = "Vat"
        '
        'Active
        '
        Me.Active.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Active.FillWeight = 50!
        Me.Active.HeaderText = "Active"
        Me.Active.MinimumWidth = 25
        Me.Active.Name = "Active"
        '
        'PONum
        '
        Me.PONum.HeaderText = "PO Number"
        Me.PONum.Name = "PONum"
        '
        'PoDate
        '
        Me.PoDate.HeaderText = "Last PO Date"
        Me.PoDate.Name = "PoDate"
        '
        'ReturnId
        '
        Me.ReturnId.HeaderText = "Return ID"
        Me.ReturnId.Name = "ReturnId"
        '
        'LastReturnDate
        '
        Me.LastReturnDate.HeaderText = "Last Return Date"
        Me.LastReturnDate.Name = "LastReturnDate"
        '
        'tbcSupplier
        '
        Me.tbcSupplier.HeaderText = "Supplier"
        Me.tbcSupplier.Name = "tbcSupplier"
        '
        'TextBox21
        '
        Me.TextBox21.Location = New System.Drawing.Point(290, 170)
        Me.TextBox21.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Size = New System.Drawing.Size(560, 25)
        Me.TextBox21.TabIndex = 15
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(140, 166)
        Me.Button7.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(125, 30)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "Search Product"
        Me.Button7.UseVisualStyleBackColor = true
        '
        'WarehouseManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7!, 17!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 761)
        Me.Controls.Add(Me.Tc_WarehouseManager)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WarehouseManager"
        Me.Text = "Warehouse Manager"
        Me.TopMost = true
        CType(Me.RecSpecDatasetBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.RecSpecDataset,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ProductBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.TabPage1.ResumeLayout(false)
        Me.TabPage1.PerformLayout
        Me.Tc_WarehouseManager.ResumeLayout(false)
        Me.InventoryTab.ResumeLayout(false)
        Me.InventoryTab.PerformLayout
        Me.Panel1.ResumeLayout(false)
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents RecSpecDataset As RecSpecDataset
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As RecSpecDatasetTableAdapters.ProductTableAdapter
    Friend WithEvents RecSpecDatasetBindingSource As BindingSource
    Friend WithEvents ProName As DataGridViewTextBoxColumn
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents txbOrderID As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents btnSearchOrderID As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Tc_WarehouseManager As TabControl
    Friend WithEvents InventoryTab As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btrnDisableProduct As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAddNewProduct As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents cbSearchParam As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ProductCode As DataGridViewTextBoxColumn
    Friend WithEvents ProductDescript As DataGridViewTextBoxColumn
    Friend WithEvents SellingPrice As DataGridViewTextBoxColumn
    Friend WithEvents OnHand As DataGridViewTextBoxColumn
    Friend WithEvents Vat As DataGridViewCheckBoxColumn
    Friend WithEvents Active As DataGridViewCheckBoxColumn
    Friend WithEvents PONum As DataGridViewTextBoxColumn
    Friend WithEvents PoDate As DataGridViewTextBoxColumn
    Friend WithEvents ReturnId As DataGridViewTextBoxColumn
    Friend WithEvents LastReturnDate As DataGridViewTextBoxColumn
    Friend WithEvents tbcSupplier As DataGridViewTextBoxColumn
    Friend WithEvents TextBox21 As TextBox
    Friend WithEvents Button7 As Button
End Class
