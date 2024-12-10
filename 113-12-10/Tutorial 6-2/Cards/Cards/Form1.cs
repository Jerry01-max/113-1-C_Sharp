using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cards
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void showCard(string cardName)
        {
            switch (cardName)
            {
                
            } 

        }
        private void showCardButton_Click(object sender, EventArgs e)
        {
            if(cardListBox.SelectedIndex != -1)
            {
                showCard(cardListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("選擇一張牌");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
