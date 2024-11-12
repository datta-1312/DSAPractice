//LinkedList<int> lst = new LinkedList<int>();

//NGL nGL = new NGL();
// nGL.PrintNextGreatestLeft(new int[]{11,13,12,8,9,15},9);
// FirstNonRepeating firstNonRepeating= new FirstNonRepeating();
// firstNonRepeating.FindFirstNonRepeating(new char[] { 'a', 'b', 'c', 'd', 'c', 'f', 'f','a', 'b'});


// Largest common prefix
// string[] strs = ["flower","flow","flight"];

// string[] strs = ["aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aab","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa","aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"];

// LongestCommonPrefix longestCommonPrefix = new LongestCommonPrefix();
// longestCommonPrefix.LongestCommonPrefixFunction(strs);

// Palindrome palindrome= new Palindrome();
// palindrome.IsPalindrome("A man, a plan, a canal: Panama");

// using System.Text;

// MergeSortClass mergeSort = new MergeSortClass();
// int[] inputArray = [2, 8, 6, 3, 4, 1];
// mergeSort.Sort(inputArray, 0, inputArray.Length - 1);

// foreach (int x in inputArray)
// {
//     Console.Write(x + " ");
// }

// TargetSum targetSum = new TargetSum();
// targetSum.TwoSum([3,2,4],6);

// PlusOneClass plusOneClass = new PlusOneClass();

// foreach(int item in plusOneClass.PlusOne([9]))
// {
//     Console.Write(item+",");
// }

//BFS
// Graph graph= new Graph(7);
// graph.AddEdge(0,1);
// graph.AddEdge(0,2);
// graph.AddEdge(0,5);
// graph.AddEdge(1,3);
// graph.AddEdge(2,4);
// graph.AddEdge(3,5);
// graph.AddEdge(4,5);
// graph.AddEdge(5,6);

// BreadthFirstSearch breadthFirstSearch = new BreadthFirstSearch();

//bool[] visited = breadthFirstSearch.PrintVistedNodes(graph.AdjacencyList,0,6);
// foreach(bool x in visited)
// {
//     Console.Write($"{x} ");
// }
// int[] distance = breadthFirstSearch.MinimumDistance(graph.AdjacencyList,0,6);
// int target = 6;
// Console.WriteLine($"Distance from 0 to target is {distance[target]}");

// int[] parent = breadthFirstSearch.PrintPath(graph.AdjacencyList,0,6);
// int target = 6;
// while(target!=-1)
// {
//     Console.Write($"{target} ");
//     target = parent[target];
// }

// int target = 6;
// int[] distanceArray1 = breadthFirstSearch.GetAllNodesInMinPath(graph.AdjacencyList,0,6);
// int[] distanceArray2 = breadthFirstSearch.GetAllNodesInMinPath(graph.AdjacencyList,target,6);

// for(int i=0;i<6;i++)
// {
//     if(distanceArray1[i]+distanceArray2[i] == distanceArray1[target])
//         Console.Write($"{i} ");
// }

//QuickSort
// QuickSort quickSort = new QuickSort();
// int[] inputArray =[2,8,6,3,4,1];
// quickSort.Sort(inputArray,0,inputArray.Length-1);

// foreach(int x in inputArray)
// {
//     Console.Write(x +" ");
// }

// Fibonacci fibonacci = new Fibonacci();
// fibonacci.Fib(4);
// foreach(var item in fibonacci.KVPairs.Keys)
// {

// }

//Linked list
// LinkedLst<int> linkedLst = new LinkedLst<int>();
// linkedLst.Append(2);
// linkedLst.Append(3);
// linkedLst.Append(5);
// linkedLst.Append(1);

// linkedLst.PrintAll();
// Console.WriteLine();
// linkedLst.InsertAt(3,8);
// linkedLst.PrintAll();
// Console.WriteLine();
// linkedLst.DeleteEnd();
// linkedLst.PrintAll();
// Console.WriteLine();
// linkedLst.Append(1);
// linkedLst.PrintAll();
// Console.WriteLine();
// linkedLst.Reverse();
// linkedLst.PrintAll();

