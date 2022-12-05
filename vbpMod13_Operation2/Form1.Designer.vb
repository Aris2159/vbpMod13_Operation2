<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frmmakethenumberto100
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frmmakethenumberto100))
        Me.lbloriginalrandomnumber = New System.Windows.Forms.Label()
        Me.lblnewcalculatednumber = New System.Windows.Forms.Label()
        Me.lblcounter = New System.Windows.Forms.Label()
        Me.lblinstruction = New System.Windows.Forms.Label()
        Me.cmdstart = New System.Windows.Forms.Button()
        Me.cmdagain = New System.Windows.Forms.Button()
        Me.cmddone = New System.Windows.Forms.Button()
        Me.cmdapplythemath = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbsquareroot = New System.Windows.Forms.RadioButton()
        Me.rdbsquare = New System.Windows.Forms.RadioButton()
        Me.rdbdivide = New System.Windows.Forms.RadioButton()
        Me.rdbmultiply = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lbloriginalnumber = New System.Windows.Forms.Label()
        Me.lblnewnumber = New System.Windows.Forms.Label()
        Me.lblcounternumber = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbloriginalrandomnumber
        '
        Me.lbloriginalrandomnumber.AutoSize = True
        Me.lbloriginalrandomnumber.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbloriginalrandomnumber.Location = New System.Drawing.Point(49, 74)
        Me.lbloriginalrandomnumber.Name = "lbloriginalrandomnumber"
        Me.lbloriginalrandomnumber.Size = New System.Drawing.Size(188, 19)
        Me.lbloriginalrandomnumber.TabIndex = 0
        Me.lbloriginalrandomnumber.Text = "Original Random Number"
        '
        'lblnewcalculatednumber
        '
        Me.lblnewcalculatednumber.AutoSize = True
        Me.lblnewcalculatednumber.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblnewcalculatednumber.Location = New System.Drawing.Point(49, 186)
        Me.lblnewcalculatednumber.Name = "lblnewcalculatednumber"
        Me.lblnewcalculatednumber.Size = New System.Drawing.Size(178, 19)
        Me.lblnewcalculatednumber.TabIndex = 1
        Me.lblnewcalculatednumber.Text = "New Calculated Number"
        '
        'lblcounter
        '
        Me.lblcounter.AutoSize = True
        Me.lblcounter.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblcounter.Location = New System.Drawing.Point(340, 19)
        Me.lblcounter.Name = "lblcounter"
        Me.lblcounter.Size = New System.Drawing.Size(66, 19)
        Me.lblcounter.TabIndex = 2
        Me.lblcounter.Text = "Counter"
        '
        'lblinstruction
        '
        Me.lblinstruction.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblinstruction.Location = New System.Drawing.Point(0, 280)
        Me.lblinstruction.Name = "lblinstruction"
        Me.lblinstruction.Size = New System.Drawing.Size(287, 142)
        Me.lblinstruction.TabIndex = 3
        Me.lblinstruction.Text = resources.GetString("lblinstruction.Text")
        Me.lblinstruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdstart
        '
        Me.cmdstart.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cmdstart.Location = New System.Drawing.Point(291, 115)
        Me.cmdstart.Name = "cmdstart"
        Me.cmdstart.Size = New System.Drawing.Size(194, 90)
        Me.cmdstart.TabIndex = 4
        Me.cmdstart.Text = "Start!"
        Me.cmdstart.UseVisualStyleBackColor = True
        '
        'cmdagain
        '
        Me.cmdagain.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cmdagain.Location = New System.Drawing.Point(293, 211)
        Me.cmdagain.Name = "cmdagain"
        Me.cmdagain.Size = New System.Drawing.Size(194, 90)
        Me.cmdagain.TabIndex = 5
        Me.cmdagain.Text = "Again!"
        Me.cmdagain.UseVisualStyleBackColor = True
        '
        'cmddone
        '
        Me.cmddone.Font = New System.Drawing.Font("Segoe UI Semibold", 22.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cmddone.Location = New System.Drawing.Point(293, 307)
        Me.cmddone.Name = "cmddone"
        Me.cmddone.Size = New System.Drawing.Size(194, 90)
        Me.cmddone.TabIndex = 6
        Me.cmddone.Text = "Done!"
        Me.cmddone.UseVisualStyleBackColor = True
        '
        'cmdapplythemath
        '
        Me.cmdapplythemath.Font = New System.Drawing.Font("Segoe UI Semibold", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.cmdapplythemath.Location = New System.Drawing.Point(514, 228)
        Me.cmdapplythemath.Name = "cmdapplythemath"
        Me.cmdapplythemath.Size = New System.Drawing.Size(174, 63)
        Me.cmdapplythemath.TabIndex = 7
        Me.cmdapplythemath.Text = "Apply The Math!"
        Me.cmdapplythemath.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbsquareroot)
        Me.GroupBox1.Controls.Add(Me.rdbsquare)
        Me.GroupBox1.Controls.Add(Me.rdbdivide)
        Me.GroupBox1.Controls.Add(Me.rdbmultiply)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Emoji", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(514, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 186)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operations"
        '
        'rdbsquareroot
        '
        Me.rdbsquareroot.AutoSize = True
        Me.rdbsquareroot.Location = New System.Drawing.Point(6, 152)
        Me.rdbsquareroot.Name = "rdbsquareroot"
        Me.rdbsquareroot.Size = New System.Drawing.Size(168, 23)
        Me.rdbsquareroot.TabIndex = 5
        Me.rdbsquareroot.TabStop = True
        Me.rdbsquareroot.Text = "SquareRoot (^(1/2))"
        Me.rdbsquareroot.UseVisualStyleBackColor = True
        '
        'rdbsquare
        '
        Me.rdbsquare.AutoSize = True
        Me.rdbsquare.Location = New System.Drawing.Point(6, 127)
        Me.rdbsquare.Name = "rdbsquare"
        Me.rdbsquare.Size = New System.Drawing.Size(95, 23)
        Me.rdbsquare.TabIndex = 4
        Me.rdbsquare.TabStop = True
        Me.rdbsquare.Text = "Square^2"
        Me.rdbsquare.UseVisualStyleBackColor = True
        '
        'rdbdivide
        '
        Me.rdbdivide.AutoSize = True
        Me.rdbdivide.Location = New System.Drawing.Point(6, 102)
        Me.rdbdivide.Name = "rdbdivide"
        Me.rdbdivide.Size = New System.Drawing.Size(107, 23)
        Me.rdbdivide.TabIndex = 3
        Me.rdbdivide.TabStop = True
        Me.rdbdivide.Text = "Divide by 2"
        Me.rdbdivide.UseVisualStyleBackColor = True
        '
        'rdbmultiply
        '
        Me.rdbmultiply.AutoSize = True
        Me.rdbmultiply.Location = New System.Drawing.Point(6, 77)
        Me.rdbmultiply.Name = "rdbmultiply"
        Me.rdbmultiply.Size = New System.Drawing.Size(121, 23)
        Me.rdbmultiply.TabIndex = 2
        Me.rdbmultiply.TabStop = True
        Me.rdbmultiply.Text = "Multiply by 2"
        Me.rdbmultiply.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 52)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(100, 23)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Subtract 2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 27)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(69, 23)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Add 2"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'lbloriginalnumber
        '
        Me.lbloriginalnumber.AutoSize = True
        Me.lbloriginalnumber.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbloriginalnumber.Location = New System.Drawing.Point(131, 104)
        Me.lbloriginalnumber.Name = "lbloriginalnumber"
        Me.lbloriginalnumber.Size = New System.Drawing.Size(0, 50)
        Me.lbloriginalnumber.TabIndex = 9
        '
        'lblnewnumber
        '
        Me.lblnewnumber.AutoSize = True
        Me.lblnewnumber.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblnewnumber.Location = New System.Drawing.Point(131, 219)
        Me.lblnewnumber.Name = "lblnewnumber"
        Me.lblnewnumber.Size = New System.Drawing.Size(0, 50)
        Me.lblnewnumber.TabIndex = 10
        Me.lblnewnumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblcounternumber
        '
        Me.lblcounternumber.AutoSize = True
        Me.lblcounternumber.Font = New System.Drawing.Font("Showcard Gothic", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblcounternumber.Location = New System.Drawing.Point(369, 46)
        Me.lblcounternumber.Name = "lblcounternumber"
        Me.lblcounternumber.Size = New System.Drawing.Size(0, 50)
        Me.lblcounternumber.TabIndex = 11
        '
        'Frmmakethenumberto100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 418)
        Me.Controls.Add(Me.lblcounternumber)
        Me.Controls.Add(Me.lblnewnumber)
        Me.Controls.Add(Me.lbloriginalnumber)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdapplythemath)
        Me.Controls.Add(Me.cmddone)
        Me.Controls.Add(Me.cmdagain)
        Me.Controls.Add(Me.cmdstart)
        Me.Controls.Add(Me.lblinstruction)
        Me.Controls.Add(Me.lblcounter)
        Me.Controls.Add(Me.lblnewcalculatednumber)
        Me.Controls.Add(Me.lbloriginalrandomnumber)
        Me.Name = "Frmmakethenumberto100"
        Me.Text = "Make The Original Number to 100."
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbloriginalrandomnumber As Label
    Friend WithEvents lblnewcalculatednumber As Label
    Friend WithEvents lblcounter As Label
    Friend WithEvents lblinstruction As Label
    Friend WithEvents cmdstart As Button
    Friend WithEvents cmdagain As Button
    Friend WithEvents cmddone As Button
    Friend WithEvents cmdapplythemath As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbsquareroot As RadioButton
    Friend WithEvents rdbsquare As RadioButton
    Friend WithEvents rdbdivide As RadioButton
    Friend WithEvents rdbmultiply As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lbloriginalnumber As Label
    Friend WithEvents lblnewnumber As Label
    Friend WithEvents lblcounternumber As Label
End Class
