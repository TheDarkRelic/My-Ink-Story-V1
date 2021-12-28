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
    PlayerActions _actions;

    private void Awake()
    {
        _actions = new PlayerActions();
        _actions.TattooControls.Tray.performed += cntxt => ToggleTray();
        trayIsOut = false;
        playable = SceneHandler.Instance;
    }

    public void PutAwayTray()
    {
        trayIsOut = false;
        machineCrosshair.ToggleCursor(true);
        Cursor.visible = false;
        machine.enabled = true;
        trayCanvas.enabled = false;
        if (transform != null) { transform.DOMoveY(trayIn.position.y, .5f); }
    }

    public void PullOutTray()
    {
        trayButton.SetActive(true);
        trayIsOut = true;
        machineCrosshair.ToggleCursor(false);
        Cursor.visible = true;
        machine.enabled = false;
        machineObject.transform.DOMove(machineIdol.position, .5f);
        Invoke(nameof(EnableCanvas), .5f);
        if (transform != null) { transform.DOMoveY(trayOut.position.y, .5f); }
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

    private void OnEnable()
    {
        _actions.TattooControls.Enable();
    }

    private void OnDisable()
    {
        _actions.TattooControls.Disable();
    }
}
