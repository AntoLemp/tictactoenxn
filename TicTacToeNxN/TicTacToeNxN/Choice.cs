using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToeNxN
{
    internal class Choice
    {
        protected int Size; // Size of N
        protected List<Button> buttons = new List<Button>(); 
        private TableLayoutPanel myPanel = new TableLayoutPanel();
        private int x = -1; // It is used for the x of the array
        private int y = 0; // It is used for the y of the array
        protected bool X = true; // It is X's turn
        protected int[,] arr; // 2d array
        protected Label turn = new Label(); // The turn of Player
        protected int counter = 0; // Turns that have been played
        protected int win = 0; // If you reached the necessary point to win
        protected bool won = false; // If you won or not
        
        public Choice(int rowscollumns)
        {
            //Creating Panel for buttons
            Size = rowscollumns;
            arr = new int[rowscollumns, rowscollumns]; //A 2d array keeping track of the spots of X's (Marked as 1) and O's (Marked as 2)
            myPanel.ColumnCount = Size;
            myPanel.RowCount = Size;
            float percentage = (100 / Size) ;
            
            for (int i = 0; i < Size*Size; i++)
            { //Creating buttons 
                Button myButton = new Button();
                myButton.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(161)));
                myButton.Name =  i.ToString(); // Name from 0,1...,N-1
                myButton.TabIndex = 1 + i + 1;
                myButton.UseVisualStyleBackColor = true;
                myButton.Click += new EventHandler(ClickButton);
                myButton.Dock = DockStyle.Fill; 
                buttons.Add(myButton);
                x++; 
                if(x == Size) 
                {
                    y++;
                    x = 0;
                }

                myPanel.Controls.Add(myButton, x,y); //Placing buttons in panel
                myPanel.Dock = DockStyle.Fill;

                //Label for player's turn
                this.turn.AutoSize = true;
                this.turn.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(161)));
                this.turn.Location = new Point(21, 19);
                this.turn.Name = "turn";
                this.turn.TabIndex = 7;
                this.turn.Text = "Player\'s X Turn";
                

            }

            //Panel Size
            for (int j = 0; j < Size; j++)
            {
                myPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, percentage));
                myPanel.RowStyles.Add(new RowStyle(SizeType.Percent, percentage));
            }
            
            
        }
        public TableLayoutPanel getPanel() 
        {
            return myPanel;
        }
        public Label getLabel() //Label for player's turn
        {
            return turn;
        }

        protected void Clear() //Clears all buttons and sets all the variables back to their starting point
        {
            foreach (Button b in buttons)
            {
                b.Text = "";
                b.BackColor = Color.White;
            }
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    arr[i, j] = 0;
                }
            }
            counter = 0;
            win = 0;
        }

        protected void Win() //Checks if somebody won
        {
            for (int player = 1; player < 3; player++) // X = 1 , O = 2
            {
                for (int i = 0; i < Size; i++) //Horizontal 
                {
                    win = 0;
                    for (int j = 0; j < Size; j++)
                    {
                        if (arr[i, j] == player)
                        {
                            win++;
                        }
                    }
                    if (win == Size)
                    {
                        if(player  == 1)
                        {
                            MessageBox.Show("Player using X won!");
                        }else { MessageBox.Show("Player using O won!"); }
                        won = true;
                        Clear();
                        return;
                    }
                }
                
                for (int i = 0; i < Size; i++) //Vertical 
                {
                    win = 0;
                    for (int j = 0; j < Size; j++)
                    {
                        if (arr[j, i] == player)
                        {
                            win++;
                        }
                    }
                    if (win == Size)
                    {
                        won = true;
                        if (player == 1)
                        {
                            MessageBox.Show("Player using X won!");
                        }
                        else { MessageBox.Show("Player using O won!"); }
                        Clear();
                        return;
                    }
                }
                
                win = 0;
                for (int i = 0; i < Size; i++) // Diagonal \
                {
                    if (arr[i, i] == player)
                    {
                        win++;
                    }

                    if (win == Size)
                    {
                        won = true;
                        if (player == 1)
                        {
                            MessageBox.Show("Player using X won!");
                        }
                        else { MessageBox.Show("Player using O won!"); }
                        Clear();
                        return;
                    }
                }
                win = 0;
                
                for (int i = Size - 1, j = 0; i > -1 && j < Size; i--, j++) // Diagonal /
                {
                    if (arr[i, j] == player)
                    {
                        win++;
                    }
                    if (win == Size)
                    {
                        won = true;
                        if (player == 1)
                        {
                            MessageBox.Show("Player using X won!");
                        }
                        else { MessageBox.Show("Player using O won!"); }
                        Clear();
                        return;
                    }
                }
                win = 0;
            }
        }
        
        protected void ClickButton(object o, EventArgs e)
        {

            Button b = (Button)o;
            if (X && b.Text == "") // X's turn
            {
                b.Text = "X";
                b.BackColor = Color.Red;
                turn.Text = "Player\'s O Turn";
                arr[int.Parse(b.Name)/Size, int.Parse(b.Name) % Size] = 1;
                X = false;
                counter++;
            } else if(!X && b.Text == "") // O's turn
            {
                b.Text = "O";
                b.BackColor = Color.Green;
                turn.Text = "Player\'s X Turn";
                arr[int.Parse(b.Name) / Size, int.Parse(b.Name) % Size] = 2;
                X = true;
                counter++;
            }
            else
            {
                MessageBox.Show("That area has already been selected!");
            }

            if (counter > Size)
            {
                Win();
            }

            if(counter == Size*Size)
            {
                MessageBox.Show("Draw!");
                Clear();
            }

        }

    }



}
