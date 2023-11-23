using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Tutorial/Item")]
public class Scriptable : ScriptableObject
{
    public string Name;
    public string Description;
    public Sprite Icon;
}
