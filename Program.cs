using System;

namespace Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassType.Mage hero1 = new ClassType.Mage();
            ClassType.Assassin hero2 = new ClassType.Assassin();
            ClassType.Warrior hero3 = new ClassType.Warrior();
            ClassType.Healer hero4 = new ClassType.Healer();
        }
    }

    //Class type of the playable character (what makes it special)
    public class ClassType : Playable 
    
    {
        //Basic stats
        double health = 140;
        double atk = 50;
        double wisdom = 50;
        double armor = 50;
        double magicResist = 50;
        double speed = 75;

        //Nested classes
        public class Mage 
        {
            //All Mages get +10 in wisdom
            static ClassType UnamedHero = new ClassType();
            double wisdom = UnamedHero.wisdom + 10; 
        }
        public class Warrior 
        {
            //All Warriors get +10 in armor
            static ClassType UnamedHero = new ClassType();
            double armor = UnamedHero.armor + 10;
        }
        public class Hunter 
        {
            //All Hunters get +30 in speed
            static ClassType UnamedHero = new ClassType();
            double speed = UnamedHero.speed + 30;
        }
        public class Assassin 
        {
            //All Assassins get +10 in atk
            static ClassType UnamedHero = new ClassType();
            double atk = UnamedHero.atk + 10;
        }
        public class Healer 
        {
            //All Healers get +10 in magic resist
            static ClassType UnamedHero = new ClassType();
            double magicResist = UnamedHero.magicResist + 10;
        }

    }

    //Super class for characters (anything other than an item)
    public class Characters 
    {
        //anything other than an item
    }

    public class Playable : Characters 
    { 
        //Any character that can be played
    }

    public class NonPlayable : Characters
    {
        //NPC that rewards experience and has a chance to drop an item WIP
    }

    //Items available in the game WIP
    public class Items { }
}
