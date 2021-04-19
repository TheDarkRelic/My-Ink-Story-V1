using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    [SerializeField] Camera zoomCamera;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            zoomCamera.gameObject.SetActive(true);
        }
        else
        {
            zoomCamera.gameObject.SetActive(false);
        }
    }
}
