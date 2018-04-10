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
    /// Interaction logic for Lightweights.xaml
    /// </summary>
    public partial class Lightweights : Window
    {
        public Lightweights(MainWindow mainWindow)
        {
            InitializeComponent();
            List<FighterClass> lights = new List<FighterClass>
            {
                new FighterClass() { Rank = 1, Name = "Conor McGregor", Win = 21, Loss = 3, Knockouts = 18, Submissions = 1 },
                new FighterClass() { Rank = 2, Name = "Tony Ferguson", Win = 23, Loss = 3, Knockouts = 9, Submissions = 9 },
                new FighterClass() { Rank = 3, Name = "Khabib Nurmagomedov", Win = 25, Loss = 0, Knockouts = 8, Submissions = 8 },
                new FighterClass() { Rank = 4, Name = "Eddie Alvarez", Win = 29, Loss = 5, Knockouts = 16, Submissions = 7 },
                new FighterClass() { Rank = 5, Name = "Edson Barboza", Win = 19, Loss = 5, Knockouts = 11, Submissions = 1 },
                new FighterClass() { Rank = 6, Name = "Dustin Porier", Win = 22, Loss = 5, Knockouts = 11, Submissions = 6 },
                new FighterClass() { Rank = 7, Name = "Justin Gaethje", Win = 18, Loss = 1, Knockouts = 15, Submissions = 1 },
                new FighterClass() { Rank = 8, Name = "Kevin Lee", Win = 16, Loss = 3, Knockouts = 1, Submissions = 8 },
                new FighterClass() { Rank = 9, Name = "Nate Diaz", Win = 19, Loss = 11, Knockouts = 4, Submissions = 13 },
                new FighterClass() { Rank = 10, Name = "Michael Chiesa", Win = 14, Loss = 3, Knockouts = 10, Submissions = 4 },
                new FighterClass() {Rank = 11, Name = "Al Iaquinta", Win = 13, Loss = 3, Knockouts = 7, Submissions = 1}
            };

            FighterSelect.ItemsSource = lights;
            FighterSelect.DisplayMemberPath = "Name";


            FighterSelect1.ItemsSource = lights;
            FighterSelect1.DisplayMemberPath = "Name";


        }

        private void FighterSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FighterClass lights = FighterSelect.SelectedItem as FighterClass;
            FighterInfoBox.Text = "Wins " + Convert.ToString(lights.Win) + " Loss " + Convert.ToString(lights.Loss);
            FinishBox.Text = "KOs " + Convert.ToString(lights.Knockouts) + "Subs " + Convert.ToString(lights.Submissions);
            RankBox.Text = Convert.ToString(lights.Rank);
            ScoreBox.Text = Convert.ToString(lights.FightScore);
        }

        private void FighterSelect1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            FighterClass lights1 = FighterSelect1.SelectedItem as FighterClass;
            FighterInfoBox1.Text = "Wins " + Convert.ToString(lights1.Win) + " Loss " + Convert.ToString(lights1.Loss);
            FinishBox1.Text = " KOs " + Convert.ToString(lights1.Knockouts) + " Subs " + Convert.ToString(lights1.Submissions);
            RankBox1.Text = Convert.ToString(lights1.Rank);
            ScoreBox1.Text = Convert.ToString(lights1.FightScore);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
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
                var light = FighterSelect.SelectedItem as FighterClass;
                var middle1 = FighterSelect1.SelectedItem as FighterClass;
                bool firstFighterNotSelected = light == null;
                bool secondFighterNotSelected = middle1 == null;
                bool sameFighterSelected = (light == middle1);

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
                    int totalPoints = (int)(middle1.FightScore + light.FightScore);
                    int result1 = (int)(light.FightScore * 100 / totalPoints);
                    int result2 = (int)(middle1.FightScore * 100 / totalPoints);
                    if (result1 > result2)
                    {

                        return light.Name + " Is " + Convert.ToString(result1 - result2) + "% More Likely To Win";

                    }
                    else if (result2 > result1)
                    {
                        return middle1.Name + " Is " +
                               Convert.ToString(result2 - result1) + "% More Likely To Win";
                    }
                    else
                    {
                        return light.Name + " & " + middle1.Name + " Are Evenly Matched, It Could Go Either Way! ";
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
    

