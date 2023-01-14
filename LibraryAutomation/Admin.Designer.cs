namespace LibraryAutomation
{
    partial class Admin
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
            this.groupBox_member_transactions = new System.Windows.Forms.GroupBox();
            this.maskTxtBox_created_data = new System.Windows.Forms.MaskedTextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtBox_authority = new System.Windows.Forms.TextBox();
            this.lbl_authority = new System.Windows.Forms.Label();
            this.txtBox_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txtBox_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_created_data = new System.Windows.Forms.Label();
            this.txtBox_surname = new System.Windows.Forms.TextBox();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txtBox_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_members = new System.Windows.Forms.Label();
            this.dataGridView_members = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_member_transactions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_members)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_member_transactions
            // 
            this.groupBox_member_transactions.Controls.Add(this.maskTxtBox_created_data);
            this.groupBox_member_transactions.Controls.Add(this.btn_clear);
            this.groupBox_member_transactions.Controls.Add(this.btn_update);
            this.groupBox_member_transactions.Controls.Add(this.btn_remove);
            this.groupBox_member_transactions.Controls.Add(this.btn_add);
            this.groupBox_member_transactions.Controls.Add(this.txtBox_authority);
            this.groupBox_member_transactions.Controls.Add(this.lbl_authority);
            this.groupBox_member_transactions.Controls.Add(this.txtBox_password);
            this.groupBox_member_transactions.Controls.Add(this.lbl_password);
            this.groupBox_member_transactions.Controls.Add(this.txtBox_username);
            this.groupBox_member_transactions.Controls.Add(this.lbl_username);
            this.groupBox_member_transactions.Controls.Add(this.lbl_created_data);
            this.groupBox_member_transactions.Controls.Add(this.txtBox_surname);
            this.groupBox_member_transactions.Controls.Add(this.lbl_surname);
            this.groupBox_member_transactions.Controls.Add(this.txtBox_name);
            this.groupBox_member_transactions.Controls.Add(this.lbl_name);
            this.groupBox_member_transactions.Controls.Add(this.txtBox_id);
            this.groupBox_member_transactions.Controls.Add(this.lbl_id);
            this.groupBox_member_transactions.Location = new System.Drawing.Point(12, 12);
            this.groupBox_member_transactions.Name = "groupBox_member_transactions";
            this.groupBox_member_transactions.Size = new System.Drawing.Size(416, 656);
            this.groupBox_member_transactions.TabIndex = 0;
            this.groupBox_member_transactions.TabStop = false;
            this.groupBox_member_transactions.Text = "Member Transactions";
            // 
            // maskTxtBox_created_data
            // 
            this.maskTxtBox_created_data.Location = new System.Drawing.Point(142, 225);
            this.maskTxtBox_created_data.Mask = "00/00/0000 90:00:00";
            this.maskTxtBox_created_data.Name = "maskTxtBox_created_data";
            this.maskTxtBox_created_data.Size = new System.Drawing.Size(260, 31);
            this.maskTxtBox_created_data.TabIndex = 3;
            this.maskTxtBox_created_data.ValidatingType = typeof(System.DateTime);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_clear.Location = new System.Drawing.Point(17, 585);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(385, 47);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update.Location = new System.Drawing.Point(17, 532);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(385, 47);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_remove.Location = new System.Drawing.Point(17, 479);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(385, 47);
            this.btn_remove.TabIndex = 8;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add.Location = new System.Drawing.Point(17, 426);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(385, 47);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtBox_authority
            // 
            this.txtBox_authority.Location = new System.Drawing.Point(142, 371);
            this.txtBox_authority.Name = "txtBox_authority";
            this.txtBox_authority.Size = new System.Drawing.Size(260, 31);
            this.txtBox_authority.TabIndex = 6;
            // 
            // lbl_authority
            // 
            this.lbl_authority.AutoSize = true;
            this.lbl_authority.Location = new System.Drawing.Point(17, 374);
            this.lbl_authority.Name = "lbl_authority";
            this.lbl_authority.Size = new System.Drawing.Size(86, 25);
            this.lbl_authority.TabIndex = 0;
            this.lbl_authority.Text = "Authority";
            // 
            // txtBox_password
            // 
            this.txtBox_password.Location = new System.Drawing.Point(142, 320);
            this.txtBox_password.Name = "txtBox_password";
            this.txtBox_password.Size = new System.Drawing.Size(260, 31);
            this.txtBox_password.TabIndex = 5;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(17, 323);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(87, 25);
            this.lbl_password.TabIndex = 0;
            this.lbl_password.Text = "Password";
            // 
            // txtBox_username
            // 
            this.txtBox_username.Location = new System.Drawing.Point(142, 271);
            this.txtBox_username.Name = "txtBox_username";
            this.txtBox_username.Size = new System.Drawing.Size(260, 31);
            this.txtBox_username.TabIndex = 4;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(17, 274);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(95, 25);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Username:";
            // 
            // lbl_created_data
            // 
            this.lbl_created_data.AutoSize = true;
            this.lbl_created_data.Location = new System.Drawing.Point(17, 228);
            this.lbl_created_data.Name = "lbl_created_data";
            this.lbl_created_data.Size = new System.Drawing.Size(119, 25);
            this.lbl_created_data.TabIndex = 0;
            this.lbl_created_data.Text = "Created Data:";
            // 
            // txtBox_surname
            // 
            this.txtBox_surname.Location = new System.Drawing.Point(142, 175);
            this.txtBox_surname.Name = "txtBox_surname";
            this.txtBox_surname.Size = new System.Drawing.Size(260, 31);
            this.txtBox_surname.TabIndex = 2;
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Location = new System.Drawing.Point(17, 178);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(86, 25);
            this.lbl_surname.TabIndex = 0;
            this.lbl_surname.Text = "Surname:";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Location = new System.Drawing.Point(142, 131);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(260, 31);
            this.txtBox_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(17, 131);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(63, 25);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // txtBox_id
            // 
            this.txtBox_id.Location = new System.Drawing.Point(142, 83);
            this.txtBox_id.Name = "txtBox_id";
            this.txtBox_id.Size = new System.Drawing.Size(260, 31);
            this.txtBox_id.TabIndex = 0;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(17, 83);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(32, 25);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "Id:";
            // 
            // lbl_members
            // 
            this.lbl_members.AutoSize = true;
            this.lbl_members.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_members.Location = new System.Drawing.Point(745, 54);
            this.lbl_members.Name = "lbl_members";
            this.lbl_members.Size = new System.Drawing.Size(140, 38);
            this.lbl_members.TabIndex = 1;
            this.lbl_members.Text = "Members";
            // 
            // dataGridView_members
            // 
            this.dataGridView_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_members.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.surname,
            this.createdData,
            this.username,
            this.password,
            this.authority});
            this.dataGridView_members.Location = new System.Drawing.Point(451, 95);
            this.dataGridView_members.Name = "dataGridView_members";
            this.dataGridView_members.RowHeadersWidth = 62;
            this.dataGridView_members.RowTemplate.Height = 33;
            this.dataGridView_members.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_members.Size = new System.Drawing.Size(755, 319);
            this.dataGridView_members.TabIndex = 0;
            this.dataGridView_members.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_members_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 8;
            this.name.Name = "name";
            this.name.Width = 150;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.MinimumWidth = 8;
            this.surname.Name = "surname";
            this.surname.Width = 150;
            // 
            // createdData
            // 
            this.createdData.HeaderText = "Created Data";
            this.createdData.MinimumWidth = 8;
            this.createdData.Name = "createdData";
            this.createdData.Width = 150;
            // 
            // username
            // 
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.Width = 150;
            // 
            // password
            // 
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.Width = 150;
            // 
            // authority
            // 
            this.authority.HeaderText = "Authority";
            this.authority.MinimumWidth = 8;
            this.authority.Name = "authority";
            this.authority.Width = 150;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 694);
            this.Controls.Add(this.dataGridView_members);
            this.Controls.Add(this.lbl_members);
            this.Controls.Add(this.groupBox_member_transactions);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox_member_transactions.ResumeLayout(false);
            this.groupBox_member_transactions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox_member_transactions;
        private TextBox txtBox_surname;
        private Label lbl_surname;
        private TextBox txtBox_name;
        private Label lbl_name;
        private TextBox txtBox_id;
        private Label lbl_id;
        private TextBox txtBox_username;
        private Label lbl_username;
        private Label lbl_created_data;
        private TextBox txtBox_authority;
        private Label lbl_authority;
        private TextBox txtBox_password;
        private Label lbl_password;
        private Button btn_clear;
        private Button btn_update;
        private Button btn_remove;
        private Button btn_add;
        private Label lbl_members;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn surname;
        private DataGridViewTextBoxColumn createdData;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn password;
        private DataGridViewTextBoxColumn authority;
        private DataGridView dataGridView_members;
        private MaskedTextBox maskTxtBox_created_data;
    }
}