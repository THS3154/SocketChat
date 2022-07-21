using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socket.Forms.Admin
{
    class AdminSettings
    {
        //관리자 레벨을 9999로 설정
        static int AdminLevel = 9999;


        //MEMBERINFO STATE값
        //회원탈퇴 
        static int MemberStateWithdrawal = 0;
        
        //회원
        static int MemberStateJoin = 1;

        //정지
        static int MemberStateSuspension = 2;

    }
}
