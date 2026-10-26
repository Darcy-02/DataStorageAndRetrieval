
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Planet : MonoBehaviour
{
    public PlanetData planetData;
    public TMP_Text planetInfo;

    void Start()
    {
        ShowPlanetData();
    }

    public void ShowPlanetData()
    {
        planetInfo.text =
            "Planet: " + planetData.planetName + "\n" +
            "Moons: " + planetData.numberOfMoons + "\n" +
            "Mass: " + planetData.mass;
    }
}

