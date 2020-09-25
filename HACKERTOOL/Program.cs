using System;

namespace HACKERTOOL
{
    class HACKER
    {
        public string HackerNickName { get; set; }
        public int ToolNumber { get; set; }

        public HACKER()
        {
            HackerNickName = "Techopriest";
            ToolNumber = 0;
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
    class FileManager
    {
        private string UserText;

        public void Manager()
        {
            //Console.WriteLine("WE IN TOOL");
            do
            {
                UserText = Console.ReadLine();
                int position = UserText.IndexOf(":") - 1;
                if (position < 0)
                    continue;
                string command = (UserText.Substring(0, position));
                string path = UserText.Substring(position + 1);
                //Console.WriteLine("command : " + command + " path : " + path);


            } while (UserText == "exit");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HACKER tool = new HACKER();
            Console.WriteLine( "HACKER USERNAME " + tool.HackerNickName);
            Console.WriteLine("WHAT TOOL YOU WONNA UUUUSE? 1-OmegaFileManager");
            tool.ToolNumber = Convert.ToInt32(Console.ReadLine());
            tool.UseTool();

        }
    }
}
