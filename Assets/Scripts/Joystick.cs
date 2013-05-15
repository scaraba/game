using UnityEngine;
using System.Collections;

public class Joystick : MonoBehaviour {
    [RequireComponent(typeof(GUITexture))]

    class Boundary
    {
    Vector2 min = Vector2.zero;
    Vector2 max = Vector2.zero;
    }

    //static private Joystick joysticks[];
    static private bool enumeratedJoysticks = false;
    static private float tapTimeDelta = 0.3f;

    bool touchPad;
    Rect touchZone;
    Vector2 deadZone = Vector2.zero;
    bool normalize = false;
    Vector2 position;
    int tapCount;

    private int lastFingerId = 1;
    private float tapTimeWindow;
    private Vector2 fingerDownPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
