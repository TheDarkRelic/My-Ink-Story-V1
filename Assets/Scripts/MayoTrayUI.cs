using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class MayoTrayUI : MonoBehaviour
{
    [SerializeField] Transform trayIn = null, trayOut = null, machineIdol = null;
    [SerializeField] Canvas trayCanvas = null;
    [SerializeField] GameObject machineObject = null;
    [SerializeField] Machine machine = null;
    [SerializeField] MachineCrosshair machineCrosshair = null;
    [SerializeField] Raycasting raycasting = null;
    bool trayIsOut;
    SceneHandler playable;
    [SerializeField] GameObject trayButton = null;

    private void Awake()
    {
        trayIsOut = false;
        playable = SceneHandler.Instance;
    }

    public void PutAwayTray()
    {
        playable.playable = true;
        trayIsOut = false;
        ToggleRaycast(true);
        machineCrosshair.ToggleCursor(true);
        Cursor.visible = false;
        machine.enabled = true;
        trayCanvas.enabled = false;
        if (transform != null) { transform.DOMoveY(trayIn.position.y, .5f); }
    }

    public void PullOutTray()
    {
        trayButton.SetActive(true);
        playable.playable = false;
        trayIsOut = true;
        ToggleRaycast(false);
        machineCrosshair.ToggleCursor(false);
        Cursor.visible = true;
        machine.enabled = false;
        machineObject.transform.DOMove(machineIdol.position, .5f);
        Invoke(nameof(EnableCanvas), .5f);
        if (transform != null) { transform.DOMoveY(trayOut.position.y, .5f); }
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
