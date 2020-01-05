using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiLeaf : MonoBehaviour
{
   [SerializeField]
   private float _speed;
   private float _rightLimit = 9.6f;
   private float _leftLimit = -9.66f;

   // Start is called before the first frame update
   void Start()
   {
      _speed = 5.0f;
   }

   // Update is called once per frame
   void Update()
   {
      float horizontalPos;
      float verticalPos = -4.5f;
      Vector3 newPosition;

      if (Input.GetKey(KeyCode.RightArrow))
      {
         if (transform.position.x >= _rightLimit)
         {
            newPosition = new Vector3(_leftLimit, verticalPos, 0);
            transform.position = newPosition;
         }
         transform.Translate(Vector3.right * _speed * Time.deltaTime);
      }

      if (Input.GetKey(KeyCode.LeftArrow))
      {
         if (transform.position.x <= _leftLimit)
         {
            newPosition = new Vector3(_rightLimit, verticalPos, 0);
            transform.position = newPosition;
         }
         transform.Translate(Vector3.left * _speed * Time.deltaTime);
      }
   }
}
