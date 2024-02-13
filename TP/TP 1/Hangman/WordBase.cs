namespace TP01
{
    /// <summary>
    /// This class represents the word base, taken from a text file
    /// </summary>
    class WordBase
    {
        #region constructors

        /// <summary>
        /// Init the database
        /// </summary>
        /// <param name="theStream">The input stream to read the words</param>
        public WordBase(Stream theStream)
        {
            random = new Random();
            words = new List<string>();

            using (StreamReader sr = new StreamReader(theStream))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    words.Add(line);
                }
            }
        }

        #endregion

        #region attributes

        private List<string> words;
        private Random random;

        #endregion

        #region operations

        /// <summary>
        /// Get a word, randomly
        /// </summary>
        /// <returns>a word</returns>
        public string GetAWord()
        {
            int pos = random.Next(0, words.Count);
            return words[pos];
        }

        /// <summary>
        /// Get a word, randomly
        /// </summary>
        /// <param name="minSize">the minimal number of letters of the word</param>
        /// <param name="maxSize">the maximal number of letters of the word</param>
        /// <returns>a word</returns>
        public string GetAWord(int minSize, int maxSize)
        {
            var subList = words.FindAll((word) => word.Length <= maxSize && word.Length >= minSize);
            int pos = random.Next(0, subList.Count);
            return subList[pos];
        }

        #endregion
    }
}