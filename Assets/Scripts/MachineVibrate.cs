using System.Collections;
using UnityEngine;

public class MachineVibrate : MonoBehaviour
{
    public bool vibrating;
    public bool shaking;
    [Range(10f, 100f)] public float steadiness = 10f;

    private void Start()
    {
        vibrating = false;
    }

    public IEnumerator MachineVibrating()
    {
        vibrating = true;
        if (vibrating && !shaking)
        {
            transform.position += Vector3.up / 25;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.down / 25;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.left / 25;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.right / 25;
            yield return new WaitForSeconds(.0125f);
        }
        else if (vibrating && shaking)
        {
            transform.position += Vector3.up / steadiness;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.down / steadiness;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.left / steadiness;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.right / steadiness;
            yield return new WaitForSeconds(.0125f);
        }
        vibrating = false;
    }

}
