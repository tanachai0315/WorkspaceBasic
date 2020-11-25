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

    public partial class frm_insert : Form
    {
        List<Tel> listtel = null;
        public frm_insert()
        {
            InitializeComponent();
        }

        public class Tel
        {
            public string Telephone { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listtel.Add(new Tel
            {
                Telephone = txt_telephone.Text
            });

            txt_telephone.Clear();
            txt_telephone.Focus();

            DataBinding();
        }

        public void LoadData()
        {
            string sql_cbx = "Select * From tbl_department";
            DataTable dt = Connection.SqlGet(sql_cbx);
            cbx_department.DataSource = dt;
            cbx_department.DisplayMember = "departmentName";
            cbx_department.ValueMember = "departmentID";

            listtel = new List<Tel>();
            DataBinding();

        }

        private void frm_insert_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DataBinding()
        {
            dgv_tel.DataSource = listtel.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable checkname = Connection.SqlGet("Select * From tbl_employee where empfirstname = '" + txt_firstname.Text + "'");

            if (checkname.Rows.Count > 0)
            {
                MessageBox.Show("ไม่สามารถบันทึกได้ ชื่อพนักงานซ้ำ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!(txt_age.Value >= 17) && (txt_age.Value <= 50))
            {
                MessageBox.Show("ไม่สามารถบันทึกได้ เนื่องจาก ช่วงอายุน้อยกว่า 17 ปี หรือ เกิน 50 ปี", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            if (dgv_tel.Rows.Count == 0)
            {
                MessageBox.Show("ไม่สามารถบันทึกได้ เนื่องจาก ไม่มีข้อมูลเบอร์โทรศัพท์", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string sql_insert = "Insert Into tbl_employee (empfirstname,emplastname,Age,departmentID) Values ('" + txt_firstname.Text + "','" + txt_lastname.Text + "','" + txt_age.Value.ToString() + "','" + cbx_department.SelectedValue + "')";
                Connection.SqlGet(sql_insert);

                for (int i = 0; i < dgv_tel.Rows.Count; i++)
                {
                    string sql_tel = "Insert Into tbl_telephone Select MAX(empID), '" + dgv_tel.Rows[i].Cells["col_telephone"].Value.ToString() + "' From tbl_employee";
                    Connection.SqlGet(sql_tel);
                }

                MessageBox.Show("บันทึกข้อมูลสำเร็จ", "แจ้งเตือน", MessageBoxButtons.OK, MessageBoxIcon.Information);
                listtel.Clear();
                Clear();
            }


        }

        public void Clear()
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_telephone.Clear();
            txt_age.Text = "";
            cbx_department.Text = "";
        }

        public void GetClick()
        {
            txt_telephone.Text = dgv_tel.CurrentRow.Cells["col_telephone"].Value.ToString();
        }
        private void dgv_tel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string count;

                count = dgv_tel.CurrentCell.RowIndex.ToString();
                int number = Convert.ToInt32(count);

                //MessageBox.Show(count);
                listtel.RemoveAt(number);

                txt_telephone.Clear();
                txt_telephone.Focus();
                //listtel.Clear();

                DataBinding();

            }
        }

        private void dgv_tel_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            GetClick();
        }
    }
}
