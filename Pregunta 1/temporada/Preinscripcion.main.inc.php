<?php
session_start();
echo "Hola: ".$_SESSION["id"];
echo "<br>";

//include "conexion.inc.php";
$sql="select * from academico.alumno where id=".$_SESSION["id"];
$resultado=mysqli_query($con, $sql);
$fila=mysqli_fetch_array($resultado);
$nombrecompleto=$fila["nombrecompleto"];
?>