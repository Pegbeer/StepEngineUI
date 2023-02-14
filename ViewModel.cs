using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StepEngineUI
{
    public class ViewModel : INotifyPropertyChanged
    {
        private int _contador;

        public int Contador
        {
            get { return _contador; }
            set
            {
                if(_contador!= value)
                {
                    _contador = value;
                    OnPropertyChanged(nameof(Contador));
                }
            }
        }



        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
