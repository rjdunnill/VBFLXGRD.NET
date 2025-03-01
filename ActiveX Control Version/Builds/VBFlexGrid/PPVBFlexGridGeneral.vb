VERSION 5.00
Begin VB.Form PPVBFlexGridGeneral 
   Caption         =   "General"
   ClientHeight    =   7425
   ClientLeft      =   0
   ClientTop       =   0
   ClientWidth     =   6225
   LockControls    =   -1  'True
   PaletteMode     =   0  'Halftone
   ScaleHeight     =   7425
   ScaleWidth      =   6225
   Begin VB.TextBox TextFrozenRows 
      Height          =   315
      Left            =   1200
      TabIndex        =   17
      Top             =   1920
      Width           =   780
   End
   Begin VB.TextBox TextFrozenCols 
      Height          =   315
      Left            =   3240
      TabIndex        =   19
      Top             =   1920
      Width           =   780
   End
   Begin VB.ComboBox ComboDirectionAfterReturn 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   37
      Top             =   5160
      Width           =   2235
   End
   Begin VB.CheckBox CheckWantReturn 
      Caption         =   "WantReturn"
      Height          =   285
      Left            =   4200
      TabIndex        =   54
      Top             =   3720
      Width           =   1920
   End
   Begin VB.CheckBox CheckAllowUserEditing 
      Caption         =   "AllowUserEditing"
      Height          =   285
      Left            =   4200
      TabIndex        =   49
      Top             =   1920
      Width           =   1920
   End
   Begin VB.ComboBox ComboIMEMode 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   45
      Top             =   6600
      Width           =   2235
   End
   Begin VB.ComboBox ComboClipMode 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   43
      Top             =   6240
      Width           =   2235
   End
   Begin VB.TextBox TextClipSeparators 
      Height          =   315
      Left            =   1800
      MaxLength       =   2
      TabIndex        =   41
      Top             =   5880
      Width           =   2235
   End
   Begin VB.ComboBox ComboWrapCellBehavior 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   39
      Top             =   5520
      Width           =   2235
   End
   Begin VB.ComboBox ComboTabBehavior 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   35
      Top             =   4800
      Width           =   2235
   End
   Begin VB.ComboBox ComboRowSizingMode 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   33
      Top             =   4440
      Width           =   2235
   End
   Begin VB.ComboBox ComboAllowUserResizing 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   31
      Top             =   4080
      Width           =   2235
   End
   Begin VB.ComboBox ComboSelectionMode 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   29
      Top             =   3720
      Width           =   2235
   End
   Begin VB.ComboBox ComboFillStyle 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   27
      Top             =   3360
      Width           =   2235
   End
   Begin VB.ComboBox ComboFocusRect 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   25
      Top             =   3000
      Width           =   2235
   End
   Begin VB.ComboBox ComboHighLight 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   23
      Top             =   2640
      Width           =   2235
   End
   Begin VB.ComboBox ComboScrollBars 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   21
      Top             =   2280
      Width           =   2235
   End
   Begin VB.CheckBox CheckShowLabelTips 
      Caption         =   "ShowLabelTips"
      Height          =   285
      Left            =   4200
      TabIndex        =   53
      Top             =   3360
      Width           =   1920
   End
   Begin VB.CheckBox CheckShowInfoTips 
      Caption         =   "ShowInfoTips"
      Height          =   285
      Left            =   4200
      TabIndex        =   52
      Top             =   3000
      Width           =   1920
   End
   Begin VB.CheckBox CheckDisableNoScroll 
      Caption         =   "DisableNoScroll"
      Height          =   285
      Left            =   4200
      TabIndex        =   51
      Top             =   2640
      Width           =   1920
   End
   Begin VB.CheckBox CheckScrollTrack 
      Caption         =   "ScrollTrack"
      Height          =   285
      Left            =   4200
      TabIndex        =   50
      Top             =   2280
      Width           =   1920
   End
   Begin VB.CheckBox CheckAllowSelection 
      Caption         =   "AllowSelection"
      Height          =   285
      Left            =   4200
      TabIndex        =   48
      Top             =   1560
      Width           =   1920
   End
   Begin VB.CheckBox CheckAllowBigSelection 
      Caption         =   "AllowBigSelection"
      Height          =   285
      Left            =   4200
      TabIndex        =   47
      Top             =   1200
      Width           =   1920
   End
   Begin VB.TextBox TextFixedCols 
      Height          =   315
      Left            =   3240
      TabIndex        =   15
      Top             =   1560
      Width           =   780
   End
   Begin VB.TextBox TextCols 
      Height          =   315
      Left            =   3240
      TabIndex        =   11
      Top             =   1200
      Width           =   780
   End
   Begin VB.TextBox TextFixedRows 
      Height          =   315
      Left            =   1200
      TabIndex        =   13
      Top             =   1560
      Width           =   780
   End
   Begin VB.TextBox TextRows 
      Height          =   315
      Left            =   1200
      TabIndex        =   9
      Top             =   1200
      Width           =   780
   End
   Begin VB.CheckBox CheckMouseTrack 
      Caption         =   "MouseTrack"
      Height          =   285
      Left            =   4200
      TabIndex        =   46
      Top             =   840
      Width           =   1920
   End
   Begin VB.CommandButton CommandFontFixedClear 
      Caption         =   "Clear"
      Enabled         =   0   'False
      Height          =   315
      Left            =   4200
      TabIndex        =   5
      ToolTipText     =   "Set FontFixed = Nothing"
      Top             =   480
      Width           =   1035
   End
   Begin VB.CheckBox CheckDoubleBuffer 
      Caption         =   "DoubleBuffer"
      Height          =   285
      Left            =   3480
      TabIndex        =   2
      Top             =   120
      Width           =   1620
   End
   Begin VB.ComboBox ComboMousePointer 
      Height          =   315
      Left            =   1800
      Style           =   2  'Dropdown List
      TabIndex        =   7
      Top             =   840
      Width           =   2235
   End
   Begin VB.CheckBox CheckEnabled 
      Caption         =   "Enabled"
      Height          =   285
      Left            =   120
      TabIndex        =   0
      Top             =   120
      Width           =   1620
   End
   Begin VB.CheckBox CheckVisualStyles 
      Caption         =   "VisualStyles"
      Height          =   285
      Left            =   1800
      TabIndex        =   1
      Top             =   120
      Width           =   1620
   End
   Begin VB.Label LabelFrozenRows 
      Caption         =   "FrozenRows:"
      Height          =   240
      Left            =   120
      TabIndex        =   16
      Top             =   1920
      Width           =   1020
   End
   Begin VB.Label LabelFrozenCols 
      Caption         =   "FrozenCols:"
      Height          =   240
      Left            =   2160
      TabIndex        =   18
      Top             =   1920
      Width           =   1020
   End
   Begin VB.Label LabelDirectionAfterReturn 
      Caption         =   "DirectionAfterReturn:"
      Height          =   240
      Left            =   120
      TabIndex        =   36
      Top             =   5160
      Width           =   1620
   End
   Begin VB.Label LabelIMEMode 
      Caption         =   "IMEMode:"
      Height          =   240
      Left            =   120
      TabIndex        =   44
      Top             =   6600
      Width           =   1620
   End
   Begin VB.Label LabelClipMode 
      Caption         =   "ClipMode:"
      Height          =   240
      Left            =   120
      TabIndex        =   42
      Top             =   6240
      Width           =   1620
   End
   Begin VB.Label LabelClipSeparators 
      Caption         =   "ClipSeparators:"
      Height          =   240
      Left            =   120
      TabIndex        =   40
      Top             =   5880
      Width           =   1620
   End
   Begin VB.Label LabelWrapCellBehavior 
      Caption         =   "WrapCellBehavior:"
      Height          =   240
      Left            =   120
      TabIndex        =   38
      Top             =   5520
      Width           =   1620
   End
   Begin VB.Label LabelTabBehavior 
      Caption         =   "TabBehavior:"
      Height          =   240
      Left            =   120
      TabIndex        =   34
      Top             =   4800
      Width           =   1620
   End
   Begin VB.Label LabelRowSizingMode 
      Caption         =   "RowSizingMode:"
      Height          =   240
      Left            =   120
      TabIndex        =   32
      Top             =   4440
      Width           =   1620
   End
   Begin VB.Label LabelAllowUserResizing 
      Caption         =   "AllowUserResizing:"
      Height          =   240
      Left            =   120
      TabIndex        =   30
      Top             =   4080
      Width           =   1620
   End
   Begin VB.Label LabelSelectionMode 
      Caption         =   "SelectionMode:"
      Height          =   240
      Left            =   120
      TabIndex        =   28
      Top             =   3720
      Width           =   1620
   End
   Begin VB.Label LabelFillStyle 
      Caption         =   "FillStyle:"
      Height          =   240
      Left            =   120
      TabIndex        =   26
      Top             =   3360
      Width           =   1620
   End
   Begin VB.Label LabelFocusRect 
      Caption         =   "FocusRect:"
      Height          =   240
      Left            =   120
      TabIndex        =   24
      Top             =   3000
      Width           =   1620
   End
   Begin VB.Label LabelHighLight 
      Caption         =   "HighLight:"
      Height          =   240
      Left            =   120
      TabIndex        =   22
      Top             =   2640
      Width           =   1620
   End
   Begin VB.Label LabelScrollBars 
      Caption         =   "ScrollBars:"
      Height          =   240
      Left            =   120
      TabIndex        =   20
      Top             =   2280
      Width           =   1620
   End
   Begin VB.Label LabelFixedCols 
      Caption         =   "FixedCols:"
      Height          =   240
      Left            =   2160
      TabIndex        =   14
      Top             =   1560
      Width           =   1020
   End
   Begin VB.Label LabelCols 
      Caption         =   "Cols:"
      Height          =   240
      Left            =   2160
      TabIndex        =   10
      Top             =   1200
      Width           =   1020
   End
   Begin VB.Label LabelFixedRows 
      Caption         =   "FixedRows:"
      Height          =   240
      Left            =   120
      TabIndex        =   12
      Top             =   1560
      Width           =   1020
   End
   Begin VB.Label LabelRows 
      Caption         =   "Rows:"
      Height          =   240
      Left            =   120
      TabIndex        =   8
      Top             =   1200
      Width           =   1020
   End
   Begin VB.Label LabelFontFixedName 
      BorderStyle     =   1  'Fixed Single
      Caption         =   "(None)"
      Height          =   315
      Left            =   1800
      TabIndex        =   4
      Top             =   480
      Width           =   2235
   End
   Begin VB.Label LabelFontFixed 
      Caption         =   "FontFixed:"
      Height          =   240
      Left            =   120
      TabIndex        =   3
      Top             =   480
      Width           =   1620
   End
   Begin VB.Label LabelMousePointer 
      Caption         =   "MousePointer:"
      Height          =   240
      Left            =   120
      TabIndex        =   6
      Top             =   840
      Width           =   1620
   End
