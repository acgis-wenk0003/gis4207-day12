using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    class FeatureLayer : IFeatureLayer
    {
        private string _featureClass;
        private string _name;

        string IFeatureLayer.FeatureClass
        {
            get
            {
                return _featureClass;
            }

            set
            {
                _featureClass = value;
            }
        }

        string ILayer.Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
    }
}
