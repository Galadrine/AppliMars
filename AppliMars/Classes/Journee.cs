﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

public class Journee {

    #region variables

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
        set { _compteRendu = value; }
    }

    #endregion


    #region constructeurs 


    public Journee(int num) 
    {
        monNumero = num;
        monCompteRendu = "";
        maListeActivites = new List<Activite>();
    }

    
        public Journee(int numero, string compteRendu, string cheminPlanningXML)
        {
            maListeActivites = new List<Activite>();
            monNumero = numero;
            monCompteRendu = compteRendu;

            // Récupération de la liste des activités de la journée
            XDocument _planningXML = XDocument.Load(cheminPlanningXML);
            var activites = from activite in _planningXML.Descendants("Activites")
                            where activite.Parent.Parent.Attribute("id").ToString() == numero.ToString()
                            select activite;
            foreach (XElement a in activites.Elements("Activite"))
            {
                string nom = a.Element("NomAct").Value;
                int hDebutAct = int.Parse(a.Element("HDebutAct").Value);
                int mDebutAct = int.Parse(a.Element("MDebutAct").Value);
                int hFinAct = int.Parse(a.Element("HFinAct").Value);
                int mFinAct = int.Parse(a.Element("MFinAct").Value);
                bool ext = bool.Parse(a.Element("BoolExt").Value);
                string description = a.Element("DescriptionAct").Value;

                List<Astronaute> astro = new List<Astronaute>();

                // Récupération de la liste des participants
                //var participants = from astronaute in _planningXML.Descendants("Participants")
                //                   where  
                //foreach (XElement p in)
                if (ext == true)
                {
                    int posX = int.Parse(a.Element("PosX").Value);
                    int posY = int.Parse(a.Element("PosY").Value);
                    maListeActivites.Add(new Activite(nom, ext, description, hDebutAct, mDebutAct, hFinAct, mFinAct, astro, posX, posY));
                }
                else
                maListeActivites.Add(new Activite(nom, ext, description, hDebutAct, mDebutAct, hFinAct, mFinAct, astro));
            }
     
        }



    #endregion

}

