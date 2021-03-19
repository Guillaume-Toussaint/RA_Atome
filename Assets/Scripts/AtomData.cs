using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AtomData : MonoBehaviour{
    public string nom;
    public int num;
    public double masse;
    public string localisation;

    /* // Constructeur qui sera utilisé dans une version future
    public AtomData(string n, double m, string loc){
        this.nom = n;
        this.masse = m;
        this.localisation = loc;
    }*/

    void Start(){

        TextMesh  obj = (TextMesh ) this.transform.GetChild(1).gameObject.GetComponent<TextMesh >();
        obj.text = this.nom;
        obj = (TextMesh ) this.transform.GetChild(2).gameObject.GetComponent<TextMesh >();
        obj.text = "numéro : "+this.num+"\n masse : "+this.masse+"u";
        
        obj = (TextMesh ) this.transform.GetChild(3).gameObject.GetComponent<TextMesh >();
        obj.text = this.localisation.Replace("\\n","\n");

    }

    void Update(){

    }


}