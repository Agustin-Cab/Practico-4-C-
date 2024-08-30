using System.Security.Policy;

namespace Practico_4__C__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TDesde_TextChanged(object sender, EventArgs e)
        {

        }
        private void TListaNumeros_TextChanged(object sender, EventArgs e)
        {

        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite letras, la tecla Backspace y espacios
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permite letras, la tecla Backspace y espacios
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void BGenerar_Click(object sender, EventArgs e)
        {
            // Variables para almacenar los valores ingresados
            int desde;
            int hasta;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Intentar convertir los valores a números enteros
            bool esDesdeValido = int.TryParse(TDesde.Text, out desde);
            bool esHastaValido = int.TryParse(THasta.Text, out hasta);

            // Validar que los valores ingresados sean números
            if (!esDesdeValido || !esHastaValido)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (desde > hasta)
            {
                MessageBox.Show("'Desde' no puede ser mayor que 'Hasta'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Limpiar la salida anterior
            LB_ListaNros.Items.Clear();

            // Generar y mostrar los números
            for (int i = desde; i <= hasta; i++)
            {
                LB_ListaNros.Items.Add(i);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BPares_Click(object sender, EventArgs e)
        {

            int desde;
            int hasta;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Intentar convertir los valores a números enteros
            bool esDesdeValido = int.TryParse(TDesde.Text, out desde);
            bool esHastaValido = int.TryParse(THasta.Text, out hasta);

            // Validar que los valores ingresados sean números
            if (!esDesdeValido || !esHastaValido)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (desde > hasta)
            {
                MessageBox.Show("'Desde' no puede ser mayor que 'Hasta'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            LB_ListaNros.Items.Clear();
            // Números pares
            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 == 0)
                {
                    LB_ListaNros.Items.Add(i);
                }
            }
        }


        private void BImpares_Click(object sender, EventArgs e)
        {
            int desde;
            int hasta;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Intentar convertir los valores a números enteros
            bool esDesdeValido = int.TryParse(TDesde.Text, out desde);
            bool esHastaValido = int.TryParse(THasta.Text, out hasta);

            // Validar que los valores ingresados sean números
            if (!esDesdeValido || !esHastaValido)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (desde > hasta)
            {
                MessageBox.Show("'Desde' no puede ser mayor que 'Hasta'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Números impares
            LB_ListaNros.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                if (i % 2 != 0) 
                {
                    LB_ListaNros.Items.Add(i);
                }
            }
        }


        private void BPrimos_Click(object sender, EventArgs e)
        {
            int desde;
            int hasta;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(TDesde.Text) || string.IsNullOrWhiteSpace(THasta.Text))
            {
                MessageBox.Show("Por favor, complete ambos campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Intentar convertir los valores a números enteros
            bool esDesdeValido = int.TryParse(TDesde.Text, out desde);
            bool esHastaValido = int.TryParse(THasta.Text, out hasta);

            // Validar que los valores ingresados sean números
            if (!esDesdeValido || !esHastaValido)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (desde > hasta)
            {
                MessageBox.Show("'Desde' no puede ser mayor que 'Hasta'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Números primos
            LB_ListaNros.Items.Clear();

            for (int i = desde; i <= hasta; i++)
            {
                if (EsPrimo(i)) 
                {
                    LB_ListaNros.Items.Add(i);
                }
            }
        }










































        private bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(numero); i += 2)
            {
                if (numero % i == 0) return false;
            }
            return true;
        }

        
    }
}