End
Attribute VB_Name = "PPVBFlexGridGeneral"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = False
Attribute VB_Exposed = False
Option Explicit
Private Const WM_UPDATEUISTATE As Long = &H128
Private Const UIS_CLEAR As Long = 2, UISF_HIDEFOCUS As Long = &H1, UISF_HIDEACCEL As Long = &H2
Private Declare Function SendMessage Lib "user32" Alias "SendMessageW" (ByVal hWnd As Long, ByVal wMsg As Long, ByVal wParam As Long, ByRef lParam As Any) As Long
Private FontFixedCleared As Boolean
Private FreezeChanged As Boolean

Private Sub Form_Load()
SendMessage PropertyPage.hWnd, WM_UPDATEUISTATE, MakeDWord(UIS_CLEAR, UISF_HIDEFOCUS Or UISF_HIDEACCEL), ByVal 0&
With ComboMousePointer
.AddItem FlexMousePointerDefault & " - Default"
.ItemData(.NewIndex) = FlexMousePointerDefault
.AddItem FlexMousePointerArrow & " - Arrow"
.ItemData(.NewIndex) = FlexMousePointerArrow
.AddItem FlexMousePointerCrosshair & " - Cross"
.ItemData(.NewIndex) = FlexMousePointerCrosshair
.AddItem FlexMousePointerIbeam & " - I-Beam"
.ItemData(.NewIndex) = FlexMousePointerIbeam
.AddItem FlexMousePointerHand & " - Hand"
.ItemData(.NewIndex) = FlexMousePointerHand
.AddItem FlexMousePointerSizePointer & " - Size"
.ItemData(.NewIndex) = FlexMousePointerSizePointer
.AddItem FlexMousePointerSizeNESW & " - Size NE SW"
.ItemData(.NewIndex) = FlexMousePointerSizeNESW
.AddItem FlexMousePointerSizeNS & " - Size N S"
.ItemData(.NewIndex) = FlexMousePointerSizeNS
.AddItem FlexMousePointerSizeNWSE & " - Size NW SE"
.ItemData(.NewIndex) = FlexMousePointerSizeNWSE
.AddItem FlexMousePointerSizeWE & " - Size W E"
.ItemData(.NewIndex) = FlexMousePointerSizeWE
.AddItem FlexMousePointerUpArrow & " - Up Arrow"
.ItemData(.NewIndex) = FlexMousePointerUpArrow
.AddItem FlexMousePointerHourglass & " - Hourglass"
.ItemData(.NewIndex) = FlexMousePointerHourglass
.AddItem FlexMousePointerNoDrop & " - No Drop"
.ItemData(.NewIndex) = FlexMousePointerNoDrop
.AddItem FlexMousePointerArrowHourglass & " - Arrow and Hourglass"
.ItemData(.NewIndex) = FlexMousePointerArrowHourglass
.AddItem FlexMousePointerArrowQuestion & " - Arrow and Question"
.ItemData(.NewIndex) = FlexMousePointerArrowQuestion
.AddItem FlexMousePointerSizeAll & " - Size All"
.ItemData(.NewIndex) = FlexMousePointerSizeAll
.AddItem FlexMousePointerArrowCD & " - Arrow and CD"
.ItemData(.NewIndex) = FlexMousePointerArrowCD
.AddItem FlexMousePointerCustom & " - Custom"
.ItemData(.NewIndex) = FlexMousePointerCustom
End With
With ComboScrollBars
.AddItem vbSBNone & " - None"
.ItemData(.NewIndex) = vbSBNone
.AddItem vbHorizontal & " - Horizontal"
.ItemData(.NewIndex) = vbHorizontal
.AddItem vbVertical & " - Vertical"
.ItemData(.NewIndex) = vbVertical
.AddItem vbBoth & " - Both"
.ItemData(.NewIndex) = vbBoth
End With
With ComboHighLight
.AddItem FlexHighLightNever & " - Never"
.ItemData(.NewIndex) = FlexHighLightNever
.AddItem FlexHighLightAlways & " - Always"
.ItemData(.NewIndex) = FlexHighLightAlways
.AddItem FlexHighLightWithFocus & " - WithFocus"
.ItemData(.NewIndex) = FlexHighLightWithFocus
End With
With ComboFocusRect
.AddItem FlexFocusRectNone & " - None"
.ItemData(.NewIndex) = FlexFocusRectNone
.AddItem FlexFocusRectLight & " - Light"
.ItemData(.NewIndex) = FlexFocusRectLight
.AddItem FlexFocusRectHeavy & " - Heavy"
.ItemData(.NewIndex) = FlexFocusRectHeavy
End With
With ComboFillStyle
.AddItem FlexFillStyleSingle & " - Single"
.ItemData(.NewIndex) = FlexFillStyleSingle
.AddItem FlexFillStyleRepeat & " - Repeat"
.ItemData(.NewIndex) = FlexFillStyleRepeat
End With
With ComboSelectionMode
.AddItem FlexSelectionModeFree & " - Free"
.ItemData(.NewIndex) = FlexSelectionModeFree
.AddItem FlexSelectionModeByRow & " - ByRow"
.ItemData(.NewIndex) = FlexSelectionModeByRow
.AddItem FlexSelectionModeByColumn & " - ByColumn"
.ItemData(.NewIndex) = FlexSelectionModeByColumn
.AddItem FlexSelectionModeFreeByRow & " - FreeByRow"
.ItemData(.NewIndex) = FlexSelectionModeFreeByRow
.AddItem FlexSelectionModeFreeByColumn & " - FreeByColumn"
.ItemData(.NewIndex) = FlexSelectionModeFreeByColumn
End With
With ComboAllowUserResizing
.AddItem FlexAllowUserResizingNone & " - None"
.ItemData(.NewIndex) = FlexAllowUserResizingNone
.AddItem FlexAllowUserResizingColumns & " - Column"
.ItemData(.NewIndex) = FlexAllowUserResizingColumns
.AddItem FlexAllowUserResizingRows & " - Rows"
.ItemData(.NewIndex) = FlexAllowUserResizingRows
.AddItem FlexAllowUserResizingBoth & " - Both"
.ItemData(.NewIndex) = FlexAllowUserResizingBoth
End With
With ComboRowSizingMode
.AddItem FlexRowSizingModeIndividual & " - Individual"
.ItemData(.NewIndex) = FlexRowSizingModeIndividual
.AddItem FlexRowSizingModeAll & " - All"
.ItemData(.NewIndex) = FlexRowSizingModeAll
End With
With ComboTabBehavior
.AddItem FlexTabControls & " - Controls"
.ItemData(.NewIndex) = FlexTabControls
.AddItem FlexTabCells & " - Cells"
.ItemData(.NewIndex) = FlexTabCells
.AddItem FlexTabNext & " - Next"
.ItemData(.NewIndex) = FlexTabNext
End With
With ComboDirectionAfterReturn
.AddItem FlexDirectionAfterReturnNone & " - None"
.ItemData(.NewIndex) = FlexDirectionAfterReturnNone
.AddItem FlexDirectionAfterReturnUp & " - Up"
.ItemData(.NewIndex) = FlexDirectionAfterReturnUp
.AddItem FlexDirectionAfterReturnDown & " - Down"
.ItemData(.NewIndex) = FlexDirectionAfterReturnDown
.AddItem FlexDirectionAfterReturnLeft & " - Left"
.ItemData(.NewIndex) = FlexDirectionAfterReturnLeft
.AddItem FlexDirectionAfterReturnRight & " - Right"
.ItemData(.NewIndex) = FlexDirectionAfterReturnRight
End With
With ComboWrapCellBehavior
.AddItem FlexWrapNone & " - None"
.ItemData(.NewIndex) = FlexWrapNone
.AddItem FlexWrapRow & " - Row"
.ItemData(.NewIndex) = FlexWrapRow
.AddItem FlexWrapGrid & " - Grid"
.ItemData(.NewIndex) = FlexWrapGrid
End With
With ComboClipMode
.AddItem FlexClipModeNormal & " - Normal"
.ItemData(.NewIndex) = FlexClipModeNormal
.AddItem FlexClipModeExcludeHidden & " - ExcludeHidden"
.ItemData(.NewIndex) = FlexClipModeExcludeHidden
End With
With ComboIMEMode
.AddItem FlexIMEModeNoControl & " - NoControl"
.ItemData(.NewIndex) = FlexIMEModeNoControl
.AddItem FlexIMEModeOn & " - On"
.ItemData(.NewIndex) = FlexIMEModeOn
.AddItem FlexIMEModeOff & " - Off"
.ItemData(.NewIndex) = FlexIMEModeOff
.AddItem FlexIMEModeDisable & " - Disable"
.ItemData(.NewIndex) = FlexIMEModeDisable
.AddItem FlexIMEModeHiragana & " - Hiragana"
.ItemData(.NewIndex) = FlexIMEModeHiragana
.AddItem FlexIMEModeKatakana & " - Katakana"
.ItemData(.NewIndex) = FlexIMEModeKatakana
.AddItem FlexIMEModeKatakanaHalf & " - KatakanaHalf"
.ItemData(.NewIndex) = FlexIMEModeKatakanaHalf
.AddItem FlexIMEModeAlphaFull & " - AlphaFull"
.ItemData(.NewIndex) = FlexIMEModeAlphaFull
.AddItem FlexIMEModeAlpha & " - Alpha"
.ItemData(.NewIndex) = FlexIMEModeAlpha
.AddItem FlexIMEModeHangulFull & " - HangulFull"
.ItemData(.NewIndex) = FlexIMEModeHangulFull
.AddItem FlexIMEModeHangul & " - Hangul"
.ItemData(.NewIndex) = FlexIMEModeHangul
End With
End Sub

