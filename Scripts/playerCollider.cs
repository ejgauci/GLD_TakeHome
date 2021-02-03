using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollider : MonoBehaviour
{

    GameManager gm;


    void Start()
    {
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();

    }

    IEnumerator showCoin(Collider coin)
    {
        yield return new WaitForSeconds(3);
        coin.gameObject.SetActive(true);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "coin")
        {
            print("coin collected");
            other.gameObject.SetActive(false);
            gm.addCoin();
            StartCoroutine(showCoin(other));


        }
    }
}
