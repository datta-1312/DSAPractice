public class AsteroidCollisions
{
    public int[] AsteroidCollision(int[] asteroids) {
        List<int> lst = new List<int>(asteroids);

        int i = 0;

        while(i < lst.Count - 1)
        {
            if(lst[i] > 0 && lst[i+1] < 0 && lst[i] + lst[i+1] < 0)
            {
                lst.RemoveAt(i);
                i--;
                continue;
            }
            if(lst[i] > 0 && lst[i+1] < 0 && lst[i] + lst[i+1] > 0)
            {
                lst.RemoveAt(i+1);
                continue;
            }
            if(lst[i] > 0 && lst[i+1] < 0 && lst[i] + lst[i+1] == 0)
            {
                lst.RemoveRange(i,2);
                continue;
            }
            i++;
        }
        return lst.ToArray();
    }
}