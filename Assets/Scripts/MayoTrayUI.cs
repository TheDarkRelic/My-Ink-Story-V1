using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MayoTrayUI : MonoBehaviour
{
    [SerializeField] Transform trayIn, trayOut, machineIdol;
    [SerializeField] Canvas trayCanvas;
    [SerializeField] GameObject machineObject;
    [SerializeField] Machine machine;
    [SerializeField] MachineCrosshair machineCrosshair;
    [SerializeField] Raycasting raycasting;
    bool trayIsOut;

    private void Awake()
    {
        trayIsOut = false;
    }

    public void PutAwayTray()
    {
        trayIsOut = false;
        ToggleRaycast(true);
        machineCrosshair.ToggleCursor(true);
        Cursor.visible = false;
        machine.enabled = true;
        trayCanvas.enabled = false;
        transform.DOMoveY(trayIn.position.y, .5f);
    }

    public void PullOutTray()
    {
        trayIsOut = true;
        ToggleRaycast(false);
        machineCrosshair.ToggleCursor(false);
        Cursor.visible = true;
        machine.enabled = false;
        machineObject.transform.DOMove(machineIdol.position, .5f);
        Invoke(nameof(EnableCanvas), .5f);
        transform.DOMoveY(trayOut.position.y, .5f);
    }

    public void ToggleRaycast(bool isActive)
    {
        raycasting.enabled = isActive;
    }

    public void ToggleTray()
    {
        if (!trayIsOut) { PullOutTray(); }
        else if (trayIsOut) { PutAwayTray(); }
    }

    void EnableCanvas()
    {
        trayCanvas.enabled = true;
    }
}
