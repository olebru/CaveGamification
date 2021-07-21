using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SegmentController : MonoBehaviour
{
    MapRenderer maprenderer;
    void Start()
    {
        maprenderer = new MapRenderer(0.07f);
        maprenderer.PlotLeg(MockData.GetMassagedSampleData(), Color.yellow);


    }
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
            maprenderer.ShowInside(true);

        if (Input.GetKey(KeyCode.K))
            maprenderer.ShowInside(false);
        if (Input.GetKey(KeyCode.O))
            maprenderer.ShowOutSide(true);

        if (Input.GetKey(KeyCode.L))
            maprenderer.ShowOutSide(false);
    }
}
