using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV, torqy;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torqy);
        }
        
        else if (Input.GetKeyDown(KeyCode.F))
        {
            rb.angularVelocity = Vector3.zero;
        }
        
    }
}
