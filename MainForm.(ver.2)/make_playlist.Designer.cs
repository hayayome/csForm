
namespace MainForm
{
    partial class make_playlist
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
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DBGrid1 = new System.Windows.Forms.DataGridView();
            this.reset = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.SearchOpenBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayListOpenBtn = new System.Windows.Forms.Button();
            this.DBGrid2 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.Btnadd = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(127, 31);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(100, 21);
            this.txttitle.TabIndex = 0;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(127, 74);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 21);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "제목";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "가수/그룹 이름";
            // 
            // DBGrid1
            // 
            this.DBGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid1.Location = new System.Drawing.Point(43, 210);
            this.DBGrid1.Name = "DBGrid1";
            this.DBGrid1.RowTemplate.Height = 23;
            this.DBGrid1.Size = new System.Drawing.Size(349, 229);
            this.DBGrid1.TabIndex = 4;
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(205, 121);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "다시쓰기";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(86, 121);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 6;
            this.search.Text = "검색하기";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SearchOpenBtn
            // 
            this.SearchOpenBtn.Location = new System.Drawing.Point(146, 458);
            this.SearchOpenBtn.Name = "SearchOpenBtn";
            this.SearchOpenBtn.Size = new System.Drawing.Size(113, 39);
            this.SearchOpenBtn.TabIndex = 7;
            this.SearchOpenBtn.Text = "검색 목록 열기";
            this.SearchOpenBtn.UseVisualStyleBackColor = true;
            this.SearchOpenBtn.Click += new System.EventHandler(this.SearchOpenBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "곡 검색 목록";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(597, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "플레이리스트 제작 현황";
            // 
            // PlayListOpenBtn
            // 
            this.PlayListOpenBtn.Location = new System.Drawing.Point(617, 458);
            this.PlayListOpenBtn.Name = "PlayListOpenBtn";
            this.PlayListOpenBtn.Size = new System.Drawing.Size(113, 39);
            this.PlayListOpenBtn.TabIndex = 10;
            this.PlayListOpenBtn.Text = "플레이리스트 열기";
            this.PlayListOpenBtn.UseVisualStyleBackColor = true;
            this.PlayListOpenBtn.Click += new System.EventHandler(this.PlayListOpenBtn_Click);
            // 
            // DBGrid2
            // 
            this.DBGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid2.Location = new System.Drawing.Point(496, 210);
            this.DBGrid2.Name = "DBGrid2";
            this.DBGrid2.RowTemplate.Height = 23;
            this.DBGrid2.Size = new System.Drawing.Size(349, 229);
            this.DBGrid2.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 40);
            this.button3.TabIndex = 12;
            this.button3.Text = "플레이리스트 제작 목록";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Btnadd
            // 
            this.Btnadd.Location = new System.Drawing.Point(405, 277);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(75, 23);
            this.Btnadd.TabIndex = 13;
            this.Btnadd.Text = "추가하기";
            this.Btnadd.UseVisualStyleBackColor = true;
            this.Btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.Location = new System.Drawing.Point(863, 389);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(75, 23);
            this.Btndelete.TabIndex = 14;
            this.Btndelete.Text = "저장하기";
            this.Btndelete.UseVisualStyleBackColor = true;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(405, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "제거하기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // make_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnadd);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlayListOpenBtn);
            this.Controls.Add(this.DBGrid2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchOpenBtn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.DBGrid1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txttitle);
            this.Name = "make_playlist";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DBGrid1;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button SearchOpenBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PlayListOpenBtn;
        private System.Windows.Forms.DataGridView DBGrid2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Btnadd;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.Button button1;
    }
}