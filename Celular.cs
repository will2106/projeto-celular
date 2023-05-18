using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_celular
{
    public class Celular
    {
        
 
 
 // Propriedades       
public string Cor { get; set; }


public string Modelo { get; set; }




public string Tamanho { get; set; }



//Metodos
public void Ligar(){

Console.WriteLine($"Ligando...");

return; 

}


public void Desligado()

{

Console.WriteLine($"Desligando o celular...");

return ;


}



public void FazerLigacao(){
Console.WriteLine($"Fazendo ligacao...");

return ;


}


public void EnviarMensagem(){
Console.WriteLine($"Enviando Mensagem...");



return ;

}










    }
}