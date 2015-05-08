<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Modify String</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<form action="" method="post">
		<input type="text" name="string" id="input" value="<?= isset($_POST['string']) ? htmlentities($_POST['string']) : '';?>">
		<input type="radio" name="operation" value="palindrome" id="palindrome">
		<label for="palindrome">Check Palindrome</label>
		<input type="radio" name="operation" value="reverse" id="reverse">
		<label for="reverse">Reverse String</label>
		<input type="radio" name="operation" value="split" id="split">
		<label for="split">Split</label>
		<input type="radio" name="operation" value="hash" id="hash">
		<label for="hash">Hash String</label>
		<input type="radio" name="operation" value="shuffle" id="shuffle">
		<label for="shuffle">Shuffle String</label>
		<input type="submit" onclick="keepValue()">
	</form>
	<?php
	if (isset($_POST['string']) && !empty($_POST['string']) && isset($_POST['operation'])) :
		$input = $_POST['string'];
		$operation = $_POST['operation'];
		$output;
		switch ($operation) {
			case 'palindrome':
				isPalindrome($input) ? $output = "{$input} is a palindrome!" : $output = "{$input} is not a palindrome!";
				break;
			case 'reverse':
				$output = reverseString($input);
				break;
			case 'split':
				$output = splitString($input);
				break;
			case 'hash':
				$output = hashString($input);
				break;
			case 'shuffle':
				$output = shuffleString($input);
				break;
			default:
				die('Invalid operation');
				break;
		}

	?>
	<div><?php echo htmlentities($output) ?></div>
	<?php endif; ?>
	
</section>

<?php
function isPalindrome($str)
{
	return $str == strrev($str);
}
function reverseString($str)
{
	return strrev($str);
}

function splitString($str)
{
	$input = preg_replace('/[^A-Za-z]/', '', $str);
	return implode(' ', str_split($input));
}
function hashString($str)
{
	return crypt($str);
}
function shuffleString($str)
{
	return str_shuffle($str);
}
?>
</body>
</html>