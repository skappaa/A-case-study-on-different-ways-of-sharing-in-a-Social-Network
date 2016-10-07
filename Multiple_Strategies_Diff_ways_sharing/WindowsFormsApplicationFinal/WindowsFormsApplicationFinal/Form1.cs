using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Excel;

namespace WindowsFormsApplicationFinal
{

    public partial class Form1 : Form
    {
        public static string myPath = @"C:\Users\Sumukhi Kappa\Desktop\Sumukhi\mastersproject\executablecode";
        public static Random rnd = new Random();
        public static List<Node> nodes = new List<Node>();
        public static List<Node> Small_List, Med_List, Large_List; //List
        //public static int InterestTopics;
        public static List<List<Node>> smallList, MedList, LargeList; //List of Lists representing clusters
        public static Graph<Node> LeadersGraph; //Graph of Leader Nodes
        public static List<Graph<Node>> SmallGraph, MedGraph, LargeGraph; //List of Graphs for List of Lists to createEdges
        public static List<Node> Leaders = new List<Node>(); //List of Leader Nodes
        public static int small_Count, med_Count, large_Count;
        public static JsonFile jsonfile = new JsonFile();
        public static string path = Directory.GetCurrentDirectory();
        public static List<Double> Probabalities = new List<Double>();
        public static List<Message> form1mesg;
        public static int ID = 1;
        public static int NodeCount = 0;
        public static int n = 0;
        public static int k1;
        public static int totaltime;
        //[Added :]
        static Dictionary<int, Dictionary<String, Dictionary<String, double>>> categoriesJson;
        public Form1()
        {
            InitializeComponent();

            //[Added :]
            try
            {
                string file = File.ReadAllText(path + "\\..\\Debug\\" + "interestList.json");
                categoriesJson = JsonConvert.DeserializeObject<Dictionary<int, Dictionary<String, Dictionary<String, double>>>>(file);
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException();
            }
        }

        private static Microsoft.Office.Interop.Excel.Workbook mWorkBook;
        private static Microsoft.Office.Interop.Excel.Sheets mWorkSheets;
        private static Microsoft.Office.Interop.Excel.Worksheet mWSheet1;
        private static Microsoft.Office.Interop.Excel.Application oXL;
        object Missing = System.Reflection.Missing.Value;


        public void AppendToExcel()
        {
            string path = myPath + @"\windowsform.xls";
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            oXL.DisplayAlerts = false;
            mWorkBook = oXL.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Get all the sheets in the workbook
            mWorkSheets = mWorkBook.Worksheets;
            //Get the allready exists sheet
            mWSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)mWorkSheets.get_Item("Sheet1");
            Microsoft.Office.Interop.Excel.Range range = mWSheet1.UsedRange;
            int colCount = range.Columns.Count;
            int rowCount = range.Rows.Count;

            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    for (int j = 0; j < dt.Columns.Count; j++)
            //    {
            //        mWSheet1.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
            //    }
            //}   

            int i1; 
            i1 = rowCount+1;
            mWSheet1.Cells[i1, 1] = textBoxSmall.Text;
            mWSheet1.Cells[i1, 2] = textBoxSmallSize.Text;
            mWSheet1.Cells[i1, 3] = textBoxMed.Text;
            mWSheet1.Cells[i1, 4] = textBoxMediumSize.Text;
            mWSheet1.Cells[i1, 5] =  textBoxLarge.Text;
            mWSheet1.Cells[i1, 6] = textBoxLargeSize.Text;
           mWorkBook.SaveAs(path, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal,
            Missing, Missing, Missing, Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive,
            Missing, Missing, Missing,
            Missing, Missing);
            mWorkBook.Close(Missing, Missing, Missing);
            mWSheet1 = null;
            mWorkBook = null;
            oXL.Quit();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
       
