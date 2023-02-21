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
        Me.PicboxBNB = New System.Windows.Forms.PictureBox()
        Me.Txtnumnights = New System.Windows.Forms.TextBox()
        Me.Lblheading = New System.Windows.Forms.Label()
        Me.Lblpriceper = New System.Windows.Forms.Label()
        Me.Lblnumnights = New System.Windows.Forms.Label()
        Me.Lblcoststay = New System.Windows.Forms.Label()
        Me.Lbltotalcost = New System.Windows.Forms.Label()
        Me.Btncost = New System.Windows.Forms.Button()
        Me.Btnclear = New System.Windows.Forms.Button()
        Me.Btnexit = New System.Windows.Forms.Button()
        CType(Me.PicboxBNB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicboxBNB
        '
        Me.PicboxBNB.Image = Global.Assignment_4.My.Resources.Resources.airbnb
        Me.PicboxBNB.Location = New System.Drawing.Point(3, 5)
        Me.PicboxBNB.Name = "PicboxBNB"
        Me.PicboxBNB.Size = New System.Drawing.Size(386, 442)
        Me.PicboxBNB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicboxBNB.TabIndex = 7
        Me.PicboxBNB.TabStop = False
        '
        'Txtnumnights
        '
        Me.Txtnumnights.Location = New System.Drawing.Point(608, 166)
        Me.Txtnumnights.Multiline = True
        Me.Txtnumnights.Name = "Txtnumnights"
        Me.Txtnumnights.Size = New System.Drawing.Size(27, 20)
        Me.Txtnumnights.TabIndex = 8
        '
        'Lblheading
        '
        Me.Lblheading.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblheading.Location = New System.Drawing.Point(466, 5)
        Me.Lblheading.Name = "Lblheading"
        Me.Lblheading.Size = New System.Drawing.Size(223, 39)
        Me.Lblheading.TabIndex = 9
        Me.Lblheading.Text = "Orlando AirBNB"
        '
        'Lblpriceper
        '
        Me.Lblpriceper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblpriceper.Location = New System.Drawing.Point(502, 44)
        Me.Lblpriceper.Name = "Lblpriceper"
        Me.Lblpriceper.Size = New System.Drawing.Size(187, 62)
        Me.Lblpriceper.TabIndex = 10
        Me.Lblpriceper.Text = "Only $79.00 per night"
        '
        'Lblnumnights
        '
        Me.Lblnumnights.AutoSize = True
        Me.Lblnumnights.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblnumnights.Location = New System.Drawing.Point(432, 166)
        Me.Lblnumnights.Name = "Lblnumnights"
        Me.Lblnumnights.Size = New System.Drawing.Size(153, 20)
        Me.Lblnumnights.TabIndex = 11
        Me.Lblnumnights.Text = "Number of Nights:"
        '
        'Lblcoststay
        '
        Me.Lblcoststay.AutoSize = True
        Me.Lblcoststay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblcoststay.Location = New System.Drawing.Point(432, 211)
        Me.Lblcoststay.Name = "Lblcoststay"
        Me.Lblcoststay.Size = New System.Drawing.Size(110, 20)
        Me.Lblcoststay.TabIndex = 12
        Me.Lblcoststay.Text = "Cost of stay:"
        '
        'Lbltotalcost
        '
        Me.Lbltotalcost.AutoSize = True
        Me.Lbltotalcost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbltotalcost.Location = New System.Drawing.Point(608, 217)
        Me.Lbltotalcost.Name = "Lbltotalcost"
        Me.Lbltotalcost.Size = New System.Drawing.Size(0, 13)
        Me.Lbltotalcost.TabIndex = 16
        '
        'Btncost
        '
        Me.Btncost.BackColor = System.Drawing.Color.LightGray
        Me.Btncost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncost.Location = New System.Drawing.Point(436, 353)
        Me.Btncost.Name = "Btncost"
        Me.Btncost.Size = New System.Drawing.Size(88, 23)
        Me.Btncost.TabIndex = 17
        Me.Btncost.Text = "Display cost"
        Me.Btncost.UseVisualStyleBackColor = False
        '
        'Btnclear
        '
        Me.Btnclear.BackColor = System.Drawing.Color.LightGray
        Me.Btnclear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnclear.Location = New System.Drawing.Point(551, 353)
        Me.Btnclear.Name = "Btnclear"
        Me.Btnclear.Size = New System.Drawing.Size(88, 23)
        Me.Btnclear.TabIndex = 18
        Me.Btnclear.Text = "Clear"
        Me.Btnclear.UseVisualStyleBackColor = False
        '
        'Btnexit
        '
        Me.Btnexit.BackColor = System.Drawing.Color.LightGray
        Me.Btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnexit.Location = New System.Drawing.Point(672, 353)
        Me.Btnexit.Name = "Btnexit"
        Me.Btnexit.Size = New System.Drawing.Size(88, 23)
        Me.Btnexit.TabIndex = 19
        Me.Btnexit.Text = "Exit"
        Me.Btnexit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AcceptButton = Me.Btncost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Tan
        Me.CancelButton = Me.Btnclear
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btnexit)
        Me.Controls.Add(Me.Btnclear)
        Me.Controls.Add(Me.Btncost)
        Me.Controls.Add(Me.Lbltotalcost)
        Me.Controls.Add(Me.Lblcoststay)
        Me.Controls.Add(Me.Lblnumnights)
        Me.Controls.Add(Me.Lblpriceper)
        Me.Controls.Add(Me.Lblheading)
        Me.Controls.Add(Me.Txtnumnights)
        Me.Controls.Add(Me.PicboxBNB)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AirBNB Reservations"
        CType(Me.PicboxBNB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicboxBNB As PictureBox
    Friend WithEvents Txtnumnights As TextBox
    Friend WithEvents Lblheading As Label
    Friend WithEvents Lblpriceper As Label
    Friend WithEvents Lblnumnights As Label
    Friend WithEvents Lblcoststay As Label
    Friend WithEvents Lbltotalcost As Label
    Friend WithEvents Btncost As Button
    Friend WithEvents Btnclear As Button
    Friend WithEvents Btnexit As Button
End Class
