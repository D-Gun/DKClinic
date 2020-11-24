﻿using System.Drawing;
using System.Windows.Forms;

namespace DKClinic.Customer
{
    public partial class ShortAnswer : BaseQuestion
    {
        public ShortAnswer()
        {
            InitializeComponent();
        }

        public void CreateAnswer()
        {
            RichTextBox txb = new RichTextBox();
            txb.Location = new Point(5, 5);
            txb.Size = new Size(600, 60);
            txb.Font = new Font("Gulim", 14F);
            pnlAnswer.Controls.Add(txb);
        }
    }
}
