using backend.model;
using backend.service;
using cs_school_ms.service;
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

namespace cs_school_ms.view
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        test t = new test();
        string imgLocate = null;

        void get()
        {
            //DataTable dt = new DataTable();
            DataTable dt = testService.gettest();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dataGridView1.Rows.Add(
                    dt.Rows[i]["id"].ToString(),
                    dt.Rows[i]["name"].ToString(),
                    Image.FromFile(Path.Combine(Application.StartupPath, "test", dt.Rows[i]["photo"].ToString()))
                    );
            }

        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            get();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                t.name = textBox1.Text;
                t.photo = method.CopyImage_ToDestination("test", imgLocate);
                testService.add(t);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            get();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imgLocate = method.BrowseImage();
            pictureBox1.ImageLocation = imgLocate;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
