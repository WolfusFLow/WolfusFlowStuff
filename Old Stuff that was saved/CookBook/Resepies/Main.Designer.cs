namespace Resepies
{
    partial class Main
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
            this.listRecipes = new System.Windows.Forms.ListBox();
            this.Recipelable = new System.Windows.Forms.Label();
            this.Ingredientslabel = new System.Windows.Forms.Label();
            this.listIngredient = new System.Windows.Forms.ListBox();
            this.textRecipeName = new System.Windows.Forms.TextBox();
            this.AddRecipe = new System.Windows.Forms.Button();
            this.btmUpdateName = new System.Windows.Forms.Button();
            this.labelAllIngredients = new System.Windows.Forms.Label();
            this.listAllIngredients = new System.Windows.Forms.ListBox();
            this.buttonAddToRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(12, 117);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(120, 134);
            this.listRecipes.TabIndex = 0;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // Recipelable
            // 
            this.Recipelable.AutoSize = true;
            this.Recipelable.Location = new System.Drawing.Point(12, 86);
            this.Recipelable.Name = "Recipelable";
            this.Recipelable.Size = new System.Drawing.Size(46, 13);
            this.Recipelable.TabIndex = 1;
            this.Recipelable.Text = "Recipes";
            // 
            // Ingredientslabel
            // 
            this.Ingredientslabel.AutoSize = true;
            this.Ingredientslabel.Location = new System.Drawing.Point(135, 86);
            this.Ingredientslabel.Name = "Ingredientslabel";
            this.Ingredientslabel.Size = new System.Drawing.Size(59, 13);
            this.Ingredientslabel.TabIndex = 3;
            this.Ingredientslabel.Text = "Ingredients";
            // 
            // listIngredient
            // 
            this.listIngredient.FormattingEnabled = true;
            this.listIngredient.Location = new System.Drawing.Point(138, 117);
            this.listIngredient.Name = "listIngredient";
            this.listIngredient.Size = new System.Drawing.Size(120, 134);
            this.listIngredient.TabIndex = 2;
            // 
            // textRecipeName
            // 
            this.textRecipeName.Location = new System.Drawing.Point(12, 12);
            this.textRecipeName.Name = "textRecipeName";
            this.textRecipeName.Size = new System.Drawing.Size(200, 20);
            this.textRecipeName.TabIndex = 4;
            // 
            // AddRecipe
            // 
            this.AddRecipe.Location = new System.Drawing.Point(12, 38);
            this.AddRecipe.Name = "AddRecipe";
            this.AddRecipe.Size = new System.Drawing.Size(75, 23);
            this.AddRecipe.TabIndex = 5;
            this.AddRecipe.Text = "Add Recipe";
            this.AddRecipe.UseVisualStyleBackColor = true;
            this.AddRecipe.Click += new System.EventHandler(this.AddRecipe_Click);
            // 
            // btmUpdateName
            // 
            this.btmUpdateName.Location = new System.Drawing.Point(116, 38);
            this.btmUpdateName.Name = "btmUpdateName";
            this.btmUpdateName.Size = new System.Drawing.Size(96, 23);
            this.btmUpdateName.TabIndex = 7;
            this.btmUpdateName.Text = "Update Name";
            this.btmUpdateName.UseVisualStyleBackColor = true;
            this.btmUpdateName.Click += new System.EventHandler(this.btmUpdateName_Click);
            // 
            // labelAllIngredients
            // 
            this.labelAllIngredients.AutoSize = true;
            this.labelAllIngredients.Location = new System.Drawing.Point(261, 86);
            this.labelAllIngredients.Name = "labelAllIngredients";
            this.labelAllIngredients.Size = new System.Drawing.Size(73, 13);
            this.labelAllIngredients.TabIndex = 9;
            this.labelAllIngredients.Text = "All Ingredients";
            // 
            // listAllIngredients
            // 
            this.listAllIngredients.FormattingEnabled = true;
            this.listAllIngredients.Location = new System.Drawing.Point(264, 117);
            this.listAllIngredients.Name = "listAllIngredients";
            this.listAllIngredients.Size = new System.Drawing.Size(120, 134);
            this.listAllIngredients.TabIndex = 8;
            this.listAllIngredients.SelectedIndexChanged += new System.EventHandler(this.listAllIngredients_SelectedIndexChanged);
            // 
            // buttonAddToRecipe
            // 
            this.buttonAddToRecipe.Location = new System.Drawing.Point(292, 257);
            this.buttonAddToRecipe.Name = "buttonAddToRecipe";
            this.buttonAddToRecipe.Size = new System.Drawing.Size(92, 23);
            this.buttonAddToRecipe.TabIndex = 10;
            this.buttonAddToRecipe.Text = "Add To Recipe";
            this.buttonAddToRecipe.UseVisualStyleBackColor = true;
            this.buttonAddToRecipe.Click += new System.EventHandler(this.buttonAddToRecipe_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.ClientSize = new System.Drawing.Size(410, 297);
            this.Controls.Add(this.buttonAddToRecipe);
            this.Controls.Add(this.labelAllIngredients);
            this.Controls.Add(this.listAllIngredients);
            this.Controls.Add(this.btmUpdateName);
            this.Controls.Add(this.AddRecipe);
            this.Controls.Add(this.textRecipeName);
            this.Controls.Add(this.Ingredientslabel);
            this.Controls.Add(this.listIngredient);
            this.Controls.Add(this.Recipelable);
            this.Controls.Add(this.listRecipes);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRecipes;
        private System.Windows.Forms.Label Recipelable;
        private System.Windows.Forms.Label Ingredientslabel;
        private System.Windows.Forms.ListBox listIngredient;
        private System.Windows.Forms.TextBox textRecipeName;
        private System.Windows.Forms.Button AddRecipe;
        private System.Windows.Forms.Button btmUpdateName;
        private System.Windows.Forms.Label labelAllIngredients;
        private System.Windows.Forms.ListBox listAllIngredients;
        private System.Windows.Forms.Button buttonAddToRecipe;
    }
}