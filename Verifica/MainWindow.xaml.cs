using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Verifica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void btnCreaLibri_Click(object sender, RoutedEventArgs e)
        {
            DateTime annoPub = DateTime.Parse(txtAnnoPub.Text);
            int numPag = int.Parse(txtNumeroPagine.Text);
            Libro l = new Libro(txtNome.Text, txtTitolo.Text, annoPub, txtEditore.Text, numPag);
        }

        private void creaBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            DateTime orarioApertura = DateTime.Parse(txtOrarioApertura.Text);
            DateTime orarioChiusura = DateTime.Parse(txtOrarioChiusura.Text);
            Biblioteca b = new Biblioteca(txtNomeBiblioteca.Text, txtIndirizzo.Text, orarioApertura, orarioChiusura);
        }
    }
}
