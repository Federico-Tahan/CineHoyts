------------------------------------------------------------------------------------------------------------
--CLIENTES QUE GASTARON MAS QUE EL PROMEDIO GENERAL
----------------------------------------------------------
CREATE OR alter procedure SP_GastoClientes
as
select p.nombre+SPACE(1)+p.apellido 'nombre',
b.barrio, trim(direccion)+SPACE(1)+trim(str(nro_direccion))'direccion', SUM(c.monto*c.cantidad)'importe'
from FACTURA f
join COMPROBANTE c on f.id_factura = c.id_factura
join CLIENTES  cl on f.id_cliente = cl.id_cliente
join PERSONAS p on cl.id_persona = p.id_persona
join BARRIOS b on b.id_barrio = p.id_barrio
where DATEDIFF(YEAR,f.fecha_pago, GETDATE()) =0  
group by p.nombre, p.apellido, b.barrio, direccion ,nro_direccion
having  SUM(c.monto*cantidad)> 
(select SUM(c.monto*cantidad)/COUNT(f.id_factura)
from factura  f
join COMPROBANTE c on c.id_factura = f.id_factura)
order by 1 asc

Create OR ALTER Proc SP_GetAvg
as
select SUM(c.monto*cantidad)/COUNT(f.id_factura) 'GastoPromedio'
from FACTURA f
join COMPROBANTE c on f.id_factura = c.id_factura


------------------------------------------------------------------------------------------------------------
--RECAUDACION X PROMOCION
----------------------------------------------------------

CREATE OR ALTER PROC SP_RECAUDACIONxPROMO
@montomin money
as
select tp.id_tipo_promocion,tp.tipo_promocion,
	sum(c.cantidad * c.monto) 'Importe_Generado', YEAR(f.fecha_pago)
	from factura f 
	join comprobante c on f.id_factura = c.id_factura
	join PROMOCION pr on pr.id_promocion=c.id_promocion
	join TIPO_PROMOCION tp on tp.id_tipo_promocion = pr.id_tipo_promocion
	join FUNCION pf on pf.id_funcion= c.id_funcion
	join PELICULA p on p.id_pelicula = pf.id_pelicula
	join RESTRICION_DE_EDAD re on re.id_restriccion = p.id_restriccion
	group by tp.id_tipo_promocion, YEAR(f.fecha_pago),tp.tipo_promocion
	having sum(c.cantidad * c.monto)>=@montomin

-----------------------------------------------------------------------------------------------
--GANANCIAS POR PELICULA DA RESULTADO SIN HAVING--ELEGIR ENTRE DTP 
--TORTA Y TABLA
CREATE or alter PROC SP_GananciasXPelicula
as
select p.titulo,duracion,descripcion, sum(c.monto*c.cantidad) 'ImporteGenerado', sum(cantidad) 'Espectadores'
from FACTURA f 
join comprobante c on f.id_factura = c.id_factura
join FUNCION pf on pf.id_funcion = c.id_funcion
join PELICULA p on p.id_pelicula= pf.id_pelicula
join RESTRICION_DE_EDAD re on p.id_restriccion=re.id_restriccion
where year(fecha_pago)=YEAR(getdate())
group by p.id_pelicula, P.titulo,duracion,descripcion



-----------------------------------
--GASTO TOTAL DE CLIENTES (DA RESULTADO SIN WHERE) elegir gastos anual o mensual y  elegir cliente
--mensual
create OR ALTER proc SP_GastoTotalDeClientes
@fecha1 datetime,
@fecha2 datetime,
@apellido varchar(50)
as
select c.id_cliente 'Codigo',p.nombre +' '+p.apellido 'Cliente', sum(co.cantidad * co.monto) 'CantidadGastado',sum(cantidad)'Entradascompradas'
from personas p 
join clientes c on p.id_persona = c.id_persona
join factura f on c.id_cliente = f.id_cliente
join comprobante co on co.id_factura = f.id_factura
where (fecha_pago between @fecha1 and @fecha2 ) and apellido like CONCAT('[A-',@apellido, ']%')
group by c.id_cliente ,p.nombre ,p.apellido

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
--tickets vendidos por vendedor

create or alter proc SP_TICKETSxVENDEDOR
AS
select  v.id_vendedor, p.nombre+SPACE (1)+ p.apellido 'Nombreyapellido' ,
p.nro_doc'numerodedocumento',COUNT(cantidad)'Cantidad'
from VENDEDORES V
join FACTURA f on f.id_vendedor = v.id_vendedor
join PERSONAS p on v.id_persona = p.id_persona
join comprobante c on c.id_factura = f.id_factura
group by v.id_vendedor,p.nombre,p.apellido,p.nro_doc
order by 2


