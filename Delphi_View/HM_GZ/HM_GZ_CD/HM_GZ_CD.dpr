program HM_GZ_CD;

uses
  Forms,
  VHMGZCD003S in 'VHMGZCD003S.pas' {Form1},
  VHMGZCD008S in 'VHMGZCD008S.pas' {Form3};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm3, Form3);
  Application.Run;
end.
