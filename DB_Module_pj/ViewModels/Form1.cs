using DB_Module_pj.Models;
using DB_Module_pj.Repositories;
using MySql.Data.MySqlClient;

namespace DB_Module_pj
{
    public partial class Form1 : Form
    {
        private MySqlConnection _conn = default!;
        private IuserRepository _userRepository;
        public Form1()
        {
            _userRepository = new userRepository();
            InitializeComponent();
        }

        private void btn_Signin_Click(object sender, EventArgs e)
        {
            /*            Members member = new()
                        {
                            id = txtID.Text,
                            pwd = txtPWD.Text,
                        };
                        _userRepository.Insert(member);*/


            //_userRepository.Delete("qqqq"); 

            var members = _userRepository.getAll();

            foreach(var member in members)
            {
                MessageBox.Show($"num : {member.num} / id : {member.id} / pwd : {member.pwd} / name : {member.name} ");
            }

        }
    }
}
