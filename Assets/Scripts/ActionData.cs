using UnityEngine;

[CreateAssetMenu(fileName = "newaAction", menuName = "Action/ActionData")]
public class ActionData : ScriptableObject
{
    [SerializeField] private string actionName;
    [SerializeField] private int actionCost;
    [SerializeField] private int streessImpact;

    public string ActionName => actionName;
    public int ActionCost => actionCost;
    public int StreessImpact => streessImpact;  
}