//Decimal to binary
// DecimalToBinary decimalToBinary = new DecimalToBinary();
// decimalToBinary.DecToBinary(10);

//Count characters
// CountChars countChars = new CountChars();
// countChars.CountCharacters(["cat","bt","hat","tree"],"atach");

//Queue using Stack
// MyQueue myQueue= new MyQueue();
// //"push","push","peek","pop","empty"
// myQueue.Push(1);
// myQueue.Push(2);
// Console.WriteLine(myQueue.Peek());
// Console.WriteLine(myQueue.Pop());
// Console.WriteLine(myQueue.Empty());

//Diameter of binary tree
// using System.Runtime.InteropServices;
// using System.Text;

//BTDiameter bTDiameter = new BTDiameter();
// TreeNode root = new TreeNode(1);
// root.left = new TreeNode(2);
// root.left.left = new TreeNode(4);
// root.left.right = new TreeNode(5);
// root.right = new TreeNode(3);
// bTDiameter.DiameterOfBinaryTree(root);

// /[4,2,7,1,3], val = 2
// TreeNode root = new TreeNode(4);
// root.left = new TreeNode(2);
// root.left.left = new TreeNode(1);
// root.left.right = new TreeNode(3);
// root.right = new TreeNode(7);
// TreeNode result = bTDiameter.SearchBST(root, 2);
// TreeNode result = bTDiameter.SearchBST(root, 5);

//Max product
// MaxProductSolution maxProductSolution = new MaxProductSolution();
// maxProductSolution.MaxProduct([-4,-3]);

//Majority Element
// Majority majority = new Majority();
// majority.MajorityElement([2,2,1,1,1,2,2]);

//Good largest integer
// GoodLargestInteger goodLargestInteger = new GoodLargestInteger();
// goodLargestInteger.LargestGoodInteger("4818042931906802860005960222213336669500011846936171709111");
// goodLargestInteger.LargestGoodInteger("111");

//Anagram
// Anagram anagram = new Anagram();
// anagram.IsAnagram("anagram","nagaram");

//Crossing paths
// CrossingPaths crossingPaths = new CrossingPaths();
// // crossingPaths.IsPathCrossing("NESWW");
// crossingPaths.IsPathCrossing("S");

//Make equal
// MakeEqual makeEqual = new MakeEqual();
// makeEqual.IsMakeEqual(["abc","aabc","bc"]);

//Max length between characters
// MaxLengthBetweenChars maxLengthBetweenChars = new MaxLengthBetweenChars();
// int result = maxLengthBetweenChars.MaxLengthBetweenEqualCharacters("cbzxy");
// int result = maxLengthBetweenChars.MaxLengthBetweenEqualCharacters("abca");

//Make good string
// MakeGoodString makeGoodString = new MakeGoodString();
// makeGoodString.MakeGood("abBAcC");

//Merge 2 sorted arrays
// MergeArrays mergeArrays = new MergeArrays();
// mergeArrays.Merge([1,2,3,0,0,0],3,[2,5,6],3);
// mergeArrays.Merge([0],0,[1],1);

//Fully Justify string
// FullyJustify fullyJustify = new FullyJustify();
// fullyJustify.FullJustify(["This", "is", "an", "example", "of", "text", "justification."],16);

//Merge k linked lists
// MergeLinkedLists mergeLinkedLists = new MergeLinkedLists();
// ListNode head1 = new ListNode(1);
// head1.next = new ListNode(4);
// head1.next.next = new ListNode(5);

// ListNode head2 = new ListNode(1);
// head2.next = new ListNode(3);
// head2.next.next = new ListNode(4);

// ListNode head3 = new ListNode(2);
// head3.next = new ListNode(6);

// ListNode[] lists = [head1,head2,head3];

// ListNode head = mergeLinkedLists.MergeKLists(lists);

// while(head!=null)
// {
//     Console.Write(head.val+",");
//     head = head.next;
// }

//Remove a given element from an array
// RemoveElementInArray removeElementInArray = new RemoveElementInArray();
// removeElementInArray.RemoveElement([0,1,2,2,3,0,4,2],2);

