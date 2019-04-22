using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBluePrint standardTurret;
    public TurretBluePrint missileLauncher;
    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }


    void Update()
    {

    }
    public void SelectStadardTurret()
    {
        print("Selected stardard");
        buildManager.SelectTurretToBuild(standardTurret);

    }
    public void SelectMissileLauncher()
    {
        print("Selected MissileLauncher");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
}
