using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilariOdev2
{
    class IkinciKatList:Node,CircularLinkedList
    {
        public List<Araba> Arabalar = new List<Araba>();
        public List<Node> Nodelar = new List<Node>();
        public Node Head;
        public int Size = 0;
        public  int count = 0;
        public void InsertFirst(object /*o,int*/ value)
        {
            Node tmpHead = new Node { Data=value};
            if (Head == null)
            {
                Head = tmpHead;
                tmpHead.Next = tmpHead;
            }
            count++;
        }

        public void InsertLast(object /*o,int*/ value)
        {
            Node newLast = new Node { Data = value };
            //bool varmi = false;
            if (Head == null)
            {
                InsertFirst(value);
            }
            else
            {
                foreach (var item in Nodelar)
                {
                    if(item.Next==Head)
                    {
                        item.Next = newLast;
                        newLast.Next = Head;
                    }
                }
            }
            count++;
            Size++;
        }
        
        public void IkinciKatArabaEkle(Araba a)
        {
            Arabalar.Add(a);
        }

        public object Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Hata: Circular Linked List boş...");
            }
            object temp = "";
            switch (Size)
            {
                case 15:
                    {
                        temp = "Beyaz2";
                        Arabalar.RemoveAt(Arabalar.Count - 14);
                        break;
                    }
                case 14:
                    {
                        temp = "Beyaz4";
                        Arabalar.RemoveAt(Arabalar.Count - 12);
                        break;
                    }
                case 13:
                    {
                        temp = "Beyaz6";
                        Arabalar.RemoveAt(Arabalar.Count - 10);
                        break;
                    }
                case 12:
                    {
                        temp = "Beyaz8";
                        Arabalar.RemoveAt(Arabalar.Count - 8);
                        break;
                    }
                case 11:
                    {
                        temp = "Beyaz10";
                        Arabalar.RemoveAt(Arabalar.Count - 6);
                        break;
                    }
                case 10:
                    {
                        temp = "Beyaz12";
                        Arabalar.RemoveAt(Arabalar.Count - 4);
                        break;
                    }
                case 9:
                    {
                        temp = "Beyaz14";
                        Arabalar.RemoveAt(Arabalar.Count - 2);
                        break;
                    }
                case 8:
                    {
                        temp = "Beyaz1";
                        Arabalar.RemoveAt(Arabalar.Count - 8);
                        break;
                    }
                case 7:
                    {
                        temp = "Beyaz5";
                        Arabalar.RemoveAt(Arabalar.Count - 6);
                        break;
                    }
                case 6:
                    {
                        temp = "Beyaz9";
                        Arabalar.RemoveAt(Arabalar.Count - 4);
                        break;
                    }
                case 5:
                    {
                        temp = "Beyaz13";
                        Arabalar.RemoveAt(Arabalar.Count - 2);
                        break;
                    }
                case 4:
                    {
                        temp = "Beyaz3";
                        Arabalar.RemoveAt(Arabalar.Count - 4);
                        break;
                    }
                case 3:
                    {
                        temp = "Beyaz11";
                        Arabalar.RemoveAt(Arabalar.Count - 2);
                        break;
                    }
                case 2:
                    {
                        temp = "Beyaz7";
                        Arabalar.RemoveAt(Arabalar.Count - 2);
                        break;
                    }
                case 1:
                    {
                        temp = "Beyaz15";
                        Arabalar.RemoveAt(Arabalar.Count - 1);
                        break;
                    }
                default:
                    throw new Exception("Hata: Circular Linked List boş...");
            }
            count--;
            Size--;
            return temp;
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }

        public string getElements()
        {
            string temp = "";
            foreach (Araba a in Arabalar)//Listede gerekli arama yapıldı.
            {
                temp += "\nAraba Rengi:" + a.ArabaRengi;
            }
            return temp;
        }
    }
}
