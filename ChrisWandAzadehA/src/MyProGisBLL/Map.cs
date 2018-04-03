using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class Map : IMap
    {
        private int _layerCount;
        private ILayer[] _layers = new ILayer[0];
        private string _name;

        int IMap.LayerCount
        {
            get
            {
                return _layerCount;
            }
        }

        ILayer[] IMap.Layers
        {
            get
            {
                return _layers;
            }
        }

        string IMap.Name
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

        void IMap.AddLayer(ILayer layer)
        {
            
            Array.Resize(ref _layers, _layers.Length + 1);
            _layers[_layers.Length - 1] = layer;
            _layerCount += 1;

        }

        void IMap.RemoveLayer(int index)
        {
            throw new NotImplementedException();
        }
    }
}
