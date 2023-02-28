namespace classes;

class classeBanco{
     public bool sacar;
     public bool deposito;
     public bool transacao;      
     public bool tirar;

    public string agencia;

     public string tipo;

      public int valor;

       public int conta;

       public void saque(){
         sacar = true;
       }

       public void deposito(){
        deposito = false;
        
       }

       public void transacao(){
        transacao = true;
       }

       public void extrato(){
        tirar = true;
        
       }
}
