using UnityEngine;

public class MagnusEffect : MonoBehaviour
{
    Rigidbody rb; 
    [SerializeField] Vector3 velocity, spin;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //kick
            Kick();
        }
        //apply magnus fx
        Magnus();
    }
    void Magnus()
    {
        Vector3 magnusForce = Vector3.Cross(rb.linearVelocity, rb.angularVelocity);
        
        rb.AddForce(magnusForce, ForceMode.Force); //.Impulse จะส่งแรงเป็นระลอกๆ
    }
    void Kick()
    {
        rb.linearVelocity = velocity; //LinearKick
        rb.angularVelocity = spin; //AngularKick
    }

}
