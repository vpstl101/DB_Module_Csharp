using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Module_pj.Models
{
    public class Members
    {
        //Optional(임이의)
        // ? : Nullable 
        // ! : 타입 체크시 null 또는 undefined(정의되지 않은) 값이 들어오지 않을 것이라는 알려주는 용도
        public int num { get; set; } = default!;
        public string id { get; set; } = default!;
        public string pwd { get; set; } = default!;
        public string name { get; set; } = default!;
        public string cellPhone { get; set; } = default!;
        public DateTime EvtTime { get; set; } = default!;


        public static void printLog(string contents)
        {
            //해당 폴더가 없을경우 "LogFolder"새로 만든다
            DirectoryInfo di = new DirectoryInfo("LogFolder");
            if (di.Exists == false)
                di.Create();

            //@ "\\"역슬레시 1개 생략
            //ture append 옵션  새로운내용 추가시 덮어쓰지않고 계속 추가  
            using (StreamWriter wr = new StreamWriter(@"LogFolder\EvtHistory.txt", true))
            {
                wr.WriteLine(contents);
            }

        }

    }
}
