
namespace Recipes2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.listRecipes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listIngredients = new System.Windows.Forms.ListBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnUpdateRecipeName = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listAllIngredients = new System.Windows.Forms.ListBox();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipes";
            // 
            // listRecipes
            // 
            this.listRecipes.FormattingEnabled = true;
            this.listRecipes.Location = new System.Drawing.Point(48, 92);
            this.listRecipes.Name = "listRecipes";
            this.listRecipes.Size = new System.Drawing.Size(120, 95);
            this.listRecipes.TabIndex = 1;
            this.listRecipes.SelectedIndexChanged += new System.EventHandler(this.listRecipes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingredients";
            // 
            // listIngredients
            // 
            this.listIngredients.FormattingEnabled = true;
            this.listIngredients.Location = new System.Drawing.Point(257, 92);
            this.listIngredients.Name = "listIngredients";
            this.listIngredients.Size = new System.Drawing.Size(120, 95);
            this.listIngredients.TabIndex = 3;
            this.listIngredients.SelectedIndexChanged += new System.EventHandler(this.listIngredients_SelectedIndexChanged);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(462, 92);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(218, 20);
            this.txtRecipeName.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add Recipe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdateRecipeName
            // 
            this.btnUpdateRecipeName.Location = new System.Drawing.Point(575, 129);
            this.btnUpdateRecipeName.Name = "btnUpdateRecipeName";
            this.btnUpdateRecipeName.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateRecipeName.TabIndex = 6;
            this.btnUpdateRecipeName.Text = "Update Recipe";
            this.btnUpdateRecipeName.UseVisualStyleBackColor = true;
            this.btnUpdateRecipeName.Click += new System.EventHandler(this.btnUpdateRecipeName_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "All Ingredients";
            // 
            // listAllIngredients
            // 
            this.listAllIngredients.FormattingEnabled = true;
            this.listAllIngredients.Location = new System.Drawing.Point(462, 232);
            this.listAllIngredients.Name = "listAllIngredients";
            this.listAllIngredients.Size = new System.Drawing.Size(218, 186);
            this.listAllIngredients.TabIndex = 9;
            // 
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Location = new System.Drawing.Point(462, 439);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddToRecipe.TabIndex = 10;
            this.btnAddToRecipe.Text = "Add To Recipe";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            this.btnAddToRecipe.Click += new System.EventHandler(this.btnAddToRecipe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.listAllIngredients);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdateRecipeName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.listIngredients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listRecipes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listRecipes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listIngredients;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnUpdateRecipeName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listAllIngredients;
        private System.Windows.Forms.Button btnAddToRecipe;
    }
}

