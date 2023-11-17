namespace Inheritance_GameItems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Parent class objects
            // ----------------------------------------------------------------

            // GameItem objects use the parent class for instantiation.
            GameItem genericThing = new GameItem("Block", 5, 3, 20);

            // Parent objects can call methods in the parent class only.
            genericThing.Purchase();
            genericThing.Sell();


            // ----------------------------------------------------------------
            // Child class objects
            // ----------------------------------------------------------------
            // Child class objects can call any properties or methods in the parent or child class.

            // Love potion stats:  Name--> "potion"
            //                     Purchase cost --> 25
            //                     Sell cost --> 2
            //                     Weight --> 0.5
            //                     Effect --> "forces others to... player"
            //                     Uses --> 1
            Potion lovePotion = 
                new Potion("forces others to fall in love with the player", 1);

            // Health potion stats:  Name--> "health"
            //                       Purchase cost --> 100
            //                       Sell cost --> 2
            //                       Weight --> 0.5
            //                       Effect --> "Increases the player's... drank"
            //                       Uses --> 3
            Potion healthPotion = 
                new Potion("health", 100, "Increases the player's health when drank.", 3);

            // Buy then use the health potion.
            healthPotion.Purchase();
            healthPotion.Drink();
            healthPotion.Drink();
            healthPotion.Drink();
            healthPotion.Drink();

            // Toothpick stats:  Name--> "Toothpick of Doom"
            //                   Purchase cost --> 0.05 (5 cents)
            //                   Sell cost --> 0 (nothing)
            //                   Weight --> 0.01
            //                   Damage --> 0.6
            //                   Durability --> 1
            //                   Can be repaired --> no
            //double damage, double maxDurability, string name, double purchaseCost, double sellCost, double weight
            Weapon toothpickWeapon = 
                new Weapon(0.6, 1, "fragile", false, "Toothpick of Doom", 0.05, 0, 0.01);

            // Attack 10 times!
            for(int i = 0; i < 10; i++)
            {
                toothpickWeapon.Attack();
            }
        }
    }
}