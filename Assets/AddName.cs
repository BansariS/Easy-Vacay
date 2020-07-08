using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AddName : MonoBehaviour
{
    public static HashSet<string> listnames = new HashSet<string>();
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("hello");
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void buttonOnClick()
    {
        Debug.Log("This button was clicked");
        // Debug.Log("Name: "+EventSystem.current.currentSelectedGameObject.name);
        listnames.Add(EventSystem.current.currentSelectedGameObject.name);     
    }
    

    public static List<string> ListStrings()
    {
        // string finalString = "";
        List<string> finalnames = new List<string>();
        foreach (string s in listnames)
        {
            finalnames.Add(s);
            Debug.Log(s);

        }
        Debug.Log(finalnames);
        return finalnames;
    }
}
