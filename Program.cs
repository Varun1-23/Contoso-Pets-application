string petId = "";
string petSpecies = "";
string petAge = "0";
string petPhysicalCondition = "";
string petPersonality = "";
string petNickName = "";

int maxPets = 8;
string? readResult;
string[,] ourAnimals = new string[maxPets, 6];

for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
        petSpecies = "dog";
        petId = "d1";
        petAge = "2";
        petPhysicalCondition = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
        petPersonality = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
        petNickName = "lola";
        break;
        
        case 1:
        petSpecies = "dog";
        petId = "d2";
        petAge = "9";
        petPhysicalCondition = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
        petPersonality = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
        petNickName = "loki";
        break;

        case 2:
        petSpecies = "cat";
        petId = "c3";
        petAge = "1";
        petPhysicalCondition = "small white female weighing about 8 pounds. litter box trained.";
        petPersonality = "friendly";
        petNickName = "Puss";
        break;

        case 3:
        petSpecies = "cat";
        petId = "c4";
        petAge = "?";
        petPhysicalCondition = "tbd";
        petPersonality = "tbd";
        petNickName = "tbd";
        break;

        default:
        petSpecies = "";
        petId = "";
        petAge = "";
        petPhysicalCondition = "";
        petPersonality = "";
        petNickName = "";
        break;

    }

    
        ourAnimals[i, 0] = petId;
        ourAnimals[i, 1] = petSpecies;
        ourAnimals[i, 2] = petAge;
        ourAnimals[i, 3] = petPhysicalCondition;
        ourAnimals[i, 4] = petPersonality;
        ourAnimals[i, 5] = petNickName;   
}

for (int i=0; i < maxPets; i++)
{
    if (!string.IsNullOrEmpty(ourAnimals[i,0]))
    {
        
        for (int j=0; j < 6; j++)
        {
            switch (j)
            {
                case 0:
                Console.WriteLine($"pet id: {ourAnimals[i,j]}");
                break;
                case 1:
                Console.WriteLine($"pet species: {ourAnimals[i,j]}");
                break;
                case 2:
                Console.WriteLine($"pet age: {ourAnimals[i,j]}");
                break;
                case 3:
                Console.WriteLine($"pet physical condition: {ourAnimals[i,j]}");
                break;
                case 4:
                Console.WriteLine($"pet personality: {ourAnimals[i,j]}");
                break;
                case 5:
                Console.WriteLine($"pet nickname: {ourAnimals[i,j]}");
                break;
                default:
                Console.WriteLine("break");
                break;
            }
        }
    }
}


string menuSelection = "";

string[] selections = new string[] { "Welcome to the Contoso PetFriends app. Your main menu options are: ", 
                                      "1. List all of our current pet information", 
                                      "2. Add a new animal friend to the ourAnimals array",
                                      "3. Ensure animal ages and physical descriptions are complete",
                                      "4. Ensure animal nicknames and personality descriptions are complete",
                                      "5. Edit an animal's age",
                                      "6. Edit an animal's personality description",
                                      "7. Display all cats with a specified characteristic",
                                      "8. Display all dogs with a specified characteristic",
                                      "Enter your selection number (or type Exit to exit the program)"
                                    } ;

