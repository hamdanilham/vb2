Public Class Form1
    Dim kelas As String
    Dim harganya, totalsementara As Double
    Dim status1, status2, status3 As Integer

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub harga_TextChanged(sender As Object, e As EventArgs) Handles harga.TextChanged

    End Sub

    Private Sub penerbangan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles penerbangan.SelectedIndexChanged
        Select Case penerbangan.Text
            Case "Jakarta(CGK)-Denpasar(DPS)"
                noKtp.Text = "No. KTP"
            Case "Denpasar(DPS)-Jakarta(CGK)"
                noKtp.Text = "No. KTP"
            Case "Jakarta(CGK)-Surabaya(SBY)"
                noKtp.Text = "No. KTP"
            Case "Surabaya(SBY)-Jakarta(CGK)"
                noKtp.Text = "No. KTP"
            Case "Bandung(BDG)-Surabaya(SBY)"
                noKtp.Text = "No. KTP"
            Case "Surabaya(SBY)-Bandung(BDG)"
                noKtp.Text = "No. KTP"
            Case "Bandung(BDG)-Denpasar(DPS)"
                noKtp.Text = "No. KTP"
            Case "Denpasar(DPS)-Bandung(BDG)"
                noKtp.Text = "No. KTP"
            Case "Jakarta(CGK)-Singapur(SNG)"
                noKtp.Text = "No. Passport"
            Case "Singapur(SNG)-Jakarta(CGK)"
                noKtp.Text = "No. Passport"
            Case "Jakarta(CGK)-Kuala Lumpur(KLI)"
                noKtp.Text = "No. Passport"
            Case "Kuala Lumpur(KLI) - Jakarta(CGK)"
                noKtp.Text = "No. Passport"
            Case "Jakarta(CGK)-Bangkok(BGK)"
                noKtp.Text = "No. Passport"
            Case "Bangkok(BGK)-Jakarta(CGK)"
                noKtp.Text = "No. Passport"
            Case "Bandung(BDG)-Singapur(SNG)"
                noKtp.Text = "No. Passport"
            Case "Singapur(SNG)-Bandung(BDG)"
                noKtp.Text = "No. Passport"
            Case "Bandung(BDG)-Kuala Lumpur(KLI)"
                noKtp.Text = "No. Passport"
            Case "Kuala Lumpur(KLI) - Bandung(BDG)"
                noKtp.Text = "No. Passport"
            Case "Bandung(BDG)-Bangkok(BGK)"
                noKtp.Text = "No. Passport"
            Case "Bangkok(BGK)-Bandung(BDG)"
                noKtp.Text = "No. Passport"
            Case "Surabaya(SBY)-Singapur(SNG)"
                noKtp.Text = "No. Passport"
            Case "Singapur(SNG)-Surabaya(SBY)"
                noKtp.Text = "No. Passport"
            Case "Surabaya(SBY)-Kuala Lumpur(KLI)"
                noKtp.Text = "No. Passport"
            Case "Kuala Lumpur(KLI)-Surabaya(SBY)"
                noKtp.Text = "No. Passport"
            Case "Surabaya(SBY)-Bangkok(BGK)"
                noKtp.Text = "No. Passport"
            Case "Bangkok(BGK)-Surabaya(SBY)"
                noKtp.Text = "No. Passport"
            Case "Denpasar(DPS)-Singapur(SNG)"
                noKtp.Text = "No. Passport"
            Case "Singapur(SNG)-Denpasar(DPS)"
                noKtp.Text = "No. Passport"
            Case "Denpasar(DPS)-Kuala Lumpur(KLI)"
                noKtp.Text = "No. Passport"
            Case "Kuala Lumpur(KLI) - Denpasar(DPS)"
                noKtp.Text = "No. Passport"
            Case "Denpasar(DPS)-Bangkok(BGK)"
                noKtp.Text = "No. Passport"
            Case "Bangkok(BGK)-Denpasar(DPS)"
                noKtp.Text = "No. Passport"
        End Select
    End Sub

    Private Sub bisnis_CheckedChanged(sender As Object, e As EventArgs) Handles bisnis.CheckedChanged
        kelas = "Bisnis"
        Select Case penerbangan.Text
            Case "Jakarta(CGK)-Denpasar(DPS)"
                harga.Text = "1950000"
            Case "Denpasar(DPS)-Jakarta(CGK)"
                harga.Text = "1850000"
            Case "Jakarta(CGK)-Surabaya(SBY)"
                harga.Text = "1750000"
            Case "Surabaya(SBY)-Jakarta(CGK)"
                harga.Text = "1725000"
            Case "Bandung(BDG)-Surabaya(SBY)"
                harga.Text = "1950000"
            Case "Surabaya(SBY)-Bandung(BDG)"
                harga.Text = "1925000"
            Case "Bandung(BDG)-Denpasar(DPS)"
                harga.Text = "2250000"
            Case "Denpasar(DPS)-Bandung(BDG)"
                harga.Text = "2750000"
            Case "Jakarta(CGK)-Singapur(SNG)"
                harga.Text = "2500000"
            Case "Singapur(SNG)-Jakarta(CGK)"
                harga.Text = "2525000"
            Case "Jakarta(CGK)-Kuala Lumpur(KLI)"
                harga.Text = "2600000"
            Case "Kuala Lumpur(KLI) - Jakarta(CGK)"
                harga.Text = "2625000"
            Case "Jakarta(CGK)-Bangkok(BGK)"
                harga.Text = "2700000"
            Case "Bangkok(BGK)-Jakarta(CGK)"
                harga.Text = "2725000"
            Case "Bandung(BDG)-Singapur(SNG)"
                harga.Text = "2800000"
            Case "Singapur(SNG)-Bandung(BDG)"
                harga.Text = "2825000"
            Case "Bandung(BDG)-Kuala Lumpur(KLI)"
                harga.Text = "2900000"
            Case "Kuala Lumpur(KLI) - Bandung(BDG)"
                harga.Text = "2925000"
            Case "Bandung(BDG)-Bangkok(BGK)"
                harga.Text = "3000000"
            Case "Bangkok(BGK)-Bandung(BDG)"
                harga.Text = "3525000"
            Case "Surabaya(SBY)-Singapur(SNG)"
                harga.Text = "2900000"
            Case "Singapur(SNG)-Surabaya(SBY)"
                harga.Text = "2825000"
            Case "Surabaya(SBY)-Kuala Lumpur(KLI)"
                harga.Text = "2625000"
            Case "Kuala Lumpur(KLI)-Surabaya(SBY)"
                harga.Text = "2700000"
            Case "Surabaya(SBY)-Bangkok(BGK)"
                harga.Text = "2725000"
            Case "Bangkok(BGK)-Surabaya(SBY)"
                harga.Text = "2800000"
            Case "Denpasar(DPS)-Singapur(SNG)"
                harga.Text = "2825000"
            Case "Singapur(SNG)-Denpasar(DPS)"
                harga.Text = "2900000"
            Case "Denpasar(DPS)-Kuala Lumpur(KLI)"
                harga.Text = "2925000"
            Case "Kuala Lumpur(KLI) - Denpasar(DPS)"
                harga.Text = "2625000"
            Case "Denpasar(DPS)-Bangkok(BGK)"
                harga.Text = "2700000"
            Case "Bangkok(BGK)-Denpasar(DPS)"
                harga.Text = "2725000"
        End Select
    End Sub

    Private Sub ekonomi_CheckedChanged(sender As Object, e As EventArgs) Handles ekonomi.CheckedChanged
        Select Case penerbangan.Text
            Case "Jakarta(CGK)-Denpasar(DPS)"
                harga.Text = "1025000"
            Case "Denpasar(DPS)-Jakarta(CGK)"
                harga.Text = "975000"
            Case "Jakarta(CGK)-Surabaya(SBY)"
                harga.Text = "875000"
            Case "Surabaya(SBY)-Jakarta(CGK)"
                harga.Text = "825000"
            Case "Bandung(BDG)-Surabaya(SBY)"
                harga.Text = "1125000"
            Case "Surabaya(SBY)-Bandung(BDG)"
                harga.Text = "1075000"
            Case "Bandung(BDG)-Denpasar(DPS)"
                harga.Text = "1525000"
            Case "Denpasar(DPS)-Bandung(BDG)"
                harga.Text = "1750000"
            Case "Jakarta(CGK)-Singapur(SNG)"
                harga.Text = "1500000"
            Case "Singapur(SNG)-Jakarta(CGK)"
                harga.Text = "1525000"
            Case "Jakarta(CGK)-Kuala Lumpur(KLI)"
                harga.Text = "1600000"
            Case "Kuala Lumpur(KLI) - Jakarta(CGK)"
                harga.Text = "1625000"
            Case "Jakarta(CGK)-Bangkok(BGK)"
                harga.Text = "1700000"
            Case "Bangkok(BGK)-Jakarta(CGK)"
                harga.Text = "1725000"
            Case "Bandung(BDG)-Singapur(SNG)"
                harga.Text = "1800000"
            Case "Singapur(SNG)-Bandung(BDG)"
                harga.Text = "1825000"
            Case "Bandung(BDG)-Kuala Lumpur(KLI)"
                harga.Text = "1900000"
            Case "Kuala Lumpur(KLI) - Bandung(BDG)"
                harga.Text = "1925000"
            Case "Bandung(BDG)-Bangkok(BGK)"
                harga.Text = "2500000"
            Case "Bangkok(BGK)-Bandung(BDG)"
                harga.Text = "2525000"
            Case "Surabaya(SBY)-Singapur(SNG)"
                harga.Text = "2500000"
            Case "Singapur(SNG)-Surabaya(SBY)"
                harga.Text = "2525000"
            Case "Surabaya(SBY)-Kuala Lumpur(KLI)"
                harga.Text = "1625000"
            Case "Kuala Lumpur(KLI)-Surabaya(SBY)"
                harga.Text = "1700000"
            Case "Surabaya(SBY)-Bangkok(BGK)"
                harga.Text = "1725000"
            Case "Bangkok(BGK)-Surabaya(SBY)"
                harga.Text = "1800000"
            Case "Denpasar(DPS)-Singapur(SNG)"
                harga.Text = "1825000"
            Case "Singapur(SNG)-Denpasar(DPS)"
                harga.Text = "1900000"
            Case "Denpasar(DPS)-Kuala Lumpur(KLI)"
                harga.Text = "1925000"
            Case "Kuala Lumpur(KLI) - Denpasar(DPS)"
                harga.Text = "1625000"
            Case "Denpasar(DPS)-Bangkok(BGK)"
                harga.Text = "1700000"
            Case "Bangkok(BGK)-Denpasar(DPS)"
                harga.Text = "1725000"
        End Select
    End Sub

    Private Sub tanggalKembali_ValueChanged(sender As Object, e As EventArgs) Handles tanggalKembali.ValueChanged
        Dim tgl1 As DateTime
        Dim tgl2 As DateTime
        Dim st As Double
        Dim tiketdewasa As Double
        Dim tiketbayi As Double

        tgl1 = tanggalBerangkat.Value.Date
        tgl2 = tanggalKembali.Value.Date
        If (tgl2 < tgl1) Then
            tanggalBerangkat.Value = DateTime.Now
            tanggalKembali.Value = DateTime.Now
            MessageBox.Show("Tanggal berangkat lebih dari tanggal kembali!! Masukan tanggal dengan benar", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            tiketdewasa = Val(dewasa.Text) * Val(harga.Text)
            tiketbayi = Val(bayi.Text) * (15 * tiketdewasa / 100)
            st = tiketdewasa + tiketbayi
            subTotal.Text = st.ToString
            totalSemua.Text = st.ToString
        End If
    End Sub

    Private Sub tanggalBerangkat_ValueChanged(sender As Object, e As EventArgs) Handles tanggalBerangkat.ValueChanged
        Dim tgl1 As DateTime
        Dim tgl2 As DateTime
        Dim st As Double
        Dim tiketdewasa As Double
        Dim tiketbayi As Double

        tgl1 = tanggalBerangkat.Value.Date
        tgl2 = tanggalKembali.Value.Date
        If (tgl2 < tgl1) Then
            tanggalBerangkat.Value = DateTime.Now
            tanggalKembali.Value = DateTime.Now
            MessageBox.Show("Tanggal berangkat lebih dari tanggal kembali!! Masukan tanggal dengan benar", "Warning!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            tiketdewasa = Val(dewasa.Text) * Val(harga.Text)
            tiketbayi = Val(bayi.Text) * (15 * tiketdewasa / 100)
            st = tiketdewasa + tiketbayi
            subTotal.Text = st.ToString
            totalSemua.Text = st.ToString
        End If
    End Sub

    Private Sub dewasa_TextChanged(sender As Object, e As EventArgs) Handles dewasa.TextChanged
        Dim st As Double
        Dim tiketdewasa As Double
        Dim tiketbayi As Double

        tiketdewasa = Val(dewasa.Text) * Val(harga.Text)
        tiketbayi = Val(bayi.Text) * (15 * tiketdewasa / 100)
        st = tiketdewasa + tiketbayi
        subTotal.Text = st.ToString
        totalSemua.Text = st.ToString
        totalsementara = st
    End Sub

    Private Sub bayi_TextChanged(sender As Object, e As EventArgs) Handles bayi.TextChanged
        Dim st As Double
        Dim tiketdewasa As Double
        Dim tiketbayi As Double

        tiketdewasa = Val(dewasa.Text) * Val(harga.Text)
        tiketbayi = Val(bayi.Text) * (15 * tiketdewasa / 100)
        st = tiketdewasa + tiketbayi
        subTotal.Text = st.ToString
        totalSemua.Text = st.ToString
        totalsementara = st
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles bagasi3.CheckedChanged
        If (status1 = 0) Then
            harganya = harganya + 925000
            status1 = 1
        Else
            harganya = harganya - 925000
            status1 = 0
        End If

        totalSemua.Text = totalsementara + harganya
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        penerbangan.Text = ""
        bisnis.Checked = False
        ekonomi.Checked = False
        harga.Text = ""
        nama.Text = ""
        ktp.Text = ""
        tanggalKembali.Value = DateTime.Now
        tanggalBerangkat.Value = DateTime.Now
        subTotal.Text = ""
        dewasa.Text = ""
        bayi.Text = ""
        totalSemua.Text = ""
        bagasi1.Checked = False
        bagasi2.Checked = False
        bagasi3.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

    Private Sub bagasi1_CheckedChanged(sender As Object, e As EventArgs) Handles bagasi1.CheckedChanged
        If (status2 = 0) Then
            harganya = harganya + 325000
            status2 = 1
        Else
            harganya = harganya - 325000
            status2 = 0
        End If

        totalSemua.Text = totalsementara + harganya
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        status1 = 0
        status2 = 0
        status3 = 0
        harganya = 0
    End Sub

    Private Sub bagasi2_CheckedChanged(sender As Object, e As EventArgs) Handles bagasi2.CheckedChanged
        If (status3 = 0) Then
            harganya = harganya + 625000
            status3 = 1
        Else
            harganya = harganya - 625000
            status3 = 0
        End If

        totalSemua.Text = totalsementara + harganya
    End Sub
End Class
