using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    private Renderer rend;
    private Color startColor;
    private GameObject turret;
    public Vector3 positionOffSet;
    BuildManager buildManager;
   
    void Start()
    {
        
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
        buildManager = BuildManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildManager.GetTurretToBuild() == null)
        {
            return;
        }
        rend.material.color = hoverColor;
        
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
        
    }
    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;
        if (buildManager.GetTurretToBuild() == null)
            return;
        
        if (turret != null)
        {
            print(" We can't build here");
        }
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffSet, transform.rotation);

    }
    
}
