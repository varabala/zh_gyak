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
            case "k�k":
                return new SolidColorBrush(Colors.Blue);
            case "z�ld":
                return new SolidColorBrush(Colors.Green);
            case "s�rga":
                return new SolidColorBrush(Colors.Yellow);
            default:
                return new SolidColorBrush(Colors.Black);
        }
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        // Nem sz�ks�ges a ConvertBack implement�ci�ja a feladatban
        throw new NotImplementedException();
    }
}
