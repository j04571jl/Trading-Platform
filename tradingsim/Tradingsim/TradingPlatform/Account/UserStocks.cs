using Simple.Data;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TradingPlatform
{
    public partial class UserDWform : Form
    {
        public UserDWform()
        {
            InitializeComponent();
        }

        private void UserDWform_Load(object sender, EventArgs e)
        {
            var select = "SELECT * FROM SecuritiesBought WHERE [Username] ="+ Form1.usern;

            var db = Database.OpenNamedConnection("mainDb");
            var SecurityBought = db.SecuritiesBought.FindByUsername(Form1.usern);
            //problem below, has to be a string feeded in.
            var c = new SqlConnection(db); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
