<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnHerlezen = New System.Windows.Forms.Button()
        Me.cboLand = New System.Windows.Forms.ComboBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.dlgOpenen = New System.Windows.Forms.OpenFileDialog()
        Me.cboDatums = New System.Windows.Forms.ComboBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.ttClose = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttHerlezen = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttLand = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttDatum = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'btnHerlezen
        '
        Me.btnHerlezen.Location = New System.Drawing.Point(12, 122)
        Me.btnHerlezen.Name = "btnHerlezen"
        Me.btnHerlezen.Size = New System.Drawing.Size(145, 23)
        Me.btnHerlezen.TabIndex = 0
        Me.btnHerlezen.Text = "Herlezen"
        Me.ttHerlezen.SetToolTip(Me.btnHerlezen, "Herlaadt de informatie van het programma")
        Me.btnHerlezen.UseVisualStyleBackColor = True
        '
        'cboLand
        '
        Me.cboLand.FormattingEnabled = True
        Me.cboLand.Location = New System.Drawing.Point(12, 12)
        Me.cboLand.Name = "cboLand"
        Me.cboLand.Size = New System.Drawing.Size(145, 23)
        Me.cboLand.TabIndex = 1
        Me.ttLand.SetToolTip(Me.cboLand, "Pas hier het land aan")
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(12, 151)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(145, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Sluiten"
        Me.ttClose.SetToolTip(Me.btnClose, "Sluit het programma af")
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'dlgOpenen
        '
        Me.dlgOpenen.FileName = "OpenFileDialog1"
        '
        'cboDatums
        '
        Me.cboDatums.FormattingEnabled = True
        Me.cboDatums.Location = New System.Drawing.Point(12, 41)
        Me.cboDatums.Name = "cboDatums"
        Me.cboDatums.Size = New System.Drawing.Size(145, 23)
        Me.cboDatums.TabIndex = 4
        Me.ttDatum.SetToolTip(Me.cboDatums, "Pas de datum voor de informatie aan")
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtData.Location = New System.Drawing.Point(163, 12)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(250, 162)
        Me.txtData.TabIndex = 5
        Me.ttInfo.SetToolTip(Me.txtData, "Krijg meer informatie over het geselecteerde land te zien")
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
        Me.Text = "Corona Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnHerlezen As Button
    Friend WithEvents cboLand As ComboBox
    Friend WithEvents btnClose As Button
    Friend WithEvents dlgOpenen As OpenFileDialog
    Friend WithEvents cboDatums As ComboBox
    Friend WithEvents txtData As TextBox
    Friend WithEvents ttClose As ToolTip
    Friend WithEvents ttLand As ToolTip
    Friend WithEvents ttDatum As ToolTip
    Friend WithEvents ttInfo As ToolTip
    Friend WithEvents ttHerlezen As ToolTip
End Class
