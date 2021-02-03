using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class electricityScript : MonoBehaviour
{
    private bool playerIsInElectricity = false;
    GameManager gm;
    public bool turbineActive = false;

    [SerializeField] private Animator myAnimationController;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        print("electricity zone");

        if (turbineActive == false)
        {
            GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStart.gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStop.gameObject.SetActive(true);
        }
        
        playerIsInElectricity = true;
    }

    private void OnTriggerExit(Collider other)
    {
        print("Exit electricity Zone");

        
            GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStart.gameObject.SetActive(false);
        
            GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStop.gameObject.SetActive(false);

        playerIsInElectricity = false;
    }

    private void Update()
    {
        if (playerIsInElectricity == true)
        {

            if (Input.GetKeyDown(KeyCode.E))
            {


                if (turbineActive == false)
                {
                    turbineActive = true;
                    print("tubine started");
                    gm.StartCoroutine("startTurbine");

                    GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStart.gameObject.SetActive(false);
                    GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStop.gameObject.SetActive(true);

                    myAnimationController.SetBool("playSpin", true);
                }
                else
                {
                    turbineActive = false;
                    print("turbine stopped");
                    gm.stopTurbine();

                    GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStop.gameObject.SetActive(false);
                    GameObject.Find("MenuCanvas").GetComponent<menuController>().electricityMenuStart.gameObject.SetActive(true);

                    myAnimationController.SetBool("playSpin", false);
                }






            }

        }   
    }
}
