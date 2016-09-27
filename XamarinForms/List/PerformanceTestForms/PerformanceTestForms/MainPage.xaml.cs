using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PerformanceTestForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            LoadList();
        }

        private void LoadList()
        {
            List<ImageItem> itemList = new List<ImageItem>();

            for (int i = 1; i <= 12; i++)
            {
                itemList.Add(new ImageItem(string.Format("https://portalstoragewuprod.azureedge.net/vision/Analysis/{0}-1.jpg",i)));
            }

            this.ImageList.ItemsSource = itemList;
        }
    }

    public class ImageItem
    {
        public ImageItem(string url)
        {
            Url = url;
        }

        public string Url { get; set; }
    }
}
