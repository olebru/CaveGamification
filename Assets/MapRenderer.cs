using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class MapRenderer
{

    const float MINHVNOVAL = 0.2f;
    GameObject cylinderPrefab;
    List<GameObject> insideMeshes = new List<GameObject>();
    List<GameObject> outsideMeshes = new List<GameObject>();
    private bool showingInside = true;
    private bool showingOutside = true;
    public void ShowInside(bool show)
    {
        if (show != showingInside)
        {
            showingInside = show;
            foreach (var meshGo in insideMeshes)
            {
                meshGo.SetActive(show);
            }
        }
    }
    public void ShowOutSide(bool show)
    {
        if (show != showingOutside)
        {
            showingOutside = show;
            foreach (var meshGo in outsideMeshes)
            {
                meshGo.SetActive(show);
            }
        }
    }
    public MapRenderer(float lineWidth)
    {
        _lineWidth = lineWidth;
        cylinderPrefab = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinderPrefab.SetActive(false);
    }
    private float _lineWidth;
    private Dictionary<string, Vector3> namedPoints = new Dictionary<string, Vector3>();
    public void CreateDimPointLightAt(Vector3 location)
    {

        GameObject lightGameObject = new GameObject("The Light");
        Light lightComp = lightGameObject.AddComponent<Light>();
        lightComp.color = Color.white;
        lightGameObject.transform.position = location;
        lightComp.intensity = 0.1f;


    }

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

            CreateDimPointLightAt(next);

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
            Vector3 right = Vector3.Cross(dir, Vector3.down).normalized * (listOfAllLegs[i - 1].right < MINHVNOVAL ? MINHVNOVAL : listOfAllLegs[i - 1].right );
            Vector3 left = Vector3.Cross(dir, Vector3.up).normalized * (listOfAllLegs[i - 1].left < MINHVNOVAL ? MINHVNOVAL : listOfAllLegs[i - 1].right );

            var leftPoint = left + listOfAllPoints[i - 1];
            var rightPoint = right + listOfAllPoints[i - 1];
            var upPoint = listOfAllPoints[i - 1];
            upPoint.y = upPoint.y + (listOfAllLegs[i - 1].up < MINHVNOVAL ? MINHVNOVAL : listOfAllLegs[i - 1].up );
            var downPoint = listOfAllPoints[i - 1];
            downPoint.y = downPoint.y - (listOfAllLegs[i - 1].down < MINHVNOVAL ? MINHVNOVAL : listOfAllLegs[i - 1].down );

            CreateCylinderBetweenPoints(listOfAllPoints[i - 1], leftPoint, _lineWidth / 2, Color.red);
            CreateCylinderBetweenPoints(listOfAllPoints[i - 1], rightPoint, _lineWidth / 2, Color.green);
            CreateCylinderBetweenPoints(listOfAllPoints[i - 1], upPoint, _lineWidth / 2, Color.magenta);
            CreateCylinderBetweenPoints(listOfAllPoints[i - 1], downPoint, _lineWidth / 2, Color.blue);


            CreateCylinderBetweenPoints(leftPoint, upPoint, _lineWidth / 2, Color.black);
            CreateCylinderBetweenPoints(upPoint, rightPoint, _lineWidth / 2, Color.black);
            CreateCylinderBetweenPoints(rightPoint, downPoint, _lineWidth / 2, Color.black);
            CreateCylinderBetweenPoints(downPoint, leftPoint, _lineWidth / 2, Color.black);

            hvnoData.Add((rightPoint, leftPoint, downPoint, upPoint));
        }
        for (int i = 1; i < hvnoData.Count; i++)
        {
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
            DrawInsideAndOutSideMesh(leftupVerts);
            DrawInsideAndOutSideMesh(upRightVerts);
            DrawInsideAndOutSideMesh(rightDownVerts);
            DrawInsideAndOutSideMesh(downLeftVerts);
        }
        ShowOutSide(false);
    }
    private void DrawInsideAndOutSideMesh(Vector3[] verts)
    {

        int[] trianglesInside =
                   {
            0, 2, 1,
            0, 3, 2
                 };

        int[] trianglesOutSide =
                    {
            1,3,0,
            1,2,3
                 };

        insideMeshes.Add(DrawMesh(verts, trianglesInside));
        outsideMeshes.Add(DrawMesh(verts, trianglesOutSide));

    }
    private GameObject DrawMesh(Vector3[] verts, int[] triangles)
    {
        var gameObject = new GameObject();
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.sharedMaterial = new Material(Shader.Find("Standard"));

        MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
        MeshCollider meshCollider = gameObject.AddComponent<MeshCollider>();

        Mesh mesh = new Mesh();
        mesh.Clear();
        mesh.vertices = verts;
        mesh.triangles = triangles;
        mesh.Optimize();
        mesh.RecalculateNormals();
        meshFilter.mesh = mesh;
        return gameObject;
    }
    Vector3 PointFromHeadingDistanceAndElevation(Vector3 origin, float heading, float distance, float elevation)
    {

        var result = new Vector3();
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
