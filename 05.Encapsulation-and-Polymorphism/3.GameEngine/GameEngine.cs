using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3.GameEngine.Characters;
using _3.GameEngine.Interfaces;
using _3.GameEngine.Items;

namespace _3.GameEngine
{
    public class Engine
    {
        private const int GameTurns = 4;

        protected List<Character> characterList = new List<Character>();
        protected List<Bonus> timeoutItems;

        public virtual void Run()
        {
            ReadUserInput();
            InitializeTimeoutItems();
            for (int i = 0; i < GameTurns; i++)
            {
                foreach (var character in characterList)
                {
                    if (character.IsAlive)
                    {
                        ProcessTargetSearch(character);
                    }
                }
                ProcessItemTimeout(timeoutItems);
            }
            PrintGameOutcome();
        }

        private void ReadUserInput()
        {
            string inputLine = Console.ReadLine();
            while (inputLine != "")
            {
                string[] parameters = inputLine.Split(
                    new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                ExecuteCommand(parameters);
                inputLine = Console.ReadLine();
            }
        }

        public void ProcessItemTimeout(List<Bonus> timeoutItems)
        {
            for (int i = 0; i < timeoutItems.Count; i++)
            {
                timeoutItems[i].Countdown--;
                if (timeoutItems[i].Countdown == 0)
                {
                    var item = timeoutItems[i];
                    item.HasTimedOut = true;
                    var itemHolder = GetCharacterByItem(item);

                    //itemHolder.RemoveItemEffects(item);
                    itemHolder.RemoveFromInventory(item);
                    i--;
                }
            }
        }

        public void InitializeTimeoutItems()
        {
            timeoutItems = characterList
                .SelectMany(c => c.Inventory)
                .Where(i => i is Bonus)
                .Cast<Bonus>()
                .ToList();
        }
        //Implemented
        protected virtual void ExecuteCommand(string[] inputParams)
        {
            switch (inputParams[0])
            {
                case "status":
                    PrintCharactersStatus(characterList);
                    break;
                case "create":
                    CreateCharacter(inputParams);
                    break;
                case "add":
                    AddItem(inputParams);
                    break;
                default:
                    break;
            }
        }
        // Implemented 
        protected virtual void CreateCharacter(string[] inputParams)
        {
            string id = inputParams[2];
            int x = int.Parse(inputParams[3]);
            int y = int.Parse(inputParams[4]);

            Team team;
            if (inputParams[5] == "Blue")
            {
                team = Team.Blue;
            }
            else
            {
                team = Team.Red;
            }

            if (inputParams[1] == "warrior")
            {
                Character warrior = new Warrior(id, x, y, 0, 0, team, 0);
                characterList.Add(warrior);
            }
            else if (inputParams[1] == "mage")
            {
                Character mage = new Mage(id, x, y, 0, 0, team, 0);
                characterList.Add(mage);
            }
            else
            {
                Character healer = new Healer(id, x, y, 0, 0, team, 0);
                characterList.Add(healer);
            }
        }
        // Implemented 
        protected void AddItem(string[] inputParams)
        {
            string characterId = inputParams[1];
            string itemClass = inputParams[2];
            string itemId = inputParams[3];

            Character itemOwner = GetCharacterById(characterId);
            string type = itemOwner.GetType().Name;


            if (itemClass == "injection")
            {
                Bonus injection = new Injection(itemId, 0, 0, 0);
                itemOwner.AddToInventory(injection);
                //ApplyItemEffectByType(itemOwner, type, injection);

            }
            else if (itemClass == "pill")
            {
                Bonus pill = new Pill(itemId, 0, 0, 0);
                itemOwner.AddToInventory(pill);
                //ApplyItemEffectByType(itemOwner, type, pill);

            }
            else if (itemClass == "axe")
            {
                Item axe = new Axe(itemId, 0, 0, 0);
                itemOwner.AddToInventory(axe);
            }
            else if (itemClass == "shield")
            {
                Item shield = new Shield(itemId, 0, 0, 0);
                itemOwner.AddToInventory(shield);
            }
        }

        protected void ProcessTargetSearch(Character currentCharacter)
        {
            var availableTargets = characterList
                .Where(t => IsWithinRange(currentCharacter.X, currentCharacter.Y, t.X, t.Y, currentCharacter.Range)).ToList();
            if (availableTargets.Count == 0)
            {
                return;
            }
            var target = currentCharacter.GetTarget(availableTargets);
            if (target == null)
            {
                return;
            }
            ProcessInteraction(currentCharacter, target);
        }

        protected void ProcessInteraction(Character currentCharacter, Character target)
        {
            if (currentCharacter is IHeal)
            {
                target.HealthPoints += (currentCharacter as IHeal).HealingPoints;
            }
            else if (currentCharacter is IAttack)
            {
                target.HealthPoints -= (currentCharacter as IAttack).AttackPoints - target.DefensePoints;
                if (target.HealthPoints <= 0)
                {
                    target.IsAlive = false;
                }
            }
        }

        protected bool IsWithinRange(int attackerX, int attackerY,
            int targetX, int targetY, int range)
        {
            double distance = Math.Sqrt(
                (attackerX - targetX) * (attackerX - targetX) +
                (attackerY - targetY) * (attackerY - targetY)
                );
            return distance <= (double)range;
        }

        protected Character GetCharacterById(string characterId)
        {
            return characterList.FirstOrDefault(x => x.Id == characterId);
        }

        protected Character GetCharacterByItem(Item item)
        {
            return characterList.FirstOrDefault(x => x.Inventory.Contains(item));
        }

        protected void PrintCharactersStatus(IEnumerable<Character> characters)
        {
            foreach (var character in characters)
            {
                Console.WriteLine(character.ToString());
            }
        }

        protected void PrintGameOutcome()
        {
            var charactersAlive = characterList.Where(c => c.IsAlive);
            var redTeamCount = charactersAlive.Count(x => x.Team == Team.Red);
            var blueTeamCount = charactersAlive.Count(x => x.Team == Team.Blue);
            if (redTeamCount == blueTeamCount)
            {
                Console.WriteLine("Tie game!");
            }
            else
            {
                string winningTeam = redTeamCount > blueTeamCount ? "Red" : "Blue";
                Console.WriteLine(winningTeam + " team wins the game!");
            }
            var aliveCharacters = characterList.Where(c => c.IsAlive);
            PrintCharactersStatus(aliveCharacters);
        }
    }
}
