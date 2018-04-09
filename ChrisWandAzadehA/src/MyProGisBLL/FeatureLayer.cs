using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class FeatureLayer : Layer, IFeatureLayer
    {
        private string _FeatureClass;
        string IFeatureLayer.FeatureClass {
            get
            {
                return _FeatureClass;
            }
            set
            {
                _FeatureClass = value;
            }
        }
    }
}
