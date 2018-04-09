using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyProGisBLL;

namespace MyProGISConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Overall Map setup section tm1= canada tm2=US
            IMap testmap = new Map();
            testmap.Name = "Canada";
            IMap testmap2 = new Map();
            testmap2.Name = "U.S.";
            IMapManager TestMapDoc = new MapDocument();

            // Canada Layer Setup Section
            ILayer Clayer1 = new Layer();
            Clayer1.Name = "Provinces";
            
            ILayer Clayer2 = new Layer();
            Clayer2.Name = "Lakes";

            testmap.AddLayer(Clayer1);

            testmap.AddLayer(Clayer2);

            // US Layer setup section
            ILayer ULayer1 = new Layer();
            ILayer ULayer2 = new Layer();
            ILayer ULayer3 = new Layer();
            ULayer1.Name = "States";
            ULayer2.Name = "Lakes";
            ULayer3.Name = "Rivers";

            testmap2.AddLayer(ULayer1);
            testmap2.AddLayer(ULayer2);
            testmap2.AddLayer(ULayer3);

            //add Maps to doc
            TestMapDoc.AddMap(testmap);
            TestMapDoc.AddMap(testmap2);
            TestMapDoc.SetFocusMap(1);

            IMapDocument MapDoc = (IMapDocument)TestMapDoc;
            
            
            
            // report 1 Write section
            Console.WriteLine("Map Document Report");
            Console.WriteLine("Focus Map= " + MapDoc.FocusMap.Name);
            Console.WriteLine("\n"+ "Map Name= "+ MapDoc.Maps[0].Name);
            Console.WriteLine("Layer Count= " + MapDoc.Maps[0].LayerCount);
            Console.WriteLine("\t"+"FeatureLayer Name= "+ MapDoc.Maps[0].Layers[0].Name);
            Console.WriteLine("\tFeatureLayer featureclass= "+ "C:\\data\\prov.shp \n");
            Console.WriteLine("\tFeatureLayer Name= "+ MapDoc.Maps[0].Layers[1].Name);
            Console.WriteLine("\tFeatureLayer featureclass= C:\\data\\canlakes.shp \n");
            Console.WriteLine("Map Name= "+ MapDoc.Maps[1].Name);
            Console.WriteLine("Layer Count= "+ MapDoc.Maps[1].LayerCount);
            Console.WriteLine("\tFeatureLayer Name= "+MapDoc.Maps[1].Layers[0].Name);
            Console.WriteLine("\tFeatureLayer featureclass= C:\\data\\states.shp \n");
            Console.WriteLine("\tFeatureLayer Name= "+MapDoc.Maps[1].Layers[1].Name);
            Console.WriteLine("\tFeatureLayer featureclass= C:\\data\\uslakes.shp \n");
            Console.WriteLine("\tFeatureLayer Name= "+MapDoc.Maps[1].Layers[2].Name);
            Console.WriteLine("\tFeatureLayer featureclass= C:\\data\\usrivers.shp \n");

            TestMapDoc.RemoveMap(0);
            IMapDocument MapDoc2 = (IMapDocument)TestMapDoc;
            MapDoc.Maps[0].RemoveLayer(2);

            Console.WriteLine("Map Document Report");
            Console.WriteLine("Focus Map= " + MapDoc2.FocusMap.Name);
            Console.WriteLine("\n" + "Map Name= " + MapDoc2.Maps[0].Name);
            Console.WriteLine("Layer Count= " + MapDoc2.Maps[0].LayerCount);
            Console.WriteLine("\t" + "FeatureLayer Name= " + MapDoc2.Maps[0].Layers[0].Name);
            Console.WriteLine("\tFeatureLayer featureclass= " + "C:\\data\\states.shp \n");
            //Console.WriteLine("\tFeatureLayer Name= " + MapDoc2.Maps[0].Layers[1].Name);
            Console.WriteLine("\tFeatureLayer featureclass= C:\\data\\uslakes.shp \n");
            //read line utility
            Console.Read();
        }
    }
}
