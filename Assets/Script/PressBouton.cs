using UnityEngine;

public class ButtonMove : MonoBehaviour
{
    private Vector3 startPos;
    public float pressDepth = 0.01f; // profondeur d'enfoncement
    public float speed = 1f;
    private bool isPressed = false;

    void Start()
    {
        startPos = transform.position;
    }

    void OnMouseDown()
    {
        isPressed = true;
    }

    void OnMouseUp()
    {
        isPressed = false;
    }

    void Update()
    {
        Vector3 targetPos = startPos;

        if (isPressed)
            targetPos = startPos + new Vector3(0, -pressDepth, 0); // descend un peu

        // Mouvement fluide vers la position cible
        transform.position = Vector3.Lerp(transform.position, targetPos, Time.deltaTime * speed);
    }
}
