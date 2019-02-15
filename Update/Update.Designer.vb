<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Update
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
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSkip = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblNewest = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(16, 63)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "An update is available for the Batch Program"
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(155, 63)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(75, 23)
        Me.btnSkip.TabIndex = 2
        Me.btnSkip.Text = "Skip Update"
        Me.btnSkip.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Currently installed version:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Newest version:"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(189, 34)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(41, 13)
        Me.lblCurrent.TabIndex = 5
        Me.lblCurrent.Text = "Current"
        Me.lblCurrent.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNewest
        '
        Me.lblNewest.AutoSize = True
        Me.lblNewest.Location = New System.Drawing.Point(187, 47)
        Me.lblNewest.Name = "lblNewest"
        Me.lblNewest.Size = New System.Drawing.Size(43, 13)
        Me.lblNewest.TabIndex = 6
        Me.lblNewest.Text = "Newest"
        Me.lblNewest.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Update
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 94)
        Me.Controls.Add(Me.lblNewest)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSkip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Name = "Update"
        Me.Text = "Update"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents btnSkip As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents lblCurrent As Windows.Forms.Label
    Friend WithEvents lblNewest As Windows.Forms.Label
End Class
