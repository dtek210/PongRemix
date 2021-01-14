using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
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
using System.Windows.Shapes;

namespace PongRemix
{
    /// <summary>
    /// Interaction logic for DBWindow.xaml
    /// </summary>
    public partial class DBWindow : Window
    {
        //private int counter = 0;

        private bool UpdateDB = false;

        public DBWindow()
        {
            InitializeComponent();
        }

        public class MyData
        {
            public string Place { get; set; }
            public string Name { get; set; }
            public string Score { get; set; }
        }
        private void BtnAddToListBox_Click(object sender, RoutedEventArgs e)
        {
            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn;
            SQLiteCommand cmd;
            SQLiteDataReader sqlite_datareader;

            if (UpdateDB == true)
            {
                MessageBox.Show("DataBase has already been Displayed!!!" + "\n");
                return;
            }
            int i = 0;
            try
            {
                // create a new database connection:
                sqlite_conn = new SQLiteConnection("Data Source=pongScores.db;Version=3;New=True;Compress=True;");

                // open the connection:
                sqlite_conn.Open();

                // create a new SQL command:
                cmd = sqlite_conn.CreateCommand();


                // But how do we read something out of our table ?
                // First lets build a SQL-Query again:
                cmd.CommandText = "SELECT * FROM pongScoresDB ORDER BY score DESC";


                // Now the SQLiteCommand object can give us a DataReader-Object:
                sqlite_datareader = cmd.ExecuteReader();

                // The SQLiteDataReader allows us to run through the result lines:
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    // Print out the content of the text field:
                    this.lvResults.Items.Add(new
                    {
                        Place = i,
                        Name = sqlite_datareader["name"].ToString(),
                        Score = sqlite_datareader["score"].ToString(),
                    });
                    i++;
                }
                // We are ready, now lets cleanup and close our connection:
                UpdateDB = true;
            }
            catch
            {
                MessageBox.Show("No Database to Display" + "\n");
            }
        }
        private void BtnExitDone_Click(object sender, RoutedEventArgs e)
        {
            lvResults.Items.Clear();
            this.Close();
        }
    }
}
