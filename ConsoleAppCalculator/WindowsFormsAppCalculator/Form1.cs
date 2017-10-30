﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCalculator
{
    public partial class Form1 : Form
    {
        public float fPrviBroj = 0;
        public float fDrugiBroj = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBroj - fDrugiBroj);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBroj + fDrugiBroj);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBroj * fDrugiBroj);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            fPrviBroj = Convert.ToSingle(inptFirstNumber.Value);
            fDrugiBroj = Convert.ToSingle(inptSecondNumber.Value);
            inptResult.Text = Convert.ToString(fPrviBroj / fDrugiBroj);
        }
    }
}
