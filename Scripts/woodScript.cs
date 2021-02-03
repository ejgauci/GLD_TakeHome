using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class woodScript : MonoBehaviour
{
    private bool playerIsInWood = false;

    GameManager gm;

    public int timesHit = 0;
    menuController mc;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        
        print("wood zone");
        GameObject.Find("MenuCanvas").GetComponent<menuController>().woodMenu.gameObject.SetActive(true);
        playerIsInWood = true;
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exit Gold Zone");
        GameObject.Find("MenuCanvas").GetComponent<menuController>().woodMenu.gameObject.SetActive(false);
        playerIsInWood = false;
    }

    private void Update()
    {
        if (playerIsInWood == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Took 5 Wood");
                timesHit++;

                gm.addWood();

                

                if (timesHit >= 2)
                {
                    Destroy(this.gameObject);
                    GameObject.Find("MenuCanvas").GetComponent<menuController>().woodMenu.gameObject.SetActive(false);
                }
                
            }

        }
    }
}
