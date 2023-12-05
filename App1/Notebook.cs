public class Notebook : INotifyPropertyChanged
{
    private string brand;
    private int memory;
    private string color;
    private string processor;

    public string Brand
    {
        get => brand;
        set
        {
            brand = value;
            OnPropertyChanged(nameof(Brand));
        }
    }

    public int Memory
    {
        get => memory;
        set
        {
            memory = value;
            OnPropertyChanged(nameof(Memory));
        }
    }

    public string Color
    {
        get => color;
        set
        {
            color = value;
            OnPropertyChanged(nameof(Color));
        }
    }

    public string Processor
    {
        get => processor;
        set
        {
            processor = value;
            OnPropertyChanged(nameof(Processor));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
