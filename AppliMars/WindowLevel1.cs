﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliMars {
    public partial class WindowLevel1 : Form {

        #region variables

        private int _currentDay;
        private Mission _mission;
        private int _numPage;
        private List<Button> _boutons = new List<Button>();
        private WindowLevel0 win0;
        
        #endregion


        #region accesseurs

        public Mission maMission {
            get { return _mission; }
            set { _mission = value; }
        }

        public int maJournneeCourante {
            get { return _currentDay; }
            set { _currentDay = value; }
        }

        public int monNumeroPage {
            get { return _numPage; }
            set { _numPage = value; }
        }

        public List<Button> MesBoutons {
            get { return _boutons; }
            set { _boutons = value; }
        }

        public WindowLevel0 maFenetrePrec {
            get { return win0; }
            set { win0 = value; }
        }
        

        #endregion


        #region constructeurs

        public WindowLevel1(Mission miss, WindowLevel0 winzero) {
            InitializeComponent();

            maFenetrePrec = winzero;
            maMission = miss;
            this.Text = maMission.monNomMission;
            DateTime now = DateTime.Now;

            TimeSpan diff = now - _mission.maDateDebut;
            Double totalMin = diff.TotalMinutes;

            int nbJours = (int)(totalMin / 1480);
            double minRestantes = (totalMin - (nbJours * 1480));

            int hActuelle = (int)(minRestantes / 60);
            int minActuelle = (int)(minRestantes - (hActuelle * 60));

            labelJour.Text = nbJours.ToString();
            labelHeures.Text = hActuelle.ToString();
            labelMinutes.Text = minActuelle.ToString();

            _mission.monJourJ = nbJours+1;
            maJournneeCourante = nbJours+1;


            for (int i = 1; i < _mission.maDureeMission+1; i++) {
                // comboBoxJourDebut.Items.Add(_mission._planning._tableauJournees[i]);
                comboBoxJourDebut.Items.Add(i);
                comboBoxJourFin.Items.Add(i);
            }

            comboBoxJourDebut.SelectedIndex = 1;
            comboBoxJourFin.SelectedIndex = maMission.maDureeMission -1;

            MesBoutons=genererBoutonsJours();

            monNumeroPage = 0;
            affichageBoutons("right");
        }

        #endregion


        #region methodes

        public IEnumerable<Control> GetAll(Control control, Type type) {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        public List<Button> genererBoutonsJours() {

            Planning P = maMission.monPlanning;
            List<Button> monCalendrier = new List<Button>();

            int date = 1, page, ligne, rang;

            foreach (Journee J in P.monTableauJournees) {
                page = ((date - 1) / 50) + 1;
                ligne = (((date - 1) - ((page - 1) * 50)) / 10) + 1;
                rang = (date - 1) - ((page - 1) * 50) - ((ligne - 1) * 10);

                Button jour = new Button();
                jour.Text = Convert.ToString(date);
                jour.Width = 50;
                jour.Height = 50;
                jour.Visible = false;
                jour.Enabled = false;
                jour.Location = new System.Drawing.Point(95 + 56 * rang, 56 * ligne);
                jour.Click += new System.EventHandler(journee_Click);
                monCalendrier.Add(jour);
                date++;
                if (date < _mission.monJourJ) {
                    jour.BackColor = System.Drawing.Color.Silver;
                } else if (date == _mission.monJourJ) {
                    jour.BackColor = System.Drawing.Color.LightBlue;
                } else {
                    jour.BackColor = System.Drawing.Color.PaleGreen;
                }

                groupBoxCalendrier.Controls.Add(jour);

            }
            pictureBoxLeftArrow.Enabled = false;

            return monCalendrier;
        }

        public void affichageBoutons(string direction) {

            if (direction == "left") {
                monNumeroPage--;
                for (int i = (monNumeroPage) * 50; i < MesBoutons.Count(); i++) {
                    MesBoutons[i].Visible = false;
                    MesBoutons[i].Enabled = false;
                }
            } else if (direction == "right")  {
                monNumeroPage++;
                for (int i = 0; i < (monNumeroPage - 1) * 50; i++) {
                    MesBoutons[i].Visible = false;
                    MesBoutons[i].Enabled = false;
                }
            }

            for (int i = (monNumeroPage - 1) * 50; i < (monNumeroPage) * 50; i++) { 
                MesBoutons[i].Visible = true;
                MesBoutons[i].Enabled = true;
            }

            if (monNumeroPage >= 10)
                pictureBoxRightArrow.Enabled = false;
            else if (monNumeroPage > 1)
                pictureBoxLeftArrow.Enabled = true;
            else if (monNumeroPage <= 1) 
                pictureBoxLeftArrow.Enabled = false;
            else if (monNumeroPage < 10) 
                pictureBoxRightArrow.Enabled = true;

        }

        #endregion


        #region evenements

        private void journee_Click(object sender, EventArgs e) {
            Button but = sender as Button;
            Journee monJour = maMission.monPlanning.monTableauJournees[Int32.Parse(but.Text)-1];
            WindowLevel2 win2 = new WindowLevel2(monJour, this);
            win2.Show();
            this.Hide();
        }

        private void pictureBoxLeftArrow_Click(object sender, EventArgs e) {
            affichageBoutons("left");
        }

        private void pictureBoxRightArrow_Click(object sender, EventArgs e) {
            affichageBoutons("right");
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            WindowResultSearch win2 = new WindowResultSearch(this, textBoxSearch, comboBoxJourDebut, comboBoxJourFin);
            win2.Show();
            this.Hide();
        }

        private void buttonRetourChoixMission_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
        }

        #endregion


    }
}
