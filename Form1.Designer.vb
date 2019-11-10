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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic = New System.Windows.Forms.PictureBox()
        Me.txtencoder = New System.Windows.Forms.TextBox()
        Me.btndecode = New System.Windows.Forms.Button()
        Me.txtdecoder = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnencode = New System.Windows.Forms.Button()
        CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Encode"
        '
        'pic
        '
        Me.pic.BackColor = System.Drawing.Color.White
        Me.pic.Location = New System.Drawing.Point(25, 12)
        Me.pic.Name = "pic"
        Me.pic.Size = New System.Drawing.Size(529, 130)
        Me.pic.TabIndex = 1
        Me.pic.TabStop = False
        '
        'txtencoder
        '
        Me.txtencoder.Location = New System.Drawing.Point(75, 159)
        Me.txtencoder.Name = "txtencoder"
        Me.txtencoder.Size = New System.Drawing.Size(479, 20)
        Me.txtencoder.TabIndex = 2
        '
        'btndecode
        '
        Me.btndecode.Location = New System.Drawing.Point(187, 223)
        Me.btndecode.Name = "btndecode"
        Me.btndecode.Size = New System.Drawing.Size(75, 23)
        Me.btndecode.TabIndex = 3
        Me.btndecode.Text = "Decode"
        Me.btndecode.UseVisualStyleBackColor = True
        '
        'txtdecoder
        '
        Me.txtdecoder.Location = New System.Drawing.Point(75, 185)
        Me.txtdecoder.Name = "txtdecoder"
        Me.txtdecoder.Size = New System.Drawing.Size(479, 20)
        Me.txtdecoder.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Decode"
        '
        'btnencode
        '
        Me.btnencode.Location = New System.Drawing.Point(293, 223)
        Me.btnencode.Name = "btnencode"
        Me.btnencode.Size = New System.Drawing.Size(75, 23)
        Me.btnencode.TabIndex = 6
        Me.btnencode.Text = "Encode"
        Me.btnencode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 258)
        Me.Controls.Add(Me.btnencode)
        Me.Controls.Add(Me.txtdecoder)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btndecode)
        Me.Controls.Add(Me.txtencoder)
        Me.Controls.Add(Me.pic)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "BarCode App"
        CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pic As PictureBox
    Friend WithEvents txtencoder As TextBox
    Friend WithEvents btndecode As Button
    Friend WithEvents txtdecoder As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnencode As Button
End Class
