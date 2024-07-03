<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerEntry
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
        Me.CompanyNameLabel = New System.Windows.Forms.Label()
        Me.CustomerNameTextBox = New System.Windows.Forms.TextBox()
        Me.PICLabel = New System.Windows.Forms.Label()
        Me.PaymentConditionLabel = New System.Windows.Forms.Label()
        Me.EntryButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerKanaNameTextBox = New System.Windows.Forms.TextBox()
        Me.PICComboBox = New System.Windows.Forms.ComboBox()
        Me.PaymentConditionComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Address2TextBox = New System.Windows.Forms.TextBox()
        Me.PostalCodeMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FocusEmphasizeProvider = New Application.FocusEmphasizeProvider()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.KokyakuTelTextBox = New System.Windows.Forms.TextBox()
        Me.KokyakuFaxTextBox = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Tanto1NameTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto1YakuTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto1BusyoTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto1KeitaiTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto2NameTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto2YakuTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto2BusyoTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto2KeitaiTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto3NameTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto3YakuTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto3BusyoTextBox = New System.Windows.Forms.TextBox()
        Me.Tanto3KeitaiTextBox = New System.Windows.Forms.TextBox()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CompanyNameLabel
        '
        Me.CompanyNameLabel.AutoSize = True
        Me.CompanyNameLabel.Location = New System.Drawing.Point(98, 24)
        Me.CompanyNameLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.CompanyNameLabel.Name = "CompanyNameLabel"
        Me.CompanyNameLabel.Size = New System.Drawing.Size(62, 18)
        Me.CompanyNameLabel.TabIndex = 1
        Me.CompanyNameLabel.Text = "顧客名"
        '
        'CustomerNameTextBox
        '
        Me.CustomerNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerNameTextBox.Location = New System.Drawing.Point(177, 20)
        Me.CustomerNameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CustomerNameTextBox.Name = "CustomerNameTextBox"
        Me.CustomerNameTextBox.Size = New System.Drawing.Size(247, 25)
        Me.CustomerNameTextBox.TabIndex = 0
        Me.ToolTip.SetToolTip(Me.CustomerNameTextBox, "顧客名を入力します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "最大100文字まで入力できます。")
        '
        'PICLabel
        '
        Me.PICLabel.AutoSize = True
        Me.PICLabel.Location = New System.Drawing.Point(58, 90)
        Me.PICLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PICLabel.Name = "PICLabel"
        Me.PICLabel.Size = New System.Drawing.Size(98, 18)
        Me.PICLabel.TabIndex = 1
        Me.PICLabel.Text = "営業担当者"
        '
        'PaymentConditionLabel
        '
        Me.PaymentConditionLabel.AutoSize = True
        Me.PaymentConditionLabel.Location = New System.Drawing.Point(78, 126)
        Me.PaymentConditionLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.PaymentConditionLabel.Name = "PaymentConditionLabel"
        Me.PaymentConditionLabel.Size = New System.Drawing.Size(80, 18)
        Me.PaymentConditionLabel.TabIndex = 1
        Me.PaymentConditionLabel.Text = "支払条件"
        '
        'EntryButton
        '
        Me.EntryButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryButton.Location = New System.Drawing.Point(749, 644)
        Me.EntryButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.EntryButton.Name = "EntryButton"
        Me.EntryButton.Size = New System.Drawing.Size(125, 34)
        Me.EntryButton.TabIndex = 7
        Me.EntryButton.Text = "登録"
        Me.EntryButton.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.BindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 57)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "顧客名(かな)"
        '
        'CustomerKanaNameTextBox
        '
        Me.CustomerKanaNameTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomerKanaNameTextBox.Location = New System.Drawing.Point(177, 52)
        Me.CustomerKanaNameTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CustomerKanaNameTextBox.Name = "CustomerKanaNameTextBox"
        Me.CustomerKanaNameTextBox.Size = New System.Drawing.Size(247, 25)
        Me.CustomerKanaNameTextBox.TabIndex = 1
        Me.ToolTip.SetToolTip(Me.CustomerKanaNameTextBox, "顧客名(かな)を入力します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "最大100文字まで入力できます。")
        '
        'PICComboBox
        '
        Me.PICComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PICComboBox.FormattingEnabled = True
        Me.PICComboBox.Location = New System.Drawing.Point(177, 82)
        Me.PICComboBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PICComboBox.Name = "PICComboBox"
        Me.PICComboBox.Size = New System.Drawing.Size(172, 26)
        Me.PICComboBox.TabIndex = 2
        Me.ToolTip.SetToolTip(Me.PICComboBox, "営業担当者を選びます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "選択肢に無い場合は「従業員台帳」へ新しい従業員を登録してください。")
        '
        'PaymentConditionComboBox
        '
        Me.PaymentConditionComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PaymentConditionComboBox.FormattingEnabled = True
        Me.PaymentConditionComboBox.Location = New System.Drawing.Point(177, 122)
        Me.PaymentConditionComboBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PaymentConditionComboBox.Name = "PaymentConditionComboBox"
        Me.PaymentConditionComboBox.Size = New System.Drawing.Size(172, 26)
        Me.PaymentConditionComboBox.TabIndex = 3
        Me.ToolTip.SetToolTip(Me.PaymentConditionComboBox, "この顧客の標準の支払条件を選びます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "選択肢に無い場合は「支払条件の管理」から新しい支払条件を追加してください。")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(78, 164)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "郵便番号"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 212)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "住所1"
        '
        'Address1TextBox
        '
        Me.Address1TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Address1TextBox.Location = New System.Drawing.Point(177, 209)
        Me.Address1TextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(313, 25)
        Me.Address1TextBox.TabIndex = 5
        Me.ToolTip.SetToolTip(Me.Address1TextBox, "この顧客の住所を入力します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "50文字まで入力できます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "この住所は見積書などで1段目に表示されます。")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(107, 256)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "住所2"
        '
        'Address2TextBox
        '
        Me.Address2TextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Address2TextBox.Location = New System.Drawing.Point(177, 253)
        Me.Address2TextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Address2TextBox.Name = "Address2TextBox"
        Me.Address2TextBox.Size = New System.Drawing.Size(313, 25)
        Me.Address2TextBox.TabIndex = 6
        Me.ToolTip.SetToolTip(Me.Address2TextBox, "この顧客の住所を入力します。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "50文字まで入力できます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "この住所は見積書などで2段目に表示されます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'PostalCodeMaskedTextBox
        '
        Me.PostalCodeMaskedTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PostalCodeMaskedTextBox.Location = New System.Drawing.Point(177, 161)
        Me.PostalCodeMaskedTextBox.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.PostalCodeMaskedTextBox.Mask = "000-0000"
        Me.PostalCodeMaskedTextBox.Name = "PostalCodeMaskedTextBox"
        Me.PostalCodeMaskedTextBox.Size = New System.Drawing.Size(172, 25)
        Me.PostalCodeMaskedTextBox.TabIndex = 4
        Me.ToolTip.SetToolTip(Me.PostalCodeMaskedTextBox, "この顧客の所在地の郵便番号を入力します。")
        '
        'FocusEmphasizeProvider
        '
        Me.FocusEmphasizeProvider.Target = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 27)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "電話番号"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(646, 157)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 18)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "FAX"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(102, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(219, 27)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "顧客担当者１名前"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(102, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(219, 27)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "顧客担当者１役職"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(102, 412)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(219, 27)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "顧客担当者１部署"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(102, 450)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(219, 27)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "顧客担当者１携帯"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(102, 494)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(219, 27)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "顧客担当者２名前"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(102, 531)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(219, 27)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "顧客担当者２役職"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(102, 571)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(219, 27)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "顧客担当者２部署"
        '
        'KokyakuTelTextBox
        '
        Me.KokyakuTelTextBox.Location = New System.Drawing.Point(452, 157)
        Me.KokyakuTelTextBox.Name = "KokyakuTelTextBox"
        Me.KokyakuTelTextBox.Size = New System.Drawing.Size(168, 25)
        Me.KokyakuTelTextBox.TabIndex = 17
        '
        'KokyakuFaxTextBox
        '
        Me.KokyakuFaxTextBox.Location = New System.Drawing.Point(692, 155)
        Me.KokyakuFaxTextBox.Name = "KokyakuFaxTextBox"
        Me.KokyakuFaxTextBox.Size = New System.Drawing.Size(175, 25)
        Me.KokyakuFaxTextBox.TabIndex = 18
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(102, 610)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(219, 27)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "顧客担当者２携帯"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(491, 371)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(219, 27)
        Me.Label15.TabIndex = 20
        Me.Label15.Text = "顧客担当者３役職"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(491, 329)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(219, 27)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "顧客担当者３名前"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(491, 412)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(219, 27)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "顧客担当者３部署"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(491, 450)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(219, 27)
        Me.Label18.TabIndex = 23
        Me.Label18.Text = "顧客担当者３携帯"
        '
        'Tanto1NameTextBox
        '
        Me.Tanto1NameTextBox.Location = New System.Drawing.Point(262, 326)
        Me.Tanto1NameTextBox.Name = "Tanto1NameTextBox"
        Me.Tanto1NameTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto1NameTextBox.TabIndex = 24
        '
        'Tanto1YakuTextBox
        '
        Me.Tanto1YakuTextBox.Location = New System.Drawing.Point(262, 368)
        Me.Tanto1YakuTextBox.Name = "Tanto1YakuTextBox"
        Me.Tanto1YakuTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto1YakuTextBox.TabIndex = 25
        '
        'Tanto1BusyoTextBox
        '
        Me.Tanto1BusyoTextBox.Location = New System.Drawing.Point(262, 409)
        Me.Tanto1BusyoTextBox.Name = "Tanto1BusyoTextBox"
        Me.Tanto1BusyoTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto1BusyoTextBox.TabIndex = 26
        '
        'Tanto1KeitaiTextBox
        '
        Me.Tanto1KeitaiTextBox.Location = New System.Drawing.Point(262, 447)
        Me.Tanto1KeitaiTextBox.Name = "Tanto1KeitaiTextBox"
        Me.Tanto1KeitaiTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto1KeitaiTextBox.TabIndex = 27
        '
        'Tanto2NameTextBox
        '
        Me.Tanto2NameTextBox.Location = New System.Drawing.Point(262, 491)
        Me.Tanto2NameTextBox.Name = "Tanto2NameTextBox"
        Me.Tanto2NameTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto2NameTextBox.TabIndex = 28
        '
        'Tanto2YakuTextBox
        '
        Me.Tanto2YakuTextBox.Location = New System.Drawing.Point(262, 528)
        Me.Tanto2YakuTextBox.Name = "Tanto2YakuTextBox"
        Me.Tanto2YakuTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto2YakuTextBox.TabIndex = 29
        '
        'Tanto2BusyoTextBox
        '
        Me.Tanto2BusyoTextBox.Location = New System.Drawing.Point(262, 568)
        Me.Tanto2BusyoTextBox.Name = "Tanto2BusyoTextBox"
        Me.Tanto2BusyoTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto2BusyoTextBox.TabIndex = 30
        '
        'Tanto2KeitaiTextBox
        '
        Me.Tanto2KeitaiTextBox.Location = New System.Drawing.Point(262, 607)
        Me.Tanto2KeitaiTextBox.Name = "Tanto2KeitaiTextBox"
        Me.Tanto2KeitaiTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto2KeitaiTextBox.TabIndex = 31
        '
        'Tanto3NameTextBox
        '
        Me.Tanto3NameTextBox.Location = New System.Drawing.Point(649, 326)
        Me.Tanto3NameTextBox.Name = "Tanto3NameTextBox"
        Me.Tanto3NameTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto3NameTextBox.TabIndex = 32
        '
        'Tanto3YakuTextBox
        '
        Me.Tanto3YakuTextBox.Location = New System.Drawing.Point(649, 368)
        Me.Tanto3YakuTextBox.Name = "Tanto3YakuTextBox"
        Me.Tanto3YakuTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto3YakuTextBox.TabIndex = 33
        '
        'Tanto3BusyoTextBox
        '
        Me.Tanto3BusyoTextBox.Location = New System.Drawing.Point(649, 409)
        Me.Tanto3BusyoTextBox.Name = "Tanto3BusyoTextBox"
        Me.Tanto3BusyoTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto3BusyoTextBox.TabIndex = 34
        '
        'Tanto3KeitaiTextBox
        '
        Me.Tanto3KeitaiTextBox.Location = New System.Drawing.Point(649, 447)
        Me.Tanto3KeitaiTextBox.Name = "Tanto3KeitaiTextBox"
        Me.Tanto3KeitaiTextBox.Size = New System.Drawing.Size(206, 25)
        Me.Tanto3KeitaiTextBox.TabIndex = 35
        '
        'CustomerEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 699)
        Me.Controls.Add(Me.Tanto3KeitaiTextBox)
        Me.Controls.Add(Me.Tanto3BusyoTextBox)
        Me.Controls.Add(Me.Tanto3YakuTextBox)
        Me.Controls.Add(Me.Tanto3NameTextBox)
        Me.Controls.Add(Me.Tanto2KeitaiTextBox)
        Me.Controls.Add(Me.Tanto2BusyoTextBox)
        Me.Controls.Add(Me.Tanto2YakuTextBox)
        Me.Controls.Add(Me.Tanto2NameTextBox)
        Me.Controls.Add(Me.Tanto1KeitaiTextBox)
        Me.Controls.Add(Me.Tanto1BusyoTextBox)
        Me.Controls.Add(Me.Tanto1YakuTextBox)
        Me.Controls.Add(Me.Tanto1NameTextBox)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.KokyakuFaxTextBox)
        Me.Controls.Add(Me.KokyakuTelTextBox)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.PostalCodeMaskedTextBox)
        Me.Controls.Add(Me.PaymentConditionComboBox)
        Me.Controls.Add(Me.PICComboBox)
        Me.Controls.Add(Me.EntryButton)
        Me.Controls.Add(Me.Address2TextBox)
        Me.Controls.Add(Me.Address1TextBox)
        Me.Controls.Add(Me.CustomerKanaNameTextBox)
        Me.Controls.Add(Me.CustomerNameTextBox)
        Me.Controls.Add(Me.PaymentConditionLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PICLabel)
        Me.Controls.Add(Me.CompanyNameLabel)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "CustomerEntry"
        Me.Text = "顧客の登録"
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CompanyNameLabel As Label
    Friend WithEvents CustomerNameTextBox As TextBox
    Friend WithEvents PICLabel As Label
    Friend WithEvents PaymentConditionLabel As Label
    Friend WithEvents EntryButton As Button
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents BindingSource As BindingSource
    Friend WithEvents CustomerKanaNameTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PICComboBox As ComboBox
    Friend WithEvents PaymentConditionComboBox As ComboBox
    Friend WithEvents Address2TextBox As TextBox
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PostalCodeMaskedTextBox As MaskedTextBox
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents FocusEmphasizeProvider As FocusEmphasizeProvider
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents KokyakuFaxTextBox As TextBox
    Friend WithEvents KokyakuTelTextBox As TextBox
    Friend WithEvents Tanto3KeitaiTextBox As TextBox
    Friend WithEvents Tanto3BusyoTextBox As TextBox
    Friend WithEvents Tanto3YakuTextBox As TextBox
    Friend WithEvents Tanto3NameTextBox As TextBox
    Friend WithEvents Tanto2KeitaiTextBox As TextBox
    Friend WithEvents Tanto2BusyoTextBox As TextBox
    Friend WithEvents Tanto2YakuTextBox As TextBox
    Friend WithEvents Tanto2NameTextBox As TextBox
    Friend WithEvents Tanto1KeitaiTextBox As TextBox
    Friend WithEvents Tanto1BusyoTextBox As TextBox
    Friend WithEvents Tanto1YakuTextBox As TextBox
    Friend WithEvents Tanto1NameTextBox As TextBox
End Class
