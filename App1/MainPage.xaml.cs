using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    public sealed partial class MainPage : Page
{
    public DataModel DataModel { get; } = new DataModel();

    public MainPage()
    {
        this.InitializeComponent();
        // Teszt adatok hozzáadása a listához
        DataModel.Laptops.Add(new Notebook { Brand = "Dell", Memory = 16, Processor = "i7", Color = "Black" });
        // További notebookok hozzáadása...
    }
}

}
