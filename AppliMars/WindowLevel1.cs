using System;
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

        private int _currentDay = 12;
        private Mission _mission;
        private Planning plan = new Planning(500);


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
        

        #endregion


        #region constructeurs

        public WindowLevel1() {
            InitializeComponent();

            Astronaute ast = new Astronaute("Bob");


            // TO DO 
            // Charger ici la date du début de la mission
            DateTime deb = new DateTime(2015,11,12,00,01,00);
            List<string> list = new List<string>();
            _mission = new Mission("MaMission", deb, 500, list);

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

            _mission.monJourJ = nbJours;





            Console.WriteLine(diff);


            // TO DO : Remplacer par les lignes commentées après avoir créer les XML des Missions
            // for (int i = 0; i < _mission._dureeMission; i++) {
            for (int i = 1; i <= 500; i++) {
                // comboBoxJourDebut.Items.Add(_mission._planning._tableauJournees[i]);
                comboBoxJourDebut.Items.Add(i);
                comboBoxJourFin.Items.Add(i);
            }

            comboBoxJourDebut.SelectedIndex = 0;
            comboBoxJourFin.SelectedIndex = 499;


            int ent = 500;
            int cpt = 1;

            for (int i = 1; i <= ent / 50; i++) {

                for (int j = 1; j <= 5; j++) {

                    for (int k = 1; k <= 10; k++) {

                        Button bt = new Button();
                        bt.Text = cpt.ToString();
                        groupBoxCalendrier.Controls.Add(bt);
                        bt.Width = 50;
                        bt.Height = 50;

                        // TO DO
                        // Vérifier si le jour est passé ou non
                        if (cpt < _mission.monJourJ) {
                            bt.BackColor = System.Drawing.Color.Silver;
                        } else if (cpt == _mission.monJourJ) {
                            bt.BackColor = System.Drawing.Color.LightBlue;
                        } else {
                            bt.BackColor = System.Drawing.Color.PaleGreen;
                        }

                        bt.Click += new EventHandler(journee_Click);

                        bt.Location = new Point(98 + ((k-1) * 56), 28 + ((j-1) * 56));

                        cpt++;
                    }
                }
            }

            Console.WriteLine("teset");

        }

        // Initialise les XX boutons des jours
        public WindowLevel1(int ent) {
            InitializeComponent();
            


        }

        #endregion


        #region methodes

        public IEnumerable<Control> GetAll(Control control, Type type) {
            var controls = control.Controls.Cast<Control>();
            return controls.SelectMany(ctrl => GetAll(ctrl, type)).Concat(controls).Where(c => c.GetType() == type);
        }

        #endregion


        #region evenements

        private void journee_Click(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowLevel2 win2 = new WindowLevel2(but.Text, this);
            win2.Show();
            this.Hide();
        }

        private void pictureBoxLeftArrow_Click(object sender, EventArgs e) {

            /*
            if (trackBarCalendrier.Value > 0) {
                trackBarCalendrier.Value = trackBarCalendrier.Value - 1;
            }
            trackBarCalendrier_Scroll(sender, e);
            */





        }

        private void pictureBoxRightArrow_Click(object sender, EventArgs e) {

            /*
            if (trackBarCalendrier.Value < 9) {
                trackBarCalendrier.Value = trackBarCalendrier.Value + 1;
            }
            trackBarCalendrier_Scroll(sender, e);
            */





        }

        /*
        private void trackBarCalendrier_Scroll(object sender, EventArgs e) {

            var c = GetAll(this, typeof(Button));

            // MessageBox.Show("Total Controls: " + c.Count());
            
            // var first = c.


            Console.WriteLine("Valeur trackbar : " + trackBarCalendrier.Value);

            for (int i = 0; i < groupBoxCalendrier.Controls.Count; i++) {
                if (groupBoxCalendrier.Controls[i].Name.Contains("buttonDay")) {

                    groupBoxCalendrier.Controls[i].Text = Convert.ToString((50 * trackBarCalendrier.Value) + i );

                    if (int.Parse(labelDay.Text) == (50 * trackBarCalendrier.Value) + i ) {
                        groupBoxCalendrier.Controls[i].BackColor = Color.LightBlue;
                    } else {
                        if (int.Parse(groupBoxCalendrier.Controls[i].Text) < currentDay) {
                            groupBoxCalendrier.Controls[i].BackColor = Color.Silver;
                        } else {
                            groupBoxCalendrier.Controls[i].BackColor = Color.PaleGreen;
                        }

                    }
                }
            }
        }
        */

        private void buttonSearch_Click(object sender, EventArgs e) {
            WindowResultSearch win2 = new WindowResultSearch(this, textBoxSearch, comboBoxJourDebut, comboBoxJourFin);
            win2.Show();
            this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e) {

        }

        #endregion

    }
}
