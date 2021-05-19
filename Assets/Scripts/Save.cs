using System.Collections;
using TMPro;
using UnityEngine;

public class Save : MonoBehaviour
{
    [SerializeField] PixelCounter pixelCounter = null;
    [SerializeField] Unlockable unlockable = null;
    [SerializeField] DiscordWebhook discord = null;

    [SerializeField] TMP_Text percentageText = null;
    public Texture2D[] tattooDesigns;
    public Texture2D tattooDesign;
    private Texture2D finalData;
    public RenderTexture tattooTexture;
    private float correctPixels;
    public float totalCorrectPixels;
    public float incorrectPixels;
    public float coloredPixels;
    public Color targetColor;
    public GameObject youWinText;
    public GameObject youLoseText;
    public GameObject tryAgainButton, continueButton, mainMenuButton;
    public int designNumber;
    [SerializeField] float passingAmount = 75;
    public byte[] data;
    public string playerName;
    float roundedPercent;

    private void Awake()
    {
        var getPlayerName = PlayerPrefs.GetString("PlayerName");
        if (getPlayerName != null) { playerName = getPlayerName; }
        

        SetDesignNumber(1);
    }
    public void SaveTexture()
    {
        StartCoroutine(CoSave());
        
    }

    IEnumerator CoSave()
    {
        yield return new WaitForEndOfFrame();

        RenderTexture.active = tattooTexture;
        var playerTattooTexture = new Texture2D(tattooTexture.width, tattooTexture.height);
        playerTattooTexture.ReadPixels(new Rect(0, 0, tattooTexture.width, tattooTexture.height), 0, 0);
        playerTattooTexture.Apply();

        data = playerTattooTexture.EncodeToPNG();
        Object.Destroy(playerTattooTexture);

        finalData = new Texture2D(tattooTexture.width, tattooTexture.height);
        finalData.LoadImage(data);

        CompareTextures();
        var difficulty = SceneHandler.Instance.difficultySetting;
        discord.SendDiscordMessage( playerName, data, roundedPercent, difficulty);
    }

    private void CompareTextures()
    {
        CompareTexture(finalData, tattooDesign);
        var percentValue = (totalCorrectPixels / pixelCounter.totalPixels) * 100;
        roundedPercent = percentValue;
        roundedPercent = Mathf.Round(roundedPercent * 10.0f) * 0.1f;
        if (roundedPercent < 0 ) { roundedPercent = 0; }
        DisplayResults(percentValue, roundedPercent);
    }

    private void DisplayResults(float percentValue, float roundedPercent)
    {
        var difficulty = PlayerPrefs.GetInt("Difficulty");
        if (difficulty == 0) { passingAmount = 40; }
        else if (difficulty == 1) { passingAmount = 60; }
        else if (difficulty == 2) { passingAmount = 85; }

        if (percentValue >= passingAmount)
        {
            unlockable.UnlockPanel(designNumber);
            percentageText.text = $"Great Job! you got {roundedPercent}%";
            youLoseText.SetActive(false);
            youWinText.SetActive(true);
            continueButton.SetActive(true);
        }
        else
        {
            percentageText.text = $"OUch!  {roundedPercent}% ??? They aint coming back...";
            youWinText.SetActive(false);
            youLoseText.SetActive(true);
            tryAgainButton.SetActive(true);
        }
        mainMenuButton.SetActive(true);
        percentageText.enabled = true;
    }

    private void CompareTexture(Texture2D first, Texture2D second)
    {
        Color[] firstPix = first.GetPixels();
        Color[] secondPix = second.GetPixels();

        for (int i = 0; i < firstPix.Length; i++)
        {
            if (firstPix[i].Equals (secondPix[i]))
            {
                    correctPixels++;
            }
            else if (!firstPix[i].Equals(secondPix[i]))
            {
                if (secondPix[i].a != 0)
                {
                    incorrectPixels++;
                }
                else if (secondPix[i].a == 0 && firstPix[i].a != 0)
                {
                    incorrectPixels++;
                    correctPixels--;
                }
            }
        }

        totalCorrectPixels = correctPixels;
    }

    [ContextMenu("MapPixels")]
    public void MapPixelCountByColor()
    {
        coloredPixels = 0;
        Color[] textureToMap = tattooDesign.GetPixels();
        foreach (var p in textureToMap)
        {
            if (p.Equals(targetColor))
            {
                coloredPixels++;
            }
        }
    }

    public void Set2DTexture(int designNum)
    {
        tattooDesign = tattooDesigns[designNum];
    }

    public void SetDesignNumber(int designNumber)
    {
        this.designNumber = designNumber;
    }

}
