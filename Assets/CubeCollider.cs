using UnityEngine;

public class CubeCollider : MonoBehaviour
{
    void OnCollisionEnter (Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "WallBounce")
        {
           Debug.Log("HitWall");
        }
    }
}
