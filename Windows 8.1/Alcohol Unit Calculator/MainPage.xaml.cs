using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Alcohol_Unit_Calculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        int recommendmen = 21;
        int reccomendwomen = 14;

        public MainPage()
        {
            this.InitializeComponent();
           
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

      
        }

        private void numbertext_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            
            
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {

            if (!isValid(a.Text))
            {

                var messageDialog2 = new MessageDialog("Please enter a value");
                await messageDialog2.ShowAsync();

            }

            else if (!isValid(b.Text))
            {

                var messageDialog2 = new MessageDialog("Please enter a value");
                await messageDialog2.ShowAsync();

            }

            else if (!isValid(c.Text))
            {

                var messageDialog2 = new MessageDialog("Please enter a value");
                await messageDialog2.ShowAsync();

            }

            else if (!isValid(d.Text))
            {

                var messageDialog2 = new MessageDialog("Please enter a value");
                await messageDialog2.ShowAsync();

            }

            else if (!isValid(z.Text))
            {

                var messageDialog2 = new MessageDialog("Please enter a value");
                await messageDialog2.ShowAsync();

            }

            else
            {
                try
                {



                    int apint = 2;
                    int awine = 3;
                    int aspirit = 1;
                    int adspirit = 2;
                    int aalcopop = 2;


                    int npint = Convert.ToInt32(pint.Text);
                    int nwine = Convert.ToInt32(wine.Text);
                    int nsspirit = Convert.ToInt32(sspirit.Text);
                    int ndspirit = Convert.ToInt32(dspirit.Text);
                    int nalcopop = Convert.ToInt32(alcopop.Text);

                    int tpint = apint * npint;
                    int twine = awine * nwine;
                    int taspirit = aspirit * nsspirit;
                    int tdspirit = adspirit * ndspirit;
                    int talcopop = aalcopop * nalcopop;

                    int total = tpint + twine + taspirit + tdspirit + talcopop;
                    result.Text = total.ToString();


                    if (total > recommendmen)
                    {

                        int diff = total - recommendmen;
                        var messageDialog2 = new MessageDialog("You are" + " " + diff + " " + "units over the limit for a man for a week");
                        await messageDialog2.ShowAsync();


                    }

                    else if (total > reccomendwomen)
                    {

                        int diff = total - reccomendwomen;
                        var messageDialog3 = new MessageDialog("You are" + " " + diff + " " + "units over the limit for a woman for a week");
                        await messageDialog3.ShowAsync();

                    }

                    

                }



                catch (Exception ex)
                {

                    message_user("Please enter a valid value");

                }




            }
        }

         private async void message_user(string message)
        {

            var messageDialog4 = new MessageDialog(message);
            await messageDialog4.ShowAsync();

        }
          private Boolean isValid(string doofer)
        {
            if (doofer == "")
            {
                return false;
            }

            else

                return true;

        }
    }
}
