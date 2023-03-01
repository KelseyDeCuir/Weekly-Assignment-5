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
        Me.picComic = New System.Windows.Forms.PictureBox()
        Me.lblComicConvention = New System.Windows.Forms.Label()
        Me.lblGroup = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.gpbBadge = New System.Windows.Forms.GroupBox()
        Me.radSuperhero = New System.Windows.Forms.RadioButton()
        Me.radAutographs = New System.Windows.Forms.RadioButton()
        Me.radConvention = New System.Windows.Forms.RadioButton()
        Me.lblRegistration = New System.Windows.Forms.Label()
        Me.lblCostTickets = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbBadge.SuspendLayout()
        Me.SuspendLayout()
        '
        'picComic
        '
        Me.picComic.Image = Global.Weekly_Assignment_5.My.Resources.Resources.comic
        Me.picComic.Location = New System.Drawing.Point(-3, 0)
        Me.picComic.Name = "picComic"
        Me.picComic.Size = New System.Drawing.Size(648, 144)
        Me.picComic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picComic.TabIndex = 0
        Me.picComic.TabStop = False
        '
        'lblComicConvention
        '
        Me.lblComicConvention.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComicConvention.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblComicConvention.Location = New System.Drawing.Point(100, 161)
        Me.lblComicConvention.Name = "lblComicConvention"
        Me.lblComicConvention.Size = New System.Drawing.Size(451, 43)
        Me.lblComicConvention.TabIndex = 1
        Me.lblComicConvention.Text = "Comic Convention Registration"
        Me.lblComicConvention.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblGroup
        '
        Me.lblGroup.Font = New System.Drawing.Font("Constantia", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblGroup.Location = New System.Drawing.Point(192, 218)
        Me.lblGroup.Name = "lblGroup"
        Me.lblGroup.Size = New System.Drawing.Size(145, 32)
        Me.lblGroup.TabIndex = 2
        Me.lblGroup.Text = "Group Size:"
        Me.lblGroup.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtGroup
        '
        Me.txtGroup.Font = New System.Drawing.Font("Constantia", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txtGroup.ForeColor = System.Drawing.Color.OrangeRed
        Me.txtGroup.Location = New System.Drawing.Point(356, 218)
        Me.txtGroup.Multiline = True
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.Size = New System.Drawing.Size(50, 30)
        Me.txtGroup.TabIndex = 3
        Me.txtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'gpbBadge
        '
        Me.gpbBadge.BackColor = System.Drawing.Color.Turquoise
        Me.gpbBadge.Controls.Add(Me.radConvention)
        Me.gpbBadge.Controls.Add(Me.radAutographs)
        Me.gpbBadge.Controls.Add(Me.radSuperhero)
        Me.gpbBadge.Font = New System.Drawing.Font("Constantia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbBadge.ForeColor = System.Drawing.Color.OrangeRed
        Me.gpbBadge.Location = New System.Drawing.Point(150, 266)
        Me.gpbBadge.Name = "gpbBadge"
        Me.gpbBadge.Size = New System.Drawing.Size(355, 115)
        Me.gpbBadge.TabIndex = 4
        Me.gpbBadge.TabStop = False
        Me.gpbBadge.Text = "Select Badge Type: "
        '
        'radSuperhero
        '
        Me.radSuperhero.Location = New System.Drawing.Point(53, 26)
        Me.radSuperhero.Name = "radSuperhero"
        Me.radSuperhero.Size = New System.Drawing.Size(306, 23)
        Me.radSuperhero.TabIndex = 0
        Me.radSuperhero.TabStop = True
        Me.radSuperhero.Text = "Convention + Superhero Experience"
        Me.radSuperhero.UseVisualStyleBackColor = True
        '
        'radAutographs
        '
        Me.radAutographs.Location = New System.Drawing.Point(53, 55)
        Me.radAutographs.Name = "radAutographs"
        Me.radAutographs.Size = New System.Drawing.Size(222, 23)
        Me.radAutographs.TabIndex = 1
        Me.radAutographs.TabStop = True
        Me.radAutographs.Text = "Convention + Autographs"
        Me.radAutographs.UseVisualStyleBackColor = True
        '
        'radConvention
        '
        Me.radConvention.Location = New System.Drawing.Point(53, 84)
        Me.radConvention.Name = "radConvention"
        Me.radConvention.Size = New System.Drawing.Size(133, 24)
        Me.radConvention.TabIndex = 2
        Me.radConvention.TabStop = True
        Me.radConvention.Text = "Convention"
        Me.radConvention.UseVisualStyleBackColor = True
        '
        'lblRegistration
        '
        Me.lblRegistration.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistration.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblRegistration.Location = New System.Drawing.Point(157, 432)
        Me.lblRegistration.Name = "lblRegistration"
        Me.lblRegistration.Size = New System.Drawing.Size(215, 23)
        Me.lblRegistration.TabIndex = 5
        Me.lblRegistration.Text = "Registration Cost:"
        Me.lblRegistration.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblCostTickets
        '
        Me.lblCostTickets.Font = New System.Drawing.Font("Constantia", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblCostTickets.ForeColor = System.Drawing.Color.OrangeRed
        Me.lblCostTickets.Location = New System.Drawing.Point(415, 432)
        Me.lblCostTickets.Name = "lblCostTickets"
        Me.lblCostTickets.Size = New System.Drawing.Size(137, 28)
        Me.lblCostTickets.TabIndex = 6
        Me.lblCostTickets.Text = "$0000.00"
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Turquoise
        Me.btnCalculate.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnCalculate.Location = New System.Drawing.Point(161, 510)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(146, 36)
        Me.btnCalculate.TabIndex = 7
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Turquoise
        Me.btnClear.Font = New System.Drawing.Font("Comic Sans MS", 14.0!, System.Drawing.FontStyle.Bold)
        Me.btnClear.Location = New System.Drawing.Point(357, 510)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(146, 36)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 583)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCostTickets)
        Me.Controls.Add(Me.lblRegistration)
        Me.Controls.Add(Me.gpbBadge)
        Me.Controls.Add(Me.txtGroup)
        Me.Controls.Add(Me.lblGroup)
        Me.Controls.Add(Me.lblComicConvention)
        Me.Controls.Add(Me.picComic)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comic Convention Registration"
        CType(Me.picComic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbBadge.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComic As PictureBox
    Friend WithEvents lblComicConvention As Label
    Friend WithEvents lblGroup As Label
    Friend WithEvents txtGroup As TextBox
    Friend WithEvents gpbBadge As GroupBox
    Friend WithEvents radConvention As RadioButton
    Friend WithEvents radAutographs As RadioButton
    Friend WithEvents radSuperhero As RadioButton
    Friend WithEvents lblRegistration As Label
    Friend WithEvents lblCostTickets As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
End Class
