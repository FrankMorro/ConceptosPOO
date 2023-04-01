using ConceptosOOP.Logic;

namespace Conceptos.UserInterface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            if (txtDay.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un día", "Error Día");
                return;
            }

            if (txtMonth.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un mes", "Error Mes");
                return;
            }

            if (txtYear.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un año", "Error Año");
                return;
            }

            try
            {
                int year = Convert.ToInt32(txtYear.Text);
                int month = Convert.ToInt32(txtMonth.Text);
                int day = Convert.ToInt32(txtDay.Text);

                var date = new Date(day, month, year);

                MessageBox.Show($"Felicidades su fecha correcta es: {date}");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrio un error al moimento de establecer la fecha:\n{ex.Message} ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}