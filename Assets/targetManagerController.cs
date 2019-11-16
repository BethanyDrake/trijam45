using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetManagerController : MonoBehaviour
{

    public GameObject phone;
    public GameObject cannon;
    public float maxDistance;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddNewTarget() {


        Vector3 newPosition = (new Vector3(Random.Range(-1.0f, 1.0f), 0.7f, Random.Range(-1.0f, 1.0f) )) * maxDistance;

        GameObject newTarget = Instantiate(phone, newPosition, Quaternion.identity ) as GameObject;
        newTarget.transform.Rotate(90f, 0f, 0f);
    }

    private float timeSinceLastNewTarget = 0;
    public float targetRechargeTime;

    // Update is called once per frame
    void Update()
    {
        timeSinceLastNewTarget = timeSinceLastNewTarget + Time.deltaTime;
        if (Input.GetButton("Fire1") && timeSinceLastNewTarget > targetRechargeTime)
    {
        timeSinceLastNewTarget = 0;
        AddNewTarget();
    }

    }
}
