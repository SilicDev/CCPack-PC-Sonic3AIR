using ConnectorLib.SimpleTCP;
using JetBrains.Annotations;

namespace CrowdControl.Games.Packs.Sonic3AIR;

[UsedImplicitly]
class Sonic3AIR : SimpleTCPPack<SimpleTCPServerConnector>
{
    public override string Host => "127.0.0.1";
    public override ushort Port => 58430;

    public override Game Game { get; } = new("Sonic 3 A.I.R.", "Sonic3AIR", "PC", ConnectorType.SimpleTCPServerConnector);

    public override EffectList Effects
    {
        get
        {
            List<Effect> effects =
            [
                new("Give Ring", "AddRing")
                    { Price = 1, Description = "Give the player a ring.", Quantity = 99 },
                new("Take Ring", "TakeRing")
                    { Price = 1, Description = "Take a ring from the player", Quantity = 99 },
                new("Change to Sonic", "CharSonic")
                    { Price = 5, Description = "Change the character to Sonic." },
                new("Change to Tails", "CharTails")
                    { Price = 5, Description = "Change the character to Tails." },
                new("Change to Knuckles", "CharKnuckles")
                    { Price = 5, Description = "Change the character to Knuckles." },
                new("Slap", "Slap")
                    { Price = 5, Description = "Slaps the player." },
                new("Kill", "Kill")
                    { Price = 100, Description = "Kills the player." },
                new("Give Emeralds", "GiveEmerald")
                    { Price = 100, Description = "Gives the chaos/super emeralds to the player." },
                new("Take Emeralds", "TakeEmerald")
                    { Price = 200, Description = "Takes the chaos/super emeralds from the player." },
                new("Blue Spheres Jail", "BlueSpheres")
                    {
                        Price = 250, Description = "Send the player to complete a level of Blue spheres.",
                        SessionCooldown = 5
                    },
                new("Shove", "Shove")
                    { Price = 10, Description = "Shove the player forward with lots of speed." },
                new("Reverse!", "Reverse")
                    { Price = 10, Description = "Shove the player backward with lots of speed." },
                new("Grant Speed Shoes", "SpeedShoes")
                    { Price = 40, Description = "Gives Speed Shoes to the player." },
                new("Grant Invincibility", "Invincibility")
                    { Price = 40, Description = "Gives Invicibility to the player." },
                new("Spawn Bumper", "Bumper")
                    { Price = 5, Description = "Spawns a Bumper in front of the player." },
                new("Spawn Spring", "HorizontalSpring")
                    { Price = 15, Description = "Spawns a Spring in front of the player." },
                new("Spawn Eggbox", "Eggbox")
                    { Price = 5, Description = "Spawns a Eggbox in front of the player." },
                new("Spawn Motobug", "Jimmy")
                    { Price = 10, Description = "Spawns a Motobug to chase the player." },
                new("Spawn Asteron", "Meansteron")
                    { Price = 20, Description = "Spawns a Asteron in front of the player." },
                new("Give Shield", "shieldBlue")
                    { Price = 3, Description = "Gives A Shield to the Player" },
                new("Give Fire Shield", "shieldFire")
                    { Price = 3, Description = "Gives A Fire Shield to the Player" },
                new("Give Thunder Shield", "shieldThunder")
                    { Price = 3, Description = "Gives A Thunder Shield to the Player" },
                new("Give Bubble Shield", "shieldBubble")
                    { Price = 3, Description = "Gives A Bubble Shield to the Player" },
                new("Invert Controls", "InvertControls")
                    { Price = 50, Duration = 20, Description = "Inverts the player's controls." },
                new("Disable Jump", "NoJump")
                    { Price = 50, Duration = 10, Description = "Disables the player's ability to jump." },
                new("Disable Jump Abilities", "NoJumpAbility")
                    { Price = 50, Duration = 20, Description = "Disables the player's jump abilities (Instashield, Flight, Glide)." },
            ];
            return effects;
        }
    }

    public Sonic3AIR(UserRecord player, Func<CrowdControlBlock, bool> responseHandler, Action<object> statusUpdateHandler) : base(player, responseHandler, statusUpdateHandler)
    {
    }

    protected override GameState GetGameState()
    {
        return GameState.Ready;
    }
}
