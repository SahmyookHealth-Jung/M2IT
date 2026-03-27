program HM_GC_PJ;

uses
  Forms,
  VHMGCPJ020S in 'VHMGCPJ020S.pas' {Form2},
  VHMGCPJ066S in 'VHMGCPJ066S.pas' {Form3},
  VHMGCPJ018S in 'VHMGCPJ018S.pas' {Form1},
  VHMGCPJ062S in 'VHMGCPJ062S.pas' {Form4},
  VHMGCPJ064S in 'VHMGCPJ064S.pas' {Form5},
  VHMGCPJ067S in 'VHMGCPJ067S.pas' {Form6},
  VHMGCPJ068S in 'VHMGCPJ068S.pas' {Form7},
  VHMGCPJ069S in 'VHMGCPJ069S.pas' {Form8},
  VHMGCPJ070S in 'VHMGCPJ070S.pas' {Form9},
  VHMGCPJ071S in 'VHMGCPJ071S.pas' {Form10},
  VHMGCPJ073S in 'VHMGCPJ073S.pas' {Form11},
  VHMGCPJ074S in 'VHMGCPJ074S.pas' {Form12},
  VHMGCPJ076S in 'VHMGCPJ076S.pas' {Form13},
  VHMGCPJ063S01 in 'VHMGCPJ063S01.pas' {Form14};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm3, Form3);
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm4, Form4);
  Application.CreateForm(TForm5, Form5);
  Application.CreateForm(TForm6, Form6);
  Application.CreateForm(TForm7, Form7);
  Application.CreateForm(TForm8, Form8);
  Application.CreateForm(TForm9, Form9);
  Application.CreateForm(TForm10, Form10);
  Application.CreateForm(TForm11, Form11);
  Application.CreateForm(TForm12, Form12);
  Application.CreateForm(TForm13, Form13);
  Application.CreateForm(TForm14, Form14);
  Application.Run;
end.
