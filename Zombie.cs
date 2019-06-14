using System;

namespace Parcial{
/*3 - En una película existen dos tipos de personajes
Los Humanos no infectados y los infectados (o zombies).
Los No infectados están vivos, los zombies: No.

Ambos comen, pero los zombies comen cerebros humanos.
Ambos caminan; pero los zombies caminan como....zombies.
Ambos emiten sonidos con la boca. Los no infectados hablan, los zombies hacen “Aggggggh!!!”
 */

public class Zombie:Personaje{

    public Zombie():base(){
        base.vive = false;
        base.infectado = true;
    }

    public override void  comer(){
        Console.WriteLine("come cerebros humanos.");
    }

    public override void caminar(){
        Console.WriteLine("camina como... Zombie.");
        
    }

    public override void hablar(){
        Console.WriteLine("dice: Aggggggh!!!");
    }

}
}
