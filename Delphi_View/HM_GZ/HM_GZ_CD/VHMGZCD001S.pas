unit VHMGZCD001S;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, TFlatRadioButtonUnit, TFlatLabelUnit, TFlatButtonUnit, StdCtrls,
  TFlatComboBoxUnit, ExtCtrls, TFlatPanelUnit, TFlatTabControlUnit,
  TFlatMemoUnit, TFlatGroupBoxUnit, TFlatCheckBoxUnit, Grids, BaseGrid,
  AdvGrid, TFlatEditUnit;

type
  TForm4 = class(TForm)
    FlatPanel1: TFlatPanel;
    FlatPanel3: TFlatPanel;
    FlatComboBox4: TFlatComboBox;
    FlatButton19: TFlatButton;
    FlatButton20: TFlatButton;
    FlatButton2: TFlatButton;
    FlatPanel2: TFlatPanel;
    FlatLabel5: TFlatLabel;
    FlatPanel4: TFlatPanel;
    FlatPanel16: TFlatPanel;
    FlatRadioButton37: TFlatRadioButton;
    FlatRadioButton1: TFlatRadioButton;
    FlatRadioButton2: TFlatRadioButton;
    Label8: TLabel;
    FlatEdit5: TFlatEdit;
    Label1: TLabel;
    FlatPanel7: TFlatPanel;
    AdvStringGrid1: TAdvStringGrid;
    FlatPanel5: TFlatPanel;
    FlatLabel1: TFlatLabel;
    FlatPanel6: TFlatPanel;
    Label2: TLabel;
    FlatEdit1: TFlatEdit;
    FlatEdit2: TFlatEdit;
    Label3: TLabel;
    FlatEdit3: TFlatEdit;
    FlatComboBox1: TFlatComboBox;
    Label4: TLabel;
    FlatEdit4: TFlatEdit;
    FlatEdit6: TFlatEdit;
    Label5: TLabel;
    FlatEdit7: TFlatEdit;
    FlatEdit8: TFlatEdit;
    Label6: TLabel;
    Label7: TLabel;
    FlatEdit9: TFlatEdit;
    Label9: TLabel;
    FlatEdit10: TFlatEdit;
    Label10: TLabel;
    FlatComboBox2: TFlatComboBox;
    Label11: TLabel;
    FlatComboBox3: TFlatComboBox;
    Label12: TLabel;
    FlatComboBox5: TFlatComboBox;
    Label13: TLabel;
    FlatComboBox6: TFlatComboBox;
    Label14: TLabel;
    FlatComboBox7: TFlatComboBox;
    Label15: TLabel;
    FlatComboBox8: TFlatComboBox;
    Label16: TLabel;
    FlatEdit11: TFlatEdit;
    Label17: TLabel;
    FlatComboBox9: TFlatComboBox;
    Label18: TLabel;
    FlatComboBox10: TFlatComboBox;
    Label19: TLabel;
    FlatComboBox11: TFlatComboBox;
    Label20: TLabel;
    FlatComboBox12: TFlatComboBox;
    Label21: TLabel;
    FlatComboBox13: TFlatComboBox;
    Label22: TLabel;
    FlatComboBox14: TFlatComboBox;
    Label23: TLabel;
    FlatEdit12: TFlatEdit;
    Label24: TLabel;
    FlatEdit13: TFlatEdit;
    Label25: TLabel;
    FlatEdit14: TFlatEdit;
    Label26: TLabel;
    Label27: TLabel;
    Label28: TLabel;
    FlatEdit15: TFlatEdit;
    Label29: TLabel;
    FlatEdit16: TFlatEdit;
    Label30: TLabel;
    FlatEdit17: TFlatEdit;
    Label31: TLabel;
    FlatEdit18: TFlatEdit;
    Label32: TLabel;
    FlatEdit19: TFlatEdit;
    Label33: TLabel;
    Label34: TLabel;
    FlatEdit20: TFlatEdit;
    Label35: TLabel;
    Label36: TLabel;
    FlatEdit21: TFlatEdit;
    FlatEdit22: TFlatEdit;
    Label37: TLabel;
    Label38: TLabel;
    FlatEdit23: TFlatEdit;
    Label39: TLabel;
    FlatEdit24: TFlatEdit;
    FlatCheckBox2: TFlatCheckBox;
    FlatCheckBox1: TFlatCheckBox;
    Label40: TLabel;
    FlatComboBox15: TFlatComboBox;
    Label41: TLabel;
    FlatEdit25: TFlatEdit;
    FlatCheckBox3: TFlatCheckBox;
    FlatComboBox16: TFlatComboBox;
    Label42: TLabel;
    Label43: TLabel;
    FlatComboBox17: TFlatComboBox;
    Label44: TLabel;
    FlatComboBox18: TFlatComboBox;
    FlatGroupBox4: TFlatGroupBox;
    FlatCheckBox23: TFlatCheckBox;
    FlatCheckBox25: TFlatCheckBox;
    FlatCheckBox26: TFlatCheckBox;
    FlatCheckBox27: TFlatCheckBox;
    FlatCheckBox28: TFlatCheckBox;
    FlatCheckBox30: TFlatCheckBox;
    FlatCheckBox31: TFlatCheckBox;
    FlatCheckBox32: TFlatCheckBox;
    FlatCheckBox34: TFlatCheckBox;
    Label45: TLabel;
    Label46: TLabel;
    FlatCheckBox4: TFlatCheckBox;
    FlatEdit26: TFlatEdit;
    Label47: TLabel;
    FlatEdit27: TFlatEdit;
    FlatEdit28: TFlatEdit;
    Label48: TLabel;
    Label49: TLabel;
    FlatEdit29: TFlatEdit;
    Label50: TLabel;
    FlatEdit30: TFlatEdit;
    FlatGroupBox1: TFlatGroupBox;
    FlatMemo1: TFlatMemo;
    FlatPanel8: TFlatPanel;
    AdvStringGrid2: TAdvStringGrid;
    FlatPanel9: TFlatPanel;
    AdvStringGrid3: TAdvStringGrid;
    FlatTabControl1: TFlatTabControl;
    FlatPanel10: TFlatPanel;
    Label51: TLabel;
    FlatComboBox19: TFlatComboBox;
    FlatPanel11: TFlatPanel;
    AdvStringGrid4: TAdvStringGrid;
    FlatPanel12: TFlatPanel;
    AdvStringGrid5: TAdvStringGrid;
    FlatPanel13: TFlatPanel;
    Label52: TLabel;
    FlatComboBox20: TFlatComboBox;
    FlatTabControl2: TFlatTabControl;
    FlatPanel14: TFlatPanel;
    FlatLabel2: TFlatLabel;
    FlatPanel15: TFlatPanel;
    AdvStringGrid6: TAdvStringGrid;
    FlatPanel17: TFlatPanel;
    FlatLabel3: TFlatLabel;
    FlatPanel18: TFlatPanel;
    Label53: TLabel;
    FlatComboBox21: TFlatComboBox;
    Label54: TLabel;
    FlatComboBox22: TFlatComboBox;
    Label55: TLabel;
    FlatComboBox23: TFlatComboBox;
    FlatPanel19: TFlatPanel;
    AdvStringGrid7: TAdvStringGrid;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form4: TForm4;

implementation

{$R *.dfm}

end.
