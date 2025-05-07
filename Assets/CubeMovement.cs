//using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;

public class CubeMovement : MonoBehaviour
{
    public float cubeSpeed = 1.0f;
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //Quaternion Stuff
        Quaternion zRotate = Quaternion.Euler(0, Random.Range(-45f,45f), 0); //Random range from -45 to 45 on z axis
        Vector3 Direction = zRotate * new Vector3((Random.Range(1, 3) == 1 ? cubeSpeed : -cubeSpeed), 0, 0);
        rb.linearVelocity = Direction;
        
        //Vector Stuff
        //Vector3 Direction = new Vector3((Random.Range(1, 3) == 1 ? 1 : -1), 0, Random.Range(-1f, 2f)).normalized;
        //rb.linearVelocity = Direction*cubeSpeed;
    }

    void FixedUpdate()
    {
        //Check for WallBounce
        //If found then reverse z direction while maintain x direction and speed



    }
}
