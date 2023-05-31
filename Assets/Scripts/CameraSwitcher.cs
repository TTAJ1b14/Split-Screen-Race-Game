using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private Camera firstPersonCamera;
    [SerializeField] private Camera firstPersonCameraPlayer2;
    [SerializeField] private Camera thirdPersonCamera;
    [SerializeField] private Camera thirdPersonCameraPlayer2;
    bool mainCameraActive = true;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            mainCameraActive = !mainCameraActive;

            if (!mainCameraActive)
            {
                firstPersonCamera.gameObject.SetActive(true);
                thirdPersonCamera.gameObject.SetActive(false);
                Debug.Log("First Person Camera activated");
            }
            else if (mainCameraActive)
            {
                thirdPersonCamera.gameObject.SetActive(true);
                firstPersonCamera.gameObject.SetActive(false);
                Debug.Log("Third Person Camera activated");
            }
        }

         if (Input.GetKeyDown(KeyCode.B))
        {
            mainCameraActive = !mainCameraActive;

            if (!mainCameraActive)
            {
                firstPersonCameraPlayer2.gameObject.SetActive(true);
                thirdPersonCameraPlayer2.gameObject.SetActive(false);
                Debug.Log("Player 2 First Person Camera activated");
            }
            else if (mainCameraActive)
            {
                thirdPersonCameraPlayer2.gameObject.SetActive(true);
                firstPersonCameraPlayer2.gameObject.SetActive(false);
                Debug.Log("Player 2 Third Person Camera activated");
            }
        }
    }
}
