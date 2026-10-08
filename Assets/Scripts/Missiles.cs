using UnityEngine;

public class Missile : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    public float lifetime = 5f;

    float lifespan;

    void Start()
    {
    player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Lifetime
        lifespan += Time.deltaTime;
        if (lifespan >= lifetime) 
        { 
            Destroy(gameObject); 
            return; 
        }
        
        if (player == null) return;

        // look at player
        Vector3 dir = player.position - transform.position;
        Quaternion targetRot = Quaternion.LookRotation(Vector3.forward, dir);

        // Slerp rotate towards player
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, 5f * Time.deltaTime);

        // Move forward
        transform.Translate(Vector2.up * speed * Time.deltaTime, Space.Self);

        // destroy on contact calls function for lose 
        if (Vector2.Distance(transform.position, player.position) < 1f)
        {
            player.GetComponent<PlayerHealth>().TakeHit();
            Destroy(gameObject);
        }
            
    }
}