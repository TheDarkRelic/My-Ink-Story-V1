using UnityEngine;
public class Raycasting : MonoBehaviour
{
    [SerializeField] Transform machine = null;
    [SerializeField] Transform idolPos = null;
    [SerializeField] Machine machineScript = null;
    [SerializeField] MachineCrosshair machineCrosshair = null;
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

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100, layerMask))
        {
            SceneHandler.Instance.playable = true;
            machineCrosshair.ToggleCursor(true);
            machineScript.enabled = true;
            Cursor.visible = false;
        }
        else
        {
            machineAudio.enabled = false;
            machineScript.animator.SetBool("Running", false);
            SceneHandler.Instance.playable = false;
            machineCrosshair.ToggleCursor(false);
            machineScript.enabled = false;
            Cursor.visible = true;
            machine.position = idolPos.position;
            machine.rotation = idolPos.rotation;
        }
    }
}
