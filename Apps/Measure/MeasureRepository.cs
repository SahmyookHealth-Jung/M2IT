using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Measure
{
    public class MeasureRepository
    {
        private DBHelper db = new DBHelper();

        public List<MeasureDto> GetTodayWaitingList()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
           
            string sql = $@" 
                SELECT A.ACPT_NO,
                        A.NAME,
                        A.SEX, 
                        C.ITEM_NAME
              FROM  ACPT_M A          
              INNER JOIN ACPT_D B
                   ON A.ACPT_NO = B.ACPT_NO
              INNER JOIN CTR_INFO_D1 C
                   ON C.CUST_CODE = A.CUST_CODE
                  AND C.CTR_YEAR = A.CTR_YEAR
                  AND C.CTR_NO = A.CTR_NO
                  AND C.ITEM_NO = B.ITEM_NO
              LEFT JOIN EXAM_RSLT R
                    ON A.ACPT_NO = R.ACPT_NO
                   AND R.EXAMCODE IN ('S0001', 'S0002')
               WHERE A.ACPT_DATE = TO_DATE('{today} 00:00:00', 'YYYY-MM-DD HH24:MI:SS')
                    AND R.ACPT_NO IS NULL
                GROUP BY A.ACPT_NO, A.NAME, A.SEX, C.ITEM_NAME
                ORDER BY A.ACPT_NO
            ";

            //string sql = $@" 
            //    SELECT A.ACPT_NO,
            //            A.NAME,
            //            A.SEX, 
            //            C.ITEM_NAME
            //  FROM  ACPT_M A          
            //  INNER JOIN ACPT_D B
            //       ON A.ACPT_NO = B.ACPT_NO
            //  INNER JOIN CTR_INFO_D1 C
            //       ON C.CUST_CODE = A.CUST_CODE
            //      AND C.CTR_YEAR = A.CTR_YEAR
            //      AND C.CTR_NO = A.CTR_NO
            //      AND C.ITEM_NO = B.ITEM_NO
            //  LEFT JOIN EXAM_RSLT R
            //        ON A.ACPT_NO = R.ACPT_NO
            //       AND R.EXAMCODE IN ('S0001', 'S0002')
            //   WHERE TO_CHAR(A.ACPT_DATE, 'YYYYMMDD') = '{today}'
            //        AND R.ACPT_NO IS NULL
            //    GROUP BY A.ACPT_NO, A.NAME, A.SEX, C.ITEM_NAME
            //    ORDER BY A.ACPT_NO
            //";

            DataTable dt = DBHelper.GetDataTable(sql);
            List<MeasureDto> list = new List<MeasureDto>();

            foreach (DataRow row in dt.Rows)
            {
                MeasureDto dto = new MeasureDto();
                dto.AcptNo = row["ACPT_NO"].ToString();
                dto.Name = row["NAME"].ToString();
                dto.Sex = row["SEX"].ToString();
                dto.ItemName = row["ITEM_NAME"].ToString();

                list.Add(dto);
            }
            return list;
        }

        public MeasureDto GetRoomInfoByCode(string roomCode)
        {
            string sql = $@"SELECT MEDL_NAME
                FROM BASECODE_MEDL
                WHERE BIG_CODE = '243'
                  AND MEDL_CODE = '{roomCode}'
            ";

            DataTable dt = DBHelper.GetDataTable(sql);

            MeasureDto room = null;

            if (dt.Rows.Count > 0)
            {
                room = new MeasureDto();
                room.RoomName = dt.Rows[0]["MEDL_NAME"].ToString();
            }
            return room;
        }

        public MeasureDto GetPatientInfo(string acptNo)
        {
            string sql = $@"
                SELECT A.ACPT_NO, A.AGE, P.REGI_FNT, P.REGI_BACK ,P.NAME, P.SEX, P.FIX_PCUST_NO
                    FROM ACPT_M A
                INNER JOIN PCUST_INFO P ON A.FIX_PCUST_NO = P.FIX_PCUST_NO
                WHERE A.ACPT_NO = '{acptNo}'
            ";

            DataTable dt = DBHelper.GetDataTable(sql);
            MeasureDto patient = null;

            if (dt.Rows.Count > 0)
            {
                patient = new MeasureDto();
                patient.AcptNo = dt.Rows[0]["ACPT_NO"].ToString();
                patient.RegiFnt = dt.Rows[0]["REGI_FNT"].ToString();
                patient.RegiBack = dt.Rows[0]["REGI_BACK"].ToString();
                patient.Age = dt.Rows[0]["AGE"].ToString();
                patient.Name = dt.Rows[0]["NAME"].ToString();
                patient.Sex = dt.Rows[0]["SEX"].ToString();
                patient.FixPcustNo = dt.Rows[0]["FIX_PCUST_NO"].ToString();
            }
            return patient;
        }

        public List<MeasureDto> GetPatientExamList(string acptNo) 
        {
            string sql = $@"
                SELECT E.EXAMCODE, E.EXAM_NAME, A.ACPT_NO
                  FROM EXAM_CODE E
                INNER JOIN ACPT_EXAM_LIST A 
                        ON E.EXAMCODE = A.EXAMCODE
                      AND E.EXAMCODE_SEQ = A.EXAMCODE_SEQ
                WHERE A.ACPT_NO = '{acptNo}'
                   AND A.EXAMCODE IN (
                            'S0001', 'S0002', 'S0003', 'S0012', 'S0013', 'S0014', 'S0078')
                ORDER BY E.EXAMCODE       
            ";

            DataTable dt = DBHelper.GetDataTable(sql);
            List<MeasureDto> list = new List<MeasureDto>();

            foreach (DataRow row in dt.Rows)
            {
                MeasureDto dto = new MeasureDto();
                dto.ExamCode = row["EXAMCODE"].ToString();
                dto.ExamName = row["EXAM_NAME"].ToString();
                dto.AcptNo = row["ACPT_NO"].ToString();

                list.Add(dto);
            }
            return list;
        }

        public List<MeasureResultDto> GetMeasureResults(string acptNo)
        {
            string sql = $@"
                SELECT
                    TO_CHAR(A.ACPT_DATE, 'YYYY-MM-DD') AS ACPT_DATE,
                    A.ACPT_NO,
                    MAX(CASE WHEN EXAMCODE = 'S0001' THEN COALESCE(TO_CHAR(NUM_RSLT), CHAR_RSLT) END) AS HEIGHT,
                    MAX(CASE WHEN EXAMCODE = 'S0002' THEN COALESCE(TO_CHAR(NUM_RSLT), CHAR_RSLT) END) AS WEIGHT,
                    MAX(CASE WHEN EXAMCODE = 'S0003' THEN COALESCE(TO_CHAR(NUM_RSLT), CHAR_RSLT) END) AS BMI,
                    MAX(CASE WHEN EXAMCODE = 'S0012' THEN COALESCE(TO_CHAR(NUM_RSLT), CHAR_RSLT) END) AS WAIST,
                    MAX(CASE WHEN EXAMCODE = 'S0014' THEN COALESCE(TO_CHAR(NUM_RSLT), CHAR_RSLT) END) AS CHEST,
                    MAX(CASE WHEN EXAMCODE = 'S0078' THEN COALESCE(TO_CHAR(NUM_RSLT), CHAR_RSLT) END) AS NECK
                FROM ACPT_M A
                LEFT JOIN EXAM_RSLT R
                    ON R.ACPT_NO = A.ACPT_NO
                    AND R.EXAMCODE IN ('S0001', 'S0002', 'S0003', 'S0012', 'S0014', 'S0078')
                WHERE A.FIX_PCUST_NO = (SELECT FIX_PCUST_NO FROM ACPT_M WHERE ACPT_NO = '{acptNo}')
                GROUP BY A.ACPT_DATE, A.ACPT_NO
                HAVING 
                    A.ACPT_DATE = (SELECT MAX(ACPT_DATE)
                                            FROM ACPT_M
                                            WHERE FIX_PCUST_NO = (SELECT FIX_PCUST_NO FROM ACPT_M WHERE ACPT_NO = '{acptNo}')
                    )
                    OR
                    COUNT(R.EXAMCODE) > 0 
                ORDER BY A.ACPT_DATE DESC
            ";

            DataTable dt = DBHelper.GetDataTable(sql);
            List<MeasureResultDto> list = new List<MeasureResultDto>();

            foreach (DataRow row in dt.Rows)
            {
                MeasureResultDto dto = new MeasureResultDto();

                dto.AcptNo = row["ACPT_NO"].ToString();
                dto.AcptDate = row["ACPT_DATE"].ToString();
                dto.Height = row["HEIGHT"].ToString();
                dto.Weight = row["WEIGHT"].ToString();
                dto.Bmi = row["BMI"].ToString();
                dto.Waist = row["WAIST"].ToString();
                dto.Chest = row["CHEST"].ToString();
                dto.Neck = row["NECK"].ToString();

                list.Add(dto);
            }
            return list;
        }
        public string GetTodayAcptNoByPcustNo(string pcustNo)
        {
            string sql = $@"
        SELECT MAX(A.ACPT_NO) 
        FROM ACPT_M A
        INNER JOIN PCUST_INFO P
           ON A.FIX_PCUST_NO = P.FIX_PCUST_NO
        WHERE P.PCUST_NO = '{pcustNo}'
          AND A.ACPT_DATE >= TRUNC(SYSDATE)      -- 오늘 00:00:00 부터
          AND A.ACPT_DATE <  TRUNC(SYSDATE) + 1  -- 내일 00:00:00 전까지
    ";
            DataTable dt = DBHelper.GetDataTable(sql);

            if (dt.Rows.Count > 0 && dt.Rows[0][0] != DBNull.Value)
            {
                return dt.Rows[0][0].ToString();
            }
            else
            {
                return null;
            }
        }

        public bool SaveMeasureResults(List<MeasureResultDto> list)
        {
            int saveConut = 0;

            foreach (var dto in list)
            {
                MergeExamResult(dto.AcptNo, "S0001", dto.Height, dto.AcptDate); // 신장
                MergeExamResult(dto.AcptNo, "S0002", dto.Weight ,dto.AcptDate); // 체중
                MergeExamResult(dto.AcptNo, "S0003", dto.Bmi, dto.AcptDate);    // 비만도
                MergeExamResult(dto.AcptNo, "S0012", dto.Waist, dto.AcptDate);  // 허리둘레
                MergeExamResult(dto.AcptNo, "S0014", dto.Chest, dto.AcptDate);  // 가슴둘레
                MergeExamResult(dto.AcptNo, "S0078", dto.Neck, dto.AcptDate);   // 목둘레

                saveConut++;
            }
            return saveConut > 0;
        }

        private void MergeExamResult(string acptNo, string examCode, string value, string acptDate)
        {
            if (value == null) value = "";

            string numValue = System.Text.RegularExpressions.Regex.Replace(value, @"[^0-9.]", "");

            if (string.IsNullOrEmpty(numValue)) numValue = "NULL";  // 숫자 없으면 DB에 null 넣기

            string sql = $@"
            MERGE INTO EXAM_RSLT T
            USING DUAL
               ON (T.ACPT_NO = '{acptNo}' AND T.EXAMCODE = '{examCode}')
            WHEN MATCHED THEN
                UPDATE SET 
                    CHAR_RSLT = NULL,
                    NUM_RSLT  = {numValue}
            WHEN NOT MATCHED THEN
                INSERT (
                    ACPT_NO, ACPT_DATE, EXAMCODE, CHAR_RSLT, NUM_RSLT, INSERT_DATE, 
                    INSERT_IP, INSERT_EMP
                )
                VALUES (
                    '{acptNo}',TO_DATE('{acptDate}', 'YYYY-MM-DD') ,'{examCode}', 'NULL', {numValue}, SYSDATE,
                    '000.00.00.0', '9999'
                )
        ";

            DBHelper.ExecuteNonQuery(sql);
        }       
    }
}