//Merge alternatively
// MergeAlternate mergeAlternate = new MergeAlternate();
// mergeAlternate.MergeAlternately("abcd","pq");

// Revere a word in string
// ReverseWord reverseWord = new ReverseWord();
// reverseWord.ReverseWords("a good   example");

//Max operations
// MaxOperation maxOperation = new MaxOperation();
// maxOperation.MaxOperations([3,1,5,1,1,1,1,1,2,2,3,2,2],1);
// maxOperation.MaxOperations([3,1,3,4,3],6);

//Remove stars in a string
//RemoveStarsInString removeStarsInString = new RemoveStarsInString();
// removeStarsInString.RemoveStars("leet**cod*e");
//removeStarsInString.RemoveStars("erase*****");

//Asteriod collision
// AsteroidCollisions asteroidCollisions = new AsteroidCollisions();
// asteroidCollisions.AsteroidCollision([-2,-2,2,-2]);
// asteroidCollisions.AsteroidCollision([-2,-1,2,-1]);

//Odd even linked list
// OddEvenLinkedList oddEvenLinkedList= new OddEvenLinkedList();
// //head = [1,2,3,4,5]
// ListNode head = new ListNode(1);
// head.next = new ListNode(2);
// head.next.next = new ListNode(3);
// head.next.next.next = new ListNode(4);
// head.next.next.next.next = new ListNode(5);
// oddEvenLinkedList.OddEvenList(head);

//Largest Altitude
// LargestAltitudePrefixSum largestAltitudePrefixSum = new LargestAltitudePrefixSum();
// largestAltitudePrefixSum.LargestAltitude([44,32,-9,52,23,-50,50,33,-84,47,-14,84,36,-62,37,81,-36,-85,-39,67,-63,64,-47,95,91,-40,65,67,92,-28,97,100,81]);

//Move zeros to end
// MoveZerosToEnd moveZerosToEnd= new MoveZerosToEnd();
// moveZerosToEnd.MoveZeroes([0,1,0,3,12]);

//Finding a pivot
//FindingPivot findingPivot= new FindingPivot();
// findingPivot.PivotIndex([1,7,3,6,5,6]);
// findingPivot.PivotIndex([1,2,3]);

//Daily temperatures
// DailyTemperature dailyTemperature = new DailyTemperature();
// dailyTemperature.DailyTemperatures([55,38,53,81,61,93,97,32,43,78]);

//String compression
// StringCompression stringCompression = new StringCompression();
// stringCompression.Compress(['a','a','b','b','c','c','c']);

//Add two numbers of linked lists
// LinkedLst<char> l1 = new LinkedLst<char>();
// l1.Append('2');
// l1.Append('4');
// l1.Append('3');
// LinkedLst<char> l2 = new LinkedLst<char>();
// l2.Append('5');
// l2.Append('6');
// l2.Append('4');
// AddTwoLL addTwoLL= new AddTwoLL();
// addTwoLL.AddTwoNumbers(l1.Head,l2.Head);

//Find the maximum vowels in a string
// FindMaxVowels findMaxVowels = new FindMaxVowels();
// findMaxVowels.MaxVowels("weallloveyou", 7);

//Calculate max area
// MaxAreaCalculate maxAreaCalculate= new MaxAreaCalculate();
// maxAreaCalculate.MaxArea([4,3,2,1,4]);

//Rotate a matrix
// RotateMatrix rotateMatrix= new RotateMatrix();
// rotateMatrix.Rotate([[1,2,3],[4,5,6],[7,8,9]]);

//Rotate array not done
// RotateArray rotateArray = new RotateArray();
// rotateArray.Rotate([1,2],1);

//Balanced binary tree
// BalancedBinaryTree balancedBinaryTree = new BalancedBinaryTree();
// balancedBinaryTree.IsBalanced()

//Buy and sell for max profit
//BuyAndSell buyAndSell = new BuyAndSell();
// buyAndSell.MaxProfit([2,4,1]);
//buyAndSell.MaxProfit([7,1,5,3,6,4]);

