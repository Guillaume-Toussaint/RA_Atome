using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text;
using System.Xml;
using System;

public class AtomDataLoader : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   /* public static AtomData loadData(string nomAtome){//nomAtome est le nom récupéré depuis le code QR de l'atome
            XmlReader xmlReader = XmlReader.Create("/TextData/atomes.xml");
            while(xmlReader.Read())
            {
                if((xmlReader.NodeType == XmlNodeType.Element) && (xmlReader.Name == "atome"))
                {
                    if(xmlReader.HasAttributes)
                        if(xmlReader.GetAttribute("nom") == nomAtome){
                            //C'est l'atom dont on récupère les infos
                            return new AtomData(xmlReader.GetAttribute("nom"),Convert.ToDouble(xmlReader.GetAttribute("masse")),xmlReader.GetAttribute("location"));
                        }
                        //Console.WriteLine(xmlReader.GetAttribute("currency") + ": " + xmlReader.GetAttribute("rate"));                    
                }

        }
        return null;


}*/

}
