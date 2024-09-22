using System.ComponentModel.Design;
using static System.Net.Mime.MediaTypeNames;

namespace IFGame1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Ваше имя " + name);
            Console.WriteLine("Вы просыпаетесь и обнаруживаете себя в неизвестной комнате.\n" +
                "Перед вами закрытая дверь.\n" +
                "Вы осматриваетесь.\n" +
                "В комнате есть кровать, тумбочка, ящик в углу и странная статуя.\n" +
                "Окна в комнате нет, но вы видите вентиляционную шахту над стулом.");
            int aOne = 0;
            int aTwo = 0;
            int aThree = 0;
            int allArtefacts = 0;
            int aKey = 0;
            int aLockpick = 0;
            int aVentTry = 0;
        Beginning:
            Console.WriteLine("Ваши возможные действия:\n" +
                "Посмотреть на кровать(1)\n" +
                "Посмотреть на ящик(2)\n" +
                "Посмотреть на вентиляцию(3)\n" +
                "Посмотреть на тумбочку(4)\n" +
                "Посмотреть на статую(5)\n" +
                "Попытаться открыть дверь(6)\n" +
                "Введите номер действия(1-6)");
            int action = Convert.ToInt32(Console.ReadLine());
            if (action == 1)
            {
                if (aOne == 0)
                {
                    Console.WriteLine("Вы смотрите на кровать\n" +
                   "Вы замечаете что под кроватью что-то лежит\n" +
                   "Заглянуть под кровать?\n" +
                   "(Введите Да/Нет)");
                    string artefactOne = Console.ReadLine();
                    if (artefactOne == "Да")
                    {
                        Console.WriteLine(name + ", вы нашли странный артефакт!");
                        aOne = 1;
                        allArtefacts = allArtefacts + 1;
                        goto Beginning;
                    }
                    else goto Beginning;
                }
                else
                {
                    Console.WriteLine("Вы уже нашли здесь артефакт");
                    goto Beginning;
                }
            }
            if (action == 2)
            {
                Console.WriteLine("Вы смотрите на ящик\n" +
                    "Ящик заперт на ключ.");
                if (aKey == 1)
                {
                    Console.WriteLine("У вас есть ключ, и вы открываете ящик\n" +
                        "В нем лежит отмычка.");
                    Console.WriteLine(name + ", вы нашли отмычку!");
                    aLockpick = 1;
                    goto Beginning;
                }
                else if (aLockpick == 1)
                {
                    Console.WriteLine("У вас уже есть отмычка из ящика");
                    goto Beginning;
                }
                else
                {
                    Console.WriteLine("Нужно найти ключ.");
                    goto Beginning;
                }
            }
            if (action == 3)
            {
                Console.WriteLine("Вы смотрите на вентиляцию.");
                if (aTwo == 0)
                {
                    Console.WriteLine("Решетка вентиляции закрыта.\n" +
                        "Можно попытаться ее открыть.\n" +
                        "(Введите Да/Нет)");
                Ventillation:
                    string artefactTwo = Console.ReadLine();
                    if (artefactTwo == "Да")
                    {
                        Console.WriteLine("Вы пытаетесь открыть решетку.\n" +
                            "Она шатается.\n" +
                            "Попробовать еще раз?\n" +
                            "(Введите Да/Нет)");
                        aVentTry = aVentTry + 1;
                        if (aVentTry == 3)
                        {
                            Console.WriteLine(name + ", вы нашли странный артефакт!");
                            aTwo = 1;
                            allArtefacts = allArtefacts + 1;
                            goto Beginning;
                        }
                        else
                        {
                            goto Ventillation;
                        }
                    }
                    else
                    {
                        goto Beginning;
                    }
                }
                else
                {
                    Console.WriteLine("Вы уже нашли здесь артефакт");
                    goto Beginning;
                }
            }
            if (action == 4)
            {
                Console.WriteLine("Вы смотрите на тумбочку");
                if (aThree == 0)
                {
                    Console.WriteLine("Вы замечаете что на ней что-то лежит.");
                    Console.WriteLine(name + " , вы нашли странный артефакт!");
                    aThree = 1;
                    allArtefacts = allArtefacts + 1;
                    goto Beginning;
                }
                else
                {
                    Console.WriteLine("Вы уже нашли здесь артефакт.");
                    goto Beginning;
                }
            }
            if (action == 5)
            {
                Console.WriteLine("Вы смотрите на статую");
                if (aKey == 0)
                {
                    if (allArtefacts == 3)
                    {
                        Console.WriteLine("В статуе есть три отверстия.\n" +
                            "Видимо, если вставить в эти отверстия странные артефакты, что-то произойдет.\n" +
                            "Вставить артефакты?\n" +
                            "(Введите Да/Нет)\n");
                        string artefactThree = Console.ReadLine();
                        if (artefactThree == "Да")
                        {
                            Console.WriteLine("Из статуи выдвигается коробочка.\n" +
                                "В ней лежит ключ.\n" +
                                "Возможно, он от тумбочки.");
                            Console.WriteLine(name + " , вы нашли ключ!");
                            aKey = 1;
                            goto Beginning;
                        }
                    }
                    else
                    {
                        Console.WriteLine("В статуе есть три отверстия.\n" +
                            "Видимо, если вставить в эти отверстия странные артефакты, что-то произойдет.\n" +
                            "Пока что вы ничего не можете сделать.");
                        goto Beginning;
                    }
                }
                else
                {
                    Console.WriteLine("Вы уже нашли ключ.");
                    goto Beginning;
                }
            }
            if (action == 6)
            {
                Console.WriteLine("Вы смотрите на дверь.");
                if (aLockpick == 1)
                {
                    Console.WriteLine("Вы вскрываете дверь отмычкой.");
                    Console.WriteLine(name + " , поздравляем, вы смогли выбраться!\n" +
                        "Спасибо за игру!\n" +
                        "Конец игры.");
                }
                else
                {
                    Console.WriteLine("Дверь заперта. Вам нужна отмычка.");
                    goto Beginning;
                }
            }
        }
    }
}
