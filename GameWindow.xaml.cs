using System;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Threading;

namespace PongRemix
{
    /// <summary>
    /// Daniel Tekle
    /// Assignment 5: Animation with WPF
    /// Game Window Methods
    ///     - GameWindow : sets up game window 
    ///     - GameTimer_Tick : game play events
    ///     - Window_KeyDown : game control events
    ///     - WriteDatabase : stores game score to Data base of high scores
    ///     - BtnStartGame_Click : game play start after paused event
    ///     - BtnStopGame_Click : game play pause event
    ///     - EndGameReset : game play end screen event
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        private DispatcherTimer gameTimer = new DispatcherTimer();
        private EndGameWindow gameWindowPopup;
        private String name;
        //contol speed 
        private double dx = 1;
        private double dy = 1;
        private double vertDirection = -1;
        private double horizDirection = 1;

        private double gameBallTop = 0;
        private double gameBallLeft = 0;

        private double gamePaddleTop = 0;
        private double gamePaddleLeft = 0;
        //contol moving wall speed
        private double gamePaddleDy = 2;

        private int playerScore = 0;
        private int tempScore = 0;
        private bool gameStoped = false;
        private GameWindow gameWindow;
        private MainWindow homeWindow;

        public GameWindow(String name)
        {
            InitializeComponent();
            this.name = name;
            gameTimer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            gameTimer.Tick += GameTimer_Tick;

            gameBallTop = Canvas.GetTop(gameBall);
            gameBallLeft = Canvas.GetLeft(gameBall);

            gamePaddleTop = Canvas.GetTop(gamePaddle);
            gamePaddleLeft = Canvas.GetLeft(gamePaddle);

            gameTimer.IsEnabled = true;
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //double xComponent = gameBall;
            //double yComponent = 0;
            if (gameBallTop <= 0 || gameBallTop >= (myGameCanvas.Height - gameBall.Height))
            {
                vertDirection *= -1;
            }
            if (gameBallLeft <= 0)
            {
                this.Close();
                MessageBox.Show("Game Over");
                WriteDatabase(playerScore, this.name);
                EndGameReset();
            }
            if (gameBallLeft >= myGameCanvas.Width - gameBall.Width)
            {
                horizDirection *= -1;
            }
            if (gamePaddleLeft + gamePaddle.Width == gameBallLeft
                && gameBallTop + gameBall.Height / 2 >= gamePaddleTop && gameBallTop + gameBall.Height / 2 <= gamePaddleTop + gamePaddle.Height)
            {
                horizDirection = 1;
                playerScore += 5;
                tempScore = playerScore;
                scoreCounter.Text = playerScore.ToString();
            }

            if (tempScore == 10 || tempScore == 20 || tempScore == 30 )
            {
                    gamePaddle.Height -= 4;
                    dx += 1;
                    dy += 1;
                    gamePaddleDy += 2;
                    tempScore = 0;
                
            }
            if (tempScore >= 30 && gamePaddle.Height > 6)
            {
                gamePaddle.Height -= 4;
                tempScore = 0;
            }
    
            
            gameBallLeft += dx * horizDirection;
            gameBallTop += dy * vertDirection;

            Canvas.SetTop(gameBall, gameBallTop);
            Canvas.SetLeft(gameBall, gameBallLeft);

        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Up)
            {
                if (gamePaddleTop - gamePaddleDy >= 0)
                    gamePaddleTop -= gamePaddleDy;
            }
            else if (e.Key == Key.Down)
            {
                if (gamePaddleTop + gamePaddleDy + gamePaddle.Height <= myGameCanvas.Height)
                    gamePaddleTop += gamePaddleDy;
            }
            Canvas.SetTop(gamePaddle, gamePaddleTop);
        }

        private static void WriteDatabase(int score, String name)
        {

            // We use these three SQLite objects:
            SQLiteConnection sqlite_conn;
            SQLiteCommand cmd;
            SQLiteDataReader sqlite_datareader;
            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=pongScores.db;Version=3;New=True;Compress=True;");
            int count = 0;
            String scorePrint = "";
            String highScoreMsg = "New High Score";
            String notHighScoreMsg = "Not A High Score";

            bool highScore = true;

            // open the connection:
            sqlite_conn.Open();

            // create a new SQL command:
            cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            cmd.CommandText = "CREATE TABLE if not exists pongScoresDB  (score integer, name varchar(100), place integer);";

            // Now lets execute the SQL ;D
            cmd.ExecuteNonQuery();

            // Lets insert something into our new table:
            cmd.CommandText = "INSERT INTO pongScoresDB (score, name) VALUES ('" + score + "', '" + name + "')";

            // And execute this again ;D
            cmd.ExecuteNonQuery();

            // But how do we read something out of our table ?
            // First lets build a SQL-Query again:
            cmd.CommandText = "SELECT * FROM pongScoresDB ORDER BY score DESC";

            // Now the SQLiteCommand object can give us a DataReader-Object:
            sqlite_datareader = cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through the result lines:
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                count++;
                if (count <= 10) // Read() returns true if there is still a result line to read
                {
                    // Print out the content of the text field:
                    scorePrint += (count + ":\t" + sqlite_datareader["name"] + "\t\t" + sqlite_datareader["score"] + "\n");
                }
                    if (score.CompareTo(Convert.ToInt32(sqlite_datareader["score"])) < 0)
                    {
                        highScore = false;
                    }  
            }
            notHighScoreMsg += " your in " + count + " place";

            if (highScore == true)
            {
                MessageBox.Show(scorePrint + "\n" + highScoreMsg);
            }
            else
            {
                MessageBox.Show(scorePrint + "\n" + notHighScoreMsg);
            }
            

            // We are ready, now lets cleanup and close our connection:
            sqlite_conn.Close();
        }

        private void BtnStartGame_Click(object sender, RoutedEventArgs e)
        {
            if (gameStoped == true)
            {
                gameStoped = false;
                gameTimer.Start();

            }
            
        }

        private void BtnStopGame_Click(object sender, RoutedEventArgs e)
        {
            if (gameStoped == false)
            {
                gameStoped = true;
                gameTimer.Stop();

            }
        }

        private void EndGameReset() {
            
            gameBallTop = 0;
            gameBallLeft = 0;
            this.gameWindowPopup = new EndGameWindow(name);
            this.gameWindowPopup.ShowDialog();
            
        }

        private void BtnResetGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.gameWindow = new GameWindow(name);
            this.gameWindow.ShowDialog();
        }

        private void btnHomeGame_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.homeWindow = new MainWindow();
            this.homeWindow.ShowDialog();
        }
    }
}
