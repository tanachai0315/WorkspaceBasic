namespace Workspace01
{
    partial class frm_update
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
            this.label5 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_age = new System.Windows.Forms.NumericUpDown();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.txt_firstname = new System.Windows.Forms.TextBox();
            this.cbx_depart = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.dgv_tel = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.col_telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_empid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txt_age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telephone";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(98, 177);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(160, 20);
            this.txt_tel.TabIndex = 24;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(98, 86);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(160, 20);
            this.txt_age.TabIndex = 23;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(98, 51);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(160, 20);
            this.txt_lastname.TabIndex = 22;
            // 
            // txt_firstname
            // 
            this.txt_firstname.Location = new System.Drawing.Point(98, 15);
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.Size = new System.Drawing.Size(160, 20);
            this.txt_firstname.TabIndex = 21;
            // 
            // cbx_depart
            // 
            this.cbx_depart.FormattingEnabled = true;
            this.cbx_depart.Location = new System.Drawing.Point(98, 121);
            this.cbx_depart.Name = "cbx_depart";
            this.cbx_depart.Size = new System.Drawing.Size(160, 21);
            this.cbx_depart.TabIndex = 20;
            this.cbx_depart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbx_depart_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Age";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Firstname";
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(251, 387);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_tel
            // 
            this.dgv_tel.AllowUserToAddRows = false;
            this.dgv_tel.AllowUserToDeleteRows = false;
            this.dgv_tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_telephone,
            this.col_empid});
            this.dgv_tel.Location = new System.Drawing.Point(10, 203);
            this.dgv_tel.Name = "dgv_tel";
            this.dgv_tel.ReadOnly = true;
            this.dgv_tel.Size = new System.Drawing.Size(316, 178);
            this.dgv_tel.TabIndex = 13;
            this.dgv_tel.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tel_CellClick);
            this.dgv_tel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_tel_KeyDown);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 174);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // col_telephone
            // 
            this.col_telephone.DataPropertyName = "telephone";
            this.col_telephone.HeaderText = "Telephone";
            this.col_telephone.Name = "col_telephone";
            this.col_telephone.ReadOnly = true;
            // 
            // col_empid
            // 
            this.col_empid.DataPropertyName = "empID";
            this.col_empid.HeaderText = "EMPID";
            this.col_empid.Name = "col_empid";
            this.col_empid.ReadOnly = true;
            this.col_empid.Visible = false;
            // 
            // frm_update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 415);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.cbx_depart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.dgv_tel);
            this.Name = "frm_update";
            this.Text = "frm_update";
            this.Load += new System.EventHandler(this.frm_update_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.NumericUpDown txt_age;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.TextBox txt_firstname;
        private System.Windows.Forms.ComboBox cbx_depart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.DataGridView dgv_tel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_empid;
    }
}