using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public Button forward, backward, left, right, positionButton, rotationButton, scaleUpButton, scaleDownButton;

    public GameObject gameObject;
    private float movingSpeed = 200.0f;

    private bool isPositioning = false;

    private Vector3 scaleVector;
    private float scaleFactor = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        scaleVector = new Vector3(scaleFactor, scaleFactor, scaleFactor);
        right.onClick.AddListener(RightButtonClicked);
        left.onClick.AddListener(LeftButtonClicked);
        forward.onClick.AddListener(ForwardButtonClicked);
        backward.onClick.AddListener(BackwardButtonClicked);
        positionButton.onClick.AddListener(PositionButtonClicked);
        rotationButton.onClick.AddListener(RotationnButtonClicked);
        scaleUpButton.onClick.AddListener(ScaleUpClicked);
        scaleDownButton.onClick.AddListener(ScaleDownClicked);

    }
    // Update is called once per frame
    void Update()
    {
    
    }
    
    void RightButtonClicked() {
        if (isPositioning == true)
        {
    	gameObject.transform.Translate(Vector3.right * movingSpeed * Time.deltaTime);
    	return;
        }
        else
        {
    	gameObject.transform.Rotate(Vector3.down * movingSpeed * Time.deltaTime);
    	return;
        }
    }
    
    void LeftButtonClicked() {
        if (isPositioning == true)
        {
    	gameObject.transform.Translate(Vector3.left * movingSpeed * Time.deltaTime);
    	return;
        }
        else
        {
    	gameObject.transform.Rotate(Vector3.up * movingSpeed * Time.deltaTime);
    	return;
        }
    }
    void ForwardButtonClicked() {
        Debug.Log("forward");
        if (isPositioning == true)
        {
    	gameObject.transform.Translate(Vector3.forward * movingSpeed * Time.deltaTime);
    	return;
        }
        else
        {
    	return;
        }
    }
    
    void BackwardButtonClicked() {
        Debug.Log("backward");
        if (isPositioning == true)
        {
    	gameObject.transform.Translate(Vector3.back * movingSpeed * Time.deltaTime);
    	return;
        }
        else
        {
    	return;
        }
    }
    
    void PositionButtonClicked() {
        isPositioning = true;
    }
    
    void RotationnButtonClicked() {
        isPositioning = false;
    }
    
    void ScaleUpClicked() {
        gameObject.transform.localScale += scaleVector;
    }
    
    void ScaleDownClicked() {
        gameObject.transform.localScale -= scaleVector;
	}
}
