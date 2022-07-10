using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkezi
{
    internal class BireyselMusteriKuyruk
    {
        Node front; //çağrı sırasındaki en öndeki kişi
        Node rear; //çağrı sırasındaki en sondaki kişi
        public BireyselMusteriKuyruk()
        {
            front = null;
            rear = null;
        }

        public void ekle(string data) //ekle
        {
            Node eleman = new Node(data);
            if (front == null)
            {
                front = rear = eleman;
            }
            else
            {
                rear.next = eleman;
                rear = eleman;
            }
        }

        public Node veri;
        public void sil() //sil
        {
            veri= front;
            front = front.next;
        }

        string mesaj;
        public string SirayiGoster()
        {
            mesaj = "";
            Node temp = front;
            while (temp != null)
            {
                mesaj += temp.data.ToString() + " <- ";
                temp = temp.next;
            }
            return mesaj + "son";
        }

        public string SiradaArama(string arananEleman)
        {
            int i = 0;
            Node temp = front;
            while (temp != null)
            {
                i++;
                if (temp.data == arananEleman) break;
                temp = temp.next;
            }
            return i + ". sıradasınız.";
        }
    }
}
