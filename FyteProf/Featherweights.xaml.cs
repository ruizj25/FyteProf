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
using System.Windows.Shapes;


namespace FyteProf
{
    /// <summary>
    /// Interaction logic for Featherweights.xaml
    /// </summary>
    public partial class Featherweights : Window
    {
      
        public Featherweights(MainWindow mainWindow)
        {
            InitializeComponent();
            List<FighterClass> feathers = new List<FighterClass>
            {
                new FighterClass() { Rank = 1, Name = "Max Holloway", Win = 19, Loss = 4, Knockouts = 9, Submissions = 2 },
                new FighterClass() { Rank = 2, Name = "Brian Ortega", Win = 14, Loss = 0, Knockouts = 3, Submissions = 7 },
                new FighterClass() { Rank = 3, Name = "Frankie Edgar", Win = 22, Loss = 6, Knockouts = 7, Submissions = 4 },
                new FighterClass() { Rank = 4, Name = "Cub Swanson", Win = 25, Loss = 8, Knockouts = 8, Submissions = 7 },
                new FighterClass() { Rank = 5, Name = "Jeremy Stephens", Win = 28, Loss = 14, Knockouts = 18, Submissions = 3 },
                new FighterClass() { Rank = 6, Name = "Josh Emmett", Win = 13, Loss = 2, Knockouts = 4, Submissions = 2 },
                new FighterClass() { Rank = 7, Name = "Ricardo Lamas", Win = 18, Loss = 6, Knockouts = 5, Submissions = 5 },
                new FighterClass() { Rank = 8, Name = "Chang Sung Jung", Win = 14, Loss = 4, Knockouts = 4, Submissions = 8 },
                new FighterClass() { Rank = 9, Name = "Darren Elkins", Win = 24, Loss = 5, Knockouts = 8, Submissions = 4 },
                new FighterClass() { Rank = 10, Name = "Yair Rodriguez", Win = 10, Loss = 2, Knockouts = 3, Submissions = 2 }
            };

            FighterSelect.ItemsSource = feathers;
            FighterSelect.DisplayMemberPath = "Name";


            FighterSelect1.ItemsSource = feathers;
            FighterSelect1.DisplayMemberPath = "Name";
            

        }

        private void FighterSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FighterClass feathers = FighterSelect.SelectedItem as FighterClass;
            FighterInfoBox.Text = "Wins " + Convert.ToString(feathers.Win) + " Loss " + Convert.ToString(feathers.Loss);
            FinishBox.Text = " KOs " + Convert.ToString(feathers.Knockouts) + " Subs " + Convert.ToString(feathers.Submissions);
            RankBox.Text = Convert.ToString(feathers.Rank);
            ScoreBox.Text = Convert.ToString(feathers.FightScore);
        }

        private void FighterSelect1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FighterClass feathers1 = FighterSelect1.SelectedItem as FighterClass;
            FighterInfoBox1.Text = "Wins " + Convert.ToString(feathers1.Win) + " Loss " + Convert.ToString(feathers1.Loss);
            FinishBox1.Text = " KOs " + Convert.ToString(feathers1.Knockouts) + " Subs " + Convert.ToString(feathers1.Submissions);
            RankBox1.Text = Convert.ToString(feathers1.Rank);
            ScoreBox1.Text = Convert.ToString(feathers1.FightScore);
        }

        private void rankBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)

        {

        }
        private void MainWinButton_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void MainWinButton_Click_1(object sender, RoutedEventArgs e)
        {

            this.Close();

        }

        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var feather = FighterSelect.SelectedItem as FighterClass;
                var feather1 = FighterSelect1.SelectedItem as FighterClass;
                bool firstFighterNotSelected = feather == null;
                bool secondFighterNotSelected = feather1 == null;
                bool sameFighterSelected = (feather == feather1);

                void Fighter1NotSelected()
                {
                    RankBox.Background = Brushes.Pink;
                    RankLabel.Foreground = Brushes.Red;
                    FighterInfoBox.Background = Brushes.Pink;
                    RecordLabel.Foreground = Brushes.Red;
                    FinishBox.Background = Brushes.Pink;
                    FinLabel.Foreground = Brushes.Red;
                    ScoreBox.Background = Brushes.Pink;
                    ScoreLabel.Foreground = Brushes.Red;
                    ScoreBox.Text = string.Empty;
                }

                void Fighter2NotSelected()
                {
                    FighterInfoBox1.Background = Brushes.Pink;
                    RankBox1.Background = Brushes.Pink;
                    ScoreBox1.Background = Brushes.Pink;
                    FinishBox1.Background = Brushes.Pink;
                    FinLabel1.Foreground = Brushes.Red;
                    RankLabel1.Foreground = Brushes.Red;
                    RecordLabel1.Foreground = Brushes.Red;
                    ScoreLabel1.Foreground = Brushes.Red;
                    ScoreBox1.Text = string.Empty;
                    
                }

            if (firstFighterNotSelected || secondFighterNotSelected)
            {

                bool case1 = firstFighterNotSelected;
                bool case2 = secondFighterNotSelected;

                if (case1)
                {
                    Fighter1NotSelected();
                }

                if (case2)
                {
                    Fighter2NotSelected();
                }

                MessageBox.Show("You Need To Select A Fighter");
                return;

            }
            else
            {
                RankBox.Background = Brushes.White;
                RankLabel.Foreground = Brushes.Black;
                FighterInfoBox.Background = Brushes.White;
                RecordLabel.Foreground = Brushes.Black;
                FinishBox.Background = Brushes.White;
                FinLabel.Foreground = Brushes.Black;
                ScoreBox.Background = Brushes.White;
                ScoreLabel.Foreground = Brushes.Black;

                RankBox1.Background = Brushes.White;
                RankLabel1.Foreground = Brushes.Black;
                FighterInfoBox1.Background = Brushes.White;
                RecordLabel1.Foreground = Brushes.Black;
                FinishBox1.Background = Brushes.White;
                FinLabel1.Foreground = Brushes.Black;
                ScoreBox1.Background = Brushes.White;
                ScoreLabel1.Foreground = Brushes.Black;
            }


            if (sameFighterSelected)
            {
                Fighter2NotSelected();
                MessageBox.Show("You Can't Compare the same Fighter");
                return;
            }
                string FightResult()
                {
                    int totalPoints = (int)(feather1.FightScore + feather.FightScore);
                    int result1 = (int)(feather.FightScore * 100 / totalPoints);
                    int result2 = (int)(feather1.FightScore * 100 / totalPoints);
                    if (result1 > result2)
                    {

                        return feather.Name + " Is " + 
                               Convert.ToString(result1 - result2) + "% More Likely To Win";

                    }
                    else if (result2 > result1)
                    {
                        return feather1.Name + " Is " +
                               Convert.ToString(result2 - result1) + "% More Likely";
                    }
                    else
                    {
                        return feather.Name + " & " + feather1.Name + " Are Evenly Matched, It Could Go Either Way! ";
                    }
                }

                var messageText = FightResult();
                System.Windows.Forms.MessageBox.Show(messageText);
            }
            catch (NullReferenceException)

            {

            }
        }
    }
}
