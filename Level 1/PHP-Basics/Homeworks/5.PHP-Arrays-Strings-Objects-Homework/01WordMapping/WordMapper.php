<!DOCTYPE html>
<html>
	<head>
        <meta charset="UTF-8">
		<title>Word Mapping</title>
		<link rel="stylesheet" type="text/css" href="styles/styles.css"/>
	</head>
<body>

<section>
	<p class="message">Sample input: The quick brows fox.!!! jumped over..// the lazy dog.!</p>
	<form action="" method="post">
		<div>
			<textarea name="text" required="required"></textarea>
		</div>
		<input type="submit" value="Count words">
	</form>
	<?php
	if (isset($_POST['text']) && !empty($_POST['text'])) :
		$text = $_POST['text'];
		$words = str_word_count(strtolower($text), 1);
		$frequency = array_count_values($words);
	?>
	<table>
		<thead>
			<tr>
				<th colspan="2">With php functions:</th>
			</tr>
			<tr>
				<th>Word</th>
				<th>Count</th>
			</tr>
		</thead>
		<tbody>
		<?php foreach ($frequency as $key => $value) : ?>
			<tr>
				<td><?php echo htmlentities($key) ?></td>
				<td><?php echo htmlentities($value) ?></td>
			</tr>
		<?php endforeach; ?>
		</tbody>
	</table>

	<!-- This is another way of doing it, using regex and an associative array -->

	<?php
	$words = preg_split('/[^A-Za-z\'-]/', strtolower($text), -1, PREG_SPLIT_NO_EMPTY);
	$frequency = [];
	foreach ($words as $word) {
		if (!isset($frequency[$word])) {
			$frequency[$word] = 1;
		} else {
			$frequency[$word] ++;
		}
	}
	?>

	<table>
		<thead>
			<tr>
				<th colspan="2">Without php functions:</th>
			</tr>
			<tr>
				<th>Word</th>
				<th>Count</th>
			</tr>
		</thead>
		<tbody>
		<?php foreach ($frequency as $key => $value) : ?>
			<tr>
				<td><?php echo htmlentities($key) ?></td>
				<td><?php echo htmlentities($value) ?></td>
			</tr>
		<?php endforeach; ?>
		</tbody>
	</table>
	<?php endif; ?>
	
</section>

</body>
</html>