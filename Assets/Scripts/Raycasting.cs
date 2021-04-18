using UnityEngine;
public class Raycasting : MonoBehaviour
{
    [SerializeField] Transform machine;
    public RaycastHit hit;
    public  LayerMask layerMask;
    public float machineHieght = 1;
    [SerializeField] Transform idolPos;
    public Ray ray;

    void FixedUpdate()
    {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100, layerMask))
        {
            //SetIdolPosition();
        }
        else
        {
            //machine.DOMove(new Vector3(7, 0, -5), .5f);
            machine.position = new Vector3(7, 0, -5);
            machine.rotation = idolPos.rotation;
        }
    }

    public void SetIdolPosition()
    {
        machine.position = hit.point + (Vector3.up * machineHieght) + (Vector3.forward * -2);

        //machine.DOMove(hit.point + Vector3.up * machineHieght, .5f);
    }
}
