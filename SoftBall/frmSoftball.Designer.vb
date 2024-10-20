<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSoftball
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        lblHeading = New Label()
        btnScore = New Button()
        lblTotalFinalScore = New Label()
        lstScore = New ListBox()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(675, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuClear, mnuExit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "File"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(101, 22)
        mnuClear.Text = "Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(101, 22)
        mnuExit.Text = "Exit"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(165, 24)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(282, 33)
        lblHeading.TabIndex = 1
        lblHeading.Text = "Softball Scoreboard"
        ' 
        ' btnScore
        ' 
        btnScore.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnScore.ForeColor = Color.Gray
        btnScore.Location = New Point(232, 99)
        btnScore.Name = "btnScore"
        btnScore.Size = New Size(150, 34)
        btnScore.TabIndex = 2
        btnScore.Text = "Enter Score"
        btnScore.UseVisualStyleBackColor = True
        ' 
        ' lblTotalFinalScore
        ' 
        lblTotalFinalScore.AutoSize = True
        lblTotalFinalScore.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalFinalScore.ForeColor = Color.Gray
        lblTotalFinalScore.Location = New Point(165, 184)
        lblTotalFinalScore.Name = "lblTotalFinalScore"
        lblTotalFinalScore.Size = New Size(92, 29)
        lblTotalFinalScore.TabIndex = 3
        lblTotalFinalScore.Text = "Label1"
        lblTotalFinalScore.Visible = False
        ' 
        ' lstScore
        ' 
        lstScore.Font = New Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstScore.FormattingEnabled = True
        lstScore.ItemHeight = 19
        lstScore.Location = New Point(542, 114)
        lstScore.Name = "lstScore"
        lstScore.Size = New Size(41, 156)
        lstScore.TabIndex = 4
        ' 
        ' frmSoftball
        ' 
        AcceptButton = btnScore
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        BackgroundImage = My.Resources.Resources.Softball
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(675, 419)
        Controls.Add(lstScore)
        Controls.Add(lblTotalFinalScore)
        Controls.Add(btnScore)
        Controls.Add(lblHeading)
        Controls.Add(MenuStrip1)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        MainMenuStrip = MenuStrip1
        Name = "frmSoftball"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Softball Scoreboard"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnScore As Button
    Friend WithEvents lblTotalFinalScore As Label
    Friend WithEvents lstScore As ListBox

End Class
