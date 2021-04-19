using UnityEngine;
using DG.Tweening;

public class MayoTrayUI : MonoBehaviour
{
    [SerializeField] Transform trayIn, trayOut, machineIdol;
    [SerializeField] Canvas trayCanvas;
    [SerializeField] GameObject machineObject;
    [SerializeField] Machine machine;
    [SerializeField] MachineCrosshair machineCrosshair;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.T)) { return; }
        if (transform.position != trayOut.position)
        {
            PullOutTray();
        }
        else
        {
            PutAwayTray();
        }

    }

    private void PutAwayTray()
    {
        machineCrosshair.ToggleCursor(true);
        Cursor.visible = false;
        machine.enabled = true;
        trayCanvas.enabled = false;
        transform.DOMoveY(trayIn.position.y, .5f);
    }

    public void PullOutTray()
    {
        machineCrosshair.ToggleCursor(false);
        Cursor.visible = true;
        machine.enabled = false;
        machineObject.transform.DOMove(machineIdol.position, .5f);
        Invoke(nameof(EnableCanvas), .5f);
        transform.DOMoveY(trayOut.position.y, .5f);
    }

    void EnableCanvas()
    {
        trayCanvas.enabled = true;
    }
}
