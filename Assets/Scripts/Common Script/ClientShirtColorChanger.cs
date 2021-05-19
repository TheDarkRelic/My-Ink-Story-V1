using UnityEngine;

public class ClientShirtColorChanger : MonoBehaviour
{
    [SerializeField] Material material;
    Color[] colors = new Color[6];

    private void Awake()
    {
        colors[0] = new Color32(134, 144, 89, 255); //light army green
        colors[1] = new Color32(90, 94, 145, 255); //periwinkle
        colors[2] = new Color32(140, 90, 145, 255); //purpleish
        colors[3] = new Color32(230, 130, 223, 255); //light pink
        colors[4] = new Color32(100, 164, 164, 255); //light teal
        colors[5] = new Color32(185, 60, 60, 255); //redish
    }
    private void OnEnable()
    {
        var index = Random.Range(0, colors.Length);
        material.color = colors[index];
    }
}
