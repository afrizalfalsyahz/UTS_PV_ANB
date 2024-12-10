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
        Label1 = New Label()
        cmbitem = New ComboBox()
        txtharga = New TextBox()
        txtsubtotal = New TextBox()
        btnsubtotal = New Button()
        RadioButton1 = New RadioButton()
        txtdiskon = New TextBox()
        txttotal = New TextBox()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        btntotal = New Button()
        btnreset = New Button()
        btnclose = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        txtjumlah = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Berlin Sans FB Demi", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(240, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(351, 33)
        Label1.TabIndex = 0
        Label1.Text = "Aplikasi Kasir Poetoe Kopi"
        ' 
        ' cmbitem
        ' 
        cmbitem.FormattingEnabled = True
        cmbitem.Items.AddRange(New Object() {"Coffee Arabica 100%", "Coffee Blend", "Coffee Bajawa", "Black Tea"})
        cmbitem.Location = New Point(356, 143)
        cmbitem.Name = "cmbitem"
        cmbitem.Size = New Size(235, 33)
        cmbitem.TabIndex = 1
        ' 
        ' txtharga
        ' 
        txtharga.Location = New Point(356, 197)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(235, 31)
        txtharga.TabIndex = 2
        ' 
        ' txtsubtotal
        ' 
        txtsubtotal.Location = New Point(356, 299)
        txtsubtotal.Name = "txtsubtotal"
        txtsubtotal.Size = New Size(235, 31)
        txtsubtotal.TabIndex = 3
        ' 
        ' btnsubtotal
        ' 
        btnsubtotal.Location = New Point(354, 336)
        btnsubtotal.Name = "btnsubtotal"
        btnsubtotal.Size = New Size(112, 34)
        btnsubtotal.TabIndex = 4
        btnsubtotal.Text = "Sub Total"
        btnsubtotal.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(675, 306)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(149, 29)
        RadioButton1.TabIndex = 5
        RadioButton1.TabStop = True
        RadioButton1.Text = "Harga Normal"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' txtdiskon
        ' 
        txtdiskon.Location = New Point(356, 385)
        txtdiskon.Name = "txtdiskon"
        txtdiskon.Size = New Size(238, 31)
        txtdiskon.TabIndex = 6
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(356, 424)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(235, 31)
        txttotal.TabIndex = 7
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(675, 196)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(72, 29)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "10%"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(675, 252)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(72, 29)
        RadioButton3.TabIndex = 9
        RadioButton3.TabStop = True
        RadioButton3.Text = "20%"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' btntotal
        ' 
        btntotal.Location = New Point(356, 461)
        btntotal.Name = "btntotal"
        btntotal.Size = New Size(112, 34)
        btntotal.TabIndex = 10
        btntotal.Text = "Total"
        btntotal.UseVisualStyleBackColor = True
        ' 
        ' btnreset
        ' 
        btnreset.Location = New Point(392, 525)
        btnreset.Name = "btnreset"
        btnreset.Size = New Size(112, 34)
        btnreset.TabIndex = 11
        btnreset.Text = "Reset"
        btnreset.UseVisualStyleBackColor = True
        ' 
        ' btnclose
        ' 
        btnclose.Location = New Point(510, 525)
        btnclose.Name = "btnclose"
        btnclose.Size = New Size(112, 34)
        btnclose.TabIndex = 12
        btnclose.Text = "Close"
        btnclose.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(240, 146)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 25)
        Label2.TabIndex = 13
        Label2.Text = "ITEM"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(240, 198)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 25)
        Label3.TabIndex = 14
        Label3.Text = "HARGA"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(240, 300)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 25)
        Label4.TabIndex = 15
        Label4.Text = "SUB TOTAL"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(240, 388)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 25)
        Label5.TabIndex = 16
        Label5.Text = "DISKON"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(240, 427)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 25)
        Label6.TabIndex = 17
        Label6.Text = "TOTAL"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(675, 136)
        Label7.Name = "Label7"
        Label7.Size = New Size(76, 25)
        Label7.TabIndex = 18
        Label7.Text = "DISKON"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(240, 252)
        Label8.Name = "Label8"
        Label8.Size = New Size(80, 25)
        Label8.TabIndex = 19
        Label8.Text = "JUMLAH"
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Location = New Point(356, 249)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(150, 31)
        txtjumlah.TabIndex = 20
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(854, 592)
        Controls.Add(txtjumlah)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnclose)
        Controls.Add(btnreset)
        Controls.Add(btntotal)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(txttotal)
        Controls.Add(txtdiskon)
        Controls.Add(RadioButton1)
        Controls.Add(btnsubtotal)
        Controls.Add(txtsubtotal)
        Controls.Add(txtharga)
        Controls.Add(cmbitem)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Poetoe Kopi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbitem As ComboBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtsubtotal As TextBox
    Friend WithEvents btnsubtotal As Button
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents txtdiskon As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents btntotal As Button
    Friend WithEvents btnreset As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtjumlah As TextBox

End Class
