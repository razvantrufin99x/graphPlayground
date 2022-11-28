using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graphPlayground
{
    public  class _graph
    {
        public const int nmaxnoduri = 20;
        public const int nmaxlegaturi = nmaxnoduri * 4;
        public int nnoduri = 0;
        public int nlegaturi = 0;

        public int [] cap = new int [nmaxnoduri];
        public int [] legaturi = new int [nmaxlegaturi];

        public _graph() { }

        public bool aflaLegaturaUrmatoare(int legaturacurenta, int legaturaurmatoare)
        {
            if(legaturi[legaturacurenta]==0)
            { return false; }
            else
            {
                legaturaurmatoare = legaturacurenta + 1;
                return true;
            }
        }

        bool aflaNod(int legaturacurenta, int nodcurent)
        { 
            if(legaturacurenta> nlegaturi) { return false; }    
            else { 
                nodcurent = legaturi[legaturacurenta];
                return true;
            }
        }
        
        bool aflaCap(int nod, int primaLegatura)
        {
            if(nod > nnoduri) { return false; } 
            else
            {
                primaLegatura = cap[nod];
                return true;
            }

        }
        bool aflaLegatura(int dela, int la, int legatura)
        {
            int i;
            if (dela > nnoduri || la > nnoduri)
                return false;
            i  = cap[dela];
            while (legaturi[i] != la && legaturi[i] != 0) i++;
            legatura = i;
            if (legaturi[i] == 0) legatura = 0;
            return true;
        }
        bool citestegraf( int pnnoduri, ref int [] pcap, ref int [] plegaturi)
        {
            
            nnoduri = pnnoduri;
            cap = pcap;
            legaturi = plegaturi;
            nlegaturi = plegaturi.Length;
            return true;
        }
    }
}
