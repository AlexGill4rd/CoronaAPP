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
        Me.btnHerlezen = New System.Windows.Forms.Button()
        Me.cboLand = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dlgOpenen = New System.Windows.Forms.OpenFileDialog()
        Me.cboDatums = New System.Windows.Forms.ComboBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnHerlezen
        '
        Me.btnHerlezen.Location = New System.Drawing.Point(12, 122)
        Me.btnHerlezen.Name = "btnHerlezen"
        Me.btnHerlezen.Size = New System.Drawing.Size(145, 23)
        Me.btnHerlezen.TabIndex = 0
        Me.btnHerlezen.Text = "Herlezen"
        Me.btnHerlezen.UseVisualStyleBackColor = True
        '
        'cboLand
        '
        Me.cboLand.FormattingEnabled = True
        Me.cboLand.Location = New System.Drawing.Point(12, 12)
        Me.cboLand.Name = "cboLand"
        Me.cboLand.Size = New System.Drawing.Size(145, 23)
        Me.cboLand.TabIndex = 1
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 151)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(145, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Sluiten"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dlgOpenen
        '
        Me.dlgOpenen.FileName = "OpenFileDialog1"
        '
        'cboDatums
        '
        Me.cboDatums.Enabled = False
        Me.cboDatums.FormattingEnabled = True
        Me.cboDatums.Location = New System.Drawing.Point(12, 41)
        Me.cboDatums.Name = "cboDatums"
        Me.cboDatums.Size = New System.Drawing.Size(145, 23)
        Me.cboDatums.TabIndex = 4
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtData.Location = New System.Drawing.Point(163, 12)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(250, 162)
        Me.txtData.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 187)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.cboDatums)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.cboLand)
        Me.Controls.Add(Me.btnHerlezen)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHerlezen As Button
    Friend WithEvents cboLand As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents dlgOpenen As OpenFileDialog
    Friend WithEvents cboDatums As ComboBox
    Friend WithEvents txtData As TextBox
End Class
