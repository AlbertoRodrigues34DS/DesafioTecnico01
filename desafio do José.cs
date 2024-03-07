/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class desafio {
    
   static void Main() {
   static bool funcionando= true;
 while(funcionando){
    Console.WriteLine("Olá Link, novamente seja bem vindo ao Legends of Zelda, temos novidade!! Por favor escolha abaixo uma das opções");
    Console.WriteLine("1-> Suas notificações");
    Console.WriteLine("2-> Ganho de seguidores no último mês");
    Console.WriteLine("3-> Quantas Horas mensais ou diária que ficou no Zelda ");
    Console.WriteLine("4-> Arrumar o seu perfil");
    Console.WriteLine("5-> Sair");
    
    if(!string.TryParse(Console.ReadLine(), out escolha)){
        Console.WriteLine("Escolha inválida, por favor escolhe um das opções acima Link.");
        break;
    }
    
    switch(escolha){
        
        case 1:
        mostrar = notificacoes(tela);
        break;
        
        case 2: 
        
        Random aleatorio = new Random; 
        int seguidor = aleatorio.Next(50, 10000);
        Console.WriteLine($"O seu ganho no último mês foi de: {seguidores}");
        break;
        
        case 3:
        
        Console.ReadLine("Deseja ver hoje ou no mês? (1/2)");
        string opcao=Console.ReadLine;
        if(escolha==1){
        Random aleatorio = new Random; 
        float horas = aleatorio.Next(1.35, 12.23);
        Console.WriteLine($"Ao total de horas hoje: {horas}");
        break;
    }
    else{
        Random aleatorio = new Random; 
        float horas = aleatorio.Next();
        Console.WriteLine($"Ao total de horas mensal é : {horas}");
        break;
    }
    case 4:
    
    Console.WriteLine("Dados do seu perfil: ");
     string nome = Link;
     int idade = 18;
     float altura = 1.75;
     string frase = "Meu dever é proteger aquela que eu amo."
     Console.WriteLine($"Nome: {nome}");
     Console.WriteLine($"idade: {idade}");
     Console.WriteLine($"altura: {altura}");
     Console.WriteLine($"frase: {frase}");
     Console.WriteLine("O que deseja mudar?(digite somente o que está escrito antes de suas informações)");
     string escolha1 = Console.ReadLine();
     if(escolha1 == nome){
         Console.WriteLine("Por favor digite o novo nome: ");
         string alterado = Console.ReadLine();
         alterado = nome;
         Console.WriteLine($"Seu novo nome: {alterado}");
     }
    
    if(escolha1 == idade){
         Console.WriteLine("Por favor digite a nova idade: ");
         int alterado2 = Convert.ToInt32(Console.ReadLine());
         alterado2 = idade;
         Console.WriteLine($"Seu novo nome: {alterado2}");
        
    }
    if(escolha1 == altura){
         Console.WriteLine("Por favor digite a nova altura: ");
         float alterado3 = float.parse(Console.ReadLine());
         alterado = nome;
         Console.WriteLine($"Seu novo nome: {alterado3}");
    }
    if(escolha1 == frase){
         Console.WriteLine("Por favor digite a nova frase: ");
         string alterado4 = Console.ReadLine();
         alterado = nome;
         Console.WriteLine($"Seu novo nome: {alterado4}");
    }
    case 5:
     Console.WriteLine("Obrigado por estar aqui conosco, por favor volte sempre Link :D");
        funcionando = false;
    }
    static int notificacoes(){
        string [] novidade = {"Nas últimas 3 horas você teve um ganho de 100 seguidores.", "Seu último post bateu 2000 curtidas.","Zelda_do_LinkS2 mencionou em seu perfil.","Seus zeelris alcançou 100 mil pessoas, parabéns!!"}
        Random novidade = new Random();
        string tela = novidade.Next();
    }
    
  }
  }
}
}