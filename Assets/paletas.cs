using UnityEngine;

public class paletas : MonoBehaviour
{
    [SerializeField] private float speed = 7f;
    [SerializeField] private bool paleta1;
    private float yBound = 3.75f;
 
    void Update()
    {
        float movement;

        if (paleta1){
            movement = Input.GetAxisRaw("Vertical");
           
        }
        else {
             movement = Input.GetAxisRaw("Vertical2");
        }
        
        Vector2 paddleposition = transform.position;
        paddleposition.y = Mathf.Clamp(paddleposition.y + movement * speed * Time.deltaTime, -yBound, yBound);
        transform.position = paddleposition;
    }
}
