VERSION 5.00
Begin VB.Form PPVBFlexGridStyle 
   Caption         =   "Style"
   ClientHeight    =   7425
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   6225
   LockControls    =   -1  'True
   PaletteMode     =   0  'Halftone
   ScaleHeight     =   7425
   ScaleWidth      =   6225
   Begin VB.CheckBox CheckSingleLine 
      Alignment       =   1  'Right Justify
      Caption         =   "SingleLine"
      Height          =   285
      Left            =   3120
      TabIndex        =   27
      Top             =   3120
      Width           =   1650
   End
   Begin VB.TextBox TextFormatString 
      Height          =   675
      Left            =   1560
      MultiLine       =   -1  'True
      ScrollBars      =   2  'Vertical
      TabIndex        =   29
      Top             =   3480
      Width           =   4395
   End
   Begin VB.ComboBox ComboEllipsisFormatFixed 
      Height          =   315
      Left            =   4560
      Style           =   2  'Dropdown List
      TabIndex        =   25
      Top             =   2640
      Width           =   1380
   End
   Begin VB.ComboBox ComboEllipsisFormat 
      Height          =   315
      Left            =   1560
      Style           =   2  'Dropdown List
      TabIndex        =   23
      Top             =   2640
      Width           =   1380
   End
   Begin VB.ComboBox ComboPictureType 
      Height          =   315
      Left            =   1560
      Style           =   2  'Dropdown List
      TabIndex        =   21
      Top             =   2280
      Width           =   1380
   End
   Begin VB.ComboBox ComboMergeCells 
      Height          =   315
      Left            =   1560
      Style           =   2  'Dropdown List
      TabIndex        =   19
      Top             =   1920
      Width           =   1380
   End
   Begin VB.CheckBox CheckWordWrap 
      Alignment       =   1  'Right Justify
      Caption         =   "WordWrap"
      Height          =   285
      Left            =   120
      TabIndex        =   26
      Top             =   3075
      Width           =   1650
   End
   Begin VB.TextBox TextColWidthMax 
      Height          =   315
      Left            =   4560
      TabIndex        =   17
      Top             =   1560
      Width           =   1380
   End
   Begin VB.TextBox TextColWidthMin 
      Height          =   315
      Left            =   1560
      TabIndex        =   15
      Top             =   1560
      Width           =   1380
   End
   Begin VB.TextBox TextRowHeightMax 
      Height          =   315
      Left            =   4560
      TabIndex        =   13
      Top             =   1200
      Width           =   1380
   End
   Begin VB.TextBox TextRowHeightMin 
      Height          =   315
      Left            =   1560
      TabIndex        =   11
      Top             =   1200
      Width           =   1380
   End
   Begin VB.ComboBox ComboTextStyleFixed 
      Height          =   315
      Left            =   4560
      Style           =   2  'Dropdown List
      TabIndex        =   9
      Top             =   840
      Width           =   1380
   End
   Begin VB.ComboBox ComboTextStyle 
      Height          =   315
      Left            =   1560
      Style           =   2  'Dropdown List
      TabIndex        =   7
      Top             =   840
      Width           =   1380
   End
   Begin VB.TextBox TextGridLineWidth 
      Height          =   315
      Left            =   1560
      TabIndex        =   5
      Top             =   480
      Width           =   1380
   End
   Begin VB.ComboBox ComboGridLinesFixed 
      Height          =   315
      Left            =   4560
      Style           =   2  'Dropdown List
      TabIndex        =   3
      Top             =   120
      Width           =   1380
   End
   Begin VB.ComboBox ComboGridLines 
      Height          =   315
      Left            =   1560
      Style           =   2  'Dropdown List
      TabIndex        =   1
      Top             =   120
      Width           =   1380
   End
   Begin VB.Label LabelFormatString 
      Caption         =   "FormatString:"
      Height          =   240
      Left            =   120
      TabIndex        =   28
      Top             =   3480
      Width           =   1410
   End
   Begin VB.Label LabelEllipsisFormatFixed 
      Caption         =   "EllipsisFormatFixed:"
      Height          =   240
      Left            =   3120
      TabIndex        =   24
      Top             =   2640
      Width           =   1410
   End
   Begin VB.Label LabelEllipsisFormat 
      Caption         =   "EllipsisFormat:"
      Height          =   240
      Left            =   120
      TabIndex        =   22
      Top             =   2640
      Width           =   1410
   End
   Begin VB.Label LabelPictureType 
      Caption         =   "PictureType:"
      Height          =   240
      Left            =   120
      TabIndex        =   20
      Top             =   2280
      Width           =   1410
   End
   Begin VB.Label LabelMergeCells 
      Caption         =   "MergeCells:"
      Height          =   240
      Left            =   120
      TabIndex        =   18
      Top             =   1920
      Width           =   1410
   End
   Begin VB.Label LabelColWidthMax 
      Caption         =   "ColWidthMax:"
      Height          =   240
      Left            =   3120
      TabIndex        =   16
      Top             =   1560
      Width           =   1410
   End
   Begin VB.Label LabelColWidthMin 
      Caption         =   "ColWidthMin:"
      Height          =   240
      Left            =   120
      TabIndex        =   14
      Top             =   1560
      Width           =   1410
   End
   Begin VB.Label LabelRowHeightMax 
      Caption         =   "RowHeightMax:"
      Height          =   240
      Left            =   3120
      TabIndex        =   12
      Top             =   1200
      Width           =   1410
   End
   Begin VB.Label LabelRowHeightMin 
      Caption         =   "RowHeightMin:"
      Height          =   240
      Left            =   120
      TabIndex        =   10
      Top             =   1200
      Width           =   1410
   End
   Begin VB.Label LabelTextStyleFixed 
      Caption         =   "TextStyleFixed:"
      Height          =   240
      Left            =   3120
      TabIndex        =   8
      Top             =   840
      Width           =   1410
   End
   Begin VB.Label LabelTextStyle 
      Caption         =   "TextStyle:"
      Height          =   240
      Left            =   120
      TabIndex        =   6
      Top             =   840
      Width           =   1410
   End
   Begin VB.Label LabelGridLineWidth 
      Caption         =   "GridLineWidth:"
      Height          =   240
      Left            =   120
      TabIndex        =   4
      Top             =   480
      Width           =   1410
   End
   Begin VB.Label LabelGridLinesFixed 
      Caption         =   "GridLinesFixed:"
      Height          =   240
      Left            =   3120
      TabIndex        =   2
      Top             =   120
      Width           =   1410
   End
   Begin VB.Label LabelGridLines 
      Caption         =   "GridLines:"
      Height          =   240
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1410
   End
