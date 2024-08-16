using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    private GameManager gm;

    Camera cam;
    public LayerMask mask;

    public Vector3 hitTilePosition;

    void Start()
    {
        cam = Camera.main;
        gm = FindObjectOfType<GameManager>();
    }

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10f;
        mousePosition = cam.ScreenToWorldPoint(mousePosition);
        Debug.DrawRay(transform.position, mousePosition - transform.position, Color.blue);

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100, mask))
            {
                Debug.Log("RayCast.cs: tile name: '" + hit.transform.name + "'.");
                float x = hit.transform.position.x;
                float y = hit.transform.position.y;
                float z = hit.transform.position.z;
                hitTilePosition = new Vector3(x, y, z);
                Debug.Log("RayCast.cs: hitTilePosition = " + hitTilePosition.ToString() + ".");
                gm.SetNewPosition(hitTilePosition);
            }
        }
    }
}
