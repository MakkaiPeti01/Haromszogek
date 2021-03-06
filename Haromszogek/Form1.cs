﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Haromszogek
{
    public partial class frmFo : Form
    {
        private double aOldal;
        private double bOldal;
        private double cOldal;
        public frmFo()
        {
            aOldal = 0;
            bOldal = 0;
            cOldal = 0;
            InitializeComponent();
            tbAoldal.Text = aOldal.ToString();
            tbBoldal.Text = bOldal.ToString();
            tbColdal.Text = cOldal.ToString();
            lbHarmszogLista.Items.Clear();
        }

        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_szamol_Click(object sender, EventArgs e)
        {
            try
            {
                aOldal = int.Parse(tbAoldal.Text);
                bOldal = int.Parse(tbBoldal.Text);
                cOldal = int.Parse(tbColdal.Text);
                if (aOldal == 0 || bOldal == 0 || cOldal == 0)
                {
                    MessageBox.Show("Nem lehet 0", "Nem lehet 0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var h = new Haromszog(aOldal, bOldal, cOldal);
                    //MessageBox.Show(szoveg.ToString(), "Ez most", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                    List<string> adatok = h.AdatokSzoveg();
                    foreach (var i in adatok)
                    {
                        lbHarmszogLista.Items.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Számot adjon meg!","Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAoldal.Focus();
            }
        }

        private void btnTorol_Click(object sender, EventArgs e)
        {
            if (lbHarmszogLista.Items.Count>0)
            {
                lbHarmszogLista.Items.Clear();
            }
            else
            {
                MessageBox.Show("Nincs mit törölni");
            }
        }

        private void btnFajlbol_Click(object sender, EventArgs e)
        {
            lbHarmszogLista.Items.Clear();
            if (ofdMegnyitas.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamReader file = new StreamReader(ofdMegnyitas.FileName);
                    try
                    {
                        while (!file.EndOfStream)
                        {
                            string sor = file.ReadLine();
                            var h = new Haromszog(sor);
                            lbHarmszogLista.Items.Add("Fájlból olvasás");
                            foreach (var i in h.AdatokSzoveg())
                            {
                                lbHarmszogLista.Items.Add(i);
                                Console.WriteLine(i);
                            }
                            lbHarmszogLista.Items.Add("-----------------------------------------------------");
                        }
                        file.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        file.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }
    }
}
