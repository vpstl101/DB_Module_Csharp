using DB_Module_pj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLib.Database;
using System.Data;

namespace DB_Module_pj.Repositories
{
    public class userRepository : RepositoryBase, IuserRepository
    {
        public long Insert(Members user)
        {
            string query = "INSERT INTO members (ID, PWD, Name) VALUES (@ID, @PWD, @Name)";

            using(DB_Manager? db = getDB_Conn())
            {
                return db.Execute(query, new SqlParameter[]
                {
                    new SqlParameter("@ID", user.id),
                    new SqlParameter("@PWD", user.pwd),
                    new SqlParameter("@Name", user.name),
                });
            }
        }

        //부분 업데이트일때는 오버로드, 매개변수를 추가하여 수정
        public void Update(Members user)
        {
            string query = "UPDATE members SET Name=@Name WHERE ID = @ID";

            using (DB_Manager? db = getDB_Conn())
            {
                db.Execute(query, new SqlParameter[]
                {
                    new SqlParameter("@ID", user.id),
                    //new SqlParameter("@PWD", user.pwd),
                    new SqlParameter("@Name", user.name),
                });
            }
        }

        public void Delete(string Id)
        {
            string query = "DELETE FROM members WHERE ID = @ID";

            using (DB_Manager? db = getDB_Conn())
            {
                db.Execute(query, new SqlParameter[]
                {
                    new SqlParameter("@ID", Id),

                });
            }
        }

        //Select
        public List<Members> getAll()
        {
            List<Members> list = new List<Members>();
            string query = "SELECT * FROM members";
            using DB_Manager? db = getDB_Conn();
            using (IDataReader dr = db.getReader(query))
            {
                while (dr.Read())
                {
                    Members members = new Members()
                    {
                        num = (int)dr["num"],
                        id = dr["ID"].ToString(),
                        pwd = dr["PWD"].ToString(),
                        name = dr["Name"].ToString(),
                    };
                    list.Add(members);
                }                
            }
            return list;
        }
    }
}