        public void Randommesg()
        {
            Random r = new Random();
            double k2 = n * 0.15;
            k1 = Convert.ToInt32(k2);
            double time = n * 0.4;
            totaltime = Convert.ToInt32(time);
            //List<String> messagetype=new List<String>();
            //List<double> rscore=new List<double>();
            for (int i = 0; i <= k1; i++)
            {
               
                List<double> rscore = new List<double>();
                List<string> messagetype = new List<string>();
                Message msg = new Message(messagetype, rscore);
                messagetype.Clear();
                rscore.Clear();
                int mnum = r.Next(6);
                while (messagetype.Count <= mnum)
                {
                    string[] arr = { "sports", "reebok", "nike", "adidas", "cookware", "home decor", "tools", "toys", "clothes", "appliances", "electronics", "phones", "computers" };
                    int i1 = r.Next(13);
                    String mesgtype = arr[i1];
                    if (messagetype.Contains(mesgtype))
                    {
                        continue;
                    }
                    else
                    {
                        messagetype.Add(mesgtype);
                    }
                }
                while (rscore.Count <= messagetype.Count)
                {
                    Double i2 = r.NextDouble();
                    String score1 = i2.ToString("0.#");
                    Double score2 = double.Parse(score1);
                    rscore.Add(score2);
                }
              // Message msg = new Message(messagetype, rscore);
               msg._messageCategories = messagetype;
               msg._relevanceScore = rscore;
                msg.id = i;
                form1mesg.Add(new Message(messagetype, rscore));
                //form1mesg.Add(msg);
                if (i == k1) { return; }
               
            }
        }

        public void ExportToExcel(System.Data.DataTable dt)
        { 
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();   
            app.Visible = false;   
            Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);   
            Worksheet ws = (Worksheet)wb.ActiveSheet;   
            //for (int i = 0; i < dt.Columns.Count; i++)   
            //{   
            //    ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;   
            //}   
            for (int i = 0; i < dt.Rows.Count; i++)   
            {   
                for (int j = 0; j < dt.Columns.Count; j++)   
                {   
                    ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();   
                }   
            }   
            wb.SaveAs();   
            wb.Close();   
            app.Quit();   
        }




