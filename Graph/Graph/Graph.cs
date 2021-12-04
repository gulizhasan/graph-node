using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class Graph<T> where T : IComparable
    {
        private LinkedList<GraphNode<T>> nodes;
        public Graph() //create the graph
        {
            nodes = new LinkedList<GraphNode<T>>();
        }

        public int NumNodesGraph() //returns the node count
        {
            return nodes.Count;
        }

        public bool ContainsGraph(GraphNode<T> node)
        {
            foreach(GraphNode<T> n in nodes) //search through graph to check if the node exists
            {
                if (n.ID.CompareTo(node.ID) == 0 & node.ID != null)
                {
                    return true;
                }                   
            }
            return false;
        }
        
        public void AddNode(T id) //add a new node (with this “id”) to the list of nodes of the graph
        {
            GraphNode<T> n = new GraphNode<T>(id);
            nodes.AddFirst(n);
        }
        
        public GraphNode<T> GetNodeByID(T id) //returns the node with this id
        {
            //Search through the list of nodes for a node with this id
            foreach(GraphNode<T> n in nodes)
            {
                if (id.CompareTo(n.ID) == 0)
                {
                    return n;
                }                  
            }
            return null;
        }
        
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            foreach(GraphNode<T> n in nodes) // return true if “to” is adjacent to “from”
            {
                if(n.ID.CompareTo(from.ID) == 0)
                {
                    if (from.GetAdjList().Contains(to.ID))
                        return true;
                }
            }
            return false;
        }
        
        public void AddEdge(T from, T to) //Add a directed edge between the node with id "from" and the node with id “to”
        {
            //Find the node with id “from” in the list of nodes and then
            //use the GraphNode method to add an edge to the node with id “to”
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);

            if (n1 != null & n2 != null)
            {
                n1.AddEdge(n2); //adds edge between if nodes are not null
            }
        }
    }
}
