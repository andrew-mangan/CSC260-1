using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
                //string difficultyS;
                //var TestWord = new diffculty("easy", "test");
                string CodeWord;

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                Console.Write("Enter the word.");
                
                CodeWord = Console.ReadLine();
                char[] chars = CodeWord.ToCharArray();
                //var TestWord2 = new diffculty("easy", "test");
                //var EnterWord = new TakeWord("medium", null);

                //Form1.lblLet1.Text = TestWord.NumLetters.ToString();
                //lblLet2.Text = TakeWord.Numletters.ToString();


            }

        }

        //constructors
        public abstract class Word
        {
            public virtual string Difficulty { get; set; }
            public virtual string CodeWord { get; set; }

            public virtual int NumLetters
            { get; set;
                /*get
                {
                    return this.NumLetters;
                }

                set
                {

                    {
                        if (value <= 0)
                        {
                            this.NumLetters = 0;
                            this.Difficulty = null;
                            this.CodeWord = null;

                        }
                        else if (value > 8)
                        {
                            this.NumLetters = 8;
                            this.Difficulty = "HARD";
                            this.CodeWord = "DAUGHTER";
                        }
                        else
                        {
                            this.NumLetters = value;
                        }
                    }
                }*/
            }

            public Word(string difficulty, string codeword)
            {
                this.CodeWord = codeword;
                this.Difficulty = difficulty;
            }

        }

        public class Difficulty : Word
        {
            public char[] Letters;
            protected string _toupper;

            public Difficulty(string Difficulty, string CodeWord) : base(Difficulty, CodeWord)
            {
                _toupper = Difficulty.ToUpper();
                Difficulty = _toupper;
                _toupper = CodeWord.ToUpper();
                CodeWord = _toupper;
                NumLetters = 1;

            }
            
            public virtual void SpliceWord()
            {
                for (int i = 0; i < CodeWord.Length; i++)
                {
                    if ((CodeWord[i] >= 0) && (CodeWord[i] <= 8))
                    {
                        Letters[i] = CodeWord[i];
                        NumLetters++;
                    }
                }
            }

        }
        public class TakeWord : Difficulty
        {
            private string _codeword;
            public TakeWord(string Difficulty, string CodeWord) : base(Difficulty, CodeWord)
            {


                _codeword = CodeWord;


                SpliceWord();
                switch (_codeword.Length)
                {
                    case (0):
                        Difficulty = null;
                        break;
                    case 1:
                        Difficulty = "EASY";
                        break;
                    case 2:
                        Difficulty = "EASY";// code block
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
                }

            }
            public override void SpliceWord()
            {
                _codeword.ToUpper();
                Letters[1] = 'A';
                Letters[0] = 'B';
                for (int i = 0; i < _codeword.Length; i++)
                {
                    if ((_codeword[i] >= 0) && (_codeword[i] <= 8))
                    {
                        Letters[i] = _codeword[i];
                        NumLetters++;
                    }
                }
                NumLetters = _codeword.Length;
            }

        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            var TestWord = new TakeWord("HARD", "HELLO");

            /*if (tbxWord.Text == null)
            {
                var TestWord = new Difficulty("HARD", "MOTHER");
                rad6.Text = TestWord.NumLetters.ToString();
                lblLet1.Text = TestWord.Letters[0].ToString();
                lblLet2.Text = TestWord.Letters[1].ToString();
                lblLet3.Text = TestWord.Letters[2].ToString();
                lblLet4.Text = TestWord.Letters[3].ToString();
                lblLet5.Text = TestWord.Letters[4].ToString();
                lblLet6.Text = TestWord.Letters[5].ToString();
                lblLet7.Text = TestWord.Letters[6].ToString();
                lblLet8.Text = TestWord.Letters[7].ToString();
            }
            else
            {
                var Testword = new TakeWord(null, tbxWord.Text);
            }*/
            rad6.Text = TestWord.CodeWord.ToString();
            radioButton5.Text = TestWord.NumLetters.ToString();
            radioButton4.Text = TestWord.CodeWord.Length.ToString();
            lblLet1.Text = TestWord.Letters[1].ToString();

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

    }
}