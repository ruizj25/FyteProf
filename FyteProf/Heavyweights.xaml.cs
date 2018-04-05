using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;
using System.Windows.Forms;


namespace FyteProf
{
    using System.Globalization;
    using Brushes = System.Windows.Media.Brushes;
    using MessageBox = System.Windows.Forms.MessageBox;

    /// <summary>
    /// Interaction logic for Heavyweights.xaml
    /// </summary>
    public partial class Heavyweights : Window
    {
      

        public Heavyweights(MainWindow mainWindow)
        {
            InitializeComponent();
           List<FighterClass> heavys = new List<FighterClass>
            {
                new FighterClass
                {
                    Rank = 1,
                    Name = "Stipe Miocic",
                    Win = 18,
                    Loss = 2,
                    Knockouts = 13,
                    Submissions = 1
                },
                new FighterClass
                {
                    Rank = 2,
                    Name = "Francis Ngannou",
                    Win = 11,
                    Loss = 2,
                    Knockouts = 7,
                    Submissions = 4
                },
                new FighterClass
                {
                    Rank = 3,
                    Name = "Allistar Overeem",
                    Win = 43,
                    Loss = 16,
                    Knockouts = 19,
                    Submissions = 19
                },
                new FighterClass
                {
                    Rank = 4,
                    Name = "Fabricio Werdum",
                    Win = 23,
                    Loss = 7,
                    Knockouts = 6,
                    Submissions = 11
                },
                new FighterClass
                {
                    Rank = 5,
                    Name = "Cain Velasquez",
                    Win = 14,
                    Loss = 2,
                    Knockouts = 12,
                    Submissions = 0
                },
                new FighterClass
                {
                    Rank = 6,
                    Name = "Curtis Blaydes",
                    Win = 9,
                    Loss = 1,
                    Knockouts = 7,
                    Submissions = 0
                },
                new FighterClass {Rank = 7, Name = "Mark Hunt", Win = 13, Loss = 12, Knockouts = 10, Submissions = 0},
                new FighterClass
                {
                    Rank = 8,
                    Name = "Derrick Lewis",
                    Win = 19,
                    Loss = 5,
                    Knockouts = 17,
                    Submissions = 1
                },
                new FighterClass
                {
                    Rank = 9,
                    Name = "Alexander Volkov",
                    Win = 30,
                    Loss = 6,
                    Knockouts = 20,
                    Submissions = 3
                },
                new FighterClass
                {
                    Rank = 10,
                    Name = "Marcin Tybura",
                    Win = 16,
                    Loss = 4,
                    Knockouts = 7,
                    Submissions = 6
                },

            };


            FighterSelect.ItemsSource = heavys;
            FighterSelect.DisplayMemberPath = "Name";


            FighterSelect1.ItemsSource = heavys;
            FighterSelect1.DisplayMemberPath = "Name";


        }



        private void FighterSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            FighterClass heavy = FighterSelect.SelectedItem as FighterClass;
            FighterInfoBox.Text = "Wins " + Convert.ToString(heavy.Win) + " Loss " + Convert.ToString(heavy.Loss);
            FinishBox.Text = " KOs " + Convert.ToString(heavy.Knockouts) + " Subs " +
                             Convert.ToString(heavy.Submissions);
            RankBox.Text = Convert.ToString(heavy.Rank);
            ScoreBox.Text = Convert.ToString(heavy.FightScore);


            //FighterSelect.SelectedItem = FighterSelect1.SelectedItem;
        }

        private void FighterSelect1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            FighterClass heavy1 = FighterSelect1.SelectedItem as FighterClass;
            FighterInfoBox1.Text = "Wins " + Convert.ToString(heavy1.Win) + " Loss " + Convert.ToString(heavy1.Loss);
            FinishBox1.Text = " KOs " + Convert.ToString(heavy1.Knockouts) + " Subs " +
                              Convert.ToString(heavy1.Submissions);
            RankBox1.Text = Convert.ToString(heavy1.Rank);
            ScoreBox1.Text = Convert.ToString(heavy1.FightScore);
            //FighterSelect1.SelectedItem = FighterSelect.SelectedItem;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void rankBox1_TextChanged(object sender, TextChangedEventArgs e)
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
                var heavy = FighterSelect.SelectedItem as FighterClass;
                var heavy1 = FighterSelect1.SelectedItem as FighterClass;
                bool firstFighterNotSelected = heavy == null;
                bool secondFighterNotSelected = heavy1 == null;
                bool sameFighterSelected = (heavy == heavy1);

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
                    int totalPoints = (int) (heavy1.FightScore + heavy.FightScore);
                    int result1 = (int) (heavy.FightScore * 100 / totalPoints);
                    int result2 = (int) (heavy1.FightScore * 100 / totalPoints);
                    if (result1 > result2)
                    {

                        return heavy.Name + " Is " + Convert.ToString(result1 - result2, CultureInfo.InvariantCulture) + "% More Likely To Win";

                    }
                    else if (result2 > result1)
                    {
                        return heavy1.Name + " Is " +
                               Convert.ToString(result2 - result1, CultureInfo.InvariantCulture) + "% More Likely To Win";
                    }
                    else
                    {
                        return heavy.Name + " & " + heavy1.Name + " Are Evenly Matched, It Could Go Either Way! ";}
                }

                





                var messageText = FightResult();
                System.Windows.Forms.MessageBox.Show(messageText);
            }
            catch (NullReferenceException)
            { }
        }

    }

}
