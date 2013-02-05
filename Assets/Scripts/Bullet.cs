using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour {

    public int m_Damage;
    public float m_Distance;
    public float m_Speed;
    public Vector3 m_fireDir;
    
       
    

    public virtual void setDirection(Vector3 dir) 
    {
        m_fireDir = dir;
    }

	
	// Update is called once per frame
	void Update () {
        if (m_Distance > 0){
            float d = m_Speed * Time.deltaTime;
           m_Distance = m_Distance - d;

            rigidbody.MovePosition(transform.position + (m_fireDir * d));
//            rigidbody.MovePosition((m_fireDir * d));
        }else{
            Destroy(gameObject);
        }
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != gameObject.tag)
        {
            Ship s = (Ship)other.gameObject.GetComponent<Ship>();
            if (s != null)
            {
                s.m_health = s.m_health - m_Damage;
            }
            else
            {
                Bullet b = (Bullet)other.gameObject.GetComponent<Bullet>();
                if (b != null)
                {
                    b.setDirection(m_fireDir * -1);
                    //Destroy(b.gameObject);
                }
            }
            Destroy(gameObject);
        }
    }
}