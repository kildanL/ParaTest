using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParaTest.Page2
{
    class MemeViewModel: INotifyPropertyChanged
    {
        Color colorFrame;
        Random rnd = new Random();

        public Color ColorFrame
        {
            get => colorFrame;
            set
            {
                colorFrame = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public async Task ChangeColor()
        {
            await Task.Delay(500);
            ColorFrame = Color.FromRgb(rnd.Next(255), rnd.Next(255), rnd.Next(255));
        }
    }
}
