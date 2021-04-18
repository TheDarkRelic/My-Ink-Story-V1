using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ink : MonoBehaviour
{
    public GameObject go;
    public Color newColor;
    Material color;
    public SpriteRenderer sprite;

    private void Start()
    {
        go = this.gameObject;
        color = go.GetComponent<SpriteRenderer>().material;
        sprite = go.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
       color.color = newColor;
    }
}
