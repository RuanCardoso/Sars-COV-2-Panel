using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace Global_Sars_COV_2
{
    public partial class MainWindow : MetroWindow
    {
        //private const int GWL_STYLE = -16;
        //private const int WS_SYSMENU = 0x80000;
        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern int GetWindowLong(IntPtr hWnd, int nIndex);
        //[DllImport("user32.dll")]
        //private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
        public MainWindow()
        {
            InitializeComponent();
            //--------------------------//
            InitChart();
            //--------------------------//
            Loaded += MainWindow_Loaded;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }
        ChartValues<ObservableValue> c2020;
        ChartValues<ObservableValue> c2019;
        void InitChart()
        {
            c2020 = new ChartValues<ObservableValue> { new ObservableValue(0), new ObservableValue(0), new ObservableValue(0) };
            c2019 = new ChartValues<ObservableValue> { new ObservableValue(0), new ObservableValue(0), new ObservableValue(0) };
            {
                SeriesCollection = new SeriesCollection
                {
                  new RowSeries
                  {
                    Title = "2020-",
                    Values = c2019
                  }
                };
            }
            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new RowSeries
            {
                Title = "2020",
                Values = c2020
            });

            //also adding values updates and animates the chart automatically
            //SeriesCollection[1].Values.Add(new ObservableValue(48d));

            Labels = new[] { "Confirmados", "Recuperados", "Mortos" };
            Formatter = value => value.ToString("N");

            DataContext = this;
        }
        private void MainWindow_Loaded(Object sender, RoutedEventArgs e)
        {
            //var hwnd = new WindowInteropHelper(this).Handle;
            //SetWindowLong(hwnd, GWL_STYLE, GetWindowLong(hwnd, GWL_STYLE) & ~WS_SYSMENU);
            //-------------------------------------------------------------------------------//
            ShowCloseButton = false;
            //-----------------------------//
            sobre.Text = "Sobre esses dados\n\n" +
            "Mudam rapidamente\n" +
            "Os dados mudam rapidamente e podem não mostrar alguns dos casos que ainda não foram informados.\n\n" +
            "Incluem somente as pessoas testadas\n" +
            "Os casos incluem somente pessoas que tiveram testes com resultado positivo. As regras e a disponibilidade dos testes podem variar de acordo com o país. Talvez você não veja dados sobre algumas áreas porque não há registros da publicação ou da coleta recente dessas informações.\n\n" +
            "Por que vejo dados distintos em fontes diferentes?\n" +
            "Existem várias fontes que monitoram e agregam dados sobre o coronavírus. Essas informações são atualizadas em momentos distintos e talvez sejam coletadas de maneiras diferentes.\n";
            getInforSARS(countries[0]);
            {
                loaded = true;
            }
        }
        string[] countries = {
            "https://news.google.com/covid19/map?hl=pt-BR&gl=BR&ceid=BR%3Apt-419", // Global
            "https://news.google.com/covid19/map?hl=pt-BR&gl=BR&ceid=BR%3Apt-419&mid=%2Fm%2F015fr", // Brasil
            "https://news.google.com/covid19/map?hl=pt-BR&gl=BR&ceid=BR%3Apt-419&mid=%2Fm%2F09c7w0", // EUA
           
            "https://news.google.com/covid19/map?hl=pt-BR&gl=BR&ceid=BR%3Apt-419&mid=%2Fm%2F01hd58", // BR-SP
            "https://news.google.com/covid19/map?hl=pt-BR&gl=BR&ceid=BR%3Apt-419&mid=%2Fm%2F01hd4s", // BR-RJ
            "https://news.google.com/covid19/map?hl=pt-BR&gl=BR&ceid=BR%3Apt-419&mid=%2Fm%2F01hdnp", // BR-PA
        };
        bool loaded = false;
        HtmlWeb HtmlWeb = new HtmlWeb();
        async void getInforSARS(string uri)
        {
            try
            {
                var html = await HtmlWeb.LoadFromWebAsync(uri);
                var getCounter = html.DocumentNode.SelectNodes("//div[contains(@class, 'UvMayb')]");
                //--------------------------------------------------------------------------------------//
                totalConf.Content = getCounter[0].InnerText;
                totalRec.Content = getCounter[1].InnerText;
                totalMortos.Content = getCounter[2].InnerText;
                //---------------------------------------------//
                double c = 0;
                double r = 0;
                double m = 0;
                //---------------------------------------------------------//
                double.TryParse((string)totalConf.Content, out c);
                double.TryParse((string)totalRec.Content, out r);
                double.TryParse((string)totalMortos.Content, out m);
                //---------------------------------------------//
                c2020[0] = new ObservableValue(c);
                c2020[1] = new ObservableValue(r);
                c2020[2] = new ObservableValue(m);
                //---------------------------------------------//
                c2019[0] = new ObservableValue(c * 0.2);
                c2019[1] = new ObservableValue(r * 0.2);
                c2019[2] = new ObservableValue(m * 0.2);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void close_Click(Object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void ComboBox_SelectionChanged(Object sender, SelectionChangedEventArgs e)
        {
            if (loaded)
            {
                int index = ((ComboBox)sender).SelectedIndex;
                //---------------------------------------------//
                totalConf.Content = "Aguarde.....";
                totalRec.Content = "Aguarde.....";
                totalMortos.Content = "Aguarde.....";
                //------------------------------------------------------------//
                getInforSARS(countries[index >= 3 ? index - 1 : index]);
            }
        }
    }
}
