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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        cmbjenis = New ComboBox()
        cmbnama = New ComboBox()
        txtharga = New TextBox()
        txtjumlah = New TextBox()
        txttotal = New TextBox()
        txtpotongan = New TextBox()
        txtbayar = New TextBox()
        btnhitung = New Button()
        btnbatal = New Button()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Swis721 Blk BT", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.RoyalBlue
        Label1.Location = New Point(287, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(263, 29)
        Label1.TabIndex = 0
        Label1.Text = "Showroom Barokah"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Sitka Small", 8F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ButtonHighlight
        Label2.Location = New Point(48, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(108, 23)
        Label2.TabIndex = 1
        Label2.Text = "Jenis Motor"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Sitka Small", 8F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(40, 145)
        Label3.Name = "Label3"
        Label3.Size = New Size(115, 23)
        Label3.TabIndex = 2
        Label3.Text = "Nama Motor"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Sitka Small", 8F, FontStyle.Bold)
        Label4.ForeColor = SystemColors.ButtonHighlight
        Label4.Location = New Point(537, 82)
        Label4.Name = "Label4"
        Label4.Size = New Size(62, 23)
        Label4.TabIndex = 3
        Label4.Text = "Harga"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Sitka Small", 8F, FontStyle.Bold)
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(528, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(71, 23)
        Label5.TabIndex = 4
        Label5.Text = "Jumlah"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Sitka Small", 8F, FontStyle.Bold)
        Label6.ForeColor = SystemColors.ButtonHighlight
        Label6.Location = New Point(40, 265)
        Label6.Name = "Label6"
        Label6.Size = New Size(110, 23)
        Label6.TabIndex = 5
        Label6.Text = "Total Harga"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Sitka Small", 8F, FontStyle.Bold)
        Label7.ForeColor = SystemColors.ButtonHighlight
        Label7.Location = New Point(40, 311)
        Label7.Name = "Label7"
        Label7.Size = New Size(90, 23)
        Label7.TabIndex = 6
        Label7.Text = "Potongan"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Sitka Small", 8F, FontStyle.Bold)
        Label8.ForeColor = SystemColors.ButtonHighlight
        Label8.Location = New Point(40, 370)
        Label8.Name = "Label8"
        Label8.Size = New Size(108, 23)
        Label8.TabIndex = 7
        Label8.Text = "Total Bayar"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.BackColor = Color.CornflowerBlue
        Label9.Font = New Font("Sitka Banner", 8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.ForeColor = Color.White
        Label9.Location = New Point(456, 427)
        Label9.Name = "Label9"
        Label9.Size = New Size(341, 23)
        Label9.TabIndex = 8
        Label9.Text = "Potongan 500k untuk pembelian di atas 15000000"
        ' 
        ' cmbjenis
        ' 
        cmbjenis.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold)
        cmbjenis.FormattingEnabled = True
        cmbjenis.Location = New Point(175, 82)
        cmbjenis.Name = "cmbjenis"
        cmbjenis.Size = New Size(182, 28)
        cmbjenis.TabIndex = 9
        ' 
        ' cmbnama
        ' 
        cmbnama.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold)
        cmbnama.FormattingEnabled = True
        cmbnama.Location = New Point(175, 141)
        cmbnama.Name = "cmbnama"
        cmbnama.Size = New Size(182, 28)
        cmbnama.TabIndex = 10
        ' 
        ' txtharga
        ' 
        txtharga.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold)
        txtharga.Location = New Point(620, 82)
        txtharga.Name = "txtharga"
        txtharga.Size = New Size(132, 26)
        txtharga.TabIndex = 11
        ' 
        ' txtjumlah
        ' 
        txtjumlah.Font = New Font("Microsoft Sans Serif", 8F, FontStyle.Bold)
        txtjumlah.Location = New Point(620, 139)
        txtjumlah.Name = "txtjumlah"
        txtjumlah.Size = New Size(132, 26)
        txtjumlah.TabIndex = 12
        ' 
        ' txttotal
        ' 
        txttotal.Location = New Point(175, 265)
        txttotal.Name = "txttotal"
        txttotal.Size = New Size(150, 31)
        txttotal.TabIndex = 13
        ' 
        ' txtpotongan
        ' 
        txtpotongan.Location = New Point(175, 311)
        txtpotongan.Name = "txtpotongan"
        txtpotongan.Size = New Size(150, 31)
        txtpotongan.TabIndex = 14
        ' 
        ' txtbayar
        ' 
        txtbayar.Location = New Point(175, 365)
        txtbayar.Name = "txtbayar"
        txtbayar.Size = New Size(150, 31)
        txtbayar.TabIndex = 15
        ' 
        ' btnhitung
        ' 
        btnhitung.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnhitung.Location = New Point(287, 209)
        btnhitung.Name = "btnhitung"
        btnhitung.Size = New Size(112, 34)
        btnhitung.TabIndex = 16
        btnhitung.Text = "Hitung"
        btnhitung.UseVisualStyleBackColor = True
        ' 
        ' btnbatal
        ' 
        btnbatal.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        btnbatal.Location = New Point(438, 209)
        btnbatal.Name = "btnbatal"
        btnbatal.Size = New Size(112, 34)
        btnbatal.TabIndex = 17
        btnbatal.Text = "Batal"
        btnbatal.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Transparent
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(498, 265)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(290, 132)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 18
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Blue
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(btnbatal)
        Controls.Add(btnhitung)
        Controls.Add(txtbayar)
        Controls.Add(txtpotongan)
        Controls.Add(txttotal)
        Controls.Add(txtjumlah)
        Controls.Add(txtharga)
        Controls.Add(cmbnama)
        Controls.Add(cmbjenis)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbjenis As ComboBox
    Friend WithEvents cmbnama As ComboBox
    Friend WithEvents txtharga As TextBox
    Friend WithEvents txtjumlah As TextBox
    Friend WithEvents txttotal As TextBox
    Friend WithEvents txtpotongan As TextBox
    Friend WithEvents txtbayar As TextBox
    Friend WithEvents btnhitung As Button
    Friend WithEvents btnbatal As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
