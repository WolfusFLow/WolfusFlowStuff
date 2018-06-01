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

namespace Resepies
{
    public partial class Main : Form
    {
        SqlConnection Connection;
        string connectionString;

        public Main()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["Resepies.Properties.Settings.Database1ConnectionString"].ConnectionString;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            PopulateRecipes();
            PopulateAllIngredients();
            
        }

        private void PopulateRecipes()
            {
                using (Connection = new SqlConnection(connectionString))
                using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Recipe", Connection))
                {
                    DataTable recipeTable = new DataTable();
                    Adapter.Fill(recipeTable);

                    listRecipes.DisplayMember = "Name";
                    listRecipes.ValueMember = "Id";
                    listRecipes.DataSource = recipeTable;

                }

            }



        private void PopulateAllIngredients()
        {
            using (Connection = new SqlConnection(connectionString))
            using (SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * FROM Ingredient", Connection))
            {
                DataTable ingredientTable = new DataTable();
                Adapter.Fill(ingredientTable);

                listAllIngredients.DisplayMember = "Name";
                listAllIngredients.ValueMember = "Id";
                listAllIngredients.DataSource = ingredientTable;

            }

        }


        private void PopulateIngredients()
        {
            string query = "SELECT a.Name FROM Ingredient a " +
                "Inner join RecipeIngredient b ON a.Id = b.IngredientId " +
                "Where b.RecipeId = @RecipeId";
            //@ = каждый раз как мы запускаем query мы проходим это действие


            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand (query, Connection))
            using (SqlDataAdapter Adapter = new SqlDataAdapter(command))
            {

                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);

                DataTable IngredietnTable = new DataTable();
                Adapter.Fill(IngredietnTable);

                listIngredient.DisplayMember = "Name";
                listIngredient.ValueMember = "Id";
                listIngredient.DataSource = IngredietnTable;

            }

        }



        private void listRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateIngredients();

            //MessageBox.Show(listRecipes.SelectedValue.ToString());
        }

        private void AddRecipe_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO Recipe Values (@RecipeName, 80, 'bla-bla')";

            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, Connection)) 
            {
                Connection.Open();           
                command.Parameters.AddWithValue("@RecipeName", textRecipeName.Text);

                command.ExecuteScalar();

            }
            PopulateRecipes();
        }

        private void btmUpdateName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName Where id = @RecipeId";

            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@RecipeName", textRecipeName.Text);
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);

                command.ExecuteScalar();

            }
            PopulateRecipes();
        }

         
        private void listAllIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngredient Values (@RecipeId, @IngredientId)";

            using (Connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, Connection))
            {
                Connection.Open();
                command.Parameters.AddWithValue("@RecipeId", listRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", listAllIngredients.SelectedValue);

                command.ExecuteScalar();

            }
            PopulateRecipes();
        }
    }
    }

