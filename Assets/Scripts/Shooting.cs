using UnityEngine;

public class Shooting : MonoBehaviour
{
    private void Update()
    {
        var position = transform.position; 
        RaycastHit2D raycastHit = Physics2D.Raycast(position, Vector2.up);
        Debug.DrawRay(position, Vector3.up * 5, Color.green); //   Vector3.up => transform.up
        
        if (raycastHit)
        {
            Destroy(raycastHit.collider.gameObject);
        }
    }
}