End
Attribute VB_Name = "PPVBFlexGridStyle"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private Const WM_UPDATEUISTATE As Long = &H128
Private Const UIS_CLEAR As Long = 2, UISF_HIDEFOCUS As Long = &H1, UISF_HIDEACCEL As Long = &H2
Private Declare Function SendMessage Lib "user32" Alias "SendMessageW" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByRef lParam As Any) As Long
Private FreezeChanged As Boolean

Private Sub Form_Load()
SendMessage PropertyPage.hWnd, WM_UPDATEUISTATE, MakeDWord(UIS_CLEAR, UISF_HIDEFOCUS Or UISF_HIDEACCEL), ByVal 0&
With ComboGridLines
.AddItem FlexGridLineNone & " - None"
.ItemData(.NewIndex) = FlexGridLineNone
.AddItem FlexGridLineFlat & " - Flat"
.ItemData(.NewIndex) = FlexGridLineFlat
.AddItem FlexGridLineInset & " - Inset"
.ItemData(.NewIndex) = FlexGridLineInset
.AddItem FlexGridLineRaised & " - Raised"
.ItemData(.NewIndex) = FlexGridLineRaised
.AddItem FlexGridLineDashes & " - Dashes"
.ItemData(.NewIndex) = FlexGridLineDashes
.AddItem FlexGridLineDots & " - Dots"
.ItemData(.NewIndex) = FlexGridLineDots
End With
With ComboGridLinesFixed
.AddItem FlexGridLineNone & " - None"
.ItemData(.NewIndex) = FlexGridLineNone
.AddItem FlexGridLineFlat & " - Flat"
.ItemData(.NewIndex) = FlexGridLineFlat
.AddItem FlexGridLineInset & " - Inset"
.ItemData(.NewIndex) = FlexGridLineInset
.AddItem FlexGridLineRaised & " - Raised"
.ItemData(.NewIndex) = FlexGridLineRaised
.AddItem FlexGridLineDashes & " - Dashes"
.ItemData(.NewIndex) = FlexGridLineDashes
.AddItem FlexGridLineDots & " - Dots"
.ItemData(.NewIndex) = FlexGridLineDots
End With
With ComboTextStyle
.AddItem FlexTextStyleFlat & " - Flat"
.ItemData(.NewIndex) = FlexTextStyleFlat
.AddItem FlexTextStyleRaised & " - Raised"
.ItemData(.NewIndex) = FlexTextStyleRaised
.AddItem FlexTextStyleInset & " - Inset"
.ItemData(.NewIndex) = FlexTextStyleInset
.AddItem FlexTextStyleRaisedLight & " - RaisedLight"
.ItemData(.NewIndex) = FlexTextStyleRaisedLight
.AddItem FlexTextStyleInsetLight & " - InsetLight"
.ItemData(.NewIndex) = FlexTextStyleInsetLight
End With
With ComboTextStyleFixed
.AddItem FlexTextStyleFlat & " - Flat"
.ItemData(.NewIndex) = FlexTextStyleFlat
.AddItem FlexTextStyleRaised & " - Raised"
.ItemData(.NewIndex) = FlexTextStyleRaised
.AddItem FlexTextStyleInset & " - Inset"
.ItemData(.NewIndex) = FlexTextStyleInset
.AddItem FlexTextStyleRaisedLight & " - RaisedLight"
.ItemData(.NewIndex) = FlexTextStyleRaisedLight
.AddItem FlexTextStyleInsetLight & " - InsetLight"
.ItemData(.NewIndex) = FlexTextStyleInsetLight
End With
With ComboMergeCells
.AddItem FlexMergeCellsNever & " - Never"
.ItemData(.NewIndex) = FlexMergeCellsNever
.AddItem FlexMergeCellsFree & " - Free"
.ItemData(.NewIndex) = FlexMergeCellsFree
.AddItem FlexMergeCellsRestrictRows & " - RestrictRows"
.ItemData(.NewIndex) = FlexMergeCellsRestrictRows
.AddItem FlexMergeCellsRestrictColumns & " - RestrictColumns"
.ItemData(.NewIndex) = FlexMergeCellsRestrictColumns
.AddItem FlexMergeCellsRestrictAll & " - RestrictAll"
.ItemData(.NewIndex) = FlexMergeCellsRestrictAll
.AddItem FlexMergeCellsFixedOnly & " - FixedOnly"
.ItemData(.NewIndex) = FlexMergeCellsFixedOnly
End With
With ComboPictureType
.AddItem FlexPictureTypeColor & " - Color"
.ItemData(.NewIndex) = FlexPictureTypeColor
.AddItem FlexPictureTypeMonochrome & " - Monochrome"
.ItemData(.NewIndex) = FlexPictureTypeMonochrome
End With
With ComboEllipsisFormat
.AddItem FlexEllipsisFormatNone & " - None"
.ItemData(.NewIndex) = FlexEllipsisFormatNone
.AddItem FlexEllipsisFormatEnd & " - End"
.ItemData(.NewIndex) = FlexEllipsisFormatEnd
.AddItem FlexEllipsisFormatPath & " - Path"
.ItemData(.NewIndex) = FlexEllipsisFormatPath
.AddItem FlexEllipsisFormatWord & " - Word"
.ItemData(.NewIndex) = FlexEllipsisFormatWord
End With
With ComboEllipsisFormatFixed
.AddItem FlexEllipsisFormatNone & " - None"
.ItemData(.NewIndex) = FlexEllipsisFormatNone
.AddItem FlexEllipsisFormatEnd & " - End"
.ItemData(.NewIndex) = FlexEllipsisFormatEnd
.AddItem FlexEllipsisFormatPath & " - Path"
.ItemData(.NewIndex) = FlexEllipsisFormatPath
.AddItem FlexEllipsisFormatWord & " - Word"
.ItemData(.NewIndex) = FlexEllipsisFormatWord
End With
End Sub

