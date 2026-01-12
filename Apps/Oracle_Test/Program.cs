using System;
using System.Data.Odbc; 
namespace OracleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("오라클 DB 연결 테스트를 시작합니다...");

            string dbUser = "***";      
            string dbPass = "***";    

            // 연결 문자열 생성
            string connectionString = $"DSN=Hana_DB;Uid={dbUser};Pwd={dbPass};";

            // 연결 객체 생성
            using (OdbcConnection conn = new OdbcConnection(connectionString))
            {
                try
                {
                    // 1. 접속 시도
                    conn.Open();
                    Console.WriteLine("\n[성공] DB 접속에 성공했습니다!");
                    Console.WriteLine($"[정보] 서버 버전: {conn.ServerVersion}");

                    // 2. 간단한 쿼리 날려보기 (오라클 시간 조회)
                    string query = "SELECT TO_CHAR(SYSDATE, 'YYYY-MM-DD HH24:MI:SS') FROM DUAL";

                    using (OdbcCommand cmd = new OdbcCommand(query, conn))
                    {
                        // 쿼리 실행 결과 가져오기
                        object result = cmd.ExecuteScalar();
                        Console.WriteLine($"[확인] 현재 DB 서버 시간: {result}");
                    }
                }
                catch (OdbcException ex)
                {
                    // ODBC 관련 에러가 나면 여기가 실행됨
                    Console.WriteLine("\n[실패] DB 연결 중 에러가 발생했습니다.");
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("에러 코드: " + ex.ErrorCode);
                    Console.WriteLine("에러 내용: " + ex.Message);
                    Console.WriteLine("--------------------------------------------------");
                    Console.WriteLine("팁: ID/PW가 틀렸거나, Hana_DB 설정을 못 찾는 걸 수 있어요.");
                }
                catch (Exception ex)
                {
                    // 기타 에러
                    Console.WriteLine("\n[에러] 알 수 없는 오류: " + ex.Message);
                }
            }

            // 프로그램이 바로 꺼지지 않게 엔터 칠 때까지 대기
            Console.WriteLine("\n엔터 키를 누르면 종료합니다...");
            Console.ReadLine();
        }
    }
}