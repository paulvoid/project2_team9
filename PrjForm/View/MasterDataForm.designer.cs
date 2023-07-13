namespace PrjForm
{
    partial class MasterDataForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_TT = new System.Windows.Forms.DataGridView();
            this.clm_item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_procode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_W = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_H = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_scrap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_udtBY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_udtDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_udtDT = new System.Windows.Forms.TextBox();
            this.txt_udtBY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_SC = new System.Windows.Forms.TextBox();
            this.txt_H = new System.Windows.Forms.TextBox();
            this.txt_W = new System.Windows.Forms.TextBox();
            this.txt_procd = new System.Windows.Forms.TextBox();
            this.txt_mch = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TT)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(17, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(563, 33);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhom 9                           Planning App  Master Data";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 59);
            this.panel1.TabIndex = 1;
            // 
            // dgv_TT
            // 
            this.dgv_TT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_item,
            this.clm_machine,
            this.clm_procode,
            this.clm_W,
            this.clm_H,
            this.clm_scrap,
            this.clm_udtBY,
            this.clm_udtDT});
            this.dgv_TT.Location = new System.Drawing.Point(2, 57);
            this.dgv_TT.Name = "dgv_TT";
            this.dgv_TT.Size = new System.Drawing.Size(652, 461);
            this.dgv_TT.TabIndex = 9;
            this.dgv_TT.SelectionChanged += new System.EventHandler(this.dgv_TT_SelectionChanged);
            // 
            // clm_item
            // 
            this.clm_item.DataPropertyName = "item";
            this.clm_item.HeaderText = "item";
            this.clm_item.Name = "clm_item";
            // 
            // clm_machine
            // 
            this.clm_machine.DataPropertyName = "machine";
            this.clm_machine.HeaderText = "machine";
            this.clm_machine.Name = "clm_machine";
            // 
            // clm_procode
            // 
            this.clm_procode.DataPropertyName = "process_code";
            this.clm_procode.HeaderText = "process code";
            this.clm_procode.Name = "clm_procode";
            // 
            // clm_W
            // 
            this.clm_W.DataPropertyName = "width";
            this.clm_W.HeaderText = "width";
            this.clm_W.Name = "clm_W";
            // 
            // clm_H
            // 
            this.clm_H.DataPropertyName = "height";
            this.clm_H.HeaderText = "height";
            this.clm_H.Name = "clm_H";
            // 
            // clm_scrap
            // 
            this.clm_scrap.DataPropertyName = "scrap";
            this.clm_scrap.HeaderText = "scrap";
            this.clm_scrap.Name = "clm_scrap";
            // 
            // clm_udtBY
            // 
            this.clm_udtBY.DataPropertyName = "updated_by";
            this.clm_udtBY.HeaderText = "update by";
            this.clm_udtBY.Name = "clm_udtBY";
            // 
            // clm_udtDT
            // 
            this.clm_udtDT.DataPropertyName = "updated_date";
            this.clm_udtDT.HeaderText = "update date";
            this.clm_udtDT.Name = "clm_udtDT";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.btnClear);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.btnCreate);
            this.panel5.Controls.Add(this.btnUpdate);
            this.panel5.Location = new System.Drawing.Point(650, 57);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(266, 464);
            this.panel5.TabIndex = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Controls.Add(this.txt_udtDT);
            this.panel6.Controls.Add(this.txt_udtBY);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Controls.Add(this.txt_SC);
            this.panel6.Controls.Add(this.txt_H);
            this.panel6.Controls.Add(this.txt_W);
            this.panel6.Controls.Add(this.txt_procd);
            this.panel6.Controls.Add(this.txt_mch);
            this.panel6.Controls.Add(this.txt_item);
            this.panel6.Controls.Add(this.label1);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(29, 94);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(210, 275);
            this.panel6.TabIndex = 8;
            // 
            // txt_udtDT
            // 
            this.txt_udtDT.Location = new System.Drawing.Point(56, 235);
            this.txt_udtDT.Name = "txt_udtDT";
            this.txt_udtDT.Size = new System.Drawing.Size(140, 20);
            this.txt_udtDT.TabIndex = 15;
            // 
            // txt_udtBY
            // 
            this.txt_udtBY.Location = new System.Drawing.Point(56, 205);
            this.txt_udtBY.Name = "txt_udtBY";
            this.txt_udtBY.Size = new System.Drawing.Size(140, 20);
            this.txt_udtBY.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 235);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "UdtDT:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 206);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "UdtBY:";
            // 
            // txt_SC
            // 
            this.txt_SC.Location = new System.Drawing.Point(56, 174);
            this.txt_SC.Name = "txt_SC";
            this.txt_SC.Size = new System.Drawing.Size(140, 20);
            this.txt_SC.TabIndex = 11;
            // 
            // txt_H
            // 
            this.txt_H.Location = new System.Drawing.Point(56, 142);
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(140, 20);
            this.txt_H.TabIndex = 10;
            // 
            // txt_W
            // 
            this.txt_W.Location = new System.Drawing.Point(56, 110);
            this.txt_W.Name = "txt_W";
            this.txt_W.Size = new System.Drawing.Size(140, 20);
            this.txt_W.TabIndex = 9;
            // 
            // txt_procd
            // 
            this.txt_procd.Location = new System.Drawing.Point(56, 77);
            this.txt_procd.Name = "txt_procd";
            this.txt_procd.Size = new System.Drawing.Size(140, 20);
            this.txt_procd.TabIndex = 8;
            // 
            // txt_mch
            // 
            this.txt_mch.Location = new System.Drawing.Point(56, 46);
            this.txt_mch.Name = "txt_mch";
            this.txt_mch.Size = new System.Drawing.Size(140, 20);
            this.txt_mch.TabIndex = 7;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(56, 13);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(140, 20);
            this.txt_item.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Scrap:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 19);
            this.label9.TabIndex = 4;
            this.label9.Text = "Height:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Width:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 2;
            this.label11.Text = "ProCD:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mch:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Item:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PrjForm.Properties.Resources.WebSV2;
            this.pictureBox2.Location = new System.Drawing.Point(53, 20);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(159, 56);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Blue;
            this.btnClear.Location = new System.Drawing.Point(137, 404);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Blue;
            this.btnDelete.Location = new System.Drawing.Point(26, 404);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Blue;
            this.btnCreate.Location = new System.Drawing.Point(26, 375);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(102, 23);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Blue;
            this.btnUpdate.Location = new System.Drawing.Point(137, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // MasterDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 502);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgv_TT);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MasterDataForm";
            this.Text = "MasterData";
            this.Load += new System.EventHandler(this.MasterDataForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TT)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_TT;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txt_udtDT;
        private System.Windows.Forms.TextBox txt_udtBY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_SC;
        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.TextBox txt_W;
        private System.Windows.Forms.TextBox txt_procd;
        private System.Windows.Forms.TextBox txt_mch;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_item;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_procode;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_W;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_H;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_scrap;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_udtBY;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_udtDT;
    }
}