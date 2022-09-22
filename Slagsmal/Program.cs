

string yes = "yes";
int round = 1;
while (yes =="yes")
{
    //name and health variables
    Console.WriteLine("What is your name soon to be dead person?");
    string name = Console.ReadLine();
    Console.WriteLine($"Welcome {name} today you will be facing Bobby McWeakling in a grousome 1v1 battle.");
    int healthP1 = 100;
    int healthP2 = 100;
    while (healthP1 != 0 && healthP2 != 0)
    {
        //enemys choice
        Random choice = new Random();
        int rChoice = choice.Next(1, 3);
        //always attacks first round otherwise block doesn't work
        if (round == 1)
        {
            rChoice = 1;
        }
        if (rChoice == 2)
        {
            Console.WriteLine("Bobby McWeakling is going to block");
        }
        //Players choice
        Console.WriteLine($"What does {name} do?");
        Console.WriteLine("A:Attack B:Block");
        string fight = Console.ReadLine().ToLower();
        //Player attakcs
        if (fight == "a")
        {
            //players damage
            Random damage = new Random();
            int rDamage = damage.Next(1, 21);
            if (rChoice == 2)
            {
                if (round != 1)
                {
                    //enemy blocks
                    Random p2block = new Random();
                    int r2Block = p2block.Next(1, 11);
                    Console.WriteLine($"{name} did {rDamage} damage!");
                    rDamage -= r2Block;
                    if (rDamage < 0)
                    {
                        rDamage = 0;
                    }
                    Console.WriteLine($"Bobby McWeakling blocks with {r2Block}!");
                    Console.ReadLine();
                    healthP2 -= rDamage;
                    //Negative health bad
                    if (healthP2 < 0)
                    {
                        healthP2 = 0;
                    }
                    Console.WriteLine($"{name} only does {rDamage} damage and Bobby McWeakling has {healthP2} health left.");
                    //Player won
                    if (healthP2 == 0)
                    {
                        Console.WriteLine($"{name} is the winner!!!!");
                    }
                }

            }
            else
            {
                //enemy didn't block
                healthP2 -= rDamage;
                if (healthP2 < 0)
                {
                    healthP2 = 0;
                }
                Console.WriteLine($"{name} did {rDamage} damage and Bobby McWeakling only has {healthP2} health left!");
                if (healthP2 == 0)
                {
                    Console.WriteLine($"{name} is the winner!!!!");
                }
                Console.ReadLine();
            }
        }
        else if (fight == "b")
        {
            //player blocks
            Console.WriteLine($"{name} gets ready to block!");
            Console.ReadLine();
        }
        else
        {
            //player didnt do anything
            Console.WriteLine($"For some reason {name} does nothing.");
            Console.ReadLine();
            
        }
        
        if (healthP2 > 0)
        {
            //enemys turn
            Console.WriteLine("Now it's Bobby McWeaklings turn!!!");
            Console.ReadLine();
            if (rChoice == 1)
            {
                //enemy attacks
                Console.WriteLine("Bobby McWeakling attacks!!");
                Console.ReadLine();
                Random damage = new Random();
                int rDamage = damage.Next(1, 21);
                if (fight == "b")
                {
                    //player blocks
                    Console.WriteLine($"Bobby McWeakling hits with {rDamage} damage!!");
                    Random block = new Random();
                    int rBlock = block.Next(1, 11);
                    rDamage -= rBlock;
                    if (rDamage < 0)
                    {
                        rDamage = 0;
                    }
                    healthP1 -= rDamage;
                    Console.WriteLine($"{name} blocked {rBlock} damage!! he only took {rDamage} damage and has {healthP1} health left!");
                    Console.ReadLine();
                    
                }
                else
                {
                    //player didn't block
                    healthP1 -= rDamage;
                    Console.WriteLine($"{name} took {rDamage} damage and has {healthP1} health left!");
                }
                if (healthP1 < 0)
                {
                    healthP1 = 0;
                } 
                if (healthP1 == 0)
                {
                    //enemy won
                    Console.WriteLine("Bobby McWeakling won!!!");
                }
                
            }
            else if (rChoice == 2 && round != 1)
            {
                //enemy blocked players damage
                if (fight == "a" )
                {
                    Console.WriteLine("Bobby McWeakling has already used his turn to block!!");
                }
                else
                {
                    Console.WriteLine("Bobby McWeakling was prepared to block but didn't get attacked");
                }
            }
            else
            {
                //first round when enemy can't block
                Console.WriteLine("Bobby McWeakling attacks!!");
                Console.ReadLine();
                Random damage = new Random();
                int rDamage = damage.Next(1, 21);
                if (fight == "b")
                {
                    Console.WriteLine($"Bobby McWeakling hits with {rDamage} damage!!");
                    Random block = new Random();
                    int rBlock = block.Next(1, 11);
                    rDamage -= rBlock;
                    if (rDamage < 0)
                    {
                        rDamage = 0;
                    }
                    healthP1 -= rDamage;
                    Console.WriteLine($"{name} blocked {rBlock} damage!! he only took {rDamage} damage and has {healthP1} health left!");
                    Console.ReadLine();
                    
                }
                else
                {
                    healthP1 -= rDamage;
                    Console.WriteLine($"{name} took {rDamage} damage and has {healthP1} health left!");
                }
                if (healthP1 < 0)
                {
                    healthP1 = 0;
                } 
                if (healthP1 == 0)
                {
                    Console.WriteLine("Bobby McWeakling won!!!");
                }            
            }
            //round increase
            round ++;
            Console.WriteLine($"Round {round}!!");
        }

    }
    //someone won
    Console.WriteLine("Start over?(yes/no)");
    yes = Console.ReadLine().ToLower();
}