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
    public partial class frm_update : Form
    {
        public frm_update()
        {
            InitializeComponent();
        }

        public void frm_update_Load(object sender, EventArgs e)
        {
            loadTel();
            LoadDpart();
        }

        string setid;
        string setdpartid;
        internal string empid { set { setid = value; } }
        internal string firstname { set { txt_firstname.Text = value; } }
        internal string lastname { set { txt_lastname.Text = value; } }
        internal string age { set { txt_age.Text = value; } }

        internal string departID { set { setdpartid = value; } }

        internal string depart { set { cbx_depart.Text = value; } }

        public void loadTel()
        {
            string sql_searchtel = "Select * From tbl_telephone Where empID = '" + setid + "'";
            DataTable dt = Connection.SqlGet(sql_searchtel);
            dgv_tel.DataSource = dt;
        }

        public void GetClick()
        {
            txt_tel.Text = dgv_tel.CurrentRow.Cells["col_telephone"].Value.ToString();
        }

        private void dgv_tel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //addTel
            string sql_add = "Insert into tbl_telephone (empID,telephone) Values ('"+setid+"' , '"+txt_tel.Text+"')";
            Connection.SqlGet(sql_add);

            loadTel();
        }

        public void LoadDpart()
        {
            string sql_cbx = "Select * From tbl_department where departmentID='" + setdpartid+"'";
            DataTable dt = Connection.SqlGet(sql_cbx);
            cbx_depart.DataSource = dt;
            cbx_depart.DisplayMember = "departmentName";
            cbx_depart.ValueMember = "departmentID";

        }

        private void dgv_tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {

                string sql_deltel = "DELETE FROM tbl_telephone WHERE empID='"+setid+"' AND telephone = '"+txt_tel.Text+"'";

                    //string sql_deltel = "Delete From tbl_telephone where telephone = '" + txt_tel.Text + "'";
                Connection.SqlGet(sql_deltel);

                    txt_tel.Clear();
                    loadTel();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string sql_update = "Update tbl_employee Set empfirstname='" + txt_firstname.Text + "' , emplastname='" + txt_lastname.Text + "' , Age='" + txt_age.Value.ToString() + "' , departmentID='" + cbx_depart.SelectedValue + "' Where empID='" + setid + "'";
            string sql_updatetel = "Update tbl_telephone Set telephone='" + txt_tel.Text + "' where empId='" + setid + "'";
            Connection.SqlGet(sql_update);
            Connection.SqlGet(sql_updatetel);

            MessageBox.Show("อัพเดทข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadTel();
            Clear();
            Close();
            
        }

    

        private void cbx_depart_MouseClick(object sender, MouseEventArgs e)
        {
            string sql_cbx = "Select * From tbl_department";
            DataTable dt = Connection.SqlGet(sql_cbx);
            cbx_depart.DataSource = dt;
            cbx_depart.DisplayMember = "departmentName";
            cbx_depart.ValueMember = "departmentID";
        }

        public void Clear()
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_age.Text = "";
            txt_tel.Clear();
            cbx_depart.Text = "";


        }

    }

}
