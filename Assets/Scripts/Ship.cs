using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public abstract class Ship : MonoBehaviour {
    //these allow you to customize the ships in the editor
    public int m_health;
    public GameObject m_bullet;
    public float m_speed;
    public int m_damage;
    public float m_bulletSpeed;
    public float m_fireRate;
    public Vector3 m_fireDir;
    public float m_range;

    //new things for level initiation
    private Vector3 startPos;
    public static float distanceTravelled;


    //these are internal that will never need to be exposed
    private float m_fireTimer;
    protected CharacterController m_charControl;

    //All ship types will probably need these functions
	// Use this for initialization
	public virtual void Start () {

        StartGame.GameStart += GameStart;
        StartGame.GameOver += GameOver;
        m_charControl = (CharacterController)gameObject.GetComponent<CharacterController>();
        m_fireDir.Normalize();
	}
	
	// Update is called once per frame
	public virtual void Update () {
        //checking to see if the ship is still afloat
        if (m_health < 1){
            Destroy(gameObject);
            StartGame.TriggerGameOver();
        }
        //keeping a timer for shot refreshing
        if (m_fireTimer > 0)
            m_fireTimer = m_fireTimer - Time.deltaTime;
	}
    private void GameStart()
    {
        distanceTravelled = 0f;
        transform.localPosition = startPos;
        rigidbody.isKinematic = false;
        gameObject.active = true;
        enabled = true;
    }

    private void GameOver()
    {
        //rigidbody.isKinematic = true;
        enabled = false;
    
    
    }

    void fireTouch()
    { 
    
    
    }

    public virtual void fire()
    {
        //Debug.Log("m_fireTimer" + m_fireTimer);
        //setting up the bullet with a number properties that are based on the ship type
        if (m_fireTimer <= 0){
            m_fireTimer = m_fireRate;
            GameObject go = (GameObject)Instantiate(m_bullet, (transform.position+m_fireDir*transform.localScale.magnitude), Quaternion.identity);
            Bullet b = (Bullet)go.GetComponent<Bullet>();
            
            
            if (b != null)
            {
                b.m_Damage = m_damage;
                b.setDirection(m_fireDir);
                //b.m_fireDir = m_fireDir;
                b.m_Distance = m_range;
                b.m_Speed = m_bulletSpeed;
                go.tag = gameObject.tag;
                
            }
         }
    }
}
