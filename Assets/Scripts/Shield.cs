using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {
    
    
    public int m_shieldhealth;
    public int m_bulletnegate;
    public int m_damage;
    public Ship m_ship;


    void Start()
    {
        gameObject.transform.parent = m_ship.gameObject.transform;
    
    
    }

     
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag != gameObject.tag )
        {
            Ship s = (Ship)col.GetComponent<Ship>();
            Bullet b = (Bullet)col.GetComponent<Bullet>();

            if (s != null)
            {
                s.m_health = s.m_health - m_damage; 
            
            
            }

            else if(b != null)
            {
                m_shieldhealth -= b.m_Damage;
                m_ship.m_health -= b.m_Damage - m_bulletnegate;
                DestroyImmediate(b.gameObject);
            }

            if (m_shieldhealth < 0)
            {
                DestroyImmediate(gameObject);
            
            
            }
        }

    
    }
}
