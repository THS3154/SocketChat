using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socket
{
    class StringText
    {
        //0 -> 한국어
        //1 -> 영문
        static int language = 0;
        
        public StringText(int lang)
        {
            language = lang;
        }

        static bool CheckLanguage(List<string> str)
        {
            //참일경우 등록된 언어가있음
            if (language < str.Count)
                return true;
            else
                return false;
        }
        public static string LoginCancel()
        {
            //로그인 실패했을경우 출력함
            List<string> str = new List<string>();
            str.Add("로그인 하지못했습니다.");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string LoginSuccess()
        {
            List<string> str = new List<string>();
            str.Add("님 환영합니다.");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string WatermarkSend()
        {
            List<string> str = new List<string>();
            str.Add("채팅 메시지 보내기");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string CreatePort()
        {
            List<string> str = new List<string>();
            str.Add("0~65535번호 사이 포트번호를 입력해주세요.");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string CreatePerson()
        {
            List<string> str = new List<string>();
            str.Add("인원을 선택해주세요.");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string CreateName()
        {
            List<string> str = new List<string>();
            str.Add("방제목을 입력해주세요.");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string CreateCheckName()
        {
            List<string> str = new List<string>();
            str.Add("동일한 방제목으로 만드실 수 없습니다.");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string CreateRoom()
        {
            List<string> str = new List<string>();
            str.Add("방만들기");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string Setting()
        {
            List<string> str = new List<string>();
            str.Add("환경설정");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string AdminMemberTitle()
        {
            List<string> str = new List<string>();
            str.Add("의 정보");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }

        public static string DBUpdateSuccess()
        {
            List<string> str = new List<string>();
            str.Add("수정완료");
            return (CheckLanguage(str) ? str[language] : str[0]);
        }
    }
}
