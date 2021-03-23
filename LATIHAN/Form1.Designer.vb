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
        Dim Kode_barangLabel As System.Windows.Forms.Label
        Dim Nama_barangLabel As System.Windows.Forms.Label
        Dim Jenis_barangLabel As System.Windows.Forms.Label
        Dim Harga_barangLabel1 As System.Windows.Forms.Label
        Dim Jumlah_barangLabel As System.Windows.Forms.Label
        Me.Penjualan_barangDataSet = New LATIHAN.penjualan_barangDataSet()
        Me.Master_barangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Master_barangTableAdapter = New LATIHAN.penjualan_barangDataSetTableAdapters.master_barangTableAdapter()
        Me.TableAdapterManager = New LATIHAN.penjualan_barangDataSetTableAdapters.TableAdapterManager()
        Me.Master_barangDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Kode_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Nama_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Jenis_barangComboBox = New System.Windows.Forms.ComboBox()
        Me.Harga_barangTextBox1 = New System.Windows.Forms.TextBox()
        Me.Jumlah_barangTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Kode_barangLabel = New System.Windows.Forms.Label()
        Nama_barangLabel = New System.Windows.Forms.Label()
        Jenis_barangLabel = New System.Windows.Forms.Label()
        Harga_barangLabel1 = New System.Windows.Forms.Label()
        Jumlah_barangLabel = New System.Windows.Forms.Label()
        CType(Me.Penjualan_barangDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_barangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_barangDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kode_barangLabel
        '
        Kode_barangLabel.AutoSize = True
        Kode_barangLabel.Location = New System.Drawing.Point(28, 30)
        Kode_barangLabel.Name = "Kode_barangLabel"
        Kode_barangLabel.Size = New System.Drawing.Size(70, 13)
        Kode_barangLabel.TabIndex = 1
        Kode_barangLabel.Text = "kode barang:"
        '
        'Nama_barangLabel
        '
        Nama_barangLabel.AutoSize = True
        Nama_barangLabel.Location = New System.Drawing.Point(28, 67)
        Nama_barangLabel.Name = "Nama_barangLabel"
        Nama_barangLabel.Size = New System.Drawing.Size(72, 13)
        Nama_barangLabel.TabIndex = 3
        Nama_barangLabel.Text = "nama barang:"
        '
        'Jenis_barangLabel
        '
        Jenis_barangLabel.AutoSize = True
        Jenis_barangLabel.Location = New System.Drawing.Point(28, 104)
        Jenis_barangLabel.Name = "Jenis_barangLabel"
        Jenis_barangLabel.Size = New System.Drawing.Size(67, 13)
        Jenis_barangLabel.TabIndex = 5
        Jenis_barangLabel.Text = "jenis barang:"
        '
        'Harga_barangLabel1
        '
        Harga_barangLabel1.AutoSize = True
        Harga_barangLabel1.Location = New System.Drawing.Point(28, 184)
        Harga_barangLabel1.Name = "Harga_barangLabel1"
        Harga_barangLabel1.Size = New System.Drawing.Size(73, 13)
        Harga_barangLabel1.TabIndex = 9
        Harga_barangLabel1.Text = "harga barang:"
        '
        'Jumlah_barangLabel
        '
        Jumlah_barangLabel.AutoSize = True
        Jumlah_barangLabel.Location = New System.Drawing.Point(28, 144)
        Jumlah_barangLabel.Name = "Jumlah_barangLabel"
        Jumlah_barangLabel.Size = New System.Drawing.Size(76, 13)
        Jumlah_barangLabel.TabIndex = 10
        Jumlah_barangLabel.Text = "jumlah barang:"
        '
        'Penjualan_barangDataSet
        '
        Me.Penjualan_barangDataSet.DataSetName = "penjualan_barangDataSet"
        Me.Penjualan_barangDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Master_barangBindingSource
        '
        Me.Master_barangBindingSource.DataMember = "master_barang"
        Me.Master_barangBindingSource.DataSource = Me.Penjualan_barangDataSet
        '
        'Master_barangTableAdapter
        '
        Me.Master_barangTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.master_barangTableAdapter = Me.Master_barangTableAdapter
        Me.TableAdapterManager.UpdateOrder = LATIHAN.penjualan_barangDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Master_barangDataGridView
        '
        Me.Master_barangDataGridView.AllowUserToDeleteRows = False
        Me.Master_barangDataGridView.AutoGenerateColumns = False
        Me.Master_barangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Master_barangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Master_barangDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Master_barangDataGridView.DataSource = Me.Master_barangBindingSource
        Me.Master_barangDataGridView.Location = New System.Drawing.Point(12, 225)
        Me.Master_barangDataGridView.Name = "Master_barangDataGridView"
        Me.Master_barangDataGridView.ReadOnly = True
        Me.Master_barangDataGridView.Size = New System.Drawing.Size(543, 221)
        Me.Master_barangDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "kode_barang"
        Me.DataGridViewTextBoxColumn1.HeaderText = "kode_barang"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nama_barang"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nama_barang"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "jenis_barang"
        Me.DataGridViewTextBoxColumn3.HeaderText = "jenis_barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "jumlah_barang"
        Me.DataGridViewTextBoxColumn4.HeaderText = "jumlah_barang"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "harga_barang"
        Me.DataGridViewTextBoxColumn5.HeaderText = "harga_barang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'Kode_barangTextBox
        '
        Me.Kode_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Master_barangBindingSource, "kode_barang", True))
        Me.Kode_barangTextBox.Location = New System.Drawing.Point(110, 27)
        Me.Kode_barangTextBox.Name = "Kode_barangTextBox"
        Me.Kode_barangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Kode_barangTextBox.TabIndex = 2
        '
        'Nama_barangTextBox
        '
        Me.Nama_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Master_barangBindingSource, "nama_barang", True))
        Me.Nama_barangTextBox.Location = New System.Drawing.Point(110, 64)
        Me.Nama_barangTextBox.Name = "Nama_barangTextBox"
        Me.Nama_barangTextBox.Size = New System.Drawing.Size(158, 20)
        Me.Nama_barangTextBox.TabIndex = 4
        '
        'Jenis_barangComboBox
        '
        Me.Jenis_barangComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Master_barangBindingSource, "jenis_barang", True))
        Me.Jenis_barangComboBox.FormattingEnabled = True
        Me.Jenis_barangComboBox.Items.AddRange(New Object() {"MAKANAN", "SNACK", "MINUMAN"})
        Me.Jenis_barangComboBox.Location = New System.Drawing.Point(110, 101)
        Me.Jenis_barangComboBox.Name = "Jenis_barangComboBox"
        Me.Jenis_barangComboBox.Size = New System.Drawing.Size(158, 21)
        Me.Jenis_barangComboBox.TabIndex = 6
        '
        'Harga_barangTextBox1
        '
        Me.Harga_barangTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Master_barangBindingSource, "harga_barang", True))
        Me.Harga_barangTextBox1.Location = New System.Drawing.Point(110, 181)
        Me.Harga_barangTextBox1.Name = "Harga_barangTextBox1"
        Me.Harga_barangTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.Harga_barangTextBox1.TabIndex = 10
        '
        'Jumlah_barangTextBox
        '
        Me.Jumlah_barangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Master_barangBindingSource, "jumlah_barang", True))
        Me.Jumlah_barangTextBox.Location = New System.Drawing.Point(110, 141)
        Me.Jumlah_barangTextBox.Name = "Jumlah_barangTextBox"
        Me.Jumlah_barangTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Jumlah_barangTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(326, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 34)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(432, 64)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 34)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Edit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(326, 135)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 34)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "Hapus"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(432, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 34)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "New"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 458)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Jumlah_barangLabel)
        Me.Controls.Add(Me.Jumlah_barangTextBox)
        Me.Controls.Add(Harga_barangLabel1)
        Me.Controls.Add(Me.Harga_barangTextBox1)
        Me.Controls.Add(Jenis_barangLabel)
        Me.Controls.Add(Me.Jenis_barangComboBox)
        Me.Controls.Add(Nama_barangLabel)
        Me.Controls.Add(Me.Nama_barangTextBox)
        Me.Controls.Add(Kode_barangLabel)
        Me.Controls.Add(Me.Kode_barangTextBox)
        Me.Controls.Add(Me.Master_barangDataGridView)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.Penjualan_barangDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_barangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_barangDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Penjualan_barangDataSet As penjualan_barangDataSet
    Friend WithEvents Master_barangBindingSource As BindingSource
    Friend WithEvents Master_barangTableAdapter As penjualan_barangDataSetTableAdapters.master_barangTableAdapter
    Friend WithEvents TableAdapterManager As penjualan_barangDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Master_barangDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Kode_barangTextBox As TextBox
    Friend WithEvents Nama_barangTextBox As TextBox
    Friend WithEvents Jenis_barangComboBox As ComboBox
    Friend WithEvents Harga_barangTextBox1 As TextBox
    Friend WithEvents Jumlah_barangTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
