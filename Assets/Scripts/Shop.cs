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
        print("Purchased stardard");
        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

    }
    public void PurchaseAnotherTurret()
    {
        print("Purchased Another");
        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);
    }
}
