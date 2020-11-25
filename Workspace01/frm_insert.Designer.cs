namespace Workspace01
{
    partial class frm_insert
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
            this.dgv_tel = new System.Windows.Forms.DataGridView();
            this.col_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_empID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_addtel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbx_department = new System.Windows.Forms.ComboBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.NumericUpDown();
            this.txt_telephone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_age)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tel
            // 
            this.dgv_tel.AllowUserToAddRows = false;
            this.dgv_tel.AllowUserToDeleteRows = false;
            this.dgv_tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_telephone,
            this.col_empID});
            this.dgv_tel.Location = new System.Drawing.Point(12, 200);
            this.dgv_tel.Name = "dgv_tel";
            this.dgv_tel.ReadOnly = true;
            this.dgv_tel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_tel.Size = new System.Drawing.Size(316, 178);
            this.dgv_tel.TabIndex = 0;
            this.dgv_tel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tel_CellClick);
            this.dgv_tel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_tel_KeyDown);
            // 
            // col_telephone
            // 
            this.col_telephone.DataPropertyName = "telephone";
            this.col_telephone.HeaderText = "Telephone";
            this.col_telephone.Name = "col_telephone";
            this.col_telephone.ReadOnly = true;
            this.col_telephone.Width = 250;
            // 
            // col_empID
            // 
            this.col_empID.DataPropertyName = "empID";
            this.col_empID.HeaderText = "EMPID";
            this.col_empID.Name = "col_empID";
            this.col_empID.ReadOnly = true;
            this.col_empID.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_addtel
            // 
            this.btn_addtel.Location = new System.Drawing.Point(266, 171);
            this.btn_addtel.Name = "btn_addtel";
            this.btn_addtel.Size = new System.Drawing.Size(62, 23);
            this.btn_addtel.TabIndex = 2;
            this.btn_addtel.Text = "Add";
            this.btn_addtel.UseVisualStyleBackColor = true;
            this.btn_addtel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Firstname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Department";
            // 
            // cbx_department
            // 
            this.cbx_department.FormattingEnabled = true;
            this.cbx_department.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbx_department.Location = new System.Drawing.Point(100, 118);
            this.cbx_department.Name = "cbx_department";
            this.cbx_department.Size = new System.Drawing.Size(160, 21);
            this.cbx_department.TabIndex = 7;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(100, 12);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(160, 20);
            this.txt_firstname.TabIndex = 8;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(100, 48);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(160, 20);
            this.txt_lastname.TabIndex = 9;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(100, 83);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(160, 20);
            this.txt_age.TabIndex = 10;
            this.txt_age.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_telephone
            // 
            this.txt_telephone.Location = new System.Drawing.Point(100, 174);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(160, 20);
            this.txt_telephone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telephone";
            // 
            // frm_insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 419);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.cbx_department);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addtel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_tel);
            this.Name = "frm_insert";
            this.Text = "Insert";
            this.Load += new System.EventHandler(this.frm_insert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_age)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_addtel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbx_department;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.NumericUpDown txt_age;
        private System.Windows.Forms.TextBox txt_telephone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_empID;
    }
}