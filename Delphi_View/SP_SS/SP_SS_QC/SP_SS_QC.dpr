program SP_SS_QC;

uses
  Forms,
  VSPSSQC001S in '..\VSPSSQC001S.pas' {Form65};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm65, Form65);
  Application.Run;
end.
