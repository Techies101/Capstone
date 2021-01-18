﻿Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class Spes

    ReadOnly con As New OleDbConnection(My.Settings.strCon)
    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Or String.IsNullOrEmpty(TxtFather.Text) Or String.IsNullOrEmpty(TxtMother.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If BtnS.Text = "SAVE" Then
            Try
                Await InsertQuery()
                MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempSpes.docx")
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            Try
                Await UpdateQuery()
                MessageBox.Show("Update successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
                UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempSpes.docx")
                ResetTextField()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
    Async Function InsertQuery() As Task(Of Integer)
        Dim dtFrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_spes(FULLNAME,FULLADDRESS, FATHERNAME, MOTHERNAME, FATHEROCCU, MOTHEROCCU, DATEISSUED) 
                                         VALUES(@FULLNAME, @FULLADDRESS, @FATHERNAME, @MOTHERNAME, @FATHEROCCU, @MOTHEROCCU, DATEISSUED)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("FATHERNAME", TxtFather.Text)
            mycmd.Parameters.AddWithValue("MOTHERNAME", TxtMother.Text)
            mycmd.Parameters.AddWithValue("FATHEROCCU", TxtOccu.Text)
            mycmd.Parameters.AddWithValue("MOTHEROCCU", TxtOccu1.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtFrmat))


            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Async Function UpdateQuery() As Task(Of Integer)
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("UPDATE tbl_spes
                                         SET FULLNAME= '" & TxtName.Text & "',
                                             FULLADDRESS= '" & TxtAddress.Text & "',
                                             FATHERNAME= '" & TxtFather.Text & "',
                                             MOTHERNAME= '" & TxtMother.Text & "',
                                             FATHEROCCU='" & TxtOccu.Text & "',
                                             MOTHEROCCU= '" & TxtOccu1.Text & "',
                                             DATEISSUED= '" & DateTimePicker2.Value & "'
                                         WHERE ID=@ID", con)
            mycmd.Parameters.AddWithValue("ID", BCHistory.id)

            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Sub ResetTextField()
        TxtName.ResetText()
        TxtAddress.ResetText()
        TxtFather.ResetText()
        TxtMother.ResetText()
        TxtOccu.ResetText()
        TxtOccu1.ResetText()
    End Sub

    Public Sub UpdateBookMark(BookmarkUpdate As String, TextToUse As String, WordApp As Object)

        Dim BMRange As Range
        BMRange = WordApp.Bookmarks(BookmarkUpdate).Range
        BMRange.Text = TextToUse
        WordApp.Bookmarks.Add(BookmarkUpdate, BMRange)

    End Sub

    Private Sub UpdateWordDocs(sPath As String)
        Dim dtFormat As String = "MM/d/yyyy"
        Dim monthFrmat As String = "MMMM"
        Dim objWordApp = New Word.Application With {
            .Visible = False
        }
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("name", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("name1", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("address", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("fathername", TxtFather.Text.Trim, wdDoc)
        UpdateBookMark("guardian", TxtFather.Text.Trim, wdDoc)
        UpdateBookMark("mothername", TxtMother.Text.Trim, wdDoc)
        UpdateBookMark("fatheroccupation", TxtOccu.Text.Trim, wdDoc)
        UpdateBookMark("motheroccupation", TxtOccu1.Text.Trim, wdDoc)
        UpdateBookMark("day", $"{DateTimePicker2.Value.Day}th", wdDoc)
        UpdateBookMark("myear", $"{DateTimePicker2.Value.ToString("Y").ToUpper}", wdDoc)



        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "SPES"
        PrintPreview.Show()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(residents)
        residents.BtnUse.Visible = True
    End Sub

    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtFather_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtFather.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TxtMother_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMother.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        If BCHistory.catTitle = "SPES" Then
            BCHistory.LoadSpes()
        End If
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub


End Class