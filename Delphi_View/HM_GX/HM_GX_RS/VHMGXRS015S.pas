unit VHMGXRS015S;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls, TFlatMemoUnit, TFlatTabControlUnit, Grids, BaseGrid,
  AdvGrid, TFlatRadioButtonUnit, TFlatButtonUnit, TFlatComboBoxUnit,
  TFlatLabelUnit, TFlatCheckBoxUnit, TFlatEditUnit, ExtCtrls,
  TFlatPanelUnit;

type
  TForm75 = class(TForm)
    FlatPanel4: TFlatPanel;
    FlatPanel7: TFlatPanel;
    Label12: TLabel;
    Label17: TLabel;
    Label5: TLabel;
    Label1: TLabel;
    FlatEdit20: TFlatEdit;
    FlatEdit21: TFlatEdit;
    FlatEdit4: TFlatEdit;
    FlatEdit7: TFlatEdit;
    FlatPanel9: TFlatPanel;
    FlatCheckBox1: TFlatCheckBox;
    FlatCheckBox6: TFlatCheckBox;
    FlatCheckBox7: TFlatCheckBox;
    FlatCheckBox8: TFlatCheckBox;
    FlatCheckBox9: TFlatCheckBox;
    FlatCheckBox10: TFlatCheckBox;
    FlatCheckBox11: TFlatCheckBox;
    FlatCheckBox12: TFlatCheckBox;
    FlatCheckBox13: TFlatCheckBox;
    FlatPanel8: TFlatPanel;
    FlatLabel14: TFlatLabel;
    FlatPanel6: TFlatPanel;
    FlatComboBox2: TFlatComboBox;
    FlatPanel12: TFlatPanel;
    FlatLabel10: TFlatLabel;
    FlatButton1: TFlatButton;
    FlatPanel3: TFlatPanel;
    Label11: TLabel;
    FlatLabel5: TFlatLabel;
    FlatLabel7: TFlatLabel;
    FlatComboBox3: TFlatComboBox;
    FlatComboBox4: TFlatComboBox;
    FlatButton2: TFlatButton;
    FlatPanel10: TFlatPanel;
    FlatRadioButton12: TFlatRadioButton;
    FlatRadioButton13: TFlatRadioButton;
    FlatRadioButton14: TFlatRadioButton;
    FlatPanel11: TFlatPanel;
    FlatCheckBox2: TFlatCheckBox;
    FlatCheckBox3: TFlatCheckBox;
    FlatCheckBox4: TFlatCheckBox;
    FlatComboBox7: TFlatComboBox;
    FlatEdit1: TFlatEdit;
    FlatPanel5: TFlatPanel;
    AdvStringGrid1: TAdvStringGrid;
    FlatTabControl1: TFlatTabControl;
    FlatPanel13: TFlatPanel;
    FlatLabel13: TFlatLabel;
    FlatLabel15: TFlatLabel;
    FlatLabel16: TFlatLabel;
    FlatLabel17: TFlatLabel;
    FlatLabel18: TFlatLabel;
    FlatLabel19: TFlatLabel;
    FlatLabel20: TFlatLabel;
    FlatLabel21: TFlatLabel;
    FlatLabel22: TFlatLabel;
    FlatLabel23: TFlatLabel;
    FlatLabel24: TFlatLabel;
    FlatLabel25: TFlatLabel;
    FlatLabel26: TFlatLabel;
    FlatLabel27: TFlatLabel;
    FlatLabel28: TFlatLabel;
    FlatLabel29: TFlatLabel;
    FlatLabel30: TFlatLabel;
    FlatLabel31: TFlatLabel;
    FlatLabel34: TFlatLabel;
    FlatLabel35: TFlatLabel;
    FlatLabel41: TFlatLabel;
    FlatLabel42: TFlatLabel;
    FlatLabel43: TFlatLabel;
    FlatLabel32: TFlatLabel;
    FlatLabel33: TFlatLabel;
    FlatLabel36: TFlatLabel;
    FlatLabel37: TFlatLabel;
    FlatLabel38: TFlatLabel;
    FlatLabel39: TFlatLabel;
    FlatLabel40: TFlatLabel;
    FlatLabel44: TFlatLabel;
    FlatEdit6: TFlatEdit;
    FlatEdit12: TFlatEdit;
    FlatEdit13: TFlatEdit;
    FlatEdit14: TFlatEdit;
    FlatEdit15: TFlatEdit;
    FlatEdit16: TFlatEdit;
    FlatPanel14: TFlatPanel;
    FlatCheckBox14: TFlatCheckBox;
    FlatCheckBox15: TFlatCheckBox;
    FlatCheckBox16: TFlatCheckBox;
    FlatCheckBox17: TFlatCheckBox;
    FlatCheckBox18: TFlatCheckBox;
    FlatCheckBox19: TFlatCheckBox;
    FlatCheckBox20: TFlatCheckBox;
    FlatCheckBox21: TFlatCheckBox;
    FlatPanel15: TFlatPanel;
    FlatCheckBox22: TFlatCheckBox;
    FlatCheckBox23: TFlatCheckBox;
    FlatCheckBox24: TFlatCheckBox;
    FlatCheckBox25: TFlatCheckBox;
    FlatCheckBox26: TFlatCheckBox;
    FlatCheckBox27: TFlatCheckBox;
    FlatCheckBox28: TFlatCheckBox;
    FlatCheckBox29: TFlatCheckBox;
    FlatPanel16: TFlatPanel;
    FlatCheckBox30: TFlatCheckBox;
    FlatCheckBox31: TFlatCheckBox;
    FlatCheckBox32: TFlatCheckBox;
    FlatCheckBox33: TFlatCheckBox;
    FlatCheckBox34: TFlatCheckBox;
    FlatCheckBox35: TFlatCheckBox;
    FlatCheckBox36: TFlatCheckBox;
    FlatCheckBox37: TFlatCheckBox;
    FlatPanel17: TFlatPanel;
    FlatCheckBox38: TFlatCheckBox;
    FlatCheckBox39: TFlatCheckBox;
    FlatCheckBox40: TFlatCheckBox;
    FlatCheckBox41: TFlatCheckBox;
    FlatCheckBox42: TFlatCheckBox;
    FlatCheckBox43: TFlatCheckBox;
    FlatCheckBox44: TFlatCheckBox;
    FlatEdit17: TFlatEdit;
    FlatEdit18: TFlatEdit;
    FlatEdit19: TFlatEdit;
    FlatComboBox8: TFlatComboBox;
    FlatEdit23: TFlatEdit;
    FlatEdit24: TFlatEdit;
    FlatEdit25: TFlatEdit;
    FlatEdit26: TFlatEdit;
    FlatEdit27: TFlatEdit;
    FlatEdit28: TFlatEdit;
    FlatPanel18: TFlatPanel;
    FlatCheckBox45: TFlatCheckBox;
    FlatCheckBox46: TFlatCheckBox;
    FlatCheckBox47: TFlatCheckBox;
    FlatCheckBox48: TFlatCheckBox;
    FlatCheckBox49: TFlatCheckBox;
    FlatCheckBox50: TFlatCheckBox;
    FlatCheckBox51: TFlatCheckBox;
    FlatCheckBox52: TFlatCheckBox;
    FlatPanel19: TFlatPanel;
    FlatCheckBox53: TFlatCheckBox;
    FlatCheckBox54: TFlatCheckBox;
    FlatCheckBox55: TFlatCheckBox;
    FlatCheckBox56: TFlatCheckBox;
    FlatCheckBox57: TFlatCheckBox;
    FlatCheckBox58: TFlatCheckBox;
    FlatCheckBox59: TFlatCheckBox;
    FlatCheckBox60: TFlatCheckBox;
    FlatPanel20: TFlatPanel;
    FlatCheckBox61: TFlatCheckBox;
    FlatCheckBox62: TFlatCheckBox;
    FlatCheckBox63: TFlatCheckBox;
    FlatCheckBox64: TFlatCheckBox;
    FlatCheckBox65: TFlatCheckBox;
    FlatCheckBox66: TFlatCheckBox;
    FlatCheckBox67: TFlatCheckBox;
    FlatCheckBox68: TFlatCheckBox;
    FlatPanel21: TFlatPanel;
    FlatCheckBox69: TFlatCheckBox;
    FlatCheckBox70: TFlatCheckBox;
    FlatCheckBox71: TFlatCheckBox;
    FlatCheckBox72: TFlatCheckBox;
    FlatCheckBox73: TFlatCheckBox;
    FlatCheckBox74: TFlatCheckBox;
    FlatCheckBox75: TFlatCheckBox;
    FlatEdit29: TFlatEdit;
    FlatPanel25: TFlatPanel;
    FlatCheckBox100: TFlatCheckBox;
    FlatCheckBox101: TFlatCheckBox;
    FlatCheckBox102: TFlatCheckBox;
    FlatCheckBox103: TFlatCheckBox;
    FlatCheckBox104: TFlatCheckBox;
    FlatCheckBox105: TFlatCheckBox;
    FlatCheckBox106: TFlatCheckBox;
    FlatEdit38: TFlatEdit;
    FlatEdit39: TFlatEdit;
    FlatEdit40: TFlatEdit;
    FlatComboBox13: TFlatComboBox;
    FlatEdit30: TFlatEdit;
    FlatEdit31: TFlatEdit;
    FlatPanel22: TFlatPanel;
    FlatCheckBox76: TFlatCheckBox;
    FlatCheckBox77: TFlatCheckBox;
    FlatCheckBox78: TFlatCheckBox;
    FlatCheckBox79: TFlatCheckBox;
    FlatCheckBox80: TFlatCheckBox;
    FlatCheckBox81: TFlatCheckBox;
    FlatCheckBox82: TFlatCheckBox;
    FlatCheckBox83: TFlatCheckBox;
    FlatCheckBox84: TFlatCheckBox;
    FlatPanel23: TFlatPanel;
    FlatCheckBox85: TFlatCheckBox;
    FlatCheckBox86: TFlatCheckBox;
    FlatCheckBox87: TFlatCheckBox;
    FlatCheckBox88: TFlatCheckBox;
    FlatCheckBox91: TFlatCheckBox;
    FlatEdit32: TFlatEdit;
    FlatComboBox12: TFlatComboBox;
    FlatEdit33: TFlatEdit;
    FlatEdit34: TFlatEdit;
    FlatEdit35: TFlatEdit;
    FlatEdit36: TFlatEdit;
    FlatEdit37: TFlatEdit;
    FlatEdit41: TFlatEdit;
    FlatEdit42: TFlatEdit;
    FlatEdit43: TFlatEdit;
    FlatEdit44: TFlatEdit;
    FlatEdit2: TFlatEdit;
    FlatPanel1: TFlatPanel;
    FlatCheckBox5: TFlatCheckBox;
    FlatCheckBox89: TFlatCheckBox;
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form75: TForm75;

implementation

{$R *.dfm}

end.
