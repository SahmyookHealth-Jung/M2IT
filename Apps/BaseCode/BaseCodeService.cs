using System.Collections.Generic;

namespace BaseCodeApp
{
    public class BaseCodeService
    {
        private BaseCodeRepository _repo = new BaseCodeRepository();

        public List<BigCodeDto> GetBigList(string bizType) => _repo.GetBigList(bizType);
        public List<MedlCodeDto> GetMedlList(string bizType, string bigCode) => _repo.GetMedlList(bizType, bigCode);
        public List<SmlCodeDto> GetSmlList(string bizType, string bigCode, string medlCode) => _repo.GetSmlList(bizType, bigCode, medlCode);

        public void SaveBigList(List<BigCodeDto> list) => _repo.SaveBigList(list);
        public void SaveMedlList(List<MedlCodeDto> list, string bizGubun) => _repo.SaveMedlList(list, bizGubun);
        public void SaveSmlList(List<SmlCodeDto> list, string bizGubun, string bigCode) => _repo.SaveSmlList(list, bizGubun, bigCode);

        public List<ComboItem> GetBizGubunList() 
        { 
            return _repo.GetBizGubunList(); 
        } 
    }
}