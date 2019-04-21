using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    void Start()
    {
        buildManager = BuildManager.instance;
    }


    void Update()
    {

    }
    public void PurchaseStadardTurret()
    {
        print("Selected stardard");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

    }
    public void PurchaseMissileLauncher()
    {
        print("Selected MissileLauncher");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);
    }
}
