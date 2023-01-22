namespace LibraryAutomation
{
    partial class Member
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txtBox_search = new System.Windows.Forms.TextBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.language = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishinghouse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pieces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearofrelease = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_search.Location = new System.Drawing.Point(12, 12);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(77, 34);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txtBox_search
            // 
            this.txtBox_search.Location = new System.Drawing.Point(95, 12);
            this.txtBox_search.Name = "txtBox_search";
            this.txtBox_search.Size = new System.Drawing.Size(97, 31);
            this.txtBox_search.TabIndex = 2;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_refresh.Location = new System.Drawing.Point(198, 9);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(86, 34);
            this.btn_refresh.TabIndex = 0;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(780, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 31);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.author,
            this.language,
            this.publishinghouse,
            this.type,
            this.pieces,
            this.yearofrelease});
            this.dataGridView1.Location = new System.Drawing.Point(12, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(903, 428);
            this.dataGridView1.TabIndex = 4;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 120;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 120;
            // 
            // author
            // 
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 8;
            this.author.Name = "author";
            this.author.Width = 120;
            // 
            // language
            // 
            this.language.HeaderText = "Language";
            this.language.MinimumWidth = 8;
            this.language.Name = "language";
            this.language.Width = 120;
            // 
            // publishinghouse
            // 
            this.publishinghouse.HeaderText = "Publishing House";
            this.publishinghouse.MinimumWidth = 8;
            this.publishinghouse.Name = "publishinghouse";
            this.publishinghouse.Width = 120;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 8;
            this.type.Name = "type";
            this.type.Width = 120;
            // 
            // pieces
            // 
            this.pieces.HeaderText = "Pieces";
            this.pieces.MinimumWidth = 8;
            this.pieces.Name = "pieces";
            this.pieces.Width = 120;
            // 
            // yearofrelease
            // 
            this.yearofrelease.HeaderText = "Year Of Release";
            this.yearofrelease.MinimumWidth = 8;
            this.yearofrelease.Name = "yearofrelease";
            this.yearofrelease.Width = 120;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_logout.Location = new System.Drawing.Point(12, 497);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(133, 47);
            this.btn_logout.TabIndex = 5;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 568);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBox_search);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_search);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member";
            this.Load += new System.EventHandler(this.Member_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_search;
        private TextBox txtBox_search;
        private Button btn_refresh;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Button btn_logout;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn language;
        private DataGridViewTextBoxColumn publishinghouse;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn pieces;
        private DataGridViewTextBoxColumn yearofrelease;
    }
}