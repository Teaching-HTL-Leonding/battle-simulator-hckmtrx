#region Constants
const int PIRATE_HEALTH = 20;
const int PIRATE_ATTACK = 3;
const int PIRATE_ARMOR = 3;
const int PIRATE_SPEED = 3;

const int STONE_CHEWER_HEALTH = 50;
const int STONE_CHEWER_ATTACK = 8;
const int STONE_CHEWER_ARMOR = 10;
const int STONE_CHEWER_SPEED = 1;

const int GHOST_WARRIOR_HEALTH = 20;
const int GHOST_WARRIOR_ATTACK = 2;
const int GHOST_WARRIOR_ARMOR = 2;
const int GHOST_WARRIOR_SPEED = 5;

const int OUTWORLDER_HEALTH = 15;
const int OUTWORLDER_ATTACK = 1;
const int OUTWORLDER_ARMOR = 2;
const int OUTWORLDER_SPEED = 10;

const int MONSTER_KNIGHT_HEALTH = 15;
const int MONSTER_KNIGHT_ATTACK = 4;
const int MONSTER_KNIGHT_ARMOR = 3;
const int MONSTER_KNIGHT_SPEED = 3;
#endregion

int pirate_wins = 0;
const int DARK_GOBLIN_HEALTH = 10;
const int DARK_GOBLIN_ATTACK = 1;
const int DARK_GOBLIN_ARMOR = 8;
const int DARK_GOBLIN_SPEED = 3;

int stone_chewer_wins = 0;
int ghost_warrior_wins = 0;
int outworlder_wins = 0;
int monster_knight_wins = 0;
int dark_goblin_wins = 0;
int draws = 0;

int random_character1;
double random_character1_health;
int random_character1_attack;
double random_character1_armor;
int random_character1_speed;

int random_character2;
double random_character2_health;
int random_character2_attack;
double random_character2_armor;
int random_character2_speed;

Console.WriteLine("Welcome to the battle simulator!");

