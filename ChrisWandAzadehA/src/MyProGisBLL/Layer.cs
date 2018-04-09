using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class Layer: ILayer
    {
        private string _Name;
       string ILayer.Name { get
            {
                return _Name; 
            }
            set
            {
                _Name = value;
            }
        }
    }
}
