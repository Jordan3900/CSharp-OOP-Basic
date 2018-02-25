using System;
using System.Collections.Generic;
using System.Linq;


    public class Potato
    {
        static void Main(string[] args)
        {
            long capacityOfBag = long.Parse(Console.ReadLine());
            string[] safe = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();
            long gold = 0;
            long gems = 0;
            long money = 0;

            for (int i = 0; i < safe.Length; i += 2)
            {
                string name = safe[i];
                long capacity = long.Parse(safe[i + 1]);

                string item = string.Empty;


                if (name.Length == 3)
                {
                    item = "Cash";
                }
                else if (name.ToLower().EndsWith("gem"))
                {
                    item = "Gem";
                }
                else if (name.ToLower() == "gold")
                {
                    item = "Gold";
                }

                if (item == "")
                {
                    continue;
                }
                else if (capacityOfBag < bag.Values.Select(x => x.Values.Sum()).Sum() + capacity)
                {
                    continue;
                }

                switch (item)
                {
                    case "Gem":
                        if (!bag.ContainsKey(item))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (capacity > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[item].Values.Sum() + capacity > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(item))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (capacity > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[item].Values.Sum() + capacity > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(item))
                {
                    bag[item] = new Dictionary<string, long>();
                }

                if (!bag[item].ContainsKey(name))
                {
                    bag[item][name] = 0;
                }

                bag[item][name] += capacity;
                if (item == "Gold")
                {
                    gold += capacity;
                }
                else if (item == "Gem")
                {
                    gems += capacity;
                }
                else if (item == "Cash")
                {
                    money += capacity;
                }
            }

            foreach (var item in bag)
            {
                Console.WriteLine($"<{item.Key}> ${item.Value.Values.Sum()}");
                foreach (var item2 in item.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
