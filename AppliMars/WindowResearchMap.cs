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
    public partial class WindowResearchMap : Form {

        #region variables

        private WindowLevel1 _win1;

        #endregion


        #region accesseurs

        public WindowLevel1 maFenetrePrec {
            get { return _win1; }
            set { _win1 = value; }
        }

        #endregion


        #region constructeurs

        public WindowResearchMap() {
            InitializeComponent();
        }

        public WindowResearchMap(WindowLevel1 w1)
            : this() {
            maFenetrePrec = w1;

            for (int i = 0; i < maFenetrePrec.maMission.maDureeMission + 1; i++) {
                // comboBoxJourDebut.Items.Add(_mission._planning._tableauJournees[i]);
                cB_JourDebut.Items.Add(i);
                cB_JourFin.Items.Add(i);
            }

            cB_JourDebut.SelectedIndex = 1;
            cB_JourFin.SelectedIndex = maFenetrePrec.maMission.maDureeMission - 1;
        }

        #endregion


        #region évènements

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
        }

        #endregion

    }
}
