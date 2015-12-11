using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace AppliMars {


    public class Journee {

        #region variables

        private Mission _m;
        private List<Activite> _listeActivites;
        private int _numero;
        private string _compteRendu;

        #endregion


        #region accesseurs

        public List<Activite> maListeActivites {
            get { return _listeActivites; }
            set { _listeActivites = value; }
        }

        public int monNumero {
            get { return _numero; }
            set { _numero = value; }
        }

        public string monCompteRendu {
            get { return _compteRendu; }
            set { 
                _compteRendu = value;
                // MAJ dans le XML !!
            }
        }

        public Mission maMission {
            get {return _m;}
            set { _m = value; }
        }

        #endregion


        #region constructeurs

        public Journee(int numero, string compteRendu, Mission mission) {

            string cheminPlanningXML = mission.monCheminPlanningXML;

            maListeActivites = new List<Activite>();
            monNumero = numero;
            monCompteRendu = compteRendu;

            // Récupération de la liste des activités de la journée
            XDocument _planningXML = XDocument.Load(cheminPlanningXML);

            var activites = from activite in _planningXML.Descendants("Activites")
                            where (string)activite.Parent.FirstAttribute == numero.ToString()
                            select activite;
            var elements = activites.Elements("Activite");
            int xd = elements.Count();
            IEnumerable<XElement> elements2 = activites.Descendants("Activites");
            int xd2 = elements2.Count();
            maMission = mission;

            foreach (XElement a in elements) {
                int idAct = int.Parse(a.Attribute("idAct").Value);
                string nom = a.Element("NomAct").Value;
                int hDebutAct = int.Parse(a.Element("HDebutAct").Value);
                int mDebutAct = int.Parse(a.Element("MDebutAct").Value);
                int hFinAct = int.Parse(a.Element("HFinAct").Value);
                int mFinAct = int.Parse(a.Element("MFinAct").Value);
                bool ext = bool.Parse(a.Element("BoolExt").Value);
                string description = a.Element("DescriptionAct").Value;


                List<Astronaute> astro = new List<Astronaute>();

                // récupération de la liste des participants

                // var jours = from jour in _planningXML.Descendants("Planning") select jour;
                var participants = from astronaute in _planningXML.Descendants("Astronaute")
                                   where (string)astronaute.Parent.Parent.Attribute("idAct") == idAct.ToString()
                                   select astronaute;

                int count1 = participants.Count();

                foreach (XElement p in participants)
                {
                    string nomP = p.Value.ToString();
                    // Ajout de l'astronaute dans la liste des participants à l'activité 
                    astro.Add(new Astronaute(nomP));
                }
                if (ext == true) {
                    int posX = int.Parse(a.Element("PosX").Value);
                    int posY = int.Parse(a.Element("PosY").Value);
                    maListeActivites.Add(new Activite(nom, ext, description, hDebutAct, mDebutAct, hFinAct, mFinAct, astro, posX, posY));
                } else
                     maListeActivites.Add(new Activite(nom, ext, description, hDebutAct, mDebutAct, hFinAct, mFinAct, astro));
            }
        }

        #endregion


        #region methodes



        #endregion

    }

}