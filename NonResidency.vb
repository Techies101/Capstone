﻿Imports System.Data.OleDb
Imports Microsoft.Office.Interop.Word
Imports Word = Microsoft.Office.Interop.Word
Public Class NonResidency
    ReadOnly con As New OleDbConnection(My.Settings.strCon)

    Async Function InsertQuery() As Task(Of Integer)
        Dim dtFrmat As String = "MM/d/yyyy"
        Dim i As Integer
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If

        Using mycmd As New OleDbCommand("INSERT INTO tbl_nonresidency(FULLNAME,FULLADDRESS,DATEISSUED,FEES,ISSUEDAT) 
                                         VALUES(@FULLNAME, @FULLADDRESS,@DATEISSUED)", con)
            mycmd.Parameters.AddWithValue("FULLNAME", TxtName.Text)
            mycmd.Parameters.AddWithValue("FULLADDRESS", TxtAddress.Text)
            mycmd.Parameters.AddWithValue("DATEISSUED", DateTimePicker2.Value.ToString(dtFrmat))
            mycmd.Parameters.AddWithValue("FEES", TxtAmount.Text)
            mycmd.Parameters.AddWithValue("ISSUEDAT", Txtissued.Text)



            i = Await mycmd.ExecuteNonQueryAsync
        End Using
        Return i
    End Function

    Sub ResetTextField()
        TxtName.ResetText()
        TxtAddress.ResetText()
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
        Dim objWordApp = New Word.Application
        objWordApp.Visible = False
        Dim wdDoc As Word.Document = objWordApp.Documents.Open(sPath, [ReadOnly]:=False)
        wdDoc = objWordApp.ActiveDocument

        UpdateBookMark("name1", TxtName.Text.Trim, wdDoc)
        UpdateBookMark("address", TxtAddress.Text.Trim, wdDoc)
        UpdateBookMark("day", $"{DateTimePicker2.Value.Day.ToString()}th", wdDoc)
        UpdateBookMark("myear", $"{DateTimePicker2.Value.ToString("Y").ToUpper}", wdDoc)



        wdDoc.Save()
        wdDoc.Close()
        wdDoc = Nothing
        objWordApp.Quit()
        objWordApp = Nothing
    End Sub

    Private Async Sub BtnS_Click(sender As Object, e As EventArgs) Handles BtnS.Click
        If String.IsNullOrEmpty(TxtName.Text) Or String.IsNullOrEmpty(TxtAddress.Text) Then
            MessageBox.Show("There's blank field you need to fill out!", "Field Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Await InsertQuery()
            MessageBox.Show("Data successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            UpdateWordDocs("C:\Capstone\BSITCapstone\Docs\TempNonresidency.docx")
            ResetTextField()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        PrintPreview.checkLoad = "Non-Residency"
        PrintPreview.Show()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(BCHistory)
    End Sub


    Private Sub Txtissued_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtissued.KeyPress
        e.Handled = True
    End Sub

    Private Sub TxtAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAmount.KeyPress
        e.Handled = True
    End Sub
    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Dashboard.activefrm.Close()
        Dashboard.OpenFormChild(residents)
        residents.BtnUse.Visible = True
    End Sub
End Class