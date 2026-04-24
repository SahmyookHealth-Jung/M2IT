program HM_GC_CM;

uses
  Forms,
  VHMHRRV016S14 in 'HM_GR\HM_GR_RV\VHMHRRV016S14.pas' {Form15};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm15, Form15);
  Application.Run;
end.
