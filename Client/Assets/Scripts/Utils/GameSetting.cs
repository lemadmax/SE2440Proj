using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSetting : MonoBehaviour
{
    public GameObject MenInfantry;
    public GameObject UndeadInfantry;
    public GameObject OrcCavalry;

    const int campCount = 3;
    const int unitCount = 2;
    const int buildingCount = 1;

    GameObject[,] UnitPrefabs = new GameObject[campCount, unitCount];
    GameObject[,] BuildingPrefabs = new GameObject[campCount, buildingCount];

    void Start()
    {
        UnitPrefabs[(int)Camp.Men, (int)Unit.Infantry] = MenInfantry;

        UnitPrefabs[(int)Camp.Undead, (int)Unit.Infantry] = UndeadInfantry;

        UnitPrefabs[(int)Camp.Orc, (int)Unit.Cavalry] = OrcCavalry;
    }
}
