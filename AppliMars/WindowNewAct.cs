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

        private void tB_descrAct_TextChanged(object sender, EventArgs e)
        {
            while (tB_descrAct.Text.Length < 4000)
            {
                tB_descrAct.ForeColor = Color.Red;
            }
        }

        private void cB_localisation_CheckedChanged(object sender, EventArgs e)
        {
            if (cB_localisation.Checked == false)
            {
                tB_xAct.Enabled = tB_yAct.Enabled = false;
                tB_xAct.BackColor = tB_yAct.BackColor = Color.LightGray;
            }
            else
            {
                tB_xAct.Enabled = tB_yAct.Enabled = true;
                tB_xAct.BackColor = tB_yAct.BackColor = Color.White;
            }

        }

        private void b_creerNvAct_Click(object sender, EventArgs e)
        {
            bool flag = true;
            while (flag == true)
            {
                // Récupération de toutes les informations
                string nomNvAct = cB_typeAct.SelectedText;
                bool extNvAct = cB_localisation.Checked;
                string descrNvAct = tB_descrAct.Text;
                if (descrNvAct.Length > 400)
                {
                    tB_descrAct.ForeColor = Color.Red;
                    flag = false;
                }
                int hDebNvAct, mDebNvAct, hFinNvAct, mFinNvAct;
                bool flagDuree = int.TryParse(tB_HDebAct.Text, out hDebNvAct);
                flagDuree = int.TryParse(tB_MDebAct.Text, out mDebNvAct);
                flagDuree = int.TryParse(tB_HFinAct.Text, out hFinNvAct);
                flagDuree = int.TryParse(tB_MFinAct.Text, out mFinNvAct);
                // Arrondir à la dizaine les minutes 
                mDebNvAct = (int)(10*Math.Round((mDebNvAct / 10)*1.0));
                mFinNvAct = (int)(10 * Math.Round((mFinNvAct / 10) * 1.0));
                
                // Vérifie que l'horaire est contenue dans la journée 
                if ((hDebNvAct == 24 && mDebNvAct >= 40) || (hFinNvAct == 24 && mFinNvAct >= 40)
                    || hDebNvAct >= 24 || hFinNvAct >= 24)
                {
                    flagDuree = false;
                }
                if (flagDuree == false)
                {
                    l_erreurConvert.Visible = true;
                    flag = false;
                }
                // Echange si les horaires de début et de fin sont inversés
                if (hDebNvAct > hFinNvAct)
                {
                    int tmp = hFinNvAct;
                    hFinNvAct = hDebNvAct;
                    hDebNvAct = tmp;
                    tmp = mFinNvAct;
                    mFinNvAct = mDebNvAct;
                    mDebNvAct = tmp;
                }
                List<Astronaute> partNvAct = new List<Astronaute>();
                foreach (string astro in lB_listePart.SelectedItems)
                {
                    var astroTrouve = from astroPresent in _jour.m.mesAstronautes where astroPresent.ToString() == astro.ToString() select astroPresent;
                    partNvAct.Add((Astronaute)astroTrouve);
                }
                int xNvAct, yNvAct;
                bool flagLoc = int.TryParse(tB_xAct.Text, out xNvAct);
                flagLoc = int.TryParse(tB_yAct.Text, out yNvAct);
                if (xNvAct < -700 || xNvAct > 395)
                    flagLoc = false;
                if (yNvAct < -1053 || yNvAct > 1000)
                    flagLoc = false;
                if (flagLoc == false)
                {
                    tB_xAct.ForeColor = tB_yAct.ForeColor = Color.Red;
                    flag = false;
                }

                // Vérification des chevauchements avec d'autres activités 
                foreach (Activite a in _jour.maListeActivites)
                {
                    if (hDebNvAct <= a.monHeureFin)
                    {
                        if (hFinNvAct >= a.monHeureDebut)
                        {
                            flag = false;
                        }
                    }
                }
                
                // Si tout est ok flag == true, on peut créer la nouvelle activité 
                _jour.maListeActivites.Add(new Activite(nomNvAct, extNvAct, descrNvAct, hDebNvAct, mDebNvAct, hFinNvAct, mFinNvAct, partNvAct, xNvAct, yNvAct));
            }
            MessageBox.Show("Impossible de créer la nouvelle activité");
        }

    }
}
