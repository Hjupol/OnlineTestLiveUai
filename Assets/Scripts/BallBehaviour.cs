using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class BallBehaviour : NetworkBehaviour
{
    public Rigidbody rb;
    public Transform position;
    public Rigidbody gameObject;

    public void Awake()
    {
        rb.detectCollisions = false;
    }

    
    public override void OnStartServer()
    {
        base.OnStartServer();
        gameObject=Instantiate(rb, position);
        gameObject.detectCollisions = true;
    }

    [ServerCallback]
    void OnCollisionEnter(Collision col)
    {
        //Do something...
    }
    
    
    //public override void OnNetworkDestroy()
    //{
    //    Destroy(gameObject);
    //    base.OnNetworkDestroy();
    //}
}
