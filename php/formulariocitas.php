<?php
include ("inc/fechas.php");
include ("inc/usarBD.php");
$consulta="SELECT * FROM citas WHERE diacita='".$fechaEnCurso."' ORDER BY horacita;";
$hacerConsulta=mysql_query($consulta, $conexion);
$numeroDeCitasDelDia=mysql_num_rows($hacerConsulta);
echo ("Citas del día: ".$numeroDeCitasDelDia.salto);
echo ($diaActual." del ".$mesActual." de ".$annioActual);
echo ("<table width='500' border='0' cellspacing='0' cellpadding='0'>");
while ($cita = mysql_fetch_array($hacerConsulta, MYSQL_ASSOC)) {
echo ("<tr><td>".$cita["horacita"]."</td>");
echo ("<td>".$cita["asuntocita"]."</td>");
<form action="" method="post" name="formularioCitasPrincipal" id="formularioCitasPrincipal">
<input type="hidden" name="fechaEnCurso" id="fechaEnCurso" value="<?php echo($fechaEnCurso); ?>">
<table width="500" border="0" cellspacing="0" cellpadding="0">
<tr><th>CITAS</th></tr>
</table>
echo ("<table width='500' border='0' cellspacing='0' cellpadding='0'>");
while ($cita = mysql_fetch_array($hacerConsulta, MYSQL_ASSOC)) {
echo ("<tr><td>".$cita["horacita"]."</td>");
echo ("<td>".$cita["asuntocita"]."</td>");
echo ("<td><input type='radio' id='citaSeleccionada' name='citaSeleccionada' value='".$cita["idcita"]."'>");
echo ("</td></tr>");
}
echo ("</table>");
echo ("<input name='borrarCita' type='button' id='borrarCita' value='Eliminar Cita' onClick='javascript:saltar("eliminarCita.php");'>".salto);
echo ("<input name='cambiarCita' type='button' id='cambiarCita' value='Modificar cita' onClick='javascript:saltar("cambiarCita.php");'>".salto);
}
/* En todo caso se mostrarán los botones de agregar cita y cambiar la fecha en curso. */
echo ("<input name='nuevaCita' type='button' id='nuevaCita' value='Agregar cita' onClick='javascript:saltar("agregarCita.php");'>".salto);
echo ("<input name='cambiarFecha' type='button' id='cambiarFecha' value='Otro día' onClick='javascript:saltar("cambiarFecha.php");'>".salto);
?>


