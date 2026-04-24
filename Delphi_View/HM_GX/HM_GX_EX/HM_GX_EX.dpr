program HM_GX_EX;

uses
  Forms,
  VHMGXEX014S in 'VHMGXEX014S.pas' {Form1},
  VHMGXEX017S in '..\..\..\..\delphi 7.0 Enterprise\Work\DrawFormSample\VHMGXEX017S.pas' {Form2},
  VHMGXEX018S in 'VHMGXEX018S.pas' {Form3},
  VHMGXEX006S01 in '..\VHMGXEX006S01.pas' {Form4},
  VHMGXEX006S02 in 'VHMGXEX006S02.pas' {Form5},
  VHMGXEX006S03 in 'VHMGXEX006S03.pas' {Form6},
  VHMGXEX006S04 in 'VHMGXEX006S04.pas' {Form7},
  VHMGXEX006S05 in 'VHMGXEX006S05.pas' {Form8},
  VHMGXEX006S06 in 'VHMGXEX006S06.pas' {Form9},
  biopsy in '..\biopsy.pas' {Form10},
  VHMGXEX001S in 'VHMGXEX001S.pas' {Form11},
  VHMGXEX002S in '..\..\HM_GB\HM_GB_BZ\VHMGXEX002S.pas' {Form58},
  VHMGXEX003S in 'VHMGXEX003S.pas' {Form59},
  VHMGXEX005S in 'VHMGXEX005S.pas' {Form61},
  VHMGXEX012S in 'VHMGXEX012S.pas' {Form62},
  VHMGXEX013S in 'VHMGXEX013S.pas' {Form65},
  VHMGXEX999S in 'VHMGXEX999S.pas' {Form86};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm3, Form3);
  Application.CreateForm(TForm4, Form4);
  Application.CreateForm(TForm5, Form5);
  Application.CreateForm(TForm6, Form6);
  Application.CreateForm(TForm7, Form7);
  Application.CreateForm(TForm8, Form8);
  Application.CreateForm(TForm9, Form9);
  Application.CreateForm(TForm10, Form10);
  Application.CreateForm(TForm11, Form11);
  Application.CreateForm(TForm58, Form58);
  Application.CreateForm(TForm59, Form59);
  Application.CreateForm(TForm61, Form61);
  Application.CreateForm(TForm62, Form62);
  Application.CreateForm(TForm65, Form65);
  Application.CreateForm(TForm86, Form86);
  Application.Run;
end.
