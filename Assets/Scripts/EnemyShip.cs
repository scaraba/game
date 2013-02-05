using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class EnemyShip : Ship {

    public float m_xMaxLim;
    public float m_xMinLim;
    public float m_yMin;
    public float m_yMax;
    public GameObject m_powerUp;

    public Vector3 dir=new Vector3(-.5f,.5f,0f);


	// Update is called once per frame
	new void Update () {
        base.Update();
        fire();
        
		m_charControl.Move(movement()*Time.deltaTime*m_speed);
	}
    protected virtual Vector3 movement(){
        if(dir.x>0 && transform.position.x>m_xMaxLim){
                dir.x=dir.x*(-1);
        }
        else if(dir.x<0 && transform.position.x<m_xMinLim){
                dir.x=dir.x*(-1);
        }
        if (transform.position.y < m_yMin){
            Destroy(gameObject);
        }
        return dir;
    }
    public void OnDestroy()
    {
        if (m_powerUp != null)
        {
            Instantiate(m_powerUp, transform.position, Quaternion.identity);
            
        }

    }


}
