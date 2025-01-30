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
    public partial class AADDD : Form
    {
        private Model1 db { get; set; }
        public AADDD(Model1 _db)
        {
            InitializeComponent();
            db = _db;
        }

        private void AADDD_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (iDTextBox.Text == "" || vladelecTextBox.Text == "" || vozrastTextBox.Text == "" || размерTextBox.Text == "")
            {
                MessageBox.Show("Нужно ввести все требуемые данные!");
                return;
            }
            int id;
            bool b = int.TryParse(iDTextBox.Text, out id);
            if (b == false)
            {
                MessageBox.Show("Неверный формат !!" + iDTextBox);
                return;
            }
            Kva kva = new Kva();

            kva.ID = iDTextBox.Text;
            kva.Vozrast = vladelecTextBox.Text;
            kva.Vladelec = vozrastTextBox.Text;
            kva.Размер = размерTextBox.Text;

            db.Kva.Add(kva);
            try
            {
                db.SaveChanges();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
