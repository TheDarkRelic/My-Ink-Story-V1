using System.Collections;
using System.IO;
using TMPro;
using UnityEngine;

public class Save : MonoBehaviour
{

    public Texture2D[] tattooDesigns;
    public Texture2D tattooDesign;

    public RenderTexture tattooTexture;
    private float correctPixels;
    public float totalCorrectPixels;
    public float incorrectPixels;
    public GameObject youWinText;
    public GameObject youLoseText;
    public GameObject tryAgainButton;
    public float coloredPixels;
    public Color targetColor;
    [SerializeField] PixelCounter pixelCounter;
    Texture2D finalData;
    [SerializeField] TMP_Text percentageText;

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

        var data = playerTattooTexture.EncodeToPNG();
        File.WriteAllBytes(Application.dataPath + "/saveImage.png", data);

        finalData = new Texture2D(tattooTexture.width, tattooTexture.height);
        finalData.LoadImage(data);

        CompareTextures();
    }

    private void CompareTextures()
    {
        CompareTexture(finalData, tattooDesign);
        var percentValue = (totalCorrectPixels / pixelCounter.totalPixels) * 100;
        float roundedPercent = percentValue;
        roundedPercent = Mathf.Round(roundedPercent * 10.0f) * 0.1f;

        if (percentValue >= 70)
        {
            percentageText.enabled = true;
            percentageText.text = $"Great Job! you got {roundedPercent}%";
            youLoseText.SetActive(false);
            youWinText.SetActive(true);
            tryAgainButton.SetActive(true);
        }
        else
        {
            percentageText.enabled = true;
            percentageText.text = $"OUch!  {roundedPercent}% ??? They aint coming back...";
            youWinText.SetActive(false);
            youLoseText.SetActive(true);
            tryAgainButton.SetActive(true);
        }
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

}
