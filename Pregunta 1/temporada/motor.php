<?php
include "conexion.inc.php";
$flujo=$_GET["flujo"];
$proceso=$_GET["procesoanterior"];
$procesosiguiente=$_GET['proceso'];

$sql="select * from flujoproceso ";
$sql.="where Flujo='$flujo' and proceso='$proceso'";
$resultado=mysqli_query($con, $sql);
$fila=mysqli_fetch_array($resultado);
$pantalla=$fila['Pantalla'];
$pantalla.=".motor.inc.php";
include $pantalla;
if(isset($_GET["Anterior"]))
{ 
	$sql="select * from flujoproceso ";
	$sql.="where Flujo='$flujo' and procesosiguiente='$proceso'";
	$resultado1=mysqli_query($con, $sql);
	$fila1=mysqli_fetch_array($resultado1);
	//$proceso=$fila1["Proceso"];
	$procesosiguiente=$fila1['Proceso'];
	//echo $procesosiguiente;
}
header("Location: principal.php?flujo=$flujo&proceso=$procesosiguiente");

?>