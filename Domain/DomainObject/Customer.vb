Option Strict On
Option Infer On

Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection.Emit

''' <summary>
''' 顧客1社を表現する
''' </summary>
Public Class Customer
    Implements IDataErrorInfo

#Region "定数"

    Const NameDoNotEmpty As String = "顧客名は必ず入力が必要です"
    Const NameIsAlreadyExist As String = "この顧客名は既に登録済みです"
    Const NameIsTooLong As String = "顧客名は50文字以内での入力が必要です"
    Const KanaNameDoNotEmpty As String = "顧客名かなは必ず入力が必要です"
    Const KanaNameIsTooLong As String = "顧客名かなは50文字以内での入力が必要です"
    Const PICDoNotEmpty As String = "営業担当者は必ず指定してください"
    Const PICIsNotFound As String = "未登録の従業員は利用できません"
    Const PaymentConditionDoNotEmpty As String = "支払条件は必ず指定してください"
    Const PaymentConditionIsNotFound As String = "未登録の支払条件は利用できません"
    Const PostalCodeDoNotNothing As String = "郵便番号の入力内容が不正です"
    Const PostalCodeLengthMustBeSeven As String = "郵便番号は8桁で入力してください"
    Const Address1IsTooLong As String = "住所1は50文字以内で入力してください"
    Const Address1DoNotEmpty As String = "住所1は必ず入力してください"
    Const Address2DoNotNothing As String = "住所2の入力内容が不正です"
    Const Address2IsTooLong As String = "住所2は50文字以内で入力してください"

#End Region

#Region "リポジトリへのポインタ"

    Private _CustomerRepo As ICustomerRepository
    Private _PaymentConditionRepo As IPaymentConditionRepository
    Private _EmployeeRepo As IEmployeeRepository

#End Region

#Region "コンストラクタ"

    Public Sub New(ByVal custRepo As ICustomerRepository, ByVal payRepo As IPaymentConditionRepository, ByVal empRepo As IEmployeeRepository)
        _ID = -1
        _CustomerRepo = custRepo
        _PaymentConditionRepo = payRepo
        _EmployeeRepo = empRepo
        _Name = String.Empty
        _KanaName = String.Empty
        _PIC = Nothing
        _PaymentCondition = Nothing
        _PostalCode = String.Empty
        _Address1 = String.Empty
        _Address2 = String.Empty
        _Kokyaku_tel = String.Empty
        _Kokyaku_fax = String.Empty
        _Tanto1_name = String.Empty
        _Tanto1_yaku = String.Empty
        _Tanto1_busyo = String.Empty
        _Tanto1_keitai = String.Empty
        _Tanto2_name = String.Empty
        _Tanto2_yaku = String.Empty
        _Tanto2_busyo = String.Empty
        _Tanto2_keitai = String.Empty
        _Tanto3_name = String.Empty
        _Tanto3_yaku = String.Empty
        _Tanto3_busyo = String.Empty
        _Tanto3_keitai = String.Empty

    End Sub

    Public Sub New(ByVal id As Integer, ByVal custRepo As ICustomerRepository, ByVal payRepo As IPaymentConditionRepository, ByVal empRepo As IEmployeeRepository)
        _ID = id
        _CustomerRepo = custRepo
        _PaymentConditionRepo = payRepo
        _EmployeeRepo = empRepo
        _Name = String.Empty
        _KanaName = String.Empty
        _PIC = Nothing
        _PaymentCondition = Nothing
        _PostalCode = String.Empty
        _Address1 = String.Empty
        _Address2 = String.Empty
        _Kokyaku_tel = String.Empty
        _Kokyaku_fax = String.Empty
        _Tanto1_name = String.Empty
        _Tanto1_yaku = String.Empty
        _Tanto1_busyo = String.Empty
        _Tanto1_keitai = String.Empty
        _Tanto2_name = String.Empty
        _Tanto2_yaku = String.Empty
        _Tanto2_busyo = String.Empty
        _Tanto2_keitai = String.Empty
        _Tanto3_name = String.Empty
        _Tanto3_yaku = String.Empty
        _Tanto3_busyo = String.Empty
        _Tanto3_keitai = String.Empty

    End Sub

#End Region

#Region "値プロパティ"

    ''' <summary>
    ''' ID(オブジェクトの永続化がされていないものは-1)
    ''' </summary>
    Public ReadOnly Property ID As Integer

    Private _Name As String
    ''' <summary>
    ''' 顧客名
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String
        Set(value As String)
            _Name = value
            ValidateName()
        End Set
        Get
            Return _Name
        End Get
    End Property

    Private _KanaName As String
    ''' <summary>
    ''' 顧客名かな
    ''' </summary>
    ''' <returns></returns>
    Public Property KanaName As String
        Get
            Return _KanaName
        End Get
        Set(value As String)
            _KanaName = value
            ValidateKanaName()
        End Set
    End Property

    Private _PIC As Employee
    ''' <summary>
    ''' 営業担当者
    ''' </summary>
    ''' <returns></returns>
    Public Property PIC As Employee
        Get
            Return _PIC
        End Get
        Set(value As Employee)
            _PIC = value
            ValidatePIC()
        End Set
    End Property

    Private _PaymentCondition As PaymentCondition
    ''' <summary>
    ''' 支払条件
    ''' </summary>
    ''' <returns></returns>
    Public Property PaymentCondition As PaymentCondition
        Get
            Return _PaymentCondition
        End Get
        Set(value As PaymentCondition)
            _PaymentCondition = value
            ValidatePaymentCondition()
        End Set
    End Property

    Private _PostalCode As String
    ''' <summary>
    ''' 郵便番号
    ''' </summary>
    ''' <returns></returns>
    Public Property PostalCode As String
        Get
            Return _PostalCode
        End Get
        Set(value As String)
            _PostalCode = value
            ValidatePostalCode()
        End Set
    End Property

    Private _Address1 As String
    ''' <summary>
    ''' 住所1
    ''' </summary>
    ''' <returns></returns>
    Public Property Address1 As String
        Get
            Return _Address1
        End Get
        Set(value As String)
            _Address1 = value
            ValidateAddress1()
        End Set
    End Property

    Private _Address2 As String
    ''' <summary>
    ''' 住所2
    ''' </summary>
    ''' <returns></returns>
    Public Property Address2 As String
        Get
            Return _Address2
        End Get
        Set(value As String)
            _Address2 = value
            ValidateAddress2()
        End Set
    End Property

    Private _Kokyaku_tel As String
    ''' <summary>
    ''' 顧客電話番号
    ''' </summary>
    ''' <returns></returns>
    Public Property Kokyaku_tel As String
        Get
            Return _Kokyaku_tel
        End Get
        Set(value As String)
            _Kokyaku_tel = value
            Validatekokyaku_tel()
        End Set
    End Property

    Private _Kokyaku_fax As String
    ''' <summary>
    ''' 顧客FAX
    ''' </summary>
    ''' <returns></returns>
    Public Property Kokyaku_fax As String
        Get
            Return _Kokyaku_fax
        End Get
        Set(value As String)
            _Kokyaku_fax = value
            Validatekokyaku_fax()
        End Set
    End Property

    Private _Tanto1_name As String
    ''' <summary>
    ''' 顧客担当者１名前
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto1_name As String
        Get
            Return _Tanto1_name
        End Get
        Set(value As String)
            _Tanto1_name = value
            Validatetanto1_name()
        End Set
    End Property

    Private _Tanto1_yaku As String
    ''' <summary>
    ''' 顧客担当者役職
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto1_yaku As String
        Get
            Return _Tanto1_yaku
        End Get
        Set(value As String)
            _Tanto1_yaku = value
            Validatetanto1_yaku()
        End Set
    End Property

    Private _Tanto1_busyo As String
    ''' <summary>
    ''' 顧客担当者部署
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto1_busyo As String
        Get
            Return _Tanto1_busyo
        End Get
        Set(value As String)
            _Tanto1_busyo = value
            Validatetanto1_busyo()
        End Set
    End Property

    Private _Tanto1_keitai As String
    ''' <summary>
    ''' 顧客担当者部署
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto1_keitai As String
        Get
            Return _Tanto1_keitai
        End Get
        Set(value As String)
            _Tanto1_keitai = value
            Validatetanto1_keitai()
        End Set
    End Property

    Private _Tanto2_name As String
    ''' <summary>
    ''' 顧客担当者１名前
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto2_name As String
        Get
            Return _Tanto2_name
        End Get
        Set(value As String)
            _Tanto2_name = value
            Validatetanto2_name()
        End Set
    End Property

    Private _Tanto2_yaku As String
    ''' <summary>
    ''' 顧客担当者役職
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto2_yaku As String
        Get
            Return _Tanto2_yaku
        End Get
        Set(value As String)
            _Tanto2_yaku = value
            Validatetanto2_yaku()
        End Set
    End Property

    Private _Tanto2_busyo As String
    ''' <summary>
    ''' 顧客担当者部署
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto2_busyo As String
        Get
            Return _Tanto2_busyo
        End Get
        Set(value As String)
            _Tanto2_busyo = value
            Validatetanto2_busyo()
        End Set
    End Property

    Private _Tanto2_keitai As String
    ''' <summary>
    ''' 顧客担当者部署
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto2_keitai As String
        Get
            Return _Tanto2_keitai
        End Get
        Set(value As String)
            _Tanto2_keitai = value
            Validatetanto2_keitai()
        End Set
    End Property

    Private _Tanto3_name As String
    ''' <summary>
    ''' 顧客担当者１名前
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto3_name As String
        Get
            Return _Tanto3_name
        End Get
        Set(value As String)
            _Tanto3_name = value
            Validatetanto3_name()
        End Set
    End Property

    Private _Tanto3_yaku As String
    ''' <summary>
    ''' 顧客担当者役職
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto3_yaku As String
        Get
            Return _Tanto3_yaku
        End Get
        Set(value As String)
            _Tanto3_yaku = value
            Validatetanto3_yaku()
        End Set
    End Property

    Private _Tanto3_busyo As String
    ''' <summary>
    ''' 顧客担当者部署
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto3_busyo As String
        Get
            Return _Tanto3_busyo
        End Get
        Set(value As String)
            _Tanto3_busyo = value
            Validatetanto3_busyo()
        End Set
    End Property

    Private _Tanto3_keitai As String
    ''' <summary>
    ''' 顧客担当者部署
    ''' </summary>
    ''' <returns></returns>
    Public Property Tanto3_keitai As String
        Get
            Return _Tanto3_keitai
        End Get
        Set(value As String)
            _Tanto3_keitai = value
            Validatetanto3_keitai()
        End Set
    End Property
