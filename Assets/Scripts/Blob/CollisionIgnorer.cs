using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionIgnorer : MonoBehaviour
{
    public GameObject col1;
    public GameObject col2;
    public GameObject col3;
    public GameObject col4;
    public GameObject col5;
    public GameObject col6;
    public GameObject col7;
    public GameObject col8;

    private void Awake()
    {

    }

    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
        if (collision.gameObject == gameObject)
        {
            Debug.Log("Ignoring Collision");
            Physics.IgnoreCollision(col1.GetComponent<Collider>(), collision.collider, true);
            Physics.IgnoreCollision(col2.GetComponent<Collider>(), collision.collider, true);
            Physics.IgnoreCollision(col3.GetComponent<Collider>(), collision.collider, true);
            Physics.IgnoreCollision(col4.GetComponent<Collider>(), collision.collider, true);
            Physics.IgnoreCollision(col5.GetComponent<Collider>(), collision.collider, true);
            Physics.IgnoreCollision(col6.GetComponent<Collider>(), collision.collider, true);
            Physics.IgnoreCollision(col7.GetComponent<Collider>(), collision.collider, true);
            Physics.IgnoreCollision(col8.GetComponent<Collider>(), collision.collider, true);
        }
    }
}
