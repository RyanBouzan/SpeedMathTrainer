using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;   //print to console
using System.Windows.Input;
using WinFormAnimation;
namespace SpeedMathTrainer
{
    public partial class Form1 : Form
    {

        public static List<int> masterList = new List<int>();
        public static List<int> keyList = new List<int>();
        public static List<String> problemTypeList = new List<String>();
        public static List<String> answersList = new List<String>();
        public static List<int> canPob = new List<int>();  //all operations are set to false because the array is empty
        public static List<double> timePerProb = new List<double>();
        public static Random rand = new Random();

        public int problemNumber = 0; //defaults to 2 numbers


        public int listLength = 5;
        public int randMin1;
        public int randMax1;
        public int randMin2;
        public int randMax2;
        public int score = 0;
        public int animCounter = 0;
        public static int trueAnswer;
        public static int indexOffset;
        public static double timeLeft;
        public static double timeLeftDiff;
        public static String timeLeftString;
        public static double avgTime;

        public Form1()
        {
            InitializeComponent();
            // testList.Add("test");

        }


        private void Form1_Load(object sender, EventArgs e)
        {

            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            //Debug.WriteLine(genRandomNum(randMin, randMax));
             tabControl1.Location = new Point(1, -22);
            Debug.WriteLine("form loaded");
            this.DesktopLocation = new Point(575, 300);


        }

        public static int genRandomNum(int min, int max)
        {
            rand.Next(min, max);
            return rand.Next(min, max);

        }



        public void initialize()
        {
            timeLeft = Convert.ToDouble(timeLimitInputBox.Text);
            randMin1 = Convert.ToInt32(userMin1.Text);                                    //pass user random mins and maxes
            randMin2 = Convert.ToInt32(userMin2.Text);
            randMax1 = Convert.ToInt32(userMax1.Text);
            randMax2 = Convert.ToInt32(userMax2.Text);
            incrementAnim.Hide();
            incrementAnim2.Hide();
            Debug.WriteLine("started");


            resetAll();

            gameTimer.Enabled = true;

            //general reset
            tabControl1.SelectedTab = tabPage2;
            answerBox.Focus();

            for (var i = 0; i < operatorChooser.Items.Count; i++)                       //gets the checked operators and appends them to canPob LIST
            {
                switch (i + 1)
                {
                    case 1:                                         //addition
                        if (operatorChooser.GetItemChecked(i))
                        {
                            canPob.Add(1);
                            Debug.WriteLine("Addition selected");
                        }
                        break;                                      //sub
                    case 2:
                        if (operatorChooser.GetItemChecked(i))
                        {
                            canPob.Add(2);
                            Debug.WriteLine("Subtraction selected");

                        }
                        break;
                    case 3:
                        if (operatorChooser.GetItemChecked(i))      //mult
                        {
                            canPob.Add(3);
                            Debug.WriteLine("Multiplication selected");

                        }
                        break;
                    case 4:                                         //div
                        if (operatorChooser.GetItemChecked(i))
                        {
                            canPob.Add(4);
                            Debug.WriteLine("Division selected");

                        }
                        break;
                    case 5:                                         //string em up
                        if (operatorChooser.GetItemChecked(i))
                        {
                            canPob.Add(5);
                            Debug.WriteLine("String addition selected");
                        }
                        break;
                }

            }


            generateProblem();
            setProblem(problemNumber);

        }



        public void startButton_Click(object sender, EventArgs e)
        {
            

            try
            {
                initialize();

            }
            catch (FormatException)
            {

                MessageBox.Show("thine sack count was not defined!");
                autoPickerButton_Click(sender, e);
                
            }
            


          


        }


        public static int pickRandFrom(List<int> inputArray)
        {
            if (!inputArray.Any())
                return 1;
            return inputArray[rand.Next(inputArray.Count)];

        }



