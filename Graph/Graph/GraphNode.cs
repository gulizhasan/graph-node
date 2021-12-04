using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph
{
    public class GraphNode<T>
    {
        private T id; 
        private LinkedList<T> adjList; 
        public GraphNode(T id) //construct graphnode object
        {
            this.id = id;
            adjList = new LinkedList<T>();
        }
        public T ID //get and set id
        {
            get { return id; }
            set { id = value; }
        }
        
        //add a directed edge from “this” node to the node "to”
        public void AddEdge(GraphNode<T> to)
        {
            //add the id of node “to” to the adjacency list
            adjList.AddLast(to.ID);
        }
        public LinkedList<T> GetAdjList() //returns the adjacency list
        {
            return adjList;
        }
    }
}
