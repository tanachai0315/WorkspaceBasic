namespace Workspace01
{
    partial class frm_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_emp = new System.Windows.Forms.DataGridView();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.col_empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_departmentid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_departmentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_del = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_emp
            // 
            this.dgv_emp.AllowUserToAddRows = false;
            this.dgv_emp.AllowUserToDeleteRows = false;
            this.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_empid,
            this.col_firstname,
            this.col_lastname,
            this.col_age,
            this.col_telephone,
            this.col_departmentid,
            this.col_departmentname});
            this.dgv_emp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_emp.Location = new System.Drawing.Point(0, 78);
            this.dgv_emp.Name = "dgv_emp";
            this.dgv_emp.ReadOnly = true;
            this.dgv_emp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_emp.Size = new System.Drawing.Size(864, 412);
            this.dgv_emp.TabIndex = 0;
            this.dgv_emp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellClick);
            this.dgv_emp.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_emp_CellDoubleClick);
            this.dgv_emp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_emp_KeyDown);
            this.dgv_emp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgv_emp_KeyPress);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(0, 39);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(110, 33);
            this.btn_view.TabIndex = 1;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(0, -1);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(218, 47);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(262, 20);
            this.txt_search.TabIndex = 4;
            this.txt_search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_search_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ค้นหา";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(816, -1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(754, 40);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(110, 33);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // col_empid
            // 
            this.col_empid.DataPropertyName = "empID";
            this.col_empid.HeaderText = "EmployeeID";
            this.col_empid.Name = "col_empid";
            this.col_empid.ReadOnly = true;
            // 
            // col_firstname
            // 
            this.col_firstname.DataPropertyName = "empfirstname";
            this.col_firstname.HeaderText = "Firstname";
            this.col_firstname.Name = "col_firstname";
            this.col_firstname.ReadOnly = true;
            // 
            // col_lastname
            // 
            this.col_lastname.DataPropertyName = "emplastname";
            this.col_lastname.HeaderText = "Lastname";
            this.col_lastname.Name = "col_lastname";
            this.col_lastname.ReadOnly = true;
            // 
            // col_age
            // 
            this.col_age.DataPropertyName = "Age";
            this.col_age.HeaderText = "Age";
            this.col_age.Name = "col_age";
            this.col_age.ReadOnly = true;
            // 
            // col_telephone
            // 
            this.col_telephone.DataPropertyName = "telephone";
            this.col_telephone.HeaderText = "Telephone";
            this.col_telephone.Name = "col_telephone";
            this.col_telephone.ReadOnly = true;
            // 
            // col_departmentid
            // 
            this.col_departmentid.DataPropertyName = "departmentID";
            this.col_departmentid.HeaderText = "DepartmentID";
            this.col_departmentid.Name = "col_departmentid";
            this.col_departmentid.ReadOnly = true;
            this.col_departmentid.Visible = false;
            // 
            // col_departmentname
            // 
            this.col_departmentname.DataPropertyName = "departmentName";
            this.col_departmentname.HeaderText = "DepartmentName";
            this.col_departmentname.Name = "col_departmentname";
            this.col_departmentname.ReadOnly = true;
            // 
            // btn_del
            // 
            this.btn_del.Location = new System.Drawing.Point(638, 39);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(110, 33);
            this.btn_del.TabIndex = 8;
            this.btn_del.Text = "Delete";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 490);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.dgv_emp);
            this.Name = "frm_main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_emp;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_empid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_age;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_departmentid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_departmentname;
        private System.Windows.Forms.Button btn_del;
    }
}

