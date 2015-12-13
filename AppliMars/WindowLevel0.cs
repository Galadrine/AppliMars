using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliMars {
    public partial class WindowLevel0 : Form {

        #region variables

        private List<Mission> _mesMissions = new List<Mission>();
        private Mission missionSlectionnee = null;

        #endregion


        #region accesseurs

        public List<Mission> maListeMissions {
            get { return _mesMissions; }
            set { _mesMissions = value; }
        }

        public Mission maMissionSelectionnee {
            get { return missionSlectionnee; }
            set { missionSlectionnee = value; }
        }
        

        #endregion


        #region constructeurs

        public WindowLevel0() {
            InitializeComponent();
            refreshListBox();
        }

        #endregion


        #region méthodes

        public void refreshListBox() {
            string defautMissionsDir = "..//..//Missions//";

            DirectoryInfo dInfo = new DirectoryInfo(defautMissionsDir);
            DirectoryInfo[] subdirs = dInfo.GetDirectories();

            string stringListBox;

            foreach (DirectoryInfo A in subdirs) {

                stringListBox = A.Name;
                listBoxMissions.Items.Add(stringListBox);
                maListeMissions.Add(new Mission(defautMissionsDir + A.Name + "//General.xml"));

            }
            if (subdirs.Length>0) {
                listBoxMissions.SetSelected(0, true);
            }
 

        }

        #endregion


        #region évènements

        private void buttonChargementMission_Click(object sender, EventArgs e) {
            if (missionSlectionnee != null) {
                WindowLevel1 win1 = new WindowLevel1(maMissionSelectionnee, this);
                win1.Show();
                this.Hide();
            }
        }

        private void buttonNouvelleMission_Click(object sender, EventArgs e) {
            WindowNewMission win = new WindowNewMission(this);
            win.Show();
            this.Hide();
        }

        private void listBoxMissions_SelectedIndexChanged(object sender, EventArgs e) {

            int sel = Int32.Parse(listBoxMissions.GetItemText(listBoxMissions.SelectedIndex));
            if (sel >= 0) {
                maMissionSelectionnee = maListeMissions[sel];
            }
        }

        #endregion



    }
}
