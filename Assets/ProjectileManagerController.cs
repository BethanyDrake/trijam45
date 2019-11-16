using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileManagerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }


    private float timeSinceLastFired = 0;
    public float fireRechargeTime;
    public float thrust;
    public GameObject cannon;
    public float maxRotation;

    public GameObject phone;
    // Update is called once per frame
    void Update()
    {
       timeSinceLastFired = timeSinceLastFired + Time.deltaTime;

        if (Input.GetButton("Fire1") && timeSinceLastFired > fireRechargeTime)
        {
            timeSinceLastFired = 0;
            GameObject newPhone = Instantiate(phone, cannon.transform.position, cannon.transform.rotation) as GameObject;
            Rigidbody rb = newPhone.GetComponent(typeof(Rigidbody)) as Rigidbody;

            Debug.Log(newPhone.transform.forward);
            rb.AddForce(newPhone.transform.forward * thrust);
            rb.AddTorque((new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f) )) * maxRotation);
        }
    }
}
