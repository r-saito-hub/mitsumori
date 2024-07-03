Option Strict On
Option Infer On

''' <summary>
''' 顧客登録画面
''' </summary>
Public Class CustomerEntry

#Region "プロパティ"

    Private _Customer As Domain.Customer
    ''' <summary>
    ''' 編集登録に利用する場合は編集するEmployeeのモデルオブジェクトを設定して呼び出しを行う
    ''' </summary>
    Public WriteOnly Property EditCustomer As Domain.Customer
        Set(value As Domain.Customer)
            _Customer = value
        End Set
    End Property

#End Region

#Region "メッセージ定数"

    Private Const SaveErrorMessage As String = "保存に失敗しました。時間をおいてもう一度お試しください。"

#End Region

#Region "イベント"

    ''' <summary>
    ''' 画面ロードイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomerEntry_Load(sender As Object, e As EventArgs) Handles Me.Load
        SetupControls()
    End Sub

    ''' <summary>
    ''' 登録ボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EntryButton_Click(sender As Object, e As EventArgs) Handles EntryButton.Click
        '登録に成功したら画面を閉じる
        If Save() = True Then
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' フォームをアクティベイト
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomerEntry_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'コントロールのデータソースを更新
        UpdateControlDataSource()
    End Sub

#End Region

