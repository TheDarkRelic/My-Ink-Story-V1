using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] Ink ink;


    public void ChangeColorRed()
    {
        ink.newColor = Color.red;
        ink.sprite.sortingOrder = 6;
    }

    public void ChangeColorPink()
    {
        ink.newColor = new Color32(254, 127, 195, 255);
        ink.sprite.sortingOrder = 7;
    }

    public void ChangeColorBlack()
    {
        ink.newColor = Color.black;
        ink.sprite.sortingOrder = 10;
    }

    public void ChangeColorBlue()
    {
        ink.newColor = new Color32(16, 206, 255, 255);
        ink.sprite.sortingOrder = 7;
    }

    public void ChangeColorLightBlue()
    {
        ink.newColor = new Color32(148, 233, 255, 255);
        ink.sprite.sortingOrder = 6;
    }

    public void ChangeColorYellow()
    {
        ink.newColor = new Color32(255, 255, 0, 255);
        ink.sprite.sortingOrder = 2;
    }

    public void ChangeColorWhite()
    {
        ink.newColor = Color.white;
        ink.sprite.sortingOrder = 1;
    }

    public void ChangeColorGreen()
    {
        ink.newColor = Color.green;
        ink.sprite.sortingOrder = 7;
    }

    public void ChangeColorOrange()
    {
        ink.newColor = new Color32(255, 84, 0, 255);
        ink.sprite.sortingOrder = 5;
    }

    public void ChangeColorDarkGray()
    {
        ink.newColor = new Color32(128, 127, 128, 255);
        ink.sprite.sortingOrder = 9;
    }

    public void ChangeColorPurple()
    {
        ink.newColor = new Color32(127, 0, 255, 255);
        ink.sprite.sortingOrder = 8;
    }

}
