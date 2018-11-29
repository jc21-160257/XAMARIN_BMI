using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMIkadai
{
    public partial class MainPage2 : ContentPage

    {

        public MainPage2()

        {

            InitializeComponent();

            ButtonBMI.Clicked += ButtonClickEvent;

            ButtonBMI2.Clicked += ButtonClickEvent2;

        }



        private void ButtonClickEvent2(object sender, EventArgs e)

        {

            float height = float.Parse(EntryHeight.Text);

            float weight = float.Parse(EntryWeight.Text);

            Navigation.PushModalAsync(new NavigationPage(new BmiResult(height,weight)));

        }



        private void ButtonClickEvent(object sender, EventArgs e)

        {

            float height = float.Parse(EntryHeight.Text);

            if (height > 10)
            {
                height = height / 100;
            }

            height = height * height;



            float weight = int.Parse(EntryWeight.Text);

            weight = weight / height;



            LabelResult.Text = "BMI=" + weight;



        }

    }
}