using UnityEngine;
using System.Collections;

public class EnemyShip2 : EnemyShip {


    protected override Vector3 movement()
    {        
        if (transform.position.y < m_yMin)
        {
            Destroy(gameObject);
        }
        return dir;

    }




}
