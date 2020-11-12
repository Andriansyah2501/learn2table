Public Class Form2

    Private Sub btnsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsimpan.Click
        koneksi.Open()
        perintah.Connection = koneksi
        perintah.CommandType = CommandType.Text
        perintah.CommandText = " INSERT INTO jenis(jenisnama) VALUES('" & txtjenis.Text & "')"
        perintah.ExecuteNonQuery()
        koneksi.Close()
        Me.Dispose()
        Form1.Refresh()
    End Sub

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        koneksi.Open()
        perintah.Connection = koneksi
        perintah.CommandType = CommandType.Text
        perintah.CommandText = " select * from jenis order by jenisid"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "jenis")
        dg.DataSource = ds.Tables("jenis")
        koneksi.Close()
        Form1.Refresh()
    End Sub
End Class