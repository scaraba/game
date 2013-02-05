using UnityEngine;
using System.Collections;

public class ReflectBullet : Bullet {

    public Bullet m_bullet1;

    public override void setDirection(Vector3 dir)
    {
       m_bullet1.m_fireDir.y = m_bullet1.m_fireDir.y * -1;
       m_bullet1.m_fireDir.x = m_bullet1.m_fireDir.x * -1;
    }


    void reflectBullet(Bullet b)
    {

        b.gameObject.tag = gameObject.tag;
    }

}
