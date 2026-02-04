namespace SimpleMvvm
{
    public static class CustomMath
    {
        public static int Mod(int x, int m)
        {
            var r = x % m;
            return r < 0 ? r + m : r;
        }
    }
}