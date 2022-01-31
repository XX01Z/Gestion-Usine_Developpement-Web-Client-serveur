﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Usine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sommaireDeLaideToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void employésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employes employe = new Employes();
            employe.ShowDialog();
        }


        private void fichierToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Article article = new Article();
            article.ShowDialog();
        }

        private void saisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Saisie saisie = new Saisie();
            saisie.ShowDialog();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultation consultation = new Consultation();
            consultation.ShowDialog();
        }

        private void validationDeLaSaisieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ValidSaisie validSaisie = new ValidSaisie();
            validSaisie.ShowDialog();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Apropos apropos = new Apropos();
            apropos.ShowDialog();
        }
    }
}
