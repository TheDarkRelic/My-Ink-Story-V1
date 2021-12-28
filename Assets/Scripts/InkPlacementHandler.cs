using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class InkPlacementHandler : MonoBehaviour
{
    [SerializeField] GameObject inkLinePreFab = null;
    private InkLine  activeInkLine;
    [SerializeField] Transform lineParent;
    private Vector3 hitPoint;
    [SerializeField] Machine machineScript = null;
    [SerializeField] JoystickControls joystick = null;
    PlayerActions _actions = null;
    bool pressed;

    private void Awake()
    {
        _actions = new PlayerActions();
        _actions.TattooControls.RunMachine.started += cntxt => MachineFlip(cntxt);
    }


    private void Update()
    {
        if (pressed) { PlaceLine(); }
    }

    private void MachineFlip(InputAction.CallbackContext cntxt)
    {
        pressed = cntxt.ReadValueAsButton();
    }
    private void PlaceLine()
    {
        GameObject inkLineGameObject = Instantiate(inkLinePreFab, joystick.hit.point, Quaternion.identity);
        inkLineGameObject.transform.parent = lineParent;
        activeInkLine = inkLineGameObject.GetComponent<InkLine>();

        if (machineScript.enabled == false) { FinishLineRender(); }

        if (!pressed) { FinishLineRender(); }

        if (activeInkLine != null)
        {
            hitPoint = joystick.hit.point;
            activeInkLine.UpdateLine(hitPoint);
        }
    }

    private void FinishLineRender()
    {
        if (activeInkLine != null) { activeInkLine.AddPoint(hitPoint); }
        activeInkLine = null;
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
