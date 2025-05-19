using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeNxN
{
    internal class Bot : Choice
    {
        private bool play = false; //play = false Player's turn play = true Bot's turn
        private string player; //X or Y
        private int possible; //The number of the button that should be chosen for the bot to win or (try) to not lose
        Random rnd = new Random();
        public Bot(int rowscollumns, string chararacter) : base(rowscollumns)
        {
            player = chararacter;
            //Removes the old EventHandler and adds the new one to play against the bot
            foreach(Button b in buttons)
            {
                b.Click -= base.ClickButton; 
                b.Click += new EventHandler(ClickButtonBot);
            }
        }

        private void ClickButtonBot(object o, EventArgs e)
        {
            Button b = (Button)o;
            if (!play && b.Text == "" || counter == 0) // Player's turn
            {
                if (won) { won = false; } //Indicates a new game.
                b.Text = player;
                if (player == "X") { b.BackColor = Color.Red; } else { b.BackColor = Color.Green; }
                arr[int.Parse(b.Name) / Size, int.Parse(b.Name) % Size] = 1; //Now 1 is Player and 2 is Bot
                counter++;
                play = true;

                if (counter > Size)
                {
                    Win();
                }

                if (!won && counter < Size * Size)
                {
                    playBot(); //Bot's turn
                }
            }
            else
            {
                MessageBox.Show("That area has already been selected!");
            }

            if (counter > Size)
            {
                Win();
            }

            if (counter == Size * Size)
            {
                MessageBox.Show("Draw!");
                Clear();
            }
        }

        private int Checker()
        {
            Button b = buttons[possible];
            if (b.Text == "")
            {
                arr[int.Parse(b.Name) / Size, int.Parse(b.Name) % Size] = 2;
                if (player == "X") { b.Text = "O"; b.BackColor = Color.Green; } else { b.Text = "X"; b.BackColor = Color.Red; }
                counter++;
                play = false;
                return 1; // Played something
            }
            return 0; //Didn't play
        }

        private void FindPossibleWin(int i,int j,int p)
        {
            if (arr[i, j] != p && arr[i, j] != 0)
            {
                win = 0;
            }
            else if (arr[i, j] == p)
            {
                win++;
            }
            else if (arr[i, j] != 2 && p == 1)
            {
                possible = Size * i + j;
            }
            else if (arr[i, j] != 1 && p == 2)
            {
                possible = Size * i + j;
            }
        }
        private void playBot()
        {
            if (play)
            {
                for (int p = 2; p > 0; p--) // 2 is Bot, 1 is Player
                {
                    for (int i = 0; i < Size; i++) // Checks Horizontally
                    {
                        
                        win = 0;
                        for (int j = 0; j < Size; j++)
                        {
                            FindPossibleWin(i,j,p);
                        }
                        if (win == Size - 1)
                        {
                            int checker = Checker();
                            if(checker == 1) { return; }
                        }

                    }
                    for (int j = 0; j < Size; j++) // Checks Vertically
                    {

                        win = 0;
                        for (int i = 0; i < Size; i++)
                        {
                            FindPossibleWin(i, j, p);
                        }
                        if (win == Size - 1)
                        {
                            int checker = Checker();
                            if (checker == 1) { return; }
                        }
                    }
                    win = 0;
                    for (int i = 0; i < Size; i++) // Diagonal \
                    {
                        FindPossibleWin(i, i, p);
                    }
                    if (win == Size - 1)
                    {
                        int checker = Checker();
                        if (checker == 1) { return; }
                    }
                    win = 0;
                    for (int i = Size - 1, j = 0; i > -1 && j < Size; i--, j++) // Diagonal /
                    {
                        FindPossibleWin(i, j, p);
                    }
                    if (win == Size - 1)
                    {
                        int checker = Checker();
                        if (checker == 1) { return; }
                    }

                }

                while (true)
                {
                    int randbuttom = rnd.Next(0, Size*Size - 1);
                    Button b = buttons[randbuttom];
                    if (b.Text == "")
                    {
                        arr[int.Parse(b.Name) / Size, int.Parse(b.Name) % Size] = 2;
                        if (player == "X") { b.Text = "O"; b.BackColor = Color.Green; } else { b.Text = "X"; b.BackColor = Color.Red; }
                        counter++;
                        play = false;
                        return;
                    }else if(counter >  Size * Size-1) { return; }
                }
            }

        }



    }
}
