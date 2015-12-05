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
    public partial class WindowLevel0 : Form {

        #region variables

        private List<Mission> _mesMissions;

        #endregion


        #region accesseurs


        public List<Mission> maListeMissions {
            get { return _mesMissions; }
            set { _mesMissions = value; }
        }



        #endregion


        #region constructeurs

        public WindowLevel0() {
            InitializeComponent();


            DateTime deb = new DateTime(2015, 11, 12, 00, 01, 00);
            List<string> list = new List<string>();
            Mission _mission = new Mission("MaMission", deb, 500, list);

            maListeMissions.Add(_mission);
        }

        #endregion


        #region évènements

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void buttonModifier_Click(object sender, EventArgs e) {

        }

        private void buttonCharger_Click(object sender, EventArgs e) {



        }

        private void buttonCreer_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

    }
}
