<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        lbllength = New Label()
        lblwidth = New Label()
        lblarea = New Label()
        lblperimeter = New Label()
        btncalculate = New Button()
        txtlength = New TextBox()
        txtwidth = New TextBox()
        txtarea = New TextBox()
        txtperimeter = New TextBox()
        SuspendLayout()
        ' 
        ' lbllength
        ' 
        lbllength.AutoSize = True
        lbllength.Location = New Point(46, 30)
        lbllength.Name = "lbllength"
        lbllength.Size = New Size(44, 15)
        lbllength.TabIndex = 0
        lbllength.Text = "Length"
        ' 
        ' lblwidth
        ' 
        lblwidth.AutoSize = True
        lblwidth.Location = New Point(46, 86)
        lblwidth.Name = "lblwidth"
        lblwidth.Size = New Size(39, 15)
        lblwidth.TabIndex = 1
        lblwidth.Text = "Width"
        ' 
        ' lblarea
        ' 
        lblarea.AutoSize = True
        lblarea.Location = New Point(46, 218)
        lblarea.Name = "lblarea"
        lblarea.Size = New Size(31, 15)
        lblarea.TabIndex = 2
        lblarea.Text = "Area"
        ' 
        ' lblperimeter
        ' 
        lblperimeter.AutoSize = True
        lblperimeter.Location = New Point(46, 276)
        lblperimeter.Name = "lblperimeter"
        lblperimeter.Size = New Size(58, 15)
        lblperimeter.TabIndex = 3
        lblperimeter.Text = "Perimeter"
        ' 
        ' btncalculate
        ' 
        btncalculate.Location = New Point(76, 152)
        btncalculate.Name = "btncalculate"
        btncalculate.Size = New Size(93, 23)
        btncalculate.TabIndex = 4
        btncalculate.Text = "CALCULATE"
        btncalculate.UseVisualStyleBackColor = True
        ' 
        ' txtlength
        ' 
        txtlength.Location = New Point(114, 27)
        txtlength.Name = "txtlength"
        txtlength.Size = New Size(100, 23)
        txtlength.TabIndex = 5
        ' 
        ' txtwidth
        ' 
        txtwidth.Location = New Point(114, 78)
        txtwidth.Name = "txtwidth"
        txtwidth.Size = New Size(100, 23)
        txtwidth.TabIndex = 6
        ' 
        ' txtarea
        ' 
        txtarea.Location = New Point(114, 215)
        txtarea.Name = "txtarea"
        txtarea.Size = New Size(100, 23)
        txtarea.TabIndex = 7
        ' 
        ' txtperimeter
        ' 
        txtperimeter.Location = New Point(114, 268)
        txtperimeter.Name = "txtperimeter"
        txtperimeter.Size = New Size(100, 23)
        txtperimeter.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtperimeter)
        Controls.Add(txtarea)
        Controls.Add(txtwidth)
        Controls.Add(txtlength)
        Controls.Add(btncalculate)
        Controls.Add(lblperimeter)
        Controls.Add(lblarea)
        Controls.Add(lblwidth)
        Controls.Add(lbllength)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lbllength As Label
    Friend WithEvents lblwidth As Label
    Friend WithEvents lblarea As Label
    Friend WithEvents lblperimeter As Label
    Friend WithEvents btncalculate As Button
    Friend WithEvents txtlength As TextBox
    Friend WithEvents txtwidth As TextBox
    Friend WithEvents txtarea As TextBox
    Friend WithEvents txtperimeter As TextBox

End Class
