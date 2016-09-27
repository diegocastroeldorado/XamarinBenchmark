using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Util;

namespace PerformanceTest
{
    [Activity(Label = "PerformanceTest", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        string[] itemname ={
            "Image1",
            "Image2",
            "Image3",
            "Image4",
            "Image5",
            "Image6",
            "Image7",
            "Image8",
            "Image9",
            "Image10",
            "Image11",
            "Image12",
    };

        string[] itemImage ={
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/1-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/2-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/3-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/4-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/5-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/6-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/7-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/8-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/9-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/10-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/11-1.jpg",
            "https://portalstoragewuprod.azureedge.net/vision/Analysis/12-1.jpg",
    };

        ListView list;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);   

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            CustomListAdapter adapter = new CustomListAdapter(this, 0, itemname, itemImage);
            list = (ListView)FindViewById(Resource.Id.list);
            list.Adapter = adapter;
        }
    }
}

