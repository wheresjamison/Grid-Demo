using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using UnityEditor.Animations;
using UnityEngine;
using UnityEngine.AI;


public class GridManager : MonoBehaviour
{

    //public List<GameObject> allTiles;

    int numberOfTiles = 0;
    public List<GameObject> tilesList;

    public void Start()
    {
        
    }

    public void FindAllTiles()
    {
        foreach (Transform child in transform)
        {
            numberOfTiles++;
        }
    }

    public void AddTileToList(gameObject tile)
    {
        tilesList.Add(tile);
    }
    
    //curently not needed
    //void PrintAllChildren()
    //{
    //    foreach (Transform child in transform)
    //    {
    //        Debug.Log("GridManage.cs: PrintAllChildren(): Foreach loop: " + child);
    //    }
    //}

    //void AddTileToList()
    //{
    //    foreach (Transform child in transform)
    //    {
    //        allTiles.Add(child.gameObject);
    //    }
    //    Debug.Log("all tiles have been added to list.");
    //}

    //void PrintList()
    //{
    //    foreach (GameObject tile in allTiles)
    //    {
    //        Debug.Log("Tile: " + tile);
    //    }
    //    Debug.Log("all tiles" + allTiles[1]);
    //}
}
