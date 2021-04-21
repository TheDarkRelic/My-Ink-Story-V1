using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkPlacementHandler : MonoBehaviour
{
    [SerializeField] GameObject inkLinePreFab;
    [SerializeField] Raycasting raycasting;
    private InkLine  activeInkLine;
    [SerializeField] float zDepth = 10;
    [SerializeField] float inkOffset = .15f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject inkLineGameObject = Instantiate(inkLinePreFab);
            activeInkLine = inkLineGameObject.GetComponent<InkLine>();
        }

        if (Input.GetMouseButtonUp(0))
        {
            activeInkLine = null;
        }

        if (activeInkLine != null)
        {
            var hitPoint = raycasting.hit.point + (-Vector3.forward * inkOffset);
            activeInkLine.UpdateLine(hitPoint);
        }
        
    }
}
