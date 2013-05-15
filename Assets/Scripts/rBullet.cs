using UnityEngine;
using System.Collections;

  [RequireComponent(typeof(Rigidbody))]
public class rBullet : MonoBehaviour {
  
    
    public GameObject bullet;
    public float speed;
    public float m_maxDistance;
    public float damage;

    void Start()
    { 
    
    }


    void Update()
    {
  

    GameObject go = (GameObject)Instantiate(bullet, transform.position, transform.rotation);
    rigidbody.MovePosition(rigidbody.position + transform.forward * Time.deltaTime * speed);
   
    }
}
