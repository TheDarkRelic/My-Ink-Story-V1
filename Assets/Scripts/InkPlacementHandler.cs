using UnityEngine;
using UnityEngine.InputSystem;

public class InkPlacementHandler : MonoBehaviour
{
    [SerializeField] GameObject inkLinePreFab = null;
    private InkLine  activeInkLine;
    [SerializeField] Transform lineParent;
    private Vector3 hitPoint;
    [SerializeField] Raycasting raycasting = null;
    [SerializeField] Machine machineScript = null;

    void Update()
    {
        bool playable = SceneHandler.Instance.playable;

        if (playable && Mouse.current.leftButton.wasPressedThisFrame && Physics.Raycast(raycasting.ray, out raycasting.hit, 100, raycasting.layerMask))
        {
            GameObject inkLineGameObject = Instantiate(inkLinePreFab, raycasting.hit.point, Quaternion.identity);
            inkLineGameObject.transform.parent = lineParent;
            activeInkLine = inkLineGameObject.GetComponent<InkLine>();
        }

        if (playable && Mouse.current.leftButton.wasReleasedThisFrame)
        {
            FinishLineRender();
        }

        if (machineScript.enabled == false) { FinishLineRender(); }

        if (activeInkLine != null)
        {
            hitPoint = raycasting.hit.point;
            activeInkLine.UpdateLine(hitPoint);
        }
        
    }

    private void FinishLineRender()
    {
        if (activeInkLine != null) { activeInkLine.AddPoint(hitPoint); }
        activeInkLine = null;
    }

}
