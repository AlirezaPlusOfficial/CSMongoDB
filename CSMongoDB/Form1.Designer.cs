namespace CSMongoDB
{
    partial class CSMongoDB
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDel = new System.Windows.Forms.Button();
            this.cbCustom = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clientLbl = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbGetID = new System.Windows.Forms.TextBox();
            this.btnShowall = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.tbLname = new System.Windows.Forms.TextBox();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.closeLbl = new System.Windows.Forms.Label();
            this.minimizeLbl = new System.Windows.Forms.Label();
            this.serverLbl = new System.Windows.Forms.Label();
            this.tbC1 = new System.Windows.Forms.TextBox();
            this.tbC2 = new System.Windows.Forms.TextBox();
            this.tbC3 = new System.Windows.Forms.TextBox();
            this.dblD1 = new System.Windows.Forms.Label();
            this.dblD2 = new System.Windows.Forms.Label();
            this.dblD3 = new System.Windows.Forms.Label();
            this.panelCustom = new System.Windows.Forms.Panel();
            this.panelIN = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCustom.SuspendLayout();
            this.panelIN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.cbCustom);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.clientLbl);
            this.panel1.Controls.Add(this.btnShow);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tbGetID);
            this.panel1.Controls.Add(this.btnShowall);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Location = new System.Drawing.Point(-3, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 457);
            this.panel1.TabIndex = 0;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(18, 387);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(185, 39);
            this.btnDel.TabIndex = 34;
            this.btnDel.Text = "DELETE RECORD";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cbCustom
            // 
            this.cbCustom.AutoSize = true;
            this.cbCustom.ForeColor = System.Drawing.Color.White;
            this.cbCustom.Location = new System.Drawing.Point(15, 111);
            this.cbCustom.Name = "cbCustom";
            this.cbCustom.Size = new System.Drawing.Size(61, 17);
            this.cbCustom.TabIndex = 32;
            this.cbCustom.Text = "Custom";
            this.cbCustom.UseVisualStyleBackColor = true;
            this.cbCustom.CheckedChanged += new System.EventHandler(this.cbCustom_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSMongoDB.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // clientLbl
            // 
            this.clientLbl.AutoSize = true;
            this.clientLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientLbl.ForeColor = System.Drawing.Color.White;
            this.clientLbl.Location = new System.Drawing.Point(15, 431);
            this.clientLbl.Name = "clientLbl";
            this.clientLbl.Size = new System.Drawing.Size(121, 13);
            this.clientLbl.TabIndex = 32;
            this.clientLbl.Text = "[CLIENT_VERSION]";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(18, 342);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(185, 39);
            this.btnShow.TabIndex = 26;
            this.btnShow.Text = "SHOW RECORD";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "ID";
            // 
            // tbGetID
            // 
            this.tbGetID.Location = new System.Drawing.Point(67, 316);
            this.tbGetID.Name = "tbGetID";
            this.tbGetID.Size = new System.Drawing.Size(136, 20);
            this.tbGetID.TabIndex = 3;
            // 
            // btnShowall
            // 
            this.btnShowall.Location = new System.Drawing.Point(15, 235);
            this.btnShowall.Name = "btnShowall";
            this.btnShowall.Size = new System.Drawing.Size(187, 23);
            this.btnShowall.TabIndex = 2;
            this.btnShowall.Text = "Show All Records";
            this.btnShowall.UseVisualStyleBackColor = true;
            this.btnShowall.Click += new System.EventHandler(this.btnShowall_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(15, 186);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(187, 24);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(15, 137);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(187, 24);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(234, 244);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(387, 179);
            this.tbResult.TabIndex = 17;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLbl.ForeColor = System.Drawing.Color.White;
            this.resultLbl.Location = new System.Drawing.Point(234, 225);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(49, 13);
            this.resultLbl.TabIndex = 18;
            this.resultLbl.Text = "Results";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(367, 66);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(109, 20);
            this.tbID.TabIndex = 20;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(367, 92);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(109, 20);
            this.tbFname.TabIndex = 21;
            // 
            // tbLname
            // 
            this.tbLname.Location = new System.Drawing.Point(367, 118);
            this.tbLname.Name = "tbLname";
            this.tbLname.Size = new System.Drawing.Size(109, 20);
            this.tbLname.TabIndex = 22;
            // 
            // tbAge
            // 
            this.tbAge.Location = new System.Drawing.Point(367, 144);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(109, 20);
            this.tbAge.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(237, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(237, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(237, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Age";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.White;
            this.titleLbl.Location = new System.Drawing.Point(234, 21);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(98, 16);
            this.titleLbl.TabIndex = 28;
            this.titleLbl.Text = "[APP_NAME]";
            // 
            // closeLbl
            // 
            this.closeLbl.AutoSize = true;
            this.closeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLbl.ForeColor = System.Drawing.Color.White;
            this.closeLbl.Location = new System.Drawing.Point(609, 9);
            this.closeLbl.Name = "closeLbl";
            this.closeLbl.Size = new System.Drawing.Size(27, 25);
            this.closeLbl.TabIndex = 29;
            this.closeLbl.Text = "X";
            this.closeLbl.Click += new System.EventHandler(this.closeLbl_Click);
            this.closeLbl.MouseLeave += new System.EventHandler(this.closeLbl_MouseLeave);
            this.closeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.closeLbl_MouseMove);
            // 
            // minimizeLbl
            // 
            this.minimizeLbl.AutoSize = true;
            this.minimizeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeLbl.ForeColor = System.Drawing.Color.White;
            this.minimizeLbl.Location = new System.Drawing.Point(578, 9);
            this.minimizeLbl.Name = "minimizeLbl";
            this.minimizeLbl.Size = new System.Drawing.Size(25, 25);
            this.minimizeLbl.TabIndex = 30;
            this.minimizeLbl.Text = "_";
            this.minimizeLbl.Click += new System.EventHandler(this.minimizeLbl_Click);
            this.minimizeLbl.MouseLeave += new System.EventHandler(this.minimizeLbl_MouseLeave);
            this.minimizeLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.minimizeLbl_MouseMove);
            // 
            // serverLbl
            // 
            this.serverLbl.AutoSize = true;
            this.serverLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverLbl.ForeColor = System.Drawing.Color.White;
            this.serverLbl.Location = new System.Drawing.Point(233, 428);
            this.serverLbl.Name = "serverLbl";
            this.serverLbl.Size = new System.Drawing.Size(127, 13);
            this.serverLbl.TabIndex = 31;
            this.serverLbl.Text = "[SERVER_VERSION]";
            // 
            // tbC1
            // 
            this.tbC1.Location = new System.Drawing.Point(3, 5);
            this.tbC1.Name = "tbC1";
            this.tbC1.Size = new System.Drawing.Size(100, 20);
            this.tbC1.TabIndex = 32;
            // 
            // tbC2
            // 
            this.tbC2.Location = new System.Drawing.Point(3, 31);
            this.tbC2.Name = "tbC2";
            this.tbC2.Size = new System.Drawing.Size(100, 20);
            this.tbC2.TabIndex = 33;
            // 
            // tbC3
            // 
            this.tbC3.Location = new System.Drawing.Point(3, 56);
            this.tbC3.Name = "tbC3";
            this.tbC3.Size = new System.Drawing.Size(100, 20);
            this.tbC3.TabIndex = 34;
            // 
            // dblD1
            // 
            this.dblD1.AutoSize = true;
            this.dblD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblD1.ForeColor = System.Drawing.Color.White;
            this.dblD1.Location = new System.Drawing.Point(110, 3);
            this.dblD1.Name = "dblD1";
            this.dblD1.Size = new System.Drawing.Size(14, 20);
            this.dblD1.TabIndex = 35;
            this.dblD1.Text = ":";
            // 
            // dblD2
            // 
            this.dblD2.AutoSize = true;
            this.dblD2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblD2.ForeColor = System.Drawing.Color.White;
            this.dblD2.Location = new System.Drawing.Point(110, 30);
            this.dblD2.Name = "dblD2";
            this.dblD2.Size = new System.Drawing.Size(14, 20);
            this.dblD2.TabIndex = 36;
            this.dblD2.Text = ":";
            // 
            // dblD3
            // 
            this.dblD3.AutoSize = true;
            this.dblD3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dblD3.ForeColor = System.Drawing.Color.White;
            this.dblD3.Location = new System.Drawing.Point(110, 56);
            this.dblD3.Name = "dblD3";
            this.dblD3.Size = new System.Drawing.Size(14, 20);
            this.dblD3.TabIndex = 37;
            this.dblD3.Text = ":";
            // 
            // panelCustom
            // 
            this.panelCustom.Controls.Add(this.tbC1);
            this.panelCustom.Controls.Add(this.dblD3);
            this.panelCustom.Controls.Add(this.tbC2);
            this.panelCustom.Controls.Add(this.dblD2);
            this.panelCustom.Controls.Add(this.tbC3);
            this.panelCustom.Controls.Add(this.dblD1);
            this.panelCustom.Location = new System.Drawing.Point(236, 85);
            this.panelCustom.Name = "panelCustom";
            this.panelCustom.Size = new System.Drawing.Size(128, 83);
            this.panelCustom.TabIndex = 38;
            // 
            // panelIN
            // 
            this.panelIN.Controls.Add(this.checkBox3);
            this.panelIN.Controls.Add(this.checkBox2);
            this.panelIN.Controls.Add(this.checkBox1);
            this.panelIN.Location = new System.Drawing.Point(482, 88);
            this.panelIN.Name = "panelIN";
            this.panelIN.Size = new System.Drawing.Size(95, 77);
            this.panelIN.TabIndex = 39;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.ForeColor = System.Drawing.Color.White;
            this.checkBox3.Location = new System.Drawing.Point(3, 57);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Numeric";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(3, 33);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Numeric";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(3, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(65, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Numeric";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CSMongoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(42)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(648, 450);
            this.Controls.Add(this.panelIN);
            this.Controls.Add(this.panelCustom);
            this.Controls.Add(this.serverLbl);
            this.Controls.Add(this.minimizeLbl);
            this.Controls.Add(this.closeLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbAge);
            this.Controls.Add(this.tbLname);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CSMongoDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSharp MongoDB";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCustom.ResumeLayout(false);
            this.panelCustom.PerformLayout();
            this.panelIN.ResumeLayout(false);
            this.panelIN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label clientLbl;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbGetID;
        private System.Windows.Forms.Button btnShowall;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.TextBox tbLname;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label closeLbl;
        private System.Windows.Forms.Label minimizeLbl;
        private System.Windows.Forms.Label serverLbl;
        private System.Windows.Forms.CheckBox cbCustom;
        private System.Windows.Forms.TextBox tbC1;
        private System.Windows.Forms.TextBox tbC2;
        private System.Windows.Forms.TextBox tbC3;
        private System.Windows.Forms.Label dblD1;
        private System.Windows.Forms.Label dblD2;
        private System.Windows.Forms.Label dblD3;
        private System.Windows.Forms.Panel panelCustom;
        private System.Windows.Forms.Panel panelIN;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnDel;
    }
}

