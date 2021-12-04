using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Form1 : Form
    {
        private Graph<int> myGraph = new Graph<int>(); //create a graph of integers
        string label = ""; //create label for yesNoTextBox
        public Form1()
        {
            InitializeComponent();
        }

        private void nodeButton_Click(object sender, EventArgs e)
        {
            myGraph.AddNode(Convert.ToInt32(nodeTextBox.Text)); //gets the value in text box and adds it to the graph
        }

        private void edgeButton_Click(object sender, EventArgs e) //add edge between values in the text boxes
        {
            myGraph.AddEdge(Convert.ToInt32(edge1TextBox.Text), Convert.ToInt32(edge2TextBox.Text));
        }

        private void adjacentButton_Click(object sender, EventArgs e) //checks if the nodes are adjacent
        {
            if (myGraph.IsAdjacent(myGraph.GetNodeByID(Convert.ToInt32(adjacent1TextBox.Text)), myGraph.GetNodeByID(Convert.ToInt32(adjacent2TextBox.Text))))
            {
                yesNoTextBox.Text = label + "True"; //displays true if adjacent
            } 
            else
            {
                yesNoTextBox.Text = label + "False"; //displays false if not adjacent
            }
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            countTextBox.Text = myGraph.NumNodesGraph().ToString(); //displays the number of nodes in the graph
        }
    }
}
