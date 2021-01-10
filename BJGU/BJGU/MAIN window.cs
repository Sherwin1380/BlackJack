using System;
using System.Windows;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using MessageBox = System.Windows.Forms.MessageBox;

namespace BJGU
{
    public partial class Form1 : Form
    {

        DECK deck = new DECK();
        Wallet wallet = new Wallet();
        Points Point = new Points();
        private int cardNumber;
        private int oppCardValue = 0;
        private int PlayerCardValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int player;
        public int computer;
        public int x;
        private void nEWGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OppPointsLabel.Visible = false;
            PlayerPointsLabel.Visible = false;
            DealCash.Enabled = true;
            DealButton.Enabled = true;
            player = computer = 500;
            string input = Interaction.InputBox("Enter your name:", "USERNAME INPUT", "", 250, 220);
            if(input.Length!=0)
            label3.Text = input;
            PlayerWallet.Text = ""+player;
            OppWallet.Text = "" + computer;
        }

        private void rULESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1.Blackjack starts with players making bets"+"\n"+"\n" + "2.Dealer deals 2 cards to the players and two to himself" + "\n" + "\n" + "3.Blackjack card values: All cards count their face value in blackjack.Picture cards count as 10 and the ace can count as either 1 or 11.Card suits have no meaning in blackjack.The total of any hand is the sum of the card values in the hand." + "\n" + "\n" + "4.Players must decide whether to STAND or HIT" + "\n" + "\n" + "5.The dealer acts last and must hit on 16 or less and stand on 17 through 21." + "\n" + "\n" + "6.Players win when their hand totals higher than dealer’s hand, or they have 21 or less when the dealer busts(i.e., exceeds 21).","Rules");
        }


        private void DealButton_Click(object sender, EventArgs e)
        {
            deck.SetUpDeck();
            if (string.IsNullOrWhiteSpace(DealCash.Text))
            {
                MessageBox.Show("No bet amount placed", "BET AMOUNT");
            }

            else
            {
                try
                {
                    x = Int32.Parse(DealCash.Text);
                    if (Convert.ToInt32(PlayerWallet.Text) == 0)
                    {
                        MessageBox.Show("Player has no money left start a new Game");
                    }
                    else if(x <= Convert.ToInt32(PlayerWallet.Text) && x>0)
                    {

                        PlayerWallet.Text =""+ wallet.UpdateWallet(Convert.ToInt32(PlayerWallet.Text), Convert.ToInt32(DealCash.Text));
                        OppWallet.Text =""+ wallet.UpdateWallet(Convert.ToInt32(OppWallet.Text), Convert.ToInt32(DealCash.Text));
                        HitButton.Visible = true;
                        StopButton.Visible = true;
                        HitButton.Enabled = true;
                        StopButton.Enabled = true;
                        DealButton.Enabled = false;
                        DealCash.Enabled = false;
                        OppPointsLabel.Visible = true;
                        PlayerPointsLabel.Visible=true;
                        for (cardNumber = 0; cardNumber < 4; cardNumber++)
                        {
                            if (cardNumber < 2)
                            {
                                OppCardsLabel.Text = $"{OppCardsLabel.Text} \n  + {deck.ShowFirstCards(cardNumber)}";
                                oppCardValue = oppCardValue + deck.CardValue(cardNumber);
                                OppPointsLabel.Text = "Total Points = " + oppCardValue;
                            }
                            else
                            {
                                PlayerCardsLabel.Text = $"{PlayerCardsLabel.Text} \n  + {deck.ShowFirstCards(cardNumber)}";
                                PlayerCardValue = PlayerCardValue + deck.CardValue(cardNumber);
                                PlayerPointsLabel.Text = "Total Points = " + PlayerCardValue;
                            }
                        }
                        Checkif21();

                    }
                    else
                        throw new Exception("aaa");
                    }
                catch
                {
                    MessageBox.Show("Enter a Valid Number", "BET AMOUNT");
                }

            }

        }
        private void Checkif21()
        {
            if (PlayerCardValue > 21)
            {
                //StopButtonProcess();
                WhoWin();
                ResetPoints();
                DealButton.Visible = true;
                DealButton.Enabled = true;
                HitButton.Visible = false;
                StopButton.Visible = false;
            }
        }
        private void HitButton_Click(object sender, EventArgs e)
        {
            cardNumber++;
            PlayerCardsLabel.Text = $"{PlayerCardsLabel.Text} \n  + {deck.ShowFirstCards(cardNumber)}";
            PlayerCardValue = PlayerCardValue + deck.CardValue(cardNumber);
            PlayerPointsLabel.Text = "Total Points = " + PlayerCardValue;

            Checkif21();
        }
        private void StopButton_Click(object sender, EventArgs e)
        {
            StopButtonProcess();
            WhoWin();
            ResetPoints();
            DealButton.Enabled = true;
            DealButton.Visible = true;
        }

        private void StopButtonProcess()
        {
            //show DEAL button, Hide and Stop buttons hidden
            DealButton.Visible = true;
            HitButton.Visible =false;
            StopButton.Visible = false;

            //give opponent next card until opponent point will less than 18
            while (oppCardValue < 18)
            {
                cardNumber++;
                OppCardsLabel.Text = $"{OppCardsLabel.Text} \n  + {deck.ShowFirstCards(cardNumber)}";
                oppCardValue = oppCardValue + deck.CardValue(cardNumber);
                OppPointsLabel.Text = "Total Points = " + oppCardValue;

            }
        }


        private void WhoWin()
        {
            if (PlayerCardValue > 21)
            {
                MessageBox.Show("Opponent Win");
                OpponentWinWallet();
            }
            else if (oppCardValue > 21)
            {
                MessageBox.Show("Player Win");
                PlayerWinWallet();
            }
            else
            {
                int OppWin = 21 - oppCardValue;
                int PlayerWin = 21 - PlayerCardValue;
                if (OppWin > PlayerWin)
                {
                    MessageBox.Show("Player Win");
                    PlayerWinWallet();
                }
                if (OppWin < PlayerWin)
                {
                    MessageBox.Show("Opponent Win");
                    OpponentWinWallet();
                }
                else if (OppWin == PlayerWin)
                {
                    MessageBox.Show("It's a draw");
                    OppCardsLabel.Text = "Computer Cards";
                    PlayerCardsLabel.Text = "Player Cards";
                    DealButton.Visible = true;
                    DealButton.Enabled = true;
                    DealCash.Enabled = true;
                }
            }
        }

        public void PlayerWinWallet()
        {
            int k= wallet.WinnigMoney(Int32.Parse(PlayerWallet.Text), Convert.ToInt32(DealCash.Text));
            PlayerWallet.Text = "" + k;
            if (Convert.ToInt32(OppWallet.Text) == 0)
            {
                MessageBox.Show("Opponent don't have money to play\nPlayer win");
                DealButton.Visible = false;
            }
            OppCardsLabel.Text = "Computer Cards";
            PlayerCardsLabel.Text = "Player Cards";
            DealCash.Enabled = true;
        }

        //update opponent wallet when Opponent win
        public void OpponentWinWallet()
        {
         int k=wallet.WinnigMoney(Int32.Parse(OppWallet.Text), Int32.Parse(DealCash.Text));
            OppWallet.Text = ""+k;
            if (Convert.ToInt32(PlayerWallet.Text) == 0)
            {
                MessageBox.Show("Player don't have money to play\nOpponent win");
                DealButton.Visible = false;
            }
            OppCardsLabel.Text ="Computer Cards";
            PlayerCardsLabel.Text = "Player Cards";
            DealCash.Enabled = true;
        }
        public void ResetPoints()
        {
            PlayerCardValue = 0;
            oppCardValue = 0;
        }

        private void PlayerPointsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
