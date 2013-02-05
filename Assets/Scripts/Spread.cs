using UnityEngine;
using System.Collections;

public class Spread : Bullet {
    public Bullet m_bullet1;
    public Bullet m_bullet2;
    public Bullet m_bullet3;


    public override void setDirection(Vector3 dir)
    {
        m_bullet1.m_fireDir.y = dir.y * m_bullet1.m_fireDir.y;
        m_bullet2.m_fireDir.y = dir.y * m_bullet2.m_fireDir.y;
        m_bullet3.m_fireDir.y = dir.y * m_bullet3.m_fireDir.y;
        
    }


	// Use this for initialization
	void Start () 
    {
        setupBullet(m_bullet1);
        setupBullet(m_bullet2);
        setupBullet(m_bullet3);

	}


    void setupBullet(Bullet b)
    {
        b.m_Damage = m_Damage;
        b.m_Distance = m_Distance;
        b.m_Speed = m_Speed;
        b.gameObject.tag = gameObject.tag;
    }
	

}
