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
    /// Interaction logic for Middleweights.xaml
    /// </summary>
    public partial class Middleweights : Window
    {
        

        public Middleweights(MainWindow mainWindow)
        {
            InitializeComponent();
            List<FighterClass> middles = new List<FighterClass>
            {
                new FighterClass() { Rank = 1, Name = "Robert Whittaker", Win = 19, Loss = 4, Knockouts = 9, Submissions = 5 },
                new FighterClass() { Rank = 2, Name = "Yoel Romero", Win = 13, Loss = 2, Knockouts = 11, Submissions = 2 },
                new FighterClass() { Rank = 3, Name = "Luke Rockhold", Win = 16, Loss = 4, Knockouts = 4, Submissions = 10 },
                new FighterClass() { Rank = 4, Name = "Ronaldo Souza", Win = 25, Loss = 5, Knockouts = 3, Submissions = 17 },
                new FighterClass() { Rank = 5, Name = "Chris Weidman", Win = 14, Loss = 3, Knockouts = 6, Submissions = 4 },
                new FighterClass() { Rank = 6, Name = "Kelvin Gastelum", Win = 14, Loss = 3, Knockouts = 7, Submissions = 3 },
                new FighterClass() { Rank = 7, Name = "Michael Bisping", Win = 30, Loss = 9, Knockouts = 16, Submissions = 4 },
                new FighterClass() { Rank = 8, Name = "Derek Brunson", Win = 18, Loss = 6, Knockouts = 10, Submissions = 4 },
                new FighterClass() { Rank = 9, Name = "David Branch", Win = 21, Loss = 4, Knockouts = 5, Submissions = 7 },
                new FighterClass() { Rank = 10, Name = "Uriah Hall", Win = 13, Loss = 8, Knockouts = 9, Submissions = 2 }
            };

            FighterSelect.ItemsSource = middles;
            FighterSelect.DisplayMemberPath = "Name";


            FighterSelect1.ItemsSource = middles;
            FighterSelect1.DisplayMemberPath = "Name";
            
         
        }

        private void FighterSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FighterClass middles = FighterSelect.SelectedItem as FighterClass;
            FighterInfoBox.Text = "Wins " + Convert.ToString(middles.Win) + " Loss " + Convert.ToString(middles.Loss);
            FinishBox.Text = "KOs " + Convert.ToString(middles.Knockouts) + "Subs " + Convert.ToString(middles.Submissions);
            RankBox.Text = Convert.ToString(middles.Rank);
            ScoreBox.Text = Convert.ToString(middles.FightScore);
        }

        private void FighterSelect1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FighterClass middles1 = FighterSelect1.SelectedItem as FighterClass;
            FighterInfoBox1.Text = "Wins " + Convert.ToString(middles1.Win) + " Loss " + Convert.ToString(middles1.Loss);
            FinishBox1.Text = " KOs " + Convert.ToString(middles1.Knockouts) + " Subs " + Convert.ToString(middles1.Submissions);
            RankBox1.Text = Convert.ToString(middles1.Rank);
            ScoreBox1.Text = Convert.ToString(middles1.FightScore);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FinishBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void FightButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var middle = FighterSelect.SelectedItem as FighterClass;
                var middle1 = FighterSelect1.SelectedItem as FighterClass;
                bool firstFighterNotSelected = middle == null;
                bool secondFighterNotSelected = middle1 == null;
                bool sameFighterSelected = (middle == middle1);

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


                    FighterInfoBox1.Background = Brushes.Pink;
                    RankBox1.Background = Brushes.Pink;
                    ScoreBox1.Background = Brushes.Pink;
                    FinishBox1.Background = Brushes.Pink;
                    FinLabel1.Foreground = Brushes.Red;
                    RankLabel1.Foreground = Brushes.Red;
                    RecordLabel1.Foreground = Brushes.Red;
                    ScoreLabel1.Foreground = Brushes.Red;
                    ScoreBox1.Text = string.Empty;
                    MessageBox.Show("You Can't Compare the same Fighter");
                    return;
                }


                String FightResult()
                {
                    int totalPoints = (int)(middle1.FightScore + middle.FightScore);
                    int result1 = (int)(middle.FightScore * 100 / totalPoints);
                    int result2 = (int)(middle1.FightScore * 100 / totalPoints);
                    if (result1 > result2)
                    {

                        return middle.Name + " Is " + Convert.ToString(result1 - result2) + "% More Likely To Win";

                    }
                    else if (result2 > result1)
                    {
                        return middle1.Name + " Is " +
                               Convert.ToString(result2 - result1) + "% More Likely To Win";
                    }
                    else
                    {
                        return middle.Name + " & " + middle1.Name + " Are Evenly Matched, It Could Go Either Way! ";
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
