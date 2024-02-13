namespace Exo2
{
    /// <summary>
    /// Represents a time
    /// </summary>
    class Time
    {
        private int seconds;

        /// <summary>
        /// Init the time with a number of seconds
        /// </summary>
        /// <param name="s">a nbr of seconds</param>
        public Time(int s)
        {
            seconds = s;
            Normalize();
        }

        /// <summary>
        /// Init the time
        /// </summary>
        /// <param name="h">number of hours</param>
        /// <param name="m">number of minutes</param>
        /// <param name="s">number of seconds</param>
        public Time(int h, int m, int s)
        {
            seconds = s + m * 60 + h * 3600;
            Normalize();
        }

        public int Hours
        {
            get { return seconds / 3600; }
        }

        public int Minutes
        {
            get { return (seconds % 3600) / 60; }
        }

        public int Seconds
        {
            get { return seconds % 60; }
        }

        public override string ToString()
        {
            return string.Format("{0:D2}:{1:D2}:{2:D2}", Hours, Minutes, Seconds);
        }

        /// <summary>
        /// Add some seconds
        /// </summary>
        /// <param name="nbsecs">the numer of seconds to add</param>
        public void Add(int nbsecs)
        {
            seconds += nbsecs;
            Normalize();
        }

        private void Normalize()
        {
            seconds %= 24 * 60 * 60;
        }
    }
}