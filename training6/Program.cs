class Player
{
    public static int playerHp = 100;
    public static int playerDamage = 15;
    public static int playerMoney = 0;
    public static int playerArmor = 0;
    public static string[] inventory = new string[4];


    class ShopItems
    {

        public static bool Sword = false;
        public static bool Axe = false;
        public static bool Katana = false;
        public static bool SteelArmor = false;
        public static bool ChainArmor = false;
        public static string choiceItems;
        public static string choiceItemInInventory;
        public static bool activeItem = false;

        class Program
        {
            static void Main()


            {
                {

                    bool inGame = true;
                    while (inGame)
                    {
                        Console.WriteLine("Выберите, куда пойти\nДолина боссов - 1\nМагазин - 2\nИнвентарь - 3");
                        Console.Write("Ваш выбор: ");
                        string choiceLocation = Console.ReadLine();
                        Console.Clear();
                        switch (choiceLocation)
                        {
                            case "1":
                                GoToBossValley();
                                break;
                            case "2":
                                GoToShop();
                                break;
                            case "3":
                                ChoiceInventory();
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Неверный выбор, попробуйте снова.");
                                break;
                        }
                    }
                }
            }

            static void GoToShop()
            {
                bool inShop = true;
                while (inShop)
                {
                    Console.WriteLine("Вы прибыли в магазин.\nУйти - 1\nПоказать товары - 2");
                    Console.Write("Ваш выбор: ");
                    string choiceShop = Console.ReadLine();
                    Console.Clear();
                    switch (choiceShop)
                    {
                        case "2":
                            ShowItems();
                            break;
                        case "1":
                            inShop = false;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор, попробуйте снова.");
                            Console.Clear();
                            break;
                    }
                }
            }

            static void ShowItems()
            {
                bool showItems = true;
                while (showItems)
                {
                    Console.WriteLine("\n\nСписок товаров на сегодня:");
                    Console.WriteLine($"\nВаш баланс {playerMoney} монет\n\n1)Sword - 100 монет\n\n2)Axe - 70 монет\n\n3)Katana - 200 монет\n\n4)ChainArmor - 200 монет\n\n5)SteelArmor - 300 монет\n");
                    Console.WriteLine("Введите номер предмета для преобретения или \"Уйти\" для выхода из магазина");
                    choiceItems = Console.ReadLine();
                    switch (choiceItems)
                    {
                        case "1":
                            if (playerMoney >= 100 && Sword == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы преобрели Sword");
                                Sword = true;
                                Inventory();
                                playerMoney = playerMoney - 100;
                            }
                            else if (playerMoney < 100)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас не достаточно средств");
                            }
                            else if (Sword == true)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас уже есть Sword");
                            }
                            break;
                        case "2":
                            if (playerMoney >= 70 && Axe == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы преобрели Axe");
                                Axe = true;
                                Inventory();
                                playerMoney = playerMoney - 70;
                            }
                            else if (playerMoney < 70)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас не достаточно средств");
                            }
                            else if (Axe == true)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас уже есть Axe");
                            }
                            break;
                        case "3":
                            if (playerMoney >= 200 && Katana == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы преобрели Katana");
                                Katana = true;
                                Inventory();
                                playerMoney = playerMoney - 200;
                            }
                            else if (playerMoney < 200)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас не достаточно средств");
                            }
                            else if (Katana == true)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас уже есть Katana");
                            }
                            break;
                        case "4":
                            if (playerMoney >= 200 && ChainArmor == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы преобрели ChainArmor");
                                ChainArmor = true;
                                Inventory();
                                playerMoney = playerMoney - 200;
                            }
                            else if (playerMoney < 200)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас не достаточно средств");
                            }
                            else if (ChainArmor == true)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас уже есть ChainArmor");
                            }
                            break;
                        case "5":
                            if (playerMoney >= 300 && SteelArmor == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Вы преобрели SteelArmor");
                                SteelArmor = true;
                                Inventory();
                                playerMoney = playerMoney - 300;
                            }
                            else if (playerMoney < 300)
                            {
                                Console.WriteLine("У вас не достаточно средств");
                            }
                            else if (SteelArmor == true)
                            {
                                Console.Clear();
                                Console.WriteLine("У вас уже есть SteelArmor");
                            }
                            break;
                        case "Уйти":
                            showItems = false;
                            Console.Clear();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Неверный ввод");
                            break;
                    }
                }
            }

            static void Inventory()
            {
                for (int i = 0; i < inventory.Length; i++)
                {
                    // Проверяем если место в инвентаре пустое
                    if (inventory[i] == null)
                    {
                        if (choiceItems == "1" && !inventory.Contains("Sword"))
                        {
                            inventory[i] = "Sword";
                            break;
                        }
                        else if (choiceItems == "2" && !inventory.Contains("Axe"))
                        {
                            inventory[i] = "Axe";
                            break;
                        }
                        else if (Katana == true && !inventory.Contains("Katana"))
                        {
                            inventory[i] = "Katana";
                            break;
                        }
                        else if (ChainArmor == true && !inventory.Contains("ChainArmor"))
                        {
                            inventory[i] = "ChainArmor";
                            break;
                        }
                        else if (SteelArmor == true && !inventory.Contains("SteelArmor"))
                        {
                            inventory[i] = "SteelArmor";
                            break;
                        }
                    }
                }

                Console.Write("\nВ вашем инвентаре: ");
                for (int i = 0; i < inventory.Length; i++)
                {
                    Console.Write(inventory[i] + " ");
                    if (inventory[i] == null)
                    {
                        Console.Write($"{i + 1}) Пусто ");
                    }
                }
            }
            static void ChoiceInventory()
            {
                Inventory();
                if (inventory != null)
                {
                    bool itemName = true;
                    while (itemName)
                    {
                        Console.WriteLine("\nВведите название предмета, чтобы его выбрать или нажмите enter, чтобы ничего не брать");
                        Console.Write("Ваш выбор: ");
                        string choiceItemInInventory = Console.ReadLine();
                        Console.Clear();

                        if (choiceItemInInventory != "" && inventory.Contains(choiceItemInInventory))
                        {
                            // Проверяем активирован ли уже предмет
                            if (activeItem == true)
                            {
                                ResetInventoryState();
                            }

                            Console.WriteLine($"Вы выбрали: {choiceItemInInventory}");

                            // Сбрасываем урон перед добавлением нового
                            playerDamage = 10;

                            switch (choiceItemInInventory)
                            {
                                case "Sword":
                                    playerDamage += 20;
                                    break;
                                case "Axe":
                                    playerDamage += 15;
                                    break;
                                case "Katana":
                                    playerDamage += 30;
                                    break;
                                case "ChainArmor":
                                    playerArmor += 20;
                                    break;
                                case "SteelArmor":
                                    playerArmor += 30;
                                    break;

                                default:
                                    break;
                            }
                            activeItem = true; // Устанавливаем флаг активного предмета
                            GoToBossValley();
                        }
                        else if (choiceItemInInventory == "")
                        {
                            Console.WriteLine("Вы ничего не взяли\n");
                            activeItem = false; // Сбрасываем активный предмет при выходе
                            GoToBossValley();
                        }
                        else
                        {
                            Console.Write("Такого предмета нету. Повторите попытку: ");
                            Inventory();
                        }
                    }
                }
            }

            // Метод для сброса состояния инвентаря
            static void ResetInventoryState()
            {
                activeItem = false; // Сброс флага активного предмета
                playerDamage = 15; // Сброс урона если необходимо
                playerHp = 100;
                playerArmor = 0;
            }



            static void GoToBossValley()
            {
                bool goToBoss = true;
                while (goToBoss)
                {
                    Console.WriteLine("Вы попали в \"Долину боссов\"\nПоказать список боссов - 1\nУйти - 2");
                    Console.Write("Ваш выбор: ");
                    string choiceBossOrLeave = Console.ReadLine();
                    Console.Clear();

                    if (choiceBossOrLeave == "1")
                    {
                        Console.WriteLine("Выберите номер босса, с которым хотите сразиться:\n1)Босс1\n2)Босс2\n3)Босс3");

                        string choiceBoss = Console.ReadLine();
                        if (choiceBoss != "")
                        {
                            switch (choiceBoss)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine("Вы выбрали Босс1");
                                    int hpBossOne = 100;
                                    int damageBossOne = 10;
                                    playerHp = 100;
                                    Console.WriteLine($"Ваша статистика:\n{playerHp} хп\n{playerArmor} брони\n{playerDamage} урона");
                                    playerHp = 100 + playerArmor;

                                    while (hpBossOne > 0 && playerHp > 0)
                                    {
                                        Console.WriteLine($"\nВаше здоровье: {playerHp}\nЗдоровье босса: {hpBossOne}");
                                        Console.WriteLine("Нажмите любую клавишу для выполнения действия:");
                                        Console.ReadKey();
                                        Console.Clear();
                                        playerHp -= damageBossOne;
                                        hpBossOne -= playerDamage;
                                    }
                                    if (playerHp > 0 && hpBossOne <= 0)
                                    {
                                        Console.WriteLine("Вы победили босса. Ваша награда - 100 монет\n");
                                        playerMoney = playerMoney + 100;
                                        playerHp = playerHp + playerArmor;
                                        Main();
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Вы проиграли");
                                        playerHp = 100 + playerArmor;
                                    }
                                    break;

                                case "2":
                                    Console.Clear();
                                    Console.WriteLine("Вы выбрали Босс2");
                                    int hpBossTwo = 150;
                                    int damageBossTwo = 20;
                                    Console.WriteLine($"Ваша статистика:\n{playerHp} хп\n{playerArmor} брони\n{playerDamage} урона");
                                    playerHp = 100 + playerArmor;

                                    while (hpBossTwo > 0 && playerHp > 0)
                                    {
                                        Console.WriteLine($"Ваше здоровье: {playerHp}\nЗдоровье босса: {hpBossTwo}");
                                        Console.WriteLine("Нажмите любую клавишу для выполнения действия:");
                                        Console.ReadKey();
                                        Console.Clear();
                                        playerHp = playerHp - damageBossTwo;
                                        hpBossTwo = hpBossTwo - playerDamage;
                                    }
                                    if (playerHp > 0 && hpBossTwo <= 0)
                                    {
                                        Console.WriteLine("Вы победили Босс2. Ваша награда - 200 монет");
                                        playerHp = playerHp + playerArmor;
                                        playerMoney = playerMoney + 200;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Вы проиграли");
                                        playerHp = 100 + playerArmor;
                                    }
                                    break;

                                case "3":
                                    Console.Clear();
                                    Console.WriteLine("Вы выбрали Босс3");
                                    int hpBossThree = 250;
                                    int damageBossThree = 40;
                                    Console.WriteLine($"Ваша статистика:\n{playerHp} хп\n{playerArmor} брони\n{playerDamage} урона");
                                    playerHp = 100 + playerArmor;

                                    while (hpBossThree > 0 && playerHp > 0)
                                    {
                                        Console.Clear();
                                        Console.WriteLine($"Ваше здоровье: {playerHp}\nЗдоровье босса: {hpBossThree}");
                                        Console.WriteLine("Нажмите любую клавишу для выполнения действия:");
                                        Console.ReadKey();
                                        playerHp = playerHp - damageBossThree;
                                        hpBossThree = hpBossThree - playerDamage;
                                    }
                                    if (playerHp > 0 && hpBossThree <= 0)

                                    {
                                        Console.Clear();
                                        Console.WriteLine("Вы победили Босс3. Ваша награда - 250 монет");
                                        playerHp = 100 + playerArmor;
                                        playerMoney = playerMoney + 200;
                                        continue;
                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Вы проиграли");
                                        playerHp = 100 + playerArmor;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Ошибка ввода");
                                    break;
                            }
                            break;
                        }
                        else if (choiceBoss == "")
                        {
                            Console.Clear();
                            Console.WriteLine("Ошибка ввода");
                        }
                    }
                    else if (choiceBossOrLeave == "2")
                    {
                        Main();
                        goToBoss = false;
                    }
                }
            }
        }
    }
}