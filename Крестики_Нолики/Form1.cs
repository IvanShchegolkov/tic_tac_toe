using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_Нолики
{
    public partial class Game : Form
    {
        Bitmap a = new Bitmap (@"D:\Program_files\C#\Проекты\Крестики_Нолики\Krest.png");
        Bitmap b = new Bitmap(@"D:\Program_files\C#\Проекты\Крестики_Нолики\Nolik.jpg");
        int keyNum;
        int NumProgress = 0;
        bool KrestNul = true;
        Button[] btn = new Button[9];
        Random rnd = new Random();

        public Game()
        {
            InitializeComponent();
            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;
            btn[3] = button4;
            btn[4] = button5;
            btn[5] = button6;
            btn[6] = button7;
            btn[7] = button8;
            btn[8] = button9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 1;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 2;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 3;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 4;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 5;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 6;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 7;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 8;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button10.Enabled = false;
            button11.Enabled = false;
            keyNum = 9;
            KeyPress();
            NumProgress++;
            Progress();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KrestNul = true;
            MessageBox.Show("Вы выбрали крестики");
            button10.Enabled = false;
            button11.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            KrestNul = false;
            MessageBox.Show("Вы выбрали нолики");
            button10.Enabled = false;
            button11.Enabled = false;
        }

        public void KeyPress()
        {
            switch (keyNum)
            {
                case 1:
                    if (KrestNul == true)
                    {
                        button1.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button1.BackgroundImage = b;
                    }
                    button1.BackgroundImageLayout = ImageLayout.Stretch;
                    button1.Enabled = false;
                    Machine();
                    break;
                case 2:
                    if (KrestNul == true)
                    {
                        button2.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button2.BackgroundImage = b;
                    }
                    button2.BackgroundImageLayout = ImageLayout.Stretch;
                    button2.Enabled = false;
                    Machine();
                    break;
                case 3:
                    if (KrestNul == true)
                    {
                        button3.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button3.BackgroundImage = b;
                    }
                    button3.BackgroundImageLayout = ImageLayout.Stretch;
                    button3.Enabled = false;
                    Machine();
                    break;
                case 4:
                    if (KrestNul == true)
                    {
                        button4.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button4.BackgroundImage = b;
                    }
                    button4.BackgroundImageLayout = ImageLayout.Stretch;
                    button4.Enabled = false;
                    Machine();
                    break;
                case 5:
                    if (KrestNul == true)
                    {
                        button5.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button5.BackgroundImage = b;
                    }
                    button5.BackgroundImageLayout = ImageLayout.Stretch;
                    button5.Enabled = false;
                    Machine();
                    break;
                case 6:
                    if (KrestNul == true)
                    {
                        button6.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button6.BackgroundImage = b;
                    }
                    button6.BackgroundImageLayout = ImageLayout.Stretch;
                    button6.Enabled = false;
                    Machine();
                    break;
                case 7:
                    if (KrestNul == true)
                    {
                        button7.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button7.BackgroundImage = b;
                    }
                    button7.BackgroundImageLayout = ImageLayout.Stretch;
                    button7.Enabled = false;
                    Machine();
                    break;
                case 8:
                    if (KrestNul == true)
                    {
                        button8.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button8.BackgroundImage = b;
                    }
                    button8.BackgroundImageLayout = ImageLayout.Stretch;
                    button8.Enabled = false;
                    Machine();
                    break;
                case 9:
                    if (KrestNul == true)
                    {
                        button9.BackgroundImage = a;
                    }
                    else if (KrestNul == false)
                    {
                        button9.BackgroundImage = b;
                    }
                    button9.BackgroundImageLayout = ImageLayout.Stretch;
                    button9.Enabled = false;
                    Machine();
                    break;
                default:
                    break;
            }
        }

        public void Progress()
        {
            if (NumProgress < 9)
            {
                if ((button1.BackgroundImage == a & button2.BackgroundImage == a & button3.BackgroundImage == a) || (button1.BackgroundImage == b & button2.BackgroundImage == b & button3.BackgroundImage == b))
                {
                    if (button1.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button1.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if((button4.BackgroundImage == a & button5.BackgroundImage == a & button6.BackgroundImage == a) || (button4.BackgroundImage == b & button5.BackgroundImage == b & button6.BackgroundImage == b))
                {
                    if (button4.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button4.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if ((button7.BackgroundImage == a & button8.BackgroundImage == a & button9.BackgroundImage == a) || (button7.BackgroundImage == b & button8.BackgroundImage == b & button9.BackgroundImage == b))
                {
                    if (button7.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button7.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if ((button1.BackgroundImage == a & button4.BackgroundImage == a & button7.BackgroundImage == a) || (button1.BackgroundImage == b & button4.BackgroundImage == b & button7.BackgroundImage == b))
                {
                    if (button1.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button1.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if ((button2.BackgroundImage == a & button5.BackgroundImage == a & button8.BackgroundImage == a) || (button2.BackgroundImage == b & button5.BackgroundImage == b & button8.BackgroundImage == b))
                {
                    if (button2.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button2.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if ((button3.BackgroundImage == a & button6.BackgroundImage == a & button9.BackgroundImage == a) || (button3.BackgroundImage == b & button6.BackgroundImage == b & button9.BackgroundImage == b))
                {
                    if (button3.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button3.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if ((button1.BackgroundImage == a & button5.BackgroundImage == a & button9.BackgroundImage == a) || (button1.BackgroundImage == b & button5.BackgroundImage == b & button9.BackgroundImage == b))
                {
                    if (button1.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button1.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if ((button3.BackgroundImage == a & button5.BackgroundImage == a & button7.BackgroundImage == a) || (button3.BackgroundImage == b & button5.BackgroundImage == b & button7.BackgroundImage == b))
                {
                    if (button3.BackgroundImage == a)
                    {
                        MessageBox.Show("Крестики победили");
                    }
                    else if (button3.BackgroundImage == b)
                    {
                        MessageBox.Show("Нолики победили");
                    }
                    Clears();
                }
                else if(button1.Enabled==false & button2.Enabled==false & button3.Enabled==false & button4.Enabled == false & button5.Enabled == false & button6.Enabled == false & button7.Enabled == false & button8.Enabled == false & button9.Enabled == false)
                {
                    MessageBox.Show("Ничья");
                    Clears();
                }
            }
        }

        public void Machine()
        {
            int n = rnd.Next(1, 9);
            switch (n)
            {
                case 1:
                    if (button1.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button1.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button1.BackgroundImage = a;
                        }
                        button1.BackgroundImageLayout = ImageLayout.Stretch;
                        button1.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 2:
                    if (button2.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button2.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button2.BackgroundImage = a;
                        }
                        button2.BackgroundImageLayout = ImageLayout.Stretch;
                        button2.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 3:
                    if (button3.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button3.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button3.BackgroundImage = a;
                        }
                        button3.BackgroundImageLayout = ImageLayout.Stretch;
                        button3.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 4:
                    if (button4.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button4.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button4.BackgroundImage = a;
                        }
                        button4.BackgroundImageLayout = ImageLayout.Stretch;
                        button4.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 5:
                    if (button5.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button5.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button5.BackgroundImage = a;
                        }
                        button5.BackgroundImageLayout = ImageLayout.Stretch;
                        button5.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 6:
                    if (button6.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button6.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button6.BackgroundImage = a;
                        }
                        button6.BackgroundImageLayout = ImageLayout.Stretch;
                        button6.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 7:
                    if (button7.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button7.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button7.BackgroundImage = a;
                        }
                        button7.BackgroundImageLayout = ImageLayout.Stretch;
                        button7.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 8:
                    if (button8.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button8.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button8.BackgroundImage = a;
                        }
                        button8.BackgroundImageLayout = ImageLayout.Stretch;
                        button8.Enabled = false;
                        NumProgress++;
                    }
                    break;
                case 9:
                    if (button9.Enabled == false)
                    {
                        Machine();
                    }
                    else
                    {
                        if (KrestNul == true)
                        {
                            button9.BackgroundImage = b;
                        }
                        else if (KrestNul == false)
                        {
                            button9.BackgroundImage = a;
                        }
                        button9.BackgroundImageLayout = ImageLayout.Stretch;
                        button9.Enabled = false;
                        NumProgress++;
                    }
                    break;
                default:
                    break;
            }
        }

        public void Clears()
        {
            NumProgress = default;
            button1.BackgroundImage = default;
            button1.Enabled = true;
            button2.BackgroundImage = default;
            button2.Enabled = true;
            button3.BackgroundImage = default;
            button3.Enabled = true;
            button4.BackgroundImage = default;
            button4.Enabled = true;
            button5.BackgroundImage = default;
            button5.Enabled = true;
            button6.BackgroundImage = default;
            button6.Enabled = true;
            button7.BackgroundImage = default;
            button7.Enabled = true;
            button8.BackgroundImage = default;
            button8.Enabled = true;
            button9.BackgroundImage = default;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
        }
    }
}