//Special characters
// SpecialCharacters specialCharacters = new SpecialCharacters();
// specialCharacters.NumberOfSpecialChars("abBCab"); 

// Array to Integer
// MyAtoI myAtoI = new MyAtoI();
// myAtoI.MyAtoi("words and 987");
// myAtoI.MyAtoi("-91283472332");

// myAtoI.MyAtoi("-987");
// myAtoI.MyAtoi(".1");
// myAtoI.MyAtoi("-042");"   -042"
// myAtoI.MyAtoi("   -042");
// myAtoI.MyAtoi("1337c0d3");



//Remove nth item in Linked list
//[3,7,9,3,5,8,0]
// ListNode head = new ListNode(3);
// head.next = new ListNode(7);
// head.next.next = new ListNode(9);
// head.next.next.next = new ListNode(3);
// head.next.next.next.next = new ListNode(5);
// head.next.next.next.next.next = new ListNode(8);
// head.next.next.next.next.next.next = new ListNode(0);
// RemoveNthItemInLL removeNthItemInLL= new RemoveNthItemInLL();
// removeNthItemInLL.RemoveNthFromEnd(head,1);

//Reorder linked list
//[1,2,3,4,5]
// ListNode head = new ListNode(1);
// head.next = new ListNode(2);
// head.next.next = new ListNode(3);
// head.next.next.next = new ListNode(4);
// head.next.next.next.next = new ListNode(5);
// // head.next.next.next.next.next = new ListNode(8);
// // head.next.next.next.next.next.next = new ListNode(0);
// ReorderLinkedList reorderLinkedList = new ReorderLinkedList();
// reorderLinkedList.ReorderList(head);

// int[] array = new int[10];
// Random random = new Random();

// for (int i = 0; i < array.Length; i++)
// {
//   array[i] = random.Next(1, 10001);  // Generate random numbers between 1 and 100 (inclusive)
//   //array[i] = i;  // Generate random numbers between 1 and 100 (inclusive)
// }

//Adaptive bubble sort
// AdaptiveBubbleSort adaptiveBubbleSort = new AdaptiveBubbleSort();
// adaptiveBubbleSort.BubbleSort(array);

//Selection sort
// SelectionSort selectionSort= new SelectionSort();
// selectionSort.Sort(array);

//Pattern print
// PatternPrint patternPrint = new PatternPrint();
// patternPrint.Print(5);

//Optimal partition
// OptimalPartition optimalPartition = new OptimalPartition();
// optimalPartition.PartitionString("ssssss");

//Search for a value in matrix
// MatrixSearch matrixSearch = new MatrixSearch();
// bool result = matrixSearch.SearchMatrix([[1,3,5,7],[10,11,16,20],[23,30,34,60]],3);
// bool result = matrixSearch.SearchMatrix([[1],[3]],3);
// bool result = matrixSearch.SearchMatrix([[1]],0);

//Kadane's algorithm
// KadanesAlgo kadanesAlgo = new KadanesAlgo();
// kadanesAlgo.MaxSubArray([4,-1,2,-7,3,4]);

// ReverseInteger reverseInteger= new ReverseInteger();
// reverseInteger.Reverse(1534236469);
// string num ="20000000000000000000";

//Duplicate zeros
// DuplicateZero duplicateZero = new DuplicateZero();
// duplicateZero.DuplicateZeros([1,0,2,3,0,4,5,0]);

//Balanced string
// using System.Security.Cryptography;

// Stack<int> stk = new();
// stk.Push(0);
// stk.Push(1);
// stk.Push(2);
// stk.Push(3);
// _ = stk.Pop();
// bool flag = stk.Contains(3);

// Queue<int> ints= new Queue<int>();
// ints.Enqueue(0);
// ints.Count > 0

//String interleave
// StringInterleave stringInterleave= new StringInterleave();
// stringInterleave.IsInterleave("aabcc","dbbca","aadbbcbcac");
// stringInterleave.IsInterleave("aabcc","dbbca","aadbbbaccc");
// stringInterleave.IsInterleave("","","");
// stringInterleave.IsInterleave("a","b","a");

ConnectToSQLite.Fetch();



//Console.WriteLine();
