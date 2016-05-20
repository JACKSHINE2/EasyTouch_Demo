using UnityEngine;
using System.Collections;

public class MyFirstTouch : MonoBehaviour
{
    public void OnDestroy ()
    {
        EasyTouch.On_TouchStart -= On_TouchStart;
    }

    void Init ()
    {
        //EasyTouch.AddCamera (GameObject.FindGameObjectWithTag ("CameraShade").GetComponent<Camera>(), false);
        //EasyTouch.AddCamera (GameObject.FindGameObjectWithTag ("MainCamera").GetComponent<Camera>(), false);
    }

    public void OnEnable ()
    {
        Init ();
        EasyTouch.On_TouchStart += On_TouchStart;
    }

    public void OnDisable ()
    {
        EasyTouch.On_TouchStart -= On_TouchStart;
    }

    public void On_TouchStart (Gesture gesture)
    {
        if (gesture.pickedObject == null)
        {
            return;
        }
 
        Debug.Log ("Touch in pickedObject.name = " + gesture.pickedObject.name);
    }
}
