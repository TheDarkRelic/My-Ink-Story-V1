using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] InkLine inkLine;


    public void ChangeColorRed()
    {
        inkLine.SelectColor(Color.red);
        inkLine.lineRenderer.sortingOrder = 6;
    }

    public void ChangeColorPink()
    {
        inkLine.SelectColor32(new Color32 (255, 128, 128, 255));
        inkLine.lineRenderer.sortingOrder = 7;
    }

    public void ChangeColorBlack()
    {
        inkLine.SelectColor(Color.black);
        inkLine.lineRenderer.sortingOrder = 10;
    }

    public void ChangeColorBlue()
    {
        inkLine.SelectColor(new Color32(16, 206, 255, 255));
        inkLine.lineRenderer.sortingOrder = 7;
    }

    public void ChangeColorLightBlue()
    {
        inkLine.SelectColor(new Color32(148, 233, 255, 255));
        inkLine.lineRenderer.sortingOrder = 6;
    }

    public void ChangeColorYellow()
    {
        inkLine.SelectColor(new Color32(255, 255, 0, 255));
        inkLine.lineRenderer.sortingOrder = 2;
    }

    public void ChangeColorWhite()
    {
        inkLine.SelectColor(Color.white);
        inkLine.lineRenderer.sortingOrder = 1;
    }

    public void ChangeColorGreen()
    {
        inkLine.SelectColor(Color.green);
        inkLine.lineRenderer.sortingOrder = 7;
    }

    public void ChangeColorOrange()
    {
        inkLine.SelectColor(new Color32(255, 84, 0, 255));
        inkLine.lineRenderer.sortingOrder = 5;
    }

    public void ChangeColorDarkGray()
    {
        inkLine.SelectColor(new Color32(128, 127, 128, 255));
        inkLine.lineRenderer.sortingOrder = 9;
    }

    public void ChangeColorPurple()
    {
        inkLine.SelectColor(new Color32(127, 0, 255, 255));
        inkLine.lineRenderer.sortingOrder = 8;
    }

}
