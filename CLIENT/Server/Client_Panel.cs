using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Client_Panel : Form
    {

        Heap.maxHeap[] maxHeap = new Heap.maxHeap[26];
        List<Heap.data>[] datas = new List<Heap.data>[26];
        int i = 0;

        public Client_Panel()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Client_Panel_Load(object sender, EventArgs e)
        {
            try
            {
                for (i = 0; i < 26; ++i)
                {
                    datas[i] = new List<Heap.data>();
                }
                for (i = 0; i < 26; ++i)
                {
                    maxHeap[i] = new Heap.maxHeap();
                }
                StreamReader AdminNames = new StreamReader("../../../../Server/Server/Data/CityData/Admin Names.txt");
                StreamReader CityLattitudes = new StreamReader("../../../../Server/Server/Data/CityData/City Lattitude.txt");
                StreamReader CityLongitudes = new StreamReader("../../../../Server/Server/Data/CityData/City Longitude.txt");
                StreamReader CityNames = new StreamReader("../../../../Server/Server/Data/CityData/City Names.txt");
                StreamReader CityPopulations = new StreamReader("../../../../Server/Server/Data/CityData/City Population.txt");
                StreamReader CitySearches = new StreamReader("../../../../Server/Server/Data/CityData/City Searches.txt");
                StreamReader CountryNames = new StreamReader("../../../../Server/Server/Data/CityData/Country Names.txt");
                string CityName = "";
                AutoCompleteStringCollection FromAutosource = new AutoCompleteStringCollection();
                AutoCompleteStringCollection ToAutosource = new AutoCompleteStringCollection();
                Heap.data temp;
                int index = 0;
                while (!CityNames.EndOfStream)
                {
                    CityName = CityNames.ReadLine();
                    FromAutosource.Add(CityName);
                    ToAutosource.Add(CityName);
                    temp = new Heap.data();
                    temp.CityAdminName = AdminNames.ReadLine();
                    temp.CityLattitude = CityLattitudes.ReadLine();
                    temp.CityLongitude = CityLongitudes.ReadLine();
                    temp.CityName = CityName;
                    temp.CityPopulation = CityPopulations.ReadLine();
                    temp.CitySearches = int.Parse(CitySearches.ReadLine());
                    temp.CityCountry = CountryNames.ReadLine();
                    index = GetIndex(CityName);
                    maxHeap[index].insert(ref datas[index], temp);
                }
                AdminNames.Close();
                CityLattitudes.Close();
                CityLongitudes.Close();
                CityNames.Close();
                CityPopulations.Close();
                CitySearches.Close();
                CountryNames.Close();
                FromTextbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                FromTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                FromTextbox.AutoCompleteCustomSource = FromAutosource;
                ToTextbox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ToTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ToTextbox.AutoCompleteCustomSource = ToAutosource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FromTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ToTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = (e.KeyChar == (char)Keys.Space);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public int GetIndex(string CityName)
        {
            try
            {
                if (CityName[0] == 'A' || CityName[0] == 'a')
                {
                    return 0;
                }
                else if (CityName[0] == 'B' || CityName[0] == 'b')
                {
                    return 1;
                }
                else if (CityName[0] == 'C' || CityName[0] == 'c')
                {
                    return 2;
                }
                else if (CityName[0] == 'D' || CityName[0] == 'd')
                {
                    return 3;
                }
                else if (CityName[0] == 'E' || CityName[0] == 'e')
                {
                    return 4;
                }
                else if (CityName[0] == 'F' || CityName[0] == 'f')
                {
                    return 5;
                }
                else if (CityName[0] == 'G' || CityName[0] == 'g')
                {
                    return 6;
                }
                else if (CityName[0] == 'H' || CityName[0] == 'h')
                {
                    return 7;
                }
                else if (CityName[0] == 'I' || CityName[0] == 'i')
                {
                    return 8;
                }
                else if (CityName[0] == 'J' || CityName[0] == 'j')
                {
                    return 9;
                }
                else if (CityName[0] == 'K' || CityName[0] == 'k')
                {
                    return 10;
                }
                else if (CityName[0] == 'L' || CityName[0] == 'l')
                {
                    return 11;
                }
                else if (CityName[0] == 'M' || CityName[0] == 'm')
                {
                    return 12;
                }
                else if (CityName[0] == 'N' || CityName[0] == 'n')
                {
                    return 13;
                }
                else if (CityName[0] == 'O' || CityName[0] == 'o')
                {
                    return 14;
                }
                else if (CityName[0] == 'P' || CityName[0] == 'p')
                {
                    return 15;
                }
                else if (CityName[0] == 'Q' || CityName[0] == 'q')
                {
                    return 16;
                }
                else if (CityName[0] == 'R' || CityName[0] == 'r')
                {
                    return 17;
                }
                else if (CityName[0] == 'S' || CityName[0] == 's')
                {
                    return 18;
                }
                else if (CityName[0] == 'T' || CityName[0] == 't')
                {
                    return 19;
                }
                else if (CityName[0] == 'U' || CityName[0] == 'u')
                {
                    return 20;
                }
                else if (CityName[0] == 'V' || CityName[0] == 'v')
                {
                    return 21;
                }
                else if (CityName[0] == 'W' || CityName[0] == 'w')
                {
                    return 22;
                }
                else if (CityName[0] == 'X' || CityName[0] == 'x')
                {
                    return 23;
                }
                else if (CityName[0] == 'Y' || CityName[0] == 'y')
                {
                    return 24;
                }
                else if (CityName[0] == 'Z' || CityName[0] == 'z')
                {
                    return 25;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0;
        }

        private void Go_Click(object sender, EventArgs e)
        {
            try
            {
                if (FromTextbox.Text == "")
                {
                    MessageBox.Show("Please fill from textbox to proceed!");
                }
                else if (ToTextbox.Text == "")
                {
                    MessageBox.Show("Please fill To textbox to proceed!");
                }
                else if (FromTextbox.Text == ToTextbox.Text)
                {
                    MessageBox.Show("From and to can't be same!");
                }
                else
                {
                    int FromIndex = GetIndex(FromTextbox.Text);
                    int ToIndex = GetIndex(ToTextbox.Text);
                    var fromResult = maxHeap[FromIndex].searchHeap(ref datas[FromIndex], FromTextbox.Text);
                    var toResult = maxHeap[ToIndex].searchHeap(ref datas[ToIndex], ToTextbox.Text);
                    if (fromResult == null)
                    {
                        MessageBox.Show(FromTextbox.Text + " not found!");
                    }
                    else if (toResult == null)
                    {
                        MessageBox.Show(ToTextbox.Text + " not found!");
                    }
                    else
                    {
                        listBox1.Items.Add(fromResult.CityAdminName);
                        listBox1.Items.Add(fromResult.CityLattitude);
                        listBox1.Items.Add(fromResult.CityLongitude);
                        listBox1.Items.Add(fromResult.CityName);
                        listBox1.Items.Add(fromResult.CityPopulation);
                        listBox1.Items.Add(fromResult.CitySearches.ToString());
                        listBox1.Items.Add(fromResult.CityCountry);

                        listBox2.Items.Add(toResult.CityAdminName);
                        listBox2.Items.Add(toResult.CityLattitude);
                        listBox2.Items.Add(toResult.CityLongitude);
                        listBox2.Items.Add(toResult.CityName);
                        listBox2.Items.Add(toResult.CityPopulation);
                        listBox2.Items.Add(toResult.CitySearches.ToString());
                        listBox2.Items.Add(toResult.CityCountry);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Client_Panel_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                StreamWriter AdminNames = new StreamWriter("../../../../Server/Server/Data/CityData/Admin Names.txt");
                StreamWriter CityLattitudes = new StreamWriter("../../../../Server/Server/Data/CityData/City Lattitude.txt");
                StreamWriter CityLongitudes = new StreamWriter("../../../../Server/Server/Data/CityData/City Longitude.txt");
                StreamWriter CityNames = new StreamWriter("../../../../Server/Server/Data/CityData/City Names.txt");
                StreamWriter CityPopulations = new StreamWriter("../../../../Server/Server/Data/CityData/City Population.txt");
                StreamWriter CitySearches = new StreamWriter("../../../../Server/Server/Data/CityData/City Searches.txt");
                StreamWriter CountryNames = new StreamWriter("../../../../Server/Server/Data/CityData/Country Names.txt");
                for (i = 0; i < 26; ++i)
                {
                    for (int j = 0; j < datas[i].Count; ++j)
                    {
                        AdminNames.WriteLine(datas[i][j].CityName.ToString());
                        CityLattitudes.WriteLine(datas[i][j].CityLattitude.ToString());
                        CityLongitudes.WriteLine(datas[i][j].CityLongitude.ToString());
                        CityNames.WriteLine(datas[i][j].CityName.ToString());
                        CityPopulations.WriteLine(datas[i][j].CityPopulation.ToString());
                        CitySearches.WriteLine(datas[i][j].CitySearches.ToString());
                        CountryNames.WriteLine(datas[i][j].CityCountry.ToString());
                    }
                }
                AdminNames.Close();
                CityLattitudes.Close();
                CityLongitudes.Close();
                CityNames.Close();
                CityPopulations.Close();
                CitySearches.Close();
                CountryNames.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
