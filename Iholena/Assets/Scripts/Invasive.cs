using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invasive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == null)
        {
            Debug.Log("Error, Invasive Object is null");
        }

        if (collision.tag == "Player")
        {
            //Damage Player
            Debug.Log("Player Damage Here");
        }
    }
}
