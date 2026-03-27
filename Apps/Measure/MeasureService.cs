using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measure
{
    public class MeasureService
    {
        private MeasureRepository _repo;

        public MeasureService()
        {
            _repo = new MeasureRepository();
        }

        public MeasureDto GetCurrentRoomInfo()
        {
            string myRoomCode = "11";

            return _repo.GetRoomInfoByCode(myRoomCode);
        }

        public MeasureDto GetPatientAndItemInfo(string acptNo)
        {
            MeasureDto dto = _repo.GetPatientInfo(acptNo);

            if (dto != null)
            {
                if (dto.RegiBack.Length > 0)
                {
                    char firstDigit = dto.RegiBack[0];
                    dto.FullRegiNum = $"{dto.RegiFnt}-{firstDigit}******";
                }
                else
                {
                    dto.FullRegiNum = dto.RegiFnt;
                }
            }
            return dto;
        }

        public List<MeasureDto> GetWaitingList()
        {
            return _repo.GetTodayWaitingList();
        }

        public List<MeasureDto> GetPatientExamList(string acptNo)
        {
            return _repo.GetPatientExamList(acptNo); 
        }
        public List<MeasureResultDto> GetMeasureResults(string acptNo)
        {
            return _repo.GetMeasureResults(acptNo);
        }
        public string GetTodayAcptNoByPcustNo(string pcustNo)
        {
            return _repo.GetTodayAcptNoByPcustNo(pcustNo);
        }
        public bool SaveMeasureResults(List<MeasureResultDto> list)
        {
            return _repo.SaveMeasureResults(list);
        }       
    }
}
