<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
	<title>CV Generator</title>
	<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
</head>
<body>

<?php
session_start();
$errorMessages = [];
if (submitted() && validated()) {
	$_SESSION = [];
	foreach ($_POST as $key => $val) { 
 		$_SESSION[$key] = $val; 
	}
	require "includes/CVOutput.php";
} else {
	require "includes/CVForm.html";
	if (!empty($errorMessages)) {
		foreach ($errorMessages as $value): ?>
			<div class="errorMessages"><?php echo $value; ?></div>
		<?php endforeach;
	}
}

?>

<?php
function submitted()
{
	$inputFields = ['fName', 'lName', 'email', 'phone', 'gender', 'bdate', 'nationality', 'companyName', 
	'fromDate', 'toDate', 'progLangs', 'progLangsLevel', 'langs', 'langsComprehension', 'langsReading', 'langsWriting'];
	foreach ($inputFields as $key) {
		if (!isset($_POST[$key]) || empty($_POST[$key])) {
			return false;
		}
	}
	return true;
}

function validated()
{
	global $errorMessages;
	$isValid = true;
	$namePattern = '/^[A-Za-z]{2,20}$/'; //This should actually include letters from all languages, hiphens, apostrophe, etc.
	$companyPattern = '/^[A-Za-z0-9\s]{2,20}$/';
	$datePattern = '/^[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1])$/';
	$phonePattern = '/^\+?(\s?\-?\d+)+$/';

	if (!preg_match($namePattern, $_POST['fName'])) {
		$isValid = false;
		$errorMessages[] = 'Invalid First Name. Names should contain between 2 and 20 symbols - letters only!';
	}
	if (!preg_match($namePattern, $_POST['lName'])) {
		$isValid = false;
		$errorMessages[] = 'Invalid Last Name. Names should contain between 2 and 20 symbols - letters only!';
	}
	if (!filter_var($_POST['email'], FILTER_VALIDATE_EMAIL)) {
		$isValid = false;
		$errorMessages[] = 'Invalid email format!';
	}
	if (!preg_match($phonePattern, $_POST['phone'])) {
		$isValid = false;
		$errorMessages[] = 'Invalid phone format!';
	}
	if (!preg_match($datePattern, $_POST['bdate'])) {
		$isValid = false;
		$errorMessages[] = 'Invalid birth date format!';
	}
	if (!preg_match($companyPattern, $_POST['companyName'])) {
		$isValid = false;
		$errorMessages[] = 'Invalid Company Name. Name should contain between 2 and 20 symbols - letters and digits only!';
	}
	if (!preg_match($datePattern, $_POST['fromDate'])) {
		$isValid = false;
		$errorMessages[] = 'Invalid \'From\' date format!';
	}
	if (!preg_match($datePattern, $_POST['toDate'])) {
		$isValid = false;
		$errorMessages[] = 'Invalid \'To\' date format!';
	}

	return $isValid;
}
?>

<script src="js/addRemoveItem.js"></script>
</body>
</html>