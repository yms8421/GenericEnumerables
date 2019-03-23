using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgeAdam.GenericEnumerables
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[3];
            array1[2] = 4;
            var array2D = new int[3,4];
            var array2 = new string[] { "Elma", "Armut", "Vişne", "Kiraz", "Kavun" };

            var arrayList = new ArrayList(); //List<object>
            arrayList.Add("Can");
            arrayList.Add(5);
            arrayList.Add(new Random());
            arrayList.Add(true);

            var list1 = new List<int>();
            list1.Add(3);
            list1.Add(5);
            list1.Remove(3);
            list1.Remove(4);
            list1.Add(12);
            list1.RemoveAt(0);

            var list2 = new List<string> { "Can", "Cem", "Cenk" };
            list2.Add("Alp");
            if (!list2.Contains("Tan"))
            {
                list2.Add("Tan");
            }

            var hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(3);

            var bindingList = new BindingList<string>();
            bindingList.Add("Can");
            bindingList.Add("Cem");
            bindingList.Add("Cenk");
            bindingList.Add("Alp");


            var bp1 = new BasicPerson
            {
                FullName = "Can PERK",
                Wallet = 200
            };
            var bp2 = new BasicPerson
            {
                FullName = "Fatih ESER",
                Wallet = 300
            };
            var bp3 = new BasicPerson
            {
                FullName = "Can PERK",
                Wallet = 200
            };
            BasicPerson bp4 = bp1;

            var bp1Hash = bp1.GetHashCode();
            var bp2Hash = bp2.GetHashCode();
            var bp3Hash = bp3.GetHashCode();
            var bp4Hash = bp4.GetHashCode();
            
            if (bp1 == bp3)
            {
                //çalışmaz
            }
            if (bp1 == bp4)
            {
                //çalışır bkz. GetHashCode
            }

            var dictionary = new Dictionary<int, string>();
            dictionary.Add(0, "Sıfır");//veri bakımından key tekrarlanamaz!!! value için böyle bir kural yok
            dictionary.Add(4, "Dört");//1 => key, Bir => value
            dictionary.Add(1, "Bir");//1 => key, Bir => value
            dictionary.Remove(0);//sıfır indeks değil, key değeri!!!!
            if (!dictionary.ContainsKey(3))
            {
                dictionary.Add(3, "Üç");
            }

            if (dictionary.ContainsKey(5))
            {
                var dortYaziIle = dictionary[5];
            }
            var dictionary2 = new Dictionary<string, List<string>>();
            dictionary2.Add("Can", new List<string> { "Bir isim", "yaşam kaynağı", "oyunlar verilan hak" });


            var sortedSet = new SortedSet<int>();
            sortedSet.Add(5);
            sortedSet.Add(2);
            sortedSet.Add(1);
            sortedSet.Add(10);
            sortedSet.Add(4);
            var reversedSet = sortedSet.Reverse();
            Console.WriteLine("Sorted Set");
            foreach (var number in reversedSet)
            {
                Console.WriteLine(number);
            }
            var sortedList = new SortedList<int, string>();
            sortedList.Add(4, "Dört");
            sortedList.Add(1, "Bir");
            sortedList.Add(0, "Sıfır");
            sortedList.Add(2, "İki");
            Console.WriteLine("Sorted List");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"Key : {item.Key} - Value: {item.Value}");
            }

            var linkedList = new LinkedList<string>();
            var cListNode = new LinkedListNode<string>("Can");
            var aListNode = new LinkedListNode<string>("Ali");
            linkedList.AddFirst(cListNode);
            linkedList.AddLast(aListNode);
            linkedList.AddAfter(cListNode, "Gamze");
            linkedList.AddBefore(aListNode, "Deniz");
            linkedList.AddAfter(cListNode, "Gülşah");
            linkedList.AddAfter(aListNode, "Fatih");

            var gListNode = linkedList.Find("Gülşah");
            if (gListNode != null)
            {
                linkedList.AddAfter(gListNode, "Ayşegül");
            }

            var name = "Can PERK";
            name.Replace("a", "e").Replace("n", "m"); //replace yapar ama değeri değiştirmez
            Console.WriteLine(name);
            Console.ReadKey();


            //Stack, Queue

        }
    }

    class BasicPerson
    {
        public string FullName { get; set; }
        public int Wallet { get; set; }
    }
}
