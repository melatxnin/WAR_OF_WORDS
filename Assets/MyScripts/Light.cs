using UnityEngine;

public class LightCycle : MonoBehaviour
{
    private Renderer rend;
    private Transform transf;
    

    void Start()
    {

    }

    void Update()
    {
        float hauteur = transf.position.y;
        float t = Mathf.InverseLerp(0, 10f, hauteur);
        rend.material.color = Color.Lerp(Color.green, Color.red, t);
    }
}