using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu(fileName = "PlanetData", menuName = "Scriptable Objects/PlanetData")]
public class PlanetData : ScriptableObject
{
    public string planetName = "Earth";
    public int numberOfMoons = 1;
    public float mass = 5.97f;

}
