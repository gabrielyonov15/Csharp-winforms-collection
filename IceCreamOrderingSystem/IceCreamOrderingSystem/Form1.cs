using System;
using System.Windows.Forms;

namespace IceCreamOrderingSystem
{
    public partial class frmIceCreamOrder : Form
    {
        public frmIceCreamOrder()
        {
            InitializeComponent();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            IceCreamControl iceCream = new IceCreamControl();

            iceCream.Name = txtName.Text;
            if (iceCream.Name == "")
            {
                MessageBox.Show("Моля, въведете име!");
                return;
            }

            if (rbLarge.Checked)
            {
                iceCream.Size = "Голям";
            }
            else 
            if (rbMedium.Checked)
            {
                iceCream.Size = "Среден";
            }
            else
            if (rbSmall.Checked)
            {
                iceCream.Size = "Малък";
            }

            if (iceCream.Size == null)
            {
                MessageBox.Show("Моля, изберете размер!");
                return;
            }

            if (cmbFlavor.SelectedItem != null)
            {
                iceCream.Flavor = cmbFlavor.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Моля, изберете вкус на сладоледа!");
                return;
            }

            iceCream.Cookies = chkCookies.Checked;
            iceCream.Caramel = chkCaramel.Checked;
            iceCream.Sprinkles = chkSprinkles.Checked;
            iceCream.Vanilla = chkVanilla.Checked;
            iceCream.WaferSticks = chkWaferSticks.Checked;

            string toppings= "";
            if (iceCream.Vanilla)
            {
                toppings = "Ванилия";
            }

            if (iceCream.Caramel)
            {
                if(toppings != "")
                {
                    toppings += ", Карамел";
                }
                else
                {
                    toppings = "Карамел";
                }
            }

            if (iceCream.Cookies)
            {
                if(toppings != "")
                {
                    toppings += ", Бисквити";
                }
                else
                {
                    toppings = "Бисквити";
                }
            }

            if (iceCream.Sprinkles)
            {
                if(toppings != "")
                {
                    toppings += ", Пръчици";
                }
                else
                {
                    toppings = "Пръчици";
                }
            }

            if (iceCream.WaferSticks)
            {
                if(toppings != "")
                {
                    toppings += ", Пурички";
                }
                else
                {
                    toppings = "Пурички";
                }
            }

            if (toppings == "")
            {
                toppings = "Няма добавки";
            }

            string order =
                "Име: " + iceCream.Name +
                " Размер: " + iceCream.Size +
                " Вкус: " + iceCream.Flavor +
                " Добавки: " + toppings;

            MessageBox.Show(order, "Успешна поръчка");
            lstOrder.Items.Add(order);

            txtName.Clear();
            rbLarge.Checked = rbMedium.Checked = rbSmall.Checked = false;
            chkCookies.Checked = chkCaramel.Checked = chkSprinkles.Checked = chkVanilla.Checked = chkWaferSticks.Checked = false;
            cmbFlavor.SelectedIndex = -1;
            txtName.Focus();
        }
    }
}