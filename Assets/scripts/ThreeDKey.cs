using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class ThreeDKey : MonoBehaviour {

    public UnityEvent OnMouseDownEvent = new UnityEvent();
    public UnityEvent OnMouseUpEvent = new UnityEvent();

    private Light light;

    // Use this for initialization
    void Start () {
        light = GetComponent<Light>();
        light.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("oi");
        OnMouseDownEvent.Invoke();
        light.enabled = true;
    }

    void OnMouseUp()
    {
        Debug.Log("oi");
        OnMouseUpEvent.Invoke();
        light.enabled = false;
    }

}