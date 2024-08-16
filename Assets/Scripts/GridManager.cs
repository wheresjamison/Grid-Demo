using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;

public class GridManager : MonoBehaviour
{

    public List<GameObject> allTiles;

    public void Start()
    {
        PrintAllChildren();
        AddTileToList();
        PrintList();
    }

    void PrintAllChildren()
    {
        foreach (Transform child in transform)
            Debug.Log("GridManage.cs: PrintAllChildren(): Foreach loop: " + child);
    }

    void AddTileToList()
    {
        foreach (Transform child in transform)
        {
            allTiles.Add(child.gameObject);
        }
        Debug.Log("all tiles have been added to list.");
    }

    void PrintList()
    {
        foreach (GameObject tile in allTiles)
        {
            Debug.Log("Tile: " + tile);
        }
        Debug.Log("all tiles" + allTiles[1]);
    }
}
