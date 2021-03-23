<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Me.Penjualan_barangDataSet1 = New LATIHAN.penjualan_barangDataSet1()
        Me.T_userBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.T_userTableAdapter = New LATIHAN.penjualan_barangDataSet1TableAdapters.t_userTableAdapter()
        Me.TableAdapterManager = New LATIHAN.penjualan_barangDataSet1TableAdapters.TableAdapterManager()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        CType(Me.Penjualan_barangDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_userBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.Location = New System.Drawing.Point(17, 27)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(56, 13)
        UsernameLabel.TabIndex = 1
        UsernameLabel.Text = "username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(18, 65)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(55, 13)
        PasswordLabel.TabIndex = 3
        PasswordLabel.Text = "password:"
        '
        'Penjualan_barangDataSet1
        '
        Me.Penjualan_barangDataSet1.DataSetName = "penjualan_barangDataSet1"
        Me.Penjualan_barangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_userBindingSource
        '
        Me.T_userBindingSource.DataMember = "t_user"
        Me.T_userBindingSource.DataSource = Me.Penjualan_barangDataSet1
        '
        'T_userTableAdapter
        '
        Me.T_userTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.t_userTableAdapter = Me.T_userTableAdapter
        Me.TableAdapterManager.UpdateOrder = LATIHAN.penjualan_barangDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_userBindingSource, "username", True))
        Me.UsernameTextBox.Location = New System.Drawing.Point(79, 24)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(171, 20)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.T_userBindingSource, "password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(79, 62)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(171, 20)
        Me.PasswordTextBox.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(175, 105)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormLogin"
        CType(Me.Penjualan_barangDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_userBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Penjualan_barangDataSet1 As penjualan_barangDataSet1
    Friend WithEvents T_userBindingSource As BindingSource
    Friend WithEvents T_userTableAdapter As penjualan_barangDataSet1TableAdapters.t_userTableAdapter
    Friend WithEvents TableAdapterManager As penjualan_barangDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
