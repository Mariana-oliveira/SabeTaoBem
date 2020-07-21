namespace SabeTaoBem
{
    partial class frmRecipeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeDetail));
            this.lblRecipeNameTitle = new System.Windows.Forms.Label();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.listViewIngredients = new System.Windows.Forms.ListView();
            this.clmIngredient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmUnits = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblDetails = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.richTxtBoxDesciptrion = new System.Windows.Forms.RichTextBox();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblCategoryTitle = new System.Windows.Forms.Label();
            this.lblDifficultyLevel = new System.Windows.Forms.Label();
            this.lblDifficultyLevelTitle = new System.Windows.Forms.Label();
            this.lblCostOfMeal = new System.Windows.Forms.Label();
            this.lblCostOfMealTitle = new System.Windows.Forms.Label();
            this.lblCookTime = new System.Windows.Forms.Label();
            this.lblCookTimeTitle = new System.Windows.Forms.Label();
            this.lblPreparationTime = new System.Windows.Forms.Label();
            this.lblPreparationTimeTitle = new System.Windows.Forms.Label();
            this.lblFoodStyle = new System.Windows.Forms.Label();
            this.lblFoodStyleTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecipeNameTitle
            // 
            this.lblRecipeNameTitle.AutoSize = true;
            this.lblRecipeNameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblRecipeNameTitle.Location = new System.Drawing.Point(125, 86);
            this.lblRecipeNameTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblRecipeNameTitle.Name = "lblRecipeNameTitle";
            this.lblRecipeNameTitle.Size = new System.Drawing.Size(120, 26);
            this.lblRecipeNameTitle.TabIndex = 0;
            this.lblRecipeNameTitle.Text = "Nome Receita:";
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblIngredients.Location = new System.Drawing.Point(220, 280);
            this.lblIngredients.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(109, 26);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Ingredientes:";
            // 
            // listViewIngredients
            // 
            this.listViewIngredients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmIngredient,
            this.clmQuantity,
            this.clmUnits});
            this.listViewIngredients.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewIngredients.FullRowSelect = true;
            this.listViewIngredients.GridLines = true;
            this.listViewIngredients.Location = new System.Drawing.Point(225, 318);
            this.listViewIngredients.MultiSelect = false;
            this.listViewIngredients.Name = "listViewIngredients";
            this.listViewIngredients.OwnerDraw = true;
            this.listViewIngredients.Size = new System.Drawing.Size(604, 244);
            this.listViewIngredients.TabIndex = 3;
            this.listViewIngredients.UseCompatibleStateImageBehavior = false;
            this.listViewIngredients.View = System.Windows.Forms.View.Details;
            this.listViewIngredients.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.ListViewIngredients_DrawColumnHeader);
            this.listViewIngredients.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListViewIngredients_DrawItem);
            this.listViewIngredients.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.ListViewIngredients_DrawSubItem);
            // 
            // clmIngredient
            // 
            this.clmIngredient.Text = "Ingrediente";
            this.clmIngredient.Width = 200;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Text = "Quantidade";
            this.clmQuantity.Width = 200;
            // 
            // clmUnits
            // 
            this.clmUnits.Text = "Unidades";
            this.clmUnits.Width = 200;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblDescription.Location = new System.Drawing.Point(220, 574);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(209, 26);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Instruções de Preparação:";
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.Font = new System.Drawing.Font("Segoe Print", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.ForeColor = System.Drawing.Color.White;
            this.lblDetails.Location = new System.Drawing.Point(395, 9);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(207, 40);
            this.lblDetails.TabIndex = 15;
            this.lblDetails.Text = "Detalhes Receita";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1002, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 40);
            this.btnClose.TabIndex = 16;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // richTxtBoxDesciptrion
            // 
            this.richTxtBoxDesciptrion.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtBoxDesciptrion.Location = new System.Drawing.Point(221, 613);
            this.richTxtBoxDesciptrion.Name = "richTxtBoxDesciptrion";
            this.richTxtBoxDesciptrion.ReadOnly = true;
            this.richTxtBoxDesciptrion.Size = new System.Drawing.Size(604, 199);
            this.richTxtBoxDesciptrion.TabIndex = 19;
            this.richTxtBoxDesciptrion.Text = "";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.ForeColor = System.Drawing.Color.White;
            this.lblRecipeName.Location = new System.Drawing.Point(253, 88);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(0, 21);
            this.lblRecipeName.TabIndex = 20;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.White;
            this.lblCategory.Location = new System.Drawing.Point(253, 136);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(0, 20);
            this.lblCategory.TabIndex = 22;
            // 
            // lblCategoryTitle
            // 
            this.lblCategoryTitle.AutoSize = true;
            this.lblCategoryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblCategoryTitle.Location = new System.Drawing.Point(157, 133);
            this.lblCategoryTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCategoryTitle.Name = "lblCategoryTitle";
            this.lblCategoryTitle.Size = new System.Drawing.Size(88, 26);
            this.lblCategoryTitle.TabIndex = 21;
            this.lblCategoryTitle.Text = "Categoria:";
            // 
            // lblDifficultyLevel
            // 
            this.lblDifficultyLevel.AutoSize = true;
            this.lblDifficultyLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lblDifficultyLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifficultyLevel.ForeColor = System.Drawing.Color.White;
            this.lblDifficultyLevel.Location = new System.Drawing.Point(253, 186);
            this.lblDifficultyLevel.Name = "lblDifficultyLevel";
            this.lblDifficultyLevel.Size = new System.Drawing.Size(0, 20);
            this.lblDifficultyLevel.TabIndex = 24;
            // 
            // lblDifficultyLevelTitle
            // 
            this.lblDifficultyLevelTitle.AutoSize = true;
            this.lblDifficultyLevelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblDifficultyLevelTitle.Location = new System.Drawing.Point(77, 184);
            this.lblDifficultyLevelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDifficultyLevelTitle.Name = "lblDifficultyLevelTitle";
            this.lblDifficultyLevelTitle.Size = new System.Drawing.Size(168, 26);
            this.lblDifficultyLevelTitle.TabIndex = 23;
            this.lblDifficultyLevelTitle.Text = "Grau de Dificuldade:";
            // 
            // lblCostOfMeal
            // 
            this.lblCostOfMeal.AutoSize = true;
            this.lblCostOfMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lblCostOfMeal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostOfMeal.ForeColor = System.Drawing.Color.White;
            this.lblCostOfMeal.Location = new System.Drawing.Point(673, 187);
            this.lblCostOfMeal.Name = "lblCostOfMeal";
            this.lblCostOfMeal.Size = new System.Drawing.Size(0, 20);
            this.lblCostOfMeal.TabIndex = 26;
            // 
            // lblCostOfMealTitle
            // 
            this.lblCostOfMealTitle.AutoSize = true;
            this.lblCostOfMealTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblCostOfMealTitle.Location = new System.Drawing.Point(516, 184);
            this.lblCostOfMealTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCostOfMealTitle.Name = "lblCostOfMealTitle";
            this.lblCostOfMealTitle.Size = new System.Drawing.Size(149, 26);
            this.lblCostOfMealTitle.TabIndex = 25;
            this.lblCostOfMealTitle.Text = "Custo da Refeição:";
            // 
            // lblCookTime
            // 
            this.lblCookTime.AutoSize = true;
            this.lblCookTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lblCookTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCookTime.ForeColor = System.Drawing.Color.White;
            this.lblCookTime.Location = new System.Drawing.Point(673, 234);
            this.lblCookTime.Name = "lblCookTime";
            this.lblCookTime.Size = new System.Drawing.Size(0, 20);
            this.lblCookTime.TabIndex = 30;
            // 
            // lblCookTimeTitle
            // 
            this.lblCookTimeTitle.AutoSize = true;
            this.lblCookTimeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblCookTimeTitle.Location = new System.Drawing.Point(522, 231);
            this.lblCookTimeTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCookTimeTitle.Name = "lblCookTimeTitle";
            this.lblCookTimeTitle.Size = new System.Drawing.Size(143, 26);
            this.lblCookTimeTitle.TabIndex = 29;
            this.lblCookTimeTitle.Text = "Tempo Cozedura:";
            // 
            // lblPreparationTime
            // 
            this.lblPreparationTime.AutoSize = true;
            this.lblPreparationTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lblPreparationTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreparationTime.ForeColor = System.Drawing.Color.White;
            this.lblPreparationTime.Location = new System.Drawing.Point(253, 233);
            this.lblPreparationTime.Name = "lblPreparationTime";
            this.lblPreparationTime.Size = new System.Drawing.Size(0, 20);
            this.lblPreparationTime.TabIndex = 28;
            // 
            // lblPreparationTimeTitle
            // 
            this.lblPreparationTimeTitle.AutoSize = true;
            this.lblPreparationTimeTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblPreparationTimeTitle.Location = new System.Drawing.Point(84, 230);
            this.lblPreparationTimeTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPreparationTimeTitle.Name = "lblPreparationTimeTitle";
            this.lblPreparationTimeTitle.Size = new System.Drawing.Size(161, 26);
            this.lblPreparationTimeTitle.TabIndex = 27;
            this.lblPreparationTimeTitle.Text = "Tempo Preparação:";
            // 
            // lblFoodStyle
            // 
            this.lblFoodStyle.AutoSize = true;
            this.lblFoodStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.lblFoodStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodStyle.ForeColor = System.Drawing.Color.White;
            this.lblFoodStyle.Location = new System.Drawing.Point(673, 139);
            this.lblFoodStyle.Name = "lblFoodStyle";
            this.lblFoodStyle.Size = new System.Drawing.Size(0, 20);
            this.lblFoodStyle.TabIndex = 32;
            // 
            // lblFoodStyleTitle
            // 
            this.lblFoodStyleTitle.AutoSize = true;
            this.lblFoodStyleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(75)))));
            this.lblFoodStyleTitle.Location = new System.Drawing.Point(535, 136);
            this.lblFoodStyleTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblFoodStyleTitle.Name = "lblFoodStyleTitle";
            this.lblFoodStyleTitle.Size = new System.Drawing.Size(130, 26);
            this.lblFoodStyleTitle.TabIndex = 31;
            this.lblFoodStyleTitle.Text = "Género / Estilo:";
            // 
            // frmRecipeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1056, 824);
            this.Controls.Add(this.lblFoodStyle);
            this.Controls.Add(this.lblFoodStyleTitle);
            this.Controls.Add(this.lblCookTime);
            this.Controls.Add(this.lblCookTimeTitle);
            this.Controls.Add(this.lblPreparationTime);
            this.Controls.Add(this.lblPreparationTimeTitle);
            this.Controls.Add(this.lblCostOfMeal);
            this.Controls.Add(this.lblCostOfMealTitle);
            this.Controls.Add(this.lblDifficultyLevel);
            this.Controls.Add(this.lblDifficultyLevelTitle);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblCategoryTitle);
            this.Controls.Add(this.lblRecipeName);
            this.Controls.Add(this.richTxtBoxDesciptrion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.listViewIngredients);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lblRecipeNameTitle);
            this.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmRecipeDetail";
            this.Text = "Detalhes Receita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRecipeNameTitle;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.ListView listViewIngredients;
        private System.Windows.Forms.ColumnHeader clmIngredient;
        private System.Windows.Forms.ColumnHeader clmQuantity;
        private System.Windows.Forms.ColumnHeader clmUnits;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox richTxtBoxDesciptrion;
        private System.Windows.Forms.Label lblRecipeName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryTitle;
        private System.Windows.Forms.Label lblDifficultyLevel;
        private System.Windows.Forms.Label lblDifficultyLevelTitle;
        private System.Windows.Forms.Label lblCostOfMeal;
        private System.Windows.Forms.Label lblCostOfMealTitle;
        private System.Windows.Forms.Label lblCookTime;
        private System.Windows.Forms.Label lblCookTimeTitle;
        private System.Windows.Forms.Label lblPreparationTime;
        private System.Windows.Forms.Label lblPreparationTimeTitle;
        private System.Windows.Forms.Label lblFoodStyle;
        private System.Windows.Forms.Label lblFoodStyleTitle;
    }
}