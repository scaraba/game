using UnityEngine;
using System.Collections;

public class BulletShield: Bullet
	{

    public Bullet m_bullet1, m_bullet2, m_bullet3, m_bullet4, m_bullet5, m_bullet6;


    public override void setDirection(Vector3 dir)
    {
        m_bullet1.m_fireDir.y = dir.y * m_bullet1.m_fireDir.y;
        m_bullet2.m_fireDir.y = dir.y * m_bullet2.m_fireDir.y;
        m_bullet3.m_fireDir.y = dir.y * m_bullet3.m_fireDir.y;
        m_bullet4.m_fireDir.y = dir.y * m_bullet4.m_fireDir.y;
        m_bullet5.m_fireDir.y = dir.y * m_bullet5.m_fireDir.y;
        m_bullet6.m_fireDir.y = dir.y * m_bullet6.m_fireDir.y;

    }


    void Start()
    {
        setupBullet(m_bullet1);
        setupBullet(m_bullet2);
        setupBullet(m_bullet3);
        setupBullet(m_bullet4); 
        setupBullet(m_bullet5); 
        setupBullet(m_bullet6); 
   
    
    
    }


    void setupBullet(Bullet b)
    {
        b.m_Damage = m_Damage;
        b.m_Distance = m_Distance;
        b.m_Speed = m_Speed;
        b.gameObject.tag = gameObject.tag;

    }


	}

