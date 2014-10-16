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
        Me.TextBoxInput = New System.Windows.Forms.TextBox()
        Me.ListBoxValues = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxMean = New System.Windows.Forms.TextBox()
        Me.TextBoxMode = New System.Windows.Forms.TextBox()
        Me.TextBoxFrequency = New System.Windows.Forms.TextBox()
        Me.TextBoxMedian = New System.Windows.Forms.TextBox()
        Me.buttonCalculate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBoxInput
        '
        Me.TextBoxInput.Location = New System.Drawing.Point(13, 13)
        Me.TextBoxInput.Name = "TextBoxInput"
        Me.TextBoxInput.Size = New System.Drawing.Size(174, 20)
        Me.TextBoxInput.TabIndex = 0
        '
        'ListBoxValues
        '
        Me.ListBoxValues.FormattingEnabled = True
        Me.ListBoxValues.Location = New System.Drawing.Point(13, 40)
        Me.ListBoxValues.Name = "ListBoxValues"
        Me.ListBoxValues.Size = New System.Drawing.Size(174, 160)
        Me.ListBoxValues.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Mean"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(260, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mode"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Mode Frequency"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(251, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Median"
        '
        'TextBoxMean
        '
        Me.TextBoxMean.Location = New System.Drawing.Point(300, 12)
        Me.TextBoxMean.Name = "TextBoxMean"
        Me.TextBoxMean.ReadOnly = True
        Me.TextBoxMean.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMean.TabIndex = 6
        '
        'TextBoxMode
        '
        Me.TextBoxMode.Location = New System.Drawing.Point(300, 38)
        Me.TextBoxMode.Name = "TextBoxMode"
        Me.TextBoxMode.ReadOnly = True
        Me.TextBoxMode.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMode.TabIndex = 7
        '
        'TextBoxFrequency
        '
        Me.TextBoxFrequency.Location = New System.Drawing.Point(299, 66)
        Me.TextBoxFrequency.Name = "TextBoxFrequency"
        Me.TextBoxFrequency.ReadOnly = True
        Me.TextBoxFrequency.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxFrequency.TabIndex = 8
        '
        'TextBoxMedian
        '
        Me.TextBoxMedian.Location = New System.Drawing.Point(299, 93)
        Me.TextBoxMedian.Name = "TextBoxMedian"
        Me.TextBoxMedian.ReadOnly = True
        Me.TextBoxMedian.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxMedian.TabIndex = 9
        '
        'buttonCalculate
        '
        Me.buttonCalculate.Location = New System.Drawing.Point(13, 217)
        Me.buttonCalculate.Name = "buttonCalculate"
        Me.buttonCalculate.Size = New System.Drawing.Size(75, 23)
        Me.buttonCalculate.TabIndex = 10
        Me.buttonCalculate.Text = "Calculate"
        Me.buttonCalculate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 262)
        Me.Controls.Add(Me.buttonCalculate)
        Me.Controls.Add(Me.TextBoxMedian)
        Me.Controls.Add(Me.TextBoxFrequency)
        Me.Controls.Add(Me.TextBoxMode)
        Me.Controls.Add(Me.TextBoxMean)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBoxValues)
        Me.Controls.Add(Me.TextBoxInput)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxInput As System.Windows.Forms.TextBox
    Friend WithEvents ListBoxValues As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBoxMean As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMode As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFrequency As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxMedian As System.Windows.Forms.TextBox
    Friend WithEvents buttonCalculate As System.Windows.Forms.Button

End Class
