class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a scripture to memorize: ");
        Console.WriteLine("1: John 3:16");
        Console.WriteLine("2: 1 Nephi 3:7");
        Console.WriteLine("3: John 16:33");

        int choice = int.Parse(Console.ReadLine());

        Scripture scripture;
        switch(choice)
        {
            case 1: 
                scripture = new Scripture(new Reference("John", 3, 16), "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
                break;
            case 2:
                scripture = new Scripture(new Reference("Nephi", 3, 7), "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.");
                break;
            case 3:
                scripture = new Scripture(new Reference("John", 16, 33), "These things I have spoken unto you, that in me ye might have peace. In the world ye shall have tribulation: but be of good cheer; I have overcome the world.");
                break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }


        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayScripture());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

            if (Console.ReadLine()?.ToLower() == "quit" || scripture.AllHidden())
                break;

            scripture.HideRandomWords(3);
        }
        Console.WriteLine("Great job!");
    }
}
