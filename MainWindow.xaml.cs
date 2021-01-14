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

namespace PongRemix
{
    /// <summary>
    /// Daniel Tekle
    /// Assignment 5: Animation with WPF
    /// Main Window Start window Methods
    ///     - BtnStartGame_Click : opens game window event
    ///     - BtnScoresDB_Click : opens window to view high score event 
    /// Interaction logic for MainWindow.xaml
    /// extra credit 
    /// --gave game a theme, made game paddle a plank
    /// --implemented a database to hold scores
    /// --have a start main window 
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameWindow gameWindow;
        private DBWindow dbWindow;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnStartGame_Click(object sender, RoutedEventArgs e)
        {
            if (txtInputName.Text.Equals("") || txtInputName == null)
            {
                MessageBox.Show("Enter a name to play");
                return;
            }
            else {
                
                this.gameWindow = new GameWindow(txtInputName.Text);
                this.gameWindow.ShowDialog();
                this.Close();
            }

        }

        private void BtnScoresDB_Click(object sender, RoutedEventArgs e)
        {

            this.dbWindow = new DBWindow();
            this.dbWindow.ShowDialog();

        }

        private void MnuHelpAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("PONG REMIX App,\n\n" +
                "User enters name to begin game \n" +
                "use keyboard arrow keys to move paddle up and down \n" +
                "for every 10 points the ball speed incresses  \n" +
                "and paddle decresses in size \n" +
                "HotKey shortcuts" +
            "-- File = ALT + f \n" +
                "- Start = ALT + s \n" +
                "- Stop = ALT + p \n" +
                "- Scores DB = ALT + d \n" +
                "- Exit = ALT + e \n" +
            "-- Help = ALT + h \n" +
                "- About = ALT + a \n" +
                "\n" +
                "Framework: .NET Framework version 3.8 64 bit \n" +
                "Created 11/09/2020\n" +
                ""
                );
        }
    }
}
