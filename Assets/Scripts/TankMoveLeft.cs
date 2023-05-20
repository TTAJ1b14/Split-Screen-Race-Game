using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class TankMoveLeft : MonoBehaviour
{
     private float speed = 10f;
    private float leftBound = -90;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x < leftBound)
        {
            Destroy(gameObject);
        }
    }
}


