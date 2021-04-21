using System.Linq;
using System.Collections.Generic;
using UnityEngine;

public class InkLine : MonoBehaviour
{
    [SerializeField] LineRenderer lineRenderer;

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

    
    private void AddPoint(Vector3 point)
    {
        points.Add(point);
        lineRenderer.positionCount = points.Count;
        lineRenderer.SetPosition(points.Count - 1, point);
    }
}
