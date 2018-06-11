using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ListViewApp
{
    public class Car
    {
        public int picture { get; set; }
        public string maker { get; set; }
        public string model { get; set; }
        public string kw { get; set; }
    }
}