using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _30_01_225.DataModel;

namespace _30_01_225
{
    public partial class Form1 : Form
    {
        public Model1 db { get; set; }
        public Form1()
        {
            InitializeComponent();
            db = new Model1();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSourceKva.DataSource = db.Kva.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AADDD aADDD = new AADDD(db);
            if (aADDD.ShowDialog() == DialogResult.OK)
                bindingSourceKva.DataSource = db.Kva.ToList();

        }
    }
}
