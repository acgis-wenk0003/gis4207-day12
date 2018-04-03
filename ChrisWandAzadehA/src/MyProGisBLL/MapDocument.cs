using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public class MapDocument : IMapDocument, IMapManager
    {
        private IMap _focusMap;
        private IMap[] _maps;

        IMap IMapDocument.FocusMap
        {
            get
            {
                return _focusMap;
            }
        }

        IMap[] IMapDocument.Maps
        {
            get
            {
                return _maps;
            }
        }

        void IMapManager.AddMap(IMap map)
        {
            throw new NotImplementedException();
        }

        IMap IMapDocument.GetMap(string name)
        {
            throw new NotImplementedException();
        }

        void IMapManager.RemoveMap(int index)
        {
            throw new NotImplementedException();
        }

        void IMapManager.SetFocusMap(int index)
        {
            throw new NotImplementedException();
        }
    }
}
