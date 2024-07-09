using DB_Module_pj.Models;

namespace DB_Module_pj.Repositories
{
    public interface IuserRepository
    {
        void Delete(string Id);
        List<Members> getAll();

        //인터페이스 추가
        long Insert(Members user);
        void Update(Members user);
    }
}