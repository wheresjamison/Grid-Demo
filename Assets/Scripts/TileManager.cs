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
    //public Vector3 tilePosition = new Vector3();

    public void Start()
    {
        //tilePosition = transform.position;
        Debug.Log("TileManager.cs: " + name + " -> " + transform.position.ToString());
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
