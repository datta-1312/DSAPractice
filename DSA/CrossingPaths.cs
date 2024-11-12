public class CrossingPaths
{
    public bool IsPathCrossing(string path) {
        int[,] TwoDMatrix = new int[4,4];
        int x=0;
        int y=0;
        foreach(char character in path)
        {
            switch(character)
            {
                case 'N':
                        if(TwoDMatrix[x,++y]==0)
                        {
                            TwoDMatrix[x,y]=1;
                            continue;
                        }
                        return true;
                case 'S':
                        if(TwoDMatrix[x,--y]==0)
                        {
                            TwoDMatrix[x,y]=1;
                            continue;
                        }
                        return true;
                case 'E':
                        if(TwoDMatrix[++x,y]==0)
                        {
                            TwoDMatrix[x,y]=1;
                            continue;
                        }
                        return true;
                case 'W':
                        if(TwoDMatrix[--x,y]==0)
                        {
                            TwoDMatrix[x,y]=1;
                            continue;
                        }
                        return true;
            }
        }
        return false;
    }
}