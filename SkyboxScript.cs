using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxScript : MonoBehaviour
{

    void Start()
    {
        
    }


    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * 1f);
    }
}