using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movewithcamera : MonoBehaviour
{
    private GameObject _sphere;
    private GameObject _camera;

    void Start()
    {
        _sphere = GameObject.Find("Sphere");
        _camera = GameObject.FindWithTag("MainCamera");
    }

    void Update()
    {
        this.transform.position = _sphere.transform.position;
    }
}
