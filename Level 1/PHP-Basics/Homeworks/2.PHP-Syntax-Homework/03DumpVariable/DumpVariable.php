<?php
$arr = ["hello", 15, 1.234, array(1,2,3), (object)[2,34]];
for ($i=0; $i < count($arr); $i++) { 
	if (is_numeric($arr[$i])) {
		echo var_dump($arr[$i]);
	} else {
		echo gettype($arr[$i]) . "\n";
	}
	
}
?>