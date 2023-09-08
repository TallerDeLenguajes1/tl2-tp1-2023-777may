namespace SistemaCadeteria;

class Cadeteria
{
    private string nombre;
    private int telefono;
    private Cadete listadoCadetes;

    Cadeteria(string nombre, int telefono){
        this->nombre = nombre;
        this->telefono = telefono;
        this->listadoCadetes = NULL;
    }
    public void agregarCadete(){

    } 
    public void quitarCadete(){

    }
    public int cantidadPedidosCadete(){

    }
    public float jornalAPagarCadete(){

    } 
    public float jornalAPagarTodos(){

    }
    private void altaPedido(){ //seria privado para poder llamarlo en asignarlo a cadete

    }

    public void asignarPedidoCadete(){

    }

    public void cambiarEstadoPedido(){

    }
    
    public void reasignarPedido(){

    }
    public void informeJornada(){
        //monto ganado y la cantidad de envíos de cada cadete y el total. Muestre también la cantidad de envíos promedio por cadete
    }
}