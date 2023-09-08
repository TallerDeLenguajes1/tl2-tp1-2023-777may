namespace SistemaCadeteria;
class Cliente
{
    private string nombre;
    private string direccion;
    private int telefono;
    private string datosReferenciaDireccion;
    
    Cliente(string nombre, string direccion, int telefono, string datosReferenciaDireccion){  
        this->nombre = nombre;
        this->direccion = direccion;
        this->telefono = telefono;  
        this->datosReferenciaDireccion = datosReferenciaDireccion;
    }
    Cliente(string nombre, string direccion, int telefono){  
        this->nombre = nombre;
        this->direccion = direccion;
        this->telefono = telefono;
    }


}