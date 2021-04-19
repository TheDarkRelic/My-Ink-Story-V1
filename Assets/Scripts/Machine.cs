using System.Collections;
using UnityEngine;
using DG.Tweening;

public class Machine : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Raycasting raycasting;
    [SerializeField] MachineVibrate vibrate;
    [SerializeField] float machineSpeed;
    [SerializeField] GameObject ink;
    [SerializeField] Transform inkParent;
    bool strokeReady;
    [SerializeField] float smoothing = .2f;

    private void Start()
    {
        strokeReady = true;
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && Physics.Raycast(raycasting.ray, out raycasting.hit, 100, raycasting.layerMask) && transform != null)
        {
            animator.SetBool("Running", true);
            transform.DOMove(raycasting.hit.point, .2f);
            //transform.position = raycasting.hit.point;

            if (strokeReady && raycasting.hit.collider != null)
            {
                if (!vibrate.vibrating) { vibrate.StartCoroutine("MachineVibrating"); }
                StartCoroutine(PlaceInk(ink));
            }
        }
        else
        {
            transform.DOMove(raycasting.hit.point + (Vector3.up * raycasting.machineHieght) + (-Vector3.forward * 2), smoothing);
            animator.SetBool("Running", false);
        }
        
    }

    IEnumerator PlaceInk(GameObject currentInk)
    {
        var random = Random.Range(-.2f, .2f);
        strokeReady = false;
        var placedInk = Instantiate(currentInk, raycasting.hit.point, Quaternion.identity);
        var color = placedInk.GetComponentInChildren<SpriteRenderer>().color;
        color = ink.GetComponentInChildren<Ink>().newColor;
        placedInk.transform.parent = inkParent;

        if (vibrate.shaking)
        {
            placedInk.transform.position = new Vector3(placedInk.transform.position.x + random, placedInk.transform.position.y + random, placedInk.transform.position.z);
        }
        yield return new WaitForSeconds(machineSpeed);
        strokeReady = true;
    }
}
