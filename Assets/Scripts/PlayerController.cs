using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // private variables
    [SerializeField] float speed;
    [SerializeField] float horsePower = 0;
    [SerializeField] float rpm;
    [SerializeField] float turnSpeed = 45.0f;

    [SerializeField] float horizontalInput;
    [SerializeField] float forwardInput;

    [SerializeField] GameObject centerofMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI revolutionsPerMinuteText;

    private Rigidbody playerRb;
    
    // keep track of all wheels
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;



    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerofMass.transform.localPosition; // Setting Player's CenterOfMass to the location of

    }
    void FixedUpdate() // For physics Calculations
    {
        // This is where we get players input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Moves the car forward based on vertical input
        // transform.Translate(Vector3.forward * Time.deltaTime * speed *forwardInput);
        // Rotates the car based on horizontal input
        // transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed *  horizontalInput);
        if (IsOnGround())
        {
            playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

            // Calculate speed in Km H
            //Mathf.RoundToInt - rounds to closest integer
            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 3.6f); // 3.6 - KMH, 2.237 - MPH
                                                                          // Set TMPro text to display speed
            speedometerText.SetText("Speed: " + speed + " Km/H");

            // % - дает остаток
            rpm = (speed % 30) * 40;
            revolutionsPerMinuteText.SetText("RPM: " + rpm);
        }
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        // checks condition for each wheel in the list. if true for each one wheel adds 1
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
