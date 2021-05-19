using UnityEngine;
using DG.Tweening;
using UnityEngine.InputSystem;
public class Raycasting : MonoBehaviour
{
    [SerializeField] Transform machine = null;
    [SerializeField] Transform idolPos = null;
    [SerializeField] Machine machineScript = null;
    [SerializeField] MachineCrosshair machineCrosshair = null;
    [SerializeField] TweenPosition tweenPosition = null;
    [SerializeField] AudioSource machineAudio;
    public float machineHieght = 1;
    public  LayerMask layerMask;
    public RaycastHit hit;
    public Ray ray;
    
    private void OnEnable()
    {
        Cursor.visible = true;
    }

    void FixedUpdate()
    {

        ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());

        if (Physics.Raycast(ray, out hit, 100, layerMask))
        {
            SceneHandler.Instance.playable = true;
            machineCrosshair.ToggleCursor(true);
            machineScript.enabled = true;
            Cursor.visible = false;
            tweenPosition.TweenPositionToA();
        }
        else
        {
            machineAudio.enabled = false;
            machineScript.animator.SetBool("Running", false);
            SceneHandler.Instance.playable = false;
            machineCrosshair.ToggleCursor(false);
            machineScript.enabled = false;
            Cursor.visible = true;
            machine.DOMove(idolPos.position, .35f);
            machine.rotation = idolPos.rotation;
            tweenPosition.TweenPositionToB();
        }
    }
}
