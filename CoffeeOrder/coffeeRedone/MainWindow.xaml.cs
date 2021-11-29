using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace CoffeeOrder
{
    /// <summary>

    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Coffee coffee_1 = new Coffee();

        public MainWindow()
        {
            
            InitializeComponent();
            DataContext = coffee_1;

        }


        public void AdjustOrder()
        {
           
            string entireOrder = " ";

            entireOrder =  coffee_1.Size + coffee_1.TypeofCoffee + coffee_1.Sugar + coffee_1.Cream;

            coffee_1.CoffeeOrder = entireOrder;

        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            if (sender == Small)
            {
                coffee_1.Size = " Small";
                Debug.WriteLine("Got here small");
                //coffeeOrder[0] = "Small";     
            }
            else if (sender == Medium)
            {
                coffee_1.Size = " Medium";
                //coffeeOrder[0] = "Medium";
            }
            else if (sender == Large)
            {
                coffee_1.Size = " Large";
                //coffeeOrder[0] = "Large";
            }
            else if (sender == Sugar && Sugar.IsChecked == true)
            {
                coffee_1.Sugar = " Sugar";
                //coffeeOrder[3] = " Sugar ";
            }
            else if (sender == Sugar && Sugar.IsChecked == false)
            {
                coffee_1.Sugar = " ";
                /// coffeeOrder[3] = " ";
            }
            else if (sender == Cream && Cream.IsChecked == true)
            {
                coffee_1.Cream = " Cream";
                // coffeeOrder[4] = " Cream ";
            }
            else if (sender == Cream && Cream.IsChecked == false)
            {
                coffee_1.Cream = " ";
                // coffeeOrder[4] = " ";
            }
            else if (sender == Latte && Latte.IsSelected == true)
            {
                coffee_1.TypeofCoffee = " Latte";
            }
            else if (sender == Capuccino && Capuccino.IsSelected == true)
            {
                coffee_1.TypeofCoffee = " Capuccino";
            }
            else if (sender == Americano && Americano.IsSelected == true)
            {
                coffee_1.TypeofCoffee = " Americano";
            }
            else if(sender == Espresso && Espresso.IsSelected == true)
            {
                coffee_1.TypeofCoffee = " Espresso";
            }
            else if (sender == PlaceOrder)
            {
                AdjustOrder();
                MessageBox.Show(coffee_1.CoffeeOrder);
            }
            AdjustOrder();
        }


    }
    public class Coffee: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string size;
        private string sugar;
        private string cream;
        private string typeofCoffee;
        private string coffeeOrder;

        public string Size
        {
            get { return size; }
            set
            {
                size = value;
                //updateUI("Size");
            }   //update the FullName property
        }
        public string Sugar
        {
            get { return sugar; }
            set
            {
                sugar = value;
                //updateUI("Sugar");
            }   //update the FullName property
        }
        public string Cream
        {
            get { return cream; }
            set
            {
                cream = value;
               // updateUI("Cream");
            }   //update the FullName property
        }
        public string TypeofCoffee
        {
            get { return typeofCoffee; }
            set
            {
                typeofCoffee = value;
                //updateUI( );
            }   //update the FullName property
        }

        public string CoffeeOrder
        {
            get { return coffeeOrder; }
            set
            {
                coffeeOrder = value;
                updateUI("CoffeeOrder");
            }   //update the FullName property
        }


        public void updateUI(string property)   ///will update everything if don't do string property = " "
        {
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property)); //doing the same as below

			/*
			//update ui with the new data
			if (PropertyChanged != null)  //used to prevent errors
			{
				PropertyChanged(this, new PropertyChangedEventArgs(property));  //send what delegate is asking
				//send the property you want to update in the user interface
			}
			*/
		}

    }
}


