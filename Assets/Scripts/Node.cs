using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color NotEnoughMoneyColour;
    public Vector3 positionOffSet;

    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;
    private Color startColor;

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
        if (buildManager.CanBuild)
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
        if (!buildManager.CanBuild)
            return;
        
        if (turret != null)
        {
            print(" We can't build here");
        }
        buildManager.BuildTurretOn(this);

    }
    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffSet;
    }
    
}
