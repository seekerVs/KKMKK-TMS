Imports System.Diagnostics.Metrics
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Module Module1

    Public conn As New MySqlConnection
    Public cmd As New MySqlCommand
    Public cmdread As MySqlDataReader
    Public db_server = "'localhost'" ' server name
    Public db_port = "'3307'" 'port
    Public db_uid = "'root'" ' user id
    Public db_pwd = "''" ' password
    Public db_name = "'kkmkk_tms'" ' database name
    Public strconn As String = "server= " & db_server & "; port=" & db_port & "; userid=" & db_uid & ";password=" & db_pwd & "; database=" & db_name & ";"

    ' DB Methods
    Public Sub ReadQuery(queryStr As String)
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = queryStr
                cmdread = .ExecuteReader
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    Public Sub InsertLoan(queryStr As String())
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `loans`(`Loan_ID`, `Transaction_Type`, `Amount`) VALUES (@Loan_ID, @Transaction_Type, @Amount)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Loan_ID", CInt(queryStr(0)))
                .Parameters.AddWithValue("@Transaction_Type", queryStr(1))
                .Parameters.AddWithValue("@Amount", CInt(queryStr(2)))

                Dim rowsaffected = cmd.ExecuteNonQuery()
                If rowsaffected > 0 Then
                    MsgBox("Record Transaction Added :)", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Else
                    MsgBox("Record Insertion Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub


    'Utility Methods
    Public Function Generate7Id() As Integer
        Dim random As New Random()
        Dim IsExist As Boolean = True
        Dim num As Integer
        'Dim counter As Integer
        While IsExist
            num = random.Next(1000000, 9999999)
            ReadQuery("SELECT * FROM loans WHERE Loan_ID='" & num & "'")
            If Not (cmdread Is Nothing) AndAlso cmdread.HasRows Then
                IsExist = True
            Else
                IsExist = False
            End If
            'Counter += 1
        End While
        'msgbox("unique id generated, loop count: " & counter.tostring(), msgboxstyle.information, "information")
        Return num
    End Function

    Public Function Generate5Id() As Integer
        Dim random As New Random()
        Dim IsExist As Boolean = True
        Dim num As Integer
        'Dim counter As Integer
        While IsExist
            num = random.Next(10000, 99999)
            ReadQuery("SELECT * FROM loans WHERE Loan_ID='" & num & "'")
            If Not (cmdread Is Nothing) AndAlso cmdread.HasRows Then
                IsExist = True
            Else
                IsExist = False
            End If
            'counter += 1
        End While
        'MsgBox("Unique ID Generated, Loop Count: " & counter.ToString(), MsgBoxStyle.Information, "Information")
        Return num
    End Function



End Module
