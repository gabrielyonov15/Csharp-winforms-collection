namespace WinFormsApp2
{
    public partial class frmEmployee : Form
    {
        List<Person> people = new List<Person>();
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            if (firstName == "")
            {
                MessageBox.Show("Моля, въведете име:");
                return;
            }

            string lastName = txtLastName.Text;
            if (lastName == "")
            {
                MessageBox.Show("Моля, въведете фамилия:");
                return;
            }

            string egn = txtIDNumber.Text;
            if (egn.Length != 10)
            {
                MessageBox.Show("Моля, въведете точно 10 цифри за ЕГН:");
                return;
            }

            string gender = "";
            if (rbMale.Checked)
            {
                gender = "Мъж";
            }
            else
            if (rbFemale.Checked)
            {
                gender = "Жена";
            }

            if (gender == "")
            {
                MessageBox.Show("Моля, изберете пол!");
                return;
            }

            if (cmbOccupation.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете сфера на работа!");
                return;
            }

            Person p = new Person();
            p.FirstName = txtFirstName.Text;
            p.MiddleName = txtMiddleName.Text;
            p.LastName = txtLastName.Text;
            p.EGN = txtIDNumber.Text;
            p.Gender = gender;
            p.Occupation = cmbOccupation.SelectedItem.ToString();

            DialogResult result =
                MessageBox.Show(
                 "Име: " + p.FirstName +
                 "\nПрезиме: " + p.MiddleName +
                 "\nФамилия: " + p.LastName +
                 "\nЕГН: " + p.EGN +
                 "\nПол: " + p.Gender +
                 "\nСфера на работа: " + p.Occupation,
                 "Потвърждение на данни",
                 MessageBoxButtons.OKCancel,
                 MessageBoxIcon.Question,
                 MessageBoxDefaultButton.Button2);

            if (result == DialogResult.OK)
            {
                people.Add(p);
                MessageBox.Show("Данните са въведени успешно!");
                txtFirstName.Clear();
                txtMiddleName.Clear();
                txtLastName.Clear();
                txtIDNumber.Clear();
                rbMale.Checked = rbFemale.Checked = false;
                cmbOccupation.SelectedIndex = -1;
                txtFirstName.Focus();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (people.Count == 0)
            {
                MessageBox.Show("Няма въведени хора.");
                return;
            }

            string all = "";
            for (int i = 0; i < people.Count; i++)
            {
                Person p = people[i];

                all += "Име: " + p.FirstName +
                "\nПрезиме: " + p.MiddleName +
                "\nФамилия: " + p.LastName +
                "\nЕГН: " + p.EGN +
                "\nПол: " + p.Gender +
                "\nСфера на работа: " + p.Occupation + "\n\n";
            }
            MessageBox.Show(all, "Списък с всички въведени");
        }
    }
}