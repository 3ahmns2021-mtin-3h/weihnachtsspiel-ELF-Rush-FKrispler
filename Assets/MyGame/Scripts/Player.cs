using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    int countCollisions = 0;

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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
