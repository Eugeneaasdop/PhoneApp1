using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace PhoneApp1
{
    public class PhoneViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Phone phone;
        public ICommand Increase { get; }

        public PhoneViewModel()
        {
            phone = new Phone();
            Increase = new Command(IncreasePrice);
        }

        public void IncreasePrice()
        {
            if (phone != null)
                Price += 100;
        }

        public string Title
        {
            get { return phone.Title; }
            set
            {
                if (phone.Title != value)
                {
                    phone.Title = value;
                    OnPropertyChanged("Title");
                }
            }
        }
        public string Company
        {
            get { return phone.Company; }
            set
            {
                if (phone.Company != value)
                {
                    phone.Company = value;
                    OnPropertyChanged("Company");
                }
            }
        }
        public int Price
        {
            get { return phone.Price; }
            set
            {
                if (phone.Price != value)
                {
                    phone.Price = value;
                    OnPropertyChanged("Price");
                }
            }
        }
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}
