List<Duck> ducks = new List<Duck>()
{
    new Duck() {Kind = KindOfDuck.Mallard, size = 17 },
    new Duck() {Kind = KindOfDuck.Muscovy, size = 18 },
    new Duck() {Kind = KindOfDuck.Decoy, size = 14 },
    new Duck() {Kind = KindOfDuck.Muscovy, size = 11 },
    new Duck() {Kind = KindOfDuck.Mallard, size = 14 },
    new Duck() {Kind = KindOfDuck.Decoy, size = 13 }
};

ducks.Sort();

Console.ReadKey();