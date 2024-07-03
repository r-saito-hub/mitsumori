<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EstimateEntry
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
        Me.components = New System.ComponentModel.Container()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.EstimateNoLabel = New System.Windows.Forms.Label()
        Me.IssueDateLabel = New System.Windows.Forms.Label()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.EntryButton = New System.Windows.Forms.Button()
        Me.PrintPreviewButton = New System.Windows.Forms.Button()
        Me.DetailsDataGridView = New System.Windows.Forms.DataGridView()
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DueDateLabel = New System.Windows.Forms.Label()
        Me.PaymentConditionLabel = New System.Windows.Forms.Label()
        Me.PaymentConditionComboBox = New System.Windows.Forms.ComboBox()
        Me.PICEmployeeLabel = New System.Windows.Forms.Label()
        Me.PICEmployeeComboBox = New System.Windows.Forms.ComboBox()
        Me.EffectiveDateLabel = New System.Windows.Forms.Label()
        Me.EffectiveDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.RemarksLabel = New System.Windows.Forms.Label()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerComboBox = New System.Windows.Forms.ComboBox()
        Me.EstimateNoTextBox = New System.Windows.Forms.TextBox()
        Me.IssueDateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.TaxRateLabel = New System.Windows.Forms.Label()
        Me.TaxRateTextBox = New System.Windows.Forms.TextBox()
        Me.EstimatePriceLabel = New System.Windows.Forms.Label()
        Me.EstimatePriceTextBox = New System.Windows.Forms.TextBox()
        Me.EstimatePriceIncludeTaxLabel = New System.Windows.Forms.Label()
        Me.EstimatePriceIncludeTaxTextBox = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.RowDownButton = New System.Windows.Forms.Button()
        Me.RowUpButton = New System.Windows.Forms.Button()
        Me.RowRemoveButton = New System.Windows.Forms.Button()
        Me.RowAddButton = New System.Windows.Forms.Button()
        Me.FocusEmphasizeProvider = New Application.FocusEmphasizeProvider()
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(23, 58)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(44, 18)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "件名"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.Location = New System.Drawing.Point(118, 52)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(516, 25)
        Me.TitleTextBox.TabIndex = 1
        '
        'EstimateNoLabel
        '
        Me.EstimateNoLabel.AutoSize = True
        Me.EstimateNoLabel.Location = New System.Drawing.Point(23, 24)
        Me.EstimateNoLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.EstimateNoLabel.Name = "EstimateNoLabel"
        Me.EstimateNoLabel.Size = New System.Drawing.Size(80, 18)
        Me.EstimateNoLabel.TabIndex = 0
        Me.EstimateNoLabel.Text = "見積番号"
        '
        'IssueDateLabel
        '
        Me.IssueDateLabel.AutoSize = True
        Me.IssueDateLabel.Location = New System.Drawing.Point(743, 24)
        Me.IssueDateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.IssueDateLabel.Name = "IssueDateLabel"
        Me.IssueDateLabel.Size = New System.Drawing.Size(62, 18)
        Me.IssueDateLabel.TabIndex = 0
        Me.IssueDateLabel.Text = "発行日"
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.Location = New System.Drawing.Point(20, 93)
        Me.CustomerLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(62, 18)
        Me.CustomerLabel.TabIndex = 0
        Me.CustomerLabel.Text = "顧客名"
        '
        'EntryButton
        '
        Me.EntryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryButton.Location = New System.Drawing.Point(1123, 651)
        Me.EntryButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EntryButton.Name = "EntryButton"
        Me.EntryButton.Size = New System.Drawing.Size(125, 34)
        Me.EntryButton.TabIndex = 14
        Me.EntryButton.Text = "登録"
        Me.EntryButton.UseVisualStyleBackColor = True
        '
        'PrintPreviewButton
        '
        Me.PrintPreviewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PrintPreviewButton.Location = New System.Drawing.Point(928, 651)
        Me.PrintPreviewButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PrintPreviewButton.Name = "PrintPreviewButton"
        Me.PrintPreviewButton.Size = New System.Drawing.Size(185, 34)
        Me.PrintPreviewButton.TabIndex = 13
        Me.PrintPreviewButton.Text = "見積書プレビュー"
        Me.PrintPreviewButton.UseVisualStyleBackColor = True
        '
        'DetailsDataGridView
        '
        Me.DetailsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsDataGridView.AutoGenerateColumns = False
        Me.DetailsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DetailsDataGridView.DataSource = Me.BindingSource
        Me.DetailsDataGridView.Location = New System.Drawing.Point(20, 188)
        Me.DetailsDataGridView.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DetailsDataGridView.Name = "DetailsDataGridView"
        Me.DetailsDataGridView.RowHeadersVisible = False
        Me.DetailsDataGridView.RowHeadersWidth = 62
        Me.DetailsDataGridView.RowTemplate.Height = 21
        Me.DetailsDataGridView.Size = New System.Drawing.Size(1167, 280)
        Me.DetailsDataGridView.TabIndex = 8
        '
        'DueDateDateTimePicker
        '
        Me.DueDateDateTimePicker.Location = New System.Drawing.Point(827, 52)
        Me.DueDateDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.DueDateDateTimePicker.Name = "DueDateDateTimePicker"
        Me.DueDateDateTimePicker.Size = New System.Drawing.Size(217, 25)
        Me.DueDateDateTimePicker.TabIndex = 5
        '
        'DueDateLabel
        '
        Me.DueDateLabel.AutoSize = True
        Me.DueDateLabel.Location = New System.Drawing.Point(763, 57)
        Me.DueDateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.DueDateLabel.Name = "DueDateLabel"
        Me.DueDateLabel.Size = New System.Drawing.Size(44, 18)
        Me.DueDateLabel.TabIndex = 0
        Me.DueDateLabel.Text = "納期"
        '
        'PaymentConditionLabel
        '
        Me.PaymentConditionLabel.AutoSize = True
        Me.PaymentConditionLabel.Location = New System.Drawing.Point(20, 132)
        Me.PaymentConditionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PaymentConditionLabel.Name = "PaymentConditionLabel"
        Me.PaymentConditionLabel.Size = New System.Drawing.Size(80, 18)
        Me.PaymentConditionLabel.TabIndex = 0
        Me.PaymentConditionLabel.Text = "支払条件"
        '
        'PaymentConditionComboBox
        '
        Me.PaymentConditionComboBox.FormattingEnabled = True
        Me.PaymentConditionComboBox.Location = New System.Drawing.Point(118, 128)
        Me.PaymentConditionComboBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PaymentConditionComboBox.Name = "PaymentConditionComboBox"
        Me.PaymentConditionComboBox.Size = New System.Drawing.Size(341, 26)
        Me.PaymentConditionComboBox.TabIndex = 3
        '
        'PICEmployeeLabel
        '
        Me.PICEmployeeLabel.AutoSize = True
        Me.PICEmployeeLabel.Location = New System.Drawing.Point(723, 128)
        Me.PICEmployeeLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PICEmployeeLabel.Name = "PICEmployeeLabel"
        Me.PICEmployeeLabel.Size = New System.Drawing.Size(80, 18)
        Me.PICEmployeeLabel.TabIndex = 0
        Me.PICEmployeeLabel.Text = "担当営業"
        '
        'PICEmployeeComboBox
        '
        Me.PICEmployeeComboBox.FormattingEnabled = True
        Me.PICEmployeeComboBox.Location = New System.Drawing.Point(827, 123)
        Me.PICEmployeeComboBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PICEmployeeComboBox.Name = "PICEmployeeComboBox"
        Me.PICEmployeeComboBox.Size = New System.Drawing.Size(217, 26)
        Me.PICEmployeeComboBox.TabIndex = 7
        '
        'EffectiveDateLabel
        '
        Me.EffectiveDateLabel.AutoSize = True
        Me.EffectiveDateLabel.Location = New System.Drawing.Point(683, 93)
        Me.EffectiveDateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.EffectiveDateLabel.Name = "EffectiveDateLabel"
        Me.EffectiveDateLabel.Size = New System.Drawing.Size(116, 18)
        Me.EffectiveDateLabel.TabIndex = 0
        Me.EffectiveDateLabel.Text = "見積有効期限"
        '
        'EffectiveDateDateTimePicker
        '
        Me.EffectiveDateDateTimePicker.Location = New System.Drawing.Point(827, 88)
        Me.EffectiveDateDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EffectiveDateDateTimePicker.Name = "EffectiveDateDateTimePicker"
        Me.EffectiveDateDateTimePicker.Size = New System.Drawing.Size(217, 25)
        Me.EffectiveDateDateTimePicker.TabIndex = 6
        Me.EffectiveDateDateTimePicker.Value = New Date(2024, 6, 28, 10, 2, 15, 0)
        '
        'RemarksLabel
        '
        Me.RemarksLabel.AutoSize = True
        Me.RemarksLabel.Location = New System.Drawing.Point(23, 518)
        Me.RemarksLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.RemarksLabel.Name = "RemarksLabel"
        Me.RemarksLabel.Size = New System.Drawing.Size(44, 18)
        Me.RemarksLabel.TabIndex = 7
        Me.RemarksLabel.Text = "備考"
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RemarksTextBox.Location = New System.Drawing.Point(23, 540)
        Me.RemarksTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RemarksTextBox.Multiline = True
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(1222, 100)
        Me.RemarksTextBox.TabIndex = 12
        '
        'CustomerComboBox
        '
        Me.CustomerComboBox.FormattingEnabled = True
        Me.CustomerComboBox.Location = New System.Drawing.Point(118, 88)
        Me.CustomerComboBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CustomerComboBox.Name = "CustomerComboBox"
        Me.CustomerComboBox.Size = New System.Drawing.Size(341, 26)
        Me.CustomerComboBox.TabIndex = 2
        '
        'EstimateNoTextBox
        '
        Me.EstimateNoTextBox.Location = New System.Drawing.Point(118, 20)
        Me.EstimateNoTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EstimateNoTextBox.Name = "EstimateNoTextBox"
        Me.EstimateNoTextBox.ReadOnly = True
        Me.EstimateNoTextBox.Size = New System.Drawing.Size(341, 25)
        Me.EstimateNoTextBox.TabIndex = 0
        '
        'IssueDateDateTimePicker
        '
        Me.IssueDateDateTimePicker.Location = New System.Drawing.Point(827, 20)
        Me.IssueDateDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.IssueDateDateTimePicker.Name = "IssueDateDateTimePicker"
        Me.IssueDateDateTimePicker.Size = New System.Drawing.Size(217, 25)
        Me.IssueDateDateTimePicker.TabIndex = 4
        '
        'TaxRateLabel
        '
        Me.TaxRateLabel.AutoSize = True
        Me.TaxRateLabel.Location = New System.Drawing.Point(710, 486)
        Me.TaxRateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.TaxRateLabel.Name = "TaxRateLabel"
        Me.TaxRateLabel.Size = New System.Drawing.Size(44, 18)
        Me.TaxRateLabel.TabIndex = 0
        Me.TaxRateLabel.Text = "税率"
        '
        'TaxRateTextBox
        '
        Me.TaxRateTextBox.Location = New System.Drawing.Point(763, 482)
        Me.TaxRateTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TaxRateTextBox.Name = "TaxRateTextBox"
        Me.TaxRateTextBox.ReadOnly = True
        Me.TaxRateTextBox.Size = New System.Drawing.Size(74, 25)
        Me.TaxRateTextBox.TabIndex = 10
        '
        'EstimatePriceLabel
        '
        Me.EstimatePriceLabel.AutoSize = True
        Me.EstimatePriceLabel.Location = New System.Drawing.Point(342, 486)
        Me.EstimatePriceLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.EstimatePriceLabel.Name = "EstimatePriceLabel"
        Me.EstimatePriceLabel.Size = New System.Drawing.Size(98, 18)
        Me.EstimatePriceLabel.TabIndex = 0
        Me.EstimatePriceLabel.Text = "御見積金額"
        '
        'EstimatePriceTextBox
        '
        Me.EstimatePriceTextBox.Location = New System.Drawing.Point(460, 482)
        Me.EstimatePriceTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EstimatePriceTextBox.Name = "EstimatePriceTextBox"
        Me.EstimatePriceTextBox.ReadOnly = True
        Me.EstimatePriceTextBox.Size = New System.Drawing.Size(229, 25)
        Me.EstimatePriceTextBox.TabIndex = 9
        '
        'EstimatePriceIncludeTaxLabel
        '
        Me.EstimatePriceIncludeTaxLabel.AutoSize = True
        Me.EstimatePriceIncludeTaxLabel.Location = New System.Drawing.Point(850, 486)
        Me.EstimatePriceIncludeTaxLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.EstimatePriceIncludeTaxLabel.Name = "EstimatePriceIncludeTaxLabel"
        Me.EstimatePriceIncludeTaxLabel.Size = New System.Drawing.Size(144, 18)
        Me.EstimatePriceIncludeTaxLabel.TabIndex = 0
        Me.EstimatePriceIncludeTaxLabel.Text = "御見積金額(税込)"
        '
        'EstimatePriceIncludeTaxTextBox
        '
        Me.EstimatePriceIncludeTaxTextBox.Location = New System.Drawing.Point(1020, 482)
        Me.EstimatePriceIncludeTaxTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EstimatePriceIncludeTaxTextBox.Name = "EstimatePriceIncludeTaxTextBox"
        Me.EstimatePriceIncludeTaxTextBox.ReadOnly = True
        Me.EstimatePriceIncludeTaxTextBox.Size = New System.Drawing.Size(229, 25)
        Me.EstimatePriceIncludeTaxTextBox.TabIndex = 11
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        '
        'RowDownButton
        '
        Me.RowDownButton.Image = Global.Application.My.Resources.Resources.Download_grey_16x
        Me.RowDownButton.Location = New System.Drawing.Point(1197, 272)
        Me.RowDownButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RowDownButton.Name = "RowDownButton"
        Me.RowDownButton.Size = New System.Drawing.Size(55, 34)
        Me.RowDownButton.TabIndex = 16
        Me.RowDownButton.UseVisualStyleBackColor = True
        '
        'RowUpButton
        '
        Me.RowUpButton.Image = Global.Application.My.Resources.Resources.Upload_gray_16x
        Me.RowUpButton.Location = New System.Drawing.Point(1197, 228)
        Me.RowUpButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RowUpButton.Name = "RowUpButton"
        Me.RowUpButton.Size = New System.Drawing.Size(55, 34)
        Me.RowUpButton.TabIndex = 16
        Me.RowUpButton.UseVisualStyleBackColor = True
        '
        'RowRemoveButton
        '
        Me.RowRemoveButton.Image = Global.Application.My.Resources.Resources.RemoveRow_16x
        Me.RowRemoveButton.Location = New System.Drawing.Point(1197, 398)
        Me.RowRemoveButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RowRemoveButton.Name = "RowRemoveButton"
        Me.RowRemoveButton.Size = New System.Drawing.Size(55, 34)
        Me.RowRemoveButton.TabIndex = 15
        Me.RowRemoveButton.UseVisualStyleBackColor = True
        '
        'RowAddButton
        '
        Me.RowAddButton.Image = Global.Application.My.Resources.Resources.AddRow_16x
        Me.RowAddButton.Location = New System.Drawing.Point(1197, 354)
        Me.RowAddButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.RowAddButton.Name = "RowAddButton"
        Me.RowAddButton.Size = New System.Drawing.Size(55, 34)
        Me.RowAddButton.TabIndex = 15
        Me.RowAddButton.UseVisualStyleBackColor = True
        '
        'FocusEmphasizeProvider
        '
        Me.FocusEmphasizeProvider.Target = Me
        '
        'EstimateEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 692)
        Me.Controls.Add(Me.RowDownButton)
        Me.Controls.Add(Me.RowUpButton)
        Me.Controls.Add(Me.RowRemoveButton)
        Me.Controls.Add(Me.RowAddButton)
        Me.Controls.Add(Me.RemarksTextBox)
        Me.Controls.Add(Me.RemarksLabel)
        Me.Controls.Add(Me.PICEmployeeComboBox)
        Me.Controls.Add(Me.CustomerComboBox)
        Me.Controls.Add(Me.PaymentConditionComboBox)
        Me.Controls.Add(Me.EffectiveDateDateTimePicker)
        Me.Controls.Add(Me.IssueDateDateTimePicker)
        Me.Controls.Add(Me.DueDateDateTimePicker)
        Me.Controls.Add(Me.DetailsDataGridView)
        Me.Controls.Add(Me.PrintPreviewButton)
        Me.Controls.Add(Me.EntryButton)
        Me.Controls.Add(Me.TaxRateTextBox)
        Me.Controls.Add(Me.EstimatePriceTextBox)
        Me.Controls.Add(Me.EstimatePriceIncludeTaxTextBox)
        Me.Controls.Add(Me.EstimateNoTextBox)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Me.IssueDateLabel)
        Me.Controls.Add(Me.TaxRateLabel)
        Me.Controls.Add(Me.EstimatePriceLabel)
        Me.Controls.Add(Me.EstimatePriceIncludeTaxLabel)
        Me.Controls.Add(Me.EstimateNoLabel)
        Me.Controls.Add(Me.PICEmployeeLabel)
        Me.Controls.Add(Me.EffectiveDateLabel)
        Me.Controls.Add(Me.PaymentConditionLabel)
        Me.Controls.Add(Me.DueDateLabel)
        Me.Controls.Add(Me.CustomerLabel)
        Me.Controls.Add(Me.TitleLabel)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "EstimateEntry"
        Me.Text = "見積書の作成"
        CType(Me.DetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TitleLabel As Label
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents EstimateNoLabel As Label
    Friend WithEvents IssueDateLabel As Label
    Friend WithEvents CustomerLabel As Label
    Friend WithEvents EntryButton As Button
    Friend WithEvents PrintPreviewButton As Button
    Friend WithEvents DetailsDataGridView As DataGridView
    Friend WithEvents DueDateDateTimePicker As DateTimePicker
    Friend WithEvents DueDateLabel As Label
    Friend WithEvents PaymentConditionLabel As Label
    Friend WithEvents PaymentConditionComboBox As ComboBox
    Friend WithEvents PICEmployeeLabel As Label
    Friend WithEvents PICEmployeeComboBox As ComboBox
    Friend WithEvents EffectiveDateLabel As Label
    Friend WithEvents EffectiveDateDateTimePicker As DateTimePicker
    Friend WithEvents RemarksLabel As Label
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents CustomerComboBox As ComboBox
    Friend WithEvents EstimateNoTextBox As TextBox
    Friend WithEvents IssueDateDateTimePicker As DateTimePicker
    Friend WithEvents TaxRateLabel As Label
    Friend WithEvents TaxRateTextBox As TextBox
    Friend WithEvents EstimatePriceLabel As Label
    Friend WithEvents EstimatePriceTextBox As TextBox
    Friend WithEvents EstimatePriceIncludeTaxLabel As Label
    Friend WithEvents EstimatePriceIncludeTaxTextBox As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents FocusEmphasizeProvider As FocusEmphasizeProvider
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents RowRemoveButton As Button
    Friend WithEvents RowAddButton As Button
    Friend WithEvents RowDownButton As Button
    Friend WithEvents RowUpButton As Button
End Class
