program HM_GS_RC;

uses
  Forms,
  VHMGSRC030S in 'VHMGSRC030S.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
