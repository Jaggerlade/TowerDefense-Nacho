using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if(instance != null)
        {
            return;
        }               
        instance = this;
    }
    public GameObject standardTurretPrefab;
    public GameObject missileLauncherPrefab;
    public GameObject buildEffect;

    private TurretBluePrint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    



    public void BuildTurretOn(Node node)
    {
        if (PlayerStats.Money < turretToBuild.cost)
        {
            print("Not enough Money");
            return;

        }

        PlayerStats.Money -= turretToBuild.cost;

       GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        print("Turret build! Money left:" + PlayerStats.Money);
    }
    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        turretToBuild = turret;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
