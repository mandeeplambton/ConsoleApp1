using System;

namespace ConsoleApp1
{


    class village
    {
        public static int numberofvillages = 0;
        public village nextvillage;
        public village previouslyvillage;
        public string villagename;
        public bool isAstrildehere = false;

        public village()
        {
            village.numberofvillages++;
        }


        class countryside
        {
            public village Maple;

            public village Toronto;
            public village Ajax;
            public village Head;
            public village Tail;
            public village Temp;

            public void MapInitializer()
            {
                Maple = new village();
                Maple.villagename = "Maple";
                Maple.previouslyvillage = null;
                Maple.nextvillage = Toronto;
                Toronto = new village();
                Toronto.villagename = "Toronto ";
                Toronto.previouslyvillage = Maple;
                Toronto.nextvillage = Ajax;
                Ajax = new village();
                Ajax.villagename = "Ajax";
                Ajax.previouslyvillage = Toronto;
                Ajax.nextvillage = null;
            }

            public void LookForAstride()
            {
                Head = Maple;
                if (Head.isAstrildehere)
                {
                    Console.WriteLine("yeah! AstrIde is in");
                }
                while (true)
                { }

            }



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

    }
}
