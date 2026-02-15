program HM_GX_EX;

uses
  Forms,
  VHMGXEX014S in 'VHMGXEX014S.pas' {Form1},
  VHMGXEX017S in '..\..\..\..\delphi 7.0 Enterprise\Work\DrawFormSample\VHMGXEX017S.pas' {Form2},
  VHMGXEX018S in 'VHMGXEX018S.pas' {Form3};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm3, Form3);
  Application.Run;
end.
