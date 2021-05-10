using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;
using System.Collections;

public class TattooDesignSelector : MonoBehaviour
{
    [SerializeField] Save save = null;
    [SerializeField] PixelCounter pixelCounter = null;
    [SerializeField] SetPlayerName setPlayerName;
    [SerializeField] Image tattooDisplayImage = null;
    [SerializeField] SpriteRenderer tattooDisplayPattern = null;
    [SerializeField] GameObject designSelectionPanel = null;
    [SerializeField] Sprite defaultDisplay = null, defaultPattern = null, defaultCompare = null;
    [SerializeField] Texture2D defaultTexture = null;
    [SerializeField] TMP_Text titleText;
    [SerializeField] Color blendColor1, blendColor2;
    [SerializeField] GameObject namePanel;
    private Sprite _tattooCompareImage;
    public bool isActive;

    private void Awake()
    {
        setPlayerName.CheckForSavedName(namePanel);
    }

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
            designSelectionPanel.SetActive(true);
        }
        else if (isActive)
        {
            isActive = false;
            designSelectionPanel.SetActive(false);
        }
    }
}
