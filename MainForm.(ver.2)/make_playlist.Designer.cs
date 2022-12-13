
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
            this.DBGrid1 = new System.Windows.Forms.DataGridView();
            this.search = new System.Windows.Forms.Button();
            this.SearchOpenBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PlayListOpenBtn = new System.Windows.Forms.Button();
            this.DBGrid2 = new System.Windows.Forms.DataGridView();
            this.Btnadd = new System.Windows.Forms.Button();
            this.Btndelete = new System.Windows.Forms.Button();
            this.btnpop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txttitle.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txttitle.Location = new System.Drawing.Point(190, 65);
            this.txttitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(260, 34);
            this.txttitle.TabIndex = 0;
            this.txttitle.TextChanged += new System.EventHandler(this.txttitle_TextChanged);
            // 
            // DBGrid1
            // 
            this.DBGrid1.BackgroundColor = System.Drawing.Color.White;
            this.DBGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid1.Location = new System.Drawing.Point(12, 189);
            this.DBGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DBGrid1.Name = "DBGrid1";
            this.DBGrid1.RowHeadersWidth = 51;
            this.DBGrid1.RowTemplate.Height = 23;
            this.DBGrid1.Size = new System.Drawing.Size(378, 286);
            this.DBGrid1.TabIndex = 4;
            this.DBGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBGrid1_CellContentClick);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(130)))), ((int)(((byte)(221)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(457, 65);
            this.search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(86, 36);
            this.search.TabIndex = 6;
            this.search.Text = "검색";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // SearchOpenBtn
            // 
            this.SearchOpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.SearchOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchOpenBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SearchOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchOpenBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SearchOpenBtn.Location = new System.Drawing.Point(98, 482);
            this.SearchOpenBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchOpenBtn.Name = "SearchOpenBtn";
            this.SearchOpenBtn.Size = new System.Drawing.Size(194, 49);
            this.SearchOpenBtn.TabIndex = 7;
            this.SearchOpenBtn.Text = "검색 목록 가져오기";
            this.SearchOpenBtn.UseVisualStyleBackColor = false;
            this.SearchOpenBtn.Click += new System.EventHandler(this.SearchOpenBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "곡 검색 목록";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(472, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "플레이리스트 제작 현황";
            // 
            // PlayListOpenBtn
            // 
            this.PlayListOpenBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.PlayListOpenBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayListOpenBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.PlayListOpenBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayListOpenBtn.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PlayListOpenBtn.Location = new System.Drawing.Point(536, 482);
            this.PlayListOpenBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayListOpenBtn.Name = "PlayListOpenBtn";
            this.PlayListOpenBtn.Size = new System.Drawing.Size(246, 49);
            this.PlayListOpenBtn.TabIndex = 10;
            this.PlayListOpenBtn.Text = "플레이리스트 가져오기";
            this.PlayListOpenBtn.UseVisualStyleBackColor = false;
            this.PlayListOpenBtn.Click += new System.EventHandler(this.PlayListOpenBtn_Click);
            // 
            // DBGrid2
            // 
            this.DBGrid2.BackgroundColor = System.Drawing.Color.White;
            this.DBGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBGrid2.Location = new System.Drawing.Point(475, 189);
            this.DBGrid2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DBGrid2.Name = "DBGrid2";
            this.DBGrid2.RowHeadersWidth = 51;
            this.DBGrid2.RowTemplate.Height = 23;
            this.DBGrid2.Size = new System.Drawing.Size(384, 286);
            this.DBGrid2.TabIndex = 9;
            // 
            // Btnadd
            // 
            this.Btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.Btnadd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnadd.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btnadd.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btnadd.Location = new System.Drawing.Point(413, 286);
            this.Btnadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(40, 44);
            this.Btnadd.TabIndex = 13;
            this.Btnadd.Text = "▶";
            this.Btnadd.UseVisualStyleBackColor = false;
            this.Btnadd.Click += new System.EventHandler(this.Btnadd_Click);
            // 
            // Btndelete
            // 
            this.Btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(130)))), ((int)(((byte)(221)))));
            this.Btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndelete.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Btndelete.ForeColor = System.Drawing.Color.White;
            this.Btndelete.Location = new System.Drawing.Point(730, 575);
            this.Btndelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Btndelete.Name = "Btndelete";
            this.Btndelete.Size = new System.Drawing.Size(86, 49);
            this.Btndelete.TabIndex = 14;
            this.Btndelete.Text = "저장";
            this.Btndelete.UseVisualStyleBackColor = false;
            this.Btndelete.Click += new System.EventHandler(this.Btndelete_Click);
            // 
            // btnpop
            // 
            this.btnpop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(244)))));
            this.btnpop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpop.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnpop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpop.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnpop.Location = new System.Drawing.Point(413, 338);
            this.btnpop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnpop.Name = "btnpop";
            this.btnpop.Size = new System.Drawing.Size(40, 44);
            this.btnpop.TabIndex = 15;
            this.btnpop.Text = "◀";
            this.btnpop.UseVisualStyleBackColor = false;
            this.btnpop.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "제목",
            "가수/그룹명",
            "소속사명"});
            this.comboBox1.Location = new System.Drawing.Point(49, 65);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(133, 36);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // make_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 654);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnpop);
            this.Controls.Add(this.Btndelete);
            this.Controls.Add(this.Btnadd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PlayListOpenBtn);
            this.Controls.Add(this.DBGrid2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SearchOpenBtn);
            this.Controls.Add(this.search);
            this.Controls.Add(this.DBGrid1);
            this.Controls.Add(this.txttitle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(889, 701);
            this.MinimumSize = new System.Drawing.Size(889, 701);
            this.Name = "make_playlist";
            this.Text = "플레이 리스트 만들기";
            this.Load += new System.EventHandler(this.make_playlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.DataGridView DBGrid1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button SearchOpenBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PlayListOpenBtn;
        private System.Windows.Forms.DataGridView DBGrid2;
        private System.Windows.Forms.Button Btnadd;
        private System.Windows.Forms.Button Btndelete;
        private System.Windows.Forms.Button btnpop;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}