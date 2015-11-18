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

public class Planning
{
    public List<Journee> _tableauJournees {
        get;
        set;
    }


	public virtual string _nomPlanning
	{
		get;
		set;
	}

	public virtual void majJourJXML(int nouveauJour)
	{
		throw new System.NotImplementedException();
	}

	public Planning(string nomPlanning, List<Journee> listJournees)
	{
        // ??
	}

    // Création de l'instance Planning à partir d'un fichier XML 
    public Planning (int DureeMission, string cheminXMLPlanning)
    {
        XDocument _planningXML = XDocument.Load(cheminXMLPlanning);
        _tableauJournees = new List<Journee>();
        var jours = from jour in _planningXML.Descendants("Planning") select jour;
        foreach (XElement j in jours.Elements("Jour"))
        {
            int num = int.Parse(j.Attribute("id").Value);
            string cr = j.Element("CRJour").Value;
            _tableauJournees.Add(new Journee(num, cr, cheminXMLPlanning));
        }
    }

}

