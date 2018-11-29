using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMIkadai
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class BmiResult : ContentPage
	{
        private float height;

        private float weight;


        // 引数のないコンストラクタ

        public BmiResult()

        {

            InitializeComponent();

            buttonBack.Clicked += buttonBackClicked;

        }



        // 引数のあるコンストラクタ

        public BmiResult(float height,float weight)

        {

            InitializeComponent();

            this.height = height;

            if (height > 10)
            {
                height = height / 100;
            }

            this.weight = weight;

            height = height * height;

            weight = weight / height;


            labelBMI.Text = "BMI=" + weight;

            buttonBack.Clicked += buttonBackClicked;

        }



        // 前のページに戻るボタンの処理

        private void buttonBackClicked(object sender, EventArgs e)

        {

            Navigation.PopModalAsync();

        }
    }
}