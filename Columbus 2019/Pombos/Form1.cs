using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Pombos.Classes;

namespace Columbus2019
{
    public partial class Form1 : Form
    {
        // Instances
        Pombo p = new Pombo();

        // Variables
        private string lastID;
        private string imgLocation;

        // Start
        public Form1()
        {
            // Check for DB integrity
            if (p.DBIntegrityCheck() == false)
            {
                MessageBox.Show("Base de dados danificada!\n O programa irá fechar...");
                Environment.Exit(0);
            }
            else
            {
                // Initialize
                InitializeComponent();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load data on GridView
            RefreshGrid();

            Grid.Columns[0].SortMode = DataGridViewColumnSortMode.Programmatic;

            // Hide ID
            Grid.Columns[0].Visible = false;
            Grid.Columns[8].Visible = false;

            // Sort
            Grid.Sort(Grid.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        // Add button
        private void Add_Click(object sender, EventArgs e)
        {
            // Get values from input fields
            // Number
            bool convN1 = int.TryParse(txtNumber.Text, out int result);

            if (convN1 == true)
            {
                p.Number = result;
            }
            else
            {
                MessageBox.Show("O campo de número apenas aceita números! Tente novamente.\n" +
                    "Caso o pombo não tenha um número identificador insira 0.");
                return;
            }

            // Name
            p.Name = txtName.Text;

            // Date
            p.Date = txtDate.Text;

            // Gender
            p.Gender = txtGender.Text;

            // Dad Number
            bool convN2 = int.TryParse(txtDad.Text, out result);
            if (convN2 == true)
            {
                p.DadNumber = result;
            }
            else
            {
                MessageBox.Show("O campo de progenitor apenas aceita números! Tente novamente.\n" +
                    "Caso o pombo não tenha um número identificador insira 0.");
                return;
            }

            // Mom Number
            bool convN3 = int.TryParse(txtMom.Text, out result);
            if (convN3 == true)
            {
                p.MomNumber = result;
            }
            else
            {
                MessageBox.Show("O campo de progenitora apenas aceita números! Tente novamente.\n" +
                    "Caso o pombo não tenha um número identificador insira 0.");
                return;
            }

            // State
            p.State = txtState.Text;

            // State
            p.Notes = txtState.Text;

            // Image
            p.Image = null;

            if (imgLocation != null)
            {
                FileStream fileStream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                p.Image = binaryReader.ReadBytes((int)fileStream.Length);
            }

            // Insert data into DB
            bool successful = p.Insert(p);
            if (successful == true)
            {
                MessageBox.Show("Pombo registado com sucesso!");
                // Clear
                Clear();
            }
            else
            {
                MessageBox.Show("Erro a registar pombo! Tente novamente.");
                return;
            }

            // Load data on GridView
            RefreshGrid();

            // Sort
            Grid.Sort(Grid.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        // Update button
        private void Update_Click(object sender, EventArgs e)
        {
            // Get values from input fields

            // ID
            bool convN0 = int.TryParse(lastID, out int result);

            if (convN0 == true)
            {
                p.PomboID = result;
            }
            else
            {
                MessageBox.Show("ID Inválido!");
                return;
            }

            // Number
            bool convN1 = int.TryParse(txtNumber.Text, out result);

            if (convN1 == true)
            {
                p.Number = result;
            }
            else
            {
                MessageBox.Show("O campo de número apenas aceita números! Tente novamente.\n" +
                    "Caso o pombo não tenha um número identificador insira 0.");
                return;
            }

            // Name
            p.Name = txtName.Text;

            // Date
            p.Date = txtDate.Text;

            // Gender
            p.Gender = txtGender.Text;

            // Dad Number
            bool convN2 = int.TryParse(txtDad.Text, out result);
            if (convN2 == true)
            {
                p.DadNumber = result;
            }
            else
            {
                MessageBox.Show("O campo de progenitor apenas aceita números! Tente novamente.\n" +
                    "Caso o pombo não tenha um número identificador insira 0.");
                return;
            }

            // Mom Number
            bool convN3 = int.TryParse(txtMom.Text, out result);
            if (convN3 == true)
            {
                p.MomNumber = result;
            }
            else
            {
                MessageBox.Show("O campo de progenitora apenas aceita números! Tente novamente.\n" +
                    "Caso o pombo não tenha um número identificador insira 0.");
                return;
            }

            // State
            p.State = txtState.Text;

            // Image
            p.Image = null;

            if (imgLocation != null)
            {
                FileStream fileStream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binaryReader = new BinaryReader(fileStream);
                p.Image = binaryReader.ReadBytes((int)fileStream.Length);
            }

            // Update data into DB
            bool successful = p.Update(p);
            if (successful == true)
            {
                MessageBox.Show("Pombo atualizado com sucesso!");
                // Clear
                Clear();
            }
            else
            {
                MessageBox.Show("Erro ao atualizar pombo! Tente novamente.");
                return;
            }

            // Load data on GridView
            RefreshGrid();

            // Sort
            Grid.Sort(Grid.Columns[0], System.ComponentModel.ListSortDirection.Descending);
        }

        // Delete button
        private void Delete_Click(object sender, EventArgs e)
        {
            // Delete with lastID
            // Get ID
            bool convN0 = int.TryParse(lastID, out int result);

            if (convN0 == true)
            {
                p.PomboID = result;
            }
            else
            {
                MessageBox.Show("ID Inválido!");
                return;
            }
            //Delete data from DB
            bool successful = p.Delete(p);
            if (successful == true)
            {
                MessageBox.Show("Pombo apagado com sucesso!");
                Clear();
            }
            else
            {
                MessageBox.Show("Erro ao apagar pombo! Tente novamente.");
                return;
            }

            // Load data on GridView
            RefreshGrid();
        }

        // Get data from grid to text boxes on mouse click
        private void Grid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Clear
            Clear();

            // Identify row of mouse click
            int row = e.RowIndex;

            // Store ID
            lastID = Grid.Rows[row].Cells[0].Value.ToString();

            // Assign respectively
            txtNumber.Text = Grid.Rows[row].Cells[1].Value.ToString();
            txtName.Text = Grid.Rows[row].Cells[2].Value.ToString();
            txtDate.Text = Grid.Rows[row].Cells[3].Value.ToString();
            txtGender.Text = Grid.Rows[row].Cells[4].Value.ToString();
            txtDad.Text = Grid.Rows[row].Cells[5].Value.ToString();
            txtMom.Text = Grid.Rows[row].Cells[6].Value.ToString();
            txtState.Text = Grid.Rows[row].Cells[7].Value.ToString();
            // Image decoding
            byte[] imgData = null;
            if (Grid.Rows[row].Cells[9].Value != DBNull.Value &&
                (imgData = (byte[])Grid.Rows[row].Cells[9].Value) != null && 
                imgData.Length > 0)
            {
                imgData = (byte[])Grid.Rows[row].Cells[9].Value;

                using (MemoryStream memoryStream = new MemoryStream(imgData, 0, imgData.Length))
                {
                    memoryStream.Write(imgData, 0, imgData.Length);

                    pictureBox1.Image = Image.FromStream(memoryStream, true);
                }
            }
        }

        // Select row and show profile
        private void Grid_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Identify row of mouse click
            int row = e.RowIndex;

            // Get form2 instance
            Form2 form2 = new Form2();

            // Load profile
            form2.LoadProfile(Grid, row);

            // Show details window
            form2.ShowDialog();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Get value from the box
            string keyword = SearchBox.Text;
            // Search with keyword
            Grid.DataSource = p.Search(keyword);
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void txtDad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        private void txtMom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check for a naughty character in the KeyDown event.
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Stop the character from being entered into the control since it is illegal.
                e.Handled = true;
            }
        }

        // Clears input text
        public void Clear()
        {
            txtNumber.Text = "";
            txtName.Text = "";
            txtDate.Text = "";
            txtGender.Text = "";
            txtDad.Text = "";
            txtMom.Text = "";
            txtState.Text = "";
            pictureBox1.Image = null;
        }

        // Refreshes Grid
        public void RefreshGrid()
        {
            // Refresh
            // Load data on GridView
            DataTable dataTable = p.Select();
            Grid.DataSource = dataTable;
        }

        private void Grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in Grid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        if (cell.Value.ToString() == "[Apto / Saudável]")
                        {
                            cell.Style.ForeColor = Color.Green;
                        }
                        else if (cell.Value.ToString() == "[Inapto / Doente]")
                        {
                            cell.Style.ForeColor = Color.Red;
                        }
                        else if (cell.Value.ToString() == "Morto")
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                row.Cells[i].Style.BackColor = Color.LightGray;
                            }
                        }
                        else if (cell.Value.ToString() == "Dado / Vendido")
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                row.Cells[i].Style.BackColor = Color.LightYellow;
                            }
                        }
                        else if (cell.Value.ToString() == "Devolvido")
                        {
                            for (int i = 0; i < row.Cells.Count; i++)
                            {
                                row.Cells[i].Style.BackColor = Color.MistyRose;
                            }
                        }
                    }
                }
            }
        }
    }
}
