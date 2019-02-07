using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    interface CircularLinkedList
    {
        void InsertFirst(object value);
        void InsertLast(object value);
        object Remove();
        Boolean IsEmpty();
        string getElements();
    }
}
