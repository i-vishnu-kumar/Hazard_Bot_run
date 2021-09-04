using UnityEngine;

public class DragDropJumper : MonoBehaviour
{
    public BoxCollider2D box;

    private void FixedUpdate()
    {
        if (transform.position.y < 10)
        {
            box.enabled = true;
        }
    }

    private void OnMouseDrag()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
        box.enabled = false;
    }

}
