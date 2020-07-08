using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;


public class LoadScene : MonoBehaviour
{
    public Transform[] obj;
    public Transform[] dataobj;
    public TextMeshProUGUI tnames;
    public TextMeshProUGUI tdnames;
    public  string notification;

    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }
     void Start()
    {
        DontDestroyOnLoad(transform.gameObject);
        SceneManager.sceneLoaded += OnSceneLoaded;
    }
     public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "SELECT_DAYS")
        {
            string titlename;
            int notificationcount;
            titlename = Namescript.titleStringName();

            GameObject Expandedworldgameobject = GameObject.FindGameObjectWithTag("expand");
            
            obj = Expandedworldgameobject.GetComponentsInChildren<Transform>(true);
            List<GameObject> datalogsname = new List<GameObject>();
            List<GameObject> descriptions = new List<GameObject>();

            List<string> fnames = new List<string>();
            fnames = AddName.ListStrings();
            notificationcount =fnames.Count; 
             

            foreach (var ob in obj)
            {
                if (ob.gameObject.tag == "datalogtitle")
                {
                    tnames = ob.GetComponent<TextMeshProUGUI>();
                    tnames.text = titlename;
                }

                if (ob.gameObject.tag == "notification")
                {
                    tnames = ob.GetComponent<TextMeshProUGUI>();
                    notification = notificationcount.ToString();
                    tnames.text = notification;
                    
                }


                if (ob.gameObject.tag == "datalog")
                {
                    datalogsname.Add(ob.transform.gameObject);

                }

                if(ob.gameObject.tag == "description"){
                    descriptions.Add(ob.transform.gameObject);
                }
            }
           

            for (int i = 0; i < fnames.Count; i++)
            {

                tnames = datalogsname[i].GetComponent<TextMeshProUGUI>();
                tnames.text = fnames[i];

                tdnames = descriptions[i].GetComponent<TextMeshProUGUI>();

                if (tnames.text == "San Francisco")
                {
                    tdnames.text = " In one day the Golden  Gate, Painted Ladies, Union square and Cabel Car ride can be experienced. If you have more than one day then explore Lombard Street,Palace of Fine Arts, Pier 39, Cupid's Span and Alcatras Island,too.";
                }
                else if (tnames.text == "Los Angeles")
                {
                    tdnames.text = " You should not miss the amazing destinations like Hollywood walk of fame, TCL Chinese Theatre, Hollywood Sign, Griffith Observatory and Pershing Square in Los Angeles. ";

                }
                else if (tnames.text == "17 Mile Drive")
                {
                    tdnames.text = " 17-Mile Drive is a scenic road through Pebble Beach and Pacific Grove on the Monterey Peninsula in California, much of which hugs the Pacific coastline and passes famous golf courses, mansions and scenic attractions, including the Bird Rock and the 5,300-acre Del Monte Forest of Monterey Cypress trees. ";

                }
                else if (tnames.text == "Monterey")
                {
                    tdnames.text = " Explore the beauty of amazing views at Pebble Beach and Lone Cypress. Don't miss the sunset at Carmel by Sea, white sandy beach backed by a trail & cypress trees popular for dog walking, volleyball & surfing. ";

                }
                else if (tnames.text == "Naples Reef")
                {
                    tdnames.text = "Naples Reef is a fringing reef located off the Gaviota Coast of Santa Barbara County, California. It is an underwater pinnacle and cave system that is a popular scuba diving and fishing area. ";

                }
                else if (tnames.text == "SkyDive California")
                {
                    tdnames.text = "Skydive California is home to some of the top talents in the skydiving world. This skydiving facility is conveniently located in Northern California near the Bay Area. So pack up a picnic and witness the incredible experience. ";

                }

                else
                {
                    tdnames.text = " Explore this place for fun! ";
                }

               }


            }
               

            

            }
               




        }



