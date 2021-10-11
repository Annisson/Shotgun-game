using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Shotgun
{
    public partial class Form1 : Form
    {
        Opponent opponent = new Opponent();
        Player player = new Player();

        public Form1()
        {
            InitializeComponent();
            
            player.BulletsCount = 0;
            opponent.BulletsCount = 0;
            UpdateBulletsCount();

            player.WinCount = 0;
            opponent.WinCount = 0;
            UpdateWinCount();

            if (player.BulletsCount != 3)
            {
                buttonShotgun.Visible = false;
            }          

        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            string opponentChoice = OpponentChoice(opponent.BulletsCount);

            if (player.BulletsCount == 0)
            {               
                MessageBox.Show("You don't have any bullets, you have to load your gun!");
            }
            else if (player.BulletsCount == 1 || player.BulletsCount == 2)
            {
                
                if (opponentChoice == "shotgun")
                {
                    opponent.WinCount++;
                    UpdateWinCount();
                    MessageBox.Show("YOU LOST! \nYour opponent used SHOTGUN.");
                    GameOver();
                }
                else if (opponentChoice == "load")
                {
                    player.WinCount++;
                    UpdateWinCount();
                    MessageBox.Show("YOU WON! \nYour opponent loaded their gun and got shot.");
                    GameOver();
                }
                else if (opponentChoice == "shoot")
                {
                    player.BulletsCount--;
                    opponent.BulletsCount--;
                    AddItemsToListBox("You both shot and lost bullets.");
                }
                else if (opponentChoice == "block")
                {
                    player.BulletsCount--;
                    AddItemsToListBox("You shot, but your opponent blocked.");
                }

            }
            else if (player.BulletsCount == 3)
            {
                MessageBox.Show("You have three bullets already, use the shotgun!");
            }

            UpdateBulletsCount();
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            string opponentChoice = OpponentChoice(opponent.BulletsCount);


            if (player.BulletsCount == 3)
            {
                MessageBox.Show("You have three bullets already, use the shotgun!");
            }
            else
            {                
                if (opponentChoice == "shotgun")
                {
                    opponent.WinCount++;
                    UpdateWinCount();
                    MessageBox.Show("YOU LOST! \nYour opponent used SHOTGUN.");
                    GameOver();
                }
                else if (opponentChoice == "load")
                {
                    player.BulletsCount++;
                    opponent.BulletsCount++;
                    AddItemsToListBox("You both loaded your guns.");
                    if (player.BulletsCount == 3)
                    {
                        ShotgunButtonShow();
                    }
                }
                else if (opponentChoice == "shoot")
                {
                    opponent.WinCount++;
                    UpdateWinCount();
                    MessageBox.Show("YOU LOST! \nYour opponent shot while your were loading your gun.");
                    GameOver();
                }
                else if (opponentChoice == "block")
                {
                    player.BulletsCount++;
                    AddItemsToListBox("Your opponent blocked while you loaded your gun.");
                    if (player.BulletsCount == 3)
                    {
                        ShotgunButtonShow();
                    }
                }

            }
            UpdateBulletsCount();
        }

        private void buttonBlock_Click(object sender, EventArgs e)
        {
            string opponentChoice = OpponentChoice(opponent.BulletsCount);

            if (opponentChoice == "shotgun")
            {
                opponent.WinCount++;
                UpdateWinCount();
                MessageBox.Show("YOU LOST! \nYour opponent used SHOTGUN.");
                GameOver();
            }
            else if (opponentChoice == "load")
            {
                opponent.BulletsCount++;
                AddItemsToListBox("Your opponent loaded their gun while you blocked.");
            }
            else if (opponentChoice == "shoot")
            {
                opponent.BulletsCount--;
                AddItemsToListBox("Your opponent shot, but you blocked!");
            }
            else if (opponentChoice == "block")
            {
                AddItemsToListBox("You both blocked.");
            }
            UpdateBulletsCount();
        }

        private void buttonShotgun_Click(object sender, EventArgs e)
        {
            string opponentChoice = OpponentChoice(opponent.BulletsCount);

            if (opponentChoice == "shotgun")
            {
                AddItemsToListBox("You BOTH used shotgun and lost all your bullets!");
                player.BulletsCount = 0;
                opponent.BulletsCount = 0;
                buttonShotgun.Visible = false;
                UpdateBulletsCount();
            }
            else
            {
                player.WinCount++;
                UpdateWinCount();
                MessageBox.Show("YOU WON! \nYou used SHOTGUN.");
                GameOver();
            }
            
        }
        private string OpponentChoice(int bullets)
        {
            Opponent opponent = new Opponent();
            string choice = opponent.OpponentChoice(bullets);
            return choice;
        }

        private void UpdateBulletsCount()
        {
            textBoxShotsLeft.Text = player.BulletsCount.ToString();
            textBoxOpponentShotsLeft.Text = opponent.BulletsCount.ToString();
        }
        private void UpdateWinCount()
        {
            textBoxPlayerScore.Text = player.WinCount.ToString();
            textBoxOpponentScore.Text = opponent.WinCount.ToString();
        }
        private void ShotgunButtonShow()
        {
            buttonShotgun.Visible = true;
        }

        private void AddItemsToListBox(string item) 
        {
            listBox1.Items.Add(item);
        }
        private void GameOver() 
        {
            listBox1.Items.Clear();
            player.BulletsCount = 0;
            opponent.BulletsCount = 0;
            buttonShotgun.Visible = false;
            UpdateBulletsCount();
        }
 
    }
}
