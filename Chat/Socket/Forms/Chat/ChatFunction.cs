using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socket.Forms.Chat
{
    
    class ChatFunction
    {
        public struct ChatListData
        {
            public int Roomindex;       //방 고유번호
            public string ServerID;     //서버 아이디
            public string RoomName;     //방이름
            public string CreateTime;   //방생성시간
            public string EndTime;      //방 끝난시간
        }

        public static void ReadRoom(string MyID,ref List<ChatListData> Rooms)
        {
            //해당 유저가 들어갔던 방목록을 가져온다
            MSSQL sql = new MSSQL();
            MSSQL ReadName = new MSSQL();
            sql.ReadData($"SELECT ROOMINDEX FROM {Tables.InOutLogs} WHERE ID = '{MyID}'");
            while (sql.rdr.Read())
            {
                ChatListData cld = new ChatListData();
                cld.Roomindex = Convert.ToInt32(sql.rdr["ROOMINDEX"].ToString());

                //종료된 방 DB에서 값을 읽어옴
                string query = $"SELECT COUNT(*) FROM {Tables.EndRoomList} WHERE ROOMINDEX = {sql.rdr["ROOMINDEX"].ToString()}";
                int cnt = (int)ReadName.GetQueryCnt(query);


                query = $"SELECT ID,RNAME,CREATETIME,ENDTIME FROM {Tables.EndRoomList} WHERE ROOMINDEX = {sql.rdr["ROOMINDEX"].ToString()}";
                ReadName.ReadData(query);

                //ENDROOMLIST 테이블에 데이터가 없으면 하지않음
                if(cnt != 0)
                {
                    ReadName.rdr.Read();

                    cld.ServerID = ReadName.rdr["ID"].ToString();
                    cld.RoomName = ReadName.rdr["RNAME"].ToString();
                    cld.CreateTime = ReadName.rdr["CREATETIME"].ToString();
                    cld.EndTime = ReadName.rdr["ENDTIME"].ToString();

                    

                    Rooms.Add(cld);
                }
                ReadName.RdrClose();
            }
        }
    }
}
