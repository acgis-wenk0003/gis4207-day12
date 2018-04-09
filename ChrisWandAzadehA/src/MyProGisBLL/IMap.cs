using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
     public interface IMap
    {
        //Properties
        string Name { get; set; }
        ILayer[] Layers { get; }
        int LayerCount { get; }

        //Methods
        void AddLayer(ILayer layer);
        void RemoveLayer(int index);
    }
}
