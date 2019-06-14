using System;

namespace Parcial{

    public class Solucion{

        /*1 - Ingresar un número y mostrar la suma de los números que lo anteceden. */

        public void anteceder(){ /*NOTA: asumo que se trata de un numero entero. */

        Console.WriteLine("Ingrese un numero: ");
            int numero;
            bool conversion = Int32.TryParse(Console.ReadLine(), out numero);
            if(!conversion){
                do{
                Console.WriteLine($"El dato ingresado no es valido. Solo se aceptan numeros enteros."); 
                Console.WriteLine("Ingrese un numero: ");
                conversion = Int32.TryParse(Console.ReadLine(), out numero);
                }while(!conversion);    
            }

            int result = 0;

            for(int i=0; i<numero; i++){

                result+=i;
            }
                
            Console.WriteLine($"La suma de los números que anteceden al {numero} es: {result}");  
        }

        
        
        

        /*2 - Se ingresa por teclado la temperatura máxima, en grados, día a día durante una semana.
        Se pide determinar el día de mayor temperatura, el de menor y el promedio. */
    /*NOTA: Pide que determinemos EL (uno solo) dia de mayor/menor temperatura. No aclara que hacer 
    si hay mas de un dia de la semana que tiene menor o mayor temperatura. Considero que se toma el primer 
    dia que hubo esa temperatura como valor.*/
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

                    int numero;
                    bool conversion = Int32.TryParse(Console.ReadLine(), out numero);
                    if(!conversion){
                        do{
                        Console.WriteLine($"El dato ingresado no es valido. Solo se aceptan numeros enteros."); 
                        Console.WriteLine($"Ingrese una temperatura maxima para el dia {i+1}: ");
                        conversion = Int32.TryParse(Console.ReadLine(), out numero);
                        }while(!conversion);
                    }

                    semana[i] = numero;
                    sum+=semana[i];

                    if(i==0){
                        diaMax=i;
                        maximo=semana[i];
                        diaMin=i;
                        minimo=semana[i];

                    }else{

                        if(maximo<semana[i]){
                            diaMax=i;
                            maximo=semana[i];
                        }

                        
                        if(minimo>semana[i]){
                            diaMin=i;
                            minimo=semana[i];
                        }

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