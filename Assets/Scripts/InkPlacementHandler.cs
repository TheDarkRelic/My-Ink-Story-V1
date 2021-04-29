using UnityEngine;

public class InkPlacementHandler : MonoBehaviour
{
    [SerializeField] GameObject inkLinePreFab;
    [SerializeField] Raycasting raycasting;
    private InkLine  activeInkLine;
    private Vector3 hitPoint;

    void Update()
    {
        bool playable = SceneHandler.Instance.playable;

        if (playable && Input.GetMouseButtonDown(0) && Physics.Raycast(raycasting.ray, out raycasting.hit, 100, raycasting.layerMask))
        {
            GameObject inkLineGameObject = Instantiate(inkLinePreFab, raycasting.hit.point, Quaternion.identity);
            activeInkLine = inkLineGameObject.GetComponent<InkLine>();
        }

        if (playable && Input.GetMouseButtonUp(0))
        {
            if (activeInkLine != null) { activeInkLine.AddPoint(hitPoint); }
            activeInkLine = null;
        }

        if (activeInkLine != null)
        {
            hitPoint = raycasting.hit.point;
            activeInkLine.UpdateLine(hitPoint);
        }
        
    }

    
}
