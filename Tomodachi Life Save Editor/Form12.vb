﻿Imports PackageIO
Public Class Form12
    Dim filepath As String
    Dim fdialog As New Form3
    Dim stmname As String
    Dim stmisland As String
    Dim stmexp As String
    Dim stmlv As String
    Dim stmregion As String
    Dim MonFichier As PackageIO.Reader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Writestmp()
    End Sub
    Private Sub Writestmp()
        Try
            Dim Writer As New PackageIO.Writer(filepath, PackageIO.Endian.Little)
            Writer.Position = stmlv
            Writer.WriteInt8(NumericUpDown1.Value)
            Writer.Position = stmexp
            Writer.WriteInt8(NumericUpDown2.Value)
            If Form1.ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "Sauvegarde enregistré"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "File saved"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "DE" Then
                fdialog.Label1.Text = "Datei speichern"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "ES" Then
                fdialog.Label1.Text = "Archivo guardado"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "PT" Then
                fdialog.Label1.Text = "Arquivo Salvo"
                fdialog.ShowDialog()
            End If
        Catch ex As Exception
            If Form1.ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "Une erreur est survenue"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "An error has occured"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "DE" Then
                fdialog.Label1.Text = "ein Fehler ist aufgetreten"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "ES" Then
                fdialog.Label1.Text = "Ha ocurrido un error"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "PT" Then
                fdialog.Label1.Text = "Um erro ocorreu"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Form1.PictureBox30.Image
        If Form1.ComboBox11.Text = "EN" Then
            Label1.Text = "Lv."
            Label2.Text = "Region"
            Label3.Text = "Home"
            Label4.Text = "Happiness"
            Label5.Text = "Gratitude"
            Button1.Text = "Save"
            Button2.Text = "Close"
        ElseIf Form1.ComboBox11.Text = "FR" Then
            Label1.Text = "Niv."
            Label2.Text = "Région"
            Label3.Text = "Île d'origine"
            Label4.Text = "Détente"
            Label5.Text = "Gratitude"
            Button1.Text = "Enregistrer"
            Button2.Text = "Fermer"
        ElseIf Form1.ComboBox11.Text = "DE" Then
            Label1.Text = "Lv."
            Label2.Text = "Region"
            Label3.Text = "Zuhause"
            Label4.Text = "Zufriedenheit"
            Label5.Text = "Dankbarkeit"
            Button1.Text = "speichern"
            Button2.Text = "schließen"
        ElseIf Form1.ComboBox11.Text = "PT" Then
            Label1.Text = "Nív."
            Label2.Text = "Região"
            Label3.Text = "Casa"
            Label4.Text = "Felicidade"
            Label5.Text = "Gratitude"
            Button1.Text = "Salvar"
            Button2.Text = "Fechar"
        ElseIf Form1.ComboBox11.Text = "ES" Then
            Label1.Text = "Niv."
            Label2.Text = "Región"
            Label3.Text = "Isla de origen"
            Label4.Text = "Relajación"
            Label5.Text = "Agradecimiento"
            Button1.Text = "Guardar"
            Button2.Text = "Cerrar"
        End If

        filepath = Form1.Label39.Text
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            Dim Reader As New PackageIO.Reader(filepath, PackageIO.Endian.Little)
            If ComboBox1.SelectedItem = ComboBox1.Items.Item(0) Then
                Reader.Position = &H392C0
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(1) Then
                Reader.Position = &H392C0 + &HC28
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + &HC28
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + &HC28
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + &HC28
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + &HC28
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(2) Then
                Reader.Position = &H392C0 + (&HC28 * 2)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 2)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 2)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 2)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 2)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(3) Then
                Reader.Position = &H392C0 + (&HC28 * 3)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 3)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 3)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 3)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 3)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(4) Then
                Reader.Position = &H392C0 + (&HC28 * 4)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 4)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 4)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 4)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 4)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(5) Then
                Reader.Position = &H392C0 + (&HC28 * 5)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 5)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 5)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 5)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 5)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(6) Then
                Reader.Position = &H392C0 + (&HC28 * 6)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 6)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 6)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 6)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 6)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(7) Then
                Reader.Position = &H392C0 + (&HC28 * 7)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 7)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 7)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 7)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 7)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(8) Then
                Reader.Position = &H392C0 + (&HC28 * 8)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 8)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 8)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 8)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 8)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            ElseIf ComboBox1.SelectedItem = ComboBox1.Items.Item(9) Then
                Reader.Position = &H392C0 + (&HC28 * 9)
                stmname = Reader.Position
                Label6.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39500 + (&HC28 * 9)
                stmisland = Reader.Position
                Label8.Text = Reader.ReadUnicodeString(10)
                Reader.Position = &H39C7C + (&HC28 * 9)
                stmregion = Reader.Position
                Label7.Text = Reader.ReadUnicodeString(64)
                Reader.Position = &H394FD + (&HC28 * 9)
                stmlv = Reader.Position
                NumericUpDown1.Value = Reader.ReadInt8
                Reader.Position = &H394FC + (&HC28 * 9)
                stmexp = Reader.Position
                NumericUpDown2.Value = Reader.ReadInt8
            End If
        Catch ex As Exception
            If Form1.ComboBox11.Text = "EN" Then
                fdialog.Label1.Text = "An error has occured, load a save first"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "FR" Then
                fdialog.Label1.Text = "Une erreur est survenue, ouvrez une sauvegarde avant"
                fdialog.ShowDialog()
            End If
            If Form1.ComboBox11.Text = "DE" Then
                fdialog.Label1.Text = "ein Fehler ist aufgetreten, lade vorher einen Speicherstand"
                fdialog.ShowDialog()
            End If
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown2.Value = 0 Then
            PictureBox32.Image = My.Resources.exp0
        End If
        If NumericUpDown2.Value = 1 Then
            PictureBox32.Image = My.Resources.exp1
        End If
        If NumericUpDown2.Value = 2 Then
            PictureBox32.Image = My.Resources.exp2
        End If
        If NumericUpDown2.Value = 3 Then
            PictureBox32.Image = My.Resources.exp3
        End If
        If NumericUpDown2.Value = 4 Then
            PictureBox32.Image = My.Resources.exp4
        End If
        If NumericUpDown2.Value = 5 Then
            PictureBox32.Image = My.Resources.exp5
        End If
        If NumericUpDown2.Value = 6 Then
            PictureBox32.Image = My.Resources.exp6
        End If
        If NumericUpDown2.Value = 7 Then
            PictureBox32.Image = My.Resources.exp7
        End If
        If NumericUpDown2.Value = 8 Then
            PictureBox32.Image = My.Resources.exp8
        End If
        If NumericUpDown2.Value = 9 Then
            PictureBox32.Image = My.Resources.exp9
        End If
        If NumericUpDown2.Value = 10 Then
            PictureBox32.Image = My.Resources.exp10
        End If
        If NumericUpDown2.Value = 11 Then
            PictureBox32.Image = My.Resources.exp11
        End If
        If NumericUpDown2.Value = 12 Then
            PictureBox32.Image = My.Resources.exp12
        End If
        If NumericUpDown2.Value = 13 Then
            PictureBox32.Image = My.Resources.exp13
        End If
        If NumericUpDown2.Value = 14 Then
            PictureBox32.Image = My.Resources.exp14
        End If
        If NumericUpDown2.Value = 15 Then
            PictureBox32.Image = My.Resources.exp15
        End If
        If NumericUpDown2.Value = 16 Then
            PictureBox32.Image = My.Resources.exp16
        End If
        If NumericUpDown2.Value = 17 Then
            PictureBox32.Image = My.Resources.exp17
        End If
        If NumericUpDown2.Value = 18 Then
            PictureBox32.Image = My.Resources.exp18
        End If
        If NumericUpDown2.Value = 19 Then
            PictureBox32.Image = My.Resources.exp19
        End If
        If NumericUpDown2.Value = 20 Then
            PictureBox32.Image = My.Resources.exp20
        End If
        If NumericUpDown2.Value = 21 Then
            PictureBox32.Image = My.Resources.exp21
        End If
        If NumericUpDown2.Value = 22 Then
            PictureBox32.Image = My.Resources.exp22
        End If
        If NumericUpDown2.Value = 23 Then
            PictureBox32.Image = My.Resources.exp23
        End If
        If NumericUpDown2.Value = 24 Then
            PictureBox32.Image = My.Resources.exp24
        End If
        If NumericUpDown2.Value = 25 Then
            PictureBox32.Image = My.Resources.exp25
        End If
        If NumericUpDown2.Value = 26 Then
            PictureBox32.Image = My.Resources.exp26
        End If
        If NumericUpDown2.Value = 27 Then
            PictureBox32.Image = My.Resources.exp27
        End If
        If NumericUpDown2.Value = 28 Then
            PictureBox32.Image = My.Resources.exp28
        End If
        If NumericUpDown2.Value = 29 Then
            PictureBox32.Image = My.Resources.exp29
        End If
        If NumericUpDown2.Value = 30 Then
            PictureBox32.Image = My.Resources.exp30
        End If
        If NumericUpDown2.Value = 31 Then
            PictureBox32.Image = My.Resources.exp31
        End If
        If NumericUpDown2.Value = 32 Then
            PictureBox32.Image = My.Resources.exp32
        End If
        If NumericUpDown2.Value = 33 Then
            PictureBox32.Image = My.Resources.exp33
        End If
        If NumericUpDown2.Value = 34 Then
            PictureBox32.Image = My.Resources.exp34
        End If
        If NumericUpDown2.Value = 35 Then
            PictureBox32.Image = My.Resources.exp35
        End If
        If NumericUpDown2.Value = 36 Then
            PictureBox32.Image = My.Resources.exp36
        End If
        If NumericUpDown2.Value = 37 Then
            PictureBox32.Image = My.Resources.exp37
        End If
        If NumericUpDown2.Value = 38 Then
            PictureBox32.Image = My.Resources.exp38
        End If
        If NumericUpDown2.Value = 39 Then
            PictureBox32.Image = My.Resources.exp39
        End If
        If NumericUpDown2.Value = 40 Then
            PictureBox32.Image = My.Resources.exp40
        End If
        If NumericUpDown2.Value = 41 Then
            PictureBox32.Image = My.Resources.exp41
        End If
        If NumericUpDown2.Value = 42 Then
            PictureBox32.Image = My.Resources.exp42
        End If
        If NumericUpDown2.Value = 43 Then
            PictureBox32.Image = My.Resources.exp43
        End If
        If NumericUpDown2.Value = 44 Then
            PictureBox32.Image = My.Resources.exp44
        End If
        If NumericUpDown2.Value = 45 Then
            PictureBox32.Image = My.Resources.exp45
        End If
        If NumericUpDown2.Value = 46 Then
            PictureBox32.Image = My.Resources.exp46
        End If
        If NumericUpDown2.Value = 47 Then
            PictureBox32.Image = My.Resources.exp47
        End If
        If NumericUpDown2.Value = 48 Then
            PictureBox32.Image = My.Resources.exp48
        End If
        If NumericUpDown2.Value = 49 Then
            PictureBox32.Image = My.Resources.exp49
        End If
        If NumericUpDown2.Value = 50 Then
            PictureBox32.Image = My.Resources.exp50
        End If
        If NumericUpDown2.Value = 51 Then
            PictureBox32.Image = My.Resources.exp51
        End If
        If NumericUpDown2.Value = 52 Then
            PictureBox32.Image = My.Resources.exp52
        End If
        If NumericUpDown2.Value = 53 Then
            PictureBox32.Image = My.Resources.exp53
        End If
        If NumericUpDown2.Value = 54 Then
            PictureBox32.Image = My.Resources.exp54
        End If
        If NumericUpDown2.Value = 55 Then
            PictureBox32.Image = My.Resources.exp55
        End If
        If NumericUpDown2.Value = 56 Then
            PictureBox32.Image = My.Resources.exp56
        End If
        If NumericUpDown2.Value = 57 Then
            PictureBox32.Image = My.Resources.exp57
        End If
        If NumericUpDown2.Value = 58 Then
            PictureBox32.Image = My.Resources.exp58
        End If
        If NumericUpDown2.Value = 59 Then
            PictureBox32.Image = My.Resources.exp59
        End If
        If NumericUpDown2.Value = 60 Then
            PictureBox32.Image = My.Resources.exp60
        End If
        If NumericUpDown2.Value = 61 Then
            PictureBox32.Image = My.Resources.exp61
        End If
        If NumericUpDown2.Value = 62 Then
            PictureBox32.Image = My.Resources.exp62
        End If
        If NumericUpDown2.Value = 63 Then
            PictureBox32.Image = My.Resources.exp63
        End If
        If NumericUpDown2.Value = 64 Then
            PictureBox32.Image = My.Resources.exp64
        End If
        If NumericUpDown2.Value = 65 Then
            PictureBox32.Image = My.Resources.exp65
        End If
        If NumericUpDown2.Value = 66 Then
            PictureBox32.Image = My.Resources.exp66
        End If
        If NumericUpDown2.Value = 67 Then
            PictureBox32.Image = My.Resources.exp67
        End If
        If NumericUpDown2.Value = 68 Then
            PictureBox32.Image = My.Resources.exp68
        End If
        If NumericUpDown2.Value = 69 Then
            PictureBox32.Image = My.Resources.exp69
        End If
        If NumericUpDown2.Value = 70 Then
            PictureBox32.Image = My.Resources.exp70
        End If
        If NumericUpDown2.Value = 71 Then
            PictureBox32.Image = My.Resources.exp71
        End If
        If NumericUpDown2.Value = 72 Then
            PictureBox32.Image = My.Resources.exp72
        End If
        If NumericUpDown2.Value = 73 Then
            PictureBox32.Image = My.Resources.exp73
        End If
        If NumericUpDown2.Value = 74 Then
            PictureBox32.Image = My.Resources.exp74
        End If
        If NumericUpDown2.Value = 75 Then
            PictureBox32.Image = My.Resources.exp75
        End If
        If NumericUpDown2.Value = 76 Then
            PictureBox32.Image = My.Resources.exp76
        End If
        If NumericUpDown2.Value = 77 Then
            PictureBox32.Image = My.Resources.exp77
        End If
        If NumericUpDown2.Value = 78 Then
            PictureBox32.Image = My.Resources.exp78
        End If
        If NumericUpDown2.Value = 79 Then
            PictureBox32.Image = My.Resources.exp79
        End If
        If NumericUpDown2.Value = 80 Then
            PictureBox32.Image = My.Resources.exp80
        End If
        If NumericUpDown2.Value = 81 Then
            PictureBox32.Image = My.Resources.exp81
        End If
        If NumericUpDown2.Value = 82 Then
            PictureBox32.Image = My.Resources.exp82
        End If
        If NumericUpDown2.Value = 83 Then
            PictureBox32.Image = My.Resources.exp83
        End If
        If NumericUpDown2.Value = 84 Then
            PictureBox32.Image = My.Resources.exp84
        End If
        If NumericUpDown2.Value = 85 Then
            PictureBox32.Image = My.Resources.exp85
        End If
        If NumericUpDown2.Value = 86 Then
            PictureBox32.Image = My.Resources.exp86
        End If
        If NumericUpDown2.Value = 87 Then
            PictureBox32.Image = My.Resources.exp87
        End If
        If NumericUpDown2.Value = 88 Then
            PictureBox32.Image = My.Resources.exp88
        End If
        If NumericUpDown2.Value = 89 Then
            PictureBox32.Image = My.Resources.exp89
        End If
        If NumericUpDown2.Value = 90 Then
            PictureBox32.Image = My.Resources.exp90
        End If
        If NumericUpDown2.Value = 91 Then
            PictureBox32.Image = My.Resources.exp91
        End If
        If NumericUpDown2.Value = 92 Then
            PictureBox32.Image = My.Resources.exp92
        End If
        If NumericUpDown2.Value = 93 Then
            PictureBox32.Image = My.Resources.exp93
        End If
        If NumericUpDown2.Value = 94 Then
            PictureBox32.Image = My.Resources.exp94
        End If
        If NumericUpDown2.Value = 95 Then
            PictureBox32.Image = My.Resources.exp95
        End If
        If NumericUpDown2.Value = 96 Then
            PictureBox32.Image = My.Resources.exp96
        End If
        If NumericUpDown2.Value = 97 Then
            PictureBox32.Image = My.Resources.exp97
        End If
        If NumericUpDown2.Value = 98 Then
            PictureBox32.Image = My.Resources.exp98
        End If
        If NumericUpDown2.Value = 99 Then
            PictureBox32.Image = My.Resources.exp99
        End If
    End Sub
End Class