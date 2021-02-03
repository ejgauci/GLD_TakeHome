using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menuController : MonoBehaviour
{

    public Text woodMenu;
    public Text ironMenu;
    public Text electricityMenuStart;
    public Text electricityMenuStop;
    public Text factoryMenu;
    public Text factoryMenuNot;
    public Text factoryMenuActive;
    public Text pandoraMenu;

    // Start is called before the first frame update
    void Start()
    {
        woodMenu.gameObject.SetActive(false);
        ironMenu.gameObject.SetActive(false);
        electricityMenuStart.gameObject.SetActive(false);
        electricityMenuStop.gameObject.SetActive(false);
        factoryMenu.gameObject.SetActive(false);
        factoryMenuNot.gameObject.SetActive(false);
        factoryMenuActive.gameObject.SetActive(false);
        pandoraMenu.gameObject.SetActive(false);

    }

    
}
