namespace SabeTaoBem
{
    partial class UserControlComments
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
            this.lblComments = new System.Windows.Forms.Label();
            this.btnNotApprove = new System.Windows.Forms.Button();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.radioBtnPending = new System.Windows.Forms.RadioButton();
            this.radioBtnAll = new System.Windows.Forms.RadioButton();
            this.radioBtnNotApproved = new System.Windows.Forms.RadioButton();
            this.radioBtnApproved = new System.Windows.Forms.RadioButton();
            this.listViewComments = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmRecipeName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnApprove = new System.Windows.Forms.Button();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.ForeColor = System.Drawing.Color.White;
            this.lblComments.Location = new System.Drawing.Point(538, 25);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(162, 40);
            this.lblComments.TabIndex = 16;
            this.lblComments.Text = "Comentários";
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
            this.btnNotApprove.Location = new System.Drawing.Point(1041, 98);
            this.btnNotApprove.Name = "btnNotApprove";
            this.btnNotApprove.Size = new System.Drawing.Size(150, 35);
            this.btnNotApprove.TabIndex = 25;
            this.btnNotApprove.Text = "Não Aprovar";
            this.btnNotApprove.UseVisualStyleBackColor = true;
            this.btnNotApprove.Click += new System.EventHandler(this.BtnNotApprove_Click);
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.radioBtnPending);
            this.groupBoxFiltro.Controls.Add(this.radioBtnAll);
            this.groupBoxFiltro.Controls.Add(this.radioBtnNotApproved);
            this.groupBoxFiltro.Controls.Add(this.radioBtnApproved);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.ForeColor = System.Drawing.Color.White;
            this.groupBoxFiltro.Location = new System.Drawing.Point(46, 80);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(399, 53);
            this.groupBoxFiltro.TabIndex = 24;
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
            // radioBtnAll
            // 
            this.radioBtnAll.AutoSize = true;
            this.radioBtnAll.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.radioBtnAll.Location = new System.Drawing.Point(330, 19);
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
            // listViewComments
            // 
            this.listViewComments.AllowColumnReorder = true;
            this.listViewComments.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmComment,
            this.clmRecipeName,
            this.clmUsername,
            this.clmDate,
            this.clmStatus});
            this.listViewComments.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewComments.FullRowSelect = true;
            this.listViewComments.GridLines = true;
            this.listViewComments.Location = new System.Drawing.Point(46, 147);
            this.listViewComments.MultiSelect = false;
            this.listViewComments.Name = "listViewComments";
            this.listViewComments.OwnerDraw = true;
            this.listViewComments.Size = new System.Drawing.Size(1145, 577);
            this.listViewComments.TabIndex = 23;
            this.listViewComments.UseCompatibleStateImageBehavior = false;
            this.listViewComments.View = System.Windows.Forms.View.Details;
            this.listViewComments.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListViewComments_DrawColumnHeader);
            this.listViewComments.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListViewComments_DrawItem);
            this.listViewComments.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListViewComments_DrawSubItem);
            // 
            // clmId
            // 
            this.clmId.Text = "ID";
            // 
            // clmComment
            // 
            this.clmComment.Text = "Comentário";
            this.clmComment.Width = 370;
            // 
            // clmRecipeName
            // 
            this.clmRecipeName.Text = "Nome Receita";
            this.clmRecipeName.Width = 250;
            // 
            // clmUsername
            // 
            this.clmUsername.Text = "Username";
            this.clmUsername.Width = 135;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Data";
            this.clmDate.Width = 175;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Estado";
            this.clmStatus.Width = 175;
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
            this.btnApprove.Location = new System.Drawing.Point(885, 98);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(150, 35);
            this.btnApprove.TabIndex = 21;
            this.btnApprove.Text = "Aprovar";
            this.btnApprove.UseVisualStyleBackColor = true;
            this.btnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            // 
            // UserControlComments
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnNotApprove);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.listViewComments);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.lblComments);
            this.Name = "UserControlComments";
            this.Size = new System.Drawing.Size(1249, 756);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Button btnNotApprove;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.RadioButton radioBtnPending;
        private System.Windows.Forms.RadioButton radioBtnAll;
        private System.Windows.Forms.RadioButton radioBtnNotApproved;
        private System.Windows.Forms.RadioButton radioBtnApproved;
        private System.Windows.Forms.ListView listViewComments;
        private System.Windows.Forms.ColumnHeader clmComment;
        private System.Windows.Forms.ColumnHeader clmRecipeName;
        private System.Windows.Forms.ColumnHeader clmUsername;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.ColumnHeader clmId;
    }
}
