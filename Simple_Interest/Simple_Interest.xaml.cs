using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Simple_Interest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Simple_Interest : ContentPage
    {
       
        public Simple_Interest()
        {
            InitializeComponent();
        }
        public void addCalculate(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(Principle_Amount.Text) && !string.IsNullOrWhiteSpace(No_Of_Years.Text) && !string.IsNullOrWhiteSpace(Rate_Of_Interest.Text))
                {
                    Interest_Amount.Text = ((Convert.ToDouble(Principle_Amount.Text) * Convert.ToDouble(No_Of_Years.Text) * Convert.ToDouble(Rate_Of_Interest.Text)) / 100).ToString();
                    Total_Amount.Text = (Convert.ToDouble(Interest_Amount.Text) + Convert.ToDouble(Principle_Amount.Text)).ToString();
                }
                else
                {
                    DisplayAlert("Alert", "Please fill in all fields...", "OK");
                }
                
            }
            catch(Exception exe)
            {

            }
        }
        public void btnCancel(object sender, EventArgs e)
        {
            Principle_Amount.Text = "";
            No_Of_Years.Text = "";
            Rate_Of_Interest.Text = "";
            Interest_Amount.Text = "";
            Total_Amount.Text = "";
        }
    }
}