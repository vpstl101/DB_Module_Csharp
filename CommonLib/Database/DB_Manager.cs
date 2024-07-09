using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib.Database
{
    public class DB_Manager : IDisposable //인터페이스
    {
        private MySqlConnection? _conn;
        private readonly string _connectionString;

        // DB_Manager 생성자
        public DB_Manager(string connectionString)
        {
            _connectionString = connectionString;
            Connection();
        }

        
        private void Connection()   //DB연결 
        {
            _conn = new MySqlConnection(_connectionString);

            try
            {
                _conn.Open();
            }
            catch (Exception ex)
            {
                //로그
                //MessageBox.Show($"Connection Error \n {ex.Message}");
                Console.WriteLine($"Connection Error");
            }
        }

        //Parameters 가져오는 메소드가 중복되기에 따로 함수를 만들어준다
        private void addParameters(MySqlCommand cmd, SqlParameter[]? parameters)
        {
            if (parameters != null)
            {
                foreach (SqlParameter param in parameters)
                {
                    //AddWithValue 자동 형 변환
                    cmd.Parameters.AddWithValue(param.ParameterName, param.Value);
                }
            }
        }

        // sql파라미터 생성
        //SqlParameter[]? Null 허용
        public IDataReader getReader(string query, SqlParameter[]? parameters)
        {
            using MySqlCommand cmd = new MySqlCommand(query, _conn);
            addParameters(cmd, parameters);
            return cmd.ExecuteReader();

        }

        //파라미터가 없는경우가 있기에 IDataReader를 Overload 한다
        public IDataReader getReader(string query)
        {
            return getReader(query, null);
        }

        //오토 인크리먼트?를 반환하기 위해 long 사용
        public long Execute(string query, SqlParameter[]? parameters)
        {
            using MySqlCommand cmd = new MySqlCommand(query, _conn);
            addParameters(cmd, parameters);

            /* ExecuteNonQuery : SQL문을 실행한 후 어떤 결과값이 돌아오지 않을 때 사용
             * 데이터베이스에 데이터값을 넣거나, 데이터를 바꾸고 싶을 때 사용
             * UPDATE , DELETE , INSERT 등을 이용할 때 사용
             * 리턴값은 정수형식(INT32)로 반환되며 그 값은 SQL문을 실행했을 때 영향을 받은 행들의 수이다
             * 그 이외에는 -1 이 반환된다. 반환값은 선택적으로 활용하면 된다. */
            cmd.ExecuteNonQuery();
            return cmd.LastInsertedId;
        }

        public long Execute(string query)
        {
            return Execute(query, null);
        }

        public DataTable getDataTable(string query, SqlParameter[]? parameters)
        {
            using MySqlCommand cmd = new MySqlCommand(query, _conn);
            addParameters(cmd, parameters);
            using MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getDataTable(string query)
        {
            return getDataTable(query, null);
        }

        /* connection 이후 Close 
         * IDisposable 인터페이스를 사용하여 닫아주기 */
        public void Dispose()   
        {
            _conn?.Close();     //conn 있다면 닫아주고
            _conn?.Dispose();   //conn 메모리를 처리
            _conn = null;       //conn 객체를 null 초기화
        }
    }
}
