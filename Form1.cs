using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slotkin_P3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //whoops!
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            orderNumTextBox.Clear();
            numItemsTextBox.Clear();
            usbDriverRadioButton.Checked = false;
            coffeeMugRadioButton.Checked = false;
            penRadioButton.Checked = false;
            textTextBox.Clear();
            logoCheckBox.Checked = false;
            numColorsTextBox.Clear();
            resultsTextBox.Clear();
            numColorsLabel.Visible = false;
            numColorsTextBox.Visible = false;
        }

        private void logoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            numColorsLabel.Visible = true;
            numColorsTextBox.Visible = true;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                LogoOrderItem item = new LogoOrderItem(logoCheckBox.Checked, textTextBox.Text);

                item.HasLogo = logoCheckBox.Checked;
                item.NumColors = Convert.ToInt32(numColorsTextBox.Text);
                item.Text = textTextBox.Text;
                item.NumItems = Convert.ToInt32(numItemsTextBox.Text);
                item.ItemID = Convert.ToInt32(orderNumTextBox.Text);

                if (usbDriverRadioButton.Checked)
                {
                    item.ItemType = usbDriverRadioButton.Text;
                }
                else if (coffeeMugRadioButton.Checked)
                {
                    item.ItemType = coffeeMugRadioButton.Text;
                }
                else if (penRadioButton.Checked)
                {
                    item.ItemType = penRadioButton.Text;
                }

                resultsTextBox.Text = item.GetOrderSummary();
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Not in number format!");
            }
            catch (Exception exc)
            {
                Console.WriteLine("Error! " + exc.Message + "\nException type: " + exc.GetType());
            }
        }

        private void numColorsTextBox_TextChanged(object sender, EventArgs e)
        {
            //whoops!
        }
    }
}