        public void buttonCreate_Click(object sender, EventArgs e)
        {

            Small_List = new List<Node>();
            Med_List = new List<Node>();
            Large_List = new List<Node>();
            form1mesg = new List<Message>();
            small_Count = Convert.ToInt32(textBoxSmall.Text);
            med_Count = Convert.ToInt32(textBoxMed.Text);
            large_Count = Convert.ToInt32(textBoxLarge.Text);
           // InterestTopics = Convert.ToInt32(textBoxInterestTopics.Text);

            int SmallSize = Convert.ToInt32(textBoxSmallSize.Text);
            int MedSize = Convert.ToInt32(textBoxMediumSize.Text);
            int LargeSize = Convert.ToInt32(textBoxLargeSize.Text);

            int smallListsize = small_Count * SmallSize; //total number of nodes in small sized clusters
            int MedListSize = med_Count * MedSize; //total number of nodes in med sized clusters
            int LargeListSize = large_Count * LargeSize; //total number of nodes in large sized clusters

            n = smallListsize + MedListSize + LargeListSize; //total number of nodes
            Randommesg();
            AppendToExcel();
            Console.WriteLine(form1mesg.Count.ToString());

           // for (int prb = 0; prb < InterestTopics; prb++)
          //  {
          //      Double prob = Convert.ToDouble(textBoxProbablity.Lines[prb]);
           //     Probabalities.Add(prob);
           // }
            for (int i = 0; i < smallListsize; i++)
            {

                Node node = new Node();
                node.Density = generateRandom(0, 100);
                node.Id = ID;
                
                //[Removed :]
                // node.InterestArray = new int[InterestTopics];


                //[Added :]
                node.InterestList = categoriesJson[ID];
                
                Nodes dispNode = new Nodes();
                dispNode.name = node.Id.ToString(); 
                dispNode.group = "red";

                jsonfile.nodes.Add(dispNode);


                nodes.Add(node);

                Small_List.Add(node);
                ID++;
            }


            // [Removed :] as this deosn't seem to be needed anymore
            // InterestDistribution(Small_List);
           

            smallList = splitAndReturn(Small_List, SmallSize); //cluster of small sized list
            SmallGraph = new List<Graph<Node>>();

            foreach (var ListofNodes in smallList)
            {
                Node LeaderNode = IsLeader(ListofNodes);
                Leaders.Add(LeaderNode);
                Graph<Node> graphSmall = new Graph<Node>();
                for (int num = 0; num < ListofNodes.Count; num++)
                {
                    graphSmall.AddNode(ListofNodes[num]);
                }

                SmallGraph.Add(graphSmall);
            }
            for (int sm = 0; sm < smallList.Count; sm++)
            {
                createEdges(smallList[sm], SmallGraph[sm]);
            }


            for (int i = 0; i < MedListSize; i++)
            {
                Node node = new Node();
                node.Density = generateRandom(0, 100);
                node.Id = ID;

                //[Removed :]
                //node.InterestArray = new int[InterestTopics];


                //[Added :]
                node.InterestList = categoriesJson[ID];

                Nodes dispNode = new Nodes();
                dispNode.name = node.Id.ToString(); 
                dispNode.group = "red";

                jsonfile.nodes.Add(dispNode);


                nodes.Add(node);
                Med_List.Add(node);
                ID++;
            }


            MedList = splitAndReturn(Med_List, MedSize);

            // [Removed :] as this deosn't seem to be needed anymore
            // InterestDistribution(Med_List);


            MedGraph = new List<Graph<Node>>();

            foreach (var ListofNodes in MedList)
            {
                Node LeaderNode = IsLeader(ListofNodes);
                Leaders.Add(LeaderNode);
                Graph<Node> graphMed = new Graph<Node>();
                for (int num = 0; num < ListofNodes.Count; num++)
                {
                    graphMed.AddNode(ListofNodes[num]);
                }

                MedGraph.Add(graphMed);
            }
            for (int med = 0; med < MedList.Count; med++)
            {
                createEdges(MedList[med], MedGraph[med]);
            }


            for (int i = 0; i < LargeListSize; i++)
            {
                Node node = new Node();
                node.Density = generateRandom(0, 100);
                node.Id = ID;

                 //[Removed :]
                // node.InterestArray = new int[InterestTopics];


                //[Added :]
                node.InterestList = categoriesJson[ID];

                Nodes dispNode = new Nodes();
                dispNode.name = node.Id.ToString();
                dispNode.group = "red";


                jsonfile.nodes.Add(dispNode);


                nodes.Add(node);
                Large_List.Add(node);
                ID++;
            }

            // [Removed :] as this deosn't seem to be needed anymore
           // InterestDistribution(Large_List);
            
            
            LargeList = splitAndReturn(Large_List, LargeSize);
            LargeGraph = new List<Graph<Node>>();
            foreach (var ListofNodes in LargeList)
            {
                Node LeaderNode = IsLeader(ListofNodes);
                Leaders.Add(LeaderNode);
                Graph<Node> graphLarge = new Graph<Node>();
                for (int num = 0; num < ListofNodes.Count; num++)
                {
                    graphLarge.AddNode(ListofNodes[num]);
                }

                LargeGraph.Add(graphLarge);
            }
            for (int lrg = 0; lrg < LargeList.Count; lrg++)
            {
                createEdges(LargeList[lrg], LargeGraph[lrg]);
            }

            LeadersGraph = new Graph<Node>();
            for (int lead = 0; lead < Leaders.Count; lead++)
            {
                LeadersGraph.AddNode(Leaders[lead]);
            }
            createEdges(Leaders, LeadersGraph);

            
            // [Removed :] as this doesn't seem appropriate anymore
           // for (int k = 0; k < nodes.Count; k++)
           // {
           //     string InterestString = " ";
            //    for (int k1 = 0; k1 < nodes[k].InterestArray.Length; k1++)
            //    {
            //        InterestString = InterestString + String.Format("{0} ,", nodes[k].InterestArray[k1]);
            //    }
            //    jsonfile.nodes[nodes[k].Id].name = nodes[k].Id.ToString() + ", " + InterestString + " }";

          //  }

           
            string jsonSerData = JsonConvert.SerializeObject(jsonfile, Formatting.Indented);
            System.IO.File.WriteAllText(path + "\\..\\Debug\\" + "graph.json", jsonSerData);
            
            Form2 frm = new Form2();
            frm.Show();

            

            System.Diagnostics.Process.Start("http://localhost:9000/graph.html");
        }

