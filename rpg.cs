using System;
using System.Threading;
abstract class Base{
    protected int vida;
    protected int poder; 
    protected bool vivo=true;
    protected int velocidade;
     public void Curar(int valor){
        vida+=valor;}
    public void Receberdano(int dano,int defesa){
        vida-=(dano - defesa);
        if (vida < 0){vida = 0; vivo=false;}}
    public void Setvida(int vida){
        this.vida=vida;}
    public void Setpoder(char classe){
        switch (classe){
            case '1':
            poder = 25;
            break;
            case '2':
            poder = 30;
            break;
            case '3':
            poder = 35;
            break;}}
    public void Setvelocidade(char classe){
        switch (classe){
            case '1':
            velocidade = 35;
            break;
            case '2':
            velocidade = 30;
            break;
            case '3':
            velocidade = 25;
            break;}}

    public void Setvelo(int velocidade){
        this.velocidade=velocidade;}

    public void Setdan(int dano){
        poder=dano;}
        public void Equipar(int forca){
        poder+=forca;}

        public int Getvida()
        {return vida;}
        public int Getvelocidade()
        {return velocidade;}
        public int  Getpoder()
        {return poder;}
        public bool Getvivo()
        {return vivo;}
    }
class Jogador : Base{
    public string nome;
    public Jogador(string nome, char clas){
        this.nome=nome;
        Setvida(100);
        Setpoder(clas);
        Setvelocidade(clas);}}
class Inimigo : Base{
    public string tipo;
    public Inimigo(string tipo){
        this.tipo=tipo;
        int vida,poder,velocidade;
        Random random = new Random();
        vida=random.Next(40,100);
        poder=random.Next(25,40);
        velocidade=random.Next(25,40);
        Setvida(vida);
        Setdan(poder);
        Setvelo(velocidade);

    }
}
class Principal
{
    static void Pause(int tempo){
        Thread.Sleep(tempo);}
    static void Main(){
        string nome;
        char classe;
        char caminho;
        int equipamento;
        bool turnojogador=false;
        
      nome=nomeaçao();
      classe=escolhaclasse(nome);
      Jogador j1 = new Jogador(nome,classe);
      Inimigo i1=new Inimigo("druida");
      caminho=Caminho();
      equipamento=escolhido(caminho);
      j1.Equipar(equipamento);
      Console.WriteLine("os seus status atuais sao: \n vida:{0} \n poder:{1} \n velocidade:{2}",j1.Getvida(), j1.Getpoder(), j1.Getvelocidade());
      Console.WriteLine("------------------------------------------------------");
      Pause(1000);
      Console.WriteLine("os atributos do inimigo sao \n nome : {0} \n dano {1} \n velocidade {2} \n vida {3}",i1.tipo, i1.Getpoder(), i1.Getvelocidade(), i1.Getvida());
       Console.WriteLine("------------------------------------------------------");
     if (j1.Getvelocidade()>i1.Getvelocidade()){turnojogador=true;}
       Combate(turnojogador, j1, i1);
    }

static string nomeaçao(){
        Console.WriteLine("Boas vindas, novo jogador, Por Favor digite seu nome...");
        return Console.ReadLine();}
static char escolhaclasse(string jogador){
    char definicao;
         Console.WriteLine("------------------------------------------------------");
        Console.WriteLine(" Otimo {0}, agora vamos escolher uma classe",jogador);
        Console.WriteLine ("[1] Ninja (mais fraco porem veloz) \n[2] Guerreiro (bem equilibrado) \n[3] Tank (forte e lento)");
         while(!char.TryParse(Console.ReadLine(),out definicao)|| (definicao!='1' && definicao!='2' && definicao != '3')){
            Console.WriteLine("Escolha uma opçao valida");}
            Console.WriteLine("otima escolha! Vamos começar nossa jornada");
            Console.WriteLine("------------------------------------------------------");
            return definicao;}

