using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinsScript : MonoBehaviour
{
    
    GameManager gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {

        print("coin collected");
        gm.addCoin();
        StartCoroutine("collectCoin");
        gameObject.SetActive(false);

    }

    IEnumerator collectCoin()
    {
        
            yield return new WaitForSeconds(3);
            gameObject.SetActive(true);
        
       
    }





}
