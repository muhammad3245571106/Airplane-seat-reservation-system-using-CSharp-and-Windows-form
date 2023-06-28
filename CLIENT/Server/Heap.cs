using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
	internal class Heap
	{
		public class data
        {
			public string CityAdminName;
			public string CityName;
			public string CityCountry;
			public int CitySearches;
			public string CityLattitude;
			public string CityLongitude;
			public string CityPopulation;
			public data()
            {
				CityAdminName = "";
				CityName = "";
				CityCountry = "";
				CitySearches = 0;
				CityLattitude = "";
				CityLongitude = "";
				CityPopulation = "";
			}
        }
        public class minHeap
        {
            public void heapifyRoot(ref List<data> vec, int i)
            {
                int largest = i;
                int l = 2 * i + 1;
                int r = 2 * i + 2;
                if (l < vec.Count && vec[l].CitySearches < vec[largest].CitySearches)
                {
                    largest = l;
                }
                if (r < vec.Count() && vec[r].CitySearches < vec[largest].CitySearches)
                {
                    largest = r;
                }
                if (largest != i)
                {
					swap(i, largest, ref vec);
                    heapifyRoot(ref vec, largest);
                }
            }
			void swap(int first, int second, ref List<data> arr)
			{
				arr[first].CitySearches = arr[first].CitySearches + arr[second].CitySearches;
				arr[second].CitySearches = arr[first].CitySearches - arr[second].CitySearches;
				arr[first].CitySearches = arr[first].CitySearches - arr[second].CitySearches;
			}
			public void heapifyLeaf(ref List<data> vec, int i)
            {
                int parent = (i - 1) / 2;

                if (vec[parent].CitySearches > 0)
                {
                    if (vec[i].CitySearches < vec[parent].CitySearches)
                    {
						swap(i, parent, ref vec);
						heapifyLeaf(ref vec, parent);
                    }
                }
            }
            public void buildHeap(ref List<data> vec)
            {
                int startIdx = (vec.Count() / 2) - 1;
                for (int i = startIdx; i >= 0; i--)
                {
                    heapifyRoot(ref vec, i);
                }
            }
            public void deleteRoot(ref List<data> vec)
            {
                int lastElement = vec[vec.Count() - 1].CitySearches;
                vec[0].CitySearches = lastElement;
                vec.RemoveAt(vec.Count - 1);
                heapifyRoot(ref vec, 0);
            }
            public void insert(ref List<data> vec, data key)
            {
                vec.Add(key);
                heapifyLeaf(ref vec, vec.Count() - 1);
            }
            public void printHeap(ref List<data> vec)
            {
                MessageBox.Show("Array representation of Min heap is:");
                for (int i = 0; i < vec.Count(); ++i)
                {
                    MessageBox.Show(vec[i].CitySearches.ToString());
                }
            }

        };

        public class maxHeap
        {
            public void heapifyRoot(ref List<data> vec, int i)
			{
				int Largest = i;
				int l = 2 * i + 1;
				int r = 2 * i + 2;
				if (l < vec.Count && vec[l].CitySearches > vec[Largest].CitySearches)
				{
					Largest = l;
				}
				if (r < vec.Count() && vec[r].CitySearches > vec[Largest].CitySearches)
				{
					Largest = r;
				}
				if (Largest != i)
				{
					swap(i, Largest, ref vec);
					heapifyRoot(ref vec, Largest);
				}
			}
			void swap(int first, int second, ref List<data> arr)
			{
				arr[first].CitySearches = arr[first].CitySearches + arr[second].CitySearches;
				arr[second].CitySearches = arr[first].CitySearches - arr[second].CitySearches;
				arr[first].CitySearches = arr[first].CitySearches - arr[second].CitySearches;
			}
			public void heapifyLeaf(ref List<data> vec, int i)
			{
				int parent = (i - 1) / 2;

				if (vec[parent].CitySearches > 0)
				{
					if (vec[i].CitySearches > vec[parent].CitySearches)
					{
					swap(i, parent, ref vec);
					heapifyLeaf(ref vec, parent);
					}
				}
			}
			public void buildHeap(ref List<data> vec)
			{
				int startIdx = (vec.Count() / 2) - 1;
				for (int i = startIdx; i >= 0; i--)
				{
					heapifyRoot(ref vec, i);
				}
			}
			public void deleteRoot(ref List<data> vec)
			{
				int lastElement = vec[vec.Count() - 1].CitySearches;
				vec[0].CitySearches = lastElement;
				vec.RemoveAt(vec.Count - 1);
				heapifyRoot(ref vec, 0);
			}
			public void insert(ref List<data> vec, data key)
			{
				vec.Add(key);
				heapifyLeaf(ref vec, vec.Count() - 1);
			}
			public void delete(ref List<data> vec, data key)
			{
				vec.Remove(key);
				heapifyLeaf(ref vec, vec.Count() - 1);
			}
			public void printHeap(ref List<data> vec)
			{
				MessageBox.Show("Array representation of Max heap is:");
				for (int i = 0; i < vec.Count(); ++i)
				{
					MessageBox.Show(vec[i].CityName.ToString());
				}
			}
			public data searchHeap(ref List<data> vec, string cityName)
            {
				Stopwatch stopwatch = new Stopwatch();
				stopwatch.Start();
				for (int i = 0; i < vec.Count(); ++i)
				{
					if (cityName.ToLower() == vec[i].CityName.ToLower())
                    {
						data temp = new data();
						vec[i].CitySearches++;
						temp = vec[i];
						delete(ref vec, vec[i]);
						insert(ref vec, temp);
						stopwatch.Stop();
						double time = stopwatch.Elapsed.TotalSeconds;
						MessageBox.Show("Find your result in "+ time.ToString() + " seconds!");
						return temp;
                    }
				}
				return null;
			}

		};
	}
}