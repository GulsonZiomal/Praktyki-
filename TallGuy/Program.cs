public class TallGuy{
    public string Name = "";
    public int Height = 0;
    public void TalkAboutYourself()
    {
        Console.WriteLine("Nazwyam się " + Name + " i mam " + Height + "cm wzrostu.");
    }

    static void Main(string[] args)
    {
        TallGuy tallguy = new TallGuy() { Height = 174, Name = "Adam"};
        tallguy.TalkAboutYourself();
    }
}