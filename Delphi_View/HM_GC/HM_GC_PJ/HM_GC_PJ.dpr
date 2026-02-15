program HM_GC_PJ;

uses
  Forms,
  VHMGCPJ018S in 'VHMGCPJ018S.pas' {Form1},
  VHMGCPJ020S in 'VHMGCPJ020S.pas' {Form2},
  VHMGCPJ066S in 'VHMGCPJ066S.pas' {Form3};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm2, Form2);
  Application.CreateForm(TForm3, Form3);
  Application.Run;
end.
