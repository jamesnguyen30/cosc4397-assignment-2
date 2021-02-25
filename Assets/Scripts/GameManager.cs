using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Slider rotateSlider;
    public Slider scaleSlider;

    private float newRotation = 0.0f;
    private float scaleValue = 0.0f;

    public GameObject gameObject;
    // private float movingSpeed = 200.0f;

    private bool isPositioning = false;

    private Vector3 scaleVector;
    private float scaleFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        scaleVector = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        scaleSlider.maxValue = 20.0f;
        scaleSlider.minValue = 1.0f;

        rotateSlider.maxValue = 360f;
        rotateSlider.minValue = 0f;
    }
    // Update is called once per frame
    void Update()
    {
        RotationUpdate();
        ScaleUpdate();
    }

    void RotationUpdate()
    {
        gameObject.transform.eulerAngles = new Vector3(
            gameObject.transform.eulerAngles.x,
            rotateSlider.value,
            gameObject.transform.eulerAngles.x
        );
    }

    void ScaleUpdate()
    {
        gameObject.transform.localScale = new Vector3(
            scaleSlider.value,            
            scaleSlider.value,            
            scaleSlider.value            
        );
    }
  
    
}
