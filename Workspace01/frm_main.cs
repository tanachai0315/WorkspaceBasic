using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workspace01
{


    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();

        }

        public void frm_main_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            string sql_con = "SELECT dbo.tbl_employee.empID, dbo.tbl_employee.empfirstname, dbo.tbl_employee.emplastname, dbo.tbl_employee.Age, dbo.tbl_employee.departmentID, dbo.tbl_department.departmentName, dbo.tbl_telephone.telephone FROM dbo.tbl_employee INNER JOIN dbo.tbl_department ON dbo.tbl_employee.departmentID = dbo.tbl_department.departmentID INNER JOIN dbo.tbl_telephone ON dbo.tbl_employee.empID = dbo.tbl_telephone.empID";
            DataTable dt = Connection.SqlGet(sql_con);
            dgv_emp.DataSource = dt;
        }

        public void Search()
        {
            string sql_search = "SELECT * FROM tbl_employee Where empfirstname like '%" + txt_search.Text+ "%' Or emplastname like '%" + txt_search.Text+ "%'";
            DataTable dt = Connection.SqlGet(sql_search);
            dgv_emp.DataSource = dt;

            txt_search.Clear();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Search();
                
        }

        public void btn_clear_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            LoadData();
        }

        public void btn_view_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void btn_add_Click(object sender, EventArgs e)
        {
            frm_insert frm = new frm_insert();
            frm.ShowDialog();
        }

        public void txt_search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Search();
            }
        }



        private void dgv_emp_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            frm_update frm2 = new frm_update();
            frm2.empid = dgv_emp.CurrentRow.Cells["col_empID"].Value.ToString();
            frm2.firstname = dgv_emp.CurrentRow.Cells["col_firstname"].Value.ToString();
            frm2.lastname = dgv_emp.CurrentRow.Cells["col_lastname"].Value.ToString();
            frm2.age = dgv_emp.CurrentRow.Cells["col_age"].Value.ToString();
            frm2.depart = dgv_emp.CurrentRow.Cells["col_departmentname"].Value.ToString();
            frm2.departID = dgv_emp.CurrentRow.Cells["col_departmentid"].Value.ToString();

            frm2.Show();
      

            
        }

        private void dgv_emp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void dgv_emp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        string setid;
        internal string empid { set { setid = value; } }
        private void btn_del_Click(object sender, EventArgs e)
        {

            string empid = dgv_emp.Rows[dgv_emp.CurrentCell.RowIndex].Cells["col_empID"].Value.ToString();

            string sql_deltel = "Delete From tbl_telephone where empID = '" + empid + "'";
            string sql_del = "Delete From tbl_employee where empID = '" + empid + "'";
            Connection.SqlGet(sql_deltel);
            Connection.SqlGet(sql_del);
            LoadData();

        }

        private void dgv_emp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dgv_emp.CurrentCell.Selected)
            {
                string empid = dgv_emp.Rows[dgv_emp.CurrentCell.RowIndex].Cells["col_empID"].Value.ToString();

                string sql_deltel = "Delete From tbl_telephone where empID = '" + empid + "'";
                string sql_del = "Delete From tbl_employee where empID = '" + empid + "'";
                Connection.SqlGet(sql_deltel);
                Connection.SqlGet(sql_del);

                LoadData();
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
