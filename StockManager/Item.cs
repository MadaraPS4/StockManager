using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockManager
{
    class Item: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private int amount;
        private string company;


        public string Имя
        {
            get { return name; }
            set
            {
                name = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Имя"));
            }
        }
        public int Количество
        {
            get { return amount; }
            set
            {
                amount = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Количество"));
            }
        }
        public string Компания
        {
            get { return company; }
            set
            {
                company = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("Компания"));
            }
        }

    }
}

