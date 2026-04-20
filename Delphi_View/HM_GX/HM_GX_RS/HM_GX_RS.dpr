program HM_GX_RS;

uses
  Forms,
  VHMGXRS004S in 'VHMGXRS004S.pas' {Form1},
  VHMGXRS005S in 'VHMGXRS005S.pas' {Form33},
  VHMGXRS013S in 'VHMGXRS013S.pas' {Form34},
  VHMGXRS016S in 'VHMGXRS016S.pas' {Form35},
  VHMGXRS023S in 'VHMGXRS023S.pas' {Form36},
  VHMGXRS023S01 in 'VHMGXRS023S01.pas' {Form37},
  VHMGXRS023S02 in 'VHMGXRS023S02.pas' {Form38},
  VHMGXRS023S03 in 'VHMGXRS023S03.pas' {Form39},
  VHMGXRS023S04 in 'VHMGXRS023S04.pas' {Form40},
  VHMGXRS007S in 'VHMGXRS007S.pas' {Form173},
  VHMGXRS007S01 in 'VHMGXRS007S01.pas' {Form174},
  VHMGXRS006S in 'VHMGXRS006S.pas' {Form175},
  VHMGXRS006S_bas in 'VHMGXRS006S_bas.pas' {Form176},
  VHMGXRS006_blood in 'VHMGXRS006_blood.pas' {Form177},
  NEW_ALL_RSLT in 'NEW_ALL_RSLT.pas' {Form178},
  VHMGXRS001S in 'VHMGXRS001S.pas' {Form66},
  VHMGXRS002S in 'VHMGXRS002S.pas' {Form67},
  VHMGXRS003S in 'VHMGXRS003S.pas' {Form68},
  VHMGXRS008S in 'VHMGXRS008S.pas' {Form69},
  VHMGXRS009S in 'VHMGXRS009S.pas' {Form70},
  VHMGXRS010S in 'VHMGXRS010S.pas' {Form71},
  VHMGXRS011S in 'VHMGXRS011S.pas' {Form72},
  VHMGXRS012S in 'VHMGXRS012S.pas' {Form73},
  VHMGXRS014S in 'VHMGXRS014S.pas' {Form74},
  VHMGXRS015S in 'VHMGXRS015S.pas' {Form75},
  VHMGXRS017S in 'VHMGXRS017S.pas' {Form76},
  VHMGXRS018S in 'VHMGXRS018S.pas' {Form77},
  VHMGXRS019S in 'VHMGXRS019S.pas' {Form78},
  VHMGXRS020S in 'VHMGXRS020S.pas' {Form79},
  VHMGXRS021S in 'VHMGXRS021S.pas' {Form80},
  VHMGXRS022S in 'VHMGXRS022S.pas' {Form81},
  VHMGXRS024S in 'VHMGXRS024S.pas' {Form82},
  VHMGXRS025S in 'VHMGXRS025S.pas' {Form83},
  VHMGXRS026S in '..\..\HM_GS\HM_GS_RC\VHMGXRS026S.pas' {Form84},
  VHMGXRS027S in 'VHMGXRS027S.pas' {Form85};

{$R *.res}

begin
  Application.Initialize;
  Application.CreateForm(TForm1, Form1);
  Application.CreateForm(TForm33, Form33);
  Application.CreateForm(TForm34, Form34);
  Application.CreateForm(TForm35, Form35);
  Application.CreateForm(TForm36, Form36);
  Application.CreateForm(TForm37, Form37);
  Application.CreateForm(TForm38, Form38);
  Application.CreateForm(TForm39, Form39);
  Application.CreateForm(TForm40, Form40);
  Application.CreateForm(TForm173, Form173);
  Application.CreateForm(TForm174, Form174);
  Application.CreateForm(TForm175, Form175);
  Application.CreateForm(TForm176, Form176);
  Application.CreateForm(TForm177, Form177);
  Application.CreateForm(TForm178, Form178);
  Application.CreateForm(TForm66, Form66);
  Application.CreateForm(TForm67, Form67);
  Application.CreateForm(TForm68, Form68);
  Application.CreateForm(TForm69, Form69);
  Application.CreateForm(TForm70, Form70);
  Application.CreateForm(TForm71, Form71);
  Application.CreateForm(TForm72, Form72);
  Application.CreateForm(TForm73, Form73);
  Application.CreateForm(TForm74, Form74);
  Application.CreateForm(TForm75, Form75);
  Application.CreateForm(TForm76, Form76);
  Application.CreateForm(TForm77, Form77);
  Application.CreateForm(TForm78, Form78);
  Application.CreateForm(TForm79, Form79);
  Application.CreateForm(TForm80, Form80);
  Application.CreateForm(TForm81, Form81);
  Application.CreateForm(TForm82, Form82);
  Application.CreateForm(TForm83, Form83);
  Application.CreateForm(TForm84, Form84);
  Application.CreateForm(TForm85, Form85);
  Application.Run;
end.
