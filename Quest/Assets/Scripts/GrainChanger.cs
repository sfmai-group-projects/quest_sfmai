using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class GrainChanger : MonoBehaviour
{
    public Grain grain;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            grain.intensity = new FloatParameter { value = 10  };
        }
    }
}
