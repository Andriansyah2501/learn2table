
Public Class Form1

    Sub ambiljenis()
        koneksi.Open()
        perintah.Connection = koneksi
        perintah.CommandType = CommandType.Text
        perintah.CommandText = " SELECT * FROM jenis ORDER BY jenisid"
        cek = perintah.ExecuteReader()
        While cek.Read
            cmbjenisbuku.Items.Add(cek.Item("jenisid") & " - " & cek.Item("jenisnama"))
        End While
        koneksi.Close()
    End Sub


    Sub tidakaktif()
        txtkodebuku.Enabled = False
        txtjudul.Enabled = False
        btntambahjenis.Enabled = False
        cmbjenisbuku.Enabled = False
        btnbatal.Enabled = False
        btnsimpan.Enabled = False
        btnupdate.Enabled = False
        btnhapus.Enabled = False
        txtkodebuku.BackColor = Color.White
        txtjudul.BackColor = Color.White
        cmbjenisbuku.BackColor = Color.White

    End Sub

    Sub aktif()
        txtkodebuku.Enabled = True
        txtjudul.Enabled = True
        btnsimpan.Enabled = True
        btnupdate.Enabled = True
        btntambahjenis.Enabled = True
        cmbjenisbuku.Enabled = True
        btnbatal.Enabled = True
        btnhapus.Enabled = True
        txtkodebuku.BackColor = Color.White
        txtjudul.BackColor = Color.White
        cmbjenisbuku.BackColor = Color.White

    End Sub


    Sub setdg()
        datagridview1.Columns(0).HeaderText = "Kode Buku"
        datagridview1.Columns(1).HeaderText = "Judul"
        datagridview1.Columns(2).HeaderText = "Jenis"

        datagridview1.Columns(0).Width = 90
        datagridview1.Columns(1).Width = 200
        datagridview1.Columns(2).Width = 88

    End Sub


    Sub bersih()
        txtkodebuku.Text = ""
        txtjudul.Text = ""

    End Sub





    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        koneksi.Open()
        perintah.Connection = koneksi
        perintah.CommandType = CommandType.Text
        perintah.CommandText = " INSERT INTO buku VALUES " & _
        " ('" & txtkodebuku.Text & "','" & txtjudul.Text & "', " & _
        " '" & cmbjenisbuku.Text.Substring(0, 1) & "')"
        perintah.ExecuteNonQuery()
        koneksi.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information)
        tampil()
        aktif()
        koneksi.Close()
    End Sub



    Private Sub txtkode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtkodebuku.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                koneksi.Open()
                perintah.Connection = koneksi
                perintah.CommandType = CommandType.Text
                perintah.CommandText = " SELECT buku.*,jenisnama" & _
                " FROM buku JOIN jenis ON buku.jenisid=jenis.jenisid" & _
                " WHERE bukuid='" & txtkodebuku.Text & "'"
                cek = perintah.ExecuteReader()
                cek.Read()
                If cek.HasRows Then
                    txtjudul.Text = cek.Item("bukujudul")
                    cmbjenisbuku.Text = cek.Item("jenisid") & " - " & cek.Item("jenisnama")
                End If
                koneksi.Close()
        End Select
    End Sub



    Sub tampil()
        koneksi.Close()
        koneksi.Open()
        perintah.Connection = koneksi
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT bukuid,bukujudul,jenisnama FROM buku JOIN jenis ON jenis.jenisid=buku.jenisid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "buku")
        datagridview1.DataSource = ds.Tables("buku")
        koneksi.Close()

    End Sub

    Private Sub Form1_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        tampil()
        cmbjenisbuku.Items.Clear()
        ambiljenis()
        setdg()
        tidakaktif()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ambiljenis()
        tampil()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambahjenis.Click
        Form2.Show()
        aktif()
    End Sub

    
    Private Sub btnupdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnupdate.Click
        koneksi.Open()
        perintah.Connection = koneksi
        perintah.CommandType = CommandType.Text
        perintah.CommandText = " UPDATE buku SET " & _
        " bukujudul='" & txtjudul.Text & "', " & _
        " jenisid='" & cmbjenisbuku.Text & "'  where bukuid='" & txtkodebuku.Text & "'"
        perintah.ExecuteNonQuery()
        koneksi.Close()
        MsgBox("DATA BERHASIL DI UPDATE", MsgBoxStyle.Information, "informasi")
        aktif()
        tampil()

    End Sub

    Private Sub datagridview1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles datagridview1.CellContentClick
        Dim i As Integer
        i = datagridview1.CurrentRow.Index
        txtkodebuku.Text = datagridview1.Rows.Item(i).Cells(0).Value
        txtjudul.Text = datagridview1.Rows.Item(i).Cells(1).Value
        cmbjenisbuku.Text = datagridview1.Rows.Item(i).Cells(2).Value
    End Sub

    Private Sub txtcari_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtcari.TextChanged
       
    End Sub

    Private Sub btnkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkeluar.Click
        Dim Keluar As String
        Keluar = MsgBox("Yakin keluar?", vbQuestion + vbYesNo, "Informasi")
        If Keluar = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btntambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntambah.Click
        aktif()
        btntambah.Enabled = False
        btnupdate.Enabled = True
        txtkodebuku.Focus()
        bersih()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        tidakaktif()
        bersih()
        btntambah.Enabled = True

    End Sub

    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhapus.Click

        Dim i As Integer
        Dim kode As String
        Dim x As Byte

        kode = datagridview1.Rows.Item(i).Cells(0).Value
        i = datagridview1.CurrentRow.Index
        x = MsgBox("Hapus Buku dengan Kode " + kode, MsgBoxStyle.Critical + vbYesNo,"Konfirmasi")
        If x = vbYes Then
            koneksi.Open()
            perintah.Connection = koneksi
            perintah.CommandType = CommandType.Text
            perintah.CommandText = "delete from buku where bukuid='" & kode & "'"
            perintah.ExecuteNonQuery()
            koneksi.Close()
            tampil()
            aktif()
        End If
    End Sub

    Private Sub btncari_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncari.Click
        koneksi.Open()
        perintah.Connection = koneksi
        perintah.CommandType = CommandType.Text
        perintah.CommandText = " SELECT bukuid, bukujudul, jenisnama FROM buku JOIN jenis ON buku.jenisid=jenis.jenisid WHERE bukuid = '" & txtcari.Text & "' OR bukujudul like '" & _
        txtcari.Text & "'"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "buku")
        datagridview1.DataSource = ds.Tables("buku")
        koneksi.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tampil()
    End Sub
End Class
