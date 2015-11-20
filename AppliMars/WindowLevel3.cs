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
    public partial class WindowLevel3 : Form {

        #region variables

        AppliMars.WindowLevel2 win2;

        #endregion

        #region constructeurs

        public WindowLevel3() {
            InitializeComponent();
        }

        public WindowLevel3(string numeroJour, AppliMars.WindowLevel2 w2)
            : this() {
                win2 = w2;
        }


        #endregion

        private void buttonRetourJournee_Click(object sender, EventArgs e) {
            this.Close();
            win2.Show();
        }


        #region methodes


        #endregion

        #region evenements


        #endregion

    }
}
