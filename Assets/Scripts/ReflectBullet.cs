using UnityEngine;
using System.Collections;

public class ReflectBullet : Bullet {

    protected override void Attack(GameObject go){
        Debug.Log("Reflecting");
        Ship s = (Ship)go.GetComponent<Ship>();
        if (s != null)
        {
            s.m_health = s.m_health - m_Damage;
        }
        else
        {
            Bullet b = (Bullet)go.GetComponent<Bullet>();
            if (b != null)
            {
                b.m_fireDir = b.m_fireDir*(-1);
                b.gameObject.tag = gameObject.tag;
            }
        }
    }

}
