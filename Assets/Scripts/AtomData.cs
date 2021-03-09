using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtomData{
    public string nom;
    public double masse;
    public string localisation;

    public AtomData(string n, double m, string loc){
        this.nom = n;
        this.masse = m;
        this.localisation = loc;
    }


}