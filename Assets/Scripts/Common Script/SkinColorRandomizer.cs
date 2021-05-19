using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinColorRandomizer : MonoBehaviour
{
    [SerializeField] Material material;
    Color[] colors = new Color[11];

    private void Awake()
    {
        colors[0] = new Color32(248, 210, 176, 255); //Pale Skin
        colors[1] = new Color32(227, 170, 120, 255); //Yellowish Skin
        colors[2] = new Color32(166, 120, 101, 255); //Equator Skin
        colors[3] = new Color32(248, 210, 176, 255); //Pale Skin
        colors[4] = new Color32(227, 170, 120, 255); //Yellowish Skin
        colors[5] = new Color32(160, 115, 95, 255); // Light Brown
        colors[6] = new Color32(248, 210, 176, 255); //Pale Skin
        colors[7] = new Color32(227, 170, 120, 255); //Yellowish Skin
        colors[8] = new Color32(123, 81, 63, 255); //Brown
        colors[9] = new Color32(248, 210, 176, 255); //Pale Skin
        colors[10] = new Color32(227, 170, 120, 255); //Yellowish Skin
    }
    private void OnEnable()
    {
        var index = Random.Range(0, colors.Length);
        material.color = colors[index];
    }
}
