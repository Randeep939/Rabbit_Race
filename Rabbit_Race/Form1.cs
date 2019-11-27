using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Rabbit_Race
{
    public partial class Form1 : Form
    {
        //private Horse.Horse DefaultHorse = new Horse01();

        Punter[] myPunter = new Punter[3];
        Rabbit[] myRabbit = new Rabbit[4];
        Property myProperty = new Property();



        public Form1()
        {
            InitializeComponent();
            TransparentBackground();
            LoadData();
        }

        #region Transparent Background
        private void TransparentBackground()
        {
            //Makes Backgrounds transparent for pictureboxes
            this.PointToScreen(pb1.Location);
            pb1.Parent = pbRaceTrack;
            pb1.BackColor = Color.Transparent;

            this.PointToScreen(pb2.Location);
            pb2.Parent = pbRaceTrack;
            pb2.BackColor = Color.Transparent;

            this.PointToScreen(pb3.Location);
            pb3.Parent = pbRaceTrack;
            pb3.BackColor = Color.Transparent;

            this.PointToScreen(pb4.Location);
            pb4.Parent = pbRaceTrack;
            pb4.BackColor = Color.Transparent;
        }
        #endregion

        #region Load Data
        private void LoadData()
        {
            PunterRadioButtons();
            RabbitPictureBoxes();
            RabbitIDCount();
        }

        private void RabbitIDCount()
        {
            // will give me how many Rabbits I have
            foreach (var id in myRabbit)
            {
                if (Factory.RabbitCount < id.RabbitID)
                {
                    Factory.RabbitCount = id.RabbitID;
                    Factory.RabbitCount += 1;
                }

            }
        }

        private void RabbitPictureBoxes()
        {
            for (myProperty.Rabbit = 0; myProperty.Rabbit < 4; myProperty.Rabbit++)
            {
                myRabbit[myProperty.Rabbit] = Factory.GetARabbit(myProperty.Rabbit);
                myRabbit[myProperty.Rabbit].RabbitID = myProperty.Rabbit;
            }

            myRabbit[0].MyPictureBox = pb1;
            myRabbit[1].MyPictureBox = pb2;
            myRabbit[2].MyPictureBox = pb3;
            myRabbit[3].MyPictureBox = pb4;
        }

        private void PunterRadioButtons()
        {
            for (myProperty.Punter = 0; myProperty.Punter < 3; myProperty.Punter++)
            {
                myPunter[myProperty.Punter] = Factory.GetAPunter(myProperty.Punter);
                myPunter[myProperty.Punter].PunterID = myProperty.Punter;
            }

            LBLs();

            PunterNotBetYet();

            myPunter[0].MyRadioButton.Text = "Jashandeep";
            myPunter[1].MyRadioButton.Text = "Jagdeep";
            myPunter[2].MyRadioButton.Text = "Tajinder";

            panelBetting.Visible = true;
            panelBets.Visible = true;
            lblMaxBet.Visible = true;
            btnBet.Enabled = true;
        }

        private void LBLs()
        {
            myProperty.LBLJashandeep = myProperty.NotBetYet;
            myProperty.LBLJagdeep = myProperty.NotBetYet;
            myProperty.LBLTajinder = myProperty.NotBetYet;
        }

        private void PunterNotBetYet()
        {
            myPunter[0].MyRadioButton = Jashandeep_RadioBtn;
            lblJashandeep.Text = myPunter[0].PunterName + myProperty.LBLJashandeep;
            myPunter[1].MyRadioButton = Jagdeep_RadioBtn;
            lblJagdeep.Text = myPunter[1].PunterName + myProperty.LBLJagdeep;
            myPunter[2].MyRadioButton = Tajinder_RadioBtn;
            lblTajinder.Text = myPunter[2].PunterName + myProperty.LBLTajinder;
        }
        #endregion

        #region Radio Buttons Clicked/Changed
        private void allRB_CheckedChanged(object sender, EventArgs e)
        {
            lblMaxBet.Visible = true;
            btnBet.Enabled = true;
            // RadioButton FakeRB = new RadioButton();
            myProperty.FakeRB = (RadioButton)sender;

            if (myProperty.FakeRB.Checked)
            {

                myProperty.Punter = Convert.ToInt16(myProperty.FakeRB.Tag);
                lblBettor.Text = myPunter[myProperty.Punter].PunterName;
                Cash();
                nudRabbitNumber.Minimum = 1;
                nudRabbitNumber.Maximum = Factory.RabbitCount;
                btnBet.Text = "Place Bet for " + lblBettor.Text;// myPunter[myProperty.Punter].PunterName;

            }
            //RadioButtonsClicked(sender);
        }
        #endregion

        private void MaxCashUsed()
        {
            for (myProperty.Punter = 0; myProperty.Punter < 3; myProperty.Punter++)
            {
                if (myPunter[myProperty.Punter].MaxCash == 0)
                {
                    myPunter[myProperty.Punter].MyRadioButton.Enabled = false;
                    btnBet.Enabled = false;
                }
                else
                {
                    myPunter[myProperty.Punter].MyRadioButton.Enabled = true;
                    btnBet.Enabled = true;
                }
            }
        }

        private void Cash()
        {
            lblMaxBet.Text = myPunter[myProperty.Punter].PunterName + "'s max bet is $" + myPunter[myProperty.Punter].MaxCash;
            nudCash.Maximum = myPunter[myProperty.Punter].MaxCash;
            nudCash.Text = myPunter[myProperty.Punter].MaxCash.ToString();

            //MaxCashUsed();
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            myProperty.Punter = Convert.ToInt16(myProperty.FakeRB.Tag);
            myPunter[myProperty.Punter].AmountBet = Convert.ToInt32(nudCash.Text);
            //myPunter[myProperty.Punter].MaxCash = myPunter[myProperty.Punter].MaxCash - myPunter[myProperty.Punter].AmountBet;


            AmountBetText();
            Cash();
        }

        private void AmountBetText()
        {
            myProperty.Rabbit = Convert.ToInt16(nudRabbitNumber.Text);
            myProperty.RabbitID = myProperty.Rabbit - 1;
            myRabbit[myProperty.RabbitID].RabbitID = myProperty.Rabbit;
            myPunter[myProperty.Punter].BettorRabbitNum = myProperty.Rabbit;
            if (myProperty.Punter == 0)
            {
                lblJashandeep.Text = myPunter[0].PunterName + " has bet $" + myPunter[0].AmountBet + " on #" + (myProperty.Rabbit) + " " + myRabbit[myProperty.RabbitID].Name + ".";
            }
            else if (myProperty.Punter == 1)
            {
                lblJagdeep.Text = myPunter[1].PunterName + " has bet $" + myPunter[1].AmountBet + " on #" + (myProperty.Rabbit) + " " + myRabbit[myProperty.RabbitID].Name + ".";

            }
            else
            {
                lblTajinder.Text = myPunter[2].PunterName + " has bet $" + myPunter[2].AmountBet + " on #" + (myProperty.Rabbit) + " " + myRabbit[myProperty.RabbitID].Name + ".";
            }
            btnRace.Visible = true;
        }
        #region Start Race
        private void btnRace_Click(object sender, EventArgs e)
        {
            StartRace();
            //IsWinner();

        }


        private void StartRace()
        {
            btnRace.Visible = false;
            btnBet.Visible = false;

            Factory.RaceTrackLength = Form1.ActiveForm.Width - pb1.Width - (pb1.Width / 2);
            while (
                pb1.Location.X < Factory.RaceTrackLength &&
                pb2.Location.X < Factory.RaceTrackLength &&
                pb3.Location.X < Factory.RaceTrackLength &&
                pb4.Location.X < Factory.RaceTrackLength
                )
            //do
            {

                for (myProperty.Rabbit = 0; myProperty.Rabbit < Factory.RabbitCount; myProperty.Rabbit++)
                {
                    myRabbit[myProperty.Rabbit].Run();
                    //Application.DoEvents();
                    Thread.Sleep(1);
                    if (myRabbit[myProperty.Rabbit].MyPictureBox.Location.X >= Factory.RaceTrackLength)
                    {
                        myProperty.RabbitRaceNum = myProperty.Rabbit + 1;
                        myProperty.RabbitID = myProperty.Rabbit;

                        lblWinner.Text = "Winner is Rabbit #" + myProperty.RabbitRaceNum + " Name: " + myRabbit[myProperty.RabbitID].Name;
                        btnNewRace.Visible = true;

                        IsWinner();
                    }
                }

            };





        }
        #endregion

        #region Is Winner
        private void IsWinner()
        {
            for (myProperty.Punter = 0; myProperty.Punter < 3; myProperty.Punter++)
            {
                if (myPunter[myProperty.Punter].BettorRabbitNum == myProperty.RabbitRaceNum)
                {
                    myPunter[myProperty.Punter].MaxCash += myPunter[myProperty.Punter].AmountBet;
                    btnBet.Enabled = true;
                }
                else
                {
                    myPunter[myProperty.Punter].MaxCash -= myPunter[myProperty.Punter].AmountBet;
                    if (myPunter[myProperty.Punter].MaxCash == 0)
                    {
                        if (myPunter[0].MaxCash == 0)
                        {
                            myProperty.LBLJashandeep = myProperty.Busted;
                            lblJashandeep.Text = myPunter[0].PunterName + myProperty.LBLJashandeep;
                            lblJashandeep.ForeColor = Color.Red;
                            lblMaxBet.Text = myPunter[0].PunterName + "'s max bet is $" + myPunter[0].MaxCash;
                        }
                        if (myPunter[1].MaxCash == 0)
                        {
                            myProperty.LBLJagdeep = myProperty.Busted;
                            lblJagdeep.Text = myPunter[1].PunterName + myProperty.LBLJagdeep;
                            lblJagdeep.ForeColor = Color.Red;
                            lblMaxBet.Text = myPunter[1].PunterName + "'s max bet is $" + myPunter[1].MaxCash;
                        }
                        if (myPunter[2].MaxCash == 0)
                        {
                            myProperty.LBLTajinder = myProperty.Busted;
                            lblTajinder.Text = myPunter[2].PunterName + myProperty.LBLTajinder;
                            lblTajinder.ForeColor = Color.Red;
                            lblMaxBet.Text = myPunter[2].PunterName + "'s max bet is $" + myPunter[2].MaxCash;
                        }
                        RestartRace();


                        myPunter[myProperty.Punter].MyRadioButton.Enabled = false;
                        btnBet.Enabled = false;
                    }
                }
                //lblMaxBet.Text = myPunter[myProperty.Punter].PunterName + "'s max bet is $" + myPunter[myProperty.Punter].MaxCash;
            }
        }

        private void RestartRace()
        {
            //if (myPunter[0].MaxCash == 0 && myPunter[1].MaxCash == 0 && myPunter[2].MaxCash == 0)
            //{
            //MessageBox.Show("Game Over!");
            if (myProperty.LBLJashandeep == " you have run out of Cash! BUSTED!" && myProperty.LBLJagdeep == " you have run out of Cash! BUSTED!" && myProperty.LBLTajinder == " you have run out of Cash! BUSTED!")
            {
                btnNewRace.Visible = false;
                btnRestart.Visible = true;
            }
            //}
        }
        #endregion


        #region New Race
        private void btnNewRace_Click(object sender, EventArgs e)
        {//Moves all the Rabbits back to their starting positions

            StartingPostition();
            //LoadData();
            PunterNotBetYet();

            btnBet.Visible = true;

            btnNewRace.Visible = false;
            lblWinner.Text = "";
        }

        private void StartingPostition()
        {
            for (myProperty.Rabbit = 0; myProperty.Rabbit < Factory.RabbitCount; myProperty.Rabbit++)
            {
                myRabbit[myProperty.Rabbit].StartingPostition();
            }
            myProperty.Rabbit = 0;
        }

        #endregion

        #region Restart Game
        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartingPostition();

            for (myProperty.Punter = 0; myProperty.Punter < 3; myProperty.Punter++)
            {
                myPunter[myProperty.Punter].MyRadioButton.Enabled = true;
                //btnBet.Enabled = false;

            }
            panelBets.Visible = false;
            panelBetting.Visible = false;
            lblMaxBet.Visible = false;
            btnRestart.Visible = false;
            btnBet.Visible = true;
            lblWinner.Text = "";

            lblJashandeep.ForeColor = Color.Black;
            lblJagdeep.ForeColor = Color.Black;
            lblTajinder.ForeColor = Color.Black;

            LoadData();
        }
        #endregion

        private void pbRaceTrack_Click(object sender, EventArgs e)
        {

        }
    }
}
