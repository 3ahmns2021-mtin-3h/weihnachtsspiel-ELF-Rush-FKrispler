using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    int countCollisions = 0;
    public bool collideTroll = false;
    public int points = 0;
    public int health = 3;
    public GameObject elfObjekt;
    public GameObject snowmanObjekt;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI timeText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "DamageItem")
        {
            countCollisions--;
    
        }

        else if (collision.name == "PickUp")
        {
            countCollisions++;
        }

        else if (collision.name.Contains("PickUp"))
        {
            Destroy(collision.gameObject);
            collideTroll = true;
            points++;
            scoreDisplay.text = points.ToString();
        }

        else if (collision.name.Contains("DamageItem"))
        {
            health--;
            healthDisplay.text = health.ToString();
            Destroy(collision.gameObject);
        }

    }

    // Update is called once per frame
    void Update()
    {
         if (health == 0)
        {
            gameOverText.text = "GAME OVER";
            elfObjekt.SetActive(false);
            snowmanObjekt.SetActive(false);
            timeText.enabled = false;
        }
    }
}
