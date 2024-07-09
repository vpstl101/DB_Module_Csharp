using CommonLib.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Module_pj.Repositories
{
    public abstract class RepositoryBase  //추상클래스
    {
        public DB_Manager getDB_Conn()
        {
            return new DB_Manager(Properties.Settings.Default.DB_Conn);
        }
    }
}
