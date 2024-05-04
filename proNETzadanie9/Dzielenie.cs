using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proNETzadanie9
{
    public partial class Dzielenie : Form
    {
        public Dzielenie()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void OnBtnOperationClick(object sender, EventArgs e)
        {
            try
            {
                double dzielna = double.Parse(dzielnaText.Text);
                double dzielnik = double.Parse(dzielnikText.Text);

                if (dzielnik == 0)
                {
                    throw new DivideByZeroException("Nie można dzielić przez zero!");
                }

                double result = dzielna / dzielnik;

                wynikText.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                HandleError(ex.Message, "Błąd: Nieprawidłowy format liczby.");
            }
            catch (OverflowException ex)
            {
                HandleError(ex.Message, "Błąd: Przekroczenie zakresu liczby.");
            }
            catch (DivideByZeroException ex)
            {
                HandleError(ex.Message, "Błąd: Nie można dzielić przez zero!");
            }
            catch (Exception ex)
            {
                HandleError(ex.Message, "Błąd: Wystąpił ogólny błąd.");
            }
        }

        private void HandleError(string errorMessage, string note)
        {
            MessageBox.Show(errorMessage, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            logEvent(errorMessage, note);
        }

        private void logEvent(string message, string note)
        {
            EventLog eventLog = new EventLog("Application");
            eventLog.Source = "WindowsFormsApp";
            eventLog.WriteEntry(message + " " + note, EventLogEntryType.Error);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
