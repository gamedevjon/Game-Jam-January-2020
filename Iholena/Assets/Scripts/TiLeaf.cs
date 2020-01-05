using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiLeaf : MonoBehaviour
{
   [SerializeField]
   private float _speed;

   // Start is called before the first frame update
   void Start()
   {
      _speed = 5.0f;
   }

   // Update is called once per frame
   void Update()
   {
      if (Input.GetKeyDown(KeyCode.RightArrow))
      {
         transform.Translate(Vector3.right * _speed * Time.deltaTime);
      }

      if (Input.GetKeyDown(KeyCode.LeftArrow))
      {
         transform.Translate(Vector3.left * _speed * Time.deltaTime);

      }
   }
}
