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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboSelectMonth = New System.Windows.Forms.ComboBox()
        Me.btnStatistics = New System.Windows.Forms.Button()
        Me.lblSavings = New System.Windows.Forms.Label()
        Me.lblMonthlySavings = New System.Windows.Forms.Label()
        Me.lblMostSavings = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(373, 261)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Magic R", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Label1.Location = New System.Drawing.Point(459, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Smart Home " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        '
        'cboSelectMonth
        '
        Me.cboSelectMonth.Font = New System.Drawing.Font("Magic R", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.cboSelectMonth.FormattingEnabled = True
        Me.cboSelectMonth.Location = New System.Drawing.Point(463, 87)
        Me.cboSelectMonth.Name = "cboSelectMonth"
        Me.cboSelectMonth.Size = New System.Drawing.Size(178, 28)
        Me.cboSelectMonth.TabIndex = 2
        Me.cboSelectMonth.Text = "January"
        '
        'btnStatistics
        '
        Me.btnStatistics.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnStatistics.Font = New System.Drawing.Font("Magic R", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnStatistics.Location = New System.Drawing.Point(246, 309)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(278, 36)
        Me.btnStatistics.TabIndex = 3
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = False
        '
        'lblSavings
        '
        Me.lblSavings.AutoSize = True
        Me.lblSavings.Font = New System.Drawing.Font("Magic R", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblSavings.Location = New System.Drawing.Point(177, 274)
        Me.lblSavings.Name = "lblSavings"
        Me.lblSavings.Size = New System.Drawing.Size(0, 17)
        Me.lblSavings.TabIndex = 4
        '
        'lblMonthlySavings
        '
        Me.lblMonthlySavings.AutoSize = True
        Me.lblMonthlySavings.Font = New System.Drawing.Font("Magic R", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblMonthlySavings.Location = New System.Drawing.Point(177, 346)
        Me.lblMonthlySavings.Name = "lblMonthlySavings"
        Me.lblMonthlySavings.Size = New System.Drawing.Size(0, 17)
        Me.lblMonthlySavings.TabIndex = 5
        '
        'lblMostSavings
        '
        Me.lblMostSavings.AutoSize = True
        Me.lblMostSavings.Font = New System.Drawing.Font("Magic R", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.lblMostSavings.Location = New System.Drawing.Point(233, 386)
        Me.lblMostSavings.Name = "lblMostSavings"
        Me.lblMostSavings.Size = New System.Drawing.Size(0, 17)
        Me.lblMostSavings.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMostSavings)
        Me.Controls.Add(Me.lblMonthlySavings)
        Me.Controls.Add(Me.lblSavings)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.cboSelectMonth)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Smart Home Application"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboSelectMonth As ComboBox
    Friend WithEvents btnStatistics As Button
    Friend WithEvents lblSavings As Label
    Friend WithEvents lblMonthlySavings As Label
    Friend WithEvents lblMostSavings As Label
End Class
