using UnityEngine;
using DG.Tweening;

public class MayoTrayUI : MonoBehaviour
{
    private const bool V = true;
    [SerializeField] Transform trayIn, trayOut, machineIdol;
    [SerializeField] Canvas trayCanvas;
    [SerializeField] GameObject machineObject;
    [SerializeField] Machine machine;

    private void Update()
    {
        if (!Input.GetKeyDown(KeyCode.T)) { return; }
        if (transform.position != trayOut.position)
        {
            machine.enabled = false;
            machineObject.transform.DOMove(machineIdol.position, .5f);
            Invoke(nameof(EnableCanvas), .5f);
            transform.DOMoveY(trayOut.position.y, .5f);
        }
        else
        {
            machine.enabled = true;
            trayCanvas.enabled = false;
            transform.DOMoveY(trayIn.position.y, .5f);
        }
        
    }

    void EnableCanvas()
    {
        trayCanvas.enabled = V;
    }
}
