string t = Console.ReadLine();
int n = Convert.ToInt32(t);
t = Console.ReadLine();
int m = Convert.ToInt32(t);
int s = 0;
static int acc(int q, int w)
{
    if (q == 0)
        return w + 1;
    else 
        if ((q!= 0) && (w == 0))
            return acc(q - 1, 1);
            else
            return acc(q-1, acc(q, w - 1));
}
    Console.WriteLine(acc(m,n));