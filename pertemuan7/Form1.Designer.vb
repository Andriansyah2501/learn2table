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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtkodebuku = New System.Windows.Forms.TextBox()
        Me.cmbjenisbuku = New System.Windows.Forms.ComboBox()
        Me.txtjudul = New System.Windows.Forms.TextBox()
        Me.btntambahjenis = New System.Windows.Forms.Button()
        Me.btntambah = New System.Windows.Forms.Button()
        Me.btnbatal = New System.Windows.Forms.Button()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnhapus = New System.Windows.Forms.Button()
        Me.btnkeluar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcari = New System.Windows.Forms.TextBox()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncari = New System.Windows.Forms.Button()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Buku"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Judul"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Buku"
        '
        'txtkodebuku
        '
        Me.txtkodebuku.Location = New System.Drawing.Point(90, 53)
        Me.txtkodebuku.Name = "txtkodebuku"
        Me.txtkodebuku.Size = New System.Drawing.Size(100, 20)
        Me.txtkodebuku.TabIndex = 0
        '
        'cmbjenisbuku
        '
        Me.cmbjenisbuku.FormattingEnabled = True
        Me.cmbjenisbuku.Location = New System.Drawing.Point(90, 176)
        Me.cmbjenisbuku.Name = "cmbjenisbuku"
        Me.cmbjenisbuku.Size = New System.Drawing.Size(121, 21)
        Me.cmbjenisbuku.TabIndex = 2
        '
        'txtjudul
        '
        Me.txtjudul.Location = New System.Drawing.Point(90, 80)
        Me.txtjudul.Multiline = True
        Me.txtjudul.Name = "txtjudul"
        Me.txtjudul.Size = New System.Drawing.Size(292, 82)
        Me.txtjudul.TabIndex = 1
        '
        'btntambahjenis
        '
        Me.btntambahjenis.Location = New System.Drawing.Point(217, 176)
        Me.btntambahjenis.Name = "btntambahjenis"
        Me.btntambahjenis.Size = New System.Drawing.Size(22, 23)
        Me.btntambahjenis.TabIndex = 5
        Me.btntambahjenis.Text = "+"
        Me.btntambahjenis.UseVisualStyleBackColor = True
        '
        'btntambah
        '
        Me.btntambah.Location = New System.Drawing.Point(7, 220)
        Me.btntambah.Name = "btntambah"
        Me.btntambah.Size = New System.Drawing.Size(58, 23)
        Me.btntambah.TabIndex = 3
        Me.btntambah.Text = "Tambah"
        Me.btntambah.UseVisualStyleBackColor = True
        '
        'btnbatal
        '
        Me.btnbatal.Location = New System.Drawing.Point(71, 220)
        Me.btnbatal.Name = "btnbatal"
        Me.btnbatal.Size = New System.Drawing.Size(58, 23)
        Me.btnbatal.TabIndex = 4
        Me.btnbatal.Text = "Batal"
        Me.btnbatal.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(132, 220)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(58, 23)
        Me.btnsimpan.TabIndex = 5
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(196, 220)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(58, 23)
        Me.btnupdate.TabIndex = 6
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnhapus
        '
        Me.btnhapus.Location = New System.Drawing.Point(260, 220)
        Me.btnhapus.Name = "btnhapus"
        Me.btnhapus.Size = New System.Drawing.Size(58, 23)
        Me.btnhapus.TabIndex = 7
        Me.btnhapus.Text = "Hapus"
        Me.btnhapus.UseVisualStyleBackColor = True
        '
        'btnkeluar
        '
        Me.btnkeluar.Location = New System.Drawing.Point(324, 220)
        Me.btnkeluar.Name = "btnkeluar"
        Me.btnkeluar.Size = New System.Drawing.Size(58, 23)
        Me.btnkeluar.TabIndex = 8
        Me.btnkeluar.Text = "Keluar"
        Me.btnkeluar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cari Kode / Judul"
        '
        'txtcari
        '
        Me.txtcari.Location = New System.Drawing.Point(111, 258)
        Me.txtcari.Name = "txtcari"
        Me.txtcari.Size = New System.Drawing.Size(188, 20)
        Me.txtcari.TabIndex = 9
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        Me.datagridview1.AllowUserToResizeColumns = False
        Me.datagridview1.AllowUserToResizeRows = False
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.datagridview1.Location = New System.Drawing.Point(0, 289)
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.Size = New System.Drawing.Size(405, 150)
        Me.datagridview1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(108, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(188, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PERPUSTAKAAN KEPRI GEMILANG"
        '
        'btncari
        '
        Me.btncari.Location = New System.Drawing.Point(305, 256)
        Me.btncari.Name = "btncari"
        Me.btncari.Size = New System.Drawing.Size(75, 23)
        Me.btncari.TabIndex = 10
        Me.btncari.Text = "Cari"
        Me.btncari.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 439)
        Me.Controls.Add(Me.btncari)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.datagridview1)
        Me.Controls.Add(Me.txtcari)
        Me.Controls.Add(Me.btnkeluar)
        Me.Controls.Add(Me.btnhapus)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnsimpan)
        Me.Controls.Add(Me.btnbatal)
        Me.Controls.Add(Me.btntambah)
        Me.Controls.Add(Me.btntambahjenis)
        Me.Controls.Add(Me.txtjudul)
        Me.Controls.Add(Me.cmbjenisbuku)
        Me.Controls.Add(Me.txtkodebuku)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtkodebuku As System.Windows.Forms.TextBox
    Friend WithEvents cmbjenisbuku As System.Windows.Forms.ComboBox
    Friend WithEvents txtjudul As System.Windows.Forms.TextBox
    Friend WithEvents btntambahjenis As System.Windows.Forms.Button
    Friend WithEvents btntambah As System.Windows.Forms.Button
    Friend WithEvents btnbatal As System.Windows.Forms.Button
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btnhapus As System.Windows.Forms.Button
    Friend WithEvents btnkeluar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcari As System.Windows.Forms.TextBox
    Friend WithEvents datagridview1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btncari As System.Windows.Forms.Button

End Class
