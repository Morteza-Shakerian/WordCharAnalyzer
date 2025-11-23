using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WordCharAnalyzer
{
    public partial class FrmAddPerson : Form
    {
        private Person _person;
        private bool _isNew = false;
        public FrmAddPerson(Person person = null)
        {
            InitializeComponent();
            if (person == null)
            {
                person = new Person();
                _isNew = true;
            }

            _person = person;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _person.FirstName = txtFirstName.Text;
            _person.LasttName = txtLastName.Text;
            _person.NationalCode = txtNationalCode.Text;
            if (rdoFemale.Checked)
                _person.Gender = rdoFemale.Text;
            else if (rdoMale.Checked)
                _person.Gender = rdoMale.Text;
            var isValid = _person.ValidateInput();
            if (!isValid.IsSuccess)
            {
                MessageBox.Show(isValid.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var frmPerson = Application.OpenForms[nameof(FrmPersonList)] as FrmPersonList;
            if (frmPerson != null)
            {
                if (_isNew)
                    frmPerson.persons.Add(_person);

                frmPerson.FillDGV();
            }
            this.Close();
        }

        private void FrmAddPerson_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = _person.FirstName;
            txtLastName.Text = _person.LasttName;
            txtNationalCode.Text = _person.NationalCode;
            if (_person.Gender == rdoMale.Text)
                rdoMale.Checked = true;
            else if (_person.Gender == rdoFemale.Text)
                rdoFemale.Checked = true;
        }

        private void txtNationalCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void FilterInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.Handled = true;

        }
    }
}
