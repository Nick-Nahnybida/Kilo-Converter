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
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.btnInches = New System.Windows.Forms.Button()
        Me.btnFeet = New System.Windows.Forms.Button()
        Me.btnYards = New System.Windows.Forms.Button()
        Me.btnMiles = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(153, 84)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(150, 24)
        Me.lblMessage.TabIndex = 0
        Me.lblMessage.Text = "1 Kilometer = ?"
        '
        'btnInches
        '
        Me.btnInches.Location = New System.Drawing.Point(41, 201)
        Me.btnInches.Name = "btnInches"
        Me.btnInches.Size = New System.Drawing.Size(75, 23)
        Me.btnInches.TabIndex = 1
        Me.btnInches.Text = "Inches"
        Me.btnInches.UseVisualStyleBackColor = True
        '
        'btnFeet
        '
        Me.btnFeet.Location = New System.Drawing.Point(140, 202)
        Me.btnFeet.Name = "btnFeet"
        Me.btnFeet.Size = New System.Drawing.Size(75, 23)
        Me.btnFeet.TabIndex = 2
        Me.btnFeet.Text = "Feet"
        Me.btnFeet.UseVisualStyleBackColor = True
        '
        'btnYards
        '
        Me.btnYards.Location = New System.Drawing.Point(244, 201)
        Me.btnYards.Name = "btnYards"
        Me.btnYards.Size = New System.Drawing.Size(75, 23)
        Me.btnYards.TabIndex = 3
        Me.btnYards.Text = "Yards"
        Me.btnYards.UseVisualStyleBackColor = True
        '
        'btnMiles
        '
        Me.btnMiles.Location = New System.Drawing.Point(343, 202)
        Me.btnMiles.Name = "btnMiles"
        Me.btnMiles.Size = New System.Drawing.Size(75, 23)
        Me.btnMiles.TabIndex = 4
        Me.btnMiles.Text = "Miles"
        Me.btnMiles.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(196, 244)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 348)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMiles)
        Me.Controls.Add(Me.btnYards)
        Me.Controls.Add(Me.btnFeet)
        Me.Controls.Add(Me.btnInches)
        Me.Controls.Add(Me.lblMessage)
        Me.Name = "Form1"
        Me.Text = "Kilometer Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnInches As System.Windows.Forms.Button
    Friend WithEvents btnFeet As System.Windows.Forms.Button
    Friend WithEvents btnYards As System.Windows.Forms.Button
    Friend WithEvents btnMiles As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