Private Sub PropertyPage_ApplyChanges()
On Error Resume Next
PropertyPage.ValidateControls
If Err.Number = 380 Then Exit Sub
On Error GoTo 0
With PropertyPage.SelectedControls(0)
.Enabled = CBool(CheckEnabled.Value = vbChecked)
.VisualStyles = CBool(CheckVisualStyles.Value = vbChecked)
.DoubleBuffer = CBool(CheckDoubleBuffer.Value = vbChecked)
If FontFixedCleared = True Then
    If Not .Font Is .FontFixed Then Set .FontFixed = Nothing
    FontFixedCleared = False
End If
.MousePointer = ComboMousePointer.ItemData(ComboMousePointer.ListIndex)
.Rows = CLng(TextRows.Text)
If .Rows > 0 Then
    If CLng(TextFixedRows.Text) >= (.Rows - .FrozenRows) Then
        MsgBox "FixedRows must be at least one less than Rows minus FrozenRows value", vbExclamation + vbOKOnly
        TextFixedRows.Text = CStr(.FixedRows)
    Else
        .FixedRows = CLng(TextFixedRows.Text)
    End If
    If CLng(TextFrozenRows.Text) >= (.Rows - .FixedRows) Then
        MsgBox "FrozenRows must be at least one less than Rows minus FixedRows value", vbExclamation + vbOKOnly
        TextFrozenRows.Text = CStr(.FrozenRows)
    Else
        .FrozenRows = CLng(TextFrozenRows.Text)
    End If
