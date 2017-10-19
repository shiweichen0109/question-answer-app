<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.LoadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.dgvQuestion = New System.Windows.Forms.DataGridView()
		Me.MenuStrip1.SuspendLayout()
		CType(Me.dgvQuestion, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(1436, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'LoadToolStripMenuItem
		'
		Me.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem"
		Me.LoadToolStripMenuItem.Size = New System.Drawing.Size(45, 20)
		Me.LoadToolStripMenuItem.Text = "Load"
		'
		'dgvQuestion
		'
		Me.dgvQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvQuestion.Dock = System.Windows.Forms.DockStyle.Fill
		Me.dgvQuestion.Location = New System.Drawing.Point(0, 24)
		Me.dgvQuestion.Name = "dgvQuestion"
		Me.dgvQuestion.Size = New System.Drawing.Size(1436, 765)
		Me.dgvQuestion.TabIndex = 1
		'
		'Welcome
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1436, 789)
		Me.Controls.Add(Me.dgvQuestion)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Welcome"
		Me.Text = "Welcome"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		CType(Me.dgvQuestion, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents LoadToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents dgvQuestion As DataGridView
End Class
