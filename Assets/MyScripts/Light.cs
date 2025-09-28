using UnityEngine;

public class LightCycle : MonoBehaviour
{
    private Renderer rend;
    
    [SerializeField] private Color[] colors = 
    {
        Color.green, 
        Color.black, 
        Color.blue, 
        Color.gray, 
        Color.yellow, 
        Color.red
    };

    [SerializeField] private float duration = 1f;
    
    private int index = 0;
    private float timer = 0f;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = colors[index];
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= duration)
        {
            index = (index + 1) % colors.Length;
            rend.material.color = colors[index];
            timer = 0f;
        }
    }
}