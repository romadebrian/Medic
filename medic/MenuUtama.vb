Public Class MenuUtama

    Private Sub PasienToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasienToolStripMenuItem.Click
        pasien.Show()
    End Sub

    Private Sub DokterToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles DokterToolStripMenuItem.Click
        Dokter.Show()

    End Sub

    Private Sub ObatToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ObatToolStripMenuItem.Click
        Obat.Show()
    End Sub

    Private Sub UserToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserToolStripMenuItem.Click
        User.Show()
    End Sub

    Private Sub RekamMedisToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RekamMedisToolStripMenuItem.Click
        Transaksi.Show()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
End Class