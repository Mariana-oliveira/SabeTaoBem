namespace SabeTaoBem
{
    partial class UserControlUnits
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
            this.lblUnits = new System.Windows.Forms.Label();
            this.btnClean = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.listViewUnits = new System.Windows.Forms.ListView();
            this.clmName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmSystem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmbSystem = new System.Windows.Forms.ComboBox();
            this.lblSystem = new System.Windows.Forms.Label();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSystemSearch = new System.Windows.Forms.ComboBox();
            this.llblCategorySearch = new System.Windows.Forms.Label();
            this.cmbCategorySearch = new System.Windows.Forms.ComboBox();
            this.lblNameSearch = new System.Windows.Forms.Label();
            this.txtNameSearch = new System.Windows.Forms.TextBox();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.ForeColor = System.Drawing.Color.White;
            this.lblUnits.Location = new System.Drawing.Point(491, 25);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(251, 40);
            this.lblUnits.TabIndex = 15;
            this.lblUnits.Text = "Unidades de Medida";
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
            this.btnClean.Location = new System.Drawing.Point(1089, 322);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(95, 35);
            this.btnClean.TabIndex = 44;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(821, 329);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(236, 28);
            this.cmbCategory.TabIndex = 43;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblCategory.Location = new System.Drawing.Point(727, 329);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 26);
            this.lblCategory.TabIndex = 42;
            this.lblCategory.Text = "Categoria:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(821, 275);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 27);
            this.txtName.TabIndex = 41;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblName.Location = new System.Drawing.Point(687, 275);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(128, 26);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Nome Unidade:";
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
            this.btnAdd.Location = new System.Drawing.Point(660, 456);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.TabIndex = 39;
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
            this.btnUpdate.Location = new System.Drawing.Point(847, 456);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(150, 35);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // listViewUnits
            // 
            this.listViewUnits.AllowColumnReorder = true;
            this.listViewUnits.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmName,
            this.clmCategory,
            this.clmSystem});
            this.listViewUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.listViewUnits.FullRowSelect = true;
            this.listViewUnits.GridLines = true;
            this.listViewUnits.Location = new System.Drawing.Point(27, 191);
            this.listViewUnits.MultiSelect = false;
            this.listViewUnits.Name = "listViewUnits";
            this.listViewUnits.OwnerDraw = true;
            this.listViewUnits.Size = new System.Drawing.Size(602, 500);
            this.listViewUnits.TabIndex = 37;
            this.listViewUnits.UseCompatibleStateImageBehavior = false;
            this.listViewUnits.View = System.Windows.Forms.View.Details;
            this.listViewUnits.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListViewUnits_DrawColumnHeader);
            this.listViewUnits.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListViewUnits_DrawItem);
            this.listViewUnits.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListViewUnits_DrawSubItem);
            this.listViewUnits.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListViewUnits_MouseClick);
            // 
            // clmName
            // 
            this.clmName.Text = "Nome Unidade";
            this.clmName.Width = 175;
            // 
            // clmCategory
            // 
            this.clmCategory.Text = "Categoria";
            this.clmCategory.Width = 200;
            // 
            // clmSystem
            // 
            this.clmSystem.Text = "Sistema";
            this.clmSystem.Width = 220;
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
            this.btnRemove.Location = new System.Drawing.Point(1034, 456);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 35);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.BtnRemove_Click);
            // 
            // cmbSystem
            // 
            this.cmbSystem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSystem.FormattingEnabled = true;
            this.cmbSystem.Location = new System.Drawing.Point(821, 383);
            this.cmbSystem.Name = "cmbSystem";
            this.cmbSystem.Size = new System.Drawing.Size(236, 28);
            this.cmbSystem.TabIndex = 46;
            // 
            // lblSystem
            // 
            this.lblSystem.AutoSize = true;
            this.lblSystem.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblSystem.Location = new System.Drawing.Point(740, 383);
            this.lblSystem.Name = "lblSystem";
            this.lblSystem.Size = new System.Drawing.Size(75, 26);
            this.lblSystem.TabIndex = 45;
            this.lblSystem.Text = "Sistema:";
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.label1);
            this.groupBoxFiltro.Controls.Add(this.cmbSystemSearch);
            this.groupBoxFiltro.Controls.Add(this.llblCategorySearch);
            this.groupBoxFiltro.Controls.Add(this.cmbCategorySearch);
            this.groupBoxFiltro.Controls.Add(this.lblNameSearch);
            this.groupBoxFiltro.Controls.Add(this.txtNameSearch);
            this.groupBoxFiltro.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxFiltro.ForeColor = System.Drawing.Color.White;
            this.groupBoxFiltro.Location = new System.Drawing.Point(28, 88);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(601, 86);
            this.groupBoxFiltro.TabIndex = 47;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.label1.Location = new System.Drawing.Point(446, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 40;
            this.label1.Text = "Sistema:";
            // 
            // cmbSystemSearch
            // 
            this.cmbSystemSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSystemSearch.FormattingEnabled = true;
            this.cmbSystemSearch.Location = new System.Drawing.Point(379, 49);
            this.cmbSystemSearch.Name = "cmbSystemSearch";
            this.cmbSystemSearch.Size = new System.Drawing.Size(216, 28);
            this.cmbSystemSearch.TabIndex = 41;
            this.cmbSystemSearch.TextChanged += new System.EventHandler(this.CmbSystemSearch_TextChanged);
            // 
            // llblCategorySearch
            // 
            this.llblCategorySearch.AutoSize = true;
            this.llblCategorySearch.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblCategorySearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.llblCategorySearch.Location = new System.Drawing.Point(229, 20);
            this.llblCategorySearch.Name = "llblCategorySearch";
            this.llblCategorySearch.Size = new System.Drawing.Size(88, 26);
            this.llblCategorySearch.TabIndex = 38;
            this.llblCategorySearch.Text = "Categoria:";
            // 
            // cmbCategorySearch
            // 
            this.cmbCategorySearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategorySearch.FormattingEnabled = true;
            this.cmbCategorySearch.Location = new System.Drawing.Point(176, 49);
            this.cmbCategorySearch.Name = "cmbCategorySearch";
            this.cmbCategorySearch.Size = new System.Drawing.Size(197, 28);
            this.cmbCategorySearch.TabIndex = 39;
            this.cmbCategorySearch.TextChanged += new System.EventHandler(this.CmbCategorySearch_TextChanged);
            // 
            // lblNameSearch
            // 
            this.lblNameSearch.AutoSize = true;
            this.lblNameSearch.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblNameSearch.Location = new System.Drawing.Point(14, 20);
            this.lblNameSearch.Name = "lblNameSearch";
            this.lblNameSearch.Size = new System.Drawing.Size(152, 26);
            this.lblNameSearch.TabIndex = 36;
            this.lblNameSearch.Text = "Nome Ingrediente:";
            // 
            // txtNameSearch
            // 
            this.txtNameSearch.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameSearch.Location = new System.Drawing.Point(6, 50);
            this.txtNameSearch.Name = "txtNameSearch";
            this.txtNameSearch.Size = new System.Drawing.Size(164, 27);
            this.txtNameSearch.TabIndex = 37;
            this.txtNameSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // lblSystemSearch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.cmbSystem);
            this.Controls.Add(this.lblSystem);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listViewUnits);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblUnits);
            this.Name = "lblSystemSearch";
            this.Size = new System.Drawing.Size(1249, 756);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ListView listViewUnits;
        private System.Windows.Forms.ColumnHeader clmName;
        private System.Windows.Forms.ColumnHeader clmCategory;
        private System.Windows.Forms.ColumnHeader clmSystem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ComboBox cmbSystem;
        private System.Windows.Forms.Label lblSystem;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.Label llblCategorySearch;
        private System.Windows.Forms.ComboBox cmbCategorySearch;
        private System.Windows.Forms.Label lblNameSearch;
        private System.Windows.Forms.TextBox txtNameSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSystemSearch;
    }
}