        public static Node GetNode(int ID)
        {
            Node SendNode = new Node();

            for (int i = 0; i < nodes.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(ID);
                if (nodes[i].Id == ID)
                {
                    SendNode = nodes[i];
                }
            }
            return SendNode;
        }

        public static Node IsLeader(List<Node> lists)
        {
            Node Leadernode = lists.OrderBy(node => node.Density).Last();
            return Leadernode;
        }

        public static void createEdges(List<Node> listofNodes, Graph<Node> graph) //adds elements to adj list of nodes depending on its density
        {
            for (int n = 0; n < listofNodes.Count; n++)
            {
                int count = 0;
                while (count < listofNodes[n].Density)
                {
                    int number = rnd.Next(listofNodes.Count);

                    graph.AddEdge(listofNodes[n], listofNodes[number]);

                    Links link = new Links();
                    link.source = listofNodes[n].Id;
                    link.target = listofNodes[number].Id;
                    link.value = 2;
                    link.length = 0.6;

                    jsonfile.links.Add(link);

                    count++; 
                }
            }
        }

        //public static void AddEdgesForLeaders(List<Node> listofLeaders)
        //{
        //    for (int i = 0; i < listofLeaders.Count - 1; i++)
        //    {
        //        Links link = new Links();
        //        link.source = listofLeaders[i].Id;
        //        link.target = listofLeaders[i + 1].Id;
        //        link.value = 2;
        //        link.length = 0.3;

        //        jsonfile.links.Add(link);
        //    }
        //}

        public List<List<Node>> splitAndReturn(List<Node> numbers, int size)
        {
            List<List<Node>> smallList = new List<List<Node>>();
            for (int i = 0; i < numbers.Count; i++)
            {
                 List<Node> small;
                if (i + size > numbers.Count)
                {
                   small = numbers.GetRange(i, numbers.Count - i);
                }
                else
                {
                   small = numbers.GetRange(i, size);
                    
                }
                smallList.Add(small);
                i = (i + size) - 1;
            }
            return smallList;

        }

        
        public static int generateRandom(int min, int max)
        {
            int random = rnd.Next(min, max);
            return random;
        }

        //to Generate inputs programatically

