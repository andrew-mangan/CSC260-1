using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    //constructors
    public abstract class Word
    {
        public virtual string Difficulty { get; set; }
        public virtual string CodeWord { get; set; }

        public Word(string difficulty, string codeword)
        {
            this.CodeWord = codeword;
            this.Difficulty = difficulty;
        }

    }

    public class diffculty : Word
    {
        public int NumLetters=0;

        public diffculty(string Difficulty, string CodeWord, int numletters) : base(Difficulty, CodeWord)
        {
            NumLetters = numletters;
            int count = 0;


            for (int i = 0; i < CodeWord.Length; i++)
            {
                if ((CodeWord[i] >= '0') && (CodeWord[i] <= '9'))
                {
                    count++;
                }
            }

        }
    }




}
