using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Collections.Generic;
using Android;

namespace ListViewApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : ListActivity
    {
        private List<Car> cars = new List<Car>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            ListView listView = FindViewById<ListView>(Resource.Id.listView1);

            cars.Add(new Car() { picture = Resource.Drawable.subaru, maker = "Subaru", model = "Impreza WRX/STI", kw = "254 KW" });
            cars.Add(new Car() { picture = Resource.Drawable.golf, maker = "Golf", model = "MK 2", kw = "103 KW" });
            cars.Add(new Car() { picture = Resource.Drawable.audi80, maker = "Audi", model = "80 Avant", kw = "144 KW" });
            cars.Add(new Car() { picture = Resource.Drawable.zonda, maker = "Zonda", model = "Zonda", kw = "270 KW" });
            cars.Add(new Car() { picture = Resource.Drawable.eleanor, maker = "Shelby", model = "GT500 1968", kw = "96 KW" });

            ListAdapter = new Adapter(this, cars);
            //SetContentView(Resource.Layout.activity_main);
        }
    }
}

