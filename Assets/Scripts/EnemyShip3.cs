using UnityEngine;
using System.Collections;

public class EnemyShip3 : EnemyShip {
    
    

    protected override Vector3 movement()
    {
        if (dir.x > 0 && transform.position.x > m_xMaxLim)
        {
            dir.y = dir.x * (-1);
            dir.x = 0;
        }
        else if (dir.y < 0 && transform.position.y < m_yMin)
        {
            dir.x = dir.y;
            dir.y = 0;

        }
        else if (dir.x < 0 && transform.position.x < m_xMinLim)
        {
            dir.y = 1;
            dir.x = 0;
        }
        else if (dir.y > 0 && transform.position.y > m_yMax)
        {
            dir.x = dir.y;
            dir.y = 0;
            
        }
        return dir;
    }



}