End If
.Cols = CLng(TextCols.Text)
If .Cols > 0 Then
    If CLng(TextFixedCols.Text) >= (.Cols - .FrozenCols) Then
        MsgBox "FixedCols must be at least one less than Cols minus FrozenCols value", vbExclamation + vbOKOnly
        TextFixedCols.Text = CStr(.FixedCols)
    Else
        .FixedCols = CLng(TextFixedCols.Text)
    End If
    If CLng(TextFrozenCols.Text) >= (.Cols - .FixedCols) Then
        MsgBox "FrozenCols must be at least one less than Cols minus FixedCols value", vbExclamation + vbOKOnly
        TextFrozenCols.Text = CStr(.FrozenCols)
    Else
        .FrozenCols = CLng(TextFrozenCols.Text)
    End If
End If
.ScrollBars = ComboScrollBars.ItemData(ComboScrollBars.ListIndex)
.HighLight = ComboHighLight.ItemData(ComboHighLight.ListIndex)
.FocusRect = ComboFocusRect.ItemData(ComboFocusRect.ListIndex)
.FillStyle = ComboFillStyle.ItemData(ComboFillStyle.ListIndex)
.SelectionMode = ComboSelectionMode.ItemData(ComboSelectionMode.ListIndex)
.AllowUserResizing = ComboAllowUserResizing.ItemData(ComboAllowUserResizing.ListIndex)
.RowSizingMode = ComboRowSizingMode.ItemData(ComboRowSizingMode.ListIndex)
.TabBehavior = ComboTabBehavior.ItemData(ComboTabBehavior.ListIndex)
.DirectionAfterReturn = ComboDirectionAfterReturn.ItemData(ComboDirectionAfterReturn.ListIndex)
.WrapCellBehavior = ComboWrapCellBehavior.ItemData(ComboWrapCellBehavior.ListIndex)
.ClipSeparators = TextClipSeparators.Text
.ClipMode = ComboClipMode.ItemData(ComboClipMode.ListIndex)
.IMEMode = ComboIMEMode.ItemData(ComboIMEMode.ListIndex)
.MouseTrack = CBool(CheckMouseTrack.Value = vbChecked)
.AllowBigSelection = CBool(CheckAllowBigSelection.Value = vbChecked)
.AllowSelection = CBool(CheckAllowSelection.Value = vbChecked)
.AllowUserEditing = CBool(CheckAllowUserEditing.Value = vbChecked)
.ScrollTrack = CBool(CheckScrollTrack.Value = vbChecked)
.DisableNoScroll = CBool(CheckDisableNoScroll.Value = vbChecked)
.ShowInfoTips = CBool(CheckShowInfoTips.Value = vbChecked)
.ShowLabelTips = CBool(CheckShowLabelTips.Value = vbChecked)
.WantReturn = CBool(CheckWantReturn.Value = vbChecked)
End With
Call PropertyPage_SelectionChanged
End Sub

