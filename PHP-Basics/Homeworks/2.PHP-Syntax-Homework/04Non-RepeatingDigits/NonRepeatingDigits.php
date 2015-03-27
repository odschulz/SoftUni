<?php
$N = 1002;
if ($N > 101) {
	for ($i=102; $i <= $N; $i++) { 
		if (hasUniqueDigits($i)) {
			echo "$i\n";
		}
	}
} else {
	echo "no";
}
function hasUniqueDigits($number)
{
	$pattern = '/(\d)(\d)*\1+/';
	if (preg_match($pattern, $number) > 0) {
		return false;
	} else {
		return true;
	}
	
}
?>