        Random rnd1 = new Random();
        Random rnd2 = new Random();
        Random rnd3 = new Random();
        Random rnd4 = new Random();
        Random rnd5 = new Random();
        Random rnd6 = new Random();
        public void Form1_Load(object sender, EventArgs e)
        {
            int i1 = rnd1.Next(100);
            int i2 = rnd2.Next(1,i1);
            int i3 = rnd3.Next(1,i1);
            int i4 = rnd4.Next(i2,100);
            int i5 = rnd5.Next(1,i3);
            int i6 = rnd6.Next(i4,100);
            
            textBoxSmall.Text = i1.ToString();
            textBoxSmallSize.Text = i2.ToString();
            textBoxMed.Text = i3.ToString();
            textBoxMediumSize.Text = i4.ToString();
            textBoxLarge.Text = i5.ToString();
            textBoxLargeSize.Text = i6.ToString();
}
        
              
       // [Removed :] as this is not needed anymore
       // public static void InterestDistribution(List<Node> InterestList)
     //   {
           // for (int p = 0; p < Probabalities.Count; p++)
         //   {
         //       int calculate = Convert.ToInt32(Probabalities[p] * InterestList.Count);
        //
         //       for (int n = 0; n < calculate; n++)
        //        {
         //           InterestList[n].InterestArray[p] = p + 1;
         //       }
         //   }
     //   }

    }



    public class Node
    {
        public int Id { get; set; }
        public int Density { get; set; }
        public int mesgsend { get; set; }
        public int mesgappri { get; set; }
        // [Removed :] as this is not being used now
        //public int[] InterestArray { get; set; }

        // [ADDED : ] maintains the interest list along with the interest factor fo reach node
        public Dictionary<String, Dictionary<String, double>> InterestList { get; set; }
        public List<Message> nodemesg { get; set; }
        public HashSet<Message> mesgforwarded { get; set; }
        public HashSet<Message> him { get; set; }
        public HashSet<Message> himr { get; set; }
        public HashSet<Message> mim { get; set; }
        public HashSet<Message> mimr { get; set; }
        public HashSet<Message> lim { get; set; }
        public HashSet<Message> limr { get; set; }
        public HashSet<Message> appri { get; set; }
        public List<Node> Neighbors { get; set; }
        public List<Node> visited { get; set; }
        public List<Node> recv { get; set; }
        public Boolean IsMessageRecvd = false;
        public string Data = " ";

        public Node()
        {
            mesgsend = 0;
            nodemesg = new List<Message>();
            mesgforwarded = new HashSet<Message>();
            him = new HashSet<Message>();
            himr = new HashSet<Message>();
            mim = new HashSet<Message>();
            mimr = new HashSet<Message>();
            lim = new HashSet<Message>();
            limr = new HashSet<Message>();
            appri = new HashSet<Message>();
            Neighbors = new List<Node>();
            recv = new List<Node>();
        }

        public static int GetDensity(Node n)
        {
            return n.Density;
        }

    }

    // [ADDED : ] This is the enum for the Interest Factor for each node
    struct InterestFactor
    {
        public static double NOT_AT_ALL = 0;
       public static double NOT_INTERESTED = 1;
       public static double NOT_VERY_INTERESTED = 2;
       public static double OKAY = 3;
       public static double INTERESTED = 4;
       public static double VERY_INTERESTED = 5;

    }

    public class Graph<T>
    {
        public List<Node> nodeSet { get; set; }
        public int[] Type { get; set; }

        public Graph()
        {
            nodeSet = new List<Node>();
        }

        public Graph(List<Node> nodeSet)
        {
            if (nodeSet == null)
                this.nodeSet = new List<Node>();
            else
                this.nodeSet = nodeSet;
        }

        public void AddNode(Node node)
        {
            nodeSet.Add(node);
        }

        public void AddEdge(Node from, Node to)
        {
            from.Neighbors.Add(to);

        }

        public int Count()
        {
            return nodeSet.Count;
        }
    }

    public class Message
    {
       // [Removed : ] the integer type as we are storing the list of the categories and not just one type as the messag may belong to multiple categories
       // public int _type { get; set; }
        public int id { get; set; }
        public string Data { get; set; }

        // [ADDED : ] this is the list of the categories a particular message belongs to
        public List<String> _messageCategories { get; set; }

        public List<double> _relevanceScore { get; set; }
      //  public DateTime expire=new DateTime();
      //  public List<Message> messg {get;set;}
        public HashSet<Node> hi= new HashSet<Node>();
        public HashSet<Node> hir = new HashSet<Node>();
        public HashSet<Node> mir = new HashSet<Node>();
        public HashSet<Node> mi = new HashSet<Node>();
        public HashSet<Node> li = new HashSet<Node>();
        public HashSet<Node> lir = new HashSet<Node>();


        public Message(List<String> messageCategories, List<double> relevanceScore)
        {
           _messageCategories = messageCategories;
           _relevanceScore = relevanceScore;
            //messg = new List<Message>();
        }
    }
   
    public class Nodes
    {
        public string name;
        public string group;
        public string text;
    }


    public class Links
    {
        public int source;
        public int target;
        public int value;
        public double length;
    }

    public class JsonFile
    {
        public List<Nodes> nodes = new List<Nodes>();
        public List<Links> links = new List<Links>();
    }

    public class GroupData
    {
        public string name;
        public string value;
    }

    public class GroupList
    {
        public List<GroupData> groupnames = new List<GroupData>();
    }
}