        public void generateProblem()
        {
            indexOffset = 0;
            trueAnswer = 0;

            keyList.Add(2);

            for (var i = 0; i < keyList[problemNumber]; i++)            //whoops
            {
                if (i % 2 == 0)                                         //first iteration generates one number based on first max/min
                    masterList.Add(genRandomNum(randMin2, randMax2));
                else
                    masterList.Add(genRandomNum(randMin1, randMax1));     //second iteration does the same using second max/min

                // Debug.WriteLine(masterList[i]);
            }

            // for (var i = 0; i < canPob.Count; i++)
            //  Debug.WriteLine(canPob[i]);

            for (var i = 0; i < keyList.Count; i++)         //sets the offset based on keyList total
            {
                indexOffset += keyList[i];
            }
            //  Debug.WriteLine(indexOffset);
            switch (pickRandFrom(canPob)) //keep it consistent
            {
                case 1:
                    trueAnswer = masterList[indexOffset - 1] + masterList[indexOffset - 2];
                    problemTypeList.Add("+Addition");
                    break;
                case 2:
                    trueAnswer = masterList[indexOffset - 1] - masterList[indexOffset - 2];

                    problemTypeList.Add("-Subtraction");
                    break;
                case 3:
                    trueAnswer = masterList[indexOffset - 1] * masterList[indexOffset - 2];

                    problemTypeList.Add("XMultiplication");
                    break;
                case 4:
                    //  trueAnswer = Math.Round(masterList[indexOffset - 1] / masterList[indexOffset-2]) * 100d ;

                    problemTypeList.Add("÷Division");
                    break;
                case 5:
                    keyList[problemNumber] = 5;
                    indexOffset = indexOffset - 2 + 5;
                    // Debug.WriteLine(indexOffset);
                    int counter = masterList.Count;
                    for (var i = 0; i < keyList[problemNumber] + 2; i++)
                    {
                        if (i < 2)
                        {
                            //   Debug.WriteLine(masterList.Count - i - 1);
                            masterList.RemoveAt(counter - i - 1);
                        }
                        else
                        {
                            masterList.Add(genRandomNum(1, 101));

                        }
                    }
                    for (var i = 0; i < 5; i++)
                        trueAnswer += masterList[(indexOffset - 1) - i];

                    problemTypeList.Add("+String Addition");
                    break;
            }
            Debug.WriteLine("Problem chosen was: " + problemTypeList[problemNumber]);

            if (problemTypeList[problemNumber] != "+++")
                operatorLabel1.Text = problemTypeList[problemNumber].Substring(0,1);


            answersList.Add(Convert.ToString(trueAnswer));


            //  Debug.WriteLine(keyList[problemNumber]);



            //now that the problem is generated, lets have the computer calculate the answer



        }









        //actually puts the problem shid into the GUI
        private void setProblem(int problemNumber)
        {


            Debug.WriteLine("Setting problem number: " + problemNumber);

            Debug.WriteLine("the answer is: " + trueAnswer);



            if (keyList[problemNumber] == 2)
            {
                tabControl1.SelectedTab = tabPage2;
                answerBox.Focus();
                numberBox1.Text = Convert.ToString(masterList[indexOffset - 1]);
                numberBox2.Text = Convert.ToString(masterList[indexOffset - 2]);
            }
            else
            {

                tabControl1.SelectedTab = tabPage3;
                answerBoxString.Focus();
                // indexOffset = indexOffset - 2 + 5;  //recalculate offset but moved this
                //  Debug.WriteLine(indexOffset - 1);
                numBox3.Text = Convert.ToString(masterList[indexOffset - 1]);
                numBox4.Text = Convert.ToString(masterList[indexOffset - 2]);
                numBox5.Text = Convert.ToString(masterList[indexOffset - 3]);
                numBox6.Text = Convert.ToString(masterList[indexOffset - 4]);
                numBox7.Text = Convert.ToString(masterList[indexOffset - 5]);

            }

            timeLeftDiff = timeLeft;


            //   string textBox = "numberBox" + controlNum;


        }










        private void answerBox_TextChanged(object sender, EventArgs e)
        {
            var inputBox = (TextBox)sender;
            String userInput = inputBox.Text;


            if (userInput.Equals(answersList[problemNumber]))
            {
                timePerProb.Add(timeLeftDiff - timeLeft);
                nextDelay.Start();
                colorFlashOn();
            }

        }


