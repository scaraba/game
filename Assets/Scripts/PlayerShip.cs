using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerShip : Ship {
    /*
	// Use this for initialization
	void Start () {
        base.Start();
	}
     */
	
	// Update is called once per frame
	new void Update () {
        base.Update();
        Vector3 newPosition = new Vector3();
        /*if (Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.y = newPosition.y + (m_speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPosition.y = newPosition.y - (m_speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x = newPosition.x - (m_speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x = newPosition.x + (m_speed);
        }
        */
       
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            newPosition.y = newPosition.y + (Time.deltaTime * m_speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            newPosition.y = newPosition.y - (Time.deltaTime * m_speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            newPosition.x = newPosition.x - (Time.deltaTime * m_speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            newPosition.x = newPosition.x + (Time.deltaTime * m_speed);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            fire();
        }
        m_charControl.Move(newPosition);
	}
}