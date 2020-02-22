Imports System.IO

Public Class MainActivity
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        nameBox.Text = ""
        ageBox.Text = ""
        addrBox.Text = ""
    End Sub

    Private Sub btnTxt_click(sender As Object, e As EventArgs) Handles btnTxt.Click
        Dim desktop_path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file_path As String = desktop_path + "\output.txt"
        Dim objWriter As New StreamWriter(file_path)

        objWriter.Write("Name: " + nameBox.Text + Environment.NewLine + "Age: " + ageBox.Text + Environment.NewLine + "Address: " + addrBox.Text)
        objWriter.Close()
        MessageBox.Show("File Created on Desktop: output.txt")
    End Sub

    Private Sub btnXml_click(sender As Object, e As EventArgs) Handles btnXml.Click
        Dim desktop_path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file_path As String = desktop_path + "\output.xml"
        Dim objWriter As New StreamWriter(file_path)

        objWriter.Write("<?xml version=""1.0""?>" + Environment.NewLine + "<name>" + nameBox.Text + "</name>" + Environment.NewLine + "<age>" + ageBox.Text + "</age>" + Environment.NewLine + "<address>" + addrBox.Text + "</address>")
        objWriter.Close()
        MessageBox.Show("File Created on Desktop: output.xml")
    End Sub

    Private Sub btnJson_click(sender As Object, e As EventArgs) Handles btnJson.Click
        Dim desktop_path As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        Dim file_path As String = desktop_path + "\output.json"
        Dim objWriter As New StreamWriter(file_path)

        objWriter.Write("[" + Environment.NewLine + "{" + Environment.NewLine + """name"": """ + nameBox.Text + """," + Environment.NewLine + """age"": " + ageBox.Text + "," + Environment.NewLine + """address"": """ + addrBox.Text + """" + Environment.NewLine + "}" + Environment.NewLine + "]")
        objWriter.Close()
        MessageBox.Show("File Created on Desktop: output.json")
    End Sub
End Class
