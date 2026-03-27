program SP_SS_ZZ;

uses
  Forms,
  VSPSSZZ002S in 'VSPSSZZ002S.pas' {Form1},
  VSPSSZZ003S in 'VSPSSZZ003S.pas' {Form2};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm2, Form2);
  Application.Run;
end.
