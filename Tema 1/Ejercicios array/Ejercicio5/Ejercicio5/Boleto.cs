using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Boleto
    {
        private int[] Numboleto;

        private int numeroAleatorio()
        {
            return new Random().Next(1, 50);
        }
        public Boleto()
        {
            bool salir = false;
            Numboleto = new int[6];
            int numeroAleatorios;
            for (int i = 0; i < Numboleto.Length; i++) {



                do
                {
                    numeroAleatorios = numeroAleatorio();
                    salir = false;

                    for (int j = 0; j < i; j++)
                    {


                        if (numeroAleatorios == Numboleto[j])
                        {
                            salir = true;
                            break;
                        }
                    }
                } while (salir);
                Numboleto[i] = numeroAleatorios;
            }
        }


        public int ObtenerPosicion(int indice)
        {
            return Numboleto[indice];
        }

        public int[] ObtenerNumeros()
        {
            return Numboleto;
        }

        public override bool Equals(object boletoParametro){
            bool flag = false;
            if (boletoParametro != null && boletoParametro is Boleto) 
            { 
                Boleto boletoRecibido = (Boleto)boletoParametro;
                for(int i = 0;i < Numboleto.Length; i++)
                {   
                    flag = false;
                    for (int j = 0; j<boletoRecibido.ObtenerNumeros().Length; j++)
                    {
                        if (this.Numboleto[i] == boletoRecibido.ObtenerPosicion(j))
                        {
                            flag = true;
                        }
                    }
                    if (flag == false)
                    {
                        return false;//Si en una vuelta completa(del for con j) uno no coincide se sale directamente por q no va a coincidir
                    }
                }
                return true;//Si llegas aqui es por q se ha encontrado siempre un numero q coincide en minimo una vuelta del for(vuelda del for con j)
                

            }
            return false;//No hace nada por q no llegamos aqui pero si lo quito no funciona
        }



    }
}

//No puede haber dos numeros iguales en el mismo boleto
//No puede habeer un boleto con los 6 mismos numeros es decir 1 al 6 y lg otro q cambie minimo un numero 