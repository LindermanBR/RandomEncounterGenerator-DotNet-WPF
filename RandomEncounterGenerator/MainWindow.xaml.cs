
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RandomEncounterGenerator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new ViewModel();
            DataContext = viewModel;
            CarregarOpcoesComboBox(viewModel.TipoEncontro, cmbTipoEncontro);
            CarregarOpcoesComboBox(viewModel.Oponente, cmbOponente);
            CarregarOpcoesComboBox(viewModel.Objetivo, cmbObjetivo);
            CarregarOpcoesComboBox(viewModel.Localidade, cmbLocalidade);
            CarregarOpcoesComboBox(viewModel.Clima, cmbClima1);
            CarregarOpcoesComboBox(viewModel.Clima, cmbClima2);

        }

        private void CarregarOpcoesComboBox(List<string> opcoes, ComboBox comboBox)
        {
            foreach (var opcao in opcoes)
            {
                comboBox.Items.Add(opcao);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (chkAleatorio.IsChecked == true)
            {
                // Se aleatório estiver marcado, selecione opções aleatórias
                viewModel.SelecionarAleatorio();
            }
            else
            {
                // Se não, use as opções selecionadas nos ComboBoxes
                viewModel.SelecionarOpcoes(
                    cmbTipoEncontro.SelectedItem as string,
                    cmbOponente.SelectedItem as string,
                    cmbObjetivo.SelectedItem as string,
                    cmbLocalidade.SelectedItem as string,
                    cmbClima1.SelectedItem as string,
                    cmbClima2.SelectedItem as string
                );

            }
            // Exibir o resultado no TextBox
            txtResultado.Text = viewModel.GerarEncontro();
            txtResultado.UpdateLayout();
        }
    }
}