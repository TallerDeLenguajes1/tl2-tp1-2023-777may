namespace SistemaCadeteria;
class Cadete
{
    private int ID;
    private string nombre;
    private string direccion;
    private int telefono;
    private Pedido listadoPedidos;
    Cadete(int ID, string nombre, string direccion, int telefono){
        this->ID = ID;
        this->nombre = nombre;
        this->direccion = direccion;
        this->telefono = telefono;
        this->listadoPedidos = NULL;
    }
    public void tomarPedido(){

    }
    public void borrarPedido(){

    }
}