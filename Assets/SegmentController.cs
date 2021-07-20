using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SegmentController : MonoBehaviour
{

    void Start()
    {
        var renderer = new MapRenderer(0.01f);
        renderer.PlotLeg(MockData.GetMassagedSampleData(), Color.yellow);


    }
    void Update()
    {

    }
}