#End Region

#Region "エラープロパティ"

    ''' <summary>
    ''' エラー保持変数
    ''' </summary>
    Private _errors As New Dictionary(Of String, String)

    ''' <summary>
    ''' このオブジェクトの状態にエラーがあればTrue
    ''' </summary>
    ''' <returns></returns>
    Public Function HasError() As Boolean
        Return _errors.Count <> 0
    End Function

    ''' <summary>
    ''' 指定プロパティにエラーがあればメッセージを返す
    ''' </summary>
    ''' <param name="columnName"></param>
    ''' <returns></returns>
    Default Public ReadOnly Property Item(columnName As String) As String Implements IDataErrorInfo.Item
        Get
            If _errors.ContainsKey(columnName) = False Then
                Return String.Empty
            End If
            Return _errors(columnName)
        End Get
    End Property

    ''' <summary>
    ''' このオブジェクト全体で整合性を保てていないエラーがあればメッセージを返す
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property [Error] As String Implements IDataErrorInfo.Error
        Get
            Return String.Empty
        End Get
    End Property

#End Region

#Region "検証メソッド"

    ''' <summary>
    ''' オブジェクトの整合性チェックを実施
    ''' </summary>
    ''' <returns></returns>
    Public Function Validate() As Boolean
        ValidateName()
        ValidateKanaName()
        ValidatePIC()
        ValidatePaymentCondition()
        ValidatePostalCode()
        ValidateAddress1()
        ValidateAddress2()

        '永続化も含めた項目全体の整合性チェックを実施
        'エラーリストのクリアのため他の要素の後に実施しないとならない
        ValidateTotalItems()

        Return Me.HasError = False
    End Function

    ''' <summary>
    ''' 永続化も含めた要素全体の整合性チェックを実施
    ''' </summary>
    Private Sub ValidateTotalItems()
        'ほかのチェックに引っかかってたらDBアクセス前に例外発生があり得るので戻してやる
        If Me.HasError = True Then
            Return
        End If

        '未登録の従業員は指定できない
        If _EmployeeRepo.FindByID(_PIC.ID) Is Nothing Then
            _errors(NameOf(PIC)) = PICIsNotFound
        End If
        '登録されていない支払条件は利用できない
        If _PaymentConditionRepo.FindByID(_PaymentCondition.ID) Is Nothing Then
            _errors(NameOf(PaymentCondition)) = PaymentConditionIsNotFound
        End If
        '同一社名が同じ住所で登録済みの場合は利用できない
        '(更新の場合は問題ないのでID比較で異なる場合だけエラーにする)
        Dim cust = _CustomerRepo.FindByCustomerNameAndAddress(_Name, _Address1, _Address2)
        If cust IsNot Nothing AndAlso cust.ID <> Me.ID Then
            _errors(NameOf(Name)) = NameIsAlreadyExist
        End If
    End Sub

    ''' <summary>
    ''' 顧客名を検証
    ''' </summary>
    Private Sub ValidateName()
        '一度エラーをクリア
        _errors.Remove(NameOf(Name))

        '名前はNothing不可
        If _Name Is Nothing Then
            _errors(NameOf(Name)) = NameDoNotEmpty
            Return
        End If

        '名前は未指定ではいけない
        If _Name = String.Empty Then
            _errors(NameOf(Name)) = NameDoNotEmpty
        End If
        '名前は50文字以内でなければならない
        If _Name.Length > 50 Then
            _errors(NameOf(Name)) = NameIsTooLong
        End If
    End Sub

    ''' <summary>
    ''' 顧客名かなを検証
    ''' </summary>
    Private Sub ValidateKanaName()
        '一度エラーをクリア
        _errors.Remove(NameOf(KanaName))

        'かな名は未指定ではいけない
        If _KanaName Is Nothing Then
            _errors(NameOf(KanaName)) = KanaNameDoNotEmpty
            Return
        End If

        'かな名は未指定ではいけない
        If _KanaName = String.Empty Then
            _errors(NameOf(KanaName)) = KanaNameDoNotEmpty
        End If
        'かな名は50文字以内でなければならない
        If _KanaName.Length > 50 Then
            _errors(NameOf(KanaName)) = KanaNameIsTooLong
        End If
    End Sub

    ''' <summary>
    ''' 営業担当者名を検証
    ''' </summary>
    Private Sub ValidatePIC()
        '一度エラーをクリア
        _errors.Remove(NameOf(PIC))

        '営業担当者名は必ず入力しなければならない
        If _PIC Is Nothing Then
            _errors(NameOf(PIC)) = PICDoNotEmpty
            Return
        End If
    End Sub

    ''' <summary>
    ''' 支払条件を検証
    ''' </summary>
    Private Sub ValidatePaymentCondition()
        '一度エラーをクリア
        _errors.Remove(NameOf(PaymentCondition))

        '支払条件は未指定ではならない
        If _PaymentCondition Is Nothing Then
            _errors(NameOf(PaymentCondition)) = PaymentConditionDoNotEmpty
            Return
        End If
    End Sub

    ''' <summary>
    ''' 郵便番号を検証
    ''' </summary>
    Private Sub ValidatePostalCode()
        '一度エラーをクリア
        _errors.Remove(NameOf(PostalCode))

        'Nothingは許可しない
        If _PostalCode Is Nothing Then
            _errors(NameOf(PostalCode)) = PostalCodeDoNotNothing
            Return
        End If

        '郵便番号は未入力可
        If _PostalCode = String.Empty Then
            Return
        End If

        '郵便番号は必ず7桁
        If _PostalCode.Length <> 8 Then
            _errors(NameOf(PostalCode)) = PostalCodeLengthMustBeSeven
        End If
    End Sub

    ''' <summary>
    ''' 住所1を検証
    ''' </summary>
    Private Sub ValidateAddress1()
        '一度エラーをクリア
        _errors.Remove(NameOf(Address1))

        'Nothingは許可しない
        If _Address1 Is Nothing Then
            _errors(NameOf(Address1)) = Address1DoNotEmpty
            Return
        End If

        '住所1は必ず入力
        If _Address1.Length = 0 Then
            _errors(NameOf(Address1)) = Address1DoNotEmpty
        End If

        '住所1は必ず50文字以内
        If _Address1.Length > 50 Then
            _errors(NameOf(_Address1)) = Address1IsTooLong
        End If
    End Sub

    ''' <summary>
    ''' 住所2を検証
    ''' </summary>
    Private Sub ValidateAddress2()
        '一度エラーをクリア
        _errors.Remove(NameOf(Address2))

        'Nothingは許可しない
        If _Address2 Is Nothing Then
            _errors(NameOf(Address2)) = Address2DoNotNothing
            Return
        End If

        '住所2は必ず50文字以内
        If _Address2.Length > 50 Then
            _errors(NameOf(_Address2)) = Address2IsTooLong
        End If
    End Sub

    ''' <summary>
    ''' 顧客電話番号を検証
    ''' </summary>
    Private Sub Validatekokyaku_tel()

    End Sub

    ''' <summary>
    ''' 顧客FAX番号を検証
    ''' </summary>
    Private Sub Validatekokyaku_fax()
    End Sub

    ''' <summary>
    ''' 顧客担当者１名前を検証
    ''' </summary>
    Private Sub Validatetanto1_name()

    End Sub
    ''' <summary>
    ''' 顧客担当者１役職を検証
    ''' </summary>
    Private Sub Validatetanto1_yaku()

    End Sub

    ''' <summary>
    ''' 顧客担当者１部署検証
    ''' </summary>
    Private Sub Validatetanto1_busyo()

    End Sub

    ''' <summary>
    ''' 顧客担当者１携帯を検証
    ''' </summary>
    Private Sub Validatetanto1_keitai()

    End Sub

    ''' <summary>
    ''' 顧客担当者２名前を検証
    ''' </summary>
    Private Sub Validatetanto2_name()

    End Sub
    ''' <summary>
    ''' 顧客担当者２役職を検証
    ''' </summary>
    Private Sub Validatetanto2_yaku()

    End Sub

    ''' <summary>
    ''' 顧客担当者２部署検証
    ''' </summary>
    Private Sub Validatetanto2_busyo()

    End Sub

    ''' <summary>
    ''' 顧客担当者２携帯を検証
    ''' </summary>
    Private Sub Validatetanto2_keitai()

    End Sub

    ''' <summary>
    ''' 顧客担当者３名前を検証
    ''' </summary>
    Private Sub Validatetanto3_name()

    End Sub
    ''' <summary>
    ''' 顧客担当者３役職を検証
    ''' </summary>
    Private Sub Validatetanto3_yaku()

    End Sub

    ''' <summary>
    ''' 顧客担当者３部署検証
    ''' </summary>
    Private Sub Validatetanto3_busyo()

    End Sub

    ''' <summary>
    ''' 顧客担当者３携帯を検証
    ''' </summary>
    Private Sub Validatetanto3_keitai()

    End Sub

#End Region

#Region "CRUD"

    ''' <summary>
    ''' このオブジェクトを永続化する
    ''' </summary>
    ''' <returns>登録成功:True 登録失敗:False</returns>
    Public Function Save() As Boolean
        If _CustomerRepo.Save(Me) = False Then
            Return False
        End If
        _ID = _CustomerRepo.LastInsertID
        Return True
    End Function

#End Region

#Region "オーバーライド"

    Public Overrides Function Equals(obj As Object) As Boolean
        '型が異なれば異なる
        If obj.GetType <> GetType(Customer) Then
            Return False
        End If
        Dim c = DirectCast(obj, Customer)

        'ID値が同じなら同じ
        Return Me.ID = c.ID
    End Function

#End Region


End Class
