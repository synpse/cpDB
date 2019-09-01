using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Pombos.Classes
{
    public class Pombo
    {
        public int PomboID { get; set; }
        public int Number { get; set; }
        public string Name { get; set; }
        public string Date { get; set; }
        public string Gender { get; set; }
        public int DadNumber { get; set; }
        public int MomNumber { get; set; }
        public string State { get; set; }
        public string Notes { get; set; }
        public byte[] Image { get; set; }

        static readonly string myConStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;

        public bool DBIntegrityCheck()
        {
            List<bool> columns = new List<bool>
            {
                ContainColumn("ID"),
                ContainColumn("Número"),
                ContainColumn("Nome"),
                ContainColumn("Data"),
                ContainColumn("Género"),
                ContainColumn("NúmeroPai"),
                ContainColumn("NúmeroMãe"),
                ContainColumn("Estado"),
                ContainColumn("Notas"),
                ContainColumn("Imagem"),
                //ContainColumn("TEST")
            };

            if (columns.Contains(false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool ContainColumn(string columnName)
        {
            // Database connection
            SQLiteConnection connection = new SQLiteConnection(myConStr);
            DataTable dataTable = new DataTable();

            // Avoid wrecking havoc by using try-catch
            try
            {
                // Write SQL Query
                string sql = "SELECT * FROM TablePombos";
                // Create CMD using SQL and connection
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                // Create SQL data adapter using CMD
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            DataColumnCollection columns = dataTable.Columns;
            if (columns.Contains(columnName))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Select data from DB
        public DataTable Select()
        {
            // Database connection
            SQLiteConnection connection = new SQLiteConnection(myConStr);
            DataTable dataTable = new DataTable();

            // Avoid wrecking havoc by using try-catch
            try
            {
                // Write SQL Query
                string sql = "SELECT * FROM TablePombos";
                // Create CMD using SQL and connection
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                // Create SQL data adapter using CMD
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dataTable);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }

        // Insert data into DB
        public bool Insert(Pombo p)
        {
            // Create default return type and set its value to false
            bool isSuccessful = false;

            // Connect DB
            SQLiteConnection connection = new SQLiteConnection(myConStr);
            try
            {
                // Create SQL Query to insert data
                string sql = "INSERT INTO TablePombos (Número, Nome, Data, Género, NúmeroPai, NúmeroMãe, Estado, Notas, Imagem) VALUES (@Número, @Nome, @Data, @Género, @NúmeroPai, @NúmeroMãe, @Estado, @Notas, @Imagem)";
                // Create SQL command using SQL and connection
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                // Create parameters to add data
                cmd.Parameters.AddWithValue("@Número", p.Number);
                cmd.Parameters.AddWithValue("@Nome", p.Name);
                cmd.Parameters.AddWithValue("@Data", p.Date);
                cmd.Parameters.AddWithValue("@Género", p.Gender);
                cmd.Parameters.AddWithValue("@NúmeroPai", p.DadNumber);
                cmd.Parameters.AddWithValue("@NúmeroMãe", p.MomNumber);
                cmd.Parameters.AddWithValue("@Estado", p.State);
                cmd.Parameters.AddWithValue("@Notas", p.Notes);
                cmd.Parameters.AddWithValue("@Imagem", p.Image);

                // Connection open
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                // If the Query runs successfully then the value of rows will be greater than zero, else its value is zero
                if (rows > 0)
                {
                    // Success
                    isSuccessful = true;
                }
                else
                {
                    // Error
                    isSuccessful = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return isSuccessful;
        }

        // Method to update data in DB from our application
        public bool Update(Pombo p)
        {
            // Create default return type and set its value to false
            bool isSuccessful = false;

            // Connect DB
            SQLiteConnection connection = new SQLiteConnection(myConStr);
            try
            {
                // SQL to update data in our DB
                string sql = "UPDATE TablePombos SET Número=@Número, Nome=@Nome, Data=@Data, Género=@Género, NúmeroPai=@NúmeroPai, NúmeroMãe=@NúmeroMãe, Estado=@Estado, Imagem=@Imagem WHERE ID=@ID";

                // Create SQL command using SQL and connection
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                // Create parameters to add data
                cmd.Parameters.AddWithValue("@Número", p.Number);
                cmd.Parameters.AddWithValue("@Nome", p.Name);
                cmd.Parameters.AddWithValue("@Data", p.Date);
                cmd.Parameters.AddWithValue("@Género", p.Gender);
                cmd.Parameters.AddWithValue("@NúmeroPai", p.DadNumber);
                cmd.Parameters.AddWithValue("@NúmeroMãe", p.MomNumber);
                cmd.Parameters.AddWithValue("@Estado", p.State);
                cmd.Parameters.AddWithValue("@Imagem", p.Image);
                cmd.Parameters.AddWithValue("ID", p.PomboID);

                // Connection open
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                // If the Query runs successfully then the value of rows will be greater than zero, else its value is zero
                if (rows > 0)
                {
                    // Success
                    isSuccessful = true;
                }
                else
                {
                    // Error
                    isSuccessful = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return isSuccessful;
        }

        // Method to update data in DB from our application
        public bool UpdateNotes(Pombo p)
        {
            // Create default return type and set its value to false
            bool isSuccessful = false;

            // Connect DB
            SQLiteConnection connection = new SQLiteConnection(myConStr);
            try
            {
                // SQL to update data in our DB
                string sql = "UPDATE TablePombos SET Estado=@Estado, Notas=@Notas WHERE ID=@ID";

                // Create SQL command using SQL and connection
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                // Create parameters to add data
                cmd.Parameters.AddWithValue("@Estado", p.State);
                cmd.Parameters.AddWithValue("@Notas", p.Notes);
                cmd.Parameters.AddWithValue("ID", p.PomboID);

                // Connection open
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                // If the Query runs successfully then the value of rows will be greater than zero, else its value is zero
                if (rows > 0)
                {
                    // Success
                    isSuccessful = true;
                }
                else
                {
                    // Error
                    isSuccessful = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return isSuccessful;
        }

        // Method to delete data in DB from our application
        public bool Delete(Pombo p)
        {
            // Create default return type and set its value to false
            bool isSuccessful = false;

            // Connect DB
            SQLiteConnection connection = new SQLiteConnection(myConStr);
            try
            {
                // SQL to delete data in our DB
                string sql = "DELETE FROM TablePombos WHERE ID=@ID";

                // Create SQL command using SQL and connection
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                // Create parameters to add data
                cmd.Parameters.AddWithValue("@ID", p.PomboID);

                // Connection open
                connection.Open();
                int rows = cmd.ExecuteNonQuery();
                // If the Query runs successfully then the value of rows will be greater than zero, else its value is zero
                if (rows > 0)
                {
                    // Success
                    isSuccessful = true;
                }
                else
                {
                    // Error
                    isSuccessful = false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }
            return isSuccessful;
        }

        // Method to search DB for Number or Name keyword and create a new datatable with search results
        public DataTable Search(string keyword)
        {
            // Database connection
            SQLiteConnection connection = new SQLiteConnection(myConStr);
            DataTable dataTable = new DataTable();

            // Avoid wrecking havoc by using try-catch
            try
            {
                // Write SQL Query
                string sql = "SELECT * FROM TablePombos WHERE Número LIKE '%"+keyword+"%' OR Nome LIKE '%"+keyword+"%'";
                // Create CMD using SQL and connection
                SQLiteCommand cmd = new SQLiteCommand(sql, connection);
                // Create SQL data adapter using CMD
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                connection.Open();
                adapter.Fill(dataTable);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
    }
}
