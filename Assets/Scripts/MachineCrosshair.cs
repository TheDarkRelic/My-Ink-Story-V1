using UnityEngine;

public class MachineCrosshair : MonoBehaviour
{
    [SerializeField] float crosshairYOffset = -0.8f;
    [SerializeField] Machine machine = null;

    void Update()
    {
        transform.position = machine.transform.position;
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
