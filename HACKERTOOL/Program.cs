using System;

namespace HACKERTOOL
{
    class HACKER
    {
        public string HackerNickName { get; set; }
        public int ToolNumber { get; set; }
        public HACKER(string Name)
        {
            ToolNumber = 0;
            HackerNickName = Name;
        }
        public void UseTool()
        {
            if (ToolNumber == 1) {
                //Console.WriteLine("WE IN USE TOOL");
                FileManager Manager = new FileManager();
                Manager.Manager();
            } else
            {
                Console.WriteLine("you retard");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string Nickname = Console.ReadLine();
            HACKER tool = new HACKER(Nickname);
            Console.WriteLine( "HACKER USERNAME " + tool.HackerNickName);
            Console.WriteLine("WHAT TOOL YOU WONNA UUUUSE? 1-OmegaFileManager");
            tool.ToolNumber = Convert.ToInt32(Console.ReadLine());
            tool.UseTool();

        }
    }
}
