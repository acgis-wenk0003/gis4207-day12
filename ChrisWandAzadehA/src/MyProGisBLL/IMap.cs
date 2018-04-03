using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public interface IMap
    {
        string Name { get; set; }
        ILayer[] Layers { get; }
        int LayerCount { get; }
        void AddLayer(ILayer layer);
        void RemoveLayer(int index);

    }
}
