using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace lab7visual.Models
{
    public class Avg : INotifyPropertyChanged
    {
        string score;
        string color;
        public event PropertyChangedEventHandler PropertyChanged;

        public Avg()
        {
            score = "0";
            color = "brown";
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Score
        {
            get => score;
            set
            {
                score = value;
                try
                {
                    if (Convert.ToDouble(score) < 1)
                        Color = "brown";
                    else if (Convert.ToDouble(score) < 1.5)
                        Color = "DarkOrange";
                    else
                        Color = "LightGreen";
                    NotifyPropertyChanged();
                }
                catch
                {

                }
            }
        }

        public string Color
        {
            get => color;
            set
            {
                color = value;
                NotifyPropertyChanged();
            }
        }
    }
}
