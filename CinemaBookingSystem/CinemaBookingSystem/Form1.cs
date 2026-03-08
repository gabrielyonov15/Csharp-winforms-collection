using Microsoft.VisualBasic.Devices;
using static System.Windows.Forms.LinkLabel;

namespace RezarvaciqNaKinoBilet
{
    public partial class frmMovieReservation : Form
    {
        public frmMovieReservation()
        {
            InitializeComponent();
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            double totalPrice = 0;

            if (cmbMovie.SelectedItem == null)
            {
                MessageBox.Show("Моля, изберете филм!");
                return;
            }

            string selectedMovie = cmbMovie.SelectedItem.ToString();

            if (selectedMovie == "Екшън – 10.00 лв.")
            {
                totalPrice += 10;
            }
            else
            if (selectedMovie == "Комедия – 8.00 лв.")
            {
                totalPrice += 8;
            }
            else
            if (selectedMovie == "Анимация – 7.00 лв.")
            {
                totalPrice += 7;
            }

            if (rb3D.Checked)
            {
                totalPrice += 3;
            }
            else
            if (rb2D.Checked)
            {
                totalPrice += 0;
            }
            else
            {
                MessageBox.Show("Моля, изберете тип прожекция!");
                return;
            }

            if (rbStandard.Checked)
            {
                totalPrice += 0;
            }
            else
            if (rbVIP.Checked)
            {
                totalPrice += 5;
            }
            else
            {
                MessageBox.Show("Моля, изберете вид място!");
                return;
            }

            if (chkPopcorn.Checked)
            {
                totalPrice += 4;
            }

            if (chkDrink.Checked)
            {
                totalPrice += 3;
            }

            DialogResult result =
                MessageBox.Show(
                $"Крайната цена на билета е {totalPrice:f2} лв.\nЖелаете ли да завършите резервацията?",
                "Потвърждение на резервация",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Резервацията е успешна!");

                rb2D.Checked = rb3D.Checked = false;
                rbStandard.Checked = rbVIP.Checked = false;
                chkDrink.Checked = chkPopcorn.Checked = false;
                cmbMovie.SelectedIndex = -1;
                cmbMovie.Focus();
            }
        }
    }
}