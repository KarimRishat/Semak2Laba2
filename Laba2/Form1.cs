using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webToolStripMenuItem.Click += webToolStripMenuItem_Click;
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void webToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            dataGridView1.Visible = true;
            if (e.Node.Text.Equals("09-122"))
            {
                dataGridView1.Rows.Clear();
                {
                    foreach (string line in File.ReadLines("Students122.txt", Encoding.Default))
                    {
                        string[] array = line.Split();
                        dataGridView1.Rows.Add(array);
                    }
                }
            }
            if (e.Node.Text.Equals("09-121"))
            {
                dataGridView1.Rows.Clear();
                    foreach (string line in File.ReadLines("Students121.txt", Encoding.Default))
                    {
                        string[] array = line.Split();
                        dataGridView1.Rows.Add(array);
                    }  
            }

        }
    }
}
