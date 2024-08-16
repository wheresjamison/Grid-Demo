using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3 selectedTilePosition = new Vector3(0, 0, 0);

    public void SetNewPosition(Vector3 newPosition)
    {
        selectedTilePosition = new Vector3(newPosition.x, newPosition.y, newPosition.z);
        Debug.Log("GameManager.cs: function SetNewPosition returns that selected tile position set to" + newPosition.ToString() + ".");
    }

    public Vector3 GetNewPosition()
    {
        Debug.Log("GameManager.cs: function GetNewPosition() returns the following: " + selectedTilePosition.ToString() + ".");
        return selectedTilePosition;
    }

    public Vector3 GetNewPositionWithoutDebug()
    {
        return selectedTilePosition;
    }
}
