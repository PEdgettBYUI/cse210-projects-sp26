using System;

public class Player
{
    public bool player_turn = true;


    public int Choice_Selector()
    {
        int player_choice = 0;
        if(player_turn == true)
        {
            Console.WriteLine("Select your move:\nAttack:\n1.Punch DNG:{Damage} SPEED:{Speed}\n2.Kick DNG:{Damage} SPEED:{Speed}\nMagic:\n3. Fireball DNG:{Damage} SPEED:{Speed}\n4. Air Cannon DNG:{Damage} SPEED:{Speed}\n5. Rock Throw DNG:{Damage} SPEED:{Speed}\nItems:\n6. Gun DNG:{Damage} SPEED:{Speed}\n7. Sword DNG:{Damage} SPEED:{Speed}\n8. HP Potion DNG:{Damage} SPEED:{Speed}");
            player_choice = int.Parse(Console.ReadLine());
        }
        return player_choice; 
    }

    public int Status_Damage();
    {
        while(player_turn == true)
        {

            switch(choice)
            {
                case 1:
                    

            }
        }

    }
    List <> Inventory = [];
    List <> Status_Effects = [];

}
