using UnityEngine;
public class Raycasting : MonoBehaviour
{
    [SerializeField] Transform machine = null;
    public RaycastHit hit;
    public  LayerMask layerMask;
    public float machineHieght = 1;
    [SerializeField] Transform idolPos = null;
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
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
            machine.position = new Vector3(7, 0, -5);
            machine.rotation = idolPos.rotation;
        }
    }
}
