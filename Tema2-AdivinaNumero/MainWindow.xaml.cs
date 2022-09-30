using System;
using System.Windows;

namespace Tema2_AdivinaNumero
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numero;

        public MainWindow()
        {
            InitializeComponent();
            mensajeTextBlock.Visibility = Visibility.Hidden;
            numero = new Random().Next(0, 101);
        }

        private void comprobarButton_Click(object sender, RoutedEventArgs e)
        {
            mensajeTextBlock.Visibility = Visibility.Visible;
            if (int.Parse(numeroTextBox.Text) == numero)
                mensajeTextBlock.Text = "¡Has acertado!";

            if (int.Parse(numeroTextBox.Text) < numero)
                mensajeTextBlock.Text = "Te has quedado corto";

            if (int.Parse(numeroTextBox.Text) > numero)
                mensajeTextBlock.Text = "Te has pasado";
        }

        private void reiniciarButton_Click(object sender, RoutedEventArgs e)
        {
            numeroTextBox.Text = "";
            mensajeTextBlock.Visibility = Visibility.Hidden;
            numero = new Random().Next(0, 101);
        }
    }
}