Private Sub PropertyPage_SelectionChanged()
Dim i As Long
FreezeChanged = True
With PropertyPage.SelectedControls(0)
CheckEnabled.Value = IIf(.Enabled = True, vbChecked, vbUnchecked)
CheckVisualStyles.Value = IIf(.VisualStyles = True, vbChecked, vbUnchecked)
CheckDoubleBuffer.Value = IIf(.DoubleBuffer = True, vbChecked, vbUnchecked)
If .Font Is .FontFixed Then
    LabelFontFixedName.Caption = "(None)"
    CommandFontFixedClear.Enabled = False
Else
    LabelFontFixedName.Caption = .FontFixed.Name
    CommandFontFixedClear.Enabled = True
End If
For i = 0 To ComboMousePointer.ListCount - 1
    If ComboMousePointer.ItemData(i) = .MousePointer Then
        ComboMousePointer.ListIndex = i
        Exit For
    End If
Next i
TextRows.Text = CStr(.Rows)
TextCols.Text = CStr(.Cols)
TextFixedRows.Text = CStr(.FixedRows)
TextFixedCols.Text = CStr(.FixedCols)
TextFrozenRows.Text = CStr(.FrozenRows)
TextFrozenCols.Text = CStr(.FrozenCols)
For i = 0 To ComboScrollBars.ListCount - 1
    If ComboScrollBars.ItemData(i) = .ScrollBars Then
        ComboScrollBars.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboHighLight.ListCount - 1
    If ComboHighLight.ItemData(i) = .HighLight Then
        ComboHighLight.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboFocusRect.ListCount - 1
    If ComboFocusRect.ItemData(i) = .FocusRect Then
        ComboFocusRect.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboFillStyle.ListCount - 1
    If ComboFillStyle.ItemData(i) = .FillStyle Then
        ComboFillStyle.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboSelectionMode.ListCount - 1
    If ComboSelectionMode.ItemData(i) = .SelectionMode Then
        ComboSelectionMode.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboAllowUserResizing.ListCount - 1
    If ComboAllowUserResizing.ItemData(i) = .AllowUserResizing Then
        ComboAllowUserResizing.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboRowSizingMode.ListCount - 1
    If ComboRowSizingMode.ItemData(i) = .RowSizingMode Then
        ComboRowSizingMode.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboTabBehavior.ListCount - 1
    If ComboTabBehavior.ItemData(i) = .TabBehavior Then
        ComboTabBehavior.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboDirectionAfterReturn.ListCount - 1
    If ComboDirectionAfterReturn.ItemData(i) = .DirectionAfterReturn Then
        ComboDirectionAfterReturn.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboWrapCellBehavior.ListCount - 1
    If ComboWrapCellBehavior.ItemData(i) = .WrapCellBehavior Then
        ComboWrapCellBehavior.ListIndex = i
        Exit For
    End If
