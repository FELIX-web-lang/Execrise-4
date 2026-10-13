<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTotalExpenses = New System.Windows.Forms.Label()
        Me.lblTakeHome = New System.Windows.Forms.Label()
        Me.lblNSSF = New System.Windows.Forms.Label()
        Me.lblPAYE = New System.Windows.Forms.Label()
        Me.lblBalanceAfterDeduction = New System.Windows.Forms.Label()
        Me.lblSACCO = New System.Windows.Forms.Label()
        Me.txtTotalExpenses = New System.Windows.Forms.TextBox()
        Me.txtPAYE = New System.Windows.Forms.TextBox()
        Me.txtNSSF = New System.Windows.Forms.TextBox()
        Me.txtTakeHome = New System.Windows.Forms.TextBox()
        Me.txtSACCO = New System.Windows.Forms.TextBox()
        Me.txtBalanceAfterDeduction = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnCalculateFees = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTotalExpenses
        '
        Me.lblTotalExpenses.AutoSize = True
        Me.lblTotalExpenses.Location = New System.Drawing.Point(88, 77)
        Me.lblTotalExpenses.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotalExpenses.Name = "lblTotalExpenses"
        Me.lblTotalExpenses.Size = New System.Drawing.Size(148, 25)
        Me.lblTotalExpenses.TabIndex = 0
        Me.lblTotalExpenses.Text = "Total Expenses"
        '
        'lblTakeHome
        '
        Me.lblTakeHome.AutoSize = True
        Me.lblTakeHome.Location = New System.Drawing.Point(88, 148)
        Me.lblTakeHome.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTakeHome.Name = "lblTakeHome"
        Me.lblTakeHome.Size = New System.Drawing.Size(114, 25)
        Me.lblTakeHome.TabIndex = 1
        Me.lblTakeHome.Text = "Take Home"
        '
        'lblNSSF
        '
        Me.lblNSSF.AutoSize = True
        Me.lblNSSF.Location = New System.Drawing.Point(88, 285)
        Me.lblNSSF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNSSF.Name = "lblNSSF"
        Me.lblNSSF.Size = New System.Drawing.Size(66, 25)
        Me.lblNSSF.TabIndex = 2
        Me.lblNSSF.Text = "NSSF"
        '
        'lblPAYE
        '
        Me.lblPAYE.AutoSize = True
        Me.lblPAYE.Location = New System.Drawing.Point(88, 364)
        Me.lblPAYE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPAYE.Name = "lblPAYE"
        Me.lblPAYE.Size = New System.Drawing.Size(65, 25)
        Me.lblPAYE.TabIndex = 3
        Me.lblPAYE.Text = "PAYE"
        '
        'lblBalanceAfterDeduction
        '
        Me.lblBalanceAfterDeduction.AutoSize = True
        Me.lblBalanceAfterDeduction.Location = New System.Drawing.Point(88, 528)
        Me.lblBalanceAfterDeduction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBalanceAfterDeduction.Name = "lblBalanceAfterDeduction"
        Me.lblBalanceAfterDeduction.Size = New System.Drawing.Size(222, 25)
        Me.lblBalanceAfterDeduction.TabIndex = 4
        Me.lblBalanceAfterDeduction.Text = "Balance After Deduction"
        '
        'lblSACCO
        '
        Me.lblSACCO.AutoSize = True
        Me.lblSACCO.Location = New System.Drawing.Point(88, 451)
        Me.lblSACCO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSACCO.Name = "lblSACCO"
        Me.lblSACCO.Size = New System.Drawing.Size(86, 25)
        Me.lblSACCO.TabIndex = 5
        Me.lblSACCO.Text = "SACCO"
        '
        'txtTotalExpenses
        '
        Me.txtTotalExpenses.Location = New System.Drawing.Point(362, 69)
        Me.txtTotalExpenses.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTotalExpenses.Name = "txtTotalExpenses"
        Me.txtTotalExpenses.Size = New System.Drawing.Size(354, 30)
        Me.txtTotalExpenses.TabIndex = 6
        '
        'txtPAYE
        '
        Me.txtPAYE.Location = New System.Drawing.Point(362, 361)
        Me.txtPAYE.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPAYE.Name = "txtPAYE"
        Me.txtPAYE.Size = New System.Drawing.Size(354, 30)
        Me.txtPAYE.TabIndex = 7
        '
        'txtNSSF
        '
        Me.txtNSSF.Location = New System.Drawing.Point(362, 280)
        Me.txtNSSF.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNSSF.Name = "txtNSSF"
        Me.txtNSSF.Size = New System.Drawing.Size(354, 30)
        Me.txtNSSF.TabIndex = 8
        '
        'txtTakeHome
        '
        Me.txtTakeHome.Location = New System.Drawing.Point(362, 141)
        Me.txtTakeHome.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTakeHome.Name = "txtTakeHome"
        Me.txtTakeHome.Size = New System.Drawing.Size(354, 30)
        Me.txtTakeHome.TabIndex = 9
        '
        'txtSACCO
        '
        Me.txtSACCO.Location = New System.Drawing.Point(362, 435)
        Me.txtSACCO.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSACCO.Name = "txtSACCO"
        Me.txtSACCO.Size = New System.Drawing.Size(354, 30)
        Me.txtSACCO.TabIndex = 10
        '
        'txtBalanceAfterDeduction
        '
        Me.txtBalanceAfterDeduction.Location = New System.Drawing.Point(362, 528)
        Me.txtBalanceAfterDeduction.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBalanceAfterDeduction.Name = "txtBalanceAfterDeduction"
        Me.txtBalanceAfterDeduction.Size = New System.Drawing.Size(354, 30)
        Me.txtBalanceAfterDeduction.TabIndex = 11
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(189, 654)
        Me.btnCalculate.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(192, 48)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate "
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnCalculateFees
        '
        Me.btnCalculateFees.Location = New System.Drawing.Point(157, 210)
        Me.btnCalculateFees.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCalculateFees.Name = "btnCalculateFees"
        Me.btnCalculateFees.Size = New System.Drawing.Size(192, 48)
        Me.btnCalculateFees.TabIndex = 13
        Me.btnCalculateFees.Text = "Calculate Fees"
        Me.btnCalculateFees.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 792)
        Me.Controls.Add(Me.btnCalculateFees)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtBalanceAfterDeduction)
        Me.Controls.Add(Me.txtSACCO)
        Me.Controls.Add(Me.txtTakeHome)
        Me.Controls.Add(Me.txtNSSF)
        Me.Controls.Add(Me.txtPAYE)
        Me.Controls.Add(Me.txtTotalExpenses)
        Me.Controls.Add(Me.lblSACCO)
        Me.Controls.Add(Me.lblBalanceAfterDeduction)
        Me.Controls.Add(Me.lblPAYE)
        Me.Controls.Add(Me.lblNSSF)
        Me.Controls.Add(Me.lblTakeHome)
        Me.Controls.Add(Me.lblTotalExpenses)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTotalExpenses As System.Windows.Forms.Label
    Friend WithEvents lblTakeHome As System.Windows.Forms.Label
    Friend WithEvents lblNSSF As System.Windows.Forms.Label
    Friend WithEvents lblPAYE As System.Windows.Forms.Label
    Friend WithEvents lblBalanceAfterDeduction As System.Windows.Forms.Label
    Friend WithEvents lblSACCO As System.Windows.Forms.Label
    Friend WithEvents txtTotalExpenses As System.Windows.Forms.TextBox
    Friend WithEvents txtPAYE As System.Windows.Forms.TextBox
    Friend WithEvents txtNSSF As System.Windows.Forms.TextBox
    Friend WithEvents txtTakeHome As System.Windows.Forms.TextBox
    Friend WithEvents txtSACCO As System.Windows.Forms.TextBox
    Friend WithEvents txtBalanceAfterDeduction As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnCalculateFees As System.Windows.Forms.Button

End Class
