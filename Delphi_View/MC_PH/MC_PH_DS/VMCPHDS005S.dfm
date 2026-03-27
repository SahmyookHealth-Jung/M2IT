object Form5: TForm5
  Left = 2402
  Top = 137
  Width = 1305
  Height = 789
  Caption = #49688#47732#50557#51228' '#51068#51068#47560#44048' [VMCPHDS005S]'
  Color = clWhite
  Font.Charset = ANSI_CHARSET
  Font.Color = clWindowText
  Font.Height = -13
  Font.Name = #45208#45588#44256#46357
  Font.Style = []
  OldCreateOrder = False
  PixelsPerInch = 96
  TextHeight = 15
  object FlatPanel11: TFlatPanel
    Left = 8
    Top = 6
    Width = 1162
    Height = 402
    ParentColor = True
    TabOrder = 0
    UseDockManager = True
    object FlatPanel1: TFlatPanel
      Left = 1
      Top = 1
      Width = 1160
      Height = 38
      ParentColor = True
      TabOrder = 0
      UseDockManager = True
      object FlatLabel1: TFlatLabel
        Left = 4
        Top = 9
        Width = 66
        Alignment = taRightJustify
        TextBorder = 0
        BevelInner = beNone
        BevelOuter = beNone
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -13
        Font.Name = #45208#45588#44256#46357
        Font.Style = []
        Caption = #49468#53552#44396#48516
        Color = clWhite
        ParentFont = False
        ParentColor = False
        ShowRect = False
        ShowEssential = True
      end
      object FlatLabel2: TFlatLabel
        Left = 186
        Top = 9
        Width = 66
        Alignment = taRightJustify
        TextBorder = 0
        BevelInner = beNone
        BevelOuter = beNone
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -13
        Font.Name = #45208#45588#44256#46357
        Font.Style = []
        Caption = #47560#44048#51068#51088
        Color = clWhite
        ParentFont = False
        ParentColor = False
        ShowRect = False
        ShowEssential = True
      end
      object FlatButton1: TFlatButton
        Left = 1078
        Top = 7
        Width = 70
        Height = 23
        Color = clSilver
        Caption = #51312#54924
        ParentColor = False
        TabOrder = 0
      end
      object FlatComboBox5: TFlatComboBox
        Left = 78
        Top = 8
        Width = 102
        Height = 23
        Color = clWindow
        ItemHeight = 15
        TabOrder = 1
        Text = 'J '#51333#47196
        ItemIndex = -1
      end
      object FlatComboBox3: TFlatComboBox
        Left = 257
        Top = 8
        Width = 102
        Height = 23
        Color = clWindow
        ItemHeight = 15
        TabOrder = 2
        Text = '2026-01-01'
        ItemIndex = -1
      end
    end
    object FlatPanel2: TFlatPanel
      Left = 1
      Top = 39
      Width = 1160
      Height = 38
      ParentColor = True
      TabOrder = 1
      UseDockManager = True
    end
    object FlatComboBox1: TFlatComboBox
      Left = 1079
      Top = 47
      Width = 72
      Height = 23
      Color = clWindow
      ItemHeight = 15
      TabOrder = 2
      Text = '  Action'
      ItemIndex = -1
    end
    object FlatTabControl1: TFlatTabControl
      Left = 0
      Top = 80
      Width = 1161
      Height = 321
      Tabs.Strings = (
        #47560#44048' '#44160#51613
        #47560#44048' '#52376#47532
        #51092#50668' '#51116#44256' '#54869#51064)
      ActiveTab = 1
      TabOrder = 4
      object AdvStringGrid1: TAdvStringGrid
        Left = 1
        Top = 17
        Width = 1159
        Height = 303
        Cursor = crDefault
        Align = alClient
        ColCount = 10
        DefaultRowHeight = 25
        DefaultDrawing = False
        FixedCols = 0
        RowCount = 40
        FixedRows = 1
        Font.Charset = DEFAULT_CHARSET
        Font.Color = clWindowText
        Font.Height = -11
        Font.Name = 'Tahoma'
        Font.Style = []
        GridLineWidth = 1
        Options = [goFixedVertLine, goFixedHorzLine, goVertLine, goHorzLine, goRangeSelect, goDrawFocusSelected]
        ParentFont = False
        TabOrder = 0
        GridLineColor = clSilver
        ActiveCellShow = False
        ActiveCellFont.Charset = DEFAULT_CHARSET
        ActiveCellFont.Color = clWindowText
        ActiveCellFont.Height = -11
        ActiveCellFont.Name = 'MS Sans Serif'
        ActiveCellFont.Style = [fsBold]
        ActiveCellColor = clGray
        Bands.PrimaryColor = clInfoBk
        Bands.PrimaryLength = 1
        Bands.SecondaryColor = clWindow
        Bands.SecondaryLength = 1
        Bands.Print = False
        AutoNumAlign = False
        AutoSize = False
        VAlignment = vtaTop
        EnhTextSize = False
        EnhRowColMove = False
        SizeWithForm = False
        Multilinecells = False
        DragDropSettings.OleAcceptFiles = True
        DragDropSettings.OleAcceptText = True
        SortSettings.AutoColumnMerge = False
        SortSettings.Column = 0
        SortSettings.Show = False
        SortSettings.IndexShow = False
        SortSettings.IndexColor = clYellow
        SortSettings.Full = True
        SortSettings.SingleColumn = False
        SortSettings.IgnoreBlanks = False
        SortSettings.BlankPos = blFirst
        SortSettings.AutoFormat = True
        SortSettings.Direction = sdAscending
        SortSettings.FixedCols = False
        SortSettings.NormalCellsOnly = False
        SortSettings.Row = 0
        FloatingFooter.Color = clBtnFace
        FloatingFooter.Column = 0
        FloatingFooter.FooterStyle = fsFixedLastRow
        FloatingFooter.Visible = False
        ControlLook.Color = clBlack
        ControlLook.CheckSize = 15
        ControlLook.RadioSize = 10
        ControlLook.ControlStyle = csClassic
        ControlLook.FlatButton = False
        EnableBlink = False
        EnableHTML = True
        EnableWheel = True
        Flat = False
        HintColor = clInfoBk
        SelectionColor = clHighlight
        SelectionTextColor = clHighlightText
        SelectionRectangle = False
        SelectionResizer = False
        SelectionRTFKeep = False
        HintShowCells = False
        HintShowLargeText = False
        HintShowSizing = False
        PrintSettings.FooterSize = 0
        PrintSettings.HeaderSize = 0
        PrintSettings.Time = ppNone
        PrintSettings.Date = ppNone
        PrintSettings.DateFormat = 'dd/mm/yyyy'
        PrintSettings.PageNr = ppNone
        PrintSettings.Title = ppNone
        PrintSettings.Font.Charset = DEFAULT_CHARSET
        PrintSettings.Font.Color = clWindowText
        PrintSettings.Font.Height = -11
        PrintSettings.Font.Name = 'MS Sans Serif'
        PrintSettings.Font.Style = []
        PrintSettings.HeaderFont.Charset = DEFAULT_CHARSET
        PrintSettings.HeaderFont.Color = clWindowText
        PrintSettings.HeaderFont.Height = -11
        PrintSettings.HeaderFont.Name = 'MS Sans Serif'
        PrintSettings.HeaderFont.Style = []
        PrintSettings.FooterFont.Charset = DEFAULT_CHARSET
        PrintSettings.FooterFont.Color = clWindowText
        PrintSettings.FooterFont.Height = -11
        PrintSettings.FooterFont.Name = 'MS Sans Serif'
        PrintSettings.FooterFont.Style = []
        PrintSettings.Borders = pbNoborder
        PrintSettings.BorderStyle = psSolid
        PrintSettings.Centered = False
        PrintSettings.RepeatFixedRows = False
        PrintSettings.RepeatFixedCols = False
        PrintSettings.LeftSize = 0
        PrintSettings.RightSize = 0
        PrintSettings.ColumnSpacing = 0
        PrintSettings.RowSpacing = 0
        PrintSettings.TitleSpacing = 0
        PrintSettings.Orientation = poPortrait
        PrintSettings.PageNumberOffset = 0
        PrintSettings.MaxPagesOffset = 0
        PrintSettings.FixedWidth = 0
        PrintSettings.FixedHeight = 0
        PrintSettings.UseFixedHeight = False
        PrintSettings.UseFixedWidth = False
        PrintSettings.FitToPage = fpNever
        PrintSettings.PageNumSep = '/'
        PrintSettings.NoAutoSize = False
        PrintSettings.NoAutoSizeRow = False
        PrintSettings.PrintGraphics = False
        HTMLSettings.Width = 100
        HTMLSettings.XHTML = False
        Navigation.AdvanceDirection = adLeftRight
        Navigation.InsertPosition = pInsertBefore
        Navigation.HomeEndKey = heFirstLastColumn
        Navigation.TabToNextAtEnd = False
        Navigation.TabAdvanceDirection = adLeftRight
        ColumnSize.Location = clRegistry
        CellNode.Color = clSilver
        CellNode.NodeColor = clBlack
        CellNode.ShowTree = False
        MaxEditLength = 0
        IntelliPan = ipVertical
        URLColor = clBlue
        URLShow = False
        URLFull = False
        URLEdit = False
        ScrollType = ssNormal
        ScrollColor = clNone
        ScrollWidth = 17
        ScrollSynch = False
        ScrollProportional = False
        ScrollHints = shNone
        OemConvert = False
        FixedFooters = 0
        FixedRightCols = 0
        FixedColWidth = 30
        FixedRowHeight = 32
        FixedFont.Charset = DEFAULT_CHARSET
        FixedFont.Color = clWindowText
        FixedFont.Height = -13
        FixedFont.Name = #45208#45588#44256#46357
        FixedFont.Style = []
        FixedAsButtons = False
        FloatFormat = '%.2f'
        IntegralHeight = False
        WordWrap = False
        ColumnHeaders.Strings = (
          ''
          #50896#51064
          #51217#49688#48264#54840
          #44160#51652#51088#47749
          #50948#51032#49324#47749
          #45824#51109#51032#49324#47749
          #48120#45796#49688#47049
          #48120#45796#50857#47049
          #54532#47196#49688#47049
          #54532#47196#50857#47049)
        Lookup = False
        LookupCaseSensitive = False
        LookupHistory = False
        ShowSelection = False
        BackGround.Top = 0
        BackGround.Left = 0
        BackGround.Display = bdTile
        BackGround.Cells = bcNormal
        Filter = <>
        ColWidths = (
          30
          75
          102
          93
          96
          104
          102
          186
          142
          294)
        RowHeights = (
          32
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25
          25)
      end
    end
    object FlatButton4: TFlatButton
      Left = 1070
      Top = 70
      Width = 81
      Height = 23
      Caption = #48708#48372#44256#54869#51064
      TabOrder = 3
    end
    object FlatButton2: TFlatButton
      Left = 1070
      Top = 93
      Width = 81
      Height = 23
      Caption = #47560#44048' '#44160#51613
      TabOrder = 5
    end
    object FlatButton3: TFlatButton
      Left = 1070
      Top = 116
      Width = 81
      Height = 23
      Caption = #47560#44048' '#52376#47532
      TabOrder = 6
    end
    object FlatButton5: TFlatButton
      Left = 1070
      Top = 139
      Width = 81
      Height = 23
      Caption = #47560#44048' '#52712#49548
      TabOrder = 7
    end
    object FlatButton6: TFlatButton
      Left = 1070
      Top = 162
      Width = 81
      Height = 23
      Caption = #51092#50668' '#51116#44256' '#54869#51064
      TabOrder = 8
    end
  end
end
