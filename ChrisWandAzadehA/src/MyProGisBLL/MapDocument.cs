using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class MapDocument : IMapDocument, IMapManager
    {
        //Properties MapDocument
        private IMap _FocusMap;
        private IMap[] _Maps = new Map[0];
         
        IMap IMapDocument.FocusMap { get { return _FocusMap; } }
        IMap[] IMapDocument.Maps { get { return _Maps; } }

        //Methods MapDocument
        IMap IMapDocument.GetMap (string name)
        {
            IMap output;
            int indexcount = 0;
            foreach (IMap AMap in _Maps)
            {

                if (AMap.Name.Equals(name)==true)
                {
                    output = AMap;
                    return output;
                    

                }
                if (!AMap.Name.Equals(name) & _Maps.Length.Equals(indexcount))
                {
                    output = new Map();
                    output.Name = "NULL MAP";
                    return null;
                }
                else
                {
                    indexcount += 1;
                    continue;
                }

            }
            output = new Map();
            output.Name = "NULL MAP break 2";
            return output;
        }

        //Methods MapManager
        void IMapManager.AddMap(IMap map)
        {
            Array.Resize(ref _Maps, _Maps.Length + 1);
            _Maps[_Maps.Length-1] = map;
        }

        void IMapManager.RemoveMap (int index)
        {
            int removeindex = Array.IndexOf(_Maps, index);
            List<IMap> new_maps = _Maps.ToList();
            List<IMap> outputmaps = new List<IMap>();
            int indexcount = 0;
            foreach (IMap LMap in new_maps)
            {
                if (indexcount == removeindex)
                {
                    indexcount += 1;
                }
                else
                {
                    indexcount += 1;
                    outputmaps.Add(LMap);
                }
                
            }
            _Maps = outputmaps.ToArray<IMap>();
            Array.Resize(ref _Maps, _Maps.Length - 1);
        }

        void IMapManager.SetFocusMap (int index)
        {
            if (index < _Maps.Length)
            {

                IMap transfermap = _Maps[index];
                _FocusMap = transfermap;
            }
            
        }
    }
}