        private void gameSummary()
        {
            gameTimer.Enabled = false;

            String tauntMessage = "";
            indexOffset = 0;
            
            switch (genRandomNum(0, 5))
            {
                case 0:
                    tauntMessage = "SUNDEEP'S SAG DANGLES LOW";
                    break;
                case 1:
                    tauntMessage = "GET GED";
                    break;
                case 2:
                    tauntMessage = "LOS CHEEGS HAVE BEEN CLAPPED";
                    break;
                case 3:
                    tauntMessage = "IMMONEED A HIGHER SCORE";
                    break;
                case 4:
                    tauntMessage = "My body is withering. I need food";
                    break;
            }
            
            double totalProbs = problemNumber;
            problemNumber = 0;
            avgTime = Convert.ToDouble(timeLimitInputBox.Text) / totalProbs;
            avgTime = Math.Round(avgTime, 2);
            //avgTime = 1d;


            tabControl1.SelectedTab = tabPage4;

            for (int i = 0; i < timePerProb.Count; i++)
            {
                Debug.WriteLine(timePerProb[i]); ;
            }

            avgTimeBox.Text = "Your average time per problem was: " + avgTime + " seconds." + Environment.NewLine;        //avg time text box
            avgTimeBox.Text += "You score was: " + score;

            for(var i = 0; i < totalProbs; i++)
            {

                for(int j = 0; j < problemNumber; j++)
            {
                indexOffset += keyList[j];
            }

                if (timePerProb[problemNumber] >= avgTime)
                {

                    summaryBox.Text += "Problem number " + (problemNumber + 1) + " [" + problemTypeList[problemNumber].Substring(1, problemTypeList[problemNumber].Length-1) + "]: (";
                    if (keyList[i] == 5)
                    {
                        for (int j = 0; j < keyList[i]; j++)
                        {
                            summaryBox.Text += j < 4 ? (masterList[j + indexOffset] + " + ") : "" + masterList[j + indexOffset];

                        }
                    }
                    else
                    {
                        summaryBox.Text += masterList[indexOffset+1] + " " + problemTypeList[problemNumber].Substring(0,1) + " " + masterList[indexOffset];
                    }

                    summaryBox.Text += " = " + answersList[i] + ") Took you " + Math.Round(timePerProb[problemNumber], 2) + " seconds to solve." + Environment.NewLine;

                }
                problemNumber++;
                indexOffset = 0;
            }

           
            if(summaryBox.Text == "")
            {
                summaryBox.Text = "You solved all problems under the average time? Technically this shouldn't be POSSIB";
            }



            if (score < 69 && !tauntMessage.Equals(""))
            {
                MessageBox.Show(tauntMessage, "YOUR SCORE WAS LESS THAN 69", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            playAgainButton.Focus();
        }
        public void resetAll()
        {
            score = 0;



            timeLeftLabel.Text = "Seconds left: " + timeLimitInputBox.Text;
            timeCopy.Text = "Seconds left: " + timeLimitInputBox.Text;
            timeLeftLabel.ForeColor = Color.Black;
            timeCopy.ForeColor = Color.Black;

            userScore.Text = "Score: " + score;
            scoreCopy.Text = "Score:  " + score;
            answerBox.Text = "";
            answerBoxString.Text = "";

            canPob.Clear();
            masterList.Clear();
            keyList.Clear();
            problemTypeList.Clear();
            answersList.Clear();

            problemNumber = 0;
        }


        private void autoPickerButton_Click(object sender, EventArgs e)
        {
            userMin1.Text = Convert.ToString(0);
            userMin2.Text = Convert.ToString(0);
            userMax1.Text = Convert.ToString(1000);
            userMax2.Text = Convert.ToString(1000);
            timeLimitInputBox.Text = Convert.ToString(600);

            for (int i = 0; i < operatorChooser.Items.Count; i++)
            {
                if (i < 2)
                    operatorChooser.SetItemChecked(i, true);
                else
                    operatorChooser.SetItemChecked(i, false);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            timeLeft -= 0.10d;
            timeLeftLabel.Text = "Seconds left: " + Math.Round(timeLeft, 0); ;
            timeCopy.Text = timeLeftLabel.Text;

            if (timeLeft <= 10)
            {
                timeLeftLabel.ForeColor = Color.Red;
                timeCopy.ForeColor = Color.Red;
            }
            
            if (timeLeft <= 0)                    //when time runs out
            {
                gameSummary();
            }

        }

        private void nextDelay_Tick(object sender, EventArgs e)
        {
            this.Update();
            score++;
            userScore.Text = "Score: " + score;
            scoreCopy.Text = "Score  " + score;
            answerBox.Clear();

            answerBoxString.Clear();
            problemNumber++;

            generateProblem();
            setProblem(problemNumber);
            opacityTimer.Start();


           // problemTypeList[problemNumber] += "C";

            Label animationLabel;

            if (tabControl1.SelectedTab == tabPage2)
                animationLabel = incrementAnim;
            else
                animationLabel = incrementAnim2;

            animationLabel.Show();
            new Animator2D(
                      new Path2D(1075, 1075, 68, 108, 1000))
                     .Play(animationLabel, Animator2D.KnownProperties.Location);

            animationLabel.Location = new Point(1075, 68);

            colorFlashOff();

            nextDelay.Stop();


        }

        
       private void colorFlashOn()
        {
            answerBox.ForeColor = Color.Lime;
            // mainPanel.ForeColor = Color.Lime;
            // stringPanel.ForeColor = Color.Lime;

           /* foreach (Control controls in mainPanel.Controls)
            {
                if(controls is TextBox)
                controls.ForeColor = Color.Lime;
            }

            foreach (Control controls in stringPanel.Controls)
            {
                if (controls is TextBox)
                    controls.ForeColor = Color.Lime;
            }
            */

            answerBoxString.ForeColor = Color.Lime;
        }

        private void colorFlashOff()
        {
            answerBox.ForeColor = Color.Black;
            
            answerBoxString.ForeColor = Color.Black;

         //   mainPanel.ForeColor = Color.Black;
          //  stringPanel.ForeColor = Color.Black;

           /* foreach (Control controls in mainPanel.Controls)
            {
                if (controls is TextBox)
                    controls.ForeColor = Color.Black;
            }

            foreach (Control controls in stringPanel.Controls)
            {
                if (controls is TextBox)
                    controls.ForeColor = Color.Black;
            }
           */
        }



        private void opacityTimer_Tick(object sender, EventArgs e)
        {
            Label animationLabel;

            if (tabControl1.SelectedTab == tabPage2)
                animationLabel = incrementAnim;
            else
                animationLabel = incrementAnim2;


            animationLabel.Hide();
            opacityTimer.Stop();
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            startButton_Click(sender, e);
        }
        
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            resetAll();
            Debug.WriteLine("claener");
            tabControl1.SelectedTab = tabPage1;

        }

    }

}

