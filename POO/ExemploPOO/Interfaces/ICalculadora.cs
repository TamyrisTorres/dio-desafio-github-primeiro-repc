namespace ExemploPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
        

// Colocar a Letra I no nome da Interface;
// Por padrão a interface será public, não precisa de modificar de acesso. 
// A interface veio para sanar o problema da falta de multiplas heranças no Csharpe, que não existia.
// Aqui precisa ser incluido, por padrão, as assinaturas dos metodos. 
    }
}