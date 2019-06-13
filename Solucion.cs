using System;

namespace Parcial{

    public class Solucion{

        /*1 - Ingresar un número y mostrar la suma de los números que lo anteceden. */

        public int anteceder(int num){ /*NOTA: asumo que se trata de un numero entero. */

        int result = 0;
        int elegido = num;

        for(int i=0; i<elegido; i++){

            result+=i;
        }
        return result;
        }

        /*2 - Se ingresa por teclado la temperatura máxima, en grados, día a día durante una semana.
        Se pide determinar el día de mayor temperatura, el de menor y el promedio. */
    /*NOTA: no aclara que hacer si hay mas de un dia de la semana que tiene menor o mayor temperatura, 
    considero que toma el primer dia que hubo esa temperatura*/
        public void calcularTemperatura(){

            int[] semana = new int[7];

            int maximo = 0;
            int minimo = 0;
            int diaMax = 0;
            int diaMin = 0;
            int sum = 0;
            int promedio = 0;

                for(int i=0; i<semana.Length; i++){
                    Console.WriteLine($"Ingrese una temperatura maxima para el dia {i+1}: ");
                    semana[i] = Convert.ToInt32(Console.ReadLine());
                    sum+=semana[i];

                    if(i==0){
                        diaMax=i;
                        maximo=semana[i];
                        diaMin=i;
                        minimo=semana[i];

                    }

                    if(maximo<semana[i]){
                        diaMax=i;
                        maximo=semana[i];
                    }

                    
                    if(minimo>semana[i]){
                        diaMin=i;
                        minimo=semana[i];
                    }
                }

            promedio = sum/semana.Length;
            Console.WriteLine($"La temperatura mayor fue {maximo} grados, el {diaMax+1}º dia de la semana");
            Console.WriteLine($"La temperatura menor fue {minimo} grados, el {diaMin+1}º dia de la semana");
            Console.WriteLine($"La temperatura promedio de esta semana fue {promedio} grados.");
            
            
        }

        /*
        Hacer un programa que:
        Cree dos instancias de zombie y un no infectado.
        Los agregue a un ArrayList.
        Luego recorra el array y, por cada uno de ellos muestre por pantalla:
        Si esta vivo o no
        Como come
        Como camina
        Hacerlo decir algo.*/

        public void actuar(){

            Personaje[] personajes = new Personaje[3];
            Zombie zombie1 = new Zombie();
            personajes[0] = zombie1;
            Zombie zombie2 = new Zombie();
            personajes[1] = zombie2;
            Humano humano = new Humano();
            personajes[2] = humano;

            for(int i=0; i<personajes.Length; i++){

                if(personajes[i].vive){
                    Console.WriteLine($"El personaje numero {i+1} esta vivo.");
                }else{
                    Console.WriteLine($"El personaje numero {i+1} no esta vivo.");
                }

                personajes[i].comer();
                personajes[i].caminar();
                personajes[i].hablar();
            }


        }
    }

}