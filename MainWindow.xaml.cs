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

namespace Lab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //defining few variables which i will use in calculation
        string Result = "";
        string arithmaticoperator = "";
        double outputvar1 = 0;
        double FinalResult = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        //the method to handle numeric inputs
        private void number(object sender, RoutedEventArgs e)
        {
            //taking the name of button in string and applying switch case as per name of button
            string numbutton = ((Button)sender).Name;
            switch(numbutton)
            {
                case "button0":
                    Result += "0";
                    break;
                case "button1":
                    Result += "1";
                    break;
                case "button2":
                    Result += "2";
                    break;
                case "button3":
                    Result += "3";
                    break;
                case "button4":
                    Result += "4";
                    break;
                case "button5":
                    Result += "5";
                    break;
                case "button6":
                    Result += "6";
                    break;
                case "button7":
                    Result += "7";
                    break;
                case "button8":
                    Result += "8";
                    break;
                case "button9":
                    Result += "9";
                    break;
                case "buttonclear":
                    Result = "";
                    break;

            }
            result.Text = Result;
        }
        //for subtraction
        private void Buttonminus(object sender, RoutedEventArgs e)
        {
            if(Result!="")
            {
                outputvar1 = double.Parse(Result);
                Result = "";
                arithmaticoperator = "-";
            }
            
        }
        //for addition
        private void Buttonplus(object sender, RoutedEventArgs e)
        {

            if (Result != "")
            {
                outputvar1 = double.Parse(Result);
                Result = "";
                arithmaticoperator = "+";
            }
        }
        //for multiplication
        private void Buttonmul(object sender, RoutedEventArgs e)
        {

            if (Result != "")
            {
                outputvar1 = double.Parse(Result);
                Result = "";
                arithmaticoperator = "*";
            }
        }
        //for division
        private void Buttondiv(object sender, RoutedEventArgs e)
        {

            if (Result != "")
            {

                outputvar1 = double.Parse(Result);
                Result = "";
                arithmaticoperator = "/";
            }
        }
        //when "=" is pressed i am applying switch case as per the operator pressed
        private void Buttonequal(object sender, RoutedEventArgs e)
        {
            switch(arithmaticoperator)
            {
                case "+":
                    FinalResult = outputvar1 + double.Parse(Result);
                    Result = FinalResult.ToString();
                    result.Text = Result;
                    break;
                case "-":
                    FinalResult = outputvar1 - double.Parse(Result) ;
                    Result = FinalResult.ToString();
                    result.Text = Result;
                    break;
                case "/":
                    //checking the divide by zero exception
                    if (double.Parse(Result) != 0)
                    {
                        FinalResult = outputvar1 / double.Parse(Result);
                        Result = FinalResult.ToString();
                        result.Text = Result;
                    }
                    break;  
                case "*":
                    FinalResult = outputvar1 * double.Parse(Result);
                    Result = FinalResult.ToString();
                    result.Text = Result;
                    break;
                
            }
        }
        
        
        
    }
}
