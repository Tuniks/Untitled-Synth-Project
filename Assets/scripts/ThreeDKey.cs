using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class ThreeDKey : MonoBehaviour {

    public UnityEvent OnMouseDownEvent = new UnityEvent();
    public UnityEvent OnMouseUpEvent = new UnityEvent();

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
        Debug.Log("oi");
        OnMouseDownEvent.Invoke();
    }

    void OnMouseUp()
    {
        Debug.Log("oi");
        OnMouseUpEvent.Invoke();
    }

}