using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class Map: IMap
    {
        //Properties
        private string _Name;
        private ILayer[] _Layers= new Layer[0];
        private int _LayerCount;
        
        string IMap.Name {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }

        ILayer[] IMap.Layers { get { return _Layers; } }
        int IMap.LayerCount { get { return _LayerCount; } }

        //Methods
        void IMap.AddLayer(ILayer layer)
        {
            Array.Resize(ref _Layers, _Layers.Length+1);
            _LayerCount += 1;
            _Layers[_Layers.Length-1] = layer;                      
        }

        void IMap.RemoveLayer(int index)
        {
            int removeindex = Array.IndexOf(_Layers, index);
            List<ILayer> new_layers = _Layers.ToList();
            List<ILayer> outputlayers = new List<ILayer>();
            int indexcount = 0;
            foreach (ILayer LLayer in new_layers)
            {
                if (indexcount == removeindex)
                {
                    indexcount += 1;
                    continue;
                }
                else
                {
                    indexcount += 1;
                    outputlayers.Add(LLayer);
                    
                }
                
            }
            _Layers = outputlayers.ToArray<ILayer>();
            Array.Resize(ref _Layers, _Layers.Length - 1);
            _LayerCount -= 1;
        }
    }
}
