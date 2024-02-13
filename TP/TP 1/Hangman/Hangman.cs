namespace TP01
{
    /// <summary>
    /// Represents the hangman game
    /// </summary>
    class Hangman
    {
        /// <summary>
        /// Init the game
        /// </summary>
        /// <param name="words">the words base (all the possible words)</param>
        /// <param name="minLength">The minimum word length (default 4)</param>
        /// <param name="maxLength">The maximum word lenth (default 10)</param>
        public Hangman(WordBase words, int minLength = 4, int maxLength = 10)
        {
            this.words = words;
            this.minLength = minLength;
            this.maxLength = maxLength;
        }

        /// <summary>
        /// Gets the hidden word (the word to find)
        /// </summary>
        public string HiddenWord
        {
            get { return word; }
        }

        /// <summary>
        /// Gets the partial word (the unknown letters are replaced with _)
        /// </summary>
        public string PartialWord
        {
            get
            {
                string partial = "";
                for (int i = 0; i < word.Length; i++)
                {
                    if (lettersFound[i])
                        partial += word[i];
                    else
                        partial += '_';
                    partial += ' '; // space to help reading
                }

                return partial;
            }
        }

        /// <summary>
        /// Gets the number of errors
        /// </summary>
        public int Errors
        {
            get => errors;
        }

        /// <summary>
        /// Tells if the player wins the game
        /// </summary>
        public bool IsGameWon
        {
            get
            {
                bool win = true;
                for (int i = 0; i < lettersFound.Length; i++)
                {
                    if (lettersFound[i] == false)
                        win = false;
                }

                return win;
            }
        }

        /// <summary>
        /// Tells if the player lost the game
        /// </summary>
        public bool IsGameLost
        {
            get { return errors >= 10; }
        }

        /// <summary>
        /// Gets all the proposed letters
        /// </summary>
        public string LettersProposed
        {
            get
            {
                string ret = "";
                foreach (char c in lettersProposed)
                    ret += char.ToUpper(c);
                return ret;
            }
        }

        /// <summary>
        /// start a new game : change the word to find, reset the errors counter, etc.
        /// </summary>
        public void StartGame()
        {
            word = this.words.GetAWord(minLength, maxLength).ToUpper();
            lettersFound = new bool[word.Length];
            for (int i = 0; i < lettersFound.Length; i++)
            {
                lettersFound[i] = false;
            }

            errors = 0;
            lettersProposed = new HashSet<char>();
        }

        /// <summary>       
        /// The player propose a letter. The number of errors is updated, and PartialWord too.
        /// If the letter is already proposed, nothing happens.
        /// </summary>        
        public void Propose(char letter)
        {
            if (!lettersProposed.Contains(letter))
            {
                lettersProposed.Add(letter);
                bool ok = false;
                for (int i = 0; i < word.Length; i++)
                {
                    if (Char.ToUpper(letter) == word[i] && lettersFound[i] == false)
                    {
                        lettersFound[i] = true;
                        ok = true;
                    }
                }

                if (!ok)
                    ++errors;
            }
        }

        #region attributes

        private WordBase words;
        private string word;
        private int minLength;
        private int maxLength;
        private bool[] lettersFound;
        private int errors;
        private HashSet<char> lettersProposed;

        #endregion
    }
}