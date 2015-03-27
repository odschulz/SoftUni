<!DOCTYPE html>
<html>
<head>
    <title>Sum of All Values</title>
    <meta charset="utf-8" />
</head>
<body>
<form method="GET" action="sum-of-all-values.php">
    <label for="keys">
        Keys string:
        <br/>
        <input type="text" name="keys" id="keys" value="startKEY12adghfgh243212gadghfgs43endKEY"/>
    </label>
    <br/>
    <br/>
    <label for="text">
        Text string:
        <br/>
        <textarea rows="6" cols="40" name="text" id="text">
asdjykulgfjddfsffdstartKEY12endKEYqwfrhtyu67543rewghy3tefdgdstartKEY123.45endKEYwret34yrestartKEY2.6endKEY213434ytuhrgerweasfdstartKEYendKEYstartKEYasfdgeendKEY
        </textarea>
    </label>
    <br/>
    <br/>
    <input type="submit"/>
</form>

<?php
$keys = $_GET['keys'];
$text = $_GET['text'];
$keyPattern = '/^([A-Za-z_]+)\d+.+\d+([A-Za-z\_]+)$/';
preg_match($keyPattern, $keys, $matches);
if (empty($matches[0])) {
    echo '<p>A key is missing</p>';
    die;
}
$startKey = $matches[1];
$endKey = $matches[2];
$result = 0;
$counter = 0;
$textPattern = '/' . $startKey . '([^'. $endKey . ']+)' . $endKey . '/';
preg_match_all($textPattern, $text, $values);
foreach ($values[1] as $value) {
    if (is_numeric($value)) {
        $counter ++;
        $result += $value;
    }
}
if ($counter == 0 || $result == 0) {
    echo '<p>The total value is: <em>nothing</em></p>';
} else {
    echo '<p>The total value is: <em>' . $result . '</em></p>';
}

?>
</body>
</html>