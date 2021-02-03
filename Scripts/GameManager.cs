using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int coins=0;
    public Text coinsText;

    public int electricity=0;
    public Text electricityText;

    public int iron=0;
    public Text ironText;

    public int wood = 0;
    public Text woodText;

    public int health =100;
    public Text healthText;

    public GameObject pandoraBox;



    // Start is called before the first frame update
    void Start()
    {
        pandoraBox.gameObject.SetActive(false);
        StartCoroutine("DecreaseHealth");
    }

   

    IEnumerator DecreaseHealth()
    {
        while (true)
        {
            health--;
            healthText.text = "HEALTH:" + health;

            yield return new WaitForSeconds(1);
        }
        

    }
   
    public void addWood()
    {
        print("Took 5 Wood -GM");
        wood += 5;
        woodText.text = "WOOD:" + wood;
    }

    public void addIron()
    {
        print("Took 10 iron -GM");
        iron += 10;

        ironText.text = "IRON:" + iron;
    }

   public void stopTurbine()
    {
        StopCoroutine("startTurbine");
    }

    IEnumerator startTurbine()
    {
        while (true)
        {
            electricity +=1;
            electricityText.text = "ELECTRICITY:" + electricity;

            yield return new WaitForSeconds(2);
        }
    }

    public void spawnPandora()
    {
        electricity -= 3;
        electricityText.text = "ELECTRICITY:" + electricity;
        wood -= 10;
        woodText.text = "WOOD:" + wood;
        iron -= 5;
        ironText.text = "IRON:" + iron;

        pandoraBox.gameObject.SetActive(true);
    }

    public void openPandora()
    {
        int randomHealth = Random.Range(0, 10);

        health += randomHealth;
        pandoraBox.gameObject.SetActive(false);
        GameObject.Find("MenuCanvas").GetComponent<menuController>().pandoraMenu.gameObject.SetActive(false);
    }

    public void addCoin()
    {
        coins++;
        coinsText.text = "COINS:" + coins;
    }

    public void hitByCar()
    {
        health = 0;
    }


    private void Update()
    {
        if (health <= 0)
        {
            print("death scene");

            SceneManager.LoadScene(1);
        }
    }

    

}