#Region "コントロール制御"

    ''' <summary>
    ''' フォーム内のコントロールの初期設定を実行
    ''' </summary>
    Private Sub SetupControls()
        '=============================================================================
        '各コントロールの表示設定
        '=============================================================================
        '営業担当者
        SetupPICComboBox()
        '支払条件
        SetupPaymentConditionComboBox()

        '=============================================================================
        'ドメインオブジェクトをインスタンス化してフォームコントロールにバインディング
        '=============================================================================

        '編集用にオブジェクトが引き渡されている呼び出しでは引き渡されたインスタンスを利用する
        If _Customer Is Nothing Then
            '永続化用リポジトリのインスタンスを用意
            Dim custRepo = New Infrastructure.CustomerRepositoryImpl
            Dim payRepo = New Infrastructure.PaymentConditionRepositoryImpl
            Dim empRepo = New Infrastructure.EmployeeRepositoryImpl
            'ドメインオブジェクトを生成
            _Customer = New Domain.Customer(custRepo, payRepo, empRepo)
        End If
        'バインディング
        Me.BindingSource.DataSource = _Customer

        '=============================================================================
        '各コントロールとバインディングオブジェクトを紐づけ
        '=============================================================================
        '会社名
        CustomerNameTextBox.DataBindings.Add(NameOf(CustomerNameTextBox.Text), BindingSource, NameOf(_Customer.Name))
        'かな名
        CustomerKanaNameTextBox.DataBindings.Add(NameOf(CustomerKanaNameTextBox.Text), BindingSource, NameOf(_Customer.KanaName))
        '営業担当者
        PICComboBox.DataBindings.Add(NameOf(PICComboBox.SelectedValue), BindingSource, NameOf(_Customer.PIC))
        '支払条件
        PaymentConditionComboBox.DataBindings.Add(NameOf(PaymentConditionComboBox.SelectedValue), BindingSource, NameOf(_Customer.PaymentCondition))
        '郵便番号
        PostalCodeMaskedTextBox.DataBindings.Add(NameOf(PostalCodeMaskedTextBox.Text), BindingSource, NameOf(_Customer.PostalCode))
        '住所1
        Address1TextBox.DataBindings.Add(NameOf(Address1TextBox.Text), BindingSource, NameOf(_Customer.Address1))
        '住所2
        Address2TextBox.DataBindings.Add(NameOf(Address2TextBox.Text), BindingSource, NameOf(_Customer.Address2))
        '顧客TEL
        KokyakuTelTextBox.DataBindings.Add(NameOf(KokyakuTelTextBox.Text), BindingSource, NameOf(_Customer.Kokyaku_tel))
        '顧客FAX
        KokyakuFaxTextBox.DataBindings.Add(NameOf(KokyakuFaxTextBox.Text), BindingSource, NameOf(_Customer.Kokyaku_fax))
        '顧客担当者１名前
        Tanto1NameTextBox.DataBindings.Add(NameOf(Tanto1NameTextBox.Text), BindingSource, NameOf(_Customer.Tanto1_name))
        '顧客担当者１役職
        Tanto1YakuTextBox.DataBindings.Add(NameOf(Tanto1YakuTextBox.Text), BindingSource, NameOf(_Customer.Tanto1_yaku))
        '顧客担当者１部署
        Tanto1BusyoTextBox.DataBindings.Add(NameOf(Tanto1BusyoTextBox.Text), BindingSource, NameOf(_Customer.Tanto1_busyo))
        '顧客担当者１部署
        Tanto1KeitaiTextBox.DataBindings.Add(NameOf(Tanto1KeitaiTextBox.Text), BindingSource, NameOf(_Customer.Tanto1_keitai))
        '顧客担当者２名前
        Tanto2NameTextBox.DataBindings.Add(NameOf(Tanto2NameTextBox.Text), BindingSource, NameOf(_Customer.Tanto2_name))
        '顧客担当者２役職
        Tanto2YakuTextBox.DataBindings.Add(NameOf(Tanto2YakuTextBox.Text), BindingSource, NameOf(_Customer.Tanto2_yaku))
        '顧客担当者２部署
        Tanto2BusyoTextBox.DataBindings.Add(NameOf(Tanto2BusyoTextBox.Text), BindingSource, NameOf(_Customer.Tanto2_busyo))
        '顧客担当者２部署
        Tanto2KeitaiTextBox.DataBindings.Add(NameOf(Tanto2KeitaiTextBox.Text), BindingSource, NameOf(_Customer.Tanto2_keitai))
        '顧客担当者３名前
        Tanto3NameTextBox.DataBindings.Add(NameOf(Tanto3NameTextBox.Text), BindingSource, NameOf(_Customer.Tanto3_name))
        '顧客担当者３役職
        Tanto3YakuTextBox.DataBindings.Add(NameOf(Tanto3YakuTextBox.Text), BindingSource, NameOf(_Customer.Tanto3_yaku))
        '顧客担当者３部署
        Tanto3BusyoTextBox.DataBindings.Add(NameOf(Tanto3BusyoTextBox.Text), BindingSource, NameOf(_Customer.Tanto3_busyo))
        '顧客担当者３部署
        Tanto3KeitaiTextBox.DataBindings.Add(NameOf(Tanto3KeitaiTextBox.Text), BindingSource, NameOf(_Customer.Tanto3_keitai))
        '=============================================================================
        'エラープロバイダのデータソースにフォームを紐づけたバインディングソースを割り当て
        '=============================================================================
        Me.ErrorProvider.DataSource = BindingSource
    End Sub

    ''' <summary>
    ''' 営業担当者のコンボボックスを設定
    ''' </summary>
    Private Sub SetupPICComboBox()
        '現状のコンボボックスの値を退避
        Dim tmp = PICComboBox.SelectedValue

        Dim displayValues As New List(Of KeyValuePair(Of String, Domain.Employee))

        '従業員情報を取得してコンボボックスメンバに利用
        Dim repo = New Infrastructure.EmployeeRepositoryImpl
        Dim emps = repo.FindAllEmployee
        For Each e In emps
            Dim kvp = New KeyValuePair(Of String, Domain.Employee)(e.Name, e)
            displayValues.Add(kvp)
        Next

        'ComboBoxの設定
        PICComboBox.ValueMember = "Value"
        PICComboBox.DisplayMember = "Key"
        PICComboBox.DataSource = displayValues

        '退避した値を戻す
        If tmp IsNot Nothing Then
            PICComboBox.SelectedValue = tmp
        End If
    End Sub

    ''' <summary>
    ''' 支払条件のコンボボックスを設定
    ''' </summary>
    Private Sub SetupPaymentConditionComboBox()
        '現状の値を退避
        Dim tmp = PaymentConditionComboBox.SelectedValue

        Dim displayValues As New List(Of KeyValuePair(Of String, Domain.PaymentCondition))

        '支払条件情報を取得してコンボボックスメンバに利用
        Dim repo = New Infrastructure.PaymentConditionRepositoryImpl
        Dim pays = repo.FindAllPaymentCondition
        For Each e In pays
            Dim kvp = New KeyValuePair(Of String, Domain.PaymentCondition)(e.Name, e)
            displayValues.Add(kvp)
        Next

        'ComboBoxの設定
        PaymentConditionComboBox.ValueMember = "Value"
        PaymentConditionComboBox.DisplayMember = "Key"
        PaymentConditionComboBox.DataSource = displayValues

        '退避した値を戻す
        If tmp IsNot Nothing Then
            PaymentConditionComboBox.SelectedValue = tmp
        End If
    End Sub

    ''' <summary>
    ''' コントロールのデータソースを更新
    ''' </summary>
    Private Sub UpdateControlDataSource()
        SetupPICComboBox()
        SetupPaymentConditionComboBox()
    End Sub

#End Region

#Region "永続化"

    ''' <summary>
    ''' フォームの入力内容で登録処理を実行
    ''' </summary>
    ''' <returns>登録成功:True 登録失敗:False</returns>
    Private Function Save() As Boolean
        'ドメインオブジェクトの正当性を確認
        If _Customer.Validate() = False Then
            'エラー情報を更新
            Me.ErrorProvider.UpdateBinding()
            Return False
        End If
        '登録
        If _Customer.Save() = False Then
            MessageBox.Show(SaveErrorMessage)
        End If
        Return True
    End Function

#End Region

End Class
