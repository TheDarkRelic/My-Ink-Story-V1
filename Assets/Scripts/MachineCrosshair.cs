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

    public void ToggleCursor(bool isActive)
    {
        var spriterenderers = GetComponentsInChildren<SpriteRenderer>();
        foreach (var cursorSprite in spriterenderers)
        {
            if (cursorSprite.enabled)
            {
                cursorSprite.enabled = isActive;
            }
            else
            {
                cursorSprite.enabled = isActive;
            }
        }
    }
}
