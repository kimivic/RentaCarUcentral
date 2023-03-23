<?php

	$cons_usuario="root";
	$cons_contra="";
	$cons_base_datos="ucentral";
	$cons_equipo="localhost";
	$obj_conexion= mysql_connect($cons_equipo,$cons_usuario,$cons_contra,$cons_base_datos);
if (!$obj_conexion)
{
	die("No hay conexión:" .mysqli_connect_error());

}

$Id_Usuario = $_POST ["Id_Usuario"];
$Contraseña = $_POST ["Contraseña"];

$query = mysql_query($usurios, "SELECT * FROM login WHERE Id_Usuario= '".$Contraseña. "'");
$nr = mysqli_num_rows ($query);

if ($nr == 1)
{
	//header ("location: proyecto.html")
	echo "Bienvenido: "
}

else if ($nr == 0)
{
	echo "Usuario no existe";
}

?>