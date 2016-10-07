using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Microsoft.Office.Interop.Excel;
using System.IO;
namespace WindowsFormsApplicationFinal
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // public static jsonFile jsonfile = new jsonFile();
        public static string mypath= @"C:\Users\Sumukhi Kappa\Desktop\Sumukhi\mastersproject\executablecode";
        static int functionCounter = 1;
        static int highInterestedNodes = 0;
        static int allHighInterestedNodes = 0;
        static int lowInterestedNodes = 0;
        static int allLowInterestedNodes = 0;
        static int medint = 0;
        static int medintrecv = 0;
        static int mesgsend;
        public static jsonfile file = new jsonfile();
        Random rnd1 = new Random();
        Random rnd2 = new Random();
        Random rnd3 = new Random();
        Random rnd4 = new Random();
        Random rnd5 = new Random();


        string[] arr = { "sports", "reebok", "nike", "adidas", "cookware", "home decor", "tools", "toys", "clothes", "appliances", "electronics", "phones", "computers" };
        public void Form2_Load(object sender, EventArgs e)
        {
            int i1 = rnd1.Next(13);
            double i2 = rnd2.NextDouble();
            if (i2 > 1)
            {
                i2 = 0;
            }

            int i3 = rnd3.Next(1, Form1.n);
            int i4 = rnd4.Next(i3, Form1.n);
            int i5 = rnd5.Next(1, 10);
            textBoxMessageType.Text = arr[i1];
            RelevanceTextBox.Text = i2.ToString("0.#");
            textIndexofsendNode.Text = i3.ToString();
            noOfNodes.Text = i4.ToString();
            noOfSecs.Text = i5.ToString();
        }



        //[: Removed] Instead of exporting, appending to existing excel

        /* public void ExportToExcel(System.Data.DataTable dt)
         {
             Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
             app.Visible = false;
             Workbook wb = app.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
             Worksheet ws = (Worksheet)wb.ActiveSheet;
             for (int i = 0; i < dt.Columns.Count; i++)
             {
                 ws.Cells[1, i + 1] = dt.Columns[i].ColumnName;
             }
             for (int i = 0; i < dt.Rows.Count; i++)
             {
                 for (int j = 0; j < dt.Columns.Count; j++)
                 {
                     ws.Cells[i + 2, j + 1] = dt.Rows[i][j].ToString();
                 }
             }
             wb.SaveAs("D:\\KalyaniData.xls");
             wb.Close();
             app.Quit();
         }*/


        private static Microsoft.Office.Interop.Excel.Workbook mWorkBook;
        private static Microsoft.Office.Interop.Excel.Sheets mWorkSheets;
        private static Microsoft.Office.Interop.Excel.Worksheet mWSheet1;
        private static Microsoft.Office.Interop.Excel.Application oXL;
        object Missing = System.Reflection.Missing.Value;

        public void AppendToExcel()
        {
            string path = mypath + @"\windowsform.xls";
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



            int i1;
            i1 = rowCount + 1;
           // Console.WriteLine(i1);
            string chk = "";
            if (strategy1.Checked)
            {
                chk = strategy1.Text;
            }
            if (strategy2.Checked)
            {
                chk = strategy2.Text;
            }
            if (strategy3.Checked)
            {
                chk = strategy3.Text;
            }
            if (strategy4.Checked)
            {
                chk = strategy4.Text;
            }
            if (strategy5.Checked)
            {
                chk = strategy5.Text;
            }
            if (strategy6.Checked)
            {
                chk = strategy6.Text;
            }


            mWSheet1.Cells[i1, 7] = textBoxMessageType.Text;
            mWSheet1.Cells[i1, 8] = RelevanceTextBox.Text;
            mWSheet1.Cells[i1, 9] = textIndexofsendNode.Text;
            mWSheet1.Cells[i1, 10] = noOfNodes.Text;
            mWSheet1.Cells[i1, 11] = noOfSecs.Text;
            mWSheet1.Cells[i1, 12] = chk;

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
            i1++;

        }


        public void AppendToExcel2()
        {
            string path = mypath + @"\windowsform.xls";
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
            // int rowCount = range.Rows.Count;
            int i1;
            i1 = rowCount;
            try
            {
                string NodeCount = intrecv.Count.ToString();
                string highIntrec = hir.Count.ToString();
                string highint = hi.Count.ToString();
                String mintr = mir.Count.ToString();
                String mint = mi.Count.ToString();
                string lowIntNodes = lir.Count.ToString();
                string lowin = li.Count.ToString();
                string noin = (interested.Count - intrecv.Count).ToString();
                String totalnodes = Form1.n.ToString();
                int hintreceived = Convert.ToInt32(highInterestedNodes);
                int hinterest = Convert.ToInt32(allHighInterestedNodes);
                float hintpercent = (float)hintreceived / (float)hinterest;
                int lintreceived = Convert.ToInt32(lowInterestedNodes);
                int linterest = Convert.ToInt32(allLowInterestedNodes);
                double lintpercent = (float)lintreceived / (float)linterest;
                int total = hinterest + linterest;
                int received = Convert.ToInt32(Form1.NodeCount);
               // Console.WriteLine(received);
               // Console.WriteLine(total);
                float totalpercent = (float)total / (float)received;
              //  Console.WriteLine(totalpercent);
                mWSheet1.Cells[i1, 13] = NodeCount;
                mWSheet1.Cells[i1, 14] = noin;
                mWSheet1.Cells[i1, 15] = totalnodes;
                mWSheet1.Cells[i1, 16] = mesgrecv;

                




            }
            catch (DivideByZeroException e) { }

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
            i1++;
        }



        public void buttonSend_Click(object sender, EventArgs e)
        {

            int k = (val1 + val2 + val3 + val4 + val5 + val6);

            if ( k != 100)
            {
                MessageBox.Show("The sum of strategie values should be 100, it is : " + k.ToString());
                return;
            }



            Form1.NodeCount = 0;
            highInterestedNodes = 0;
            allHighInterestedNodes = 0;
            lowInterestedNodes = 0;
            allLowInterestedNodes = 0;
            medint = 0;
            medintrecv = 0;
            mesgrecv = 0;
            Form2.time = 0;
            i = 0;
            file.nodes.Clear();
            if (r != null && ro != null)
            {
                r.Clear();
                ro.Clear();
            }
            foreach (Node node in Form1.nodes)
            {
                node.IsMessageRecvd = false;
                node.mesgsend = 0;
                node.mesgforwarded.Clear();
                node.nodemesg.Clear();
                node.him.Clear();
                node.himr.Clear();
                node.mim.Clear();
                node.mimr.Clear();
                node.lim.Clear();
                node.limr.Clear();
                node.appri.Clear();
            }
            foreach (Message messg in Form1.form1mesg)
            {
                messg.hi.Clear();
                messg.hir.Clear();
                messg.mi.Clear();
                messg.mir.Clear();
                messg.li.Clear();
                messg.lir.Clear();
            }
             hi.Clear(); li.Clear(); hir.Clear(); lir.Clear(); mi.Clear(); mir.Clear(); message.Clear(); interested.Clear(); intrecv.Clear();
            Form2.time = 0;
            DateTime time = DateTime.Now;

            //[Added : ] the message type should be a list of categories entered by the user
            List<String> MessageType = (textBoxMessageType.Text).Split(',').ToList();
            List<double> relevanceScore = ((RelevanceTextBox.Text).Split(',').ToList()).Select(x => double.Parse(x)).ToList();
            int totalNumberOfNodes = Convert.ToInt32(noOfNodes.Text);
            int totalNumberOfSecs = Convert.ToInt32(noOfSecs.Text);

            Message msg = new Message(MessageType, relevanceScore);
            message.Add(msg);
            int indexofSendNode = Convert.ToInt32(textIndexofsendNode.Text);
            // Double ProbabilityofNodes = Convert.ToDouble(textBoxProbabilityofNodes.Text);
                file.nodes1.Clear();
            Node SendMessagetoNode = GetNode(indexofSendNode);
            Send(SendMessagetoNode, msg, totalNumberOfNodes, totalNumberOfSecs, time);
            //Randmesg();
            Send1(r, message, totalNumberOfNodes, totalNumberOfSecs, time);
            //mesgout();

            string jsonSerData = JsonConvert.SerializeObject(Form1.jsonfile, Formatting.Indented);
            System.IO.File.WriteAllText(Form1.path + "\\..\\Debug\\" + "graph2.json", jsonSerData);
            string jsonSerData1 = JsonConvert.SerializeObject(file, Formatting.Indented, new JsonSerializerSettings
            {
                // DefaultValueHandling=DefaultValueHandling.Ignore
            });
            System.IO.File.WriteAllText(Form1.path + "\\..\\Debug\\" + "mesgout.json", jsonSerData1);
            //jsonSerData1.DefaultValueHandling.Ignore;

            AppendToExcel();
            excel1();
            excel2();
            Console.WriteLine(Form2.time + "time.\n");
           Console.WriteLine(Form2.mesgrecv + "mesgrecv");
           // Console.WriteLine(allHighInterestedNodes + "highintnodes");
           // Console.WriteLine(allLowInterestedNodes + "lowintnodes");
           // Console.WriteLine(medint+ "medint");
            Console.WriteLine(interested.Count.ToString() + "interested");
            Console.WriteLine(intrecv.Count.ToString() + "interestedreceived");
            Console.WriteLine(message.Count.ToString() + "messagecount");
            int e2 = 1;
            foreach (Message m in message)
            {
                    Console.WriteLine("message"+e2);
                    
                for (int e1 = 0; e1 < m._messageCategories.Count; e1++)
                {
                    String category = m._messageCategories[e1];
                    double relevance = m._relevanceScore[e1];
                    Console.Write(category);
                    Console.Write(relevance.ToString());
                       }
                e2++;
            }
            // MessageBox.Show(Form1.NodeCount.ToString() + " nodes received message.\n" + highInterestedNodes.ToString() + " nodes are highly interested in the message and received the message.\n" + allHighInterestedNodes.ToString() + " nodes are the total number of nodes that are highly interested in the message.\n" + lowInterestedNodes.ToString() + " nodes are low interested in the message and received the message.\n" + allLowInterestedNodes.ToString() + " nodes are the total number of nodes that are low interested in the message.\n" + (Form1.nodes.Count - Form1.NodeCount).ToString() + " nodes did not receive message.\n"+ mesgsend.ToString()+"Number of messages are sent");
            MessageBox.Show(intrecv.Count.ToString() + " nodes received message.\n" + hir.Count.ToString() + " nodes are highly interested in the message and received the message.\n" + hi.Count.ToString() + " nodes are the total number of nodes that are highly interested in the message.\n" + mir.Count.ToString() + " nodes are moderate interested in the message and received the message.\n" + mi.Count.ToString() + " nodes are the total number of nodes that are moderate interested in the message.\n" + lir.Count.ToString() + " nodes are low interested in the message and received the message.\n" + li.Count.ToString() + " nodes are the total number of nodes that are low interested in the message.\n" + (Form1.nodes.Count - intrecv.Count).ToString() + " nodes did not receive message.\n" + mesgrecv.ToString() + "Number of messages are sent");
            
            AppendToExcel2();
            excel();
          // excel1();
        }

        public static Node GetNode(int ID)
        {
            Node SendNode = new Node();
            Node SendN = new Node();
            for (int i = 0; i < Form1.nodes.Count; i++)
            {
                if (Form1.nodes[i].Id == ID)
                {
                    SendNode = Form1.nodes[i];
                    Node sendnode = new Node();
                    sendnode = Form1.nodes[i];
                    mout ms = new mout();
                    ms.nodeid = sendnode.Id;
                    ms.val1 = 0;
                    ms.appriciated = 0;
                    file.nodes.Add(ms);
                    visit v = new visit();
                    v.nodeid = sendnode.Id;
                    v.visited = 0;
                    file.vist.Add(v);
                }
                else
                {
                    SendN = Form1.nodes[i];
                    mout ms = new mout();
                    ms.nodeid = SendN.Id;
                    ms.val1 = 0;
                    ms.appriciated = 0;
                    file.nodes.Add(ms);
                    visit v = new visit();
                    v.nodeid = SendN.Id;
                    v.visited = 0;
                    file.vist.Add(v);
                }
            }
            return SendNode;
        }
        // public static HashSet<Node> p = new HashSet<Node>();
        public static List<Node> r = new List<Node>();
        public static List<Node> ro = new List<Node>();
        public static HashSet<Node> hi = new HashSet<Node>();
        public static HashSet<Node> li = new HashSet<Node>();
        public static HashSet<Node> hir = new HashSet<Node>();
        public static HashSet<Node> lir = new HashSet<Node>();
        public static HashSet<Node> interested = new HashSet<Node>();
        public static HashSet<Node> intrecv = new HashSet<Node>();
        public static HashSet<Node> mir = new HashSet<Node>();
        public static HashSet<Node> mi = new HashSet<Node>();
        public static int msout;
         public static int mesgapp;
        public static Queue<Node> que = new Queue<Node>();
        public static int time;
        public static List<Message> message = new List<Message>();
        public static int mesgrecv = 0;
       public static int i;
        public static void Send(Node node, Message msg, int totalNumberOfNodes, int totalNumberOfSecs, DateTime startTime)
        {

            


            

            node.IsMessageRecvd = true; // setting the sender node's isMessageRecvd value to true so we do not echo back the message to the sender
            node.mesgforwarded.Add(msg);

            int length = node.Neighbors.Count / 2;
            int i = 0;
            foreach (Node neighbor in node.Neighbors)
            {
                TimeSpan current = DateTime.Now.Subtract(startTime);
                double secsCount = current.TotalSeconds;

                if ( mesgrecv>= totalNumberOfNodes || Form2.time>= 100)
                {
                    //|| secsCount >= totalNumberOfSecs,Form1.NodeCount
                    return;
                }

               // if (neighbor.IsMessageRecvd == true)
                //{

                  //  continue;
                //}
                if (neighbor.nodemesg.Contains(msg))
                {
                    continue;
                }

                Boolean isInterested;







                // adding logic here


                //adding code her by sumukhi
                if (i < ((val1 / 100) * node.Neighbors.Count))
                    isInterested = isNodeInterested1(neighbor, msg, node);
                else if (i < (((val2 + val1) / 100) * node.Neighbors.Count))
                    isInterested = isNodeInterested2(neighbor, msg, node);
                else if (i < (((val3 + val2 + val1) / 100) * node.Neighbors.Count))
                    isInterested = isNodeInterested3(neighbor, msg, node);
                else if (i < (((val4 + val3 + val2 + val1) / 100) * node.Neighbors.Count))
                    isInterested = isNodeInterested4(neighbor, msg, node);
                else if (i < (((val5 + val4 + val3 + val2 + val1) / 100) * node.Neighbors.Count))
                    isInterested = isNodeInterested5(neighbor, msg, node);
                else
                    isInterested = isNodeInterested6(neighbor, msg, node);










                /*
                if (i <= length)//(functionCounter == 2)
                {
                    isInterested = isNodeInterested2(neighbor, msg, node);
                }

                else if (i > length)//(functionCounter == 3)
                {
                    isInterested = isNodeInterested3(neighbor, msg, node);
                }
                else if (functionCounter == 4)
                {
                    isInterested = isNodeInterested4(neighbor, msg, node);
                }

                else if (functionCounter == 5)
                {
                    isInterested = isNodeInterested5(neighbor, msg, node);
                }

                else if (functionCounter == 6)
                {
                    isInterested = isNodeInterested6(neighbor, msg, node);
                }

                else
                {
                    isInterested = isNodeInterested1(neighbor, msg, node);
                }
                */


                i++;



                if (isInterested)
                {
                    neighbor.IsMessageRecvd = true;
                    mout1.received(node, neighbor);
                    neighbor.Data = msg.Data;
                    Form1.jsonfile.nodes[neighbor.Id - 1].group = "blue";
                    Form1.NodeCount++;
                    if (time % 2 == 0)
                    {
                        if (!r.Contains(neighbor))
                        {
                            r.Add(neighbor);
                        }
                    }
                    else
                    {
                        if (!ro.Contains(neighbor))
                        {
                            ro.Add(neighbor);
                        }
                    }
                }
            }
        }








        // added by sumukhi
        public static int val1 = 10, val2 = 10, val3 = 10, val4 = 10, val5 = 50, val6 = 10;

        public static void Send1(List<Node> n, List<Message> mssg, int totalNumberOfNodes, int totalNumberOfSecs, DateTime startTime)
        {

          if (time >= Form1.totaltime)
            {
                return;
            }
            time++;
                if (i <Form1.form1mesg.Count)
                {
                    Message mesg = Form1.form1mesg[i];
                    message.Add(mesg);
                    i++;
                }
           // }
            foreach (Node node in n)
            {
                node.IsMessageRecvd = true; // setting the sender node's isMessageRecvd value to true so we do not echo back the message to the sender
                foreach (Node neighbor in node.Neighbors)
                {
                    foreach (Message msg in mssg)
                    {
                        if (node.mesgforwarded.Contains(msg)) { continue; }
                        //else { node.mesgforwarded.Add(msg); }
                        TimeSpan current = DateTime.Now.Subtract(startTime);
                        double secsCount = current.TotalSeconds;
                       //if (mesgrecv >= totalNumberOfNodes || Form2.time>=100)
                       // {
                       //   return;
                       // }

                       // if (neighbor.IsMessageRecvd == true)
                       // {

                       //     continue;
                       // }
                        if (neighbor.nodemesg.Contains(msg))
                        {
                            continue;
                        }

                        Boolean isInterested;











                        //adding new code 
                        if (i < ((val1 / 100) * node.Neighbors.Count))
                            isInterested = isNodeInterested1(neighbor, msg, node);
                        else if (i < (((val2 + val1) / 100) * node.Neighbors.Count))
                            isInterested = isNodeInterested2(neighbor, msg, node);
                        else if (i < (((val3 + val2 + val1) / 100) * node.Neighbors.Count))
                            isInterested = isNodeInterested3(neighbor, msg, node);
                        else if (i < (((val4 + val3 + val2 + val1) / 100) * node.Neighbors.Count))
                            isInterested = isNodeInterested4(neighbor, msg, node);
                        else if (i < (((val5 + val4 + val3 + val2 + val1) / 100) * node.Neighbors.Count))
                            isInterested = isNodeInterested5(neighbor, msg, node);
                        else
                            isInterested = isNodeInterested6(neighbor, msg, node);











                        /*

                        if (functionCounter == 2)
                        {
                            isInterested = isNodeInterested2(neighbor, msg, node);
                        }

                        else if (functionCounter == 3)
                        {
                            isInterested = isNodeInterested3(neighbor, msg, node);
                        }

                        else if (functionCounter == 4)
                        {
                            isInterested = isNodeInterested4(neighbor, msg, node);
                        }

                        else if (functionCounter == 5)
                        {
                            isInterested = isNodeInterested5(neighbor, msg, node);
                        }

                        else if (functionCounter == 6)
                        {
                            isInterested = isNodeInterested6(neighbor, msg, node);
                        }

                        else
                        {
                            isInterested = isNodeInterested1(neighbor, msg, node);
                        }



                        */

                        if (isInterested)
                        {
                            neighbor.IsMessageRecvd = true;
                            neighbor.Data = msg.Data;
                            mout1.received(node, neighbor);
                            Form1.jsonfile.nodes[neighbor.Id - 1].group = "blue";
                            Form1.NodeCount++;
                            if (time % 2 == 0)
                            {
                                if (!r.Contains(neighbor))
                                {
                                    r.Add(neighbor);
                                }
                            }
                            else
                            {
                                if (!ro.Contains(neighbor))
                                {
                                    ro.Add(neighbor);
                                }
                            }
                            //[Removed]: as it is not required any more
                            /* if (r.Count <= totalNumberOfNodes)
                             {
                                 if(!r.Contains(neighbor)){
                                  r.Add(neighbor);
                                  //que.Enqueue(neighbor);
                                 }
                             }*/
                            /* if(node.recv!=null)
                             foreach(Node n in node.recv){
                                 Send(n, msg, totalNumberOfNodes, totalNumberOfSecs, startTime);
                             }*/

                            //Send(neighbor, msg, totalNumberOfNodes, totalNumberOfSecs, startTime);
                        }
                        /* foreach (Node n in r)
                         {
                             Send(n, msg, totalNumberOfNodes, totalNumberOfSecs, startTime);
                         }*/
                        // send1(node, msg, totalNumberOfNodes, totalNumberOfSecs, startTime);
                        // send1(msg, totalNumberOfNodes, totalNumberOfSecs, startTime);

                    }
                }
                foreach (Message m1 in message)
                {
                    node.mesgforwarded.Add(m1);
                    }
            }
            if (time % 2 == 0)
            {
                if (r != null)
                {
                    Send1(r, message, totalNumberOfNodes, totalNumberOfSecs, startTime);
                    r.Clear();
                }
            }
            else
            {
                if (ro != null)
                {
                    Send1(ro, message, totalNumberOfNodes, totalNumberOfSecs, startTime);
                    ro.Clear();
                }
            }
        }

        //[Removed:] As it is not needed any more
        /*   public static void send1(Message msg, int totalNumberOfNodes, int totalNumberOfSecs, DateTime startTime)
            {
                //Console.WriteLine("count" + r.Count);
                //int rcount = r.Count;
                for (int e = 0; e<r.Count;e++)
                {
                    Console.WriteLine("count" + r.Count);
                    Node n = r[e];
                
                        Send(n, msg, totalNumberOfNodes, totalNumberOfSecs, startTime);
                    }
           
            }*/
        //[Removed:] Just used this  for some testing purpose.
      /*  public void Randmesg()
        {
            for (int i = 0; i <= 5; i++)
            {
                Random rnd1 = new Random();
                Random rnd2 = new Random();
                string[] arr = { "sports", "reebok", "nike", "adidas", "cookware", "home decor", "tools", "toys", "clothes", "appliances", "electronics", "phones", "computers" };
                int i1 = rnd1.Next(13);
                Double i2 = rnd2.NextDouble();
                String messagetyp = arr[i1];
                String score1 = i2.ToString("0.#");
                Double score2 = double.Parse(score1);
                Console.WriteLine(messagetyp + "type");
                Console.Write(score2 + "relevance");
                List<double> score = new List<double>();
                List<string> messagetype = new List<string>();
                messagetype.Add(messagetyp);
                score.Add(score2);
                Message mesg = new Message(messagetype, score);
                message.Add(mesg);
            }
        }*/
        public void excel()
        {

            string path = mypath + @"\windowsform1.xls";
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            oXL.DisplayAlerts = false;
            mWorkBook = oXL.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Get all the sheets in the workbook
            mWorkSheets = mWorkBook.Worksheets;
            //Get the allready exists sheet
            mWSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)mWorkSheets.get_Item("Sheet1");
            foreach (Node m in Form1.nodes)
            {
                Microsoft.Office.Interop.Excel.Range range = mWSheet1.UsedRange;
                int colCount = range.Columns.Count;
                int rowCount = range.Rows.Count;
                // int rowCount = range.Rows.Count;
                int i1;
                i1 = rowCount + 1; 
                    int a = m.Id;
                    int b = m.mesgsend;
                    int c = m.mesgappri;
                    //  int d = m.visited;
                    mWSheet1.Cells[i1, 1] = a;
                    mWSheet1.Cells[i1, 2] = b;
                    mWSheet1.Cells[i1, 3] = c;
                    //  mWSheet1.Cells[i1, 4] = d;
            }

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
        public void excel1()
        {

            string path = mypath + @"\windowsform1.xls";
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            oXL.DisplayAlerts = false;
            mWorkBook = oXL.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Get all the sheets in the workbook
            mWorkSheets = mWorkBook.Worksheets;
            //Get the allready exists sheet
            mWSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)mWorkSheets.get_Item("Sheet2");
            foreach (Message m in message)
            {
                Microsoft.Office.Interop.Excel.Range range = mWSheet1.UsedRange;
                int colCount = range.Columns.Count;
                int rowCount = range.Rows.Count;
                // int rowCount = range.Rows.Count;
                int i1;
                i1 = rowCount + 1;

                int a = m.hi.Count;
                int b = m.hir.Count;
                int c = m.mi.Count;
                int d = m.mir.Count;
                int e = m.li.Count;
                int f = m.lir.Count;
                mWSheet1.Cells[i1, 1] = a;
                mWSheet1.Cells[i1, 2] = b;
                mWSheet1.Cells[i1, 3] = c;
                mWSheet1.Cells[i1, 4] = d;
                mWSheet1.Cells[i1, 5] = e;
                mWSheet1.Cells[i1, 6] = f;

            }
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
        public void excel2()
        {

            string path = mypath + @"\windowsform1.xls";
            oXL = new Microsoft.Office.Interop.Excel.Application();
            oXL.Visible = true;
            oXL.DisplayAlerts = false;
            mWorkBook = oXL.Workbooks.Open(path, 0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            //Get all the sheets in the workbook
            mWorkSheets = mWorkBook.Worksheets;
            //Get the allready exists sheet
            mWSheet1 = (Microsoft.Office.Interop.Excel.Worksheet)mWorkSheets.get_Item("Sheet3");
            foreach (Node n in Form1.nodes)
            {
                Microsoft.Office.Interop.Excel.Range range = mWSheet1.UsedRange;
                int colCount = range.Columns.Count;
                int rowCount = range.Rows.Count;
                // int rowCount = range.Rows.Count;
                int i1;
                i1 = rowCount + 1;
                int a = n.Id;
                int b = n.him.Count;
                int c = n.himr.Count;
                int d = n.mim.Count;
                int e = n.mimr.Count;
                int f = n.lim.Count;
                int g = n.limr.Count;
                int h = n.appri.Count;
                int i = n.mesgsend;
                mWSheet1.Cells[i1, 1] = a;
                mWSheet1.Cells[i1, 2] = b;
                mWSheet1.Cells[i1, 3] = c;
                mWSheet1.Cells[i1, 4] = d;
                mWSheet1.Cells[i1, 5] = e;
                mWSheet1.Cells[i1, 6] = f;
                mWSheet1.Cells[i1, 7] = g;
                mWSheet1.Cells[i1, 8] = h;
                mWSheet1.Cells[i1, 9] = i;

            }
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

        // [Added : ] a new function to calculate the node's interest in the message
        // [TODO :] this function needs to be updated as needed. This is just a placeholder for now
        public static Boolean isNodeInterested1(Node node, Message msg, Node node1)
        {
           // List<String> nodesrec = new List<String>();

            for (int i = 0; i < msg._messageCategories.Count; i++)
            {
                String category = msg._messageCategories[i];
                double msgRelevance = msg._relevanceScore[i];

                if (node.InterestList.ContainsKey(category))
                {
                    interested.Add(node);
                    if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED) { allHighInterestedNodes++; hi.Add(node); msg.hi.Add(node);
                    node.him.Add(msg);
                    }
                    else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED) { allLowInterestedNodes++; li.Add(node); msg.li.Add(node);
                        node.lim.Add(msg); }
                    else
                    {
                        node.mim.Add(msg);
                        msg.mi.Add(node);
                        mi.Add(node);
                        medint++;
                    }
                }
                if (node.InterestList.ContainsKey(category) && node.InterestList[category]["score"] >= 0.1 && msgRelevance >= 0.1)
                {
                    intrecv.Add(node);
                    file.nodes[node1.Id - 1].val1++;
                    mout1 m = new mout1();
                    m.parent = node1.Id;
                    m.child = node.Id;
                    m.val = 1;
                    mesgrecv++;
                    node1.mesgsend++;
                    if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED)
                    {
                        highInterestedNodes++; hir.Add(node); msg.hir.Add(node); node.himr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);
                    }
                    else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED)
                    {
                        lowInterestedNodes++; lir.Add(node); msg.lir.Add(node); node.limr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);
                    }
                    else
                    {
                       
                        node.mimr.Add(msg);
                        msg.mir.Add(node);
                        mir.Add(node);
                        medintrecv++;
                        node.nodemesg.Add(msg);
                    }
                   // mir.Add(node);
                   // medintrecv++;
                    if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY && msgRelevance >= node.InterestList[category]["score"])
                    { file.nodes[node1.Id - 1].appriciated++; m.appriciated = 1; node.appri.Add(msg); node1.mesgappri++; }
                    else { m.appriciated = 0; }
                    file.nodes1.Add(m);
                    
                    

                    return true;
                }
            }

            return false;
        }

        // caluclate node's average interest in all the msg categories and returns true if the average factor is greater than OKAY
        private static Boolean isNodeInterested2(Node node, Message msg, Node node1)
        {

            double interestFactor = 0;
            int counter = 0;
            double totalMsgRelevance = 0.0;
            String category = "";
            double nodeRelevanceTolerance = 0.0;
            for (int i = 0; i < msg._messageCategories.Count; i++)
            {
                category = msg._messageCategories[i];
                double msgRelevance = msg._relevanceScore[i];
                if (node.InterestList.ContainsKey(category))
                {
                    interested.Add(node);
                    if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED) { allHighInterestedNodes++; hi.Add(node); msg.hi.Add(node);
                    node.him.Add(msg);
                    }
                    else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED) { allLowInterestedNodes++; li.Add(node); msg.li.Add(node);
                    node.lim.Add(msg);
                    }
                    else
                    {
                        node.mim.Add(msg);
                        msg.mi.Add(node);
                        mi.Add(node);
                        medint++;
                        totalMsgRelevance += msgRelevance;
                        nodeRelevanceTolerance += node.InterestList[category]["score"];
                        interestFactor += node.InterestList[category]["interestFactor"];
                        // nodeRelevanceTolerance += node.InterestList[category]["score"];
                        counter++;
                    }
                }
            }

            if (counter == 0)
            {
                return false;
            }

            double avgInterestFactor = interestFactor / counter;
            double avgMsgRelevance = totalMsgRelevance / counter;
            if (node.InterestList.ContainsKey(category) && avgInterestFactor >= InterestFactor.OKAY
                && avgMsgRelevance >= 0.3)
            {
                intrecv.Add(node);
                mesgrecv++;
                file.nodes[node1.Id - 1].val1++;
                mout1 m = new mout1();
                m.parent = node1.Id;
                m.child = node.Id;
                m.val = 1;
                node1.mesgsend++;
                if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED)
                {
                    highInterestedNodes++; hir.Add(node); msg.hir.Add(node); node.himr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);

                }
                else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED)
                {
                    lowInterestedNodes++; lir.Add(node); msg.lir.Add(node); node.limr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);
                }
                else
                {
                    node.nodemesg.Add(msg);
                    node1.mesgsend++;
                    node.mimr.Add(msg);
                    msg.mir.Add(node);
                    mir.Add(node);
                    medintrecv++;
                }
                if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY&&totalMsgRelevance>=nodeRelevanceTolerance) 
                { file.nodes[node1.Id - 1].appriciated++; m.appriciated = 1;
                node.appri.Add(msg); node1.mesgappri++;
                }
                else { m.appriciated = 0; }
                file.nodes1.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

        // caluclate node's average interest in all the msg categories and returns true if the average factor is greater than OKAY 
        // OR
        // if the node is very interested in any of the message categories
        private static Boolean isNodeInterested3(Node node, Message msg, Node node1)
        {
            double factor = 0;
            int counter = 0;
            double totalMsgRelevance = 0.0;
            double nodeRelevanceTolerance = 0.0;
            String category = "";
            for (int i = 0; i < msg._messageCategories.Count; i++)
            {
                category = msg._messageCategories[i];
                double msgRelevance = msg._relevanceScore[i];
                if (node.InterestList.ContainsKey(category))
                {
                    interested.Add(node);
                    if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED) { allLowInterestedNodes++; li.Add(node); msg.li.Add(node);
                    node.lim.Add(msg);
                    }
                    else if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED)
                    {
                        node1.mesgsend++;
                        node.nodemesg.Add(msg);
                        highInterestedNodes++;
                        allHighInterestedNodes++;
                        hi.Add(node);
                        msg.hi.Add(node);
                        hir.Add(node);
                        msg.hir.Add(node);
                        node.him.Add(msg);
                        node.himr.Add(msg);
                        node1.mesgsend++;
                        file.nodes[node1.Id - 1].val1++;
                        mout1 m = new mout1();
                        m.parent = node1.Id;
                        m.child = node.Id;
                        m.val = 1;
                        if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY && msgRelevance >= node.InterestList[category]["score"]) { file.nodes[node1.Id - 1].appriciated++; m.appriciated = 1;
                        node.appri.Add(msg);
                        }
                        else { m.appriciated = 0; }
                        file.nodes1.Add(m);
                        return true;
                    }
                    else
                    {
                        node.mim.Add(msg);
                        msg.mi.Add(node);
                        mi.Add(node);
                        medint++;
                    }
                    totalMsgRelevance += msgRelevance;
                    factor += node.InterestList[category]["interestFactor"];
                    nodeRelevanceTolerance += node.InterestList[category]["score"];
                    counter++;
                }
            }

            if (counter == 0)
            {
                return false;
            }

            double avgInterestFactor = factor / counter;
            double avgMsgRelevance = totalMsgRelevance / counter;
            double avgNodeRelevanceTolerance = nodeRelevanceTolerance / counter;

            if (node.InterestList.ContainsKey(category) && avgInterestFactor >= InterestFactor.OKAY && avgMsgRelevance >= avgNodeRelevanceTolerance)
            {
                intrecv.Add(node);
                mout1 m = new mout1();
              //  mesgrecv++;
                if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY)
                {
                    node1.mesgsend++;
                    node.nodemesg.Add(msg);
                    highInterestedNodes++;
                    allHighInterestedNodes++;
                    hi.Add(node);
                    msg.hi.Add(node);
                    hir.Add(node);
                    msg.hir.Add(node);
                   node.him.Add(msg);
                    node.himr.Add(msg);
                    mesgrecv++;
                    node1.mesgsend++;
                    file.nodes[node1.Id - 1].val1++;
                    m.parent = node1.Id;
                    m.child = node.Id;
                    m.val = 1;
                }
                else
                {
                    node.nodemesg.Add(msg);
                    msg.mir.Add(node);
                    node.mimr.Add(msg);
                    node1.mesgsend++;
                    file.nodes[node1.Id - 1].val1++;
                    mesgrecv++;
                    mir.Add(node);
                    medintrecv++;
                }
                if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY && avgMsgRelevance >= avgNodeRelevanceTolerance) { file.nodes[node1.Id - 1].appriciated++;
                m.appriciated = 1; node.appri.Add(msg); node1.mesgappri++;
                }
                else { m.appriciated = 0; }
            
                file.nodes1.Add(m);
                return true;
            }
            else
            {
                return false;
            }
        }

        // returns true if any of the message categories is in the node's interest list and the interest factor is anything other than NOT_INTERESTED
        private static Boolean isNodeInterested4(Node node, Message msg, Node node1)
        {
           
            for (int i = 0; i < msg._messageCategories.Count; i++)
            {
                String category = msg._messageCategories[i];
                double msgRelevance = msg._relevanceScore[i];
                if (node.InterestList.ContainsKey(category))
                {
                    interested.Add(node);
                    if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED) { allHighInterestedNodes++; hi.Add(node); msg.hi.Add(node);
                        node.him.Add(msg); }
                    else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED) { allLowInterestedNodes++; li.Add(node); msg.li.Add(node);
                    node.lim.Add(msg);
                    }
                    else
                    {
                        node.mim.Add(msg);
                        msg.mi.Add(node);
                        mi.Add(node);
                        medint++;
                    }
                }
                if (node.InterestList.ContainsKey(category) && node.InterestList[category]["interestFactor"] != InterestFactor.NOT_AT_ALL)
                {
                    intrecv.Add(node);
                    mesgrecv++;
                    file.nodes[node1.Id-1].val1++;
                    mout1 m = new mout1();
                    m.parent = node1.Id;
                    m.child = node.Id;
                    m.val = 1;
                    node1.mesgsend++;
                    if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED)
                    {
                        highInterestedNodes++; hir.Add(node); msg.hir.Add(node); node.himr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);

                    }
                    else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED)
                    {
                        lowInterestedNodes++; lir.Add(node); msg.lir.Add(node); node.limr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);
                    }
                    else
                    {
                        node1.mesgsend++; node.nodemesg.Add(msg);
                        node.mimr.Add(msg);
                        mir.Add(node);
                        msg.mir.Add(node);
                        medintrecv++;
                    }
                    if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY && msgRelevance >= node.InterestList[category]["score"])
                    { file.nodes[node1.Id - 1].appriciated++; m.appriciated = 1; node.appri.Add(msg); node1.mesgappri++; }
                    else { m.appriciated = 0; }
           
                    file.nodes1.Add(m);
                    return true;
                }
            }
            return false;
        }

        // returns true if the intrefactor and the relavnace score combined score is >= 50%
        private static Boolean isNodeInterested5(Node node, Message msg, Node node1)
        {
            for (int i = 0; i < msg._messageCategories.Count; i++)
            {
                String category = msg._messageCategories[i];
                double msgRelevance = msg._relevanceScore[i];
                if (node.InterestList.ContainsKey(category))
                {
                    interested.Add(node);
                    double interestFactor = node.InterestList[category]["interestFactor"];
                    double interestFactorPercent = (interestFactor / 5) * 100;
                    double msgRelevancePercent = ((msgRelevance / 1.0) * 100);
                    if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED) { allHighInterestedNodes++; hi.Add(node); msg.hi.Add(node);
                    node.him.Add(msg);
                    }
                    else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED) { allLowInterestedNodes++; li.Add(node); msg.li.Add(node);
                    node.lim.Add(msg);
                    }
                    else
                    {
                        node.mim.Add(msg);
                        msg.mi.Add(node);
                        mi.Add(node);
                        medint++;
                    }
                    if ((interestFactorPercent + msgRelevancePercent) / 2 >= 50)
                    {
                        intrecv.Add(node);
                        mesgrecv++;
                        file.nodes[node1.Id-1].val1++;
                        mout1 m = new mout1();
                        m.parent = node1.Id;
                        m.child = node.Id;
                        m.val = 1;
                        node1.mesgsend++;
                        if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED)
                        {
                            highInterestedNodes++; hir.Add(node); msg.hir.Add(node); node1.mesgsend++;
                            node.himr.Add(msg); node.nodemesg.Add(msg);
                        }
                        else if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED)
                        {
                            lowInterestedNodes++; lir.Add(node); msg.lir.Add(node); node.limr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);

                        }
                        else
                        {
                            node1.mesgsend++; node.nodemesg.Add(msg);
                            node.mimr.Add(msg);
                            msg.mir.Add(node);
                            mir.Add(node);
                            medintrecv++;
                        }
                        if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY && msgRelevance >= node.InterestList[category]["score"])
                        { file.nodes[node1.Id - 1].appriciated++; m.appriciated = 1; node.appri.Add(msg); node1.mesgappri++; }
                        else { m.appriciated = 0; }
                        
                        file.nodes1.Add(m);
                        return true;
                    }
                }
            }
            return false;
        }

        public static Boolean isNodeInterested6(Node node, Message msg, Node node1)
        {
            for (int i = 0; i < msg._messageCategories.Count; i++)
            {
                String category = msg._messageCategories[i];
                double msgRelevance = msg._relevanceScore[i];
                if (node.InterestList.ContainsKey(category))
                {
                    interested.Add(node);
                    if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED) { allLowInterestedNodes++; li.Add(node); msg.li.Add(node);
                    node.lim.Add(msg); 
                    }
                    else if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED) { allHighInterestedNodes++; hi.Add(node); msg.hi.Add(node);
                    node.him.Add(msg);
                    }
                    else
                    {
                        node.mim.Add(msg);
                        msg.mi.Add(node);
                        mi.Add(node);
                        medint++;
                    }
                }
                if (node.InterestList.ContainsKey(category) && node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY && msgRelevance >= 0.5)
                {
                    intrecv.Add(node);
                    mesgrecv++;
                    file.nodes[node1.Id-1].val1++;
                    mout1 m = new mout1();
                    m.parent = node1.Id;
                    m.child = node.Id;
                    m.val = 1;
                    node1.mesgsend++;
                    if (node.InterestList[category]["interestFactor"] <= InterestFactor.NOT_VERY_INTERESTED)
                    {
                        lowInterestedNodes++; lir.Add(node); msg.lir.Add(node); node.limr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);

                    }
                    else if (node.InterestList[category]["interestFactor"] == InterestFactor.VERY_INTERESTED)
                    {
                        highInterestedNodes++; hir.Add(node); msg.hir.Add(node); node.himr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);

                    }
                    else
                    {
                        node.mimr.Add(msg); node1.mesgsend++; node.nodemesg.Add(msg);
                        msg.mir.Add(node);
                        mir.Add(node);
                        medintrecv++;
                    }
                    if (node.InterestList[category]["interestFactor"] >= InterestFactor.OKAY && msgRelevance >= node.InterestList[category]["score"])
                    { file.nodes[node1.Id - 1].appriciated++; m.appriciated = 1; node.appri.Add(msg); node1.mesgappri++; }
                    else { m.appriciated = 0; }
                   
                    file.nodes1.Add(m);
                    return true;
                }
            }

            return false;
        }

        public static Boolean ifContains(int[] IntArray, object value)
        {
            int pos = Array.IndexOf(IntArray, value, 0, IntArray.Length);
            if (pos > -1)
                return true;
            else
                return false;
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            functionCounter = 3;
        }

        public void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            functionCounter = 2;
        }

        public void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        public void strategy1_CheckedChanged(object sender, EventArgs e)
        {
            functionCounter = 1;
        }

        public void strategy4_CheckedChanged(object sender, EventArgs e)
        {
            functionCounter = 4;
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void strategy5_CheckedChanged_1(object sender, EventArgs e)
        {
            functionCounter = 5;
        }

        public void strategy6_CheckedChanged(object sender, EventArgs e)
        {
            functionCounter = 6;
        }

        public void noOfNodes_TextChanged(object sender, EventArgs e)
        {

        }













        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            val1 = (int)numericUpDown1.Value;
            val2 = (int)numericUpDown2.Value;
            val3 = (int)numericUpDown3.Value;
            val4 = (int)numericUpDown4.Value;
            val5 = (int)numericUpDown5.Value;
            val6 = (int)numericUpDown6.Value;
        }




    }
    public class mout
    {
        public int nodeid { get; set; }
        public int val1 { get; set; }
        public int appriciated { get; set; }
        public int visited { get; set; }
    }
    public class mout1
    {
        public int parent { get; set; }
        public int child { get; set; }
        public int val { get; set; }
        public int appriciated { get; set; }
        public static void received(Node parent, Node child)
        {
            if (child != null)
            {
                parent.recv.Add(child);
            }
        }
    }
    public class visit
    {
        public int nodeid { get; set; }
        public int visited { get; set; }
    }

    public class jsonfile
    {
        public List<mout> nodes = new List<mout>();
        public List<mout1> nodes1 = new List<mout1>();
        public List<visit> vist = new List<visit>();
        // public Dictionary<int, List<mout1>> node = new Dictionary<int, List<mout1>>();
    }
}

