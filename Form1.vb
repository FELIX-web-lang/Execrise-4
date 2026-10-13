Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCALCULATE.Click


        ' Declare variables
        Dim salary As Double = 2300000
        Dim dependents As Integer = 4
        Dim schoolFees As Double = 430000

        Dim TOTAL_EXPENSES As Double
        Dim TAKEHOME As Double
        Dim NSSF As Double
        Dim PAYE As Double
        Dim SACCO As Double
        Dim BALANCEAFTERDEDUCTION As Double

        ' Calculate total expenses
        TOTAL_EXPENSES = dependents * schoolFees

        ' Calculate take-home balance
        TAKEHOME = salary - TOTAL_EXPENSES

        ' Calculate deductions
        NSSF = salary * 0.1
        PAYE = salary * 0.09
        SACCO = salary * 0.05

        ' Calculate balance after deductions
        BALANCEAFTERDEDUCTION = salary - (NSSF + PAYE + SACCO)

        ' Display results in text boxes
        txtTOTALEXPENSES.Text = TOTAL_EXPENSES.ToString("N0")
        txtTAKEHOME.Text = TAKEHOME.ToString("N0")
        txtNSSF.Text = NSSF.ToString("N0")
        txtPAYE.Text = PAYE.ToString("N0")
        txtSACCO.Text = SACCO.ToString("N0")
        txtBALANCEAFTERDEDUCTION.Text = BALANCEAFTERDEDUCTION.ToString("N0")

    End Sub

End Class