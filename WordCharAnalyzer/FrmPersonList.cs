using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordCharAnalyzer
{
    public partial class FrmPersonList : Form
    {
        public List<Person> persons = new List<Person>();
        public FrmPersonList()
        {
            InitializeComponent();
        }
        bool DeletePerson(ref string message)
        {
            if (dgvPerson.CurrentRow == null)
            {
                message = "لطفا یک شخص را انتخاب کنید";
                return false;
            }
            return true;
        }
        private void FrmPersonList_Load(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void FillDGV()
        {
            dgvPerson.DataSource = persons.ToList();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var frmAddPerson=new FrmAddPerson();
            frmAddPerson.ShowDialog();
            FillDGV();
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string message = "";
            if (!DeletePerson(ref message))
                MessageBox.Show(message, "خطا");
            else
            {
                persons.RemoveAt(dgvPerson.CurrentRow.Index);
                FillDGV();
            }
        }
    }
}
