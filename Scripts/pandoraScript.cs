using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pandoraScript : MonoBehaviour
{
    private bool playerIsInPandora = false;
    GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        print("pandora zone");
        GameObject.Find("MenuCanvas").GetComponent<menuController>().pandoraMenu.gameObject.SetActive(true);
        playerIsInPandora = true;
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exit pandora Zone");
        GameObject.Find("MenuCanvas").GetComponent<menuController>().pandoraMenu.gameObject.SetActive(false);
        playerIsInPandora = false;
    }

    private void Update()
    {
        if (playerIsInPandora == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {
                print("Took 10 iron");

                gm.openPandora();


            }

        }
        else
        {
            GameObject.Find("MenuCanvas").GetComponent<menuController>().pandoraMenu.gameObject.SetActive(false);
        }
    }

}
