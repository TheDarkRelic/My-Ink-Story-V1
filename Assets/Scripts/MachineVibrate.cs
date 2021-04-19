using System.Collections;
using UnityEngine;

public class MachineVibrate : MonoBehaviour
{
    public bool vibrating;
    public bool shaking;
    [Range(1f, 100f)] public float steadiness = 10f;
    [Range(50f, 500f)] public float vibeDampener = 50f;

    private void Start()
    {
        vibrating = false;
    }

    public IEnumerator MachineVibrating()
    {
        vibrating = true;
        if (vibrating && !shaking)
        {
            transform.position += Vector3.up / vibeDampener;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.down / vibeDampener;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.left / vibeDampener;
            yield return new WaitForSeconds(.0125f);
            transform.position += Vector3.right / vibeDampener;
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
