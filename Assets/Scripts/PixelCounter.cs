using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelCounter : MonoBehaviour
{
    Color[] retrievedPixels;
    public int totalPixels;

    [ContextMenu ("Count Pixels")]
    public void GetPixelCount(Texture2D selectedImage)
    {
        totalPixels = 0;
        retrievedPixels = selectedImage.GetPixels();
        foreach (var pixel in retrievedPixels)
        {
            if(pixel.a != 0) { totalPixels++; }
        }
    }
}
