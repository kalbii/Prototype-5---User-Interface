using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private Rigidbody targetRB;

    private float minSpeed = 10;
    private float maxSpeed = 12;
    private float minTorque = 650;
    private float maxTorque = 1200;

    private Skeleton SkeletonEnemy;

    // Start is called before the first frame update
    void Start()
    {
        targetRB = GetComponent<Rigidbody>();
        targetRB.AddForce(RandomForce(), ForceMode.Impulse);
        targetRB.AddTorque(RandomTorque(), Random.Range(-10, 10), Random.Range(-10, 10), ForceMode.Impulse);
        transform.position = new Vector3(Random.Range(116, 108), 102.94f, 117);

        SkeletonEnemy = GameObject.Find("Skeleton").GetComponent<Skeleton>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(minTorque, maxTorque);
    }

    private void OnMouseDown()
    {
        //Destroy(gameObject);
        SkeletonEnemy.SkeletonDeath();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
