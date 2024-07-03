# Stores

## Crear orden de compra
“Como usuario del sistema, deseo poder crear una orden de compra para solicitar productos del
almacén”.

### Datos de entrada
- Identificador del cliente
- Dirección de envío
- Ciudad de envío
- País de envío
- Código postal de envío
- Lista de productos incluyendo:
  - Identificador del producto
  - Precio
  - Cantidad
  
### Flujo primario
1. El usuario envía la solicitud “Crear orden de compra” con los datos de entrada.
2. El sistema registra la orden de compra.
3. El sistema confirma al usuario que su solicitud ha sido procesada notificándole el número de
la orden creada.

### Consideraciones
- Stores maneja 4 tipos de transporte de mercancías: Marítimo, Aéreo, Ferroviario y
Terrestre. El tipo de transporte predeterminado es Terrestre.
- Stores maneja 2 formas para especificar descuentos: Mediante porcentaje y mediante
cantidades absolutas. El descuento predeterminado de una compra es del 10%.
- La fecha de la orden de compra corresponderá a la fecha y hora en la que sea creada.
- Si en la orden se especifican productos con el mismo identificador de producto, solo se
agregará un producto con ese identificador y la cantidad registrada será la suma de las
cantidades de los productos con el mismo identificador.
