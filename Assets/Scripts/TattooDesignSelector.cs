using UnityEngine;
using UnityEngine.UI;


public class TattooDesignSelector : MonoBehaviour
{
    [SerializeField] Save save = null;
    [SerializeField] Image tattooDisplayImage = null;
    [SerializeField] SpriteRenderer tattooDisplayPattern = null;
    private Sprite _tattooCompareImage;
    [SerializeField] GameObject designSelectionPanal = null;
    public bool isActive;
    [SerializeField] Sprite defaultDisplay = null, defaultPattern = null, defaultCompare = null;
    [SerializeField] Texture2D defaultTexture = null;
    [SerializeField] PixelCounter pixelCounter = null;

    private void Start()
    {
        isActive = true;
        SetDisplayImage(defaultDisplay);
        SetTattooDisplayPattern(defaultPattern);
        SetImageToCompare(defaultCompare);
        pixelCounter.GetPixelCount(defaultTexture);
        save.tattooDesign = defaultTexture;
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

    public void SetPercentageComplete()
    {

    }
}
