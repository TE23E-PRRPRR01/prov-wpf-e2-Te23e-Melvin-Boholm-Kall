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

namespace prov_wpf_e2_Te23e_Melvin_Boholm_Kall;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KlickVisa(object sender, RoutedEventArgs e)
    {
        string aktivitet = txbAktivitet.Text;
        string langd = txbLangd.Text;
        string intensitet = txbIntensitet.Text;

        txbPass.Text = $"""
        Aktivitet: {aktivitet} 
        Längd: {langd} 
        Intensitet: {intensitet}
        """;

        if (aktivitet == "")
        {
            txbPass.Text = "Aktiviteten kan inte vara tom.";
        }
        
        int langdInt;
        bool lyckad = int.TryParse(langd, out langdInt);

        if (lyckad != true)
        {
            if (langdInt <= 180 && langdInt >= 5)
            {
                
            }
            else
            {
                txbPass.Text = "Felaktig längd! Ange ett heltal mellan 5 och 180.";
            }

        }
        
        string intensitetToLower = intensitet.ToLower();
        if (intensitetToLower == "låg" || intensitetToLower == "medel" ||intensitetToLower == "hög")
        {
            
        }
        else
        {
            txbPass.Text = "Felaktig intensitet! Välj Låg, Medel, Hög.";
        }


    }

    private void KlickSpara(object sender, RoutedEventArgs e)
    {
        if (txbAktivitet.Text != "")
        {
            txbPass.Text = $"Passet '{txbAktivitet.Text}' är sparat";

            
            
        }
        else
        {
            txbPass.Text = "Passet måste heta något.";
        }
    }

    private void KlickVisaPass(object sender, RoutedEventArgs e)
    {
        
    }
}