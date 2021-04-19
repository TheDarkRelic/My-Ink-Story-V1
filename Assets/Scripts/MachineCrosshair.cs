using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineCrosshair : MonoBehaviour
{
    [SerializeField] Raycasting raycasting;
    [SerializeField] float crosshairYOffset = -0.8f;

    void Update()
    {
        var pos = raycasting.hit.point;
        transform.position = new Vector3(pos.x, pos.y, crosshairYOffset);
    }
}
