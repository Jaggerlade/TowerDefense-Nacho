using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;

    private GameObject turretToBuild;


    void Awake()
    {
        if(instance != null)
        {
            return;
        }               
        instance = this;
    }

    

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}