----------------------------------------REPORTE-------------------------------------------------------------------------------
--MAYOR MENOR GASTO YA HECHO///////////////////////////////////////////
create OR ALTER procedure SP_MAYOR_MENOR_GASTO
AS
	select top 1 p.nombre+ ' '+ p.apellido'name', b.barrio, trim(direccion)+SPACE(1)+trim(str(nro_direccion))'direc', 
	sum(monto*cantidad)'totalgastado','Mayor Gasto' 'Top_Gasto'
	from FACTURA f
	join COMPROBANTE c on f.id_factura = c.id_factura
	join CLIENTES cl on cl.id_cliente = f.id_cliente
	join PERSONAS p on p.id_persona = cl.id_persona
	join BARRIOS b on b.id_barrio = p.id_barrio
	where DATEDIFF(YEAR,f.fecha_pago, GETDATE())= 0
	group by p.nombre, p.apellido, b.barrio, 
	direccion,str(nro_direccion)
	 having SUM(monto*cantidad)>=all (select SUM(monto * cantidad)
									 from FACTURA f1
									 join COMPROBANTE c1 on f1.id_factura = c1.id_factura
									 where f1.id_factura = c1.id_factura and 
									 DATEDIFF(YEAR,f1.fecha_pago, GETDATE()) = 0
									 group by f1.id_cliente)

	 union

	select top 1  p.nombre+ ' '+ p.apellido, b.barrio, trim(direccion)+SPACE(1)+trim(str(nro_direccion)), 
	sum(monto*cantidad)'total_gastado',
	'Menor Gasto' 'Top_Gasto'
	from FACTURA f
	join COMPROBANTE c on f.id_factura = c.id_factura
	join CLIENTES cl on cl.id_cliente = f.id_cliente
	join PERSONAS p on p.id_persona = cl.id_persona
	join BARRIOS b on b.id_barrio = p.id_barrio
	where DATEDIFF(YEAR,f.fecha_pago, GETDATE())= 0
	group by cl.id_cliente, p.nombre, p.apellido, b.barrio, 
	direccion, str(nro_direccion)
	 having SUM(monto*cantidad)<=all (select SUM(monto * cantidad)
	 from FACTURA f1
	 join COMPROBANTE c1 on f1.id_factura = c1.id_factura
	 where f1.id_factura = c1.id_factura and 
	 DATEDIFF(YEAR,f1.fecha_pago, GETDATE()) = 0
	 group by f1.id_cliente)
	 order by 4

------------------
--ELEGIR MINIMA CANTIDAD DE ESPECTADORES POR PARAMETRO
create OR ALTER proc SP_CANTIDAD_ENTRADAS_MIN
@MINIMO INT
AS
select p.id_pelicula, p.titulo, p.duracion, SUM(c.cantidad) 'cantidad_entradas'
from PELICULA p
join FUNCION fun on fun.id_pelicula = p.id_pelicula
join comprobante c on c.id_funcion = fun.id_funcion
join FACTURA f on f.id_factura = c.id_factura
group by p.id_pelicula, titulo, duracion
having SUM(c.cantidad) >= @MINIMO


-------------------------------------------------------------------------
------------------------------------------------------------------------------------------------
--RECAUDACION TOTAL DE PRODUCTORA
CREATE or alter PROC SP_RecaudacionPorFechas
as
SELECT pr.id_producto, pr.nombre, SUM(c.cantidad * c.monto)'Total', 'Año Actual'TIPO
FROM comprobante c
join funcion pf on c.id_funcion = pf.id_funcion
join PELICULA p on p.id_pelicula = pf.id_pelicula
join PRODUCTOR pr on pr.id_producto = p.id_productor
join PROMOCION pro on pro.id_promocion = c.id_promocion
join FACTURA f on f.id_factura = c.id_factura
join RESERVA r on r.id_factura = f.id_factura
where DATEDIFF (YEAR, r.FECHA_RESERVA, GETDATE()) = 0
group by pr.id_producto, pr.nombre


union

SELECT distinct  pr.id_producto, pr.nombre, SUM(c.cantidad * c.monto) 'Recaudacion', 'Desde el principio'TIPO
FROM comprobante c
join funcion pf on c.id_funcion = pf.id_funcion
join PELICULA p on p.id_pelicula = pf.id_pelicula
join PRODUCTOR pr on pr.id_producto = p.id_productor
join PROMOCION pro on pro.id_promocion = c.id_promocion
join FACTURA f on f.id_factura = c.id_factura
join RESERVA r on r.id_factura = f.id_factura
group by pr.id_producto, pr.nombre
order by 4 
	