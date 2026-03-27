program IM_EI_MA;

uses
  Forms,
  VIMEIMA001S in 'VIMEIMA001S.pas' {Form1};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.Run;
end.
