Namespace Helpers
    Public Module SqlHelper
        ' Auto-create INSERT query dan parameter binding
        Public Function CreateInsertCommand(
            tableName As String,
            fields As Dictionary(Of String, Object),
            conn As IDbConnection) As IDbCommand

            Dim columns As String = String.Join(", ", fields.Keys)
            Dim placeholders As String = String.Join(", ", fields.Keys.Select(Function(k) "@" & k))
            Dim sql As String = $"INSERT INTO {tableName} ({columns}) VALUES ({placeholders})"


            Dim cmd = conn.CreateCommand()
            cmd.CommandText = sql

            For Each pair In fields
                Dim param = cmd.CreateParameter()
                param.ParameterName = "@" & pair.Key
                param.Value = pair.Value
                cmd.Parameters.Add(param)
            Next

            'Dim cmd As New MySqlCommand(sql, conn)
            'For Each pair In fields
            '    cmd.Parameters.AddWithValue("@" & pair.Key, pair.Value)
            'Next

            Return cmd
        End Function

        ' Auto-create UPDATE query dan parameter binding
        Public Function CreateUpdateCommand(
            tableName As String,
            fields As Dictionary(Of String, Object),
            keyField As String,
            keyValue As String,
            conn As IDbConnection,
            Optional excludedFields As List(Of String) = Nothing) As IDbCommand

            ' Filter out excluded fields (e.g., "id")
            Dim filteredFields = If(excludedFields IsNot Nothing,
                fields.Where(Function(p) Not excludedFields.Contains(p.Key)).ToDictionary(Function(p) p.Key, Function(p) p.Value), fields)

            Dim setClause As String = String.Join(", ", filteredFields.Keys.Select(Function(k) $"{k}=@{k}"))
            Dim sql As String = $"UPDATE {tableName} SET {setClause} WHERE {keyField}=@{keyField}"

            Dim cmd = conn.CreateCommand()
            cmd.CommandText = sql

            ' Tambah semua param field
            For Each pair In filteredFields
                Dim param = cmd.CreateParameter()
                param.ParameterName = "@" & pair.Key
                param.Value = pair.Value
                cmd.Parameters.Add(param)
            Next

            ' Tambah param kunci
            Dim keyParam = cmd.CreateParameter()
            keyParam.ParameterName = "@" & keyField
            keyParam.Value = keyValue
            cmd.Parameters.Add(keyParam)

            'Dim cmd As New MySqlCommand(sql, conn)
            'For Each pair In filteredFields
            '    cmd.Parameters.AddWithValue("@" & pair.Key, pair.Value)
            'Next
            'cmd.Parameters.AddWithValue("@" & keyField, keyValue)

            Return cmd
        End Function

        ' Auto-create DELETE query dan parameter binding
        Public Function CreateDeleteCommand(
            tableName As String,
            keyField As String,
            keyValue As Object,
            conn As IDbConnection) As IDbCommand

            Dim sql As String = $"DELETE FROM {tableName} WHERE {keyField}=@{keyField}"
            'Dim cmd As New MySqlCommand(sql, conn)
            'cmd.Parameters.AddWithValue("?", keyValue)

            Dim cmd = conn.CreateCommand()
            cmd.CommandText = sql

            Dim param = cmd.CreateParameter()
            param.ParameterName = "@" & keyField
            param.Value = keyValue
            cmd.Parameters.Add(param)

            Return cmd
        End Function

        ' Auto-create SELECT ALL query
        Public Function CreateSelectAllCommand(
            tableName As String,
            conn As IDbConnection,
            Optional orderBy As String = Nothing,
            Optional sortDirection As String = "ASC") As IDbCommand

            Dim sql As String = $"SELECT * FROM {tableName}"

            If Not String.IsNullOrWhiteSpace(orderBy) Then
                ' Sort direction validation
                Dim direction = If(sortDirection.ToUpper() = "DESC", "DESC", "ASC")
                sql &= $" ORDER BY {orderBy} {direction}"
            End If

            Dim cmd = conn.CreateCommand()
            cmd.CommandText = sql

            Return cmd
        End Function

        ' Auto-create SELECT BY ID query dan parameter binding
        Public Function CreateSelectByIdCommand(
            tableName As String,
            keyField As String,
            keyValue As Object,
            conn As IDbConnection) As IDbCommand

            Dim sql = $"SELECT * FROM {tableName} WHERE {keyField}=@{keyField}"
            'Dim cmd As New MySqlCommand(sql, conn)
            'cmd.Parameters.AddWithValue("?", keyValue)

            Dim cmd = conn.CreateCommand()
            cmd.CommandText = sql

            Dim param = cmd.CreateParameter()
            param.ParameterName = "@" & keyField
            param.Value = keyValue
            cmd.Parameters.Add(param)

            Return cmd
        End Function
    End Module
End Namespace
