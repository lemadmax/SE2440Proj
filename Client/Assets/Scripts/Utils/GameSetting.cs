using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameSetting : MonoBehaviour
{
    public int PlayerCount;
    public GameObject MenInfantry;
    public GameObject UndeadInfantry;
    public GameObject OrcCavalry;

    public GameObject MenBarrack;
    public GameObject UndeadBarrack;

    const int campCount = 3;
    const int unitCount = 2;
    const int buildingCount = 1;

    public GameObject[,] UnitPrefabs = new GameObject[campCount, unitCount];
    public GameObject[,] BuildingPrefabs = new GameObject[campCount, buildingCount];

    public int[,] UnitPrice = new int[campCount, unitCount];
    public int[,] BuildingPrice = new int[campCount, buildingCount];

    void Start()
    {
        UnitPrefabs[(int)Camp.Men, (int)Unit.Infantry] = MenInfantry;
        UnitPrice[(int)Camp.Men, (int)Unit.Infantry] = 10;

        UnitPrefabs[(int)Camp.Undead, (int)Unit.Infantry] = UndeadInfantry;
        UnitPrice[(int)Camp.Undead, (int)Unit.Infantry] = 10;

        UnitPrefabs[(int)Camp.Orc, (int)Unit.Cavalry] = OrcCavalry;
        UnitPrice[(int)Camp.Orc, (int)Unit.Cavalry] = 50;

        BuildingPrefabs[(int)Camp.Men, (int)Building.Barracks] = MenBarrack;
        BuildingPrice[(int)Camp.Men, (int)Building.Barracks] = 100;

        BuildingPrefabs[(int)Camp.Undead, (int)Building.Barracks] = UndeadBarrack;
        BuildingPrice[(int)Camp.Undead, (int)Building.Barracks] = 100;

    }
}
