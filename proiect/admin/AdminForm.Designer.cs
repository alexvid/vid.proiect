namespace admin
{
    partial class AdminForm
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
            this.usergrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.idtxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typetxt = new System.Windows.Forms.TextBox();
            this.lnametxt = new System.Windows.Forms.TextBox();
            this.fnametxt = new System.Windows.Forms.TextBox();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // usergrid
            // 
            this.usergrid.AllowUserToAddRows = false;
            this.usergrid.AllowUserToDeleteRows = false;
            this.usergrid.AllowUserToResizeColumns = false;
            this.usergrid.AllowUserToResizeRows = false;
            this.usergrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usergrid.Location = new System.Drawing.Point(240, 25);
            this.usergrid.MultiSelect = false;
            this.usergrid.Name = "usergrid";
            this.usergrid.ReadOnly = true;
            this.usergrid.RowHeadersVisible = false;
            this.usergrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usergrid.Size = new System.Drawing.Size(426, 237);
            this.usergrid.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Id:";
            // 
            // idtxt
            // 
            this.idtxt.Location = new System.Drawing.Point(75, 25);
            this.idtxt.Name = "idtxt";
            this.idtxt.Size = new System.Drawing.Size(100, 20);
            this.idtxt.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Type(1-3):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Username:";
            // 
            // typetxt
            // 
            this.typetxt.Location = new System.Drawing.Point(75, 161);
            this.typetxt.Name = "typetxt";
            this.typetxt.Size = new System.Drawing.Size(100, 20);
            this.typetxt.TabIndex = 37;
            // 
            // lnametxt
            // 
            this.lnametxt.Location = new System.Drawing.Point(75, 132);
            this.lnametxt.Name = "lnametxt";
            this.lnametxt.Size = new System.Drawing.Size(100, 20);
            this.lnametxt.TabIndex = 36;
            // 
            // fnametxt
            // 
            this.fnametxt.Location = new System.Drawing.Point(75, 106);
            this.fnametxt.Name = "fnametxt";
            this.fnametxt.Size = new System.Drawing.Size(100, 20);
            this.fnametxt.TabIndex = 35;
            // 
            // passtxt
            // 
            this.passtxt.Location = new System.Drawing.Point(75, 80);
            this.passtxt.Name = "passtxt";
            this.passtxt.Size = new System.Drawing.Size(100, 20);
            this.passtxt.TabIndex = 34;
            // 
            // usertxt
            // 
            this.usertxt.Location = new System.Drawing.Point(75, 54);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(100, 20);
            this.usertxt.TabIndex = 33;
            // 
            // Viewbtn
            // 
            this.Viewbtn.Location = new System.Drawing.Point(124, 240);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(75, 23);
            this.Viewbtn.TabIndex = 32;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = true;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click_1);
            // 
            // Updatebtn
            // 
            this.Updatebtn.Location = new System.Drawing.Point(14, 240);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(75, 23);
            this.Updatebtn.TabIndex = 31;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = true;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click_1);
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(124, 194);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(75, 23);
            this.Deletebtn.TabIndex = 30;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click_1);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(14, 194);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(75, 23);
            this.Addbtn.TabIndex = 29;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 286);
            this.Controls.Add(this.usergrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.idtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typetxt);
            this.Controls.Add(this.lnametxt);
            this.Controls.Add(this.fnametxt);
            this.Controls.Add(this.passtxt);
            this.Controls.Add(this.usertxt);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Addbtn);
            this.Name = "AdminForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.usergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usergrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox idtxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox typetxt;
        private System.Windows.Forms.TextBox lnametxt;
        private System.Windows.Forms.TextBox fnametxt;
        private System.Windows.Forms.TextBox passtxt;
        private System.Windows.Forms.TextBox usertxt;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Addbtn;
    }
}

