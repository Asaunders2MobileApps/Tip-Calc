using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lab4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        double total = 0;

        void Calculate_Total(object sender, System.EventArgs e)
        {
            var billAmount = Convert.ToDouble(iBill.Text);
            var tipPercent = Convert.ToDouble(iTip.Text)/100;
            oTip.Text = "Tip Amount $" + (billAmount * tipPercent).ToString();
            oBillAmount.Text = "Bill Total $" + ((billAmount * tipPercent) + billAmount).ToString();
        }
        public MainPage()
        {
            InitializeComponent();
        }
    }
}
