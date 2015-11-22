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
    public partial class WindowResultSearch : Form {

        #region variables 

        private WindowLevel1 win1;

        #endregion

        #region accesseurs 

        public WindowLevel1 maFenetrePrec {
            get { return win1; }
            set { win1 = value; }
        }


        #endregion

        #region constructeurs

        public WindowResultSearch() {
            InitializeComponent();
        }

        public WindowResultSearch(AppliMars.WindowLevel1 w1) {
            InitializeComponent();

            maFenetrePrec = w1;

        }

        
        #endregion

        #region methodes


        #endregion

        #region evenements

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            win1.Show();
        }


        #endregion

    }
}
