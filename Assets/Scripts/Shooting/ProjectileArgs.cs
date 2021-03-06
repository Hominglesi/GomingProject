using UnityEngine;

public class ProjectileArgs
{
    public ProjectileTypes Type { get; set; }
    public float Speed { get; set; } = 10f;
    public float Speed2 { get; set; }
    public int BounceAmount { get; set; } = 1;
    public Vector2 StartPosition { get; set; }
    public float StartPositionOffset { get; set; }
    public Vector2 Direction { get; set; }
    public float HomingStrenght { get; set; }
    public bool IsPlayerOrigin { get; set; } = false;
    public string SpritePath { get; set; }
    public bool CustomCollider { get; set; } = false;
    public Vector2 ColliderSize { get; set; }
    public Vector2 ColliderOffset { get; set; }
    public Vector2 TargetDestination { get; set; }
    public float OffsetRange { get; set; }
    public float WaitTime { get; set; }

    public ProjectileArgs Clone()
    {
        return new ProjectileArgs()
        {
            Type = Type,
            Speed = Speed,
            Speed2 = Speed2,
            BounceAmount = BounceAmount,
            StartPosition = StartPosition,
            StartPositionOffset = StartPositionOffset,
            Direction = Direction,
            HomingStrenght = HomingStrenght,
            IsPlayerOrigin = IsPlayerOrigin,
            SpritePath = SpritePath,
            CustomCollider = CustomCollider,
            ColliderSize = ColliderSize,
            ColliderOffset = ColliderOffset,
            TargetDestination = TargetDestination,
            OffsetRange = OffsetRange,
            WaitTime = WaitTime
        };
    }
}

public enum ProjectileTypes
{
    Straight,
    Bouncing,
    Homing,
    MikicSleep
}
