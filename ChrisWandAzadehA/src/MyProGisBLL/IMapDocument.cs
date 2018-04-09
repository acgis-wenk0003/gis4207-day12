using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProGisBLL
{
    public interface IMapDocument
    {
        // Properties
        IMap FocusMap { get; }
        IMap[] Maps { get; }

        // Methods
        IMap GetMap(string name);

    }
}
