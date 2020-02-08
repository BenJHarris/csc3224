using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Experimental.Rendering.Universal;

public class PointLightPulse : MonoBehaviour
{

    public Light2D pointLight;

    public void Update()
    {
        pointLight.pointLightOuterRadius = 1 + 3  * Mathf.Abs(Mathf.Sin(Time.time));
    }
}
