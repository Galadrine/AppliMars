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
                    string nomLieu = a.Descendants("Lieu").Elements("nomLieu").First().Value;
                    int posX = int.Parse(a.Descendants("Lieu").Elements("posX").First().Value);
                    int posY = int.Parse(a.Descendants("Lieu").Elements("posY").First().Value);
                    maListeActivites.Add(new Activite(nom, ext, description, hDebutAct, mDebutAct, hFinAct, mFinAct, astro, nomLieu, posX, posY, idAct));
                } else
                    maListeActivites.Add(new Activite(nom, ext, description, hDebutAct, mDebutAct, hFinAct, mFinAct, astro, idAct));
            }
        }

        #endregion


        #region méthodes

        public int getPosActiviteByIdAct(int id) {
            int pos = 0;
            foreach (Activite acti in maListeActivites) {
                if (acti.monID == id) {
                    return pos;
                }
                pos++;
            }
            return pos;
        }

        public bool checkJourneeExterieur() {
            bool toReturn = false;
            foreach (Activite act in maListeActivites) {
                if (act.enExterieur == true) {
                    return true;
                }
            }
            return toReturn;
        }

        /// <summary>
        /// Si hAComparer:mAComparer est inférieur à h:m on revoie -1
        /// Si hAComparer:mAComparer est égal à h:m on revoie 0
        /// Si hAComparer:mAComparer est supérieur à h:m on revoie 1
        /// </summary>
        public int compareHours(int dureeAComparer, int duree) {
            if (dureeAComparer<duree) {
                return -1;
            } else if (dureeAComparer == duree) {
                return 0;
            } else {
                return 1;
            }
        }

        public string checkChevauchement(int hDeb, int mDeb, int hFin, int mFin) {
            string toReturn = "";
            foreach (Activite act in maListeActivites) {
                int 
                    h1 = act.monHeureDebut * 60 + act.mesMinutesDebut,
                    h2 = act.monHeureFin * 60 + act.mesMinutesFin,
                    h3 = hDeb * 60 + mDeb,
                    h4 = hFin * 60 + mFin;
                int result1 = compareHours(h1, h3);
                int result2 = compareHours(h1, h4);
                int result3 = compareHours(h2, h3);
                int result4 = compareHours(h2, h4);

                if (result1 < 0 && result3 > 0 && result2 < 0 && result4 > 0) {
                    return "L'activité à insérer est comprise entre les horaires de l'activité '" + act.monNom + "' de ce jour. Veuillez modifier les horaires de l'activité ou supprimer l'activité sur laquelle elle chevauche.";
                } else {
                    if (result1 < 0 && result3 > 0) {
                        return "Le début de l'activité à insérer chevauche l'activité '" + act.monNom + "' de ce jour. Veuillez modifier les horaires de l'activité ou supprimer l'activité sur laquelle elle chevauche.";
                    }
                    if (result2 < 0 && result4 > 0) {
                        return "Laf in de l'activité à insérer chevauche l'activité '" + act.monNom + "' de ce jour. Veuillez modifier les horaires de l'activité ou supprimer l'activité sur laquelle elle chevauche.";
                    }
                }
            }


            return toReturn;
        }

        #endregion

    }

}