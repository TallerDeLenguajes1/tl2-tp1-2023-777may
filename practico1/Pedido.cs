namespace SistemaCadeteria;
class Pedido
{
    private int numero;
    private string observaciones;
    private Cliente cliente;
    private string estado;
    Pedidos(int numero, string observaciones, Cliente cliente){
        this->numero = numero;
        this->observaciones = observaciones;
        this->cliente = cliente;
        this->estado = "sin atender";
    }      
    Pedidos(int numero, Cliente cliente){
        this->numero = numero;
        this->cliente = cliente;
        this->estado = "sin atender";
    }
}