Next i
TextClipSeparators.Text = .ClipSeparators
For i = 0 To ComboClipMode.ListCount - 1
    If ComboClipMode.ItemData(i) = .ClipMode Then
        ComboClipMode.ListIndex = i
        Exit For
    End If
Next i
For i = 0 To ComboIMEMode.ListCount - 1
    If ComboIMEMode.ItemData(i) = .IMEMode Then
        ComboIMEMode.ListIndex = i
        Exit For
    End If
Next i
CheckMouseTrack.Value = IIf(.MouseTrack = True, vbChecked, vbUnchecked)
CheckAllowBigSelection.Value = IIf(.AllowBigSelection = True, vbChecked, vbUnchecked)
CheckAllowSelection.Value = IIf(.AllowSelection = True, vbChecked, vbUnchecked)
CheckAllowUserEditing.Value = IIf(.AllowUserEditing = True, vbChecked, vbUnchecked)
CheckScrollTrack.Value = IIf(.ScrollTrack = True, vbChecked, vbUnchecked)
CheckDisableNoScroll.Value = IIf(.DisableNoScroll = True, vbChecked, vbUnchecked)
CheckShowInfoTips.Value = IIf(.ShowInfoTips = True, vbChecked, vbUnchecked)
CheckShowLabelTips.Value = IIf(.ShowLabelTips = True, vbChecked, vbUnchecked)
CheckWantReturn.Value = IIf(.WantReturn = True, vbChecked, vbUnchecked)
End With
FreezeChanged = False
End Sub

