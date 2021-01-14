using System.Windows;

namespace PongRemix
{
    /// <summary>
    /// Daniel Tekle
    /// Assignment 5: Animation with WPF
    /// End Game Window Methods
    ///     - BtnHome_Click : end game window home window open event
    ///     - BtnReset_Click : end game window reset game event
    ///     - BtnEnd_Click : end game window end game event
    /// Interaction logic for ResetWindow.xaml
    /// </summary>
    public partial class EndGameWindow : Window
    {
        private readonly string userName;
        private GameWindow gameWindowReset;
        private MainWindow mainWindowReset;
        public EndGameWindow(string name)
        {
            this.userName = name;
            InitializeComponent();   
        }

        private void BtnHome_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.mainWindowReset = new MainWindow();
            this.mainWindowReset.ShowDialog();
        }

        private void BtnReset_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.gameWindowReset = new GameWindow(userName);
            this.gameWindowReset.ShowDialog();
        }

        private void BtnEnd_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("GoodBy");
            System.Environment.Exit(1);
        }
    }
}
