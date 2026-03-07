using System.Windows.Forms;

namespace FitnessZoneRegistration
{
    public partial class frmFitnessRegister : Form
    {
        public frmFitnessRegister()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            cmbInterests.Items.Add("Гръб");
            cmbInterests.Items.Add("Корем");
            cmbInterests.Items.Add("Гърди");
            cmbInterests.Items.Add("Бицепс");

            cmbAge.Items.Add("до 20 год.");
            cmbAge.Items.Add("20 – 40 год.");
            cmbAge.Items.Add("40+");
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (rbMale.Checked)
            {
                gender = "г-н";
            }
            else
            if (rbFemale.Checked)
            {
                gender = "г-жа";
            }

            string firstName = txtName.Text;
            string lastName = txtLastName.Text;
            string interest = cmbInterests.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(firstName))
            {
                MessageBox.Show("Моля, въведете име!");
                return;
            }

            MessageBox.Show($"Успешна регистрация!\nДобре дошли, {gender} {firstName} {lastName}.\nЗапазени интереси: {interest}");
        }
    }
}