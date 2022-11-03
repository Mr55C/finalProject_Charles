using System.Runtime.ExceptionServices;

Console.WriteLine("Hello. This is a text based adventure called DUNGEON");
Console.WriteLine("Would you like to start DUNGEON");
string start = Console.ReadLine();
if (start == "yes") Console.WriteLine("Lets begin!");
else { Console.WriteLine("Too bad, haha."); }
Random random = new Random();
float room = 0;
string firstThing = "";
bool end = false;
bool yellowKey = false;
bool greenKey = false;
bool darkGreenKey = false;
bool pinkKey = false;
bool orangeKey = false;
bool magentaKey = false;
bool blueKey = false;
bool grayKey = false;
bool pickaxe = false;
bool emptyCup = false;
bool fullCup=false;
bool badend = false;
bool magicPill = false;

while (end == false || badend == false)
{
    Console.WriteLine("You are in room " + room + ", What would you like to do? (Type in all lower case, type 'see' to see)");
    firstThing = Console.ReadLine();
    switch (room)
    {
        case 0:
            switch (firstThing)
            {
                case "go north":
                    if (yellowKey == true)
                    {
                        Console.WriteLine("You go to the north.");
                        room = 2;
                    }
                    else
                    {
                        Console.WriteLine("The door is locked. You need a yellow key to open it.");
                    }
                    break;

                case "go east":
                    Console.WriteLine("You go to the east.");
                    room = 1;
                    break;

                case "see":
                    Console.WriteLine("There is a locked yellow door to the North, and a open room to the east.");
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 1:
            switch (firstThing)
            {
                case "see":
                    if (yellowKey == true)
                    {
                        Console.WriteLine("there is a room to the west");
                    }
                    else
                    {
                        Console.WriteLine("There is a yellow key on the floor.\r\n Your options are grab key, go west.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    yellowKey = true;
                    break;

                case "go west":
                    Console.WriteLine("You go west.");
                    room = 0;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 2:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("There is a hallway to the East and a hallway to the West. \r\n Your options are go east and go west.");
                    break;

                case "go east":
                    Console.WriteLine("You go east.");
                    room = 3;
                    break;
                case "go west":
                    Console.WriteLine("You go west.");
                    room = 6;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 3:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("There is a hallway to the east and a hallway to the West. \r\n Your options are go east and go west.");
                    break;

                case "go east":
                    Console.WriteLine("You go east.");
                    room = 4;
                    break;
                case "go west":
                    Console.WriteLine("You go west.");
                    room = 2;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 4:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and a hallway to the West. \r\n your options are go south and go west.");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 5;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 3;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 5:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the north \r\n your options are go north.");
                    break;

                case "go north":
                    Console.WriteLine("you go north");
                    room = 4;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 6:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the east, a hallway to the West, a hallway to the south and an open room to the north. \r\n your options are go east, go west, go south and go north.");
                    break;

                case "go east":
                    Console.WriteLine("you go east");
                    room = 2;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 8;
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 10;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 7;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 7:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and a window. \r\n your options are go south and look through window.");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 6;
                    break;
                case "look through window":
                    Console.WriteLine("it looks like we are on the second floor");
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 8:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a locked green door to the north and a hallway to the east \r\n your options are go north and go east.");
                    break;
                case "go north":
                    if (greenKey == true)
                    {
                        Console.WriteLine("You go to the north.");
                        room = 9;
                    }
                    else
                    {
                        Console.WriteLine("the door is locked. you need a green key to open it");
                    }
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 6;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 9:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and a red chest. \r\n your options are go south and open chest.");
                    break;
                case "open chest":
                    Console.WriteLine("you open chest and found and pickaxe");
                    pickaxe = true;
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 8;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 10:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and a hallway to the north. \r\n your options are go south and go north.");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 11;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 6;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 11:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south, a hallway to the north and a hallway to the west. \r\n your options are go south, go north and go west.");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 13;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 10;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 12;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 12:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("There is a hallway to the east. \r\n Your options are go east.");
                    break;
                case "go east":
                    Console.WriteLine("You go east.");
                    room = 11;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 13:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a locked green door to the north and a hallway to the east \r\n your options are go north and go east.");
                    break;
                case "go west":
                    if (grayKey == true)
                    {
                        Console.WriteLine("You go to the west.");
                        room = 14;
                    }
                    else
                    {
                        Console.WriteLine("the door is locked. you need a gray key to open it");
                    }
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 15;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 11;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 14:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a stair case that goes down. \r\n your options are go down and go east");
                    break;

                case "go down":
                    Console.WriteLine("you go down");
                    room = 14.5f;
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 13;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 14.5f:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a stair case that goes up and a hallway to the east. \r\n your options are go up and go east");
                    break;

                case "go up":
                    Console.WriteLine("you go up");
                    room = 14;
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 21;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 15:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the east, a hallway to the west, and open room to the north. \r\n your options are go east, go west and go north.");
                    break;

                case "go east":
                    Console.WriteLine("you go east");
                    room = 17;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 13;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 16;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 16:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("you are in a bathroom. \r\n your options are use sink and go south");
                    break;

                case "use sink":
                    if (emptyCup == true)
                    {
                        Console.WriteLine("you filled your cup");
                        fullCup = true;
                    }
                    else
                    {
                        Console.WriteLine("you need a cup to use this");
                    }
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 15;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 17:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a crumbleing wall to the east, a hallway to the north and a hallway to the west. \r\n your options are go west, go north, mine wall");
                    break;

                case "mine wall":
                    if (pickaxe == true)
                    {
                        Console.WriteLine("you mined the wall and discover a secret room but your pickaxe broke");
                        room = 20;
                    }
                    else
                    {
                        Console.WriteLine("you need a cup to use this");
                    }
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 15;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 18;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 18:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and an open room to the east. \r\n your options are go south and go east");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 17;
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 19;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 19:
            switch (firstThing)
            {
                case "see":
                    if (greenKey == true)
                    {
                        Console.WriteLine("there is a hallway to the west");
                    }
                    else
                    {
                        Console.WriteLine("There is a green key on the floor and a hallway to the west.\r\n Your options are grab key, go west.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    greenKey = true;
                    break;

                case "go west":
                    Console.WriteLine("You go west.");
                    room = 18;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 20:
            switch (firstThing)
            {
                case "see":
                    if (grayKey == true)
                    {
                        Console.WriteLine("there is a hallway to the west");
                    }
                    else
                    {
                        Console.WriteLine("There is a gray key on the floor and a hallway to the west.\r\n Your options are grab key, go west.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    grayKey = true;
                    break;

                case "go west":
                    Console.WriteLine("You go west.");
                    room = 17;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 21:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the east, a hallway to the west, and a hallway to the north. \r\n your options are go east, go west and go north.");
                    break;

                case "go east":
                    Console.WriteLine("you go east");
                    room = 32;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 14.5f;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 22;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 22:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south, an open room to the west, and hallway to the north. \r\n your options are go south, go west and go north.");
                    break;

                case "go west":
                    Console.WriteLine("you go west");
                    room = 23;
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 21;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 24;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 23:
            switch (firstThing)
            {
                case "see":
                    if (darkGreenKey == true)
                    {
                        Console.WriteLine("there is a hallway to the east");
                    }
                    else
                    {
                        Console.WriteLine("There is a dark green key on the floor and a hallway to the east.\r\n Your options are grab key, go east.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    darkGreenKey = true;
                    break;

                case "go east":
                    Console.WriteLine("You go east.");
                    room = 22;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 24:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and a hallway to the east. \r\n your options are go south and go east");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 22;
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 25;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 25:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the east, a hallway to the west, and a hallway to the north. \r\n your options are go east, go west and go north.");
                    break;

                case "go east":
                    Console.WriteLine("you go east");
                    room = 26;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 24;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 37;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 26:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the east, a hallway to the west, and an open room to the south. \r\n your options are go east, go west and go north.");
                    break;

                case "go east":
                    Console.WriteLine("you go east");
                    room = 27;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 25;
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 28;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        
        case 27:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south, an hallway to the west, and open hallway to the north. \r\n your options are go south, go west and go north.");
                    break;

                case "go west":
                    Console.WriteLine("you go west");
                    room = 26;
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 29;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 34;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 28:
            switch (firstThing)
            {
                case "see":
                    if (magentaKey == true)
                    {
                        Console.WriteLine("there is a hallway to the north");
                    }
                    else
                    {
                        Console.WriteLine("There is a magenta key on the floor and a hallway to the north.\r\n Your options are grab key, go north.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    magentaKey = true;
                    break;

                case "go north":
                    Console.WriteLine("You go north.");
                    room = 26;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 29:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and a hallway to the north. \r\n your options are go south and go north.");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 30;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 28;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 30:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the north and an hallway to the west. \r\n your options are go morth and go west");
                    break;

                case "go north":
                    Console.WriteLine("you go north");
                    room = 29;
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 31;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 31:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("There is a hallway to the east and a hallway to the West. \r\n Your options are go east and go west.");
                    break;

                case "go east":
                    Console.WriteLine("You go east.");
                    room = 30;
                    break;
                case "go west":
                    Console.WriteLine("You go west.");
                    room = 32;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 32:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a locked magenta door to the north, a hallway to the east and a hallway to the west \r\n your options are go north, go east and go west.");
                    break;
                case "go north":
                    if (magentaKey == true)
                    {
                        Console.WriteLine("You go to the north.");
                        room = 34;
                    }
                    else
                    {
                        Console.WriteLine("the door is locked. you need a magenta key to open it");
                    }
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 31;
                    break;
                case "go west":
                    Console.WriteLine("You go west.");
                    room = 21;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 33:
            switch (firstThing)
            {
                case "see":
                    if (emptyCup == true)
                    {
                        Console.WriteLine("there is a hallway to the south");
                    }
                    else
                    {
                        Console.WriteLine("There is a empty cup on the floor and a hallway to the south.\r\n Your options are grab cup, go south.");
                    }
                    break;

                case "grab cup":
                    Console.WriteLine("You grab cup.");
                    emptyCup = true;
                    break;

                case "go south":
                    Console.WriteLine("You go south.");
                    room = 32;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 34:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south, an open room to the west, and open room to the north. \r\n your options are go south, go west and go north.");
                    break;

                case "go west":
                    Console.WriteLine("you go west");
                    room = 26;
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 27;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 35;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 35:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("you are in a kitchen with a magical pill on the counter. \r\n your options are use pill and go south");
                    break;

                case "use sink":
                    if (fullCup == true)
                    {
                        Console.WriteLine("you swollowed the pill and gained super strength");
                        magicPill = true;
                    }
                    else
                    {
                        Console.WriteLine("you need a full cup to take this");
                    }
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 34;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 36:
            switch (firstThing)
            {
                case "see":
                    if (blueKey == true)
                    {
                        Console.WriteLine("there is a hallway to the east");
                    }
                    else
                    {
                        Console.WriteLine("There is a blue key on the floor and a hallway to the east.\r\n Your options are grab key, go east.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    blueKey = true;
                    break;

                case "go east":
                    Console.WriteLine("You go east.");
                    room = 34;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 37:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the north and a hallway to the east \r\n your options are go north and go east.");
                    break;
                case "go west":
                    if (blueKey == true)
                    {
                        Console.WriteLine("You go to the west.");
                        room = 38;
                    }
                    else
                    {
                        Console.WriteLine("the door is locked. you need a blue key to open it");
                    }
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 31;
                    break;
                case "go south":
                    Console.WriteLine("You go south.");
                    room = 21;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 38:
            switch (firstThing)
            {
                case "see":
                    if (pinkKey == true)
                    {
                        Console.WriteLine("there is a hallway to the east");
                    }
                    else
                    {
                        Console.WriteLine("There is a pink key on the floor and a hallway to the east.\r\n Your options are grab key, go east.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    pinkKey = true;
                    break;

                case "go east":
                    Console.WriteLine("You go east.");
                    room = 37;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
        case 39:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the east, a hallway to the west, and a hallway to the south. \r\n your options are go east, go west and go south.");
                    break;

                case "go east":
                    Console.WriteLine("you go east");
                    room = 26;
                    break;
                case "go west":
                    if (blueKey == true)
                    {
                        Console.WriteLine("You go to the west.");
                        room = 40;
                    }
                    else
                    {
                        Console.WriteLine("the door is locked. you need a pink key to open it");
                    }
                    break;
                case "go south":
                    Console.WriteLine("you go south");
                    room = 37;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 40:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the west adn an exit with an orange and dark green locks. \r\n your options are go north and exit.");
                    break;
                case "exit":
                    if (orangeKey == true && darkGreenKey == true)
                    {
                        int die = random.Next(1, 3);
                        if(die == 1)
                        {
                            Console.WriteLine("You escape and go on to live on with your new found strength.\r\n Congrats you have reached the good end!");
                            end = true;
                        }
                        else
                        {
                            Console.WriteLine("you escape and feel a sharp pain in your stomach and keel over as your mussels tear apart and die. \r\n Congrats you have reached the bad end! due to the side afects of the pill your body rejects it and the resulting happend.");
                            badend = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("the door is locked. you need an orange and dark green key to open it");
                    }
                    break;
                case "go west":
                    Console.WriteLine("you go west");
                    room = 39;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 41:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("There is a hallway to the east and a hallway to the West. \r\n Your options are go east and go west.");
                    break;

                case "go east":
                    Console.WriteLine("You go east.");
                    room = 39;
                    break;
                case "go west":
                    Console.WriteLine("You go west.");
                    room = 42;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 42:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a hallway to the south and a hallway to the east. \r\n your options are go south and go east");
                    break;

                case "go south":
                    Console.WriteLine("you go south");
                    room = 43;
                    break;
                case "go east":
                    Console.WriteLine("you go east");
                    room = 41;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 43:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a crumbling wall to the south and a hallway to the north \r\n your options are go north and go south.");
                    break;
                case "go south":
                    if (magicPill == true)
                    {
                        Console.WriteLine("You break through the wall and go to the south.");
                        room = 44;
                    }
                    else
                    {
                        Console.WriteLine("the door is locked. you need super strength to open it");
                    }
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 42;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 44:
            switch (firstThing)
            {
                case "see":
                    Console.WriteLine("there is a ladder that goes up and a hallway to the north. \r\n your options are go up and go north.");
                    break;

                case "go up":
                    Console.WriteLine("you go up");
                    room = 45;
                    break;
                case "go north":
                    Console.WriteLine("you go north");
                    room = 43;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;

            }
            break;
        case 45:
            switch (firstThing)
            {
                case "see":
                    if (orangeKey == true)
                    {
                        Console.WriteLine("there is a ladder that goes down");
                    }
                    else
                    {
                        Console.WriteLine("There is an orange key on the floor and a ladder that goes down.\r\n Your options are grab key, go down.");
                    }
                    break;

                case "grab key":
                    Console.WriteLine("You grab key.");
                    emptyCup = true;
                    break;

                case "go down":
                    Console.WriteLine("You go down.");
                    room = 44;
                    break;
                default:
                    Console.WriteLine("I no understand.");
                    break;
            }
            break;
    }
}
Console.WriteLine("Congratulations on finishing the game!");