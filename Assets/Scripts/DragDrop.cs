using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragDrop : MonoBehaviour
{

    public BoxCollider2D box;
    public PlatformEffector2D platform;

    private void OnMouseDrag()
    {
        Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(cursorPos.x, cursorPos.y);
        box.enabled = false;
        platform.enabled = false;
    }

    private void OnMouseUp()
    {
        box.enabled = true;
        platform.enabled = true;
    }

}
