using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SignInUp());
            Application.Run(new Client_Panel());

            /*            Heap.maxHeap maxHeap = new Heap.maxHeap();
                        List<List<string>> twoDimensional = new List<List<string>>();
                        List<int> list = new List<int>();
                        list.Add(0);
                        list.Add(5);
                        list.Add(3);
                        list.Add(9);
                        list.Add(4);
                        maxHeap.buildHeap(ref list);
                        maxHeap.printHeap(ref list);

                        Heap.minHeap minHeap = new Heap.minHeap();
                        List<int> list1 = new List<int>();
                        list1.Add(0);
                        list1.Add(5);
                        list1.Add(3);
                        list1.Add(9);
                        list1.Add(4);
                        minHeap.buildHeap(ref list1);
                        minHeap.printHeap(ref list1);*/
        }
    }
}
