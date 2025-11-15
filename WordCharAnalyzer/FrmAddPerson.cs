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
    public partial class FrmAddPerson : Form
    {
        public FrmAddPerson()
        {
            InitializeComponent();
        }
        bool ValidateInput(ref string message)
        {
            bool isNameValid = string.IsNullOrWhiteSpace(txtFirstName.Text);
            bool isLastNameValid = string.IsNullOrWhiteSpace(txtLastName.Text);
            bool isNationalCodeValid = string.IsNullOrWhiteSpace(txtNationalCode.Text);
            bool isGenderValid = cmbGender.SelectedIndex == -1;

            if (isNameValid)
            {
                message = " لطفا نام خود را وارد کنید";
                return false;
            }
            if (isLastNameValid)
            {
                message = " لطفا نام خانوادگی خود را وارد کنید";
                return false;
            }
            if (isNationalCodeValid)
            {
                message = " لطفا کد ملی خود را وارد کنید";
                return false;
            }
            if (isGenderValid)
            {
                message = " لطفا جنسیت خود را انتخاب کنید";
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var person = new Person();
            string msg = "";
            if (!ValidateInput(ref msg))
                MessageBox.Show(msg, "خطا");
            else
            {
                person.FirstName = txtFirstName.Text;
                person.LasttName = txtLastName.Text;
                person.NationalCode = txtNationalCode.Text;
                person.Gender = cmbGender.SelectedItem.ToString();

                var frmPersonList = Application.OpenForms[nameof(FrmPersonList)] as FrmPersonList;
                frmPersonList.persons.Add(person);
                this.Close();
            }
        }
    }
}
