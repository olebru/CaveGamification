using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SegmentController : MonoBehaviour
{
    MapRenderer renderer;
    void Start()
    {
        renderer = new MapRenderer(0.07f);
        renderer.PlotLeg(MockData.GetMassagedSampleData(), Color.yellow);


    }
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
            renderer.ShowInside(true);

        if (Input.GetKey(KeyCode.K))
            renderer.ShowInside(false);
        if (Input.GetKey(KeyCode.O))
            renderer.ShowOutSide(true);

        if (Input.GetKey(KeyCode.L))
            renderer.ShowOutSide(false);
    }
}
