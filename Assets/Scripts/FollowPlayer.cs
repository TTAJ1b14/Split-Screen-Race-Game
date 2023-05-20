using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeField] Vector3 offset = new Vector3 (0,5,-10);

    void LateUpdate() // For Camera calculations
    {
        // offset the camera behind the player
        transform.position = player.transform.position + offset;
    }
}
