using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Erica Moisei -- Aprinl 24, 2019

namespace ArrayListSimpleEx
{
    public partial class Form1 : Form
    {
        ArrayList sentence = new ArrayList();
        bool isReverse = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayMessage()
        {
            string msg = string.Empty;
            for (int i = 0; i < sentence.Count; i++)
            {
                msg += sentence[i].ToString() + " ";
            }
            lblMessage.Text = msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sentence.Add("I");
            sentence.Add("love");
            sentence.Add("prigramming");
            sentence.Add("so");
            sentence.Add("much");
        }

        private void btnShowMsg_Click(object sender, EventArgs e)
        {
            if(isReverse)
            {
                sentence.Reverse();
            }
            DisplayMessage();
            isReverse = false;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            sentence.Reverse();
            DisplayMessage();
            isReverse = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!isReverse)
            {
                sentence.Insert(1, txtSecondPos.Text.Trim());
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isReverse)
            {
                sentence.RemoveAt(1);
            }   
        } 
    }
}
