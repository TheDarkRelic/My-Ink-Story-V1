using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TattooDesign : MonoBehaviour
{
    public TattooDesign[] tattooDesigns;

    string designName;
    int designNumber;
    float percentageComplete;
    Texture2D designTexture;

    public TattooDesign(string designName, int designNumber, float percentageComplete, Texture2D designTexture)
    {
        this.designName = designName;
        this.designNumber = designNumber;
        this.percentageComplete = percentageComplete;
        this.designTexture = designTexture;
    }

}
