Imports System
Imports System.Configuration
Imports System.Data

Public Module Config
    ' Token: 0x06000033 RID: 51 RVA: 0x00003CEC File Offset: 0x00001EEC
    Public Sub writeConfig(ByVal DS_Config As DataSet)
        Dim configuration As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim dataTable As DataTable = DS_Config.Tables(0)
        configuration.AppSettings.Settings.Clear()
        For Each obj As Object In dataTable.Rows
            Dim dataRow As DataRow = CType(obj, DataRow)
            configuration.AppSettings.Settings.Add(dataRow(0).ToString(), dataRow(1).ToString())
        Next
        configuration.Save(ConfigurationSaveMode.Modified)
        ConfigurationManager.RefreshSection("appSettings")
    End Sub

    ' Token: 0x06000034 RID: 52 RVA: 0x00003DB4 File Offset: 0x00001FB4
    Public Function editConfig(ByVal key As String, ByVal value As String) As Boolean
        Dim result As Boolean = False
        Dim configuration As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        Dim dataSet As DataSet = Config.ShowConfig()
        Dim dataTable As DataTable = dataSet.Tables(0)
        For Each obj As Object In dataTable.Rows
            Dim dataRow As DataRow = CType(obj, DataRow)
            If dataRow(0).ToString() = key Then
                dataRow(1) = value.ToString()
                configuration.AppSettings.Settings.Clear()
                For Each obj2 As Object In dataTable.Rows
                    Dim dataRow2 As DataRow = CType(obj2, DataRow)
                    configuration.AppSettings.Settings.Add(dataRow2(0).ToString(), dataRow2(1).ToString())
                Next
                configuration.Save(ConfigurationSaveMode.Modified)
                ConfigurationManager.RefreshSection("appSettings")
                result = True
            End If
        Next
        Return result
    End Function

    ' Token: 0x06000035 RID: 53 RVA: 0x00003F24 File Offset: 0x00002124
    Public Function ShowConfig() As DataSet
        Dim result As DataSet
        Try
            Dim dataSet As DataSet = New DataSet()
            Dim dataTable As DataTable = New DataTable()
            dataTable.Columns.Add("Setting", GetType(String))
            dataTable.Columns.Add("Value", GetType(String))
            For Each obj As Object In ConfigurationManager.AppSettings
                Dim text As String = CStr(obj)
                Dim text2 As String = ConfigurationManager.AppSettings(text)
                Dim dataRow As DataRow = dataTable.NewRow()
                dataRow("Setting") = text.ToString()
                dataRow("Value") = text2.ToString()
                dataTable.Rows.Add(dataRow)
            Next
            dataSet.Tables.Add(dataTable)
            result = dataSet
        Catch
            result = Nothing
        End Try
        Return result
    End Function
End Module
