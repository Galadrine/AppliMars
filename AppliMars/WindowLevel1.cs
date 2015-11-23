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
            /*
            comboBox1.Items.Add(new Item("Student 1", 1));
            comboBox1.Items.Add(new Item("Student 2", 2));
            comboBox1.Items.Add(new Item("Student 3", 3));
            */
        }

        public WindowLevel1(int i) {
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
            WindowResultSearch win2 = new WindowResultSearch(this);
            win2.Show();
            this.Hide();
        }


        private void timer1_Tick(object sender, EventArgs e) {

        }

        #endregion

    }
}
