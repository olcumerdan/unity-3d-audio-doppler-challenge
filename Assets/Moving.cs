using UnityEngine;

public class Moving : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Araba sanıyede 5 bırım hızla ılerı (Z ekseninde) gıtsın 
        transform.Translate(Vector3.forward * 5 * Time.deltaTime);
        
    }
}
