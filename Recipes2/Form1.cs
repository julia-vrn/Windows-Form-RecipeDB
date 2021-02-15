using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Recipes2
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Recipes2.Properties.Settings.Database1ConnectionString"].ConnectionString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            PopulateAllIngredients();
          
        }

        private void PopulateRecipes()
        {
            using(connection = new SqlConnection(connectionString))
            using(SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM RECIPE", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                listRecipes.DisplayMember = "Name";
                listRecipes.ValueMember = "Id";
                listRecipes.DataSource = recipeTable;
            }
       
        }

        private void PopulateAllIngredients()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Ingredient", connection))
            {
                DataTable ingredientsTable = new DataTable();
                adapter.Fill(ingredientsTable);

                listAllIngredients.DisplayMember = "Name";
                listAllIngredients.ValueMember = "Id";
                listAllIngredients.DataSource = ingredientsTable;
            }

        }


        private void PopulateIngredient()
        {
            string query = "SELECT a.Name FROM Ingredient a INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId WHERE b.RecipeId = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                listIngredients.DisplayMember = "Name";
                listIngredients.ValueMember = "Id";
                listIngredients.DataSource = ingredientTable;
            }

        }

        private void listIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredient();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@RecipeName, 80)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.ExecuteNonQuery();
              
            }

            PopulateRecipes();
        }

        private void btnUpdateRecipeName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET NAME = @RecipeName WHERE Id = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                command.ExecuteNonQuery();

            }

            PopulateRecipes();
        }

        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngredient VALUES (@RecipeId, @IngredientId)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listAllIngredients.SelectedValue);
                command.ExecuteNonQuery();

            }

            PopulateRecipes();
        }
    }
}
