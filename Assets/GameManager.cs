using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TMP_Text paleta1puntajetext;
    [SerializeField] private TMP_Text paleta2puntajetext;

    [SerializeField] private Transform paletatransform;
    [SerializeField] private Transform paleta2transform;
    [SerializeField] private Transform bolatransform;

    private int paleta1puntaje;
    private int paleta2puntaje;


    private static GameManager instance;

    public static GameManager Instance
    {
        get 
        {
            if(instance == null)
            {
                instance = FindObjectOfType<GameManager>();
            }
            return instance;
        }
    }
    public void paleta1puntua(){
        paleta1puntaje++;
        paleta1puntajetext.text = paleta1puntaje.ToString();
    }
      public void paleta2puntua(){
        paleta2puntaje++;
        paleta2puntajetext.text = paleta2puntaje.ToString();
    }
    public void Restart()
    {
        paletatransform.position = new Vector2(paletatransform.position.x,0);
        paleta2transform.position = new Vector2(paleta2transform.position.x,0);
        bolatransform.position = new Vector2(0,0);
    }

}
