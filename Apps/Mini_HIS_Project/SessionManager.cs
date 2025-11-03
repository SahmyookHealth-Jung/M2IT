using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_HIS_Project
{
    /// <summary>
    /// 데이터 저장소 역할 : 로그인한 사용자 정보를 하나의 장소에 보관한다.
    /// </summary>
    public static class SessionManager
    {
        // private set을 통해 외부에서 값 변경을 방지하고 Login() 메서드를 통해서만 설정 가능
        public static int UserAuthCode { get; private set; }
        public static string UserId { get; private set; }
        public static string UserName { get; private set; }

        public static void Login(int authCode, string userId, string username)
        {
            UserAuthCode = authCode;
            UserId = userId;
            UserName = username;
        }
        public static void Logout()
        {
            UserAuthCode = 0;
            UserId = null;
            UserName = null;
        }
    } 
}