Private Sub CheckEnabled_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckVisualStyles_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckDoubleBuffer_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CommandFontFixedClear_Click()
CommandFontFixedClear.Enabled = False
LabelFontFixedName.Caption = "(None)"
FontFixedCleared = True
PropertyPage.Changed = True
End Sub

Private Sub ComboMousePointer_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub TextRows_GotFocus()
If Not TextRows.SelStart = 0 Then Exit Sub
TextRows.SelLength = Len(TextRows.Text)
End Sub

Private Sub TextRows_LostFocus()
TextRows.SelStart = 0
End Sub

Private Sub TextRows_Change()
If FreezeChanged = True Then Exit Sub
If TextRows.Text = vbNullString Then
    TextRows.Text = PropertyPage.SelectedControls(0).Rows
    TextRows.SelStart = 0
    TextRows.SelLength = Len(TextRows.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextRows_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextRows_Validate(Cancel As Boolean)
If Not IsNumeric(TextRows.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextRows.Text = PropertyPage.SelectedControls(0).Rows
    TextRows.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextRows.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextRows.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextRows.Text = PropertyPage.SelectedControls(0).Rows
        TextRows.SetFocus
    End If
End If
End Sub

Private Sub TextCols_GotFocus()
If Not TextCols.SelStart = 0 Then Exit Sub
TextCols.SelLength = Len(TextCols.Text)
End Sub

Private Sub TextCols_LostFocus()
TextCols.SelStart = 0
End Sub

Private Sub TextCols_Change()
If FreezeChanged = True Then Exit Sub
If TextCols.Text = vbNullString Then
    TextCols.Text = PropertyPage.SelectedControls(0).Cols
    TextCols.SelStart = 0
    TextCols.SelLength = Len(TextCols.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextCols_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextCols_Validate(Cancel As Boolean)
If Not IsNumeric(TextCols.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextCols.Text = PropertyPage.SelectedControls(0).Cols
    TextCols.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextCols.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextCols.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextCols.Text = PropertyPage.SelectedControls(0).Cols
        TextCols.SetFocus
    End If
End If
End Sub

Private Sub TextFixedRows_GotFocus()
If Not TextFixedRows.SelStart = 0 Then Exit Sub
TextFixedRows.SelLength = Len(TextFixedRows.Text)
End Sub

Private Sub TextFixedRows_LostFocus()
TextFixedRows.SelStart = 0
End Sub

Private Sub TextFixedRows_Change()
If FreezeChanged = True Then Exit Sub
If TextFixedRows.Text = vbNullString Then
    TextFixedRows.Text = PropertyPage.SelectedControls(0).FixedRows
    TextFixedRows.SelStart = 0
    TextFixedRows.SelLength = Len(TextFixedRows.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextFixedRows_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextFixedRows_Validate(Cancel As Boolean)
If Not IsNumeric(TextFixedRows.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextFixedRows.Text = PropertyPage.SelectedControls(0).FixedRows
    TextFixedRows.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextFixedRows.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextFixedRows.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextFixedRows.Text = PropertyPage.SelectedControls(0).FixedRows
        TextFixedRows.SetFocus
    End If
End If
End Sub

Private Sub TextFixedCols_GotFocus()
If Not TextFixedCols.SelStart = 0 Then Exit Sub
TextFixedCols.SelLength = Len(TextFixedCols.Text)
End Sub

Private Sub TextFixedCols_LostFocus()
TextFixedCols.SelStart = 0
End Sub

Private Sub TextFixedCols_Change()
If FreezeChanged = True Then Exit Sub
If TextFixedCols.Text = vbNullString Then
    TextFixedCols.Text = PropertyPage.SelectedControls(0).FixedCols
    TextFixedCols.SelStart = 0
    TextFixedCols.SelLength = Len(TextFixedCols.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextFixedCols_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextFixedCols_Validate(Cancel As Boolean)
If Not IsNumeric(TextFixedCols.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextFixedCols.Text = PropertyPage.SelectedControls(0).FixedCols
    TextFixedCols.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextFixedCols.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextFixedCols.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextFixedCols.Text = PropertyPage.SelectedControls(0).FixedCols
        TextFixedCols.SetFocus
    End If
End If
End Sub

Private Sub TextFrozenRows_GotFocus()
If Not TextFrozenRows.SelStart = 0 Then Exit Sub
TextFrozenRows.SelLength = Len(TextFrozenRows.Text)
End Sub

Private Sub TextFrozenRows_LostFocus()
TextFrozenRows.SelStart = 0
End Sub

Private Sub TextFrozenRows_Change()
If FreezeChanged = True Then Exit Sub
If TextFrozenRows.Text = vbNullString Then
    TextFrozenRows.Text = PropertyPage.SelectedControls(0).FrozenRows
    TextFrozenRows.SelStart = 0
    TextFrozenRows.SelLength = Len(TextFrozenRows.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextFrozenRows_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextFrozenRows_Validate(Cancel As Boolean)
If Not IsNumeric(TextFrozenRows.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextFrozenRows.Text = PropertyPage.SelectedControls(0).FrozenRows
    TextFrozenRows.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextFrozenRows.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextFrozenRows.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextFrozenRows.Text = PropertyPage.SelectedControls(0).FrozenRows
        TextFrozenRows.SetFocus
    End If
End If
End Sub

Private Sub TextFrozenCols_GotFocus()
If Not TextFrozenCols.SelStart = 0 Then Exit Sub
TextFrozenCols.SelLength = Len(TextFrozenCols.Text)
End Sub

Private Sub TextFrozenCols_LostFocus()
TextFrozenCols.SelStart = 0
End Sub

Private Sub TextFrozenCols_Change()
If FreezeChanged = True Then Exit Sub
If TextFrozenCols.Text = vbNullString Then
    TextFrozenCols.Text = PropertyPage.SelectedControls(0).FrozenCols
    TextFrozenCols.SelStart = 0
    TextFrozenCols.SelLength = Len(TextFrozenCols.Text)
End If
PropertyPage.Changed = True
End Sub

Private Sub TextFrozenCols_KeyPress(KeyAscii As Integer)
If KeyAscii < 48 Or KeyAscii > 57 Then If KeyAscii <> 8 Then KeyAscii = 0
End Sub

Private Sub TextFrozenCols_Validate(Cancel As Boolean)
If Not IsNumeric(TextFrozenCols.Text) Then
    MsgBox "Invalid property value", vbCritical + vbOKOnly
    TextFrozenCols.Text = PropertyPage.SelectedControls(0).FrozenCols
    TextFrozenCols.SetFocus
    Cancel = True
Else
    Dim LngValue As Long
    On Error Resume Next
    LngValue = CLng(TextFrozenCols.Text)
    Cancel = CBool(Err.Number <> 0)
    On Error GoTo 0
    If LngValue < 0 Then Cancel = True
    If Cancel = False Then
        TextFrozenCols.Text = LngValue
    Else
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextFrozenCols.Text = PropertyPage.SelectedControls(0).FrozenCols
        TextFrozenCols.SetFocus
    End If
End If
End Sub

Private Sub ComboScrollBars_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboHighLight_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboFocusRect_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboFillStyle_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboSelectionMode_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboAllowUserResizing_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboRowSizingMode_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboTabBehavior_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboDirectionAfterReturn_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboWrapCellBehavior_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub TextClipSeparators_GotFocus()
If Not TextClipSeparators.SelStart = 0 Then Exit Sub
TextClipSeparators.SelLength = Len(TextClipSeparators.Text)
End Sub

Private Sub TextClipSeparators_LostFocus()
TextClipSeparators.SelStart = 0
End Sub

Private Sub TextClipSeparators_Change()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub TextClipSeparators_Validate(Cancel As Boolean)
Select Case Len(TextClipSeparators.Text)
    Case Is > 2, 1
        MsgBox "Invalid property value", vbCritical + vbOKOnly
        TextClipSeparators.Text = PropertyPage.SelectedControls(0).ClipSeparators
        TextClipSeparators.SetFocus
        Cancel = True
    Case 2
        If StrComp(Left$(TextClipSeparators.Text, 1), Right$(TextClipSeparators.Text, 1)) = 0 Then
            MsgBox "Invalid property value", vbCritical + vbOKOnly
            TextClipSeparators.Text = PropertyPage.SelectedControls(0).ClipSeparators
            TextClipSeparators.SetFocus
            Cancel = True
        End If
End Select
End Sub

Private Sub ComboClipMode_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub ComboIMEMode_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckMouseTrack_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckAllowBigSelection_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckAllowSelection_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckAllowUserEditing_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckScrollTrack_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckDisableNoScroll_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckShowInfoTips_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckShowLabelTips_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub

Private Sub CheckWantReturn_Click()
If FreezeChanged = True Then Exit Sub
PropertyPage.Changed = True
End Sub
