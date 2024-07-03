<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstimateList
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.EstimateDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SearchIssueDateEndDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SearchIssueDateStartDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SearchPICEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchCustomerComboBox = New System.Windows.Forms.ComboBox()
        Me.IssueDateDuaringLabel = New System.Windows.Forms.Label()
        Me.SearchPICEmployeeLabel = New System.Windows.Forms.Label()
        Me.SearchIssueDateLabel = New System.Windows.Forms.Label()
        Me.SearchCustomerLabel = New System.Windows.Forms.Label()
        Me.SearchTitleLabel = New System.Windows.Forms.Label()
        Me.SearchEstimateNoLabel = New System.Windows.Forms.Label()
        Me.ClearSearchConditionButton = New System.Windows.Forms.Button()
        Me.SearchTitleTextBox = New System.Windows.Forms.TextBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.SearchEstimateNoTextBox = New System.Windows.Forms.TextBox()
        Me.NewEstimateEntryButton = New System.Windows.Forms.Button()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        CType(Me.EstimateDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'EstimateDataGridView
        '
        Me.EstimateDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EstimateDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.EstimateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EstimateDataGridView.Location = New System.Drawing.Point(20, 213)
        Me.EstimateDataGridView.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EstimateDataGridView.Name = "EstimateDataGridView"
        Me.EstimateDataGridView.RowHeadersVisible = False
        Me.EstimateDataGridView.RowHeadersWidth = 62
        Me.EstimateDataGridView.RowTemplate.Height = 21
        Me.EstimateDataGridView.Size = New System.Drawing.Size(1242, 324)
        Me.EstimateDataGridView.TabIndex = 5
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SearchIssueDateEndDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.SearchIssueDateStartDateTimePicker)
        Me.GroupBox1.Controls.Add(Me.SearchPICEmployeeComboBox)
        Me.GroupBox1.Controls.Add(Me.SearchCustomerComboBox)
        Me.GroupBox1.Controls.Add(Me.IssueDateDuaringLabel)
        Me.GroupBox1.Controls.Add(Me.SearchPICEmployeeLabel)
        Me.GroupBox1.Controls.Add(Me.SearchIssueDateLabel)
        Me.GroupBox1.Controls.Add(Me.SearchCustomerLabel)
        Me.GroupBox1.Controls.Add(Me.SearchTitleLabel)
        Me.GroupBox1.Controls.Add(Me.SearchEstimateNoLabel)
        Me.GroupBox1.Controls.Add(Me.ClearSearchConditionButton)
        Me.GroupBox1.Controls.Add(Me.SearchTitleTextBox)
        Me.GroupBox1.Controls.Add(Me.SearchButton)
        Me.GroupBox1.Controls.Add(Me.SearchEstimateNoTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(52, 20)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(973, 184)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "検索"
        '
        'SearchIssueDateEndDateTimePicker
        '
        Me.SearchIssueDateEndDateTimePicker.Location = New System.Drawing.Point(410, 93)
        Me.SearchIssueDateEndDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchIssueDateEndDateTimePicker.Name = "SearchIssueDateEndDateTimePicker"
        Me.SearchIssueDateEndDateTimePicker.Size = New System.Drawing.Size(199, 25)
        Me.SearchIssueDateEndDateTimePicker.TabIndex = 9
        '
        'SearchIssueDateStartDateTimePicker
        '
        Me.SearchIssueDateStartDateTimePicker.Location = New System.Drawing.Point(160, 93)
        Me.SearchIssueDateStartDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchIssueDateStartDateTimePicker.Name = "SearchIssueDateStartDateTimePicker"
        Me.SearchIssueDateStartDateTimePicker.Size = New System.Drawing.Size(199, 25)
        Me.SearchIssueDateStartDateTimePicker.TabIndex = 9
        '
        'SearchPICEmployeeComboBox
        '
        Me.SearchPICEmployeeComboBox.FormattingEnabled = True
        Me.SearchPICEmployeeComboBox.Location = New System.Drawing.Point(738, 18)
        Me.SearchPICEmployeeComboBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchPICEmployeeComboBox.Name = "SearchPICEmployeeComboBox"
        Me.SearchPICEmployeeComboBox.Size = New System.Drawing.Size(199, 26)
        Me.SearchPICEmployeeComboBox.TabIndex = 8
        '
        'SearchCustomerComboBox
        '
        Me.SearchCustomerComboBox.FormattingEnabled = True
        Me.SearchCustomerComboBox.Location = New System.Drawing.Point(738, 52)
        Me.SearchCustomerComboBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchCustomerComboBox.Name = "SearchCustomerComboBox"
        Me.SearchCustomerComboBox.Size = New System.Drawing.Size(199, 26)
        Me.SearchCustomerComboBox.TabIndex = 8
        '
        'IssueDateDuaringLabel
        '
        Me.IssueDateDuaringLabel.AutoSize = True
        Me.IssueDateDuaringLabel.Location = New System.Drawing.Point(372, 100)
        Me.IssueDateDuaringLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.IssueDateDuaringLabel.Name = "IssueDateDuaringLabel"
        Me.IssueDateDuaringLabel.Size = New System.Drawing.Size(26, 18)
        Me.IssueDateDuaringLabel.TabIndex = 7
        Me.IssueDateDuaringLabel.Text = "～"
        '
        'SearchPICEmployeeLabel
        '
        Me.SearchPICEmployeeLabel.AutoSize = True
        Me.SearchPICEmployeeLabel.Location = New System.Drawing.Point(633, 22)
        Me.SearchPICEmployeeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SearchPICEmployeeLabel.Name = "SearchPICEmployeeLabel"
        Me.SearchPICEmployeeLabel.Size = New System.Drawing.Size(80, 18)
        Me.SearchPICEmployeeLabel.TabIndex = 7
        Me.SearchPICEmployeeLabel.Text = "営業担当"
        '
        'SearchIssueDateLabel
        '
        Me.SearchIssueDateLabel.AutoSize = True
        Me.SearchIssueDateLabel.Location = New System.Drawing.Point(22, 99)
        Me.SearchIssueDateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SearchIssueDateLabel.Name = "SearchIssueDateLabel"
        Me.SearchIssueDateLabel.Size = New System.Drawing.Size(62, 18)
        Me.SearchIssueDateLabel.TabIndex = 7
        Me.SearchIssueDateLabel.Text = "発行日"
        '
        'SearchCustomerLabel
        '
        Me.SearchCustomerLabel.AutoSize = True
        Me.SearchCustomerLabel.Location = New System.Drawing.Point(633, 57)
        Me.SearchCustomerLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SearchCustomerLabel.Name = "SearchCustomerLabel"
        Me.SearchCustomerLabel.Size = New System.Drawing.Size(62, 18)
        Me.SearchCustomerLabel.TabIndex = 7
        Me.SearchCustomerLabel.Text = "顧客名"
        '
        'SearchTitleLabel
        '
        Me.SearchTitleLabel.AutoSize = True
        Me.SearchTitleLabel.Location = New System.Drawing.Point(22, 62)
        Me.SearchTitleLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SearchTitleLabel.Name = "SearchTitleLabel"
        Me.SearchTitleLabel.Size = New System.Drawing.Size(44, 18)
        Me.SearchTitleLabel.TabIndex = 7
        Me.SearchTitleLabel.Text = "件名"
        '
        'SearchEstimateNoLabel
        '
        Me.SearchEstimateNoLabel.AutoSize = True
        Me.SearchEstimateNoLabel.Location = New System.Drawing.Point(22, 30)
        Me.SearchEstimateNoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SearchEstimateNoLabel.Name = "SearchEstimateNoLabel"
        Me.SearchEstimateNoLabel.Size = New System.Drawing.Size(80, 18)
        Me.SearchEstimateNoLabel.TabIndex = 7
        Me.SearchEstimateNoLabel.Text = "見積番号"
        '
        'ClearSearchConditionButton
        '
        Me.ClearSearchConditionButton.Location = New System.Drawing.Point(838, 99)
        Me.ClearSearchConditionButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.ClearSearchConditionButton.Name = "ClearSearchConditionButton"
        Me.ClearSearchConditionButton.Size = New System.Drawing.Size(125, 34)
        Me.ClearSearchConditionButton.TabIndex = 5
        Me.ClearSearchConditionButton.Text = "クリア"
        Me.ClearSearchConditionButton.UseVisualStyleBackColor = True
        '
        'SearchTitleTextBox
        '
        Me.SearchTitleTextBox.Location = New System.Drawing.Point(160, 57)
        Me.SearchTitleTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchTitleTextBox.Name = "SearchTitleTextBox"
        Me.SearchTitleTextBox.Size = New System.Drawing.Size(319, 25)
        Me.SearchTitleTextBox.TabIndex = 2
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(838, 136)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(125, 34)
        Me.SearchButton.TabIndex = 6
        Me.SearchButton.Text = "検索"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'SearchEstimateNoTextBox
        '
        Me.SearchEstimateNoTextBox.Location = New System.Drawing.Point(160, 22)
        Me.SearchEstimateNoTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.SearchEstimateNoTextBox.Name = "SearchEstimateNoTextBox"
        Me.SearchEstimateNoTextBox.Size = New System.Drawing.Size(181, 25)
        Me.SearchEstimateNoTextBox.TabIndex = 2
        '
        'NewEstimateEntryButton
        '
        Me.NewEstimateEntryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NewEstimateEntryButton.Location = New System.Drawing.Point(1035, 36)
        Me.NewEstimateEntryButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.NewEstimateEntryButton.Name = "NewEstimateEntryButton"
        Me.NewEstimateEntryButton.Size = New System.Drawing.Size(227, 34)
        Me.NewEstimateEntryButton.TabIndex = 3
        Me.NewEstimateEntryButton.Text = "新しい見積書を作成"
        Me.NewEstimateEntryButton.UseVisualStyleBackColor = True
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 542)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(2, 0, 23, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1282, 32)
        Me.StatusStrip.TabIndex = 6
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(172, 25)
        Me.ToolStripStatusLabel.Text = "ToolStripStatusLabel"
        '
        'EstimateList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 574)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.EstimateDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.NewEstimateEntryButton)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "EstimateList"
        Me.Text = "見積書の管理"
        CType(Me.EstimateDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents EstimateDataGridView As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents SearchEstimateNoTextBox As TextBox
    Friend WithEvents NewEstimateEntryButton As Button
    Friend WithEvents ClearSearchConditionButton As Button
    Friend WithEvents SearchButton As Button
    Friend WithEvents SearchEstimateNoLabel As Label
    Friend WithEvents SearchTitleLabel As Label
    Friend WithEvents SearchTitleTextBox As TextBox
    Friend WithEvents SearchCustomerLabel As Label
    Friend WithEvents SearchCustomerComboBox As ComboBox
    Friend WithEvents SearchIssueDateLabel As Label
    Friend WithEvents SearchIssueDateEndDateTimePicker As DateTimePicker
    Friend WithEvents IssueDateDuaringLabel As Label
    Friend WithEvents SearchPICEmployeeComboBox As ComboBox
    Friend WithEvents SearchPICEmployeeLabel As Label
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents ToolStripStatusLabel As ToolStripStatusLabel
    Friend WithEvents SearchIssueDateStartDateTimePicker As DateTimePicker
End Class
