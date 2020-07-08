using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Namescript : MonoBehaviour
{
     public static string dayname;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void OnClicked(Button button)
    {
        Debug.Log("button's name  is" + button.name);
        dayname = button.name;

    }
     public static string titleStringName()
    {
        Debug.Log("button's string  is" + dayname);
        return dayname;

    }
}
