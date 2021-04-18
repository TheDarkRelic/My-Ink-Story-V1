using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    [SerializeField] Ink ink;


    public void ChangeColorRed()
    {
        ink.newColor = Color.red;
        ink.sprite.sortingOrder = 6;
    }
    public void ChangeColorBlack()
    {
        ink.newColor = Color.black;
        ink.sprite.sortingOrder = 9;
    }

    public void ChangeColorBlue()
    {
        ink.newColor = Color.blue;
        ink.sprite.sortingOrder = 8;
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

}
