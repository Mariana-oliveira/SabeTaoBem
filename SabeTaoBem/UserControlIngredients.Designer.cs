namespace SabeTaoBem
{
    partial class UserControlIngredients
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
            this.lbIngredients = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listViewIngredients = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnClean = new System.Windows.Forms.Button();
            this.cmbCategorySearch = new System.Windows.Forms.ComboBox();
            this.llblCategorySearch = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIngredients
            // 
            this.lbIngredients.AutoSize = true;
            this.lbIngredients.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngredients.ForeColor = System.Drawing.Color.White;
            this.lbIngredients.Location = new System.Drawing.Point(539, 25);
            this.lbIngredients.Name = "lbIngredients";
            this.lbIngredients.Size = new System.Drawing.Size(158, 40);
            this.lbIngredients.TabIndex = 16;
            this.lbIngredients.Text = "Ingredientes";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(660, 429);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 30;
            this.btnAdd.Text = "Criar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(847, 429);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 35);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // listViewIngredients
            // 
            this.listViewIngredients.AllowColumnReorder = true;
            this.listViewIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmCategory});
            this.listViewIngredients.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listViewIngredients.FullRowSelect = true;
            this.listViewIngredients.GridLines = true;
            this.listViewIngredients.Location = new System.Drawing.Point(27, 191);
            this.listViewIngredients.MultiSelect = false;
            this.listViewIngredients.Name = "listViewIngredients";
            this.listViewIngredients.OwnerDraw = true;
            this.listViewIngredients.Size = new System.Drawing.Size(602, 500);
            this.listViewIngredients.TabIndex = 28;
            this.listViewIngredients.UseCompatibleStateImageBehavior = false;
            this.listViewIngredients.View = System.Windows.Forms.View.Details;
            this.listViewIngredients.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListViewIngredients_DrawColumnHeader);
            this.listViewIngredients.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListViewIngredients_DrawItem);
            this.listViewIngredients.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListViewIngredients_DrawSubItem);
            this.listViewIngredients.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewIngredients_MouseClick);
            // 
            // clmName
            // 
            this.clmName.Text = "Nome Ingrediente";
            this.clmName.Width = 295;
            // 
            // clmCategory
            // 
            this.clmCategory.Text = "Categoria";
            this.clmCategory.Width = 300;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(1034, 429);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 35);
            this.btnRemove.TabIndex = 27;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblName.Location = new System.Drawing.Point(664, 329);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(152, 26);
            this.lblName.TabIndex = 31;
            this.lblName.Text = "Nome Ingrediente:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(822, 329);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 27);
            this.txtName.TabIndex = 32;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblCategory.Location = new System.Drawing.Point(728, 383);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 26);
            this.lblCategory.TabIndex = 33;
            this.lblCategory.Text = "Categoria:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(822, 383);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(236, 28);
            this.cmbCategory.TabIndex = 34;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.btnClean.FlatAppearance.BorderSize = 0;
            this.btnClean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(224)))), ((int)(((byte)(66)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClean.Location = new System.Drawing.Point(1073, 350);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(95, 35);
            this.btnClean.TabIndex = 35;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // cmbCategorySearch
            // 
            this.cmbCategorySearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorySearch.FormattingEnabled = true;
            this.cmbCategorySearch.Location = new System.Drawing.Point(299, 49);
            this.cmbCategorySearch.Name = "cmbCategorySearch";
            this.cmbCategorySearch.Size = new System.Drawing.Size(296, 28);
            this.cmbCategorySearch.TabIndex = 39;
            this.cmbCategorySearch.TextChanged += new System.EventHandler(this.CmbCategorySearch_TextChanged);
            // 
            // llblCategorySearch
            // 
            this.llblCategorySearch.AutoSize = true;
            this.llblCategorySearch.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCategorySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.llblCategorySearch.Location = new System.Drawing.Point(403, 20);
            this.llblCategorySearch.Name = "llblCategorySearch";
            this.llblCategorySearch.Size = new System.Drawing.Size(88, 26);
            this.llblCategorySearch.TabIndex = 38;
            this.llblCategorySearch.Text = "Categoria:";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(6, 50);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(287, 27);
            this.txtNameSearch.TabIndex = 37;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblNameSearch.Location = new System.Drawing.Point(75, 20);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(152, 26);
            this.lblNameSearch.TabIndex = 36;
            this.lblNameSearch.Text = "Nome Ingrediente:";
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.llblCategorySearch);
            this.groupBoxFiltro.Controls.Add(this.cmbCategorySearch);
            this.groupBoxFiltro.Controls.Add(this.lblNameSearch);
            this.groupBoxFiltro.Controls.Add(this.txtNameSearch);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.ForeColor = System.Drawing.Color.White;
            this.groupBoxFiltro.Location = new System.Drawing.Point(28, 88);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(601, 86);
            this.groupBoxFiltro.TabIndex = 40;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro";
            // 
            // UserControlIngredients
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.listViewIngredients);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbIngredients);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cmbCategory);
            this.Name = "UserControlIngredients";
            this.Size = new System.Drawing.Size(1249, 756);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIngredients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listViewIngredients;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ColumnHeader clmCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox cmbCategorySearch;
        private System.Windows.Forms.Label llblCategorySearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
    }
}
