using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UIElements;

public class TileManager : MonoBehaviour
{
    public GridManager gm;

    public void Start()
    {
        //tilePosition = transform.position;
        Debug.Log("TileManager.cs: " + name + " -> " + transform.position.ToString());
        gm = FindAnyObjectByType<GridManager>();
        AddTileToGrid();
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public void ReportTileInformation()
    {

    }

    public void AddTileToGrid()
    {
        gm.AddTileToList(this.gameObject);
    }
}
