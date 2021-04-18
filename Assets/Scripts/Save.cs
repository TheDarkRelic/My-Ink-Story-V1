using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class Save : MonoBehaviour
{

    public Texture2D[] tattooDesigns;
    public Texture2D tattooDesign;

    public RenderTexture tattooTexture;
    private int correctPixels;
    public int totalCorrectPixels;
    public int incorrectPixels;
    public GameObject youWinText;
    public GameObject youLoseText;
    public GameObject tryAgainButton;
    public int passingAmount = 3500;
    public int failingAmount = 15000;
    public int coloredPixels;
    public Color targetColor;

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
        Debug.Log(totalCorrectPixels);
        Debug.Log(incorrectPixels);
        if (totalCorrectPixels >= passingAmount && incorrectPixels < failingAmount)
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

    private int CompareTexture(Texture2D first, Texture2D second)
    {
        Color[] firstPix = first.GetPixels();
        Color[] secondPix = second.GetPixels();
        Debug.Log(secondPix.Length);

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

        return totalCorrectPixels = correctPixels;
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