for (int i = 0; i < 10_000; i++)
{
    random_character1 = Random.Shared.Next(0, 6);
    switch (random_character1)
    {
        case 0:
            random_character1_health = PIRATE_HEALTH;
            random_character1_attack = PIRATE_ATTACK;
            random_character1_armor = PIRATE_ARMOR;
            random_character1_speed = PIRATE_SPEED;
            break;
        case 1:
            random_character1_health = STONE_CHEWER_HEALTH;
            random_character1_attack = STONE_CHEWER_ATTACK;
            random_character1_armor = STONE_CHEWER_ARMOR;
            random_character1_speed = STONE_CHEWER_SPEED;
            break;
        case 2:
            random_character1_health = GHOST_WARRIOR_HEALTH;
            random_character1_attack = GHOST_WARRIOR_ATTACK;
            random_character1_armor = GHOST_WARRIOR_ARMOR;
            random_character1_speed = GHOST_WARRIOR_SPEED;
            break;
        case 3:
            random_character1_health = OUTWORLDER_HEALTH;
            random_character1_attack = OUTWORLDER_ATTACK;
            random_character1_armor = OUTWORLDER_ARMOR;
            random_character1_speed = OUTWORLDER_SPEED;
            break;
        case 4:
            random_character1_health = MONSTER_KNIGHT_HEALTH;
            random_character1_attack = MONSTER_KNIGHT_ATTACK;
            random_character1_armor = MONSTER_KNIGHT_ARMOR;
            random_character1_speed = MONSTER_KNIGHT_SPEED;
            break;
        case 5:
            random_character1_health = DARK_GOBLIN_HEALTH;
            random_character1_attack = DARK_GOBLIN_ATTACK;
            random_character1_armor = DARK_GOBLIN_ARMOR;
            random_character1_speed = DARK_GOBLIN_SPEED;
            break;
        default:
            return;
    }

    random_character2 = Random.Shared.Next(0, 6);
    switch (random_character2)
    {
        case 0:
            random_character2_health = PIRATE_HEALTH;
            random_character2_attack = PIRATE_ATTACK;
            random_character2_armor = PIRATE_ARMOR;
            random_character2_speed = PIRATE_SPEED;
            break;
        case 1:
            random_character2_health = STONE_CHEWER_HEALTH;
            random_character2_attack = STONE_CHEWER_ATTACK;
            random_character2_armor = STONE_CHEWER_ARMOR;
            random_character2_speed = STONE_CHEWER_SPEED;
            break;
        case 2:
            random_character2_health = GHOST_WARRIOR_HEALTH;
            random_character2_attack = GHOST_WARRIOR_ATTACK;
            random_character2_armor = GHOST_WARRIOR_ARMOR;
            random_character2_speed = GHOST_WARRIOR_SPEED;
            break;
        case 3:
            random_character2_health = OUTWORLDER_HEALTH;
            random_character2_attack = OUTWORLDER_ATTACK;
            random_character2_armor = OUTWORLDER_ARMOR;
            random_character2_speed = OUTWORLDER_SPEED;
            break;
        case 4:
            random_character2_health = MONSTER_KNIGHT_HEALTH;
            random_character2_attack = MONSTER_KNIGHT_ATTACK;
            random_character2_armor = MONSTER_KNIGHT_ARMOR;
            random_character2_speed = MONSTER_KNIGHT_SPEED;
            break;
        case 5:
            random_character2_health = DARK_GOBLIN_HEALTH;
            random_character2_attack = DARK_GOBLIN_ATTACK;
            random_character2_armor = DARK_GOBLIN_ARMOR;
            random_character2_speed = DARK_GOBLIN_SPEED;
            break;
        default:
            return;
    }

    while (random_character1_health > 0 && random_character2_health > 0)
    {
        double random_character1_attack_damage = 0;
        for (int j = 0; j < random_character1_speed; j++)
        {
            random_character1_attack_damage += random_character1_attack * Random.Shared.Next(85, 116) / 100d;
        }
        double random_character2_attack_damage = 0;
        for (int j = 0; j < random_character2_speed; j++)
        {
            random_character2_attack_damage += random_character2_attack * Random.Shared.Next(85, 116) / 100d;
        }

        if (random_character1_armor != 0)
        {
            random_character1_armor -= random_character2_attack_damage;
            if (random_character1_armor < 0) { random_character1_health += random_character1_armor; random_character1_armor = 0; }
        }
        else { random_character1_health -= random_character2_attack_damage; }
        if (random_character1_health < 0) { random_character1_health = 0; }

        if (random_character2_armor != 0)
        {
            random_character2_armor -= random_character1_attack_damage;
            if (random_character2_armor < 0) { random_character2_health += random_character2_armor; random_character2_armor = 0; }
        }
        else { random_character2_health -= random_character1_attack_damage; }
        if (random_character2_health < 0) { random_character2_health = 0; }
    }

    if (random_character1_health <= 0 && random_character2_health <= 0) { draws++; }
    else if (random_character1_health <= 0)
    {
        switch (random_character2)
        {
            case 0:
                pirate_wins++;
                break;
            case 1:
                stone_chewer_wins++;
                break;
            case 2:
                ghost_warrior_wins++;
                break;
            case 3:
                outworlder_wins++;
                break;
            case 4:
                monster_knight_wins++;
                break;
            case 5:
                dark_goblin_wins++;
                break;
            default:
                return;
        }
    }
    else
    {
        switch (random_character1)
        {
            case 0:
                pirate_wins++;
                break;
            case 1:
                stone_chewer_wins++;
                break;
            case 2:
                ghost_warrior_wins++;
                break;
            case 3:
                outworlder_wins++;
                break;
            case 4:
                monster_knight_wins++;
                break;
            case 5:
                dark_goblin_wins++;
                break;
            default:
                return;
        }
    }
}

Console.WriteLine();

const string OUTPUT = "{0} won {1} times";
Console.WriteLine(OUTPUT, "Pirate", pirate_wins);
Console.WriteLine(OUTPUT, "Stone Chewer", stone_chewer_wins);
Console.WriteLine(OUTPUT, "Ghost Warrior", ghost_warrior_wins);
Console.WriteLine(OUTPUT, "Outworlder", outworlder_wins);
Console.WriteLine(OUTPUT, "Monster Knight", monster_knight_wins);
Console.WriteLine(OUTPUT, "Dark Goblin", dark_goblin_wins);
Console.WriteLine("Draw occurred " + draws + " many times");