namespace SabeTaoBem
{
    partial class UserControlUsers
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnBlock = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUsers = new System.Windows.Forms.Label();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.radioBtnPending = new System.Windows.Forms.RadioButton();
            this.radioBtnBlocked = new System.Windows.Forms.RadioButton();
            this.radioBtnAll = new System.Windows.Forms.RadioButton();
            this.radioBtnNotApproved = new System.Windows.Forms.RadioButton();
            this.radioBtnApproved = new System.Windows.Forms.RadioButton();
            this.btnNotApprove = new System.Windows.Forms.Button();
            this.btnUnBlock = new System.Windows.Forms.Button();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApprove.Location = new System.Drawing.Point(582, 98);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(150, 35);
            this.btnApprove.TabIndex = 11;
            this.btnApprove.Text = "Aprovar";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // btnBlock
            // 
            this.btnBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnBlock.FlatAppearance.BorderSize = 0;
            this.btnBlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlock.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.Color.White;
            this.btnBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlock.Location = new System.Drawing.Point(894, 98);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(150, 35);
            this.btnBlock.TabIndex = 12;
            this.btnBlock.Text = "Bloquear";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.BtnBlock_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.AllowColumnReorder = true;
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmSurname,
            this.clmUsername,
            this.clmEmail,
            this.clmDate,
            this.clmStatus});
            this.listViewUsers.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listViewUsers.FullRowSelect = true;
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(46, 147);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.OwnerDraw = true;
            this.listViewUsers.Size = new System.Drawing.Size(1154, 577);
            this.listViewUsers.TabIndex = 13;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            this.listViewUsers.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListViewUsers_DrawColumnHeader);
            this.listViewUsers.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListViewUsers_DrawItem);
            this.listViewUsers.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListViewUsers_DrawSubItem);
            // 
            // clmName
            // 
            this.clmName.Text = "Nome";
            this.clmName.Width = 175;
            // 
            // clmSurname
            // 
            this.clmSurname.Text = "Apelido";
            this.clmSurname.Width = 175;
            // 
            // clmUsername
            // 
            this.clmUsername.Text = "Username";
            this.clmUsername.Width = 175;
            // 
            // clmEmail
            // 
            this.clmEmail.Text = "Email";
            this.clmEmail.Width = 275;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Data Registo";
            this.clmDate.Width = 175;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Estado";
            this.clmStatus.Width = 175;
            // 
            // lblUsers
            // 
            this.lblUsers.AutoSize = true;
            this.lblUsers.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsers.ForeColor = System.Drawing.Color.White;
            this.lblUsers.Location = new System.Drawing.Point(539, 25);
            this.lblUsers.Name = "lblUsers";
            this.lblUsers.Size = new System.Drawing.Size(154, 40);
            this.lblUsers.TabIndex = 14;
            this.lblUsers.Text = "Utilizadores";
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.radioBtnPending);
            this.groupBoxFiltro.Controls.Add(this.radioBtnBlocked);
            this.groupBoxFiltro.Controls.Add(this.radioBtnAll);
            this.groupBoxFiltro.Controls.Add(this.radioBtnNotApproved);
            this.groupBoxFiltro.Controls.Add(this.radioBtnApproved);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.ForeColor = System.Drawing.Color.White;
            this.groupBoxFiltro.Location = new System.Drawing.Point(46, 80);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(504, 53);
            this.groupBoxFiltro.TabIndex = 18;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro";
            // 
            // radioBtnPending
            // 
            this.radioBtnPending.AutoSize = true;
            this.radioBtnPending.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPending.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.radioBtnPending.Location = new System.Drawing.Point(6, 19);
            this.radioBtnPending.Name = "radioBtnPending";
            this.radioBtnPending.Size = new System.Drawing.Size(91, 23);
            this.radioBtnPending.TabIndex = 22;
            this.radioBtnPending.TabStop = true;
            this.radioBtnPending.Text = "Pendentes";
            this.radioBtnPending.UseVisualStyleBackColor = true;
            this.radioBtnPending.CheckedChanged += new System.EventHandler(this.RadioBtnPending_CheckedChanged);
            // 
            // radioBtnBlocked
            // 
            this.radioBtnBlocked.AutoSize = true;
            this.radioBtnBlocked.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnBlocked.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.radioBtnBlocked.Location = new System.Drawing.Point(330, 19);
            this.radioBtnBlocked.Name = "radioBtnBlocked";
            this.radioBtnBlocked.Size = new System.Drawing.Size(99, 23);
            this.radioBtnBlocked.TabIndex = 21;
            this.radioBtnBlocked.TabStop = true;
            this.radioBtnBlocked.Text = "Bloqueados";
            this.radioBtnBlocked.UseVisualStyleBackColor = true;
            this.radioBtnBlocked.CheckedChanged += new System.EventHandler(this.radioBtnBlocked_CheckedChanged);
            // 
            // radioBtnAll
            // 
            this.radioBtnAll.AutoSize = true;
            this.radioBtnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.radioBtnAll.Location = new System.Drawing.Point(434, 19);
            this.radioBtnAll.Name = "radioBtnAll";
            this.radioBtnAll.Size = new System.Drawing.Size(64, 23);
            this.radioBtnAll.TabIndex = 20;
            this.radioBtnAll.TabStop = true;
            this.radioBtnAll.Text = "Todos";
            this.radioBtnAll.UseVisualStyleBackColor = true;
            this.radioBtnAll.CheckedChanged += new System.EventHandler(this.RadioBtnAll_CheckedChanged);
            // 
            // radioBtnNotApproved
            // 
            this.radioBtnNotApproved.AutoSize = true;
            this.radioBtnNotApproved.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNotApproved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.radioBtnNotApproved.Location = new System.Drawing.Point(201, 19);
            this.radioBtnNotApproved.Name = "radioBtnNotApproved";
            this.radioBtnNotApproved.Size = new System.Drawing.Size(123, 23);
            this.radioBtnNotApproved.TabIndex = 19;
            this.radioBtnNotApproved.TabStop = true;
            this.radioBtnNotApproved.Text = "Não Aprovados";
            this.radioBtnNotApproved.UseVisualStyleBackColor = true;
            this.radioBtnNotApproved.CheckedChanged += new System.EventHandler(this.RadioBtnNotApproved_CheckedChanged);
            // 
            // radioBtnApproved
            // 
            this.radioBtnApproved.AutoSize = true;
            this.radioBtnApproved.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnApproved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.radioBtnApproved.Location = new System.Drawing.Point(102, 19);
            this.radioBtnApproved.Name = "radioBtnApproved";
            this.radioBtnApproved.Size = new System.Drawing.Size(93, 23);
            this.radioBtnApproved.TabIndex = 18;
            this.radioBtnApproved.TabStop = true;
            this.radioBtnApproved.Text = "Aprovados";
            this.radioBtnApproved.UseVisualStyleBackColor = true;
            this.radioBtnApproved.CheckedChanged += new System.EventHandler(this.RadioBtnApproved_CheckedChanged);
            // 
            // btnNotApprove
            // 
            this.btnNotApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnNotApprove.FlatAppearance.BorderSize = 0;
            this.btnNotApprove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnNotApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotApprove.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotApprove.ForeColor = System.Drawing.Color.White;
            this.btnNotApprove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotApprove.Location = new System.Drawing.Point(738, 98);
            this.btnNotApprove.Name = "btnNotApprove";
            this.btnNotApprove.Size = new System.Drawing.Size(150, 35);
            this.btnNotApprove.TabIndex = 19;
            this.btnNotApprove.Text = "Não Aprovar";
            this.btnNotApprove.UseVisualStyleBackColor = true;
            this.btnNotApprove.Click += new System.EventHandler(this.BtnNotApprove_Click);
            // 
            // btnUnBlock
            // 
            this.btnUnBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnUnBlock.FlatAppearance.BorderSize = 0;
            this.btnUnBlock.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnUnBlock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnBlock.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnBlock.ForeColor = System.Drawing.Color.White;
            this.btnUnBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUnBlock.Location = new System.Drawing.Point(1050, 98);
            this.btnUnBlock.Name = "btnUnBlock";
            this.btnUnBlock.Size = new System.Drawing.Size(150, 35);
            this.btnUnBlock.TabIndex = 20;
            this.btnUnBlock.Text = "Desbloquear";
            this.btnUnBlock.UseVisualStyleBackColor = true;
            this.btnUnBlock.Click += new System.EventHandler(this.BtnUnBlock_Click);
            // 
            // UserControlUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnUnBlock);
            this.Controls.Add(this.btnNotApprove);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.lblUsers);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.btnApprove);
            this.Name = "UserControlUsers";
            this.Size = new System.Drawing.Size(1249, 756);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.Label lblUsers;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.RadioButton radioBtnAll;
        private System.Windows.Forms.RadioButton radioBtnNotApproved;
        private System.Windows.Forms.RadioButton radioBtnApproved;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmSurname;
        private System.Windows.Forms.ColumnHeader clmUsername;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.RadioButton radioBtnBlocked;
        private System.Windows.Forms.RadioButton radioBtnPending;
        private System.Windows.Forms.Button btnNotApprove;
        private System.Windows.Forms.ColumnHeader clmEmail;
        private System.Windows.Forms.Button btnUnBlock;
    }
}
