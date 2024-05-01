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

    ' DB Methods/Functions
    Public Function ReadQuery(queryStr As String)
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
            Return 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
            Return 0
        End Try
    End Function


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
                    MessageBox.Show("Loan Record Transaction Added :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Else
                    MessageBox.Show("Loan Record Insertion Failed!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Public Sub InsertLoanType(queryStr As String())
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `loan_type`(`Loan_Type_ID`, `Name`, `Processing_Time`) VALUES (@Loan_Type_ID, @Name, @Processing_Time)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Loan_Type_ID", CInt(queryStr(0)))
                .Parameters.AddWithValue("@Name", queryStr(1))
                .Parameters.AddWithValue("@Processing_Time", queryStr(2))

                Dim rowsaffected = cmd.ExecuteNonQuery()
                If rowsaffected > 0 Then
                    MessageBox.Show("Loan Record Transaction Added :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Else
                    MessageBox.Show("Loan Record Insertion Failed!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Public Sub InsertCapitalSavings(queryStr As String())
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `capital_and_savings`(`Capital_Savings_ID`, `Transaction_Type`, `Amount`) VALUES (@Capital_Savings_ID, @Transaction_Type, @Amount)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Capital_Savings_ID", CInt(queryStr(0)))
                .Parameters.AddWithValue("@Transaction_Type", queryStr(1))
                .Parameters.AddWithValue("@Amount", queryStr(2))

                Dim rowsaffected = cmd.ExecuteNonQuery()
                If rowsaffected > 0 Then
                    MessageBox.Show("Capital/Savings Record Transaction Added :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Else
                    MessageBox.Show("Capital/Savings Record Insertion Failed!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    Public Sub InsertMembers(queryStr As String())
        Try
            With conn
                If .State = ConnectionState.Open Then .Close()
                .ConnectionString = strconn
                .Open()
            End With
            With cmd
                .Connection = conn
                .CommandText = "INSERT INTO `members`(`Member_ID`, `Fname`, `Mname`, `Lname`, `Dob`, `Sex`, `Address`, `Phone_Num`, `Occupation`, `Annual_Income`) VALUES (@Member_ID, @Fname, @Mname, @Lname, @Dob, @Sex, @Address, @Phone_Num, @Occupation, @Annual_Income)"
                .Parameters.Clear()
                .Parameters.AddWithValue("@Member_ID", CInt(queryStr(0)))
                .Parameters.AddWithValue("@Fname", queryStr(1))
                .Parameters.AddWithValue("@Mname", queryStr(2))
                .Parameters.AddWithValue("@Lname", queryStr(3))
                .Parameters.AddWithValue("@Dob", queryStr(4))
                .Parameters.AddWithValue("@Sex", queryStr(5))
                .Parameters.AddWithValue("@Address", queryStr(6))
                .Parameters.AddWithValue("@Phone_Num", queryStr(7))
                .Parameters.AddWithValue("@Occupation", queryStr(8))
                .Parameters.AddWithValue("@Annual_Income", CInt(queryStr(9)))

                Dim rowsaffected = cmd.ExecuteNonQuery()
                If rowsaffected > 0 Then
                    MessageBox.Show("Member Record Transaction Added :)", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
                Else
                    MessageBox.Show("Member Record Insertion Failed!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2)
        End Try
    End Sub

    'Utility Methods
    Public Function Generate7Id(tableName As String, pkName As String) As Integer
        Dim random As New Random()
        Dim IsExist As Boolean = True
        Dim num As Integer
        While IsExist
            num = random.Next(1000000, 9999999)
            ReadQuery("SELECT * FROM " & tableName & " WHERE " & pkName & "= '" & num & "'")
            If Not (cmdread Is Nothing) AndAlso cmdread.HasRows Then
                IsExist = True
            Else
                IsExist = False
            End If
        End While
        'msgbox("unique id generated, loop count: " & counter.tostring(), msgboxstyle.information, "information")
        Return num
    End Function

    Public Function Generate5Id(tableName As String, pkName As String) As Integer
        Dim random As New Random()
        Dim IsExist As Boolean = True
        Dim num As Integer
        While IsExist
            num = random.Next(10000, 99999)
            ReadQuery("SELECT * FROM " & tableName & " WHERE " & pkName & "= '" & num & "'")
            If Not (cmdread Is Nothing) AndAlso cmdread.HasRows Then
                IsExist = True
            Else
                IsExist = False
            End If
        End While
        'MsgBox("Unique ID Generated, Loop Count: " & counter.ToString(), MsgBoxStyle.Information, "Information")
        Return num
    End Function



End Module
