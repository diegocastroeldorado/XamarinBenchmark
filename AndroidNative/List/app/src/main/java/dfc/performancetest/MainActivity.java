package dfc.performancetest;

import android.app.Activity;
import android.app.ListActivity;
import android.os.SystemClock;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ArrayAdapter;
import android.util.Log;
import android.widget.ListView;

public class MainActivity extends AppCompatActivity {

    String[] itemname ={
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

    String[] itemImage ={
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

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        CustomListAdapter adapter=new CustomListAdapter(this, itemname, itemImage);
        list=(ListView)findViewById(R.id.list);
        list.setAdapter(adapter);
    }


}
