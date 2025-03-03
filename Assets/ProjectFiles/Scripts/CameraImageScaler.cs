using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UIElements;

public class CameraImageScaler : MonoBehaviour
{
	public Camera MainCamera;
	public GameObject Background;
	
	
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float height = 2f * MainCamera.orthographicSize;
		float width = height * MainCamera.aspect;
		Background.transform.localScale = new Vector2(width, height);
    }
}