Private Sub PropertyPage_ApplyChanges()
On Error Resume Next
PropertyPage.ValidateControls
If Err.Number = 380 Then Exit Sub
On Error GoTo 0
If CheckSingleLine.Value = vbChecked Then
    If CheckWordWrap.Value = vbChecked Then
        MsgBox "WordWrap must be False when SingleLine is True", vbExclamation + vbOKOnly
        CheckWordWrap.SetFocus
        PropertyPage.Changed = True
        Exit Sub
    End If
End If
With PropertyPage.SelectedControls(0)
.SingleLine = CBool(CheckSingleLine.Value = vbChecked)
.GridLines = ComboGridLines.ItemData(ComboGridLines.ListIndex)
.GridLinesFixed = ComboGridLinesFixed.ItemData(ComboGridLinesFixed.ListIndex)
.GridLineWidth = CInt(TextGridLineWidth.Text)
.TextStyle = ComboTextStyle.ItemData(ComboTextStyle.ListIndex)
.TextStyleFixed = ComboTextStyleFixed.ItemData(ComboTextStyleFixed.ListIndex)
.RowHeightMin = CLng(TextRowHeightMin.Text)
.RowHeightMax = CLng(TextRowHeightMax.Text)
.ColWidthMin = CLng(TextColWidthMin.Text)
.ColWidthMax = CLng(TextColWidthMax.Text)
.MergeCells = ComboMergeCells.ItemData(ComboMergeCells.ListIndex)
.PictureType = ComboPictureType.ItemData(ComboPictureType.ListIndex)
.EllipsisFormat = ComboEllipsisFormat.ItemData(ComboEllipsisFormat.ListIndex)
.EllipsisFormatFixed = ComboEllipsisFormatFixed.ItemData(ComboEllipsisFormatFixed.ListIndex)
.WordWrap = CBool(CheckWordWrap.Value = vbChecked)
.FormatString = TextFormatString.Text
End With
Call PropertyPage_SelectionChanged
End Sub

