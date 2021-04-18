using System.Collections;
using System.IO;
using UnityEngine;

public class Save : MonoBehaviour
{

    public Texture2D[] tattooDesigns;
    [HideInInspector]public Texture2D tattooDesign;

    public RenderTexture tattooTexture;
    private float correctPixels;
    public float totalCorrectPixels;
    public float incorrectPixels;
    public GameObject youWinText;
    public GameObject youLoseText;
    public GameObject tryAgainButton;
    public float passingAmount = 3500;
    public float coloredPixels;
    public Color targetColor;
    [SerializeField] PixelCounter pixelCounter;

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
        
        CompareTexture(playerTattooTexture, tattooDesign);
        var percentValue = (totalCorrectPixels / pixelCounter.totalPixels) * 100;
        if (percentValue > 70)
        {
            youLoseText.SetActive(false);
            youWinText.SetActive(true);
            tryAgainButton.SetActive(true);
        }
        else
        {
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
