using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
//{
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Space))
//        {
//            // Access the SpriteRenderer component
//            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

//            // Change the color to blue
//            spriteRenderer.color = Color.blue;

//        }
//    }
//}



// BELOW IS FROM CHATGPT
{
    private SpriteRenderer spriteRenderer;
private Color originalColor;
private bool isBlue = false;

void Start()
{
    spriteRenderer = GetComponent<SpriteRenderer>();
    originalColor = spriteRenderer.color; // Save the starting color
}

void Update()
{
    if (Input.GetKeyDown(KeyCode.Space))
    {
        if (isBlue)
        {
            spriteRenderer.color = originalColor; // Revert to original
        }
        else
        {
            spriteRenderer.color = Color.blue;     // Change to blue
        }

        isBlue = !isBlue; // Toggle the flag
    }
}
}
