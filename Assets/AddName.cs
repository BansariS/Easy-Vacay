using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddName : MonoBehaviour
{
    public static HashSet<string> listnames = new HashSet<string>();
    public void buttonOnClick()
    {
        listnames.Add(EventSystem.current.currentSelectedGameObject.name);     
    }
    

    public static List<string> ListStrings()
    {
       
        List<string> finalnames = new List<string>();
        foreach (string s in listnames)
        {
            finalnames.Add(s);
        }
        return finalnames;
    }
}
