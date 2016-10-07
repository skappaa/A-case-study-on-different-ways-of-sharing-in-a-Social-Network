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

namespace WindowsFormsApplicationFinal
{

    public partial class Form1 : Form
    {
        public static Random rnd = new Random();
        public static List<Node> nodes = new List<Node>();
        public static List<Node> Small_List, Med_List, Large_List; //List
        public static int InterestTopics;
        public static List<List<Node>> smallList, MedList, LargeList; //List of Lists representing clusters
        public static Graph<Node> LeadersGraph; //Graph of Leader Nodes
        public static List<Graph<Node>> SmallGraph, MedGraph, LargeGraph; //List of Graphs for List of Lists to createEdges
        public static List<Node> Leaders = new List<Node>(); //List of Leader Nodes
        public static int small_Count, med_Count, large_Count;
        public static JsonFile jsonfile = new JsonFile();
        public static string path = Directory.GetCurrentDirectory();
        public static List<Double> Probabalities = new List<Double>();
        public static int ID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public void buttonCreate_Click(object sender, EventArgs e)
        {

            Small_List = new List<Node>();
            Med_List = new List<Node>();
            Large_List = new List<Node>();
            Message msg = new Message(1);


            small_Count = Convert.ToInt32(textBoxSmall.Text);
            med_Count = Convert.ToInt32(textBoxMed.Text);
            large_Count = Convert.ToInt32(textBoxLarge.Text);
            InterestTopics = Convert.ToInt32(textBoxInterestTopics.Text);

            int smallListsize = small_Count * 10; //total number of nodes in small sized clusters
            int MedListSize = med_Count * 30; //total number of nodes in med sized clusters
            int LargeListSize = large_Count * 50; //total number of nodes in large sized clusters

            int n = (small_Count * 10) + (med_Count * 30) + (large_Count * 50); //total number of nodes

            for (int prb = 0; prb < InterestTopics; prb++)
            {
                Double prob = Convert.ToDouble(textBoxProbablity.Lines[prb]);
                Probabalities.Add(prob);
            }

            for (int i = 0; i < smallListsize; i++)
            {

                Node node = new Node();
                node.Density = generateRandom(0, 10);
                node.Id = ID;
                node.InterestArray = new int[InterestTopics];
                Nodes dispNode = new Nodes();
                dispNode.name = node.Id.ToString(); 
                dispNode.group = "red";

                jsonfile.nodes.Add(dispNode);


                nodes.Add(node);
                Small_List.Add(node);
                ID++;
            }

            InterestDistribution(Small_List);
            smallList = splitAndReturn(Small_List, 10); //cluster of small sized list
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
                node.Density = generateRandom(0, 10);
                node.Id = ID;
                node.InterestArray = new int[InterestTopics];
                Nodes dispNode = new Nodes();
                dispNode.name = node.Id.ToString(); 
                dispNode.group = "red";

                jsonfile.nodes.Add(dispNode);


                nodes.Add(node);
                Med_List.Add(node);
                ID++;
            }


            MedList = splitAndReturn(Med_List, 30);
            InterestDistribution(Med_List);
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
                node.Density = generateRandom(0, 10);
                node.Id = ID;
                node.InterestArray = new int[InterestTopics];
                Nodes dispNode = new Nodes();
                dispNode.name = node.Id.ToString();
                dispNode.group = "red";


                jsonfile.nodes.Add(dispNode);


                nodes.Add(node);
                Large_List.Add(node);
                ID++;
            }

            InterestDistribution(Large_List);
            LargeList = splitAndReturn(Large_List, 50);
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


            int indexofSendNode = Convert.ToInt32(textIndexofsendNode.Text);
            Node SendMessagetoNode = GetNode(indexofSendNode);
            Send(SendMessagetoNode, msg);

            string jsonSerData = JsonConvert.SerializeObject(jsonfile);
            System.IO.File.WriteAllText(path + "\\" + "graph.json", jsonSerData);
        }

        public static Node GetNode(int ID)
        {
            Node SendNode = new Node();

            for (int i = 0; i < nodes.Count; i++)
            {
                if (ID == nodes[i].Id)
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

        public List<List<Node>> splitAndReturn(List<Node> numbers, int size)
        {
            List<List<Node>> smallList = new List<List<Node>>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i + size > numbers.Count)
                {
                    List<Node> small = numbers.GetRange(i, numbers.Count - i);
                }
                else
                {
                    List<Node> small = numbers.GetRange(i, size);
                    smallList.Add(small);
                    i = (i + size) - 1;
                }
            }
            return smallList;

        }

        public static void PrintList(List<Node> listtoPrint)
        {
            foreach (Node node in listtoPrint)
            {
                Console.WriteLine(node + " has density " + node.Density + "And neighbors " + node.Neighbors.Count);
            }
        }
        public static int generateRandom(int min, int max)
        {
            int random = rnd.Next(min, max);
            return random;
        }

        public static void Send(Node node, Message msg)
        {


            node.IsMessageRecvd = true;
            node.Data = msg.Data;
            jsonfile.nodes[node.Id].group = "blue";
            jsonfile.nodes[node.Id].name = node.Id.ToString();

            int select = rnd.Next(0, 3);
            if (select == 0)
            {

            }
            else if (select == 1)
            {
                for (int i = 0; i < node.Neighbors.Count; i++)
                {
                    if (node.Neighbors[i].IsMessageRecvd == false) //&& !Leaders.Contains(node.Neighbors[i]))
                    {
                        Send(node.Neighbors[i], msg);
                    }
                    i++;

                }
            }
            else
            {
                for (int i = 0; i < node.Neighbors.Count; i++)
                {
                    if (node.Neighbors[i].IsMessageRecvd == false)// && !Leaders.Contains(node.Neighbors[i]))
                    {
                        Send(node.Neighbors[i], msg);
                    }

                }

            }


        }


        public static void InterestDistribution(List<Node> InterestList)
        {
            for (int p = 0; p < Probabalities.Count; p++)
            {
                int calculate = Convert.ToInt32(Probabalities[p] * InterestList.Count);

                for (int n = 0; n < calculate; n++)
                {
                    InterestList[n].InterestArray[p] = p + 1;
                }
            }
        }

    }



    public class Node
    {
        public int Id { get; set; }
        public int Density { get; set; }
        public int[] InterestArray { get; set; }
        public List<Node> Neighbors { get; set; }
        public Boolean IsMessageRecvd = false;
        public string Data = " ";

        public Node()
        {
            Neighbors = new List<Node>();
        }

        public static int GetDensity(Node n)
        {
            return n.Density;
        }

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
        public int _type { get; set; }
        public string Data { get; set; }

        public Message(int type)
        {
            _type = type;
        }
    }

    public class Nodes
    {
        public string name;
        public string group;
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


