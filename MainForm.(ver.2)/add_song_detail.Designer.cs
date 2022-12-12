
namespace MainForm
{
    partial class add_song_detail
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtsingernum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(41, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "번호";
            // 
            // txtnum
            // 
            this.txtnum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtnum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnum.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtnum.Location = new System.Drawing.Point(46, 46);
            this.txtnum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtnum.MaximumSize = new System.Drawing.Size(309, 38);
            this.txtnum.MaxLength = 30;
            this.txtnum.MinimumSize = new System.Drawing.Size(309, 38);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(309, 38);
            this.txtnum.TabIndex = 8;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txttitle.Location = new System.Drawing.Point(46, 145);
            this.txttitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttitle.MaximumSize = new System.Drawing.Size(309, 38);
            this.txttitle.MaxLength = 30;
            this.txttitle.MinimumSize = new System.Drawing.Size(309, 38);
            this.txttitle.Multiline = true;
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(309, 38);
            this.txttitle.TabIndex = 10;
            this.txttitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(41, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "제목";
            // 
            // txtyear
            // 
            this.txtyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtyear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtyear.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtyear.Location = new System.Drawing.Point(46, 244);
            this.txtyear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtyear.MaximumSize = new System.Drawing.Size(309, 38);
            this.txtyear.MaxLength = 30;
            this.txtyear.MinimumSize = new System.Drawing.Size(309, 38);
            this.txtyear.Multiline = true;
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(309, 38);
            this.txtyear.TabIndex = 12;
            this.txtyear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(41, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 28);
            this.label3.TabIndex = 11;
            this.label3.Text = "발매날짜";
            // 
            // txtgenre
            // 
            this.txtgenre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtgenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtgenre.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtgenre.Location = new System.Drawing.Point(46, 342);
            this.txtgenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgenre.MaximumSize = new System.Drawing.Size(309, 38);
            this.txtgenre.MaxLength = 30;
            this.txtgenre.MinimumSize = new System.Drawing.Size(309, 38);
            this.txtgenre.Multiline = true;
            this.txtgenre.Name = "txtgenre";
            this.txtgenre.Size = new System.Drawing.Size(309, 38);
            this.txtgenre.TabIndex = 14;
            this.txtgenre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtnum_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(41, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 28);
            this.label4.TabIndex = 13;
            this.label4.Text = "장르";
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(130)))), ((int)(((byte)(221)))));
            this.btnOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(46, 521);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(309, 62);
            this.btnOK.TabIndex = 15;
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtsingernum
            // 
            this.txtsingernum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txtsingernum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtsingernum.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsingernum.Location = new System.Drawing.Point(46, 439);
            this.txtsingernum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsingernum.MaximumSize = new System.Drawing.Size(309, 38);
            this.txtsingernum.MaxLength = 30;
            this.txtsingernum.MinimumSize = new System.Drawing.Size(309, 38);
            this.txtsingernum.Multiline = true;
            this.txtsingernum.Name = "txtsingernum";
            this.txtsingernum.Size = new System.Drawing.Size(309, 38);
            this.txtsingernum.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(41, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "가수번호";
            // 
            // add_song_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 629);
            this.Controls.Add(this.txtsingernum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtgenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(420, 676);
            this.MinimumSize = new System.Drawing.Size(420, 676);
            this.Name = "add_song_detail";
            this.Text = "신곡 추가";
            this.Load += new System.EventHandler(this.add_song_detail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtsingernum;
        private System.Windows.Forms.Label label5;
    }
}