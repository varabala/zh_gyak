using System.Collections.ObjectModel;
using System.ComponentModel;
using Windows.UI.Xaml.Controls;

namespace UwpApp
{
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        private DataModel dataModel;

        public MainPage()
        {
            this.InitializeComponent();
            dataModel = new DataModel();
            // Teszt adatok inicializálása
            DataModel.Laptops.Add(new Notebook { Brand = "Toshiba", Memory = 8, Processor = "i5", Color = "Black" });
            // További Notebook objektumok hozzáadása a Laptops kollekcióhoz...
            this.DataContext = this;
        }

        public DataModel DataModel
        {
            get => dataModel;
            set
            {
                if (dataModel != value)
                {
                    dataModel = value;
                    OnPropertyChanged(nameof(DataModel));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
