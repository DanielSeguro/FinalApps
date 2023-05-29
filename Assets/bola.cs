
using UnityEngine;

public class bola : MonoBehaviour
{
   
   [SerializeField] private float initialVelocity = 4f;

   [SerializeField] private float velocitymultiplier = 1.1f;

   private Rigidbody2D bola1;


    void Start()
    {
        bola1 = GetComponent<Rigidbody2D>();
        Launch();
    }
    
    private void Launch()
    {
        float velocidadx = Random.Range(0,2) == 0 ? 1 : -1;
        float velocidady = Random.Range(0,2) == 0 ? 1 : -1;
        bola1.velocity = new Vector2(velocidadx, velocidady) * initialVelocity;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Paleta"))
        {
            bola1.velocity *= velocitymultiplier;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Goal1"))
        {
                GameManager.Instance.paleta2puntua();
                GameManager.Instance.Restart();
                Launch();
        }
        else
        {
            GameManager.Instance.paleta1puntua();
              GameManager.Instance.Restart();
              Launch();
        }
    }
     
   
}
