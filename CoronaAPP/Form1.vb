Imports System.IO
Imports System.Net
Imports Nancy.Json
Imports Nancy.Json.Simple

Public Class Form1
    Dim landen As New ArrayList
    Dim datums As New ArrayList
    Dim dict As Object

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadCoronaData()
    End Sub
    Private Sub cboLand_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLand.SelectedIndexChanged
        Dim landNaam As String = cboLand.SelectedItem
        txtData.Clear()
        cboDatums.Items.Clear()
        cboDatums.ResetText()
        cboDatums.Visible = True

        For Each item As Object In dict
            If item("country").ToString = landNaam Then
                Dim data As JsonArray = item("data")
                Dim array As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(data.ToString)
                For Each it As Object In array
                    cboDatums.Items.Add(it("date"))
                Next
                Return
            End If
        Next
    End Sub
    Private Sub cboDatums_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDatums.SelectedIndexChanged
        Dim datum As String = cboDatums.SelectedItem.ToString
        Dim land As String = cboLand.SelectedItem.ToString
        txtData.Clear()
        txtData.Text = datum.PadLeft(txtData.Width / 5 - 20, " ") & vbNewLine
        For Each item As Object In dict
            If item("country").ToString = land Then
                Dim data As JsonArray = item("data")
                Dim array As Object = New JavaScriptSerializer().Deserialize(Of List(Of Object))(data.ToString)
                For Each it As Object In array
                    If it("date") = datum Then
                        Try
                            txtData.Text &= $"Total Vaccinations: {it("total_vaccinations")}{vbCrLf}"
                        Catch ex As Exception
                        End Try
                        Try
                            txtData.Text &= $"People Vaccinated: {it("people_vaccinated")}{vbCrLf}"
                        Catch ex As Exception
                        End Try
                        Try
                            txtData.Text &= $"Daily Vaccinations: {it("daily_vaccinations")}{vbCrLf}"
                        Catch ex As Exception
                        End Try
                        Try
                            txtData.Text &= $"Total Vaccinations Per 100: {it("total_vaccinations_per_hundred")}{vbCrLf}"
                        Catch ex As Exception
                        End Try
                        Try
                            txtData.Text &= $"People Vaccinated Per 100: {it("people_vaccinated_per_hundred")}{vbCrLf}"
                        Catch ex As Exception
                        End Try
                        Try
                            txtData.Text &= $"Daily Vaccinations Per Million: {it("daily_vaccinations_per_million")}{vbCrLf}"
                        Catch ex As Exception
                        End Try
                        Return
                    End If
                Next
            End If
        Next
    End Sub
    Sub loadCoronaData()
        clearAllData()

        Dim uriString As String = "https://raw.githubusercontent.com/owid/covid-19-data/master/public/data/vaccinations/vaccinations.json"
        Dim uri As New Uri(uriString)

        Dim Request As HttpWebRequest = HttpWebRequest.Create(uri)
        Request.Method = "GET"

        Dim Response As HttpWebResponse = Request.GetResponse()

        Dim Read = New StreamReader(Response.GetResponseStream())
        Dim Raw As String = Read.ReadToEnd()

        dict = New JavaScriptSerializer().Deserialize(Of List(Of Object))(Raw)

        For Each item As Object In dict
            landen.Add(item("country").ToString)
        Next
        fillLanden(landen)
    End Sub
    Sub clearAllData()
        cboLand.ResetText()
        txtData.Clear()
        landen.Clear()
        datums.Clear()
        cboLand.Items.Clear()
        cboDatums.Items.Clear()
        cboDatums.ResetText()
        cboDatums.Visible = False
    End Sub
    Sub fillLanden(ByVal array As ArrayList)
        For i = 0 To array.Count - 1
            cboLand.Items.Add(array(i))
        Next
    End Sub
    Sub fillDatumsLand(ByVal array As ArrayList)
        For i = 0 To array.Count - 1
            cboDatums.Items.Add(array(i))
        Next
        cboDatums.Visible = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnHerlezen_Click(sender As Object, e As EventArgs) Handles btnHerlezen.Click
        clearAllData()
        loadCoronaData()
    End Sub
End Class
