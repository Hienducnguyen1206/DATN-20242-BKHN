using UnityEngine;

    [CreateAssetMenu(fileName = "DISCSTATS", menuName = "DISCSTATS", order = 0)]
    public class DiscStats : ScriptableObject
    {
        [Header("Disc Stats")]
        [Range(1, 14)] public int Speed;
        [Range(1, 7)] public int Glide;
        [Range(-5,1)] public int Turn;
        [Range(0,5)] public int Fade;
    }
