using System.Threading;


namespace UITests
{
    class WebPageDelay
    {
        public static void Pause(int secondsToPause = 3000)
        {
            Thread.Sleep(secondsToPause);
        }
    }
}
