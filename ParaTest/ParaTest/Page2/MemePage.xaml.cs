using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParaTest.Page2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MemePage : ContentPage
    {
       // public MemeViewModel memeVM = new MemeViewModel();
        public MemePage()
        {
            InitializeComponent();
          //  BindingContext = memeVM;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //await memeVM.ChangeColor();
        }
    }
}