using UnityEngine;

public interface IMoveWithPointer
{
    bool CanBeMovedWithPointer()
    {
        return false;
    }

    void MoveToTagetScreenPosition(Vector2 Screenlocation)
    {
    } 
    void DragStartWithPointer(Vector2 Screenlocation)
    {
    }
    void DragEndWithPointer()
    {
    }
}
