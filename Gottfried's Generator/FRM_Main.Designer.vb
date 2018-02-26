<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Main))
        Me.BTN_Generate = New System.Windows.Forms.Button()
        Me.TXT_Title = New System.Windows.Forms.TextBox()
        Me.LBL_Title = New System.Windows.Forms.Label()
        Me.TXT_Highest = New System.Windows.Forms.TextBox()
        Me.LBL_Highest = New System.Windows.Forms.Label()
        Me.CLB_Topics = New System.Windows.Forms.CheckedListBox()
        Me.LBL_Topics = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_Generate
        '
        Me.BTN_Generate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Generate.Location = New System.Drawing.Point(453, 18)
        Me.BTN_Generate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Generate.Name = "BTN_Generate"
        Me.BTN_Generate.Size = New System.Drawing.Size(230, 306)
        Me.BTN_Generate.TabIndex = 0
        Me.BTN_Generate.Text = "Generate Worksheet"
        Me.BTN_Generate.UseVisualStyleBackColor = True
        '
        'TXT_Title
        '
        Me.TXT_Title.Location = New System.Drawing.Point(153, 18)
        Me.TXT_Title.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_Title.MaxLength = 28
        Me.TXT_Title.Name = "TXT_Title"
        Me.TXT_Title.Size = New System.Drawing.Size(292, 26)
        Me.TXT_Title.TabIndex = 1
        Me.TXT_Title.Text = "Number Systems Worksheet"
        Me.TXT_Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LBL_Title
        '
        Me.LBL_Title.AutoSize = True
        Me.LBL_Title.CausesValidation = False
        Me.LBL_Title.Location = New System.Drawing.Point(13, 21)
        Me.LBL_Title.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_Title.Name = "LBL_Title"
        Me.LBL_Title.Size = New System.Drawing.Size(123, 20)
        Me.LBL_Title.TabIndex = 2
        Me.LBL_Title.Text = "Worksheet Title:"
        '
        'TXT_Highest
        '
        Me.TXT_Highest.Location = New System.Drawing.Point(286, 72)
        Me.TXT_Highest.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TXT_Highest.MaxLength = 16
        Me.TXT_Highest.Name = "TXT_Highest"
        Me.TXT_Highest.Size = New System.Drawing.Size(157, 26)
        Me.TXT_Highest.TabIndex = 3
        Me.TXT_Highest.Text = "1000"
        Me.TXT_Highest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LBL_Highest
        '
        Me.LBL_Highest.AutoSize = True
        Me.LBL_Highest.CausesValidation = False
        Me.LBL_Highest.Location = New System.Drawing.Point(9, 75)
        Me.LBL_Highest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_Highest.Name = "LBL_Highest"
        Me.LBL_Highest.Size = New System.Drawing.Size(269, 20)
        Me.LBL_Highest.TabIndex = 4
        Me.LBL_Highest.Text = "Highest permitted value (in Base 10):"
        '
        'CLB_Topics
        '
        Me.CLB_Topics.CheckOnClick = True
        Me.CLB_Topics.FormattingEnabled = True
        Me.CLB_Topics.Items.AddRange(New Object() {"Binary/Denary Conversion", "Binary Addition", "Binary Subtraction", "Logical Shifts", "Hexadecimal/Denary Conversion", "Hexadecimal Addition", "Hexadecimal Subtraction", "Binary/Hexadecimal Conversion"})
        Me.CLB_Topics.Location = New System.Drawing.Point(13, 152)
        Me.CLB_Topics.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CLB_Topics.Name = "CLB_Topics"
        Me.CLB_Topics.Size = New System.Drawing.Size(432, 172)
        Me.CLB_Topics.TabIndex = 5
        '
        'LBL_Topics
        '
        Me.LBL_Topics.AutoSize = True
        Me.LBL_Topics.CausesValidation = False
        Me.LBL_Topics.Location = New System.Drawing.Point(9, 127)
        Me.LBL_Topics.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_Topics.Name = "LBL_Topics"
        Me.LBL_Topics.Size = New System.Drawing.Size(131, 20)
        Me.LBL_Topics.TabIndex = 6
        Me.LBL_Topics.Text = "Topics to include:"
        '
        'FRM_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 343)
        Me.Controls.Add(Me.LBL_Topics)
        Me.Controls.Add(Me.CLB_Topics)
        Me.Controls.Add(Me.LBL_Highest)
        Me.Controls.Add(Me.TXT_Highest)
        Me.Controls.Add(Me.LBL_Title)
        Me.Controls.Add(Me.TXT_Title)
        Me.Controls.Add(Me.BTN_Generate)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_Main"
        Me.Text = "Gottfried's Generator - Create number system worksheets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Generate As Button
    Friend WithEvents TXT_Title As TextBox
    Friend WithEvents LBL_Title As Label
    Friend WithEvents LBL_Highest As Label
    Friend WithEvents TXT_Highest As TextBox
    Friend WithEvents CLB_Topics As CheckedListBox
    Friend WithEvents LBL_Topics As Label
End Class
