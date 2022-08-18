using Direct;

namespace Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var v = Factory.Get<IDirect>();
        }
    }
}
