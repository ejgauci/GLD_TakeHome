using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class factoryScript : MonoBehaviour
{
    GameManager gm;
    private bool playerIsInFactory = false;
    public bool pandoraActive = false;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void setActive(bool pA)
    {
        pandoraActive = pA;
    }
   

    private void OnTriggerEnter(Collider other)
    {

        print("factory zone");

        if ((gm.electricity >= 3) && (gm.wood >= 10) && (gm.iron >= 5))
        {
            GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenu.gameObject.SetActive(true);
        }
        else if(pandoraActive==true){
            GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenuActive.gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenuNot.gameObject.SetActive(true);
        }

        
        playerIsInFactory = true;
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exit factory Zone");
        GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenu.gameObject.SetActive(false);
        GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenuActive.gameObject.SetActive(false);
        GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenuNot.gameObject.SetActive(false);
        playerIsInFactory = false;
    }

    private void Update()
    {
       

        if (playerIsInFactory == true)
        {
            if ((gm.electricity >= 3) && (gm.wood >= 10) && (gm.iron >= 5) && (pandoraActive == false))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    print("created pandora box");
                    pandoraActive = true;
                    gm.spawnPandora();

                    GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenu.gameObject.SetActive(false);
                    GameObject.Find("MenuCanvas").GetComponent<menuController>().factoryMenuActive.gameObject.SetActive(true);

                }
            }
            

        }
    }
}
