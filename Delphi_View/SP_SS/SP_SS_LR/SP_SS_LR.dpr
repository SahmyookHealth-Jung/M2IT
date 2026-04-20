program SP_SS_LR;

uses
  Forms,
  VSPSSLR001S in 'VSPSSLR001S.pas' {Form3},
  VSPSSLR002S in 'VSPSSLR002S.pas' {Form4},
  VSPSSLR003S in 'VSPSSLR003S.pas' {Form5},
  VSPSSLR004S in 'VSPSSLR004S.pas' {Form58},
  VSPSSLR005S in 'VSPSSLR005S.pas' {Form59},
  VSPSSLR006S in 'VSPSSLR006S.pas' {Form61},
  VSPSSLR007S in 'VSPSSLR007S.pas' {Form62},
  VSPSSLR008S in 'VSPSSLR008S.pas' {Form63},
  VSPSSLR009S in 'VSPSSLR009S.pas' {Form64};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm3, Form3);
  Application.CreateForm(TForm4, Form4);
  Application.CreateForm(TForm5, Form5);
  Application.CreateForm(TForm58, Form58);
  Application.CreateForm(TForm59, Form59);
  Application.CreateForm(TForm61, Form61);
  Application.CreateForm(TForm62, Form62);
  Application.CreateForm(TForm63, Form63);
  Application.CreateForm(TForm64, Form64);
  Application.Run;
end.
