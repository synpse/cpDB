using Pombos.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Columbus2019
{
    public partial class Form2 : Form
    {
        // Instances
        Pombo p = new Pombo();

        // Variables
        private string lastID;

        // Start
        public Form2()
        {
            // Initialize
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void LoadProfile(DataGridView Grid, int row)
        {
            // Store ID
            lastID = Grid.Rows[row].Cells[0].Value.ToString();

            // Assign info to labels
            txtPopName.Text = Grid.Rows[row].Cells[2].Value.ToString();
            txtPopNumber.Text = Grid.Rows[row].Cells[1].Value.ToString();
            txtPopGender.Text = Grid.Rows[row].Cells[4].Value.ToString();
            txtPopDad.Text = Grid.Rows[row].Cells[5].Value.ToString();
            txtPopMom.Text = Grid.Rows[row].Cells[6].Value.ToString();
            txtPopState.Text = Grid.Rows[row].Cells[7].Value.ToString();
            txtPopNotes.Text = Grid.Rows[row].Cells[8].Value.ToString();
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

        private void UpdateProfile_Click(object sender, EventArgs e)
        {
            // ID
            bool convN0 = int.TryParse(lastID, out int result);

            if (convN0 == true)
            {
                p.PomboID = result;
            }
            else
            {
                MessageBox.Show("ID Inválido!");
            }

            // State
            p.State = txtPopState.Text;

            // Notes
            p.Notes = txtPopNotes.Text;

            // Update data into DB
            bool successful = p.UpdateNotes(p);
            if (successful == true)
            {
                MessageBox.Show("Pombo atualizado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar pombo! Tente novamente.");
            }

            // Close this dialog
            Close();
            // Avoid minimizing form1 by activating it
            Program.form1.Activate();
            // Clear input fields from form1
            Program.form1.Clear();
            // Refresh GridDataView
            Program.form1.RefreshGrid();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPopGender_Click(object sender, EventArgs e)
        {

        }

        private void txtPopDad_Click(object sender, EventArgs e)
        {

        }

        private void txtPopMom_Click(object sender, EventArgs e)
        {

        }
    }
}
