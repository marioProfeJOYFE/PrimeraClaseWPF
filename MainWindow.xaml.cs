using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrimeraClase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            lblResultado.Content = "";

            // Comentario de una sola línea
            int numero = 5;
            int resultado = numero + numero2;
            /* Comentario
             * de
             * múltiples
             * líneas
             */

            string texto = "hola clase";

            MessageBox.Show(caption: "gg", messageBoxText: texto);

            double numeroDecimal = 5.5;
            double numeroDecimal2 = 10.5;

            double resultDecimales = numeroDecimal / numeroDecimal2;

            double resto = numeroDecimal % numeroDecimal2;



        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(messageBoxText: txtNombre.Text);
        }

        private void TextBox_TextUpperCase(object objetoQueMeLlama, TextChangedEventArgs e)
        {
            //IF Imperativo
            if (objetoQueMeLlama is TextBox)
            {
               

                TextBox textBox1 = (TextBox)objetoQueMeLlama;
                //CONTROLAR QUE SEAN NUMEROS
                textBox1.Text = new string(textBox1.Text.Where(c => char.IsDigit(c)).ToArray());
                textBox1.Text = textBox1.Text.ToUpper();
                textBox1.SelectionStart = textBox1.Text.Length;

            }
            //IF Declarativo
            if (objetoQueMeLlama is TextBox textBox)
            {
                textBox.Text = textBox.Text.ToUpper();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
    }
}
