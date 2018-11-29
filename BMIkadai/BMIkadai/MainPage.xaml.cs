using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BMIkadai
{
    public partial class MainPage : ContentPage

    {

        // 最初のページのコンストラクタ

        public MainPage()

        {

            InitializeComponent();

            ButtonBMI.Clicked += ButtonClickEvent;

            ButtonBMI2.Clicked += ButtonClickEvent2;

        }





        // 新しいページを呼び出す処理

        private void ButtonClickEvent2(object sender, EventArgs e)

        {

            float height = float.Parse(EntryHeight.Text);


            float weight = float.Parse(EntryWeight.Text);

            Navigation.PushModalAsync(new NavigationPage(new BmiResult(height,weight)));

        }



        // 最初のページでBMIを表示する処理（実際の計算はしていない）

        private void ButtonClickEvent(object sender, EventArgs e)

        {

            float height = float.Parse(EntryHeight.Text);


            height = height * height;



            float weight = int.Parse(EntryWeight.Text);

            weight = weight / height;

            LabelResult.Text = "BMI=" + weight;


        }

    }
}