Private Sub PropertyPage_SelectionChanged()
Dim i As Long
FreezeChanged = True
With PropertyPage.SelectedControls(0)
For i = 0 To ComboGridLines.ListCount - 1
    If ComboGridLines.ItemData(i) = .GridLines Then
        ComboGridLines.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboGridLinesFixed.ListCount - 1
    If ComboGridLinesFixed.ItemData(i) = .GridLinesFixed Then
        ComboGridLinesFixed.ListIndex = i
        Exit For
    End If
Next i
TextGridLineWidth.Text = CStr(.GridLineWidth)
For i = 0 To ComboTextStyle.ListCount - 1
    If ComboTextStyle.ItemData(i) = .TextStyle Then
        ComboTextStyle.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboTextStyleFixed.ListCount - 1
    If ComboTextStyleFixed.ItemData(i) = .TextStyleFixed Then
        ComboTextStyleFixed.ListIndex = i
        Exit For
    End If
Next i
TextRowHeightMin.Text = CStr(.RowHeightMin)
TextRowHeightMax.Text = CStr(.RowHeightMax)
TextColWidthMin.Text = CStr(.ColWidthMin)
TextColWidthMax.Text = CStr(.ColWidthMax)
For i = 0 To ComboMergeCells.ListCount - 1
    If ComboMergeCells.ItemData(i) = .MergeCells Then
        ComboMergeCells.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboPictureType.ListCount - 1
    If ComboPictureType.ItemData(i) = .PictureType Then
        ComboPictureType.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboEllipsisFormat.ListCount - 1
    If ComboEllipsisFormat.ItemData(i) = .EllipsisFormat Then
        ComboEllipsisFormat.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboEllipsisFormatFixed.ListCount - 1
    If ComboEllipsisFormatFixed.ItemData(i) = .EllipsisFormatFixed Then
        ComboEllipsisFormatFixed.ListIndex = i
        Exit For
    End If
