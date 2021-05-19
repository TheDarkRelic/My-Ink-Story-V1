using UnityEngine;

public class NeedleSelector : MonoBehaviour
{
    [SerializeField] MachineCrosshair crosshair = null;
    [SerializeField] InkLine inkLine = null;
    [SerializeField] SelectionsIndicator indicator = null;
    private float size;

    private void Start()
    {
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
        SetNeedleIndicator();

    }

    private void SetNeedleIndicator()
    {
        indicator.SetNeedleSprite(crosshair.transform.localScale);
    }


    public void ThreeNeedle()
    {
        inkLine.SelectNeedleSize(.125f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
        SetNeedleIndicator();
    }
    public void FiveNeedle()
    {
        inkLine.SelectNeedleSize(.25f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
        SetNeedleIndicator();
    }

    public void SevenNeedle()
    {
        inkLine.SelectNeedleSize(.375f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
        SetNeedleIndicator();
    }

    public void ElevenNeedle()
    {
        inkLine.SelectNeedleSize(.5f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
        SetNeedleIndicator();
    }

    public void FourteenNeedle()
    {
        inkLine.SelectNeedleSize(.625f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
        SetNeedleIndicator();
    }

    public void TwentyOneNeedle()
    {
        inkLine.SelectNeedleSize(.75f);
        size = inkLine.lineRenderer.startWidth;
        crosshair.transform.localScale = new Vector3(size, size, size);
        SetNeedleIndicator();
    }
}
