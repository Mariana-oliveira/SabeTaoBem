namespace SabeTaoBem
{
    partial class UserControlRecipes
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
            this.btnNotApprove = new System.Windows.Forms.Button();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.radioBtnPending = new System.Windows.Forms.RadioButton();
            this.radioBtnAll = new System.Windows.Forms.RadioButton();
            this.radioBtnNotApproved = new System.Windows.Forms.RadioButton();
            this.radioBtnApproved = new System.Windows.Forms.RadioButton();
            this.lblRecipes = new System.Windows.Forms.Label();
            this.listViewRecipes = new System.Windows.Forms.ListView();
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUsername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFoodStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnAproved = new System.Windows.Forms.Button();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
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
            this.btnNotApprove.Location = new System.Drawing.Point(1050, 98);
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
            this.groupBoxFiltro.Size = new System.Drawing.Size(395, 53);
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
            this.radioBtnAll.Location = new System.Drawing.Point(329, 19);
            this.radioBtnAll.Name = "radioBtnAll";
            this.radioBtnAll.Size = new System.Drawing.Size(63, 23);
            this.radioBtnAll.TabIndex = 20;
            this.radioBtnAll.TabStop = true;
            this.radioBtnAll.Text = "Todas";
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
            this.radioBtnNotApproved.Size = new System.Drawing.Size(122, 23);
            this.radioBtnNotApproved.TabIndex = 19;
            this.radioBtnNotApproved.TabStop = true;
            this.radioBtnNotApproved.Text = "Não Aprovadas";
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
            this.radioBtnApproved.Size = new System.Drawing.Size(92, 23);
            this.radioBtnApproved.TabIndex = 18;
            this.radioBtnApproved.TabStop = true;
            this.radioBtnApproved.Text = "Aprovadas";
            this.radioBtnApproved.UseVisualStyleBackColor = true;
            this.radioBtnApproved.CheckedChanged += new System.EventHandler(this.RadioBtnApproved_CheckedChanged);
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipes.ForeColor = System.Drawing.Color.White;
            this.lblRecipes.Location = new System.Drawing.Point(539, 25);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(111, 40);
            this.lblRecipes.TabIndex = 23;
            this.lblRecipes.Text = "Receitas";
            // 
            // listViewRecipes
            // 
            this.listViewRecipes.AllowColumnReorder = true;
            this.listViewRecipes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmID,
            this.clmName,
            this.clmUsername,
            this.clmDate,
            this.clmCategory,
            this.clmFoodStyle,
            this.clmStatus});
            this.listViewRecipes.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listViewRecipes.FullRowSelect = true;
            this.listViewRecipes.GridLines = true;
            this.listViewRecipes.Location = new System.Drawing.Point(46, 147);
            this.listViewRecipes.MultiSelect = false;
            this.listViewRecipes.Name = "listViewRecipes";
            this.listViewRecipes.OwnerDraw = true;
            this.listViewRecipes.Size = new System.Drawing.Size(1154, 577);
            this.listViewRecipes.TabIndex = 22;
            this.listViewRecipes.UseCompatibleStateImageBehavior = false;
            this.listViewRecipes.View = System.Windows.Forms.View.Details;
            this.listViewRecipes.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListViewRecipes_DrawColumnHeader);
            this.listViewRecipes.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListViewRecipes_DrawItem);
            this.listViewRecipes.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListViewRecipes_DrawSubItem);
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            // 
            // clmName
            // 
            this.clmName.Text = "Nome Receita";
            this.clmName.Width = 300;
            // 
            // clmUsername
            // 
            this.clmUsername.Text = "Username";
            this.clmUsername.Width = 150;
            // 
            // clmDate
            // 
            this.clmDate.Text = "Data Criação";
            this.clmDate.Width = 175;
            // 
            // clmCategory
            // 
            this.clmCategory.Text = "Categoria";
            this.clmCategory.Width = 160;
            // 
            // clmFoodStyle
            // 
            this.clmFoodStyle.Text = "Género / Estilo";
            this.clmFoodStyle.Width = 160;
            // 
            // clmStatus
            // 
            this.clmStatus.Text = "Estado";
            this.clmStatus.Width = 160;
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(738, 98);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(150, 35);
            this.btnDetails.TabIndex = 20;
            this.btnDetails.Text = "Ver Detalhes";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // btnAproved
            // 
            this.btnAproved.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnAproved.FlatAppearance.BorderSize = 0;
            this.btnAproved.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnAproved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAproved.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAproved.ForeColor = System.Drawing.Color.White;
            this.btnAproved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAproved.Location = new System.Drawing.Point(894, 98);
            this.btnAproved.Name = "btnAproved";
            this.btnAproved.Size = new System.Drawing.Size(150, 35);
            this.btnAproved.TabIndex = 26;
            this.btnAproved.Text = "Aprovar";
            this.btnAproved.UseVisualStyleBackColor = true;
            this.btnAproved.Click += new System.EventHandler(this.BtnAproved_Click);
            // 
            // UserControlRecipes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.btnAproved);
            this.Controls.Add(this.btnNotApprove);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.lblRecipes);
            this.Controls.Add(this.listViewRecipes);
            this.Controls.Add(this.btnDetails);
            this.Name = "UserControlRecipes";
            this.Size = new System.Drawing.Size(1249, 756);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotApprove;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.RadioButton radioBtnPending;
        private System.Windows.Forms.RadioButton radioBtnAll;
        private System.Windows.Forms.RadioButton radioBtnNotApproved;
        private System.Windows.Forms.RadioButton radioBtnApproved;
        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListView listViewRecipes;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmUsername;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnAproved;
        private System.Windows.Forms.ColumnHeader clmCategory;
        private System.Windows.Forms.ColumnHeader clmStatus;
        private System.Windows.Forms.ColumnHeader clmDate;
        private System.Windows.Forms.ColumnHeader clmFoodStyle;
        private System.Windows.Forms.ColumnHeader clmID;
    }
}
