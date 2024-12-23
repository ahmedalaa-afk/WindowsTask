using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Groups.Add("","Language");
            listView1.Groups.Add("", "Price");

            listView1.Items.AddRange(new[] {
                new ListViewItem("English",0),
                new ListViewItem("Arabic",0),
                new ListViewItem("Frensh", 0),
                new ListViewItem("German", 0),
            });

            listView1.Items.AddRange(new[] {
                new ListViewItem("Paid", 0),
                new ListViewItem("Free", 0),
            });

            listView1.Items[0].Group = listView1.Groups[0];
            listView1.Items[1].Group = listView1.Groups[0];
            listView1.Items[2].Group = listView1.Groups[0];
            listView1.Items[3].Group = listView1.Groups[0];

            listView1.Items[4].Group = listView1.Groups[1];
            listView1.Items[5].Group = listView1.Groups[1];


            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Optional: Close Form1 (the current form)
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Optional: Close Form1 (the current form)
            //this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Show Form2
            form2.Show();

            // Optional: Close Form1 (the current form)
            //this.Close();
        }
    }
}
