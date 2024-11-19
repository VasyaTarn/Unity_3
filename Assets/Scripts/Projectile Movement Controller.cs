using UnityEngine;

public class ProjectileMovementController : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float speed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Point"))
        {
            Destroy(collision.gameObject);
            GameManger.Instance.addScore(1);
        }

        Destroy(gameObject);
    }

    private void Update()
    {
        rb.velocity = transform.forward * speed;
    }
}
