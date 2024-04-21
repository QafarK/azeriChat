using System.Windows;
using System.Windows.Input;

namespace azeriChat;


public partial class MainWindow : Window
{
    public int FontSize1 { get; set; } = 15;
    public int FontSize2 { get; set; } = 25;
    public MainWindow()
    {
        InitializeComponent();
        DataContext = this;
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        listBox.Items.Add($"{DateTime.Now}          {textBox.Text}");
    }

    private void textBox_Key(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            listBox.Items.Add($"{DateTime.Now}          {textBox.Text}");
            textBox.Text = "";
        }
    }
}