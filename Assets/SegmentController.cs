using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class SegmentController : MonoBehaviour
{

    void Start()
    {
        var renderer = new MapRenderer(0.03f);
        renderer.PlotLeg(MockData.GetMassagedJOData(), Color.yellow);
        renderer.PlotLeg(MockData.GetJOData(), Color.blue, "Tilfeldig");

    }
    void Update()
    {

    }
}
