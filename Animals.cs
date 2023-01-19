using System;

namespace AnimalsControl
{
    class Animals
    {
        private string[] name = new string[5];
        private string[] type = new string[5];
        private int dog = 0;
        private int cat = 0;
        private int fish = 0;

        public string[] Name
        {
            get { return name; }
        }
        public string[] Type
        {
            get { return type; }
        }

        public void Counter()
        {
            foreach (string type in type)
            {
                if (type.ToUpper() == "DOG")
                {
                    dog++;
                }
                else if (type.ToUpper() == "CAT")
                {
                    cat++;
                }
                else
                {
                    fish++;
                }
            }
        }
        public void show()
        {
            Console.WriteLine($"\nDogs: {dog} \nCats: {cat} \nFishes: {fish}");
        }
    }
}