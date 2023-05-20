using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private Camera firstPersonCamera;
    [SerializeField] private Camera thirdPersonCamera;
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
    }
}
