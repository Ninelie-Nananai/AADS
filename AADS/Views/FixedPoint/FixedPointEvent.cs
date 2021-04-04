using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AADS.Views.FixedPoint
{
    public delegate void FixedPointChanged(FixedPointEventArgs e);
    public class FixedPointEventArgs : EventArgs
    {
        public string LatLng { get; set; }
    }
    public class FixedPointEvent
    {
        private static FixedPointEvent _Instance;
        public static FixedPointEvent Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new FixedPointEvent();
                }
                return _Instance;
            }
        }


        public event FixedPointChanged onFixedPointChanged;
        public void InvokeFixedPointChanged(FixedPointEventArgs args)
        {
            onFixedPointChanged.Invoke(args);
        }
    }
}
