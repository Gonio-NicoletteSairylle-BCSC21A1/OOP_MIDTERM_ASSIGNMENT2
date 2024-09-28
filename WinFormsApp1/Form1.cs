using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace To_do_list
{
    public partial class Form1TodoList : Form
    {
        public Form1TodoList()
        {
            InitializeComponent();
        }

        private void button3New_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Titlee.Text) && !string.IsNullOrWhiteSpace(Descriptionn.Text) && !string.IsNullOrWhiteSpace(Datee.Text))
            {
                dataGridView1TodoList.Rows.Add(Titlee.Text, Descriptionn.Text, Datee.Text, false);
                Titlee.Clear();
                Descriptionn.Clear();
                Datee.Clear();
            }
            else
            {
                MessageBox.Show("Please fill in all fields before adding a new task.");
            }
        }

        private void button2Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1TodoList.SelectedRows)
            {
                dataGridView1TodoList.Rows.Remove(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1TodoList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1TodoList.SelectedRows[0];
                selectedRow.Cells["Title"].Value = Titlee.Text;
                selectedRow.Cells["Description"].Value = Descriptionn.Text;
                selectedRow.Cells["Date"].Value = Datee.Text;
                Titlee.Clear();
                Descriptionn.Clear();
                Datee.Clear();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void button4Save_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your task/s have been saved successfully.");

        }

        private void dataGridView1TodoList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex >= 0)
            {
                DataGridViewCheckBoxCell checkboxCell = (DataGridViewCheckBoxCell)dataGridView1TodoList.Rows[e.RowIndex].Cells[e.ColumnIndex];

                DialogResult result = MessageBox.Show("Do you want to change the completion status of this task?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    checkboxCell.Value = !(bool)checkboxCell.Value;
                }
            }
        }

        private void button1Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void textBox2_TextChanged(object sender, EventArgs e) { }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
    }
}