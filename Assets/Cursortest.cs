using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursortest : MonoBehaviour
{
    [SerializeField] private Texture2D _texture2D;

    private void Awake()
    {
        Cursor.SetCursor(_texture2D, Vector2.zero, CursorMode.ForceSoftware);
    }
}
