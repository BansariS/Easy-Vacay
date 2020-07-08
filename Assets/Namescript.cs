using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Namescript : MonoBehaviour
{
     public static string dayname;
     public void OnClicked(Button button)
    {
        dayname = button.name;

    }
     public static string titleStringName()
    {
       return dayname;

    }
}
