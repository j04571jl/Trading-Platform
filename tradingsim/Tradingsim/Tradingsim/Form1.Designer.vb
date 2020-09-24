<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TradingsimDatabase1DataSetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TradingsimDatabase1DataSet = New Tradingsim.tradingsimDatabase1DataSet()
        Me.TradingsimDatabase1DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.CustomerTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerTableTableAdapter = New Tradingsim.tradingsimDatabase1DataSetTableAdapters.CustomerTableTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ForenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SurnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradingsimDatabase1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradingsimDatabase1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TradingsimDatabase1DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ForenameDataGridViewTextBoxColumn, Me.SurnameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerTableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(30, 38)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(683, 306)
        Me.DataGridView1.TabIndex = 0
        '
        'TradingsimDatabase1DataSetBindingSource1
        '
        Me.TradingsimDatabase1DataSetBindingSource1.DataSource = Me.TradingsimDatabase1DataSet
        Me.TradingsimDatabase1DataSetBindingSource1.Position = 0
        '
        'TradingsimDatabase1DataSet
        '
        Me.TradingsimDatabase1DataSet.DataSetName = "tradingsimDatabase1DataSet"
        Me.TradingsimDatabase1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TradingsimDatabase1DataSetBindingSource
        '
        Me.TradingsimDatabase1DataSetBindingSource.DataSource = Me.TradingsimDatabase1DataSet
        Me.TradingsimDatabase1DataSetBindingSource.Position = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(534, 136)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(8, 8)
        Me.DataGridView2.TabIndex = 1
        '
        'CustomerTableBindingSource
        '
        Me.CustomerTableBindingSource.DataMember = "CustomerTable"
        Me.CustomerTableBindingSource.DataSource = Me.TradingsimDatabase1DataSetBindingSource
        '
        'CustomerTableTableAdapter
        '
        Me.CustomerTableTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'ForenameDataGridViewTextBoxColumn
        '
        Me.ForenameDataGridViewTextBoxColumn.DataPropertyName = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.HeaderText = "Forename"
        Me.ForenameDataGridViewTextBoxColumn.Name = "ForenameDataGridViewTextBoxColumn"
        '
        'SurnameDataGridViewTextBoxColumn
        '
        Me.SurnameDataGridViewTextBoxColumn.DataPropertyName = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.HeaderText = "Surname"
        Me.SurnameDataGridViewTextBoxColumn.Name = "SurnameDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(972, 559)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradingsimDatabase1DataSetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradingsimDatabase1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TradingsimDatabase1DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TradingsimDatabase1DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TradingsimDatabase1DataSet As Tradingsim.tradingsimDatabase1DataSet
    Friend WithEvents TradingsimDatabase1DataSetBindingSource1 As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents CustomerTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableTableAdapter As Tradingsim.tradingsimDatabase1DataSetTableAdapters.CustomerTableTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ForenameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SurnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
