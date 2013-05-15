using UnityEngine;
using System.Collections;

public class character : MonoBehaviour {
    public GameObject bullet;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject go = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
	}
}
