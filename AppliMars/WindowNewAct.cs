using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliMars
{
    public partial class WindowNewAct : Form
    {
        #region Variables
        private Journee _jour;


        #endregion

        public WindowNewAct()
        {
            InitializeComponent();
        }

        public WindowNewAct(Journee jour)
        {
            InitializeComponent();
            _jour = jour;

            l_numJour.Text = _jour.monNumero.ToString();
            cB_cate.DataSource = _jour.m.maListeCategories;
            // cB_typeAct dépendant de cB_cate
            lB_listePart.DataSource = _jour.m.mesAstronautes;
            if (cB_localisation.Checked == false)
            {
                tB_xAct.Text = "0";
                tB_yAct.Text = "0";
                tB_xAct.ReadOnly = true;
                tB_yAct.ReadOnly = true;
            }
        }

        private void cB_cate_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TYPE ACT en fonction de CATEGORIE

            //Categorie cateSelected = from cate in _jour.m.maListeCategories where cate.ToString() == cB_cate.SelectedItem select cate;
            //cB_typeAct.DataSource = cateSelected.maListe;
        }
    }
}
