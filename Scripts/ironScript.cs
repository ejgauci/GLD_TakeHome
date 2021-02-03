using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ironScript : MonoBehaviour
{
    private bool playerIsInIron = false;
    GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        print("iron zone");
        GameObject.Find("MenuCanvas").GetComponent<menuController>().ironMenu.gameObject.SetActive(true);
        playerIsInIron = true;
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exit iron Zone");
        GameObject.Find("MenuCanvas").GetComponent<menuController>().ironMenu.gameObject.SetActive(false);
        playerIsInIron = false;
    }
    
    private void Update()
    {
        if (playerIsInIron == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Took 10 iron");

                gm.addIron();

                //GameObject.Find("MenuCanvas").GetComponent<menuController>().ironMenu.gameObject.SetActive(false);

               

            }

        }
    }
}
