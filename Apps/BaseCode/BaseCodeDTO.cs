using System;

namespace BaseCodeApp
{
    // [공통] 상태 관리를 위한 부모 클래스
    public class BaseDto
    {
        // A:추가, U:수정, D:삭제, "":변경없음
        public string Status { get; set; } = "";
    }

    public class BigCodeDto : BaseDto
    {
        public string Code { get; set; }      // BIG_CODE
        public string Name { get; set; }      // BIG_NAME
        public string BizGubun { get; set; }
    }

    public class MedlCodeDto : BaseDto
    {
        public string Code { get; set; }      // MEDL_CODE
        public string Name { get; set; }      // MEDL_NAME
        public string BigCode { get; set; }
    }

    public class SmlCodeDto : BaseDto
    {
        public string Code { get; set; }      // SML_CODE
        public string Name { get; set; }      // SML_NAME
        public string MedlCode { get; set; }
        public string Comments { get; set; }
        public string Comments2 { get; set; }
    }

    public class ComboItem
    {
        public string Value { get; set; }
        public string Text { get; set; }
        public ComboItem(string v, string t) { Value = v; Text = t; }
        public override string ToString() { return Text; }
    }
}