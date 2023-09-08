# 2_A_
  ♥   Cliente - Pedidos: composición, pues debe eliminarse con él
      Cadete - Cadetería: composición, pues deja de ser releante sin ella
      Pedidos - Cadete: agregación, pues pedido no depende del cadete, puede asignarse a otro
      
  ♥   Cadetería debería tener: agregarCadete(), quitarCadete(), cantidadPedidosCadete(), jornalAPagarCadete(), jornalAPagarTodos()
      Cadete debería tener: tomarPedido(), borrarPedido()
      
  ♥   Solo haría públicos a los métodos

  ♥   Cliente: 
      Cliente(nombre, direccion, telefono, referenciaDeDireccion){  
          this->nombre = nombre;
          this->direccion = direccion;
          this->telefono = telefono;  
          this->referenciaDeDireccion = referenciaDeDireccion;
      }
      Cliente(nombre, direccion, telefono){  
          this->nombre = nombre;
          this->direccion = direccion;
          this->telefono = telefono;
      }
      Pedidos: 
      Pedidos(numero, observaciones, cliente){
          this->numero = numero;
          this->observaciones = observaciones;
          this->cliente = cliente;
          this->estado = "sin atender";
      }      
      Pedidos(numero, cliente){
          this->numero = numero;
          this->cliente = cliente;
          this->estado = "sin atender";
      }
      Cadete:
      Cadete(ID, nombre, direccion, telefono){
          this->ID = ID;
          this->nombre = nombre;
          this->direccion = direccion;
          this->telefono = telefono;
          this->listadoPedidos = NULL;
      }
      Cadetería:
      Cadeteria(nombre, telefono){
          this->nombre = nombre;
          this->telefono = telefono;
          this->listadoCadetes = NULL;
      }
  ♥  Si, creando una relaicon entre Cadetería y Pedido para que sea Cadetería quien asigna los pedidos al Cadete
