
Imports System.IO

Public Class LoadTextFile

    '開啟檔案
    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click
        '篩選文字檔
        OpenFileDialog1.Filter = "(純文字檔案)|*.txt"
        OpenFileDialog1.FilterIndex = 1
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Title = "請選取純文字檔案"


        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dt.Rows.Clear()

            '將多個選取的檔案存入變數，並分批呼叫進datagridview
            For Each file As String In OpenFileDialog1.FileNames
                DataGridView1.Columns.Clear()

                For i = 0 To 13 Step 1
                    Dim NewColumn As New DataGridViewTextBoxColumn()
                    DataGridView1.Columns.Insert(i, NewColumn)
                Next

                If System.IO.File.Exists(file) = True Then
                    Dim txtReader As New System.IO.StreamReader(file)
                    Dim TextLine As String
                    Dim SplitLine() As String

                    Do While txtReader.Peek() <> -1
                        TextLine = txtReader.ReadLine()
                        SplitLine = Split(TextLine, " ")
                        DataGridView1.Rows.Add(SplitLine)
                    Loop

                    txtReader.Close()

                    For i = 85 To 0 Step -1
                        DataGridView1.Rows.RemoveAt(i)
                    Next

                    For i = 13 To 0 Step -1
                        If i < 8 Or i > 10 Then
                            DataGridView1.Columns.RemoveAt(i)
                        End If
                    Next

                    For i = DataGridView1.Rows.Count - 1 To 0 Step -1
                        If DataGridView1(0, i).Value = "" Then
                            DataGridView1.Rows.RemoveAt(i)
                        End If
                    Next

                    For i = 0 To DataGridView1.Rows.Count - 1 Step 1
                        Dim chr As Char() = New [Char]() {"_"}
                        Dim str As String() = DataGridView1(2, i).Value.Split(chr)

                        If DataGridView1(2, i).Value <> "" Then
                            DataGridView1(2, i).Value = str(0)
                        End If

                        Dt.Rows.Add(1)
                        Dim r As Integer = Dt.Rows.Count - 1
                        Dt(0, r).Value = DataGridView1(0, i).Value
                        Dt(1, r).Value = DataGridView1(1, i).Value
                        Dt(2, r).Value = DataGridView1(2, i).Value
                    Next

                End If
            Next

            '顯示選取檔案的總資料列數
            lblRowCount.Text = Dt.Rows.Count
        Else
            Exit Sub
        End If

    End Sub

End Class