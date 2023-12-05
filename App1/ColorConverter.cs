using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;
using Windows.UI;

public class ColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        var colorName = value.ToString().ToLower();

        switch (colorName)
        {
            case "piros":
                return new SolidColorBrush(Colors.Red);
            case "kék":
                return new SolidColorBrush(Colors.Blue);
            case "zöld":
                return new SolidColorBrush(Colors.Green);
            case "sárga":
                return new SolidColorBrush(Colors.Yellow);
            default:
                return new SolidColorBrush(Colors.Black);
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        // Nem szükséges a ConvertBack implementációja a feladatban
        throw new NotImplementedException();
    }
}
