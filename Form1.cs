using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Program
        {
            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            // [STAThread]
            public void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }

        }

        //constructors
        public interface ICheckLetters //Check letters input by user against the CodeWord
        {
            string CodeWord { get; set; }
            bool AllLetters { get; set; }
            void PrintAllWords(string message);
            bool IsWordCorrect(char[] ChkWord, string Word, bool done);
            
        }


        public abstract class Word
        {
            public virtual string Difficulty { get; set; }
            public virtual string CodeWord { get; set; }

            public virtual int NumLetters { get; set; }

            public Word(string difficulty, string codeword, int numletters)
            {
                this.CodeWord = codeword;
                this.Difficulty = difficulty; 
            }

        }

        public class Difficulty : Word //This uses a word if the input text is blank.
        {
            public char[] Letters = null;

            public Difficulty(string Difficulty, string CodeWord, int numletters) : base(Difficulty, CodeWord, numletters)
            {
                CodeWord = CodeWord.ToUpper(); //creates uppercase for the CodeWord
                Difficulty = Difficulty.ToUpper(); //Creates upper case for difficulty text
               
                SpliceWord();
            }
            
            public virtual void SpliceWord()
            {
                Letters = CodeWord.ToCharArray();
            }

        }
        public class TakeWord : Difficulty //this takes a word from the text bar to use for hangman.
        {
            private string _codeword;  //encapsolate here
            public TakeWord(string Difficulty, string CodeWord, int numletters) : base(Difficulty, CodeWord, numletters)
            {
                SpliceWord();
            }
            public override void SpliceWord()
            {
                _codeword = CodeWord.ToUpper();
                Letters = _codeword.ToCharArray();

                switch (NumLetters)
                {
                    case (0):
                        Difficulty = "null";
                        break;
                    case 1:
                        Difficulty = "EASY";
                        break;
                    case 2:
                        Difficulty = "EASY";
                        break;
                    case 3:
                        Difficulty = "EASY";
                        break;
                    case 4:
                        Difficulty = "NORMAL";
                        break;
                    case 5:
                        Difficulty = "NORMAL";
                        break;
                    case 6:
                        Difficulty = "NORMAL";
                        break;
                    case 7:
                        Difficulty = "HARD";
                        break;
                    default:
                        Difficulty = "HARD";
                        break;
                } //Sets the string for difficulty
            }

        }
        public class temporary : ICheckLetters 
        {
            public string CodeWord { get; set; }
            public bool AllLetters { get; set; } 
            public void PrintAllWords(string message)
            {
                Console.WriteLine(message);
            }
            public bool IsWordCorrect(char[] Letters, string Word, bool allboxes)
            {
                AllLetters = true;
                return (false);
            }
            public temporary()
            {
                throw new NotImplementedException();
            }

        }

        public class SubmitLetter : temporary
        {

        }
        public void DisplayWord(char[] letters, string word)
        {
            lblLet1.Visible = false;
            lblLet2.Visible = false;
            lblLet3.Visible = false;
            lblLet4.Visible = false;
            lblLet5.Visible = false;
            lblLet6.Visible = false;
            lblLet7.Visible = false;
            lblLet8.Visible = false;

            switch (letters.Length)
                {
                case 1:
                    lblLet1.Visible = true; 
                    lblLet1.Text = letters[0].ToString(); 
                    break;
                case 2:
                    lblLet1.Visible = true;
                    lblLet1.Text = letters[0].ToString();
                    lblLet2.Visible = true;
                    lblLet2.Text = letters[1].ToString();
                    break;
                case 3:
                    lblLet1.Visible = true;
                    lblLet1.Text = letters[0].ToString();
                    lblLet2.Visible = true;
                    lblLet2.Text = letters[1].ToString();
                    lblLet3.Visible = true;
                    lblLet3.Text = letters[2].ToString();
                    break;
                case 4:
                    lblLet1.Visible = true;
                    lblLet1.Text = letters[0].ToString();
                    lblLet2.Visible = true;
                    lblLet2.Text = letters[1].ToString();
                    lblLet3.Visible = true;
                    lblLet3.Text = letters[2].ToString();
                    lblLet4.Visible = true;
                    lblLet4.Text = letters[3].ToString();
                    break;
                case 5:
                    lblLet1.Visible = true;
                    lblLet1.Text = letters[0].ToString();
                    lblLet2.Visible = true;
                    lblLet2.Text = letters[1].ToString();
                    lblLet3.Visible = true;
                    lblLet3.Text = letters[2].ToString();
                    lblLet4.Visible = true;
                    lblLet4.Text = letters[3].ToString();
                    lblLet5.Visible = true;
                    lblLet5.Text = letters[4].ToString();
                    break;
                case 6:
                    lblLet1.Visible = true;
                    lblLet1.Text = letters[0].ToString();
                    lblLet2.Visible = true;
                    lblLet2.Text = letters[1].ToString();
                    lblLet3.Visible = true;
                    lblLet3.Text = letters[2].ToString();
                    lblLet4.Visible = true;
                    lblLet4.Text = letters[3].ToString();
                    lblLet5.Visible = true;
                    lblLet5.Text = letters[4].ToString();
                    lblLet6.Visible = true;
                    lblLet6.Text = letters[5].ToString();
                    break;
                case 7:
                    lblLet1.Visible = true;
                    lblLet1.Text = letters[0].ToString();
                    lblLet2.Visible = true;
                    lblLet2.Text = letters[1].ToString();
                    lblLet3.Visible = true;
                    lblLet3.Text = letters[2].ToString();
                    lblLet4.Visible = true;
                    lblLet4.Text = letters[3].ToString();
                    lblLet5.Visible = true;
                    lblLet5.Text = letters[4].ToString();
                    lblLet6.Visible = true;
                    lblLet6.Text = letters[5].ToString();
                    lblLet7.Visible = true;
                    lblLet7.Text = letters[6].ToString();
                    break;
                default:
                    lblLet1.Visible = true; 
                    lblLet1.Text = letters[0].ToString();
                    lblLet2.Visible = true;
                    lblLet2.Text = letters[1].ToString(); 
                    lblLet3.Visible = true;
                    lblLet3.Text = letters[2].ToString(); 
                    lblLet4.Visible = true; 
                    lblLet4.Text = letters[3].ToString(); 
                    lblLet5.Visible = true; 
                    lblLet5.Text = letters[4].ToString(); 
                    lblLet6.Visible = true; 
                    lblLet6.Text = letters[5].ToString(); 
                    lblLet7.Visible = true;
                    lblLet7.Text = letters[6].ToString(); 
                    lblLet8.Visible = true; 
                    lblLet8.Text = letters[7].ToString(); 
                    break;
            }
            
        } //Displays the word in letters section

        private void btnGO_Click(object sender, EventArgs e)
        {
            

            if (tbxWord.Text == null) //This section test the classes with either input or preselected word(s)
            {

                var TestWord1 = new Difficulty("HARD", "positive", 8);
                //DisplayWord(TestWord1.Letters, TestWord1.CodeWord);
            }
            else
            {
                var Testword = new TakeWord("UNKNOWN", tbxWord.Text, tbxWord.Text.Length);
                //DisplayWord(Testword.Letters, Testword.CodeWord);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
        private void btnA_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnA.Font.Underline == true)
            {
               
                this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnB_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnB.Font.Underline == true)
            {
                this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnC_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnC.Font.Underline == true)
            {
                this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnD.Font.Underline == true)
            {
                this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnE_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnE.Font.Underline == true)
            {
                this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnF_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnF.Font.Underline == true)
            {
                this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnG_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnG.Font.Underline == true)
            {
                this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnH_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnH.Font.Underline == true)
            {
                this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnI_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnI.Font.Underline == true)
            {
                this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnJ_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnJ.Font.Underline == true)
            {
                this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnK_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnK.Font.Underline == true)
            {
                this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnL_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnL.Font.Underline == true)
            {
                this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnM_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnM.Font.Underline == true)
            {
                this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnN_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnN.Font.Underline == true)
            {
                this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnO_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnO.Font.Underline == true)
            {
                this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnP_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnP.Font.Underline == true)
            {
                this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnQ_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnQ.Font.Underline == true)
            {
                this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnR_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnR.Font.Underline == true)
            {
                this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnS_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnS.Font.Underline == true)
            {
                this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnT_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnT.Font.Underline == true)
            {
                this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnU_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnU.Font.Underline == true)
            {
                this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnV_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnV.Font.Underline == true)
            {
                this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnW_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnW.Font.Underline == true)
            {
                this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnX_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnX.Font.Bold == true)
            {
                this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnY_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnY.Font.Underline == true)
            {
                this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void btnZ_Click(object sender, EventArgs e)
        {
            ClrFormat();
            if (btnZ.Font.Underline == true)
            {
                this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            }
            else
            {
                this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, style: FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }
        private void ClrFormat()
        {
            this.btnA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnI.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnO.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnW.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tbxWord.Focused == false)  //this allows the text to be entered in the text box.
            {
                switch (e.KeyChar)
                {
                    case 'A':
                    case 'a':
                        btnA.PerformClick();
                        break;
                    case 'B':
                    case 'b':
                        btnB.PerformClick();
                        break;
                    case 'C':
                    case 'c':
                        btnC.PerformClick();
                        break;
                    case 'D':
                    case 'd':
                        btnD.PerformClick();
                        break;
                    case 'E':
                    case 'e':
                        btnE.PerformClick();
                        break;
                    case 'F':
                    case 'f':
                        btnF.PerformClick();
                        break;
                    case 'G':
                    case 'g':
                        btnG.PerformClick();
                        break;
                    case 'H':
                    case 'h':
                        btnH.PerformClick();
                        break;
                    case 'I':
                    case 'i':
                        btnI.PerformClick();
                        break;
                    case 'J':
                    case 'j':
                        btnJ.PerformClick();
                        break;
                    case 'K':
                    case 'k':
                        btnK.PerformClick();
                        break;
                    case 'L':
                    case 'l':
                        btnL.PerformClick();
                        break;
                    case 'M':
                    case 'm':
                        btnM.PerformClick();
                        break;
                    case 'N':
                    case 'n':
                        btnN.PerformClick();
                        break;
                    case 'O':
                    case 'o':
                        btnO.PerformClick();
                        break;
                    case 'P':
                    case 'p':
                        btnP.PerformClick();
                        break;
                    case 'Q':
                    case 'q':
                        btnQ.PerformClick();
                        break;
                    case 'R':
                    case 'r':
                        btnR.PerformClick();
                        break;
                    case 'S':
                    case 's':
                        btnS.PerformClick();
                        break;
                    case 'T':
                    case 't':
                        btnT.PerformClick();
                        break;
                    case 'U':
                    case 'u':
                        btnU.PerformClick();
                        break;
                    case 'V':
                    case 'v':
                        btnV.PerformClick();
                        break;
                    case 'W':
                    case 'w':
                        btnW.PerformClick();
                        break;
                    case 'X':
                    case 'x':
                        btnX.PerformClick();
                        break;
                    case 'Y':
                    case 'y':
                        btnY.PerformClick();
                        break;
                    case 'Z':
                    case 'z':
                        btnZ.PerformClick();
                        break;
                    default:
                        break;
                }
                e.Handled = true;
            }
         
        }

        private void btnWSub_Click(object sender, EventArgs e)
        {
            if (tbxWord.Text == null) //This section test the classes with either input or preselected word(s)
            {

                var TestWord1 = new Difficulty("HARD", "positive", 8);
                DisplayWord(TestWord1.Letters, TestWord1.CodeWord);
            }
            else
            {
                var Testword = new TakeWord("UNKNOWN", tbxWord.Text, tbxWord.Text.Length);
                DisplayWord(Testword.Letters, Testword.CodeWord);
            }
        } //This is to test they classes and case changing of the word/letters FOR TESTING ONLY

    }
}