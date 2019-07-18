using System;
using System.Collections.Generic;


namespace HampusChallenge
{

    /*
     
         Klass Human 
                String name;
                int age;
                enum gender(male,female);

             

        klass House
                <List> Human 
                int houseNr;

        Klass Town
                <List> House
         
         
                                                                                                                                                                        */

    public enum Gender { male, female };
    class Human
        {

        public string name;
        public int age;
        public Gender gender;

        public Human(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;

        }

       /*   DEBUG OCKSÅ!
        public void getHuman()
        {
            Console.WriteLine($"This Human obj is called:\n{this.name}\n{this.age}\n{this.gender}");
        }*/

       
    }

    class House
    {
        public List<Human> houseLiving = new List<Human>();
        public int houseNumber;

        public House(Human human, int number)
        {
            houseLiving.Add(human);
            this.houseNumber = number;
        }

        public void addHumanToHouse(Human human)
        {
            this.houseLiving.Add(human);

        }
        public void getInhabitants(int number)
        {
            Console.WriteLine($"\n\nIn house: {this.houseNumber}\n\nLives these people:");
            for(int i = 0; i < this.houseLiving.Count; i++)
            {
               Console.WriteLine($"{i} {this.houseLiving[i].name}");
            }
            
           
        }

    }

    class Town
    {
        public string name;
        public List<House> housesInTown = new List<House>();

        public Town(string name)
        {
            this.name = name;

        }
        public void addHouseToTown(House house)
        {
            housesInTown.Add(house);

        }

        public string GetNameOfTown()
        {
            return this.name;
        }
        public void GetAllHousesInTown()
        {
            for(int i = 0; i < housesInTown.Count; i++)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine($"In house number {housesInTown[i].houseNumber} \nlives:\n");
                for(int j = 0; j < housesInTown[i].houseLiving.Count; j++)
                {
                    Console.WriteLine($"{j}: {housesInTown[i].houseLiving[j].name}");
                }
                Console.WriteLine("\n\n");
            }
        }
    }


            
    class Program
    {
        static void Main(string[] args)
        {
            Human John = new Human("John", 23, Gender.male);
            //John.getHuman();                                                                      Användes för debug

            Human Mary = new Human("Mary", 20, Gender.female);
            //Mary.getHuman();                                                                      Användes för debug

            Human Per = new Human("Per", 27, Gender.male);
            //Per.getHuman();                                                                       Användes för debug

            Human Johanna = new Human("Johanna", 32, Gender.female);
            //Joanne.getHuman();                                                                    Användes för debug

            House Gata1 = new House(John, 1);
            Gata1.addHumanToHouse(Mary);
            House Gata2 = new House(Per, 2);
            House Gata3 = new House(Johanna, 3);

            //Gata1.getInhabitants(1);                                                              Användes för debug

            Town Helsingborg = new Town("Helsingborg");
            Helsingborg.addHouseToTown(Gata1);
            Helsingborg.addHouseToTown(Gata2);
            Helsingborg.addHouseToTown(Gata3);

            Console.WriteLine($"In the town of: {Helsingborg.GetNameOfTown()} there is a couple of houses, namely: {Helsingborg.housesInTown.Count}\n\n ");

            Helsingborg.GetAllHousesInTown();

        }
    }
}
