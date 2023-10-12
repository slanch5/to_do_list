using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_do_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        DataTable to_do_list = new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            to_do_list.Columns.Add("Title");
            to_do_list.Columns.Add("Description");


            List.DataSource = to_do_list;
        }

        private void button_loed_Click(object sender, EventArgs e)
        {
            tasktextBox.Text = "";
            textBox2.Text = "";
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
             isEditing = true;
            tasktextBox.Text = to_do_list.Rows[List.CurrentCell.RowIndex].ItemArray[0].ToString();
            textBox2.Text = to_do_list.Rows[List.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            try
            {
                to_do_list.Rows[List.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("помилка " + ex);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                to_do_list.Rows[List.CurrentCell.RowIndex]["Title"] = tasktextBox.Text;
                to_do_list.Rows[List.CurrentCell.RowIndex]["Description"] = textBox2.Text;
            }
            else
            {
                to_do_list.Rows.Add(tasktextBox.Text, textBox2.Text);
            }

            tasktextBox.Text = "";
            textBox2.Text = "";
            isEditing = false;


        }
    }
}
