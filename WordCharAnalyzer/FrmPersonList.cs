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

        public void FillDGV()
        {
            dgvPerson.DataSource = null;
            dgvPerson.DataSource = persons.ToList();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            var frmAddPerson = new FrmAddPerson();
            frmAddPerson.Text = "افزودن شخص";
            frmAddPerson.ShowDialog();
            FillDGV();

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string message = "";
            if (DeletePerson(ref message))
            {
                var personToDelete = dgvPerson.CurrentRow.DataBoundItem as Person;
                var result = MessageBox.Show(
                $"آیا از حذف  {personToDelete.FirstName} اطمینان دارید؟",
                 "تایید حذف",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning
                 );
                if (result == DialogResult.Yes)
                {
                    persons.Remove(personToDelete);
                    FillDGV();
                }
            }
            else
                MessageBox.Show(message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPerson.CurrentRow != null)
            {
                var personToEdit = dgvPerson.CurrentRow.DataBoundItem as Person;
                var frmEditPerson = new FrmAddPerson(personToEdit);
                frmEditPerson.Text = "ویرایش اشخاص";



                DialogResult result = frmEditPerson.ShowDialog();
                if (result == DialogResult.OK)
                    FillDGV();
            }
            else
                MessageBox.Show("یک ردیف را انتخاب کنید", "خطا"
             , MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
