using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    interface IMapDocument
    {
        IMap FocusMap { get; }
        IMap[] Maps { get; }
        IMap GetMap(string name); 
    }
}
