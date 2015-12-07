using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace AppliMars {

    public class Planning {

        #region variables

        private Mission _m;
        private List<Journee> _tableauJournees;
        private string _nomPlanning;

        #endregion


        #region accesseurs

        public List<Journee> monTableauJournees {
            get { return _tableauJournees; }
            set { _tableauJournees = value; }
        }

        public string monNomPlanning {
            get { return _nomPlanning; }
            set { _nomPlanning = value; }
        }

        public Mission m
        {
            get { return _m;}
            set { _m = value; }
        }
        #endregion


        #region constructeurs

        // Création de l'instance Planning à partir d'un fichier XML 
        public Planning(Mission mission) {

            string cheminXMLPlanning = mission.monCheminPlanningXML;

            m = mission;
            XDocument _planningXML = XDocument.Load(cheminXMLPlanning);
            monTableauJournees = new List<Journee>();
            var jours = from jour in _planningXML.Descendants("Planning") select jour;
            foreach (XElement j in jours.Elements("Jour")) {
                int num = int.Parse(j.Attribute("id").Value);
                string cr = j.Element("CRJour").Value;
                _tableauJournees.Add(new Journee(num, cr, m));
            }
        }

        #endregion

    }

}