do
{
    foreach (string selection in selections)
    {
        Console.WriteLine(selection);
    }

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower().Trim();
    }
    Console.WriteLine($"You selected a menu selection '{menuSelection}': \n");

    switch (menuSelection)
    {
        case "1":
        for (int i=0; i < maxPets; i++)
        {
            if (!string.IsNullOrEmpty(ourAnimals[i,0]))
            {
                
                for (int j=0; j < 6; j++)
                {
                    switch (j)
                    {
                        case 0:
                        Console.WriteLine($"pet id: {ourAnimals[i,j]}");
                        break;
                        case 1:
                        Console.WriteLine($"pet species: {ourAnimals[i,j]}");
                        break;
                        case 2:
                        Console.WriteLine($"pet age: {ourAnimals[i,j]}");
                        break;
                        case 3:
                        Console.WriteLine($"pet physical condition: {ourAnimals[i,j]}");
                        break;
                        case 4:
                        Console.WriteLine($"pet personality: {ourAnimals[i,j]}");
                        break;
                        case 5:
                        Console.WriteLine($"pet nickname: {ourAnimals[i,j]}");
                        break;
                        default:
                        Console.WriteLine("break");
                        break;
                    }
                }
            }
        }
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        if (readResult != null)
            {
                menuSelection = readResult.ToLower().Trim();
            }
        break;

        case "2":
        int petCount = 0;
        string anotherPet = "y";
        for(int i=0; i < maxPets; i++)
        {
            if(ourAnimals[i,0] != "")
            {
                petCount += 1;
            }
        }

        while (anotherPet == "y" && petCount < maxPets)
        {
                petCount ++;
                Console.WriteLine($"Total number of pets: {petCount}");

                bool validEntry = false;
                do
                {
                    Console.WriteLine("\n Enter dog or cat to enter a new entry");
                    readResult = Console.ReadLine();
                    if(readResult != null)
                    {
                        petSpecies = readResult.ToLower().Trim();
                    
                        if (petSpecies != "dog" && petSpecies != "cat")
                        {
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                            
                            Console.WriteLine($"You entered : {petSpecies}");
                            petId = petSpecies[..1] + petCount.ToString();
 
                            do
                            {
                                string animalAge;
                                int petAges;
                                Console.WriteLine("enter the pet age or '?' if it is unknown");
                                readResult = Console.ReadLine();
                                if(readResult != null)
                                {
                                    animalAge = readResult;
                                    if(animalAge != "?")
                                    {                                   
                                        validEntry = int.TryParse(animalAge, out petAges);
                                        petAge = petAges.ToString();
                                    }
                                    else
                                    {
                                        validEntry = true;
                                        petAge = "?";

                                    }
                                }
                            }while(readResult == null || validEntry == false);                          

                            do
                                {
                                    Console.WriteLine("describe the phsical aspects of the pet (size, color, gender, weight)");
                                    readResult = Console.ReadLine();
                                    if (readResult != null)
                                        {
                                            petPhysicalCondition = readResult.ToLower();
                                            if (petPhysicalCondition == "")
                                                {
                                                    petPhysicalCondition = "tbd";
                                                }
                                        } 
                                } while (readResult == null || petPhysicalCondition == "");
                                        
                            do
                                {
                                    Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                                    readResult = Console.ReadLine();
                                    if(readResult != null)
                                        {
                                            petPersonality = readResult.ToLower();
                                            if (petPersonality == "")
                                                {
                                                    petPersonality = "tbd";
                                                }
                                        }
                                } while (readResult == null || petPersonality == "");
                            do
                                {
                                    Console.WriteLine("Enter a nickname for the pet");
                                    readResult = Console.ReadLine();
                                    if(readResult != null)
                                        {
                                            petNickName = readResult.ToLower();
                                            if(petNickName == "")
                                                {
                                                    petNickName = "tbd";
                                                }                              
                                        }
                                } while (readResult == null || petNickName == "");
                        }
                    }
                }while(validEntry == false);

                ourAnimals[petCount, 0] = petId;
                ourAnimals[petCount, 1] = petSpecies;
                ourAnimals[petCount, 2] = petAge;
                ourAnimals[petCount, 3] = petPhysicalCondition;
                ourAnimals[petCount, 4] = petPersonality;
                ourAnimals[petCount, 5] = petNickName;    

                for (int j=0; j < 6; j++)
                {
                    switch (j)
                    {
                        case 0:
                        Console.WriteLine($"pet id: {ourAnimals[petCount,j]}");
                        break;
                        case 1:
                        Console.WriteLine($"pet species: {ourAnimals[petCount,j]}");
                        break;
                        case 2:
                        Console.WriteLine($"pet age: {ourAnimals[petCount,j]}");
                        break;
                        case 3:
                        Console.WriteLine($"pet physical condition: {ourAnimals[petCount,j]}");
                        break;
                        case 4:
                        Console.WriteLine($"pet personality: {ourAnimals[petCount,j]}");
                        break;
                        case 5:
                        Console.WriteLine($"pet nickname: {ourAnimals[petCount,j]}");
                        break;
                        default:
                        Console.WriteLine("break");
                        break;
                    }
                }

            if (petCount < maxPets)
            {
                    Console.WriteLine("Do you want to add another pet in our home care. type 'y' or 'n'.");

                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        anotherPet = readResult.ToLower().Trim();
                    }

                }while(anotherPet != "y" && anotherPet != "n");
            }
        }
            
        if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our maximum number of pets to accomadate in home care");
            }

        Console.WriteLine("Press the Enter key to continue.");

        readResult = Console.ReadLine();
        if (readResult != null)
            {
                menuSelection = readResult.ToLower().Trim();
            }
        break;

        case "3":
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "4":
        Console.WriteLine("Challenge Project - please check back soon to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "5":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "6":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "7":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        case "8":
        Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
        Console.WriteLine("Press the Enter key to continue.");
        readResult = Console.ReadLine();
        break;

        default:
        break;
    }
    
} while(menuSelection != "exit" || readResult != "exit");
    