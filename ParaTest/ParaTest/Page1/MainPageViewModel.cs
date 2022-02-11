using ParaTest.Page2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ParaTest.Page1
{
    class MainPageViewModel:BindableObject
    {
        public MainPageViewModel()
        {
            IncreaseCount = new Command(OnIncrease);
        }
        int count;
        public ICommand IncreaseCount { get; }
        string countDisplay = "Кликни на меня!";


        public string CountDisplay
        {
            get => countDisplay;
            set
            {
                if (value == countDisplay)
                    return;
                countDisplay = value;
                OnPropertyChanged();
            }
        }

        void OnIncrease()
        {
            count++;
            CountDisplay = $"Ты кликнул {count} раз";
            if (count == 10)
            {
                Application.Current.MainPage.Navigation.PushAsync(new MemePage());
                count = 0;
            }
           
        }
    }
}
