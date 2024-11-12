public class BreadthFirstSearch
{
    public bool[] PrintVistedNodes(List<LinkedList<int>> adjacencyList, int src, int numOfNodes)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[numOfNodes+1];

        visited[src] = true;
        queue.Enqueue(src);
        while(queue.Count > 0)
        {
            int current = queue.Dequeue();
            Console.Write($"{current} ");
            foreach(int nextNode in adjacencyList[current])
            {
                if(visited[nextNode] == false)
                {
                    visited[nextNode] = true;
                    queue.Enqueue(nextNode);
                }
            }
        }

        return visited;
    }



    //Calculate minimum distance given the source node
    public int[] MinimumDistance(List<LinkedList<int>> adjacencyList, int src, int numOfNodes)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[numOfNodes+1];
        int[] distanceArray = new int[numOfNodes+1];

        visited[src] = true;
        queue.Enqueue(src);
        while(queue.Count > 0)
        {
            int current = queue.Dequeue();
            foreach(int nextNode in adjacencyList[current])
            {
                if(visited[nextNode] == false)
                {
                    visited[nextNode] = true;
                    distanceArray[nextNode] = distanceArray[current]+1;
                    queue.Enqueue(nextNode);
                }
            }
        }
        return distanceArray;
    }

    public int[] PrintPath(List<LinkedList<int>> adjLst,int src,int numOfNodes)
    {
        bool[] visited = new bool[numOfNodes+1];
        Queue<int> queue = new Queue<int>();
        int[] parentArray = new int[numOfNodes+1];

        queue.Enqueue(src);
        visited[src] = true;
        parentArray[src] = -1;

        while(queue.Count > 0)
        {
            int currentNode = queue.Dequeue();

            foreach(int nextNode in adjLst[currentNode])
            {
                if(!visited[nextNode])
                {
                    visited[nextNode] = true;
                    parentArray[nextNode] = currentNode;
                    queue.Enqueue(nextNode);
                }
            }
        }
        return parentArray;
    }

    public int[] GetAllNodesInMinPath(List<LinkedList<int>> adjLst, int src, int numberOfNodes)
    {
        Queue<int> queue = new Queue<int>();
        bool[] visitedNodes = new bool[numberOfNodes+1];
        int[] distArray = new int[numberOfNodes+1];

        distArray[src] = 0;
        visitedNodes[src] = true;
        queue.Enqueue(src);

        while(queue.Count > 0)
        {
            int currentNode = queue.Dequeue();

            foreach(int nextNode in adjLst[currentNode])
            {
                if(!visitedNodes[nextNode])
                {
                    visitedNodes[nextNode] = true;
                    distArray[nextNode] = distArray[currentNode] + 1;
                    queue.Enqueue(nextNode);
                }
            }
        }
        return distArray;
    }
}

public class Graph
{
    private List<LinkedList<int>> adjacencyList;

    public Graph(int numberOfNodes)
    {
        adjacencyList = new List<LinkedList<int>>(numberOfNodes);

        for(int i=0; i<numberOfNodes; i++)
        {
            adjacencyList.Add(new LinkedList<int>());
        }
    }

    public void AddEdge(int currentNode ,int adjacentNode)
    {
        // current node is the index and adjacent node is the value at that index
        adjacencyList[currentNode].AddLast(adjacentNode); 
    }

    public List<LinkedList<int>> AdjacencyList => adjacencyList;
}