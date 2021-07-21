using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MockData
{


    public static List<HeadingDistanceElevation> GetMassagedSampleData()
    {

        var stickMapData = new List<HeadingDistanceElevation>();



        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 0.0f, distance = 0.0f, elevation = 0.0f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f }); // UD 0.2 to 0 RL 20 to 0
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 125.35f, distance = 3.02f, elevation = 1.95f, down = 0.0f, up = 1.0f, right = 20.0f, left = 10.0f }); // H 20 to 1
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 59.85f, distance = 6.18f, elevation = 5.24f, down = 0.0f, up = 1.0f, right = 5.0f, left = 5.0f }); // R 10 to 5
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 55.65f, distance = 2.98f, elevation = 5.9f, down = 0.0f, up = 1.5f, right = 5.0f, left = 3.0f });// R 10 to 5
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 87.45f, distance = 4.07f, elevation = 6.86f, down = 1.0f, up = 1.0f, right = 5.0f, left = 0.0f });// R 10 to 5
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 103.9f, distance = 6.42f, elevation = 6.68f, down = 2.0f, up = 1.0f, right = 5.0f, left = 0.0f }); // R 20 to 5
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 88.8f, distance = 3.25f, elevation = 6.17f, down = 0.0f, up = 3.0f, right = 3.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 71.95f, distance = 1.86f, elevation = 5.55f, down = 0.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 111.25f, distance = 7.27f, elevation = 5.18f, down = 2.0f, up = 1.0f, right = 10.0f, left = 0.0f, EndsAtJunctionID = "Tilfeldig" });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 108.4f, distance = 6.59f, elevation = 4.94f, down = 0.5f, up = 2.0f, right = 10.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 103.4f, distance = 3.22f, elevation = 5.01f, down = 0.0f, up = 1.0f, right = 3.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 96.1f, distance = 9.21f, elevation = 5.46f, down = 0.0f, up = 1.0f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 58.5f, distance = 7.29f, elevation = 5.67f, down = 0.0f, up = 1.0f, right = 10.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 59.85f, distance = 6.05f, elevation = 5.66f, down = 0.5f, up = 0.5f, right = 2.0f, left = 0.0f }); // R 5 to 2
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 72.7f, distance = 1.9f, elevation = 5.76f, down = 0.0f, up = 1.0f, right = 2.0f, left = 3.0f }); //R 10 to 2
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 101.65f, distance = 10.67f, elevation = 5.88f, down = 0.0f, up = 0.7f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 82.9f, distance = 13.98f, elevation = 5.85f, down = 0.5f, up = 1.0f, right = 2.0f, left = 1.0f }); // R 20 to 2
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 118.9f, distance = 3.84f, elevation = 5.21f, down = 1.0f, up = 1.0f, right = 10.0f, left = 10.0f }); // R 20 to 2
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 150.15f, distance = 7.64f, elevation = 5.01f, down = 1.0f, up = 1.0f, right = 10.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 123.35f, distance = 7.19f, elevation = 4.34f, down = 0.0f, up = 5.0f, right = 15.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 116.95f, distance = 1.99f, elevation = 4.28f, down = 0.0f, up = 6.0f, right = 17.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 95.45f, distance = 27.23f, elevation = 2.84f, down = 0.0f, up = 15.0f, right = 20.0f, left = 5.0f }); // R 20 to 2
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 137.3f, distance = 7.06f, elevation = 2.42f, down = 0.0f, up = 15.0f, right = 4.0f, left = 1.0f }); // R 40 to 4 L 10 to 1
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 89.75f, distance = 2.09f, elevation = 1.95f, down = 0.0f, up = 10.0f, right = 2.0f, left = 2.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 79.65f, distance = 2.11f, elevation = 1.74f, down = 1.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 82.65f, distance = 5.33f, elevation = 1.28f, down = 1.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 78.8f, distance = 3.58f, elevation = 1.22f, down = 1.0f, up = 3.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 117.15f, distance = 4.52f, elevation = 1.88f, down = 1.0f, up = 1.0f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 83.15f, distance = 3.78f, elevation = 1.91f, down = 2.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 69.85f, distance = 6.46f, elevation = 2.36f, down = 0.0f, up = 1.0f, right = 15.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 76.05f, distance = 6.13f, elevation = 3.24f, down = 0.0f, up = 1.0f, right = 20.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 77.9f, distance = 6.92f, elevation = 3.88f, down = 0.0f, up = 1.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 105.9f, distance = 10.99f, elevation = 4.05f, down = 0.0f, up = 1.0f, right = 0.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 113.25f, distance = 0.91f, elevation = 4.04f, down = 0.0f, up = 1.0f, right = 3.0f, left = 1.0f }); // L 1 10 to 1
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 87.8f, distance = 5.39f, elevation = 4.51f, down = 5.0f, up = 1.0f, right = 5.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 81.75f, distance = 3.93f, elevation = 5.83f, down = 1.0f, up = 1.0f, right = 5.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 79.45f, distance = 3.58f, elevation = 5.97f, down = 0.0f, up = 1.0f, right = 1.0f, left = 5.0f }); // R 5 to 1
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 139.95f, distance = 8.01f, elevation = 4.92f, down = 0.0f, up = 2.0f, right = 3.0f, left = 2.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 120.75f, distance = 9.66f, elevation = 5.18f, down = 0.0f, up = 1.0f, right = 10.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 72.25f, distance = 8.49f, elevation = 5.56f, down = 0.0f, up = 1.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 69.9f, distance = 5.89f, elevation = 5.87f, down = 0.0f, up = 2.0f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 65.1f, distance = 3.31f, elevation = 6.43f, down = 0.0f, up = 2.0f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 56.45f, distance = 6.49f, elevation = 7.03f, down = 0.0f, up = 2.0f, right = 2.0f, left = 5.0f }); // R 20 to 2
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 103.05f, distance = 5.52f, elevation = 7.26f, down = 0.0f, up = 2.0f, right = 3.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 127.9f, distance = 7.72f, elevation = 6.63f, down = 0.0f, up = 2.0f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 135.55f, distance = 3.97f, elevation = 6.0f, down = 0.0f, up = 1.0f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 113.35f, distance = 1.59f, elevation = 5.52f, down = 0.0f, up = 1.0f, right = 5.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 116.6f, distance = 1.76f, elevation = 5.7f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 115.15f, distance = 19.76f, elevation = 5.14f, down = 0.0f, up = 1.0f, right = 2.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 96.45f, distance = 9.09f, elevation = 5.17f, down = 0.0f, up = 2.0f, right = 1.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 45.7f, distance = 7.83f, elevation = 6.12f, down = 0.0f, up = 2.0f, right = 2.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 78.8f, distance = 2.5f, elevation = 6.38f, down = 1.0f, up = 2.0f, right = 0.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 92.4f, distance = 5.35f, elevation = 6.23f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 34.5f, distance = 4.69f, elevation = 6.27f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 111.45f, distance = 15.9f, elevation = 6.85f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 196.4f, distance = 0.52f, elevation = 6.86f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 179.35f, distance = 2.96f, elevation = 6.23f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 152.8f, distance = 5.43f, elevation = 4.95f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 143.8f, distance = 3.25f, elevation = 3.98f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 205.0f, distance = 1.61f, elevation = 3.45f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 163.9f, distance = 2.73f, elevation = 4.06f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 126.25f, distance = 1.86f, elevation = 4.14f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 128.5f, distance = 4.69f, elevation = 4.37f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 125.65f, distance = 14.2f, elevation = 5.56f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 136.9f, distance = 12.16f, elevation = 5.46f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 130.55f, distance = 4.81f, elevation = 5.53f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 156.0f, distance = 1.72f, elevation = 5.3f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 159.15f, distance = 5.39f, elevation = 4.61f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 188.0f, distance = 3.29f, elevation = 3.34f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 188.65f, distance = 2.25f, elevation = 1.67f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 249.45f, distance = 3.86f, elevation = 0.58f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 104.65f, distance = 3.35f, elevation = 1.44f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 118.2f, distance = 4.38f, elevation = 2.09f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 74.15f, distance = 10.41f, elevation = 2.61f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 92.2f, distance = 6.98f, elevation = 2.77f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 183.85f, distance = 12.1f, elevation = 1.39f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 160.9f, distance = 7.77f, elevation = 2.24f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 128.4f, distance = 10.34f, elevation = 3.39f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 206.15f, distance = 4.59f, elevation = 3.47f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 83.75f, distance = 4.38f, elevation = 3.42f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f, EndsAtJunctionID = "Enden" });

        return stickMapData;

    }

    public static List<HeadingDistanceElevation> GetMassagedSampleDataFiltered()
    {

        return GetMassagedSampleData().GetRange(13, GetMassagedSampleData().Count - 13);

    }
    public static List<HeadingDistanceElevation> GetSampleData()
    {
        var stickMapData = new List<HeadingDistanceElevation>();
        //stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 0.0f, distance = 0.0f, elevation = 0.0f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 59.05f, distance = 12.64f, elevation = -0.14f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 347.6f, distance = 11.48f, elevation = -0.07f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 309.45f, distance = 2.48f, elevation = -0.08f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 321.65f, distance = 15.03f, elevation = -0.08f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 44.25f, distance = 3.53f, elevation = -0.13f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 41.75f, distance = 3.06f, elevation = -0.06f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 57.85f, distance = 9.29f, elevation = -0.07f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 28.1f, distance = 4.2f, elevation = -0.08f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 0.1f, distance = 4.3f, elevation = -0.08f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 44.3f, distance = 5.62f, elevation = -0.07f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 307.35f, distance = 10.1f, elevation = -0.07f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 294.5f, distance = 9.93f, elevation = -0.07f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 310.5f, distance = 11.69f, elevation = -0.09f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 318.9f, distance = 1.76f, elevation = -0.06f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 314.8f, distance = 5.0f, elevation = -0.08f, down = 1.0f, up = 30.0f, right = 3.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 35.95f, distance = 12.61f, elevation = -0.06f, down = 1.0f, up = 30.0f, right = 3.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 43.55f, distance = 8.2f, elevation = 0.06f, down = 1.0f, up = 30.0f, right = 3.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 23.05f, distance = 14.7f, elevation = -0.05f, down = 1.0f, up = 30.0f, right = 3.0f, left = 3.0f });
        //  stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 0.0f, distance = 0.0f, elevation = 0.0f, down = 0.5f, up = 0.5f, right = 20.0f, left = 20.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 125.35f, distance = 3.02f, elevation = 1.95f, down = 0.0f, up = 1.0f, right = 20.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 59.85f, distance = 6.18f, elevation = 5.24f, down = 0.0f, up = 1.0f, right = 10.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 55.65f, distance = 2.98f, elevation = 5.9f, down = 0.0f, up = 1.5f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 87.45f, distance = 4.07f, elevation = 6.86f, down = 1.0f, up = 1.0f, right = 10.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 103.9f, distance = 6.42f, elevation = 6.68f, down = 2.0f, up = 1.0f, right = 20.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 88.8f, distance = 3.25f, elevation = 6.17f, down = 0.0f, up = 3.0f, right = 3.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 71.95f, distance = 1.86f, elevation = 5.55f, down = 0.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 111.25f, distance = 7.27f, elevation = 5.18f, down = 2.0f, up = 1.0f, right = 10.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 108.4f, distance = 6.59f, elevation = 4.94f, down = 0.5f, up = 2.0f, right = 10.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 103.4f, distance = 3.22f, elevation = 5.01f, down = 0.0f, up = 1.0f, right = 3.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 96.1f, distance = 9.21f, elevation = 5.46f, down = 0.0f, up = 1.0f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 58.5f, distance = 7.29f, elevation = 5.67f, down = 0.0f, up = 1.0f, right = 10.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 59.85f, distance = 6.05f, elevation = 5.66f, down = 0.5f, up = 0.5f, right = 5.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 72.7f, distance = 1.9f, elevation = 5.76f, down = 0.0f, up = 1.0f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 101.65f, distance = 10.67f, elevation = 5.88f, down = 0.0f, up = 0.7f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 82.9f, distance = 13.98f, elevation = 5.85f, down = 0.5f, up = 1.0f, right = 20.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 118.9f, distance = 3.84f, elevation = 5.21f, down = 1.0f, up = 1.0f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 150.15f, distance = 7.64f, elevation = 5.01f, down = 1.0f, up = 1.0f, right = 10.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 123.35f, distance = 7.19f, elevation = 4.34f, down = 0.0f, up = 5.0f, right = 15.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 116.95f, distance = 1.99f, elevation = 4.28f, down = 0.0f, up = 6.0f, right = 17.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 95.45f, distance = 27.23f, elevation = 2.84f, down = 0.0f, up = 15.0f, right = 20.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 137.3f, distance = 7.06f, elevation = 2.42f, down = 0.0f, up = 15.0f, right = 40.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 89.75f, distance = 2.09f, elevation = 1.95f, down = 0.0f, up = 10.0f, right = 2.0f, left = 2.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 79.65f, distance = 2.11f, elevation = 1.74f, down = 1.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 82.65f, distance = 5.33f, elevation = 1.28f, down = 1.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 78.8f, distance = 3.58f, elevation = 1.22f, down = 1.0f, up = 3.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 117.15f, distance = 4.52f, elevation = 1.88f, down = 1.0f, up = 1.0f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 83.15f, distance = 3.78f, elevation = 1.91f, down = 2.0f, up = 1.0f, right = 1.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 69.85f, distance = 6.46f, elevation = 2.36f, down = 0.0f, up = 1.0f, right = 15.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 76.05f, distance = 6.13f, elevation = 3.24f, down = 0.0f, up = 1.0f, right = 20.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 77.9f, distance = 6.92f, elevation = 3.88f, down = 0.0f, up = 1.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 105.9f, distance = 10.99f, elevation = 4.05f, down = 0.0f, up = 1.0f, right = 0.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 113.25f, distance = 0.91f, elevation = 4.04f, down = 0.0f, up = 1.0f, right = 3.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 87.8f, distance = 5.39f, elevation = 4.51f, down = 5.0f, up = 1.0f, right = 5.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 81.75f, distance = 3.93f, elevation = 5.83f, down = 1.0f, up = 1.0f, right = 5.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 79.45f, distance = 3.58f, elevation = 5.97f, down = 0.0f, up = 1.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 139.95f, distance = 8.01f, elevation = 4.92f, down = 0.0f, up = 2.0f, right = 3.0f, left = 2.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 120.75f, distance = 9.66f, elevation = 5.18f, down = 0.0f, up = 1.0f, right = 10.0f, left = 1.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 72.25f, distance = 8.49f, elevation = 5.56f, down = 0.0f, up = 1.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 69.9f, distance = 5.89f, elevation = 5.87f, down = 0.0f, up = 2.0f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 65.1f, distance = 3.31f, elevation = 6.43f, down = 0.0f, up = 2.0f, right = 10.0f, left = 10.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 56.45f, distance = 6.49f, elevation = 7.03f, down = 0.0f, up = 2.0f, right = 20.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 103.05f, distance = 5.52f, elevation = 7.26f, down = 0.0f, up = 2.0f, right = 3.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 127.9f, distance = 7.72f, elevation = 6.63f, down = 0.0f, up = 2.0f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 135.55f, distance = 3.97f, elevation = 6.0f, down = 0.0f, up = 1.0f, right = 10.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 113.35f, distance = 1.59f, elevation = 5.52f, down = 0.0f, up = 1.0f, right = 5.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 116.6f, distance = 1.76f, elevation = 5.7f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 115.15f, distance = 19.76f, elevation = 5.14f, down = 0.0f, up = 1.0f, right = 2.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 96.45f, distance = 9.09f, elevation = 5.17f, down = 0.0f, up = 2.0f, right = 1.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 45.7f, distance = 7.83f, elevation = 6.12f, down = 0.0f, up = 2.0f, right = 2.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 78.8f, distance = 2.5f, elevation = 6.38f, down = 1.0f, up = 2.0f, right = 0.0f, left = 3.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 92.4f, distance = 5.35f, elevation = 6.23f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 34.5f, distance = 4.69f, elevation = 6.27f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 111.45f, distance = 15.9f, elevation = 6.85f, down = 0.0f, up = 2.0f, right = 5.0f, left = 5.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 196.4f, distance = 0.52f, elevation = 6.86f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 179.35f, distance = 2.96f, elevation = 6.23f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 152.8f, distance = 5.43f, elevation = 4.95f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 143.8f, distance = 3.25f, elevation = 3.98f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 205.0f, distance = 1.61f, elevation = 3.45f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 163.9f, distance = 2.73f, elevation = 4.06f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 126.25f, distance = 1.86f, elevation = 4.14f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 128.5f, distance = 4.69f, elevation = 4.37f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 125.65f, distance = 14.2f, elevation = 5.56f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 136.9f, distance = 12.16f, elevation = 5.46f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 130.55f, distance = 4.81f, elevation = 5.53f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 156.0f, distance = 1.72f, elevation = 5.3f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 159.15f, distance = 5.39f, elevation = 4.61f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 188.0f, distance = 3.29f, elevation = 3.34f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 188.65f, distance = 2.25f, elevation = 1.67f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 249.45f, distance = 3.86f, elevation = 0.58f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 104.65f, distance = 3.35f, elevation = 1.44f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 118.2f, distance = 4.38f, elevation = 2.09f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 74.15f, distance = 10.41f, elevation = 2.61f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 92.2f, distance = 6.98f, elevation = 2.77f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 183.85f, distance = 12.1f, elevation = 1.39f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 160.9f, distance = 7.77f, elevation = 2.24f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 128.4f, distance = 10.34f, elevation = 3.39f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 206.15f, distance = 4.59f, elevation = 3.47f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });
        stickMapData.Add(new HeadingDistanceElevation { headingDegrees = 83.75f, distance = 4.38f, elevation = 3.42f, down = 0.0f, up = 0.0f, right = 0.0f, left = 0.0f });

        return stickMapData;
    }

}

