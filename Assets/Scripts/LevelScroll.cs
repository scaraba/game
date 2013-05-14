using UnityEngine;
using System.Collections;

public class LevelScroll : MonoBehaviour {

    public float scrollRate;
    public static float distanceTraveled;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0f, scrollRate * Time.deltaTime, 0f);
        distanceTraveled = transform.localPosition.y;
    }
}
