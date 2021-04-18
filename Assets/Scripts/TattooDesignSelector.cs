using UnityEngine;
using UnityEngine.UI;


public class TattooDesignSelector : MonoBehaviour
{
    [SerializeField] Save save;

    [SerializeField] Image tattooDisplayImage;
    [SerializeField] SpriteRenderer tattooDisplayPattern;
    private Sprite _tattooCompareImage;
    [SerializeField] GameObject designSelectionPanal;
    public bool isActive;

    private void Start()
    {
        isActive = true;
    }

    public void SetDisplayImage(Sprite displaySprite)
    {
        tattooDisplayImage.sprite = displaySprite;
    }

    public void SetTattooDisplayPattern(Sprite patternSprite)
    {
        tattooDisplayPattern.sprite = patternSprite;
    }

    public void SetImageToCompare(Sprite compareSprite)
    {
        _tattooCompareImage = compareSprite;
    }


    public void SelectionPanel()
    {
        if (!isActive)
        {
            isActive = true;
            designSelectionPanal.SetActive(true);
        }
        else if (isActive)
        {
            isActive = false;
            designSelectionPanal.SetActive(false);
        }
    }
}
