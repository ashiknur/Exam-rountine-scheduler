using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Routine_Sceduler
{
    public partial class MainForm : Form
    {
        HashSet<string> subject_list = new HashSet<string>();
        Dictionary<string, List<string>> adj = new Dictionary<string, List<string>>();
        Dictionary<int, List<string>> same_day = new Dictionary<int, List<string>>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void add(TextBox subjectList)
        {
            string s = subjectList.Text;
            List<string> list = s.Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < list.Count; j++)
                {
                    if (i != j)
                    {
                        if (adj.ContainsKey(list[i]))
                        {
                            if (!adj[list[i]].Contains(list[j]))
                            {
                                adj[list[i]].Add((string)list[j]);
                            }
                        }
                        else
                        {
                            adj.Add(list[i], new List<string>(){ list[j]});
                        }
                    }
                }
            }
            
            foreach (string x in list)
            {
                subject_list.Add(x);
            }
        }
        public int calculateDay()
        {
            same_day.Clear();
            int days = 0;
            Dictionary<string, int> color= new Dictionary<string, int>();
            Dictionary<string, int> visited = new Dictionary<string, int>();
            string[] subjects = subject_list.ToArray();
            foreach(string sub in subjects)
            {
                visited.Add(sub, 0);
            }
            foreach(string sub in subjects)
            {
                if (!color.ContainsKey(sub))
                {
                    Queue<string> q = new Queue<string>();
                    q.Enqueue(sub);
                    visited[sub] = 1;
                    while(q.Count != 0)
                    {
                        string u = q.Dequeue();
                        Dictionary<int , int> mp = new Dictionary<int , int>();
                        if(adj.ContainsKey(u)) foreach(string v in adj[u])
                        {
                            if (visited[v] == 0)
                            {
                                visited[v] = 1;
                                q.Enqueue(v);
                            }
                            else
                            {
                                if(color.ContainsKey(v)) mp.Add(color[v], 1);
                            }
                        }
                        int num = 1;
                        while (mp.ContainsKey(num)) num++;
                        color[u] = num;
                        if(!same_day.ContainsKey(num)) same_day.Add(num, new List<string>() { u });
                        else same_day[num].Add(u);
                        if (days < color[u]) days = color[u];
                    }
                }
            }


            return days;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Enter1_Click(object sender, EventArgs e)
        {
            add(subjectList1);
        }

        private void Enter2_Click(object sender, EventArgs e)
        {
            add(subjectList2);
        }

        private void Enter3_Click(object sender, EventArgs e)
        {
            add(subjectList3);
        }

        private void Enter4_Click(object sender, EventArgs e)
        {
            add(subjectList4);
        }

        private void show_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Minimum days needed for Scheduling Exams without conflicts " + calculateDay().ToString());
            /*foreach(KeyValuePair<string, List<string>>pair in adj)
            {
                MessageBox.Show(pair.Key+ " -> ");
                foreach(string item in pair.Value) MessageBox.Show(item+ ", ");
                Console.WriteLine();
            }*/
            foreach(KeyValuePair<int, List<string>> pair in same_day)
            {
                MessageBox.Show(string.Join(", ", pair.Value));
            }
        }
    }
}