Next i
CheckWordWrap.Value = IIf(.WordWrap = True, vbChecked, vbUnchecked)
CheckSingleLine.Value = IIf(.SingleLine = True, vbChecked, vbUnchecked)
TextFormatString.Text = .FormatString
End With
FreezeChanged = False
End Sub

Private Sub ComboGridLines_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboGridLinesFixed_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub TextGridLineWidth_GotFocus()
If Not TextGridLineWidth.SelStart = 0 Then Exit Sub
TextGridLineWidth.SelLength = Len(TextGridLineWidth.Text)
End Sub

Private Sub TextGridLineWidth_LostFocus()
TextGridLineWidth.SelStart = 0
End Sub

Private Sub TextGridLineWidth_Change()
If FreezeChanged = True Then Exit Sub
If TextGridLineWidth.Text = vbNullString Then
    TextGridLineWidth.Text = PropertyPage.SelectedControls(0).GridLineWidth
    TextGridLineWidth.SelStart = 0
    TextGridLineWidth.SelLength = Len(TextGridLineWidth.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextGridLineWidth_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextGridLineWidth_Validate(Cancel As Boolean)
If Not IsNumeric(TextGridLineWidth.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextGridLineWidth.Text = PropertyPage.SelectedControls(0).GridLineWidth
    TextGridLineWidth.SetFocus
    Cancel = True
Else
    Dim IntValue As Integer
    On Error Resume Next
    IntValue = CInt(TextGridLineWidth.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If IntValue < 1 Then Cancel = True
    If Cancel = False Then
        TextGridLineWidth.Text = IntValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextGridLineWidth.Text = PropertyPage.SelectedControls(0).GridLineWidth
        TextGridLineWidth.SetFocus
    End If
End If
End Sub

Private Sub ComboTextStyle_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboTextStyleFixed_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub TextRowHeightMin_GotFocus()
If Not TextRowHeightMin.SelStart = 0 Then Exit Sub
TextRowHeightMin.SelLength = Len(TextRowHeightMin.Text)
End Sub

Private Sub TextRowHeightMin_LostFocus()
TextRowHeightMin.SelStart = 0
End Sub

Private Sub TextRowHeightMin_Change()
If FreezeChanged = True Then Exit Sub
If TextRowHeightMin.Text = vbNullString Then
    TextRowHeightMin.Text = PropertyPage.SelectedControls(0).RowHeightMin
    TextRowHeightMin.SelStart = 0
    TextRowHeightMin.SelLength = Len(TextRowHeightMin.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextRowHeightMin_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextRowHeightMin_Validate(Cancel As Boolean)
If Not IsNumeric(TextRowHeightMin.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextRowHeightMin.Text = PropertyPage.SelectedControls(0).RowHeightMin
    TextRowHeightMin.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextRowHeightMin.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextRowHeightMin.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextRowHeightMin.Text = PropertyPage.SelectedControls(0).RowHeightMin
        TextRowHeightMin.SetFocus
    End If
End If
End Sub

Private Sub TextRowHeightMax_GotFocus()
If Not TextRowHeightMax.SelStart = 0 Then Exit Sub
TextRowHeightMax.SelLength = Len(TextRowHeightMax.Text)
End Sub

Private Sub TextRowHeightMax_LostFocus()
TextRowHeightMax.SelStart = 0
End Sub

Private Sub TextRowHeightMax_Change()
If FreezeChanged = True Then Exit Sub
If TextRowHeightMax.Text = vbNullString Then
    TextRowHeightMax.Text = PropertyPage.SelectedControls(0).RowHeightMax
    TextRowHeightMax.SelStart = 0
    TextRowHeightMax.SelLength = Len(TextRowHeightMax.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextRowHeightMax_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextRowHeightMax_Validate(Cancel As Boolean)
If Not IsNumeric(TextRowHeightMax.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextRowHeightMax.Text = PropertyPage.SelectedControls(0).RowHeightMax
    TextRowHeightMax.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextRowHeightMax.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextRowHeightMax.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextRowHeightMax.Text = PropertyPage.SelectedControls(0).RowHeightMax
        TextRowHeightMax.SetFocus
    End If
End If
End Sub

Private Sub TextColWidthMin_GotFocus()
If Not TextColWidthMin.SelStart = 0 Then Exit Sub
TextColWidthMin.SelLength = Len(TextColWidthMin.Text)
End Sub

Private Sub TextColWidthMin_LostFocus()
TextColWidthMin.SelStart = 0
End Sub

Private Sub TextColWidthMin_Change()
If FreezeChanged = True Then Exit Sub
If TextColWidthMin.Text = vbNullString Then
    TextColWidthMin.Text = PropertyPage.SelectedControls(0).ColWidthMin
    TextColWidthMin.SelStart = 0
    TextColWidthMin.SelLength = Len(TextColWidthMin.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextColWidthMin_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextColWidthMin_Validate(Cancel As Boolean)
If Not IsNumeric(TextColWidthMin.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextColWidthMin.Text = PropertyPage.SelectedControls(0).ColWidthMin
    TextColWidthMin.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextColWidthMin.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextColWidthMin.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextColWidthMin.Text = PropertyPage.SelectedControls(0).ColWidthMin
        TextColWidthMin.SetFocus
    End If
End If
End Sub

Private Sub TextColWidthMax_GotFocus()
If Not TextColWidthMax.SelStart = 0 Then Exit Sub
TextColWidthMax.SelLength = Len(TextColWidthMax.Text)
End Sub

Private Sub TextColWidthMax_LostFocus()
TextColWidthMax.SelStart = 0
End Sub

Private Sub TextColWidthMax_Change()
If FreezeChanged = True Then Exit Sub
If TextColWidthMax.Text = vbNullString Then
    TextColWidthMax.Text = PropertyPage.SelectedControls(0).ColWidthMax
    TextColWidthMax.SelStart = 0
    TextColWidthMax.SelLength = Len(TextColWidthMax.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextColWidthMax_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextColWidthMax_Validate(Cancel As Boolean)
If Not IsNumeric(TextColWidthMax.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextColWidthMax.Text = PropertyPage.SelectedControls(0).ColWidthMax
    TextColWidthMax.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextColWidthMax.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextColWidthMax.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextColWidthMax.Text = PropertyPage.SelectedControls(0).ColWidthMax
        TextColWidthMax.SetFocus
    End If
End If
End Sub

Private Sub ComboMergeCells_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboPictureType_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboEllipsisFormat_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboEllipsisFormatFixed_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckWordWrap_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckSingleLine_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub TextFormatString_GotFocus()
If Not TextFormatString.SelStart = 0 Then Exit Sub
TextFormatString.SelLength = Len(TextFormatString.Text)
End Sub

Private Sub TextFormatString_LostFocus()
TextFormatString.SelStart = 0
End Sub

Private Sub TextFormatString_Change()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub
