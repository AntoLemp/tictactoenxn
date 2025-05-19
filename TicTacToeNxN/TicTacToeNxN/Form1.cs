using System;
using System.Windows.Forms;

namespace TicTacToeNxN
{
    public partial class Form1 : Form
    {
        int rowsxcollumns;
        Choice choice;
        Bot bot;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxChooseGame.SelectedIndex = 3; // NxN
            comboBoxChooseMode.SelectedIndex = 0; // Player vs Player
            comboBoxPlayer.SelectedIndex = 0; // X 

        }
        
        private void run(int num) //Starts game based on the options you have chosen
        {
            if (choice != null) 
            {
                panel2.Controls.Remove(choice.getPanel());
                panel1.Controls.Remove(choice.getLabel());
            }
            if (bot != null)
            {
                panel2.Controls.Remove(bot.getPanel());
            }
            if (comboBoxChooseMode.SelectedIndex == 0)
            {
                choice = new Choice(num);
                panel2.Controls.Add(choice.getPanel());
                panel1.Controls.Add(choice.getLabel());
            }
            else
            {
                bot = new Bot(num, comboBoxPlayer.Text);
                panel2.Controls.Add(bot.getPanel());

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Choose Game
        {
            textBox1.Text = "";
            Give_N.Hide();
            textBox1.Hide();
            button1.Hide();
            if (comboBoxChooseGame.Text == "3x3")
            {
                rowsxcollumns = 3;
                run(rowsxcollumns);
                
            }
            else if(comboBoxChooseGame.Text == "5x5")
            {
                rowsxcollumns = 5;
                run(rowsxcollumns);
            }
            else if(comboBoxChooseGame.Text == "7x7")
            {
                rowsxcollumns = 7;
                run(rowsxcollumns);

            }
            else if(comboBoxChooseGame.Text == "NxN")
            {
                Give_N.Show();
                textBox1.Show();
                button1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e) // OK Button
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("You haven't given N");
            }else
            { 
                int N;
                int odd;
                try
                {
                    N = int.Parse(textBox1.Text);
                    if (N > 1)
                    {
                        odd = N % 2;
                        if(odd == 1)
                        {
                            rowsxcollumns = N;
                            run(rowsxcollumns);
                        }
                        else
                        {
                            MessageBox.Show("N can only be an odd Number");
                        }
                    }
                    else
                    {
                        MessageBox.Show("N can only be a positive odd Number greater than 1");
                    }
                }
                catch
                {
                    MessageBox.Show("You haven't given a number");
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) // Choose Mode
        {
            if(comboBoxChooseMode.SelectedIndex == 0) //Player vs Player
            {
                Player.Hide();
                comboBoxPlayer.Hide();
                if (rowsxcollumns != 0)
                {
                    run(rowsxcollumns);
                }
            } else //Player vs Bot
            {
                Player.Show();
                comboBoxPlayer.Show();
                if (rowsxcollumns != 0)
                {
                    run(rowsxcollumns);
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e) //ComboBoxPlayer
        {
            if (rowsxcollumns != 0)
            {
                run(rowsxcollumns);
            }
        }
    }
}
