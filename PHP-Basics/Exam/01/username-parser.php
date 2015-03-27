<!DOCTYPE html>
<html>
<head>
    <title>Username Parser</title>
    <meta charset="utf-8" />
</head>
<body>
<form method="GET" action="username-parser.php">
    <label for="list">
        Username list:
        <br/>
        <textarea rows="10" cols="40" name="list" id="list">
Angel
Ivancho
Aha
Toni
Pesho
Gosho
        </textarea>
    </label>
    <br/>
    <br/>
    <label for="length">
        Minimum length:
        <br/>
        <input type="text" name="length" id="length" value="5"/>
    </label>
    <br/>
    <br/>
    <label for="show">
        Show all usernames?
        <input type="checkbox" name="show" id="show"/>
    </label>
    <br/>
    <br/>
    <input type="submit"/>
</form>

<?php
$input = $_GET['list'];
$length = intval($_GET['length']);
if (isset($_GET['show'])) {
	$show = true;
} else {
	$show = false;
}
$list = preg_split("/\s*\r?\n\s*/", $input, -1, PREG_SPLIT_NO_EMPTY);

echo '<ul>';
foreach ($list as $a) {
	$user = trim($a);
	if (isValid($user, $length)) {
		echo '<li>' . htmlspecialchars($user) . '</li>';
	} else if ($show) {
		echo '<li style="color: red;">' . htmlspecialchars($user) . '</li>';
	}

}
echo '</ul>';


function isValid($user, $length)
{
	if (strlen($user) >= $length) {
		return true;
	} else {
		return false;
	}
}


?>
</body>
</html>

