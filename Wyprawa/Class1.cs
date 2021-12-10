using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Type
{
    ghost = 1,
    ghoul = 2,
    wizard = 3,
    bat = 4
}

public abstract class Enemy 
{
    public int HP;
    public int Damage;
    public int attackRange;
    public bool isDead = false;
    public Type type{get; set;}
}

public class Ghost : Enemy
{
    public int HP = 5;
    public int Damage = 3;
    public int attackRange = 1;
    public bool isDead = false; 
    Type type = Type.ghost;
}
public class Ghoul : Enemy
{
    public int HP = 8;
    public int Damage = 2;
    public int attackRange = 2;
    public bool isDead = false;
    Type type = Type.ghoul;
}
public class Bat : Enemy
{
    public int HP = 5;
    public int Damage = 1;
    public int attackRange = 1;
    public bool isDead = false;
    Type type = Type.bat;
}
public class Wizard : Enemy
{
    public int HP = 4;
    public int Damage = 4;
    public int attackRange = 4;
    public bool isDead = false;
    Type type = Type.wizard;
}

