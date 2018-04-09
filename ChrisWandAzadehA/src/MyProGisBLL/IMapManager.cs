using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public interface IMapManager
    {
        //Methods
        void AddMap(IMap map);
        void RemoveMap(int index);
        void SetFocusMap(int index);

    }
}
