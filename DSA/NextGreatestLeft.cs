class NGL
{
    private int[] array = new int[6];

    public void PrintNextGreatestLeft(int[] inputArray,int inputNumber)
    {
        int[] answerArray = new int[inputArray.Length];
        answerArray[0] = -1;
        int nextGreatest = -1;
        for (int i = 1; i < inputArray.Length; i++)
        {
            if(nextGreatest < inputArray[i])
            {
                nextGreatest = inputArray[i];
                answerArray[i] = nextGreatest;
                continue;
            }
            answerArray[i] = nextGreatest;
        }

        if(nextGreatest > inputNumber)

        Console.WriteLine($"Next greatest element of {inputNumber} is {nextGreatest}");
        Console.WriteLine($"Next greatest element of {inputNumber} is -1");
    }
}