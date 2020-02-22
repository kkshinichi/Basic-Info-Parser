<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainActivity
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
        Me.nameBox = New System.Windows.Forms.TextBox()
        Me.ageBox = New System.Windows.Forms.TextBox()
        Me.addrBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.btnXml = New System.Windows.Forms.Button()
        Me.btnJson = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameBox
        '
        Me.nameBox.Location = New System.Drawing.Point(88, 43)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(100, 20)
        Me.nameBox.TabIndex = 0
        '
        'ageBox
        '
        Me.ageBox.Location = New System.Drawing.Point(88, 70)
        Me.ageBox.Name = "ageBox"
        Me.ageBox.Size = New System.Drawing.Size(100, 20)
        Me.ageBox.TabIndex = 1
        '
        'addrBox
        '
        Me.addrBox.Location = New System.Drawing.Point(88, 97)
        Me.addrBox.Name = "addrBox"
        Me.addrBox.Size = New System.Drawing.Size(100, 20)
        Me.addrBox.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Age"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Address"
        '
        'btnTxt
        '
        Me.btnTxt.Location = New System.Drawing.Point(29, 134)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(75, 23)
        Me.btnTxt.TabIndex = 6
        Me.btnTxt.Text = "TXT"
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'btnXml
        '
        Me.btnXml.Location = New System.Drawing.Point(29, 164)
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(75, 23)
        Me.btnXml.TabIndex = 7
        Me.btnXml.Text = "XML"
        Me.btnXml.UseVisualStyleBackColor = True
        '
        'btnJson
        '
        Me.btnJson.Location = New System.Drawing.Point(29, 193)
        Me.btnJson.Name = "btnJson"
        Me.btnJson.Size = New System.Drawing.Size(75, 23)
        Me.btnJson.TabIndex = 8
        Me.btnJson.Text = "JSON"
        Me.btnJson.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(29, 223)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "CLEAR ALL"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'MainActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnJson)
        Me.Controls.Add(Me.btnXml)
        Me.Controls.Add(Me.btnTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.addrBox)
        Me.Controls.Add(Me.ageBox)
        Me.Controls.Add(Me.nameBox)
        Me.Name = "MainActivity"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nameBox As TextBox
    Friend WithEvents ageBox As TextBox
    Friend WithEvents addrBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnTxt As Button
    Friend WithEvents btnXml As Button
    Friend WithEvents btnJson As Button
    Friend WithEvents btnClear As Button
End Class
