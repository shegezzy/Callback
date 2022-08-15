namespace Callback
{

    /// <summary>
    /// Main class
    /// </summary>
    internal class Phone
    {
        /// <summary>
        /// Delegate
        /// </summary>
        /// <param name="x"></param>
        public delegate void Progress(double x);
        /// <summary>
        /// Method that accepts the delegate
        /// </summary>
        /// <param name="pro"></param>
        public static void Backup(Progress pro)
        {

            for (int i = 0; i < 101; i++)       //loops through 0 to 100
            {
                pro(i);        // applies the method to each i
            }


        }

    }
    /// <summary>
    /// Callback class
    /// </summary>
    public class Callback
    {
        static void Main(string[] args)
        {

            Phone.Backup(Show);     //run the show method
        }
        /// <summary>
        /// Callback method
        /// </summary>
        /// <param name="bytes"></param>
        public static void Show(double bytes)
        {

            Console.WriteLine($"{bytes}% Data Backed Up ");

        }
    }
}