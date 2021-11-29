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
using System.ComponentModel;
using System.Diagnostics;

namespace Setting_Profiles
{

    public partial class MainWindow : Window
    {
        GameSettings[] profileArray = new GameSettings[4];
        public int current_Profile = 0;


        public MainWindow()
        {

            for (int i = 0; i < profileArray.Length; i++)
            {
                profileArray[i] = new GameSettings();
                profileArray[i].Points = "0";
                profileArray[i].Codsworth = " ";
                profileArray[i].Difficulty = "Easy";
                profileArray[i].Special = "Strength";
            }

            Debug.WriteLine(current_Profile);
            InitializeComponent();

            DataContext = profileArray[current_Profile];

        }

        #region ProfileButtons
        public void ProfileButtonClicked(Object sender, RoutedEventArgs e)
        {
            if (sender == Profile_1)
            {

                StartScreen2_Img.Height = 0;
                StartScreen2_Img.Width = 0;
                current_Profile = 0;
                setRadioValue();
                setcheckBox();
                setComboBox();
                setCodsworth();
                setSliderValue();

                //Debug.WriteLine(profile_Checked);
            }
            else if (sender == Profile_2)
            {
                StartScreen2_Img.Height = 0;
                StartScreen2_Img.Width = 0;
                current_Profile = 1;
                setRadioValue();
                setcheckBox();
                setComboBox();
                setCodsworth();
                setSliderValue();

                //Debug.WriteLine("got here 2");
            }
            else if (sender == Profile_3)
            {
                StartScreen2_Img.Height = 0;
                StartScreen2_Img.Width = 0;
                current_Profile = 2;
                setRadioValue();
                setcheckBox();
                setComboBox();
                setCodsworth();
                setSliderValue();
                //Debug.WriteLine("got here 3");
            }
            else if (sender == Profile_4)
            {
                StartScreen2_Img.Height = 0;
                StartScreen2_Img.Width = 0;
                current_Profile = 3;
                setRadioValue();
                setcheckBox();
                setComboBox();
                setCodsworth();  //sets the image if Codsworth is enabled
                setSliderValue();
                //Debug.WriteLine("got here 4");
            }
        }
        #endregion

        #region Codsworth
        public void CodsworthButtonClicked(Object sender, RoutedEventArgs e)
        {
            if (CodsworthButton.IsChecked == true)
            {
                profileArray[current_Profile].Codsworth = "Codsworth";
                Codsworth_Img.Opacity = 100;
            }
            else
            {
                profileArray[current_Profile].Codsworth = " ";
                Codsworth_Img.Opacity = 0;
            }
        }

        public void setCodsworth()
        {
            if (CodsworthButton.IsChecked == true)
            {
                Codsworth_Img.Opacity = 100;
            }
            else
            {
                Codsworth_Img.Opacity = 0;
            }

        }

        public void setcheckBox()
        {
            if (profileArray[current_Profile].Codsworth == "Codsworth")
            {
                CodsworthButton.IsChecked = true;
            }
            else
            {
                CodsworthButton.IsChecked = false;
            }
        }

        #endregion

        #region RadionButtons
        public void setRadioValue()
        {
            if (profileArray[current_Profile].Difficulty == "Easy")
            {
                Easy.IsChecked = true;
            }
            else if (profileArray[current_Profile].Difficulty == "Medium")
            {
                Medium.IsChecked = true;
            }
            else if (profileArray[current_Profile].Difficulty == "Hard")
            {
                Hard.IsChecked = true;
            }
        }

        public void RadioButtonClicked(Object sender, RoutedEventArgs e)
        {
            if (sender == Easy)
            {
                Debug.WriteLine(current_Profile);

                for (int i = 0; i < profileArray.Length; i++)
                {
                    if (i == current_Profile)
                    {
                        profileArray[i].Difficulty = "Easy";

                    }
                }

            }
            else if (sender == Medium)
            {
                for (int i = 0; i < profileArray.Length; i++)
                {
                    if (i == current_Profile)
                    {
                        profileArray[i].Difficulty = "Medium";
                    }
                }

            }
            else if (sender == Hard)
            {
                for (int i = 0; i < profileArray.Length; i++)
                {
                    if (i == current_Profile)
                    {
                        profileArray[i].Difficulty = "Hard";
                    }
                }
            }
        }
        #endregion

        #region ComboBox
        private void ComboBox_Clicked(object sender, RoutedEventArgs e)
        {

            if (sender == Strength && Strength.IsSelected == true)
            {
                profileArray[current_Profile].Special = "Strength";
            }
            else if (sender == Perception && Perception.IsSelected == true)
            {
                profileArray[current_Profile].Special = "Perception";
            }
            else if (sender == Endurance && Endurance.IsSelected == true)
            {
                profileArray[current_Profile].Special = "Endurance";
            }
            else if (sender == Charisma && Charisma.IsSelected == true)
            {
                profileArray[current_Profile].Special = "Charisma";
            }
            else if (sender == Intelligence && Intelligence.IsSelected == true)
            {
                profileArray[current_Profile].Special = "Intelligence";
            }
            else if (sender == Agility && Agility.IsSelected == true)
            {
                profileArray[current_Profile].Special = "Agility";
            }
            else if (sender == Luck && Luck.IsSelected == true)
            {
                profileArray[current_Profile].Special = "Luck";
            }
            else
            {
                Debug.WriteLine("You didn't choose...");
            }

        }

        private void setComboBox()
        {
            if (profileArray[current_Profile].Special == "Strength")
            {
                Strength.IsSelected = true;
            }
            else if (profileArray[current_Profile].Special == "Perception")
            {
                Perception.IsSelected = true;
            }
            else if (profileArray[current_Profile].Special == "Endurance")
            {
                Endurance.IsSelected = true;
            }
            else if (profileArray[current_Profile].Special == "Charisma")
            {
                Charisma.IsSelected = true;
            }
            else if (profileArray[current_Profile].Special == "Intelligence")
            {
                Intelligence.IsSelected = true;
            }
            else if (profileArray[current_Profile].Special == "Agility")
            {
                Agility.IsSelected = true;
            }
            else if (profileArray[current_Profile].Special == "Luck")
            {
                Luck.IsSelected = true;
            }

        }

        #endregion

        #region Slider
        public void setSliderValue()
        {
            slider.Value = double.Parse(profileArray[current_Profile].Points);
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            profileArray[current_Profile].Points = slider.Value.ToString();
        }
        #endregion

    }
        #region GameSetting Class
        public class GameSettings : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;

            private string points;
            private string difficulty;
            private string special;
            private string codsworth;

            public string Points
            {
                get { return points; }
                set
                {
                    points = value;
                    updateUI("Points");
                }
            }
            public string Difficulty
            {
                get { return difficulty; }
                set
                {
                    difficulty = value;
                    updateUI("Difficulty");
                }
            }
            public string Special
            {
                get { return special; }
                set
                {
                    special = value;
                    updateUI("Special");
                }
            }
            public string Codsworth
            {
                get { return codsworth; }
                set
                {
                    codsworth = value;
                    updateUI("Codsworth");
                }
            }

            public void updateUI(string property)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
            }


        }
        #endregion

}
