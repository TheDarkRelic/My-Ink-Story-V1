using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class InkLine : MonoBehaviour
{
    public LineRenderer lineRenderer;

    List<Vector3> points;
    [SerializeField] float pointDistance = .05f;

    public void UpdateLine(Vector3 mousePosition)
    {
        if (points == null)
        {
            points = new List<Vector3>();
            AddPoint(mousePosition);
            return;
        }

        if (Vector3.Distance (points.Last(), mousePosition) > pointDistance)
        {
            AddPoint(mousePosition);
        }
    }
    
    public void AddPoint(Vector3 point)
    {
        points.Add(point);
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
    }

    public void SelectNeedleSize(float size)
    {
        lineRenderer.startWidth = size;
        lineRenderer.endWidth = size;
    }

    public void SelectColor(Color newColor)
    {
        lineRenderer.startColor = newColor;
        lineRenderer.endColor = newColor;
    }

    public void SelectColor32(Color32 newColor)
    {
        lineRenderer.startColor = newColor;
        lineRenderer.endColor = newColor;
    }
}
