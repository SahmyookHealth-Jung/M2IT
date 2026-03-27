using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BaseCodeApp
{
    public class BaseCodeRepository
    {
        // ==========================================
        // 1. 대분류 (조회 & 저장)
        // ==========================================
        public List<BigCodeDto> GetBigList(string bizType)
        {
            // [수정] GUBUN 컬럼 조건 제거
            string sql = $"SELECT BIG_CODE, BIG_NAME, BIZ_GUBUN FROM BASECODE_BIG WHERE BIZ_GUBUN = '{bizType}' ORDER BY BIG_CODE";

            DataTable dt = DBHelper.GetDataTable(sql);

            var list = new List<BigCodeDto>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new BigCodeDto
                {
                    Code = row["BIG_CODE"].ToString(),
                    Name = row["BIG_NAME"].ToString(),
                    BizGubun = row["BIZ_GUBUN"].ToString(),
                    Status = "" // DB에 있는 건 변경 없음 상태
                });
            }
            return list;
        }

        public void SaveBigList(List<BigCodeDto> list)
        {
            foreach (var item in list)
            {
                string sql = "";
                if (item.Status == "A") // 추가
                {
                    sql = $"INSERT INTO BASECODE_BIG (BIZ_GUBUN, BIG_CODE, BIG_NAME, INSERT_DATE) VALUES ('{item.BizGubun}', '{item.Code}', '{item.Name}', SYSDATE)";
                    DBHelper.ExecuteNonQuery(sql);
                }
                else if (item.Status == "U") // 수정
                {
                    sql = $"UPDATE BASECODE_BIG SET BIG_NAME = '{item.Name}', UPDATE_DATE = SYSDATE WHERE BIZ_GUBUN = '{item.BizGubun}' AND BIG_CODE = '{item.Code}'";
                    DBHelper.ExecuteNonQuery(sql);
                }
                else if (item.Status == "D") // ★ [수정] 삭제 (GUBUN 업데이트 -> 진짜 DELETE)
                {
                    sql = $"DELETE FROM BASECODE_BIG WHERE BIZ_GUBUN = '{item.BizGubun}' AND BIG_CODE = '{item.Code}'";
                    DBHelper.ExecuteNonQuery(sql);
                }
            }
        }

        // ==========================================
        // 2. 중분류
        // ==========================================
        public List<MedlCodeDto> GetMedlList(string bizType, string bigCode)
        {
            // [수정] GUBUN 조건 제거
            string sql = $"SELECT MEDL_CODE, MEDL_NAME, BIG_CODE FROM BASECODE_MEDL WHERE BIZ_GUBUN = '{bizType}' AND BIG_CODE = '{bigCode}' ORDER BY MEDL_CODE";
            DataTable dt = DBHelper.GetDataTable(sql);

            var list = new List<MedlCodeDto>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new MedlCodeDto
                {
                    Code = row["MEDL_CODE"].ToString(),
                    Name = row["MEDL_NAME"].ToString(),
                    BigCode = row["BIG_CODE"].ToString(),
                    Status = ""
                });
            }
            return list;
        }

        public void SaveMedlList(List<MedlCodeDto> list, string bizGubun)
        {
            foreach (var item in list)
            {
                string sql = "";
                if (item.Status == "A")
                {
                    sql = $"INSERT INTO BASECODE_MEDL (BIZ_GUBUN, BIG_CODE, MEDL_CODE, MEDL_NAME, INSERT_DATE) VALUES ('{bizGubun}', '{item.BigCode}', '{item.Code}', '{item.Name}', SYSDATE)";
                    DBHelper.ExecuteNonQuery(sql);
                }
                else if (item.Status == "U")
                {
                    sql = $"UPDATE BASECODE_MEDL SET MEDL_NAME = '{item.Name}', UPDATE_DATE = SYSDATE WHERE BIZ_GUBUN = '{bizGubun}' AND BIG_CODE = '{item.BigCode}' AND MEDL_CODE = '{item.Code}'";
                    DBHelper.ExecuteNonQuery(sql);
                }
                else if (item.Status == "D") // ★ [수정] 진짜 DELETE
                {
                    sql = $"DELETE FROM BASECODE_MEDL WHERE BIZ_GUBUN = '{bizGubun}' AND BIG_CODE = '{item.BigCode}' AND MEDL_CODE = '{item.Code}'";
                    DBHelper.ExecuteNonQuery(sql);
                }
            }
        }

        // ==========================================
        // 3. 소분류
        // ==========================================
        public List<SmlCodeDto> GetSmlList(string bizType, string bigCode, string medlCode)
        {
            // [수정] GUBUN 조건 제거
            string sql = $"SELECT MEDL_CODE, SML_CODE, SML_NAME, COMMENTS, COMMENTS2 FROM BASECODE_SML WHERE BIZ_GUBUN = '{bizType}' AND BIG_CODE = '{bigCode}' AND MEDL_CODE = '{medlCode}' ORDER BY SML_CODE";
            DataTable dt = DBHelper.GetDataTable(sql);

            var list = new List<SmlCodeDto>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(new SmlCodeDto
                {
                    Code = row["SML_CODE"].ToString(),
                    Name = row["SML_NAME"].ToString(),
                    Comments = row["COMMENTS"].ToString(),
                    Comments2 = row["COMMENTS2"].ToString(),
                    MedlCode = row["MEDL_CODE"].ToString(),
                    Status = ""
                });
            }
            return list;
        }

        public void SaveSmlList(List<SmlCodeDto> list, string bizGubun, string bigCode)
        {
            foreach (var item in list)
            {
                string sql = "";
                if (item.Status == "A")
                {
                    sql = $"INSERT INTO BASECODE_SML (BIZ_GUBUN, BIG_CODE, MEDL_CODE, SML_CODE, SML_NAME, COMMENTS, COMMENTS2, INSERT_DATE) VALUES ('{bizGubun}', '{bigCode}', '{item.MedlCode}', '{item.Code}', '{item.Name}', '{item.Comments}', '{item.Comments2}', SYSDATE)";
                    DBHelper.ExecuteNonQuery(sql);
                }
                else if (item.Status == "U")
                {
                    sql = $"UPDATE BASECODE_SML SET SML_NAME = '{item.Name}', COMMENTS='{item.Comments}', COMMENTS2='{item.Comments2}', UPDATE_DATE = SYSDATE WHERE BIZ_GUBUN = '{bizGubun}' AND BIG_CODE = '{bigCode}' AND MEDL_CODE = '{item.MedlCode}' AND SML_CODE = '{item.Code}'";
                    DBHelper.ExecuteNonQuery(sql);
                }
                else if (item.Status == "D") 
                {
                    sql = $"DELETE FROM BASECODE_SML WHERE BIZ_GUBUN = '{bizGubun}' AND BIG_CODE = '{bigCode}' AND MEDL_CODE = '{item.MedlCode}' AND SML_CODE = '{item.Code}'";
                    DBHelper.ExecuteNonQuery(sql);
                }
            }
        }

        public List<ComboItem> GetBizGubunList()
        {
            string sql = @"SELECT SML_CODE, SML_NAME FROM BASECODE_SML WHERE BIG_CODE = '100' AND MEDL_CODE ='10' AND BIZ_GUBUN = 'A' ORDER BY SML_CODE";

            DataTable dt = DBHelper.GetDataTable(sql);

            var list =  new List<ComboItem>();

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new ComboItem(row["SML_CODE"].ToString(), row["SML_NAME"].ToString()));
            }
            return list;
        }
    }
}