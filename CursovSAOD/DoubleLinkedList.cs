using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursovSAOD
{
    class DoubleLinkedList
    {
        Node Head;

        public DoubleLinkedList()
        {
            Head = null;
        }

        public void Add(StaticList nShop)
        {
            Node prev = Head;
            Node nNode = new Node(nShop);
            if (Head != null)
            {
                Node temp = Head;

                while (temp != null)
                {

                    if (nNode.Shop.WorkshopName > temp.Shop.WorkshopName)
                    {
                        prev = temp;
                    }
                    if (temp.Next != Head)
                    {
                        temp = temp.Next;
                    }
                    else { break; }
                }
                temp = prev;
                if (temp == Head)
                {
                    if (nNode.Shop.WorkshopName < temp.Shop.WorkshopName)
                    {
                        nNode.Next = temp;
                        nNode.Previous = temp.Previous;
                        temp.Previous.Next = nNode;
                        temp.Previous = nNode;
                        Head = nNode;
                    }
                    else
                    {
                        nNode.Previous = temp;
                        nNode.Next = temp.Next;
                        temp.Next.Previous = nNode;
                        temp.Next = nNode;
                    }
                }
                else
                {
                    nNode.Previous = temp;
                    nNode.Next = temp.Next;
                    temp.Next.Previous = nNode;
                    temp.Next = nNode;
                }
            }
            else
            {
                Head = nNode;
                Head.Next = Head;
                Head.Previous = Head;
            }
        }

        public void Remove(StaticList nShop)
        {
            if (Head != null)
            {
                if (nShop == null) throw new Exception("Не выбран удаляемый цех");
                Node nNode = Head;
                while (nNode != null)
                {
                    if (nNode.Shop.Equals(nShop))
                    {
                        break;
                    }
                    if (nNode.Next != Head)
                    {
                        nNode = nNode.Next;
                    }
                    else { break; }

                }

                if (nNode == Head)
                {
                    nNode.Next.Previous = nNode.Previous;
                    nNode.Previous.Next = nNode.Next;
                    if (nNode.Next != Head)
                    {
                        Head = nNode.Next;
                    }
                    else
                    {
                        Head = null;
                    }
                    nNode.Shop.Dispose_();
                    nNode = null;
                    GC.Collect();

                }
                else
                {
                    if (nNode.Next != Head)
                    {
                        nNode.Next.Previous = nNode.Previous;
                    }
                    else
                    {
                        Head.Previous = nNode.Previous;
                    }
                    nNode.Previous.Next = nNode.Next;
                    nNode.Shop.Dispose_();
                    nNode = null;
                    GC.Collect();

                }
            }
            else
            {
                throw new Exception("Список пуст");
            }
        }

        public Node SearchForward(int nShop)
        {
            Node temp = Head;
            while (temp != null)
            {
                if (temp.Shop.WorkshopName == nShop)
                {
                    return temp;
                }
                else
                {
                    if (temp.Next != Head)
                    {
                        temp = temp.Next;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return null;
        }
        public Node SearchBackward(int nShop)
        {
            Node temp = Head.Previous;
            while (temp != null)
            {
                if (temp.Shop.WorkshopName == nShop)
                {
                    return temp;
                }
                else
                {
                    if (temp.Previous != Head.Previous)
                    {
                        temp = temp.Previous;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return null;
        }
        public List<StaticList> toListDoubleForward()
        {
            Node temp = Head;
            List<StaticList> list = new List<StaticList>();
            while (temp != null)
            {
                list.Add(temp.Shop);
                if (temp.Next != Head)
                {
                    temp = temp.Next;
                }
                else
                {
                    break;
                }
            }
            return list;
        }
        public List<StaticList> toListDoubleBackward()
        {
            Node temp = Head;
            List<StaticList> list = new List<StaticList>();
            while (temp != null)
            {
                if (temp.Previous != Head)
                {
                    temp = temp.Previous;
                    list.Add(temp.Shop);
                }
                else
                {
                    list.Add(temp.Previous.Shop);
                    break;
                }
            }
            return list;
        }
        public void Dispose_()
        {
            while (Head != null)
            {
                if (Head.Next != Head)
                {
                    Node temp = Head;
                    Head.Next.Previous = Head.Previous;
                    Head.Previous.Next = Head.Next;
                    Head = Head.Next;
                    temp.Shop.Dispose_();
                    temp = null;
                    GC.Collect();

                }
                else
                {
                    Head.Shop.Dispose_();
                    Head = null;
                    GC.Collect();
                }
            }
        }

        ~DoubleLinkedList()
        {
            Dispose_();
            GC.Collect();
        }
    }
}
