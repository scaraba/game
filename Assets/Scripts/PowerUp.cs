using UnityEngine;
using System.Collections;

public class PowerUp : MonoBehaviour {

    public int m_health;
    public GameObject m_bullet;
    public float m_speed;
    public int m_damage;
    public float m_bulletSpeed;
    public float m_fireRate;
    public float m_range;



    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            PlayerShip ship = (PlayerShip)col.gameObject.GetComponent<PlayerShip>();
            if (ship != null)
            {
                
                ship.m_health += m_health;
                ship.m_speed += m_speed;
                ship.m_fireRate -= m_fireRate;
                ship.m_fireRate = Mathf.Max(0, ship.m_fireRate);
                ship.m_range += m_range;
                ship.m_damage += m_damage;

                if (m_bullet != null)
                {
                    ship.m_bullet = m_bullet;
                
                }

                Destroy(gameObject);
            }
            else
            {
               // Debug.LogError("Object Tagged Player does not have a PlayerShip!!!");
            
            }

        }

        
    }
	
}
