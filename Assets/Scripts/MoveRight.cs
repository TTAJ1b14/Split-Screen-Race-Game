using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    private float speed = 25f;
    private float rightBound = 90;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x > rightBound)
        {
            Destroy(gameObject);
        }
    }
}
