using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int points = 0;
    public int health = 3;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI timeText;
  


    private void OnTriggerEnter2D(Collider2D collision)
    {


       if (collision.name.Contains("PickUp"))
        {
            Destroy(collision.gameObject);
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

    void Update()
    {
         if (health == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        }

    }
}
