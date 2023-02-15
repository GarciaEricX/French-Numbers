<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumbers
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
        Me.frmNumber1 = New System.Windows.Forms.Button()
        Me.frmNumber2 = New System.Windows.Forms.Button()
        Me.frmNumber3 = New System.Windows.Forms.Button()
        Me.frmNumber4 = New System.Windows.Forms.Button()
        Me.frmNumber5 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblFrench = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'frmNumber1
        '
        Me.frmNumber1.Location = New System.Drawing.Point(49, 111)
        Me.frmNumber1.Name = "frmNumber1"
        Me.frmNumber1.Size = New System.Drawing.Size(65, 37)
        Me.frmNumber1.TabIndex = 0
        Me.frmNumber1.Text = "1"
        Me.frmNumber1.UseVisualStyleBackColor = True
        '
        'frmNumber2
        '
        Me.frmNumber2.Location = New System.Drawing.Point(124, 111)
        Me.frmNumber2.Name = "frmNumber2"
        Me.frmNumber2.Size = New System.Drawing.Size(65, 37)
        Me.frmNumber2.TabIndex = 1
        Me.frmNumber2.Text = "2"
        Me.frmNumber2.UseVisualStyleBackColor = True
        '
        'frmNumber3
        '
        Me.frmNumber3.Location = New System.Drawing.Point(199, 111)
        Me.frmNumber3.Name = "frmNumber3"
        Me.frmNumber3.Size = New System.Drawing.Size(65, 37)
        Me.frmNumber3.TabIndex = 2
        Me.frmNumber3.Text = "3"
        Me.frmNumber3.UseVisualStyleBackColor = True
        '
        'frmNumber4
        '
        Me.frmNumber4.Location = New System.Drawing.Point(274, 111)
        Me.frmNumber4.Name = "frmNumber4"
        Me.frmNumber4.Size = New System.Drawing.Size(65, 37)
        Me.frmNumber4.TabIndex = 3
        Me.frmNumber4.Text = "4"
        Me.frmNumber4.UseVisualStyleBackColor = True
        '
        'frmNumber5
        '
        Me.frmNumber5.Location = New System.Drawing.Point(349, 111)
        Me.frmNumber5.Name = "frmNumber5"
        Me.frmNumber5.Size = New System.Drawing.Size(65, 37)
        Me.frmNumber5.TabIndex = 4
        Me.frmNumber5.Text = "5"
        Me.frmNumber5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Do you know the French words for the numbers"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(192, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "1 through 5?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(123, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(217, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Click the buttons below to see them."
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(199, 203)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(65, 37)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblFrench
        '
        Me.lblFrench.AutoSize = True
        Me.lblFrench.BackColor = System.Drawing.Color.PaleGreen
        Me.lblFrench.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblFrench.Location = New System.Drawing.Point(205, 170)
        Me.lblFrench.Name = "lblFrench"
        Me.lblFrench.Size = New System.Drawing.Size(52, 16)
        Me.lblFrench.TabIndex = 10
        Me.lblFrench.Text = "number"
        Me.lblFrench.Visible = False
        '
        'frmNumbers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 263)
        Me.Controls.Add(Me.lblFrench)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.frmNumber5)
        Me.Controls.Add(Me.frmNumber4)
        Me.Controls.Add(Me.frmNumber3)
        Me.Controls.Add(Me.frmNumber2)
        Me.Controls.Add(Me.frmNumber1)
        Me.Name = "frmNumbers"
        Me.Text = "French Numbers"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents frmNumber1 As Button
    Friend WithEvents frmNumber2 As Button
    Friend WithEvents frmNumber3 As Button
    Friend WithEvents frmNumber4 As Button
    Friend WithEvents frmNumber5 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents lblFrench As Label
End Class