 static char Caminho(){
        char escolha;
        Console.WriteLine("Ao entrar no castelo, voce se depara com dois corredores enomes, sendo o da esquerda pintado de branco e bem iluminado e o da direita pintado de azul, qual você vai seguir? [E] Esquerda | [D] Direita");
            while (!char.TryParse(Console.ReadLine(),out escolha) || (escolha!='E' && escolha!='D')){
            Console.WriteLine("escolha uma opçao valida.");}
            return escolha;}
static int escolhido(char direcao){
    int atributo=0;
    switch(direcao){
         case 'D':
        Console.WriteLine("você se depara com um grande bau vermelho, ao abrir voce recebe um novo talisma, que lhe da 12 pontos de dano a mais");
         atributo=12;
         Pause(1500);
         Console.WriteLine("ao olhar para tras apos pegar sua nova espada voce se depara com um pequeno druida que logo sorri para voce e saca sua espada");
          Pause(1000);
         break;
         case 'E':
         Console.WriteLine("Voce se encontra com algo fazendo barulho em sua frente, quando vai checar o que e emerge um pequeno druida, que logo sorri pra voce e saca sua espada");
         Pause(1000);
         break;}
         return atributo;}
        
        static void Combate(bool turno, Jogador jogador, Inimigo inimigo){
        Console.WriteLine ("Aquele com a maior velocidade ataca primeiro");
        Console.WriteLine("------------------------------------------------------");
        Pause(1000);
            int Defesaj1=0;
            int Defesai1=0;
           while (jogador.Getvivo() && inimigo.Getvivo()){
            char acao;
            int dano=0;
            int cura=0;
            int Danoj1=0;
            int Danoi1=0;
            if (turno){
     Console.WriteLine("o que deseja fazer? \n [1]Atacar \n [2]Ataque forte \n [3]curativo \n [4] segurar escudo");
         while(!char.TryParse(Console.ReadLine(),out acao)){
      Console.Write("Escolha uma opçao valida");}
        switch (acao){
          case'1':
              Danoj1=jogador.Getpoder();
              Danoj1-=Defesai1;
             Console.WriteLine("voce ataca o inimigo com sua espada e causa {0} dano",Danoj1);
             Pause(1000);
             inimigo.Receberdano(jogador.Getpoder(),Defesai1);
             turno=false;
              break;
        case '2':
             dano=jogador.Getpoder();
             dano+=10;
             Danoj1=(dano-Defesai1);
             Console.WriteLine("voce defere um ataque forte e perde vida no processo causando {0} dano",Danoj1);
                Pause(1000);
               inimigo.Receberdano(dano,Defesai1);
               jogador.Receberdano(5,0);
               turno=false;
              break;
         case '3':
           Random random= new Random();
           cura=random.Next(1,9);
           Console.WriteLine("seu curativo cura {0} pontos de vida", cura);
            Pause(1000);
           turno=false;
           break;
        case '4':
           Console.WriteLine("agora voce esta usando seu escudo");
            Pause(1000);
           Defesaj1=10;
           turno=false;
           break; }}
            else
            {
   Console.WriteLine("agora e a vez do {0}",inimigo.tipo);
    Pause(1000);
   int acaoseleciona=0;
   Random random= new Random();
   acaoseleciona=random.Next(1,5);
                switch(acaoseleciona){
                    case 1:
                    Danoi1=inimigo.Getpoder();
                    Danoi1-=Defesaj1;
                    Console.WriteLine("o inimigo te ataca e causa {0}",Danoi1);
                     Pause(1000);
                    jogador.Receberdano(inimigo.Getpoder(),Defesaj1);
                    turno=true;
                    break;
                    case 2:
                    cura=random.Next(1,12);
                    Console.WriteLine("o inimigo se cura {0} pontos",cura);
                     Pause(1000);
                    inimigo.Curar(cura);
                    turno=true;
                    break;
                    case 3:
                    Console.WriteLine("o inimigo convoca um escudo magico, o dando 15 de defesa permanente");
                     Pause(1000);
                    turno=true;
                    break;
                    case 4:
                    Console.WriteLine("grande sorte, o inimigo se destrai tocando flauta");
                     Pause(1000);
                    turno=true;
                    break;
                }}
                Console.WriteLine("sua vida restante e {0}", jogador.Getvida());
                 Console.WriteLine("------------------------");
                 Console.WriteLine("a vida restante do inimigo e {0}", inimigo.Getvida());
                  Pause(1000);
                
                }
                if (jogador.Getvivo()){
            Console.WriteLine("voce derrotou o inimigo");
            Console.WriteLine("obrigado por jogar");
            Environment.Exit(0); }
                else
        {
            Console.WriteLine("aqui e o fim para voce, Game Over");
            Environment.Exit(0);
        }
                
                
                }}
         