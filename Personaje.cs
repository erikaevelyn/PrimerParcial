namespace Parcial{
/*3 - En una película existen dos tipos de personajes
Los Humanos no infectados y los infectados (o zombies).
Los No infectados están vivos, los zombies: No.

Ambos comen, pero los zombies comen cerebros humanos.
Ambos caminan; pero los zombies caminan como....zombies.
Ambos emiten sonidos con la boca. Los no infectados hablan, los zombies hacen “Aggggggh!!!”
 */

public abstract class Personaje{

    public bool vive;
    public bool infectado;
    

    public abstract void  comer();

    public abstract void caminar();

    public abstract void hablar();

}
}
