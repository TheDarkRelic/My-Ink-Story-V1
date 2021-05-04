using UnityEngine;

public class NeedleSelector : MonoBehaviour
{
    [SerializeField] MachineCrosshair crosshair = null;
    [SerializeField] InkLine inkLine = null;
    private float size;

    private void Start()
    {
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
    }

    public void ThreeNeedle()
    {
        inkLine.SelectNeedleSize(.125f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
    }
    public void FiveNeedle()
    {
        inkLine.SelectNeedleSize(.25f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
    }

    public void SevenNeedle()
    {
        inkLine.SelectNeedleSize(.375f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
    }

    public void ElevenNeedle()
    {
        inkLine.SelectNeedleSize(.5f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
    }

    public void FourteenNeedle()
    {
        inkLine.SelectNeedleSize(.625f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
    }

    public void TwentyOneNeedle()
    {
        inkLine.SelectNeedleSize(.75f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
    }
}
