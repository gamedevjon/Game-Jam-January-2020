using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Native : MonoBehaviour
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
            Debug.Log("Error, Native Object is null");
        }

        if (collision.tag == "Player")
        {
            //Damage Player
            Debug.Log("Player Score Here");
        }
    }
}
