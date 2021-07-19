using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class MapRenderer
{
    GameObject cylinderPrefab;


    public MapRenderer(float lineWidth)
    {
        _lineWidth = lineWidth;
        cylinderPrefab = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinderPrefab.SetActive(false);



    }

    private float _lineWidth;
    private Dictionary<string, Vector3> namedPoints = new Dictionary<string, Vector3>();


    public void PlotLeg(IEnumerable<HeadingDistanceElevation> data, Color color, string startsAtJunctionID = "default")
    {
        var prev = startsAtJunctionID == "default" ? Vector3.zero : namedPoints[startsAtJunctionID];
        HeadingDistanceElevation previousLeg = new HeadingDistanceElevation { headingDegrees = 0f };

        var listOfAllPoints = new List<Vector3>();
        var listOfAllLegs = new List<HeadingDistanceElevation>();
        listOfAllPoints.Add(prev);
        listOfAllLegs.Add(data.FirstOrDefault());
        foreach (var leg in data)
        {


            var next = PointFromHeadingDistanceAndElevation(prev, leg.headingDegrees, leg.distance, leg.elevation);
            listOfAllPoints.Add(next);
            listOfAllLegs.Add(leg);
            var preNorm = prev.normalized;
            var nextNorm = next.normalized;
            if (leg.EndsAtJunctionID != null) { namedPoints.Add(leg.EndsAtJunctionID, next); }
            if (!leg.isGap) CreateCylinderBetweenPoints(prev, next, _lineWidth, color);
            prev = next;
        }


        List<(Vector3, Vector3, Vector3, Vector3)> hvnoData = new List<(Vector3, Vector3, Vector3, Vector3)>();
        for (int i = 2; i < listOfAllPoints.Count; i++)
        {
            // CreateCylinderBetweenPoints(listOfAllPoints[i - 2], listOfAllPoints[i], _lineWidth / 2, Color.blue);

            Vector3 dir = listOfAllPoints[i] - listOfAllPoints[i - 2];
            Vector3 right = Vector3.Cross(dir, Vector3.down).normalized * listOfAllLegs[i - 1].right;
            Vector3 left = Vector3.Cross(dir, Vector3.up).normalized * listOfAllLegs[i - 1].left;

            var leftPoint = left + listOfAllPoints[i - 1];
            var rightPoint = right + listOfAllPoints[i - 1];
            var upPoint = listOfAllPoints[i - 1];
            upPoint.y = upPoint.y + listOfAllLegs[i - 1].up;
            var downPoint = listOfAllPoints[i - 1];
            downPoint.y = downPoint.y - listOfAllLegs[i - 1].down;
            /*
                       CreateCylinderBetweenPoints(listOfAllPoints[i - 1], leftPoint, _lineWidth / 2, Color.red);
                       CreateCylinderBetweenPoints(listOfAllPoints[i - 1], rightPoint, _lineWidth / 2, Color.green);
                       CreateCylinderBetweenPoints(listOfAllPoints[i - 1], upPoint, _lineWidth / 2, Color.cyan);
                       CreateCylinderBetweenPoints(listOfAllPoints[i - 1], downPoint, _lineWidth / 2, Color.blue);

                        CreateCylinderBetweenPoints(leftPoint, upPoint, _lineWidth / 2, Color.black);
                        CreateCylinderBetweenPoints(upPoint, rightPoint, _lineWidth / 2, Color.black);
                        CreateCylinderBetweenPoints(rightPoint, downPoint, _lineWidth / 2, Color.black);
                        CreateCylinderBetweenPoints(downPoint, leftPoint, _lineWidth / 2, Color.black);
                        */
            hvnoData.Add((rightPoint, leftPoint, downPoint, upPoint));

        }

        for (int i = 1; i < hvnoData.Count; i++)
        {
            /*
            CreateCylinderBetweenPoints(hvnoData[i - 1].Item1, hvnoData[i].Item1, _lineWidth / 2, Color.black);
            CreateCylinderBetweenPoints(hvnoData[i - 1].Item2, hvnoData[i].Item2, _lineWidth / 2, Color.black);
            CreateCylinderBetweenPoints(hvnoData[i - 1].Item3, hvnoData[i].Item3, _lineWidth / 2, Color.black);
            CreateCylinderBetweenPoints(hvnoData[i - 1].Item4, hvnoData[i].Item4, _lineWidth / 2, Color.black);
            */
            Vector3[] leftupVerts =
            {
                    hvnoData[i-1].Item2,
                    hvnoData[i].Item2,
                    hvnoData[i].Item4,
                    hvnoData[i-1].Item4
                };

            Vector3[] upRightVerts =
            {
                    hvnoData[i].Item1,
                    hvnoData[i-1].Item1,
                    hvnoData[i-1].Item4,
                    hvnoData[i].Item4
                };

            Vector3[] rightDownVerts =
            {
                    hvnoData[i].Item3,
                    hvnoData[i-1].Item3,
                    hvnoData[i-1].Item1,
                    hvnoData[i].Item1
                };

            Vector3[] downLeftVerts =
            {
                    hvnoData[i-1].Item3,
                    hvnoData[i].Item3,
                    hvnoData[i].Item2,
                    hvnoData[i-1].Item2
                };


            DrawMesh(leftupVerts);
            DrawMesh(upRightVerts);
            DrawMesh(rightDownVerts);
            DrawMesh(downLeftVerts);

        }



    }

    private static void DrawMesh(Vector3[] verts)
    {
        var gameObject = new GameObject();
        int[] triangles =
                   {
            0, 2, 1,
            0, 3, 2
                 };
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = new Material(Shader.Find("Standard"));

        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();

        Mesh mesh = new Mesh();
        mesh.Clear();
        mesh.vertices = verts;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;
    }

    Vector3 PointFromHeadingDistanceAndElevation(Vector3 origin, float heading, float distance, float elevation)
    {

        var result = new Vector3();
        //a2 + b2 = c2 -> distance2 = elevationDelta2 + 
        var elevationDeltaY = elevation - origin.y;
        var flatDistance = Mathf.Sqrt((distance * distance) - (elevationDeltaY * elevationDeltaY));
        float angle = heading * Mathf.PI / 180f;
        result.x = Mathf.Sin(angle) * flatDistance;
        result.z = Mathf.Cos(angle) * flatDistance;
        result.y = elevationDeltaY;
        return origin + result;


    }
    void CreateCylinderBetweenPoints(Vector3 start, Vector3 end, float width, Color color)
    {
        var offset = end - start;
        var scale = new Vector3(width, offset.magnitude / 2.0f, width);
        var position = start + (offset / 2.0f);
        var cylinder = GameObject.Instantiate(cylinderPrefab, position, Quaternion.identity);
        cylinder.SetActive(true);
        cylinder.transform.up = offset;
        cylinder.transform.localScale = scale;
        var cylinderRenderer = cylinder.GetComponent<Renderer>();
        cylinderRenderer.material.SetColor("_Color", color);

